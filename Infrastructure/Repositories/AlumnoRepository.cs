using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AlumnoRepository : IAlumnoRepository
    {
        private readonly AppDbContext _context;
        public AlumnoRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Alumno>> GetAllAsync() => await _context.Alumno.ToListAsync();
        public async Task<Alumno?> GetByIdAsync(int id) => await _context.Alumno.FindAsync(id);
        public async Task AddAsync(Alumno alumno) { _context.Alumno.Add(alumno); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Alumno alumno) { _context.Entry(alumno).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var alumno = await _context.Alumno.FindAsync(id); if (alumno != null) { _context.Alumno.Remove(alumno); await _context.SaveChangesAsync(); } }
    }
}
