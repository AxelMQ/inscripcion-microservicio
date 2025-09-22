using Hangfire;
using Hangfire.Server;
using Hangfire.States;
using Microsoft.Extensions.Configuration;
using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace Infrastructure.Background
{
    /// Manager para operar Hangfire "en caliente":
    /// - StartQueue(queue, workers): arranca un servidor dedicado a esa cola
    /// - StopQueue(queue): detiene el servidor de esa cola
    /// - ScaleQueue(queue, workers): re-inicia el servidor con nuevo WorkerCount
    /// - Enqueue(queue, expr): encola un job en una cola específica
    public class HotHangfireServerManager : IDisposable
    {
        private readonly JobStorage _storage;
        private readonly int _defaultRetryAttempts;
        private readonly int[] _defaultRetryDelays;
        private readonly ConcurrentDictionary<string, BackgroundJobServer> _servers = new();

        public HotHangfireServerManager(JobStorage storage, IConfiguration config)
        {
            _storage = storage;

            // reintentos/backoff globales (se ejecuta una sola vez por proceso)
            var retryAttempts = config.GetValue<int?>("Hangfire:RetryAttempts") ?? 5;
            var retryDelays = config.GetSection("Hangfire:RetryDelays").Get<int[]>()
                                ?? new[] { 15, 60, 300, 600, 900 };

            _defaultRetryAttempts = retryAttempts;
            _defaultRetryDelays = retryDelays;

            GlobalJobFilters.Filters.Add(new AutomaticRetryAttribute
            {
                Attempts = _defaultRetryAttempts,
                OnAttemptsExceeded = AttemptsExceededAction.Fail,
                DelaysInSeconds = _defaultRetryDelays
            });
        }

        public bool IsQueueRunning(string queue) => _servers.ContainsKey(Normalize(queue));

        public void StartQueue(string queue, int workers)
        {
            queue = Normalize(queue);
            if (_servers.ContainsKey(queue)) return;

            var opts = new BackgroundJobServerOptions
            {
                Queues = new[] { queue },         // servidor dedicado a esa cola
                WorkerCount = Math.Max(1, workers),
                ServerName = $"srv-{queue}-{Guid.NewGuid():N}"
            };

            var server = new BackgroundJobServer(opts, _storage);
            if (!_servers.TryAdd(queue, server))
            {
                // si falló el add, cerramos el server recién creado
                server.Dispose();
            }
        }

        public void StopQueue(string queue)
        {
            queue = Normalize(queue);
            if (_servers.TryRemove(queue, out var server))
            {
                server.SendStop();
                server.Dispose();
            }
        }

        public void ScaleQueue(string queue, int workers)
        {
            // re-inicia el server de la cola con otro WorkerCount
            StopQueue(queue);
            StartQueue(queue, workers);
        }

        // Encola en una cola específica
        public string Enqueue(string queue, Expression<Action> job)
        {
            var client = new BackgroundJobClient(_storage);
            return client.Create(job, new EnqueuedState(Normalize(queue)));
        }

        // Overload genérico por si usas DI con interfaces/clases
        public string Enqueue<T>(string queue, Expression<Action<T>> job)
        {
            var client = new BackgroundJobClient(_storage);
            return client.Create(job, new EnqueuedState(Normalize(queue)));
        }

        private static string Normalize(string q) =>
            string.IsNullOrWhiteSpace(q) ? EnqueuedState.DefaultQueue : q.Trim().ToLowerInvariant();

        public void Dispose()
        {
            foreach (var s in _servers.Values)
            {
                try { s.SendStop(); s.Dispose(); } catch { /* swallow */ }
            }
            _servers.Clear();
        }
    }
}
