using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class NotaRepository : INotaRepository
    {
        private readonly AppDbContext _context;
        public NotaRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Nota>> GetAllAsync() => await _context.Nota.ToListAsync();
        public async Task<Nota?> GetByIdAsync(int id) => await _context.Nota.FindAsync(id);
        public async Task AddAsync(Nota nivel) { _context.Nota.Add(nivel); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Nota nivel) { _context.Entry(nivel).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var nivel = await _context.Nota.FindAsync(id); if (nivel != null) { _context.Nota.Remove(nivel); await _context.SaveChangesAsync(); } }
    }
}
