using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class HorarioMateriaRepository : IHorarioMateriaRepository
    {
        private readonly AppDbContext _context;
        public HorarioMateriaRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<HorarioMateria>> GetAllAsync() => await _context.HorarioMateria.ToListAsync();
        public async Task<HorarioMateria?> GetByIdAsync(int id) => await _context.HorarioMateria.FindAsync(id);
        public async Task AddAsync(HorarioMateria horarioMateria) { _context.HorarioMateria.Add(horarioMateria); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(HorarioMateria horarioMateria) { _context.Entry(horarioMateria).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var horarioMateria = await _context.HorarioMateria.FindAsync(id); if (horarioMateria != null) { _context.HorarioMateria.Remove(horarioMateria); await _context.SaveChangesAsync(); } }
    }
}