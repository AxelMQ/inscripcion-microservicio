using Infrastructure.Background;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/hangfire")]
    public class HangfireControlController : ControllerBase
    {
        private readonly HangfireServerManager _mgr;

        public HangfireControlController(HangfireServerManager mgr) => _mgr = mgr;

        [HttpPost("start")]
        public IActionResult Start()
        {
            _mgr.Start();
            return Ok(new { running = _mgr.IsRunning });
        }

        [HttpPost("stop")]
        public IActionResult Stop()
        {
            _mgr.Stop();
            return Ok(new { running = _mgr.IsRunning });
        }

        [HttpGet("status")]
        public IActionResult Status()
            => Ok(new { running = _mgr.IsRunning });
    }
}
