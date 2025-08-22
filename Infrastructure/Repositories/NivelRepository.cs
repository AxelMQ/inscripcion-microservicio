using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class NivelRepository : INivelRepository
    {
        private readonly AppDbContext _context;
        public NivelRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Nivel>> GetAllAsync() => await _context.Nivel.ToListAsync();
        public async Task<Nivel?> GetByIdAsync(int id) => await _context.Nivel.FindAsync(id);
        public async Task AddAsync(Nivel nivel) { _context.Nivel.Add(nivel); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Nivel nivel) { _context.Entry(nivel).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var nivel = await _context.Nivel.FindAsync(id); if (nivel != null) { _context.Nivel.Remove(nivel); await _context.SaveChangesAsync(); } }
    }
}
