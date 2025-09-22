using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Data.Entities
{
  public interface IJobResultRepository
  {
    Task<JobResult?> FindByIdAsync(string jobId);
    Task<JobResult?> FindLatestByIdempotencyAsync(string idempotencyKey);
    Task AddAsync(JobResult entity);
    Task SaveChangesAsync();
  }

}
