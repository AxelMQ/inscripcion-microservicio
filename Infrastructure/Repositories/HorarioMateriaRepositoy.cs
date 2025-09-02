// Infrastructure/Repositories/HorarioMateriaRepository.cs
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class HorarioMateriaRepository : Repository<HorarioMateria>, IHorarioMateriaRepository
    {
        private readonly AppDbContext _ctx;

        public HorarioMateriaRepository(AppDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        private IQueryable<HorarioMateria> GetQueryWithDetails()
        {
            return _ctx.Set<HorarioMateria>()
                .Include(hm => hm.Gestion)
                .Include(hm => hm.Docente)
                .Include(hm => hm.GrupoMateria)
                    .ThenInclude(gm => gm.Materia)
                .Include(hm => hm.GrupoMateria)
                    .ThenInclude(gm => gm.Grupo)
                .Include(hm => hm.Horario)
                    .ThenInclude(h => h.HorasDiaHorario)
                        .ThenInclude(hdh => hdh.HoraDia)
                            .ThenInclude(hd => hd.Dia)
                .Include(hm => hm.Horario)
                    .ThenInclude(h => h.HorasDiaHorario)
                        .ThenInclude(hdh => hdh.HoraDia)
                            .ThenInclude(hd => hd.Hora)
                .AsNoTracking();
        }

        public async Task<HorarioMateria?> GetByIdWithDetailsAsync(int id, CancellationToken ct = default)
        {
            return await GetQueryWithDetails().FirstOrDefaultAsync(hm => hm.Id == id, ct);
        }

        public async Task<List<HorarioMateria>> GetAllWithDetailsAsync(CancellationToken ct = default)
        {
            return await GetQueryWithDetails().ToListAsync(ct);
        }
    }
}