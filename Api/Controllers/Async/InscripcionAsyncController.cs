using System.Text.Json;
using Application.Enums;
using Application.Messages;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Inscripcion;
using Application.Interfaces;
using Domain.Entities;

namespace Api.Controllers.Async;

[ApiController]
[Route("api/async/inscripciones")]
[ApiExplorerSettings(GroupName = "async")]
public class InscripcionAsyncController : ControllerBase
{
    private static readonly JsonSerializerOptions _json = new(JsonSerializerDefaults.Web);
    private readonly IUnitOfWork _uow;

    public InscripcionAsyncController(IUnitOfWork uow)
    {
        _uow = uow;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] InscripcionCreateDto dto)
    {
        var job = new Job
        {
            Resource = "inscripcion",
            Operation = OperationType.Create,
            BodyJson = JsonSerializer.Serialize(dto, _json),
            Queue = "critical",
            CallbackUrl = "" // opcional
        };
        job.GenerateIdempotencyKey();

        // Crear el DTO del job con el IdempotencyKey
        var jobDto = new InscripcionJobDto
        {
            Dto = dto,
            IdempotencyKey = job.IdempotencyKey
        };

        // Actualizar el BodyJson con el nuevo DTO
        job.BodyJson = JsonSerializer.Serialize(jobDto, _json);

        // Encolar job en Hangfire invocando Worker.RunAsync
        var jobId = BackgroundJob.Enqueue<Infrastructure.Background.Worker>(w => w.RunAsync(null, job, CancellationToken.None));

        // Crear JobResult
        var jobResult = new JobResult
        {
            Id = jobId,
            IdempotencyKey = job.IdempotencyKey,
            Queue = job.Queue,
            Resource = job.Resource,
            Operation = job.Operation.ToString(),
            Status = JobStatus.Pending,
            DataJson = JsonSerializer.Serialize(jobDto, _json),
            CreatedUtc = DateTime.UtcNow
        };

        var jobRepo = _uow.GetRepository<JobResult>();
        await jobRepo.AddAsync(jobResult);
        await _uow.CompleteAsync();

        return Accepted(new { jobId, idempotencyKey = job.IdempotencyKey });
    }
}


