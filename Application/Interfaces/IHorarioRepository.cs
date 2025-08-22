using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHorarioRepository
    {
        Task<IEnumerable<Horario>> GetAllAsync();
        Task<Horario> GetByIdAsync(int id);
        Task AddAsync(Horario horario);
        Task UpdateAsync(Horario horario);
        Task DeleteAsync(int id);
    }
}
