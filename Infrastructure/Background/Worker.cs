using System.Text.Json;
using Infrastructure.Data;
using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Application.Messages;
using Hangfire.Server;

namespace Infrastructure.Background
{
    public class Worker(IServiceProvider sp, AppDbContext db)
    {
        private readonly IServiceProvider _sp = sp;
        private readonly AppDbContext _db = db;
        private static readonly JsonSerializerOptions _json = new(JsonSerializerDefaults.Web);


        private async Task<JobResult> SetProcessingAsync(string jobId, CancellationToken ct)
        {
            var jr = await _db.JobResults.FindAsync(new object?[] { jobId }, ct)
                     ?? new JobResult { Id = jobId, CreatedUtc = DateTime.UtcNow, Status = "Pending" };

            jr.Status = "Processing";
            jr.Error = null;
            jr.DataJson = null;

            if (_db.Entry(jr).State == EntityState.Detached)
                _db.JobResults.Add(jr);

            await _db.SaveChangesAsync(ct);
            return jr;
        }

        private async Task SetCompletedAsync(JobResult jr, object? payload, CancellationToken ct)
        {
            jr.Status = "Completed";
            jr.DataJson = JsonSerializer.Serialize(payload, _json);
            jr.FinishedUtc = DateTime.UtcNow;
            await _db.SaveChangesAsync(ct);
        }

        private async Task SetFailedAsync(JobResult jr, Exception ex, CancellationToken ct)
        {
            jr.Status = "Failed";
            jr.Error = ex.Message;
            jr.FinishedUtc = DateTime.UtcNow;
            await _db.SaveChangesAsync(ct);
        }

        public async Task RunAsync(PerformContext? ctx, Job job, CancellationToken ct = default)
        {
            var jobId = ctx?.BackgroundJob?.Id ?? Guid.NewGuid().ToString("N");


            var jr = await SetProcessingAsync(jobId, ct);

            try
            {
                if (!JobRegistry.TryResolve(job.Resource, job.Operation, out var route))
                    throw new InvalidOperationException($"Operación no soportada: {job.Resource}.{job.Operation}");

                object? dto = null;

                if (route.DtoType != typeof(object))
                {
                    if (string.IsNullOrWhiteSpace(job.BodyJson))
                        throw new InvalidOperationException($"El body es vacío pero se esperaba {route.DtoType.Name} para {job.Resource}.{job.Operation}.");

                    dto = JsonSerializer.Deserialize(job.BodyJson, route.DtoType, _json)
                          ?? throw new InvalidOperationException($"No se pudo deserializar a {route.DtoType.FullName}. Body: {job.BodyJson}");
                }

                var result = await route.InvokeAsync(_sp, dto, ct);
                await SetCompletedAsync(jr, result, ct);
            }
            catch (Exception ex)
            {
                await SetFailedAsync(jr, ex, ct);
                throw;
            }
        }
    }
}