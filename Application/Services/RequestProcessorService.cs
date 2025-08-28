// Application/Services/RequestProcessorService.cs

using System.Threading.Channels;
using Application.Interfaces;
using Application.Messages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Application.Enums;
using System;
using System.Linq; // 👈 necesario por FirstOrDefault

namespace Application.Services
{
    public class RequestProcessorService : BackgroundService
    {
        private readonly ChannelReader<RequestMessage> _channelReader;
        private readonly ILogger<RequestProcessorService> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IEnumerable<IRequestProcessingStrategy> _strategies;
        private readonly RequestStatusTracker _tracker;

        public RequestProcessorService(
            Channel<RequestMessage> channel,
            ILogger<RequestProcessorService> logger,
            IServiceProvider serviceProvider,
            IEnumerable<IRequestProcessingStrategy> strategies,
            RequestStatusTracker tracker)
        {
            _channelReader = channel.Reader;
            _logger = logger;
            _serviceProvider = serviceProvider;
            _strategies = strategies;
            _tracker = tracker;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Servicio de procesamiento de peticiones iniciado.");

            await foreach (var requestMessage in _channelReader.ReadAllAsync(stoppingToken))
            {
                // (Opcional) quita estos delays en prod
                 await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);

                _tracker.UpdateStatus(requestMessage.Id, RequestState.Processing, "Petición en curso.");
                _logger.LogInformation("Procesando petición con Id: {Id}", requestMessage.Id);

                 await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);

                using var scope = _serviceProvider.CreateScope();
                var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();

                try
                {
                    var strategy = _strategies.FirstOrDefault(s => s.TableType == requestMessage.Table);

                    if (strategy is null)
                    {
                        _logger.LogWarning("No se encontró una estrategia para la tabla: {Table}", requestMessage.Table);
                        _tracker.UpdateStatus(requestMessage.Id, RequestState.Failed, "Estrategia de procesamiento no encontrada.");
                        continue; // 👈 evita marcar Completed más abajo
                    }

                    await strategy.ProcessRequestAsync(requestMessage, unitOfWork);

                    // Si el UseCase ya hace CompleteAsync por operación, deja esto comentado:
                    // await unitOfWork.CompleteAsync();

                    // 👇 Publica el resultado si existe; si no, completa sin payload
                    if (!string.IsNullOrWhiteSpace(requestMessage.ResultDataJson))
                    {
                        _tracker.SetResult(requestMessage.Id, requestMessage.ResultDataJson, "Petición completada exitosamente.");
                    }
                    else
                    {
                        _tracker.UpdateStatus(requestMessage.Id, RequestState.Completed, "Petición completada exitosamente.");
                    }

                    _logger.LogInformation("Petición {Id} completada exitosamente.", requestMessage.Id);
                }
                catch (Exception ex)
                {
                    _tracker.UpdateStatus(requestMessage.Id, RequestState.Failed, $"Error al procesar la petición: {ex.Message}");
                    _logger.LogError(ex, "Error al procesar la petición {Id}", requestMessage.Id);
                }
            }
        }
    }
}
