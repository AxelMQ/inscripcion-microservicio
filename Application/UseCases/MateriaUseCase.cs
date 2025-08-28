// Application/UseCases/MateriaUseCase.cs
using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Enums;
using Application.Interfaces;
using Domain.Models;

namespace Application.UseCases
{
    public class MateriaUseCase : IUseCase<Materia>
    {
        public async Task<object?> HandleOperationAsync(
            OperationType operation,
            Materia materia,
            IUnitOfWork unitOfWork,
            CancellationToken ct = default)
        {
            var repo = unitOfWork.GetRepository<Materia>();

            switch (operation)
            {
                case OperationType.Insert:
                    await repo.AddAsync(materia, ct);
                    await unitOfWork.CompleteAsync(ct);
                    return materia; // devuelves la creada

                case OperationType.Update:
                    var existing = await repo.GetByIdAsync(materia.Id, ct)
                                   ?? throw new ArgumentException("La materia no fue encontrada para actualizar.");

                    existing.Nombre     = materia.Nombre;
                    existing.Sigla      = materia.Sigla;
                    existing.Credito    = materia.Credito;
                    existing.EsElectiva = materia.EsElectiva;

                    await repo.UpdateAsync(existing, ct);
                    await unitOfWork.CompleteAsync(ct);
                    return existing; // devuelves la actualizada

                case OperationType.Delete:
                    await repo.DeleteAsync(materia.Id, ct);
                    await unitOfWork.CompleteAsync(ct);
                    return null; // nada que devolver

                case OperationType.GetAll:
                    var all = await repo.GetAllAsync(ct);
                    return all; // IEnumerable<Materia>

                case OperationType.GetById:
                    var one = await repo.GetByIdAsync(materia.Id, ct)
                              ?? throw new ArgumentException("Materia no encontrada.");
                    return one; // Materia

                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), "Unsupported operation type.");
            }
        }
    }
}
