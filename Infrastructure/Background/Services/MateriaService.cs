// Infrastructure/Background/Services/AlumnoService.cs
using AutoMapper;
using Application.Interfaces;           // IUnitOfWork
using Domain.Entities;                  // Materia
using Shared.Contracts.Dtos.Materia;
namespace Infrastructure.Background.Services
{
    public class MateriaService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public MateriaService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<MateriaDto> CreateAsync(MateriaCreateDto dto, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var entity = _mapper.Map<Materia>(dto);          // DTO -> Entidad
            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);
            return _mapper.Map<MateriaDto>(entity);          // Entidad -> DTO
        }

        public async Task<IEnumerable<MateriaDto>> GetAllAsync(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var list = await repo.GetAllAsync(ct);
            return _mapper.Map<IEnumerable<MateriaDto>>(list);
        }

        public async Task<object?> GetByIdAsync(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var e = await repo.GetByIdAsync(id, ct);
            return e is null ? new { found = false }
                              : new { found = true, item = _mapper.Map<MateriaDto>(e) };
        }



        // Variante B: si el Update NO trae Id en el DTO (usa wrapper con Id)
        public async Task<object?> UpdateAsync(int id, MateriaUpdateDto dto, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var e = await repo.GetByIdAsync(id, ct);
            if (e is null) return new { updated = false, reason = "NotFound" };

            _mapper.Map(dto, e);
            await repo.UpdateAsync(e, ct);
            await _uow.CompleteAsync(ct);
            return new { updated = true, item = _mapper.Map<MateriaDto>(e) };
        }

        public async Task<object?> DeleteAsync(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var e = await repo.GetByIdAsync(id, ct);
            if (e is null) return new { deleted = false, reason = "NotFound" };

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return new { deleted = true };
        }
    }
}
