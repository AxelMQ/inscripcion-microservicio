// Application/UseCases/StudentUseCase.cs

using Application.Enums;
using Application.Interfaces;
using Domain.Models; // La entidad de tu dominio
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class MateriaUseCase : IUseCase<Materia>
    {
        public async Task HandleOperationAsync(OperationType operation, Materia materia, IUnitOfWork unitOfWork)
        {
            // Obtén el repositorio genérico para la entidad Materia.
            var materiaRepository = unitOfWork.GetRepository<Materia>();

            switch (operation)
            {
                case OperationType.Insert:
                    materiaRepository.Add(materia);
                    break;

                case OperationType.Update:
                    // Es mejor actualizar la entidad existente para mantener la consistencia.
                    var existingAlumno = await materiaRepository.GetByIdAsync(materia.ID);
                    if (existingAlumno == null)
                    {
                        throw new ArgumentException("El materia no fue encontrado para actualizar.");
                    }
                    
                    // Aquí actualizas las propiedades del objeto existente.
                    existingAlumno.NOMBRE = materia.NOMBRE;
                    existingAlumno.SIGLA = materia.SIGLA;
                    existingAlumno.CREDITO = materia.CREDITO;
                    existingAlumno.ES_ELECTIVA = materia.ES_ELECTIVA;

                    // El repositorio no llama a SaveChangesAsync
                    materiaRepository.Update(existingAlumno); 
                    break;

                case OperationType.Delete:
                    // Asume que la entidad solo necesita el ID para ser eliminada
                    materiaRepository.Delete(materia.ID);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), "Unsupported operation type.");
            }
        }
    }
}