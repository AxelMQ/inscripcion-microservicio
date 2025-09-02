using Domain.Core;
using System.Linq.Expressions;

namespace Application.Interfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> Query(bool asNoTracking = true);

    // Existing methods
    Task<TEntity?> GetByIdAsync(int id, CancellationToken ct = default);
    Task<List<TEntity>> GetAllAsync(CancellationToken ct = default);

    // NEW: Method overloads for eager loading
    Task<TEntity?> GetByIdAsync(int id, CancellationToken ct, params Expression<Func<TEntity, object>>[] includes);
    Task<List<TEntity>> GetAllAsync(CancellationToken ct, params Expression<Func<TEntity, object>>[] includes);
    
    Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken ct = default);
    Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken ct = default);
    Task AddAsync(TEntity entity, CancellationToken ct = default);
    Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken ct = default);
    Task UpdateAsync(TEntity entity, CancellationToken ct = default);
    Task DeleteAsync(int id, CancellationToken ct = default);
}