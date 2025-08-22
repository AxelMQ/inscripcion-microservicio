using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class HoraDiaRepository : IHoraDiaRepository
    {
        private readonly AppDbContext _context;
        public HoraDiaRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<HoraDia>> GetAllAsync() => await _context.HoraDia.ToListAsync();
        public async Task<HoraDia?> GetByIdAsync(int horaId, int diaId) => await _context.HoraDia.FindAsync(horaId, diaId);
        public async Task AddAsync(HoraDia horaDia) { _context.HoraDia.Add(horaDia); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(HoraDia horaDia) { _context.Entry(horaDia).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int horaId, int diaId) { var horaDia = await _context.HoraDia.FindAsync(horaId, diaId); if (horaDia != null) { _context.HoraDia.Remove(horaDia); await _context.SaveChangesAsync(); } }
    }
}