// Api/Controllers/JobsController.cs
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Hangfire;
using Domain.Entities;
using Application.Data.Entities;

namespace Api.Controllers;

[ApiController]
[Route("api/jobs")]
[ApiExplorerSettings(GroupName = "async")] 
public class JobsController : ControllerBase
{
    private readonly IJobResultRepository _results;
    private readonly JobStorage _storage;

    public JobsController(IJobResultRepository results, JobStorage storage)
    {
        _results = results;
        _storage = storage;
    }

    // GET /api/jobs/{jobId}
    [HttpGet("{jobId}")]
    public async Task<IActionResult> GetStatusById([FromRoute] string jobId)
    {
        // 1) Tu tabla primero (trae data como JSON real)
        var jr = await _results.FindByIdAsync(jobId);
        if (jr is not null)
            return Ok(ToDto(jr));

        // 2) Fallback: Hangfire
        var dto = await QueryHangfireAsync(jobId);
        if (dto is null)
            return NotFound(new { jobId, message = "Job no encontrado." });

        return Ok(dto);
    }

    // GET /api/jobs/by-key/{idempotencyKey}
    [HttpGet("by-key/{key}")]
    public async Task<IActionResult> GetStatusByKey([FromRoute] string key)
    {
        var jr = await _results.FindLatestByIdempotencyAsync(key);
        if (jr is null)
            return NotFound(new { idempotencyKey = key, message = "No se encontró registro con esa clave." });

        return Ok(ToDto(jr));
    }

    // ---------- Helpers ----------

    private static object ToDto(JobResult jr)
    {
        // Intenta deserializar DataJson en un JsonElement para que salga como JSON
        JsonElement? data = null;
        if (!string.IsNullOrWhiteSpace(jr.DataJson))
        {
            try
            {
                data = JsonSerializer.Deserialize<JsonElement>(jr.DataJson);
            }
            catch
            {
                // Si no es JSON válido, lo devolvemos como string crudo
                // (puedes omitir esto si prefieres siempre null)
                return new
                {
                    jobId = jr.Id,
                    status = jr.Status.ToString(),
                    queue = jr.Queue,
                    resource = jr.Resource,
                    operation = jr.Operation,
                    createdUtc = jr.CreatedUtc,
                    startedUtc = jr.StartedUtc,
                    finishedUtc = jr.FinishedUtc,
                    data = jr.DataJson, // string fallback
                    error = jr.Error
                };
            }
        }

        return new
        {
            jobId = jr.Id,
            status = jr.Status.ToString(), // Pending | Processing | Completed | Failed
            queue = jr.Queue,
            resource = jr.Resource,
            operation = jr.Operation,
            createdUtc = jr.CreatedUtc,
            startedUtc = jr.StartedUtc,
            finishedUtc = jr.FinishedUtc,
            data, // <- JsonElement?, se serializa como JSON
            error = jr.Error
        };
    }

    private async Task<object?> QueryHangfireAsync(string jobId)
    {
        var monitor =  _storage.GetMonitoringApi();
        var details = monitor.JobDetails(jobId);
        if (details is null) return null;

        // último estado conocido por Hangfire
        var state = details.History?.FirstOrDefault()?.StateName ?? "Unknown";
        // intenta leer la cola desde las propiedades
        string? queue = null;
        if (details.Properties != null && details.Properties.TryGetValue("Queue", out var q))
            queue = q;

        // Mapea al enum de tu dominio si quieres unificar nombres
        var mapped = state switch
        {
            "Processing" => JobStatus.Processing.ToString(),
            "Succeeded"  => JobStatus.Completed.ToString(),
            "Failed"     => JobStatus.Failed.ToString(),
            "Enqueued"   => JobStatus.Pending.ToString(),
            _            => state
        };

        // Hangfire no tiene tus DataJson/Error, devolvemos estructura mínima
        return new
        {
            jobId,
            status = mapped,
            queue,
            resource = (string?)null,
            operation = (string?)null,
            createdUtc = (DateTime?)null,
            startedUtc = (DateTime?)null,
            finishedUtc = (DateTime?)null,
            data = (object?)null,
            error = (string?)null
        };
    }
}
