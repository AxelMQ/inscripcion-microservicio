using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHoraDiaRepository
    {
        Task<IEnumerable<HoraDia>> GetAllAsync();
        Task<HoraDia?> GetByIdAsync(int horaId, int diaId);
        Task AddAsync(HoraDia horaDia);
        Task UpdateAsync(HoraDia horaDia);
        Task DeleteAsync(int horaId, int diaId);
    }
}
