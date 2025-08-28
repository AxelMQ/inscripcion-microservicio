// Application/UseCases/MateriaUseCase.cs
using System;
using System.Threading.Tasks;
using Application.Enums;
using Application.Interfaces;
using Domain.Models;

namespace Application.UseCases
{
    public class MateriaUseCase : IUseCase<Materia>
    {
        public async Task HandleOperationAsync(
            OperationType operation,
            Materia materia,
            IUnitOfWork unitOfWork)
        {
            var repo = unitOfWork.GetRepository<Materia>();

            switch (operation)
            {
                case OperationType.Insert:
                    await repo.AddAsync(materia);
                    break;

                case OperationType.Update:
                    var existing = await repo.GetByIdAsync(materia.Id);
                    if (existing is null)
                        throw new ArgumentException("La materia no fue encontrada para actualizar.");

                    existing.Nombre = materia.Nombre;
                    existing.Sigla = materia.Sigla;
                    existing.Credito = materia.Credito;
                    existing.EsElectiva = materia.EsElectiva;

                    await repo.UpdateAsync(existing);
                    break;

                case OperationType.Delete:
                    await repo.DeleteAsync(materia.Id);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), "Unsupported operation type.");
            }

            await unitOfWork.CompleteAsync();
        }
    }
}
