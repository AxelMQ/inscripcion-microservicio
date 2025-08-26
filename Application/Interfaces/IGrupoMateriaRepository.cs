using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGrupoMateriaRepository
    {
        Task<IEnumerable<GrupoMateria>> GetAllAsync();
        Task<GrupoMateria?> GetByIdAsync(int id);
        Task AddAsync(GrupoMateria grupoMateria);
        Task UpdateAsync(GrupoMateria grupoMateria);
        Task DeleteAsync(int id);
    }
}