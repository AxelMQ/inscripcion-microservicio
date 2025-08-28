using Application.Enums;
using Application.Interfaces;
using Application.Messages;
using Application.UseCases;
using Domain.Models;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.Strategies
{
    public class MateriaProcessingStrategy : IRequestProcessingStrategy
    {
        public TableType TableType => TableType.Materias;

        public async Task ProcessRequestAsync(RequestMessage requestMessage, IUnitOfWork unitOfWork)
        {
            var materia = JsonSerializer.Deserialize<Materia>(requestMessage.BodyJson);

            // Verificación explícita de nulidad.
            if (materia == null)
            {
                throw new ArgumentException("El cuerpo de la petición no contiene datos de Materia válidos.");
            }

            var materiaUseCase = new MateriaUseCase();
            
            // Ahora, el compilador sabe que 'materia' no es nulo aquí.
            await materiaUseCase.HandleOperationAsync(requestMessage.Operation, materia, unitOfWork);
        }
    }
}