using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPlanEstudioRepository
    {
        Task<IEnumerable<PlanEstudio>> GetAllAsync();
        Task<PlanEstudio> GetByIdAsync(int id);
        Task AddAsync(PlanEstudio planEstudio);
        Task UpdateAsync(PlanEstudio planEstudio);
        Task DeleteAsync(int id);
    }
}