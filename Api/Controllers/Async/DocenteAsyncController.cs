// Api/Controllers/DocenteAsyncController.cs
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Hangfire.States;
using Infrastructure.Background;
using Domain.Entities;                // JobResult, JobStatus
using Application.Enums;
using Application.Messages;
using Shared.Contracts.Dtos.Alumno;
using Application.Data.Entities;
using Shared.Contracts.Dtos.Docente;

namespace Api.Controllers.Async;

[ApiController]
[Route("api/{queue}/[controller]")]
[ApiExplorerSettings(GroupName = "async")]
public class DocenteAsyncController : ControllerBase
{
  private static readonly JsonSerializerOptions _json = new(JsonSerializerDefaults.Web);

  private readonly HotHangfireServerManager _queues;
  private readonly IJobResultRepository _results;

  public DocenteAsyncController(HotHangfireServerManager queues, IJobResultRepository results)
  {
    _queues = queues;
    _results = results;
  }

  // GET /api/queues/{queue}/alumno
  [HttpGet]
  public Task<IActionResult> GetAll([FromRoute] string queue)
      => EnqueueNoBody(queue, OperationType.GetAll, "https://mi-callback/alumno/getall");

  // POST /api/queues/{queue}/alumno
  [HttpPost]
  public Task<IActionResult> Create([FromRoute] string queue, [FromBody] DocenteCreateDto dto)
      => EnqueueWithBody(queue, OperationType.Create, "https://mi-callback/alumno/create", dto);

  // GET /api/queues/{queue}/alumno/{id}
  [HttpGet("{id:int}")]
  public Task<IActionResult> GetById([FromRoute] string queue, [FromRoute] int id)
      => EnqueueWithBody(queue, OperationType.GetById, "https://mi-callback/alumno/getbyid", new { id });

  // PUT /api/queues/{queue}/alumno/{id}
  [HttpPut("{id:int}")]
  public Task<IActionResult> Update([FromRoute] string queue, [FromRoute] int id, [FromBody] DocenteUpdateDto dto)
      => EnqueueWithBody(queue, OperationType.Update, "https://mi-callback/alumno/update", new { id, dto });

  // DELETE /api/queues/{queue}/alumno/{id}
  [HttpDelete("{id:int}")]
  public Task<IActionResult> Delete([FromRoute] string queue, [FromRoute] int id)
      => EnqueueWithBody(queue, OperationType.Delete, "https://mi-callback/alumno/delete", new { id });

  // ---------- Helpers ----------

  private Task<IActionResult> EnqueueNoBody(string queue, OperationType op, string cb)
  {
    var job = NewJob(queue, op, cb, bodyJson: null);
    return EnqueueCore(job);
  }

  private Task<IActionResult> EnqueueWithBody(string queue, OperationType op, string cb, object body)
  {
    var bodyJson = JsonSerializer.Serialize(body, _json); // serialización estable
    var job = NewJob(queue, op, cb, bodyJson);
    return EnqueueCore(job);
  }

  private Job NewJob(string queue, OperationType op, string callback, string? bodyJson)
  {
    var job = new Job
    {
      Operation = op,
      Resource = "docente",
      BodyJson = bodyJson,
      Queue = NormalizeQueue(queue),
      CallbackUrl = callback
    };
    job.GenerateIdempotencyKey(); // IdempotencyKey = hash(op|resource|body)
    return job;
  }

  private async Task<IActionResult> EnqueueCore(Job job)
  {
    var key = job.IdempotencyKey!;

    // 1) ¿Existe un job ACTIVO (Pending/Processing) con esta key?
    var latest = await _results.FindLatestByIdempotencyAsync(key);
    if (latest is not null &&
        (latest.Status == JobStatus.Pending || latest.Status == JobStatus.Processing))
    {
      return Accepted(new
      {
        jobId = latest.Id,
        status = latest.Status.ToString(),
        queue = latest.Queue,
        idempotencyKey = key,
        reused = true
      });
    }

    // 2) No hay activo: encolamos uno NUEVO (misma key, sin sufijos)
    var jobId = _queues.Enqueue<Worker>(job.Queue, w => w.RunAsync(null, job, CancellationToken.None));

    await _results.AddAsync(new JobResult
    {
      Id = jobId,
      IdempotencyKey = key,
      Queue = job.Queue,
      Resource = job.Resource,
      Operation = job.Operation.ToString(),
      Status = JobStatus.Pending,
      DataJson = job.BodyJson,
      CreatedUtc = DateTime.UtcNow
    });
    await _results.SaveChangesAsync();

    return Accepted(new { jobId, queue = job.Queue, idempotencyKey = key, reused = false });
  }

  private static string NormalizeQueue(string q)
      => string.IsNullOrWhiteSpace(q) ? EnqueuedState.DefaultQueue : q.Trim().ToLowerInvariant();
}
