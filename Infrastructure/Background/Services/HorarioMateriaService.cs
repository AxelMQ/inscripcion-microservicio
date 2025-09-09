using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;                 // IUnitOfWork
using Domain.Entities;                        // HorarioMateria
using Shared.Contracts.Dtos.HorarioMateria;   // Create/Update/Dto

namespace Infrastructure.Background.Services
{
    public class HorarioMateriaService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public HorarioMateriaService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        // CREATE: devuelve DTO creado
        public async Task<HorarioMateriaDto> CreateAsync(HorarioMateriaCreateDto dto, CancellationToken ct)
        {
            var repo   = _uow.GetRepository<HorarioMateria>();
            var entity = _mapper.Map<HorarioMateria>(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            return _mapper.Map<HorarioMateriaDto>(entity);
        }

        // GET ALL: proyección directa (sin Include)
        public async Task<IEnumerable<HorarioMateriaDto>> GetAllAsync(CancellationToken ct)
        {
            var query = _uow.GetRepository<HorarioMateria>().Query()
                .AsNoTracking();

            var dtos = await query
                .ProjectTo<HorarioMateriaDto>(_mapper.ConfigurationProvider)
                .ToListAsync(ct);

            return dtos;
        }

        // GET BY ID: proyección directa y envuelve en { found, item }
        public async Task<object?> GetByIdAsync(int id, CancellationToken ct)
        {
            var query = _uow.GetRepository<HorarioMateria>().Query()
                .AsNoTracking()
                .Where(hm => hm.Id == id);

            var dto = await query
                .ProjectTo<HorarioMateriaDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(ct);

            return dto is null
                ? new { found = false }
                : new { found = true, item = dto };
        }

        // UPDATE (Id fuera del DTO): retorna { updated, item? }
        public async Task<object?> UpdateAsync(int id, HorarioMateriaUpdateDto dto, CancellationToken ct)
        {
            var repo = _uow.GetRepository<HorarioMateria>();
            var e    = await repo.GetByIdAsync(id, ct);
            if (e is null) return new { updated = false, reason = "NotFound" };

            _mapper.Map(dto, e);
            await repo.UpdateAsync(e, ct);
            await _uow.CompleteAsync(ct);

            var result = _mapper.Map<HorarioMateriaDto>(e);
            return new { updated = true, item = result };
        }

        // DELETE: retorna { deleted }
        public async Task<object?> DeleteAsync(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<HorarioMateria>();
            var e    = await repo.GetByIdAsync(id, ct);
            if (e is null) return new { deleted = false, reason = "NotFound" };

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return new { deleted = true };
        }
    }
}
