using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PlanEstudioRepository : IPlanEstudioRepository
    {
        private readonly AppDbContext _context;
        public PlanEstudioRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<PlanEstudio>> GetAllAsync() => await _context.PlanEstudio.ToListAsync();
        public async Task<PlanEstudio?> GetByIdAsync(int id) => await _context.PlanEstudio.FindAsync(id);
        public async Task AddAsync(PlanEstudio planEstudio) { _context.PlanEstudio.Add(planEstudio); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(PlanEstudio planEstudio) { _context.Entry(planEstudio).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var planEstudio = await _context.PlanEstudio.FindAsync(id); if (planEstudio != null) { _context.PlanEstudio.Remove(planEstudio); await _context.SaveChangesAsync(); } }
    }
}