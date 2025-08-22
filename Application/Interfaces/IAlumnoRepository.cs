using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAlumnoRepository
    {
        Task<IEnumerable<Alumno>> GetAllAsync();
        Task<Alumno> GetByIdAsync(int id);
        Task AddAsync(Alumno alumno);
        Task UpdateAsync(Alumno alumno);
        Task DeleteAsync(int id);
    }
}
