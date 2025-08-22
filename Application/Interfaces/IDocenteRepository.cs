using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDocenteRepository
    {
        Task<IEnumerable<Docente>> GetAllAsync();
        Task<Docente> GetByIdAsync(int id);
        Task AddAsync(Docente docente);
        Task UpdateAsync(Docente docente);
        Task DeleteAsync(int id);
    }
}