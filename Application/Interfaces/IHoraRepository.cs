using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHoraRepository
    {
        Task<IEnumerable<Hora>> GetAllAsync();
        Task<Hora?> GetByIdAsync(int id);
        Task AddAsync(Hora hora);
        Task UpdateAsync(Hora hora);
        Task DeleteAsync(int id);
    }
}
