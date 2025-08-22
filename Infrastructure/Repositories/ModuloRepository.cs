using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ModuloRepository : IModuloRepository
    {
        private readonly AppDbContext _context;
        public ModuloRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Modulo>> GetAllAsync() => await _context.Modulo.ToListAsync();
        public async Task<Modulo?> GetByIdAsync(int id) => await _context.Modulo.FindAsync(id);
        public async Task AddAsync(Modulo modulo) { _context.Modulo.Add(modulo); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Modulo modulo) { _context.Entry(modulo).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var modulo = await _context.Modulo.FindAsync(id); if (modulo != null) { _context.Modulo.Remove(modulo); await _context.SaveChangesAsync(); } }
    }
}