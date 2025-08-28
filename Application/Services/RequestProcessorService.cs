// Application/Services/RequestProcessorService.cs

using System.Threading.Channels;
using Application.Interfaces;
using Application.Messages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Application.Services
{
    public class RequestProcessorService : BackgroundService
    {
        private readonly ChannelReader<RequestMessage> _channelReader;
        private readonly ILogger<RequestProcessorService> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IEnumerable<IRequestProcessingStrategy> _strategies;

        public RequestProcessorService(
            Channel<RequestMessage> channel,
            ILogger<RequestProcessorService> logger,
            IServiceProvider serviceProvider,
            IEnumerable<IRequestProcessingStrategy> strategies)
        {
            _channelReader = channel.Reader;
            _logger = logger;
            _serviceProvider = serviceProvider;
            _strategies = strategies;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Servicio de procesamiento de peticiones iniciado.");

            await foreach (var requestMessage in _channelReader.ReadAllAsync(stoppingToken))
            {
                _logger.LogInformation("Procesando petición con ID: {Id}", requestMessage.Id);

                using var scope = _serviceProvider.CreateScope();
                var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                
                try
                {
                    // No hay necesidad de actualizar el estado en la base de datos, ya que no se persiste.

                    // 1. Deserializa el cuerpo y ejecuta la estrategia
                    var strategy = _strategies.FirstOrDefault(s => s.TableType == requestMessage.Table);
                    
                    if (strategy != null)
                    {
                        await strategy.ProcessRequestAsync(requestMessage, unitOfWork);

                        // 2. Si la estrategia se ejecuta sin errores, confirma los cambios en la base de datos.
                        await unitOfWork.CompleteAsync();
                    }
                    else
                    {
                        _logger.LogWarning("No se encontró una estrategia para la tabla: {Table}", requestMessage.Table);
                    }

                    // No hay necesidad de actualizar el estado a 'Completed' en la base de datos.
                    _logger.LogInformation("Petición {Id} completada exitosamente.", requestMessage.Id);
                }
                catch (Exception ex)
                {
                    // No hay necesidad de actualizar el estado a 'Failed' en la base de datos.
                    _logger.LogError(ex, "Error al procesar la petición {Id}", requestMessage.Id);

                    // Si hubo un error, la transacción del Unit of Work se descartará al salir del bloque 'using'.
                }
            }
        }
    }
}