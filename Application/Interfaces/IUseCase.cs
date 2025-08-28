using Application.Enums;
using Domain.Core; // Asumiendo que tus entidades de dominio heredan de una clase base

namespace Application.Interfaces
{
    public interface IUseCase<TEntity> where TEntity : BaseEntity // Asume que tus entidades tienen una clase base
    {
        Task HandleOperationAsync(OperationType operation, TEntity entity, IUnitOfWork unitOfWork);
    }
}