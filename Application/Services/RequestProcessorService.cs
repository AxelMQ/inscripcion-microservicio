// Application/Services/RequestProcessorService.cs

using System.Threading.Channels;
using Application.Interfaces;
using Application.Messages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Application.Enums; // Asegúrate de tener este using
using System;

namespace Application.Services
{
    public class RequestProcessorService : BackgroundService
    {
        private readonly ChannelReader<RequestMessage> _channelReader;
        private readonly ILogger<RequestProcessorService> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IEnumerable<IRequestProcessingStrategy> _strategies;
        private readonly RequestStatusTracker _tracker; // <-- Agrega la inyección del tracker

        public RequestProcessorService(
            Channel<RequestMessage> channel,
            ILogger<RequestProcessorService> logger,
            IServiceProvider serviceProvider,
            IEnumerable<IRequestProcessingStrategy> strategies,
            RequestStatusTracker tracker) // <-- Agrega el tracker al constructor
        {
            _channelReader = channel.Reader;
            _logger = logger;
            _serviceProvider = serviceProvider;
            _strategies = strategies;
            _tracker = tracker; // <-- Inicializa el campo del tracker
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Servicio de procesamiento de peticiones iniciado.");

            await foreach (var requestMessage in _channelReader.ReadAllAsync(stoppingToken))
            {
                // Paso 1: Actualiza el estado a 'Processing' cuando la petición se saca de la cola.
                _tracker.UpdateStatus(requestMessage.Id, RequestState.Processing, "Petición en curso.");
                _logger.LogInformation("Procesando petición con ID: {Id}", requestMessage.Id);

                using var scope = _serviceProvider.CreateScope();
                var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                
                try
                {
                    var strategy = _strategies.FirstOrDefault(s => s.TableType == requestMessage.Table);
                    
                    if (strategy != null)
                    {
                        await strategy.ProcessRequestAsync(requestMessage, unitOfWork);
                        await unitOfWork.CompleteAsync();
                    }
                    else
                    {
                        _logger.LogWarning("No se encontró una estrategia para la tabla: {Table}", requestMessage.Table);
                        // Paso 2: Actualiza el estado a 'Failed' si la estrategia no se encuentra.
                        _tracker.UpdateStatus(requestMessage.Id, RequestState.Failed, "Estrategia de procesamiento no encontrada.");
                    }

                    // Paso 3: Actualiza el estado a 'Completed' si todo el procesamiento fue exitoso.
                    _tracker.UpdateStatus(requestMessage.Id, RequestState.Completed, "Petición completada exitosamente.");
                    _logger.LogInformation("Petición {Id} completada exitosamente.", requestMessage.Id);
                }
                catch (Exception ex)
                {
                    // Paso 4: Actualiza el estado a 'Failed' si ocurre una excepción durante el procesamiento.
                    _tracker.UpdateStatus(requestMessage.Id, RequestState.Failed, $"Error al procesar la petición: {ex.Message}");
                    _logger.LogError(ex, "Error al procesar la petición {Id}", requestMessage.Id);
                }
            }
        }
    }
}