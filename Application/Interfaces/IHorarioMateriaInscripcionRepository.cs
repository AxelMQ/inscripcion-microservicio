using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHorarioMateriaInscripcionRepository
    {
        Task<IEnumerable<HorarioMateriaInscripcion>> GetAllAsync();
        Task<HorarioMateriaInscripcion> GetByIdAsync(int horarioMateriaId, int inscripcionId);
        Task AddAsync(HorarioMateriaInscripcion horarioMateriaInscripcion);
        Task UpdateAsync(HorarioMateriaInscripcion horarioMateriaInscripcion);
        Task DeleteAsync(int horarioMateriaId, int inscripcionId);
    }
}
