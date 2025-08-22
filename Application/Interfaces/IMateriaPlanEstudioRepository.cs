using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMateriaPlanEstudioRepository
    {
        Task<IEnumerable<MateriaPlanEstudio>> GetAllAsync();
        Task<MateriaPlanEstudio> GetByIdAsync(int materiaId, int planEstudioId);
        Task AddAsync(MateriaPlanEstudio materiaPlanEstudio);
        Task UpdateAsync(MateriaPlanEstudio materiaPlanEstudio);
        Task DeleteAsync(int materiaId, int planEstudioId);
    }
}