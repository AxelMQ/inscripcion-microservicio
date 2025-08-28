using Application.Enums;
using Application.Messages;

namespace Application.Interfaces
{
    public interface IRequestProcessingStrategy
    {
        TableType TableType { get; }
        Task ProcessRequestAsync(RequestMessage request, IUnitOfWork unitOfWork);
    }
}