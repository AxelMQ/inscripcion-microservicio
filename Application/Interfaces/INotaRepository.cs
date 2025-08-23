using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface INotaRepository
    {
        Task<IEnumerable<Nota>> GetAllAsync();
        Task<Nota> GetByIdAsync(int id);
        Task AddAsync(Nota nivel);
        Task UpdateAsync(Nota nivel);
        Task DeleteAsync(int id);
    }
}