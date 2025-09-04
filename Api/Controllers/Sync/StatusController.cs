// Api/Controllers/StatusController.cs
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;


namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/status")]
    public class StatusController : ControllerBase
    {
        private readonly AppDbContext _db;

        public StatusController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStatus(string id, CancellationToken ct)
        {
            var status = await _db.JobResults.FirstOrDefaultAsync(x => x.Id == id, ct);
            if (status is null)
                return NotFound(new { message = "Id de petición no encontrado." });

            object? resultData = null;
            if (!string.IsNullOrWhiteSpace(status.DataJson))
            {
                try
                {
                    resultData = JsonSerializer.Deserialize<object>(status.DataJson);
                }
                catch
                {
                    resultData = status.DataJson; // fallback si no es JSON válido
                }
            }

            return Ok(new
            {
                jobId = status.Id,
                status = status.Status,
                error = status.Error,
                resultData,
                createdUtc = status.CreatedUtc,
                finishedUtc = status.FinishedUtc
            });
        }
    }
}
