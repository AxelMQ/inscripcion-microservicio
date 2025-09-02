using AutoMapper; // Necesitas agregar esta directiva using
using System.Text.Json;
using Application.Enums;
using Application.Interfaces;
using Application.Messages;
using Application.UseCases;
using Domain.Entities;
using Shared.Contracts.Dtos.HorarioMateria;

namespace Application.Strategies
{
    public class HorarioMateriaProcessingStrategy : IRequestProcessingStrategy
    {
        public TableType TableType => TableType.HorarioMaterias;

        private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web)
        {
            PropertyNameCaseInsensitive = true
        };

        private readonly IMapper _mapper; // Inyecta el mapper aquí

        // Constructor para inyectar el mapper
        public HorarioMateriaProcessingStrategy(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task ProcessRequestAsync(RequestMessage requestMessage, IUnitOfWork unitOfWork)
        {
            var useCase = new HorarioMateriaUseCase();
            object? result = null;

            switch (requestMessage.Operation)
            {
                case OperationType.Insert:
                    {
                        var dto = JsonSerializer.Deserialize<HorarioMateriaCreateDto>(requestMessage.BodyJson, JsonOptions)
                                  ?? throw new ArgumentException("JSON inválido para creación de HorarioMateria.");

                        // Usa el mapper para convertir el DTO en la entidad
                        var materia = _mapper.Map<HorarioMateria>(dto);

                        result = await useCase.HandleOperationAsync(OperationType.Insert, materia, unitOfWork);
                        break;
                    }

                case OperationType.Update:
                    {
                        var dto = JsonSerializer.Deserialize<HorarioMateriaUpdateDto>(requestMessage.BodyJson, JsonOptions)
                                  ?? throw new ArgumentException("JSON inválido para actualización de HorarioMateria.");

                        // Usa el mapper para convertir el DTO en la entidad
                        var materia = _mapper.Map<HorarioMateria>(dto);

                        result = await useCase.HandleOperationAsync(OperationType.Update, materia, unitOfWork);
                        break;
                    }

                case OperationType.Delete:
                    {
                        var dto = JsonSerializer.Deserialize<HorarioMateriaDeleteDto>(requestMessage.BodyJson, JsonOptions)
                                  ?? throw new ArgumentException("JSON inválido para eliminación de HorarioMateria.");

                        // Usa el mapper para convertir el DTO en la entidad
                        var materia = _mapper.Map<HorarioMateria>(dto);

                        result = await useCase.HandleOperationAsync(OperationType.Delete, materia, unitOfWork);
                        break;
                    }

                case OperationType.GetAll:
                    {
                        var materia = new HorarioMateria();
                        var all = await useCase.HandleOperationAsync(OperationType.GetAll, materia, unitOfWork);
                        // Mapea la colección de entidades a una colección de DTOs antes de serializar
                        result = _mapper.Map<IEnumerable<HorarioMateriaDto>>(all);
                        break;
                    }
                case OperationType.GetById:
                    {
                        var idOnly = JsonSerializer.Deserialize<IdOnlyDto>(requestMessage.BodyJson, JsonOptions);
                        var materia = new HorarioMateria { Id = idOnly!.Id };
                        var one = await useCase.HandleOperationAsync(OperationType.GetById, materia, unitOfWork);
                        // Mapea la entidad individual a un DTO antes de serializar
                        result = _mapper.Map<HorarioMateriaDto>(one);
                        break;
                    }


                default:
                    throw new ArgumentOutOfRangeException(nameof(requestMessage.Operation), "Operación no soportada.");
            }

            // ⬇️ guardar el resultado como JSON para el tracker/callback
            // Opcional: si el resultado es una entidad, también podrías mapearla a un DTO aquí
            // if (result is HorarioMateria materiaResult)
            // {
            //     requestMessage.ResultDataJson = JsonSerializer.Serialize(_mapper.Map<MateriaDto>(materiaResult), JsonOptions);
            // }
            // else
            // {
            //     requestMessage.ResultDataJson = result is null ? null : JsonSerializer.Serialize(result, JsonOptions);
            // }
            requestMessage.ResultDataJson = result is null ? null : JsonSerializer.Serialize(result, JsonOptions);
        }

        private sealed record IdOnlyDto(int Id);
    }
}