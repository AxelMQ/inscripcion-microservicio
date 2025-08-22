using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class HoraRepository : IHoraRepository
    {
        private readonly AppDbContext _context;
        public HoraRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<Hora>> GetAllAsync() => await _context.Hora.ToListAsync();
        public async Task<Hora?> GetByIdAsync(int id) => await _context.Hora.FindAsync(id);
        public async Task AddAsync(Hora hora) { _context.Hora.Add(hora); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Hora hora) { _context.Entry(hora).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var hora = await _context.Hora.FindAsync(id); if (hora != null) { _context.Hora.Remove(hora); await _context.SaveChangesAsync(); } }
    }
}