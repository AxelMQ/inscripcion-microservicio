using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHoraDiaHorarioRepository
    {
        Task<IEnumerable<HoraDiaHorario>> GetAllAsync();
        Task<HoraDiaHorario> GetByIdAsync(int horaDiaId, int horarioId);
        Task AddAsync(HoraDiaHorario horaDiaHorario);
        Task UpdateAsync(HoraDiaHorario horaDiaHorario);
        Task DeleteAsync(int horaDiaId, int horarioId);
    }
}
