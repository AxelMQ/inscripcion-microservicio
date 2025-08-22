using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class HoraDiaHorarioRepository : IHoraDiaHorarioRepository
    {
        private readonly AppDbContext _context;
        public HoraDiaHorarioRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<HoraDiaHorario>> GetAllAsync() => await _context.HoraDiaHorario.ToListAsync();
        public async Task<HoraDiaHorario?> GetByIdAsync(int horaDiaId, int horarioId) => await _context.HoraDiaHorario.FindAsync(horaDiaId, horarioId);
        public async Task AddAsync(HoraDiaHorario horaDiaHorario) { _context.HoraDiaHorario.Add(horaDiaHorario); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(HoraDiaHorario horaDiaHorario) { _context.Entry(horaDiaHorario).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int horaDiaId, int horarioId) { var horaDiaHorario = await _context.HoraDiaHorario.FindAsync(horaDiaId, horarioId); if (horaDiaHorario != null) { _context.HoraDiaHorario.Remove(horaDiaHorario); await _context.SaveChangesAsync(); } }
    }
}