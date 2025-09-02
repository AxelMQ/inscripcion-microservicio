using Application.Enums;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class HorarioMateriaUseCase : IUseCase<HorarioMateria>
    {
        public async Task<object?> HandleOperationAsync(
            OperationType operation,
            HorarioMateria horarioMateria,
            IUnitOfWork unitOfWork,
            CancellationToken ct = default)
        {
            // Get the specific IHorarioMateriaRepository from the unit of work.
            // This allows you to call the dedicated methods for eager loading.
            var repo = unitOfWork.GetRepository<HorarioMateria>() as IHorarioMateriaRepository
                       ?? throw new InvalidOperationException("The repository does not implement IHorarioMateriaRepository.");

            switch (operation)
            {
                case OperationType.Insert:
                    if (horarioMateria == null) return null;
                    await repo.AddAsync(horarioMateria, ct);
                    await unitOfWork.CompleteAsync(ct);
                    return horarioMateria;

                case OperationType.Update:
                    if (horarioMateria == null) return null;
                    // For the update, you only need the basic entity, so you can use the generic method.
                    var existingUpdate = await repo.GetByIdAsync(horarioMateria.Id, ct)
                                     ?? throw new ArgumentException("La horarioMateria no fue encontrada para actualizar.");

                    existingUpdate.CuposDisponibles = horarioMateria.CuposDisponibles;
                    existingUpdate.CuposTotal = horarioMateria.CuposTotal;
                    existingUpdate.GrupoMateriaId = horarioMateria.GrupoMateriaId;
                    existingUpdate.GestionId = horarioMateria.GestionId;
                    existingUpdate.DocenteId = horarioMateria.DocenteId;
                    existingUpdate.HorarioId = horarioMateria.HorarioId;

                    await repo.UpdateAsync(existingUpdate, ct);
                    await unitOfWork.CompleteAsync(ct);
                    return existingUpdate;

                case OperationType.Delete:
                    if (horarioMateria == null) return null;
                    await repo.DeleteAsync(horarioMateria.Id, ct);
                    await unitOfWork.CompleteAsync(ct);
                    return null;

                case OperationType.GetAll:
                    // Now, you call the specific method for getting all records with details.
                    var all = await repo.GetAllWithDetailsAsync(ct);
                    return all;

                case OperationType.GetById:
                    if (horarioMateria == null) return null;
                    // You call the specific method for getting a single record with details.
                    var one = await repo.GetByIdWithDetailsAsync(horarioMateria.Id, ct)
                                  ?? throw new ArgumentException("HorarioMateria no encontrada.");
                    return one;

                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), "Unsupported operation type.");
            }
        }
    }
}