// Infrastructure/Background/Worker.cs
using System.Text.Json;
using Infrastructure.Data;
using Application.Messages;
using Hangfire.Server;
using Domain.Entities;
using System.ComponentModel;

namespace Infrastructure.Background
{
    public class Worker(IServiceProvider sp, AppDbContext db)
    {
        private readonly IServiceProvider _sp = sp;
        private readonly AppDbContext _db = db;
        private static readonly JsonSerializerOptions _json = new(JsonSerializerDefaults.Web);

        private async Task<JobResult> SetProcessingAsync(PerformContext? ctx, Job job, CancellationToken ct)
        {
            var jobId = ctx?.BackgroundJob?.Id
                        ?? throw new InvalidOperationException("PerformContext is required to resolve Hangfire JobId.");

            var jr = await _db.JobResults.FindAsync(new object?[] { jobId }, ct);
            if (jr is null)
            {
                jr = new JobResult
                {
                    Id = jobId,
                    IdempotencyKey = job.IdempotencyKey ?? string.Empty,
                    Queue = job.Queue ?? string.Empty,
                    Resource = job.Resource,
                    Operation = job.Operation.ToString(),
                    Status = JobStatus.Pending,   // <- corregido
                    CreatedUtc = DateTime.UtcNow
                };
                _db.JobResults.Add(jr);
            }

            if (!string.IsNullOrWhiteSpace(job.Queue))
                jr.Queue = job.Queue;

            jr.Status = JobStatus.Processing;
            jr.Error = null;
            jr.DataJson = null;
            jr.StartedUtc = DateTime.UtcNow;

            await _db.SaveChangesAsync(ct);
            return jr;
        }

        private async Task SetCompletedAsync(JobResult jr, object? payload, CancellationToken ct)
        {
            jr.Status = JobStatus.Completed;
            jr.DataJson = payload is null ? null : JsonSerializer.Serialize(payload, _json);
            jr.FinishedUtc = DateTime.UtcNow;
            await _db.SaveChangesAsync(ct);
        }

        private async Task SetFailedAsync(JobResult jr, Exception ex, CancellationToken ct)
        {
            jr.Status = JobStatus.Failed;
            jr.Error = ex.Message;
            jr.FinishedUtc = DateTime.UtcNow;
            await _db.SaveChangesAsync(ct);
        }
        [DisplayName("Procesar {1}")]
        public async Task RunAsync(PerformContext? ctx, Job job, CancellationToken ct = default)
        {
            var jr = await SetProcessingAsync(ctx, job, ct);
            try
            {
                if (!JobRegistry.TryResolve(job.Resource, job.Operation, out var route))
                    throw new InvalidOperationException($"Operación no soportada: {job.Resource}.{job.Operation}");

                object? dto = null;
                if (route.DtoType != typeof(object))
                {
                    if (string.IsNullOrWhiteSpace(job.BodyJson))
                        throw new InvalidOperationException($"Se esperaba {route.DtoType.Name} para {job.Resource}.{job.Operation}.");

                    dto = JsonSerializer.Deserialize(job.BodyJson, route.DtoType, _json)
                          ?? throw new InvalidOperationException($"No se pudo deserializar a {route.DtoType.FullName}.");
                }

                var result = await route.InvokeAsync(_sp, dto, ct);
                await SetCompletedAsync(jr, result, ct);
            }
            catch (Exception ex)
            {
                await SetFailedAsync(jr, ex, ct);
                throw; // deja que Hangfire maneje retries
            }
        }
    }
}
