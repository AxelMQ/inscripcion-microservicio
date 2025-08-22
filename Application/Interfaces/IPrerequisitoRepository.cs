using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPrerequisitoRepository
    {
        Task<IEnumerable<Prerequisito>> GetAllAsync();
        // Se corrige el tipo de retorno para que sea opcional y la clave compuesta
        Task<Prerequisito?> GetByIdAsync(int materiaPlanEstudioId, int requisitoId);
        Task AddAsync(Prerequisito prerequisito);
        Task UpdateAsync(Prerequisito prerequisito);
        // Se corrige el método DeleteAsync para que coincida con el repositorio
        Task DeleteAsync(int materiaPlanEstudioId, int requisitoId);
    }
}
