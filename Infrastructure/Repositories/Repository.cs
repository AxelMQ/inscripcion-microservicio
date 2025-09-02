// Infrastructure/Repositories/Repository.cs
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

    public IQueryable<TEntity> Query(bool asNoTracking = true)
        => asNoTracking ? _db.AsNoTracking() : _db;

    public Task<TEntity?> GetByIdAsync(int id, CancellationToken ct = default)
        => _db.FindAsync([id], ct).AsTask();

    // NUEVO: Método para obtener por ID con carga de relaciones
    public async Task<TEntity?> GetByIdAsync(int id, CancellationToken ct, params Expression<Func<TEntity, object>>[] includes)
    {
        IQueryable<TEntity> query = _db.AsNoTracking();
        foreach (var include in includes)
        {
            query = query.Include(include);
        }
        return await query.FirstOrDefaultAsync(e => e.Id == id, ct);
    }
    
    public Task<List<TEntity>> GetAllAsync(CancellationToken ct = default)
        => _db.AsNoTracking().ToListAsync(ct);

    // NUEVO: Método para obtener todos los registros con carga de relaciones
    public async Task<List<TEntity>> GetAllAsync(CancellationToken ct, params Expression<Func<TEntity, object>>[] includes)
    {
        IQueryable<TEntity> query = _db.AsNoTracking();
        foreach (var include in includes)
        {
            query = query.Include(include);
        }
        return await query.ToListAsync(ct);
    }

    public Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> p, CancellationToken ct = default)
        => _db.AsNoTracking().Where(p).ToListAsync(ct);

    public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> p, CancellationToken ct = default)
        => _db.AnyAsync(p, ct);

    public Task AddAsync(TEntity entity, CancellationToken ct = default)
        => _db.AddAsync(entity, ct).AsTask();

    public Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken ct = default)
        => _db.AddRangeAsync(entities, ct);

    public Task UpdateAsync(TEntity entity, CancellationToken ct = default)
    { 
        _db.Update(entity); 
        return Task.CompletedTask; 
    }

    public async Task DeleteAsync(int id, CancellationToken ct = default)
    {
        var entity = await _db.FindAsync([id], ct);
        if (entity is not null) _db.Remove(entity);
    }
}