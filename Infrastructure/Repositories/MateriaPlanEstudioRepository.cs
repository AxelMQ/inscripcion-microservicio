using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MateriaPlanEstudioRepository : IMateriaPlanEstudioRepository
    {
        private readonly AppDbContext _context;
        public MateriaPlanEstudioRepository(AppDbContext context) { _context = context; }
        public async Task<IEnumerable<MateriaPlanEstudio>> GetAllAsync() => await _context.MateriaPlanEstudio.ToListAsync();
        public async Task<MateriaPlanEstudio?> GetByIdAsync(int materiaId, int planEstudioId) => await _context.MateriaPlanEstudio.FindAsync(materiaId, planEstudioId);
        public async Task AddAsync(MateriaPlanEstudio materiaPlanEstudio) { _context.MateriaPlanEstudio.Add(materiaPlanEstudio); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(MateriaPlanEstudio materiaPlanEstudio) { _context.Entry(materiaPlanEstudio).State = EntityState.Modified; await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int materiaId, int planEstudioId) { var mpe = await _context.MateriaPlanEstudio.FindAsync(materiaId, planEstudioId); if (mpe != null) { _context.MateriaPlanEstudio.Remove(mpe); await _context.SaveChangesAsync(); } }
    }
}