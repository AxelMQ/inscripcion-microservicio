using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDiaRepository
    {
        Task<IEnumerable<Dia>> GetAllAsync();
        Task<Dia?> GetByIdAsync(int id);
        Task AddAsync(Dia dia);
        Task UpdateAsync(Dia dia);
        Task DeleteAsync(int id);
    }
}