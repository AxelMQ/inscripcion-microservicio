using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DiaRepository : IDiaRepository
    {
        private readonly AppDbContext _context;
        public DiaRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Dia>> GetAllAsync() => await _context.Dia.ToListAsync();
        public async Task<Dia?> GetByIdAsync(int id) => await _context.Dia.FindAsync(id);
        public async Task AddAsync(Dia dia) { _context.Dia.Add(dia); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Dia dia) { _context.Entry(dia).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var dia = await _context.Dia.FindAsync(id); if (dia != null) { _context.Dia.Remove(dia); await _context.SaveChangesAsync(); } }
    }
}