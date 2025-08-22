using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PrerequisitoRepository : IPrerequisitoRepository
    {
        private readonly AppDbContext _context;
        public PrerequisitoRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Prerequisito>> GetAllAsync() => await _context.Prerequisito.ToListAsync();
        public async Task<Prerequisito?> GetByIdAsync(int materiaPlanEstudioId, int requisitoId) => await _context.Prerequisito.FindAsync(materiaPlanEstudioId, requisitoId);
        public async Task AddAsync(Prerequisito prerequisito) { _context.Prerequisito.Add(prerequisito); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Prerequisito prerequisito) { _context.Entry(prerequisito).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int materiaPlanEstudioId, int requisitoId) { var prerequisito = await _context.Prerequisito.FindAsync(materiaPlanEstudioId, requisitoId); if (prerequisito != null) { _context.Prerequisito.Remove(prerequisito); await _context.SaveChangesAsync(); } }
    }
}