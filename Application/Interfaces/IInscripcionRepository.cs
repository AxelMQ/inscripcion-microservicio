using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IInscripcionRepository
    {
        Task<IEnumerable<Inscripcion>> GetAllAsync();
        Task<Inscripcion?> GetByIdAsync(int id);
        Task AddAsync(Inscripcion inscripcion);
        Task UpdateAsync(Inscripcion inscripcion);
        Task DeleteAsync(int id);
    }
}