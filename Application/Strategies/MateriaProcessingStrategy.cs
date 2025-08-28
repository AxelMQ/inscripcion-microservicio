// Application/Strategies/MateriaProcessingStrategy.cs
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Application.Enums;
using Application.Interfaces;
using Application.Messages;
using Application.UseCases;
using Domain.Models;
using Shared.Contracts.Dtos.Materia;

namespace Application.Strategies
{
    public class MateriaProcessingStrategy : IRequestProcessingStrategy
    {
        public TableType TableType => TableType.Materias;

        private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web)
        {
            PropertyNameCaseInsensitive = true
        };

        public async Task ProcessRequestAsync(RequestMessage requestMessage, IUnitOfWork unitOfWork)
        {
            var useCase = new MateriaUseCase();
            object? result = null;

            switch (requestMessage.Operation)
            {
                case OperationType.Insert:
                {
                    var dto = JsonSerializer.Deserialize<MateriaCreateDto>(requestMessage.BodyJson, JsonOptions)
                              ?? throw new ArgumentException("JSON inválido para creación de Materia.");
                    var materia = new Materia
                    {
                        Nombre = dto.Nombre!,
                        Sigla = dto.Sigla!,
                        Credito = dto.Credito,
                        EsElectiva = dto.EsElectiva
                    };
                    result = await useCase.HandleOperationAsync(OperationType.Insert, materia, unitOfWork);
                    break;
                }

                case OperationType.Update:
                {
                    var dto = JsonSerializer.Deserialize<MateriaUpdateDto>(requestMessage.BodyJson, JsonOptions)
                              ?? throw new ArgumentException("JSON inválido para actualización de Materia.");
                    var materia = new Materia
                    {
                        Id = dto.Id,
                        Nombre = dto.Nombre!,
                        Sigla = dto.Sigla!,
                        Credito = dto.Credito,
                        EsElectiva = dto.EsElectiva
                    };
                    result = await useCase.HandleOperationAsync(OperationType.Update, materia, unitOfWork);
                    break;
                }

                case OperationType.Delete:
                {
                    var dto = JsonSerializer.Deserialize<MateriaDeleteDto>(requestMessage.BodyJson, JsonOptions)
                              ?? throw new ArgumentException("JSON inválido para eliminación de Materia.");
                    var materia = new Materia { Id = dto.Id };
                    result = await useCase.HandleOperationAsync(OperationType.Delete, materia, unitOfWork);
                    break;
                }

                case OperationType.GetAll:
                {
                    // payload dummy
                    var materia = new Materia();
                    result = await useCase.HandleOperationAsync(OperationType.GetAll, materia, unitOfWork);
                    break;
                }

                case OperationType.GetById:
                {
                    var idOnly = JsonSerializer.Deserialize<IdOnlyDto>(requestMessage.BodyJson, JsonOptions)
                                 ?? throw new ArgumentException("JSON inválido para consulta por Id.");
                    var materia = new Materia { Id = idOnly.Id };
                    result = await useCase.HandleOperationAsync(OperationType.GetById, materia, unitOfWork);
                    break;
                }

                default:
                    throw new ArgumentOutOfRangeException(nameof(requestMessage.Operation), "Operación no soportada.");
            }

            // ⬇️ guardar el resultado como JSON para el tracker/callback
            requestMessage.ResultDataJson = result is null ? null : JsonSerializer.Serialize(result, JsonOptions);
        }

        private sealed record IdOnlyDto(int Id);
    }
}
