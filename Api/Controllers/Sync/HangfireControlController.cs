using Infrastructure.Background;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/hangfire")]
    [ApiExplorerSettings(GroupName = "async")]
    public class HangfireControlController : ControllerBase
    {
        private readonly HotHangfireServerManager _mgr;

        public HangfireControlController(HotHangfireServerManager mgr) => _mgr = mgr;

        // Arranca un servidor dedicado para la cola indicada con N workers
        // POST /api/hangfire/queues/reportes/start?workers=6
        [HttpPost("queues/{queue}/start")]
        public IActionResult StartQueue([FromRoute] string queue, [FromQuery] int workers = 1)
        {
            _mgr.StartQueue(queue, workers);
            return Ok(new { queue, workers, running = _mgr.IsQueueRunning(queue) });
        }

        // Cambia la capacidad de la cola (reinicia solo ese server con nuevo WorkerCount)
        // POST /api/hangfire/queues/reportes/scale?workers=12
        [HttpPost("queues/{queue}/scale")]
        public IActionResult ScaleQueue([FromRoute] string queue, [FromQuery] int workers)
        {
            _mgr.ScaleQueue(queue, workers);
            return Ok(new { queue, workers, scaled = true });
        }

        // Detiene el servidor dedicado de esa cola
        // POST /api/hangfire/queues/reportes/stop
        [HttpPost("queues/{queue}/stop")]
        public IActionResult StopQueue([FromRoute] string queue)
        {
            _mgr.StopQueue(queue);
            return Ok(new { queue, running = _mgr.IsQueueRunning(queue) });
        }

        // Estado rápido de una cola
        // GET /api/hangfire/queues/reportes/status
        [HttpGet("queues/{queue}/status")]
        public IActionResult QueueStatus([FromRoute] string queue)
            => Ok(new { queue, running = _mgr.IsQueueRunning(queue) });

        // Encola un job de demo en una cola específica (la cola se “crea” al encolar)
        // POST /api/hangfire/queues/reportes/demo
        [HttpPost("queues/{queue}/demo")]
        public IActionResult EnqueueDemo([FromRoute] string queue)
        {
            _mgr.Enqueue(queue, () => Console.WriteLine($"Job demo en '{queue}' @ {DateTime.UtcNow}"));
            return Accepted(new { queue, enqueued = true });
        }
    }
}
