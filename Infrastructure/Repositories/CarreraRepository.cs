using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CarreraRepository : ICarreraRepository
    {
        private readonly AppDbContext _context;
        public CarreraRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Carrera>> GetAllAsync() => await _context.Carrera.ToListAsync();
        public async Task<Carrera?> GetByIdAsync(int id) => await _context.Carrera.FindAsync(id);
        public async Task AddAsync(Carrera carrera) { _context.Carrera.Add(carrera); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Carrera carrera) { _context.Entry(carrera).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var carrera = await _context.Carrera.FindAsync(id); if (carrera != null) { _context.Carrera.Remove(carrera); await _context.SaveChangesAsync(); } }
    }
}