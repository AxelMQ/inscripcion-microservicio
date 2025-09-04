using Hangfire;
using Hangfire.Server;
using Hangfire.States;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Background
{
    /// Controla en caliente el servidor de Hangfire y centraliza configuración operativa:
    /// - WorkerCount, Queues, RetryAttempts, RetryDelays (backoff)
    public class HangfireServerManager
    {
        private readonly JobStorage _storage;
        private readonly BackgroundJobServerOptions _options;
        private BackgroundJobServer? _server;
        private readonly object _gate = new();

        public HangfireServerManager(JobStorage storage, IConfiguration config)
        {
            _storage = storage;

            // Lee config (con defaults razonables)
            var workerCount = config.GetValue<int?>("Hangfire:WorkerCount")
                              ?? Environment.ProcessorCount;

            var queues = config.GetSection("Hangfire:Queues").Get<string[]>()
                        ?? new[] { EnqueuedState.DefaultQueue };

            var retryAttempts = config.GetValue<int?>("Hangfire:RetryAttempts") ?? 5;
            var retryDelays   = config.GetSection("Hangfire:RetryDelays").Get<int[]>()
                                ?? new[] { 15, 60, 300, 600, 900 };

            // Filtro global de reintentos + backoff (centralizado aquí)
            GlobalJobFilters.Filters.Add(new AutomaticRetryAttribute
            {
                Attempts = retryAttempts,
                OnAttemptsExceeded = AttemptsExceededAction.Fail,
                DelaysInSeconds = retryDelays
            });

            _options = new BackgroundJobServerOptions
            {
                WorkerCount = workerCount,
                Queues = queues
            };
        }

        public bool IsRunning { get { lock (_gate) return _server is not null; } }

        public void Start()
        {
            lock (_gate)
            {
                if (_server is not null) return;
                _server = new BackgroundJobServer(_options, _storage);
            }
        }

        public void Stop()
        {
            lock (_gate)
            {
                if (_server is null) return;
                _server.SendStop();
                _server.Dispose();
                _server = null;
            }
        }
    }
}
