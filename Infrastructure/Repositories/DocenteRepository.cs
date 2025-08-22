using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DocenteRepository : IDocenteRepository
    {
        private readonly AppDbContext _context;
        public DocenteRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Docente>> GetAllAsync() => await _context.Docente.ToListAsync();
        public async Task<Docente?> GetByIdAsync(int id) => await _context.Docente.FindAsync(id);
        public async Task AddAsync(Docente docente) { _context.Docente.Add(docente); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Docente docente) { _context.Entry(docente).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var docente = await _context.Docente.FindAsync(id); if (docente != null) { _context.Docente.Remove(docente); await _context.SaveChangesAsync(); } }
    }
}
