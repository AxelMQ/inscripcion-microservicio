using Domain.Core;

namespace Application.Interfaces;
public interface IUnitOfWork
{
     IHorarioMateriaRepository HorarioMateriaRepository { get; }
    IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;
    Task<int> CompleteAsync(CancellationToken ct = default);
}
