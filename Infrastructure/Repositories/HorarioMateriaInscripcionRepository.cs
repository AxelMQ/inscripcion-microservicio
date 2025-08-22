using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class HorarioMateriaInscripcionRepository : IHorarioMateriaInscripcionRepository
    {
        private readonly AppDbContext _context;
        public HorarioMateriaInscripcionRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<HorarioMateriaInscripcion>> GetAllAsync() => await _context.HorarioMateriaInscripcion.ToListAsync();
        public async Task<HorarioMateriaInscripcion?> GetByIdAsync(int horarioMateriaId, int inscripcionId) => await _context.HorarioMateriaInscripcion.FindAsync(horarioMateriaId, inscripcionId);
        public async Task AddAsync(HorarioMateriaInscripcion horarioMateriaInscripcion) { _context.HorarioMateriaInscripcion.Add(horarioMateriaInscripcion); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(HorarioMateriaInscripcion horarioMateriaInscripcion) { _context.Entry(horarioMateriaInscripcion).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int horarioMateriaId, int inscripcionId) { var hmi = await _context.HorarioMateriaInscripcion.FindAsync(horarioMateriaId, inscripcionId); if (hmi != null) { _context.HorarioMateriaInscripcion.Remove(hmi); await _context.SaveChangesAsync(); } }
    }
}
