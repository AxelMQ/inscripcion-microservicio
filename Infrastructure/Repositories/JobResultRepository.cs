using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Data.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
public class JobResultRepository : IJobResultRepository
{
    private readonly AppDbContext _db;
    public JobResultRepository(AppDbContext db) => _db = db;

    public Task<JobResult?> FindByIdAsync(string jobId)
        => _db.JobResults.AsNoTracking().FirstOrDefaultAsync(x => x.Id == jobId);

    public Task<JobResult?> FindLatestByIdempotencyAsync(string idempotencyKey)
        => _db.JobResults.AsNoTracking()
              .Where(x => x.IdempotencyKey == idempotencyKey)
              .OrderByDescending(x => x.CreatedUtc)
              .FirstOrDefaultAsync();

    public async Task AddAsync(JobResult entity) => await _db.JobResults.AddAsync(entity);
    public Task SaveChangesAsync() => _db.SaveChangesAsync();
}

}
