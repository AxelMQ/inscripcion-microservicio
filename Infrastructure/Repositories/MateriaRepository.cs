using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MateriaRepository : IMateriaRepository
    {
        private readonly AppDbContext _context;
        public MateriaRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Materia>> GetAllAsync() => await _context.Materia.ToListAsync();
        public async Task<Materia?> GetByIdAsync(int id) => await _context.Materia.FindAsync(id);
        public async Task AddAsync(Materia materia) { _context.Materia.Add(materia); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Materia materia) { _context.Entry(materia).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var materia = await _context.Materia.FindAsync(id); if (materia != null) { _context.Materia.Remove(materia); await _context.SaveChangesAsync(); } }
    }
}