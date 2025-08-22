using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGestionRepository
    {
        Task<IEnumerable<Gestion>> GetAllAsync();
        Task<Gestion> GetByIdAsync(int id);
        Task AddAsync(Gestion gestion);
        Task UpdateAsync(Gestion gestion);
        Task DeleteAsync(int id);
    }
}