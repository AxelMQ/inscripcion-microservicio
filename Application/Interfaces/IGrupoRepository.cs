using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGrupoRepository
    {
        Task<IEnumerable<Grupo>> GetAllAsync();
        Task<Grupo?> GetByIdAsync(int id);
        Task AddAsync(Grupo grupo);
        Task UpdateAsync(Grupo grupo);
        Task DeleteAsync(int id);
    }
}