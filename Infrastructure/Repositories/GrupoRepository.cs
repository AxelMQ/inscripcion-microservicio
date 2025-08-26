using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GrupoRepository : IGrupoRepository
    {
        private readonly AppDbContext _context;
        public GrupoRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Grupo>> GetAllAsync() => await _context.Grupo.ToListAsync();
        public async Task<Grupo?> GetByIdAsync(int id) => await _context.Grupo.FindAsync(id);
        public async Task AddAsync(Grupo grupo) { _context.Grupo.Add(grupo); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Grupo grupo) { _context.Entry(grupo).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var grupo = await _context.Grupo.FindAsync(id); if (grupo != null) { _context.Grupo.Remove(grupo); await _context.SaveChangesAsync(); } }
    }
}
