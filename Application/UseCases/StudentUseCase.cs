// Application/UseCases/StudentUseCase.cs

using System;
using System.Threading.Tasks;
using Application.Enums;
using Application.Interfaces;
using Domain.Models;

namespace Application.UseCases
{
    public class StudentUseCase : IUseCase<Alumno>
    {
        public async Task HandleOperationAsync(
            OperationType operation,
            Alumno alumno,
            IUnitOfWork unitOfWork)
        {
            var alumnoRepository = unitOfWork.GetRepository<Alumno>();

            switch (operation)
            {
                case OperationType.Insert:
                    await alumnoRepository.AddAsync(alumno);
                    break;

                case OperationType.Update:
                    var existingAlumno = await alumnoRepository.GetByIdAsync(alumno.Id);
                    if (existingAlumno is null)
                        throw new ArgumentException("El alumno no fue encontrado para actualizar.");

                    // Copia de propiedades según tu dominio
                    existingAlumno.Nombre   = alumno.Nombre;
                    existingAlumno.Ppa      = alumno.Ppa;
                    existingAlumno.Telefono = alumno.Telefono;
                    existingAlumno.Registro = alumno.Registro;

                    await alumnoRepository.UpdateAsync(existingAlumno);
                    break;

                case OperationType.Delete:
                    await alumnoRepository.DeleteAsync(alumno.Id);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), "Unsupported operation type.");
            }

            // Confirmar cambios de la unidad de trabajo
            await unitOfWork.CompleteAsync();
        }
    }
}
