using System.Text.Json;
using Application.Enums;
using Application.Messages;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Inscripcion;
using Application.Interfaces;
using Domain.Entities;
using Serilog;
using Microsoft.EntityFrameworkCore;

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
        try
        {
            Log.Information("📝 [HTTP 202] Iniciando proceso de inscripción asíncrona - AlumnoId: {AlumnoId}, HorarioMateriaId: {HorarioMateriaId}", 
                dto.AlumnoId, dto.HorarioMateriaId);

            // Validar ModelState
            if (!ModelState.IsValid)
            {
                Log.Warning("❌ [HTTP 400] Datos de inscripción inválidos - AlumnoId: {AlumnoId}, HorarioMateriaId: {HorarioMateriaId}", 
                    dto.AlumnoId, dto.HorarioMateriaId);
                return BadRequest(new { 
                    message = "Datos de inscripción inválidos",
                    errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage))
                });
            }

            var job = new Job
            {
                Resource = "inscripcion",
                Operation = OperationType.Create,
                BodyJson = JsonSerializer.Serialize(dto, _json),
                Queue = "critical",
                CallbackUrl = "" // opcional
            };
            job.GenerateIdempotencyKey();

            Log.Information("🔑 [HTTP 202] IdempotencyKey generado: {IdempotencyKey} - AlumnoId: {AlumnoId}", 
                job.IdempotencyKey, dto.AlumnoId);

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

            Log.Information("🚀 [HTTP 202] Job encolado en Hangfire - JobId: {JobId}, Queue: {Queue} - AlumnoId: {AlumnoId}", 
                jobId, job.Queue, dto.AlumnoId);

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

            Log.Information("✅ [HTTP 202] Inscripción asíncrona iniciada exitosamente - JobId: {JobId}, IdempotencyKey: {IdempotencyKey}, AlumnoId: {AlumnoId}, HorarioMateriaId: {HorarioMateriaId}", 
                jobId, job.IdempotencyKey, dto.AlumnoId, dto.HorarioMateriaId);

            return Accepted(new { 
                jobId, 
                idempotencyKey = job.IdempotencyKey,
                status = "PENDING",
                message = "Inscripción en proceso. Use el idempotencyKey para consultar el estado."
            });
        }
        catch (Exception ex)
        {
            Log.Error(ex, "💥 [HTTP 500] Error al procesar inscripción asíncrona - AlumnoId: {AlumnoId}, HorarioMateriaId: {HorarioMateriaId}", 
                dto.AlumnoId, dto.HorarioMateriaId);
            return StatusCode(500, new { 
                message = "Error interno del servidor al procesar inscripción",
                error = "Error de procesamiento asíncrono"
            });
        }
    }

    [HttpGet("{idempotencyKey}")]
    public async Task<IActionResult> GetStatus(string idempotencyKey)
    {
        try
        {
            Log.Information("🔍 [HTTP 200] Consultando estado de inscripción - IdempotencyKey: {IdempotencyKey}", idempotencyKey);

            var jobRepo = _uow.GetRepository<JobResult>();
            var jobResult = await jobRepo.Query()
                .FirstOrDefaultAsync(jr => jr.IdempotencyKey == idempotencyKey);

            if (jobResult == null)
            {
                Log.Warning("❌ [HTTP 404] Inscripción no encontrada - IdempotencyKey: {IdempotencyKey}", idempotencyKey);
                return NotFound(new { 
                    message = "Inscripción no encontrada",
                    idempotencyKey = idempotencyKey
                });
            }

            Log.Information("✅ [HTTP 200] Estado de inscripción consultado - IdempotencyKey: {IdempotencyKey}, Status: {Status}", 
                idempotencyKey, jobResult.Status);

            return Ok(new
            {
                idempotencyKey = jobResult.IdempotencyKey,
                status = jobResult.Status.ToString(),
                jobId = jobResult.Id,
                queue = jobResult.Queue,
                resource = jobResult.Resource,
                operation = jobResult.Operation,
                createdUtc = jobResult.CreatedUtc,
                startedUtc = jobResult.StartedUtc,
                finishedUtc = jobResult.FinishedUtc,
                error = jobResult.Error,
                data = jobResult.DataJson
            });
        }
        catch (Exception ex)
        {
            Log.Error(ex, "💥 [HTTP 500] Error al consultar estado de inscripción - IdempotencyKey: {IdempotencyKey}", idempotencyKey);
            return StatusCode(500, new { 
                message = "Error interno del servidor al consultar estado",
                error = "Error de consulta de estado"
            });
        }
    }
}




