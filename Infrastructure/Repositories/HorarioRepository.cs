using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class HorarioRepository : IHorarioRepository
    {
        private readonly AppDbContext _context;
        public HorarioRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Horario>> GetAllAsync() => await _context.Horario.ToListAsync();
        public async Task<Horario?> GetByIdAsync(int id) => await _context.Horario.FindAsync(id);
        public async Task AddAsync(Horario horario) { _context.Horario.Add(horario); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Horario horario) { _context.Entry(horario).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var horario = await _context.Horario.FindAsync(id); if (horario != null) { _context.Horario.Remove(horario); await _context.SaveChangesAsync(); } }
    }
}
