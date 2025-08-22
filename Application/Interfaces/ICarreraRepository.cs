using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICarreraRepository
    {
        Task<IEnumerable<Carrera>> GetAllAsync();
        Task<Carrera> GetByIdAsync(int id);
        Task AddAsync(Carrera carrera);
        Task UpdateAsync(Carrera carrera);
        Task DeleteAsync(int id);
    }
}