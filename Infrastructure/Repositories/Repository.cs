using Application.Interfaces;
using Domain.Core;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly AppDbContext _ctx;
    private readonly DbSet<TEntity> _db;

    public Repository(AppDbContext ctx) { _ctx = ctx; _db = ctx.Set<TEntity>(); }

    public Task<TEntity?> GetByIdAsync(int id, CancellationToken ct = default)
        => _db.FindAsync([id], ct).AsTask();

    public Task<List<TEntity>> GetAllAsync(CancellationToken ct = default)
        => _db.AsNoTracking().ToListAsync(ct);

    public Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> p, CancellationToken ct = default)
        => _db.AsNoTracking().Where(p).ToListAsync(ct);

    public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> p, CancellationToken ct = default)
        => _db.AnyAsync(p, ct);

    public Task AddAsync(TEntity entity, CancellationToken ct = default)
        => _db.AddAsync(entity, ct).AsTask();

    public Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken ct = default)
        => _db.AddRangeAsync(entities, ct);

    public Task UpdateAsync(TEntity entity, CancellationToken ct = default)
    { _db.Update(entity); return Task.CompletedTask; }

    public async Task DeleteAsync(int id, CancellationToken ct = default)
    {
        var entity = await _db.FindAsync([id], ct);
        if (entity is not null) _db.Remove(entity);
    }
}
