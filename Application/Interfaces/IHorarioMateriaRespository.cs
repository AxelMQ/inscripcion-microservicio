using Domain.Entities;

namespace Application.Interfaces
{
    public interface IHorarioMateriaRepository : IRepository<HorarioMateria>
    {
        Task<HorarioMateria?> GetByIdWithDetailsAsync(int id, CancellationToken ct = default);
        Task<List<HorarioMateria>> GetAllWithDetailsAsync(CancellationToken ct = default);
    }
}