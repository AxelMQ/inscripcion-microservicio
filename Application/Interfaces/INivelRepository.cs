using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface INivelRepository
    {
        Task<IEnumerable<Nivel>> GetAllAsync();
        Task<Nivel?> GetByIdAsync(int id);
        Task AddAsync(Nivel nivel);
        Task UpdateAsync(Nivel nivel);
        Task DeleteAsync(int id);
    }
}