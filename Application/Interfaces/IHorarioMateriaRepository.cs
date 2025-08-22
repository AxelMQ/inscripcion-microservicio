using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHorarioMateriaRepository
    {
        Task<IEnumerable<HorarioMateria>> GetAllAsync();
        // Se corrige el tipo de retorno para que sea opcional y coincida con el FindAsync en el repositorio
        Task<HorarioMateria?> GetByIdAsync(int id);
        Task AddAsync(HorarioMateria horarioMateria);
        Task UpdateAsync(HorarioMateria horarioMateria);
        // Se corrige el método DeleteAsync para que coincida con el repositorio
        Task DeleteAsync(int id);
    }
}