// Infrastructure/Repositories/UnitOfWork.cs

using Application.Interfaces;
using Domain.Core;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork, IAsyncDisposable, IDisposable
{
    private readonly AppDbContext _ctx;
    private readonly Dictionary<Type, object> _repos = new();
    private bool _disposed;
    
    // Propiedad para el repositorio específico de HorarioMateria
    public IHorarioMateriaRepository HorarioMateriaRepository { get; }

    public UnitOfWork(AppDbContext ctx)
    {
        _ctx = ctx;
        // Se crea el repositorio de HorarioMateria aquí y se lo asigna a la propiedad
        HorarioMateriaRepository = new HorarioMateriaRepository(_ctx);
    }

    public IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
    {
        // El Unit of Work ahora conoce los repositorios específicos
        if (typeof(TEntity) == typeof(HorarioMateria))
        {
            return (IRepository<TEntity>)HorarioMateriaRepository;
        }

        // El resto del método se mantiene igual para los repositorios genéricos
        if (_repos.TryGetValue(typeof(TEntity), out var repo))
            return (IRepository<TEntity>)repo;

        var repository = new Repository<TEntity>(_ctx);
        _repos.Add(typeof(TEntity), repository);
        return repository;
    }

    public Task<int> CompleteAsync(CancellationToken ct = default)
        => _ctx.SaveChangesAsync(ct);

    public object GetDbContext()
        => _ctx;

    public async ValueTask DisposeAsync() { if (_disposed) return; await _ctx.DisposeAsync(); _disposed = true; }
    public void Dispose() { if (_disposed) return; _ctx.Dispose(); _disposed = true; }
}