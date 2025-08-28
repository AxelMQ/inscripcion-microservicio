using Application.Enums;
using Domain.Core;

namespace Application.Interfaces
{
    public interface IUseCase<TEntity> where TEntity : BaseEntity
    {
        Task<object?> HandleOperationAsync(
            OperationType operation,
            TEntity entity,
            IUnitOfWork unitOfWork,
            CancellationToken ct = default);
    }
}
