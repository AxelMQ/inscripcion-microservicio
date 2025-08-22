using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GestionRepository : IGestionRepository
    {
        private readonly AppDbContext _context;
        public GestionRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Gestion>> GetAllAsync() => await _context.Gestion.ToListAsync();
        public async Task<Gestion?> GetByIdAsync(int id) => await _context.Gestion.FindAsync(id);
        public async Task AddAsync(Gestion gestion) { _context.Gestion.Add(gestion); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Gestion gestion) { _context.Entry(gestion).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var gestion = await _context.Gestion.FindAsync(id); if (gestion != null) { _context.Gestion.Remove(gestion); await _context.SaveChangesAsync(); } }
    }
}