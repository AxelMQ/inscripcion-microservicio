using Application.Interfaces;
using Domain.Core;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork, IAsyncDisposable, IDisposable
{
    private readonly AppDbContext _ctx;
    private readonly Dictionary<Type, object> _repos = new();
    private bool _disposed;

    public UnitOfWork(AppDbContext ctx) => _ctx = ctx;

    public IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
    {
        if (_repos.TryGetValue(typeof(TEntity), out var repo))
            return (IRepository<TEntity>)repo;

        var repository = new Repository<TEntity>(_ctx);
        _repos.Add(typeof(TEntity), repository);
        return repository;
    }

    public Task<int> CompleteAsync(CancellationToken ct = default)
        => _ctx.SaveChangesAsync(ct);

    public async ValueTask DisposeAsync() { if (_disposed) return; await _ctx.DisposeAsync(); _disposed = true; }
    public void Dispose() { if (_disposed) return; _ctx.Dispose(); _disposed = true; }
}
