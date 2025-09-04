using Hangfire;
using Hangfire.Server;
using Hangfire.States;

namespace Infrastructure.Background
{
    /// Controla el ciclo de vida del worker de Hangfire en caliente.
    public class HangfireServerManager
    {
        private readonly JobStorage _storage;
        private readonly BackgroundJobServerOptions _options;
        private BackgroundJobServer? _server;
        private readonly object _gate = new();

        public HangfireServerManager(JobStorage storage)
        {
            _storage = storage;
            _options = new BackgroundJobServerOptions
            {
                Queues = new[] { EnqueuedState.DefaultQueue }, // "default"
                WorkerCount = Environment.ProcessorCount       // ajusta si quieres
            };
        }

        public bool IsRunning
        {
            get { lock (_gate) return _server is not null; }
        }

        public void Start()
        {
            lock (_gate)
            {
                if (_server is not null) return; // ya está corriendo
                _server = new BackgroundJobServer(_options, _storage);
            }
        }

        public void Stop()
        {
            lock (_gate)
            {
                if (_server is null) return;
                _server.SendStop();   // parada ordenada
                _server.Dispose();    // libera recursos/hilos
                _server = null;
            }
        }
    }
}
