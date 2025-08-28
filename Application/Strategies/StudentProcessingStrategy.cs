using Application.Enums;
using Application.Interfaces;
using Application.Messages;
using Application.UseCases;
using Domain.Models;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.Strategies
{
    public class StudentProcessingStrategy : IRequestProcessingStrategy
    {
        public TableType TableType => TableType.Alumnos;

        public async Task ProcessRequestAsync(RequestMessage requestMessage, IUnitOfWork unitOfWork)
        {
            var alumno = JsonSerializer.Deserialize<Alumno>(requestMessage.BodyJson);

            // Verificación explícita de nulidad.
            if (alumno == null)
            {
                throw new ArgumentException("El cuerpo de la petición no contiene datos de Alumno válidos.");
            }

            var studentUseCase = new StudentUseCase();
            
            // Ahora, el compilador sabe que 'alumno' no es nulo aquí.
            await studentUseCase.HandleOperationAsync(requestMessage.Operation, alumno, unitOfWork);
        }
    }
}