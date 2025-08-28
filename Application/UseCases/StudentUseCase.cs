// Application/UseCases/StudentUseCase.cs

using Application.Enums;
using Application.Interfaces;
using Domain.Models; // La entidad de tu dominio
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class StudentUseCase : IUseCase<Alumno>
    {
        public async Task HandleOperationAsync(OperationType operation, Alumno alumno, IUnitOfWork unitOfWork)
        {
            // Obtén el repositorio genérico para la entidad Alumno.
            var alumnoRepository = unitOfWork.GetRepository<Alumno>();

            switch (operation)
            {
                case OperationType.Insert:
                    alumnoRepository.Add(alumno);
                    break;

                case OperationType.Update:
                    // Es mejor actualizar la entidad existente para mantener la consistencia.
                    var existingAlumno = await alumnoRepository.GetByIdAsync(alumno.ID);
                    if (existingAlumno == null)
                    {
                        throw new ArgumentException("El alumno no fue encontrado para actualizar.");
                    }
                    
                    // Aquí actualizas las propiedades del objeto existente.
                    existingAlumno.NOMBRE = alumno.NOMBRE;
                    existingAlumno.PPA = alumno.PPA;
                    existingAlumno.TELEFONO = alumno.TELEFONO;
                    existingAlumno.REGISTRO = alumno.REGISTRO;

                    // El repositorio no llama a SaveChangesAsync
                    alumnoRepository.Update(existingAlumno); 
                    break;

                case OperationType.Delete:
                    // Asume que la entidad solo necesita el ID para ser eliminada
                    alumnoRepository.Delete(alumno.ID);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), "Unsupported operation type.");
            }
        }
    }
}