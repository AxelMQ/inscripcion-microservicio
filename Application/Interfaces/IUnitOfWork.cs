using Domain.Core;

namespace Application.Interfaces;
public interface IUnitOfWork
{
    IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;
    Task<int> CompleteAsync(CancellationToken ct = default);
}
