using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class InscripcionRepository : IInscripcionRepository
    {
        private readonly AppDbContext _context;
        public InscripcionRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Inscripcion>> GetAllAsync() => await _context.Inscripcion.ToListAsync();
        public async Task<Inscripcion?> GetByIdAsync(int id) => await _context.Inscripcion.FindAsync(id);
        public async Task AddAsync(Inscripcion inscripcion) { _context.Inscripcion.Add(inscripcion); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Inscripcion inscripcion) { _context.Entry(inscripcion).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var inscripcion = await _context.Inscripcion.FindAsync(id); if (inscripcion != null) { _context.Inscripcion.Remove(inscripcion); await _context.SaveChangesAsync(); } }
    }
}
