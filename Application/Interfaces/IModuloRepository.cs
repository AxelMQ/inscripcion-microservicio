using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IModuloRepository
    {
        Task<IEnumerable<Modulo>> GetAllAsync();
        Task<Modulo?> GetByIdAsync(int id);
        Task AddAsync(Modulo modulo);
        Task UpdateAsync(Modulo modulo);
        Task DeleteAsync(int id);
    }
}