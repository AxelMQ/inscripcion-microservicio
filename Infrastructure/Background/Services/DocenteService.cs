using AutoMapper;
using Application.Interfaces;        
using Domain.Entities;                 
using Shared.Contracts.Dtos.Docente;

namespace Infrastructure.Background.Services
{
    public class DocenteService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public DocenteService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<DocenteDto> CreateAsync(DocenteCreateDto dto, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var entity = _mapper.Map<Docente>(dto);          // DTO -> Entidad
            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);
            return _mapper.Map<DocenteDto>(entity);          // Entidad -> DTO
        }

        public async Task<IEnumerable<DocenteDto>> GetAllAsync(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var list = await repo.GetAllAsync(ct);
            return _mapper.Map<IEnumerable<DocenteDto>>(list);
        }

        public async Task<object?> GetByIdAsync(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var e = await repo.GetByIdAsync(id, ct);
            return e is null ? new { found = false }
                              : new { found = true, item = _mapper.Map<DocenteDto>(e) };
        }



        // Variante B: si el Update NO trae Id en el DTO (usa wrapper con Id)
        public async Task<object?> UpdateAsync(int id, DocenteUpdateDto dto, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var e = await repo.GetByIdAsync(id, ct);
            if (e is null) return new { updated = false, reason = "NotFound" };

            _mapper.Map(dto, e);
            await repo.UpdateAsync(e, ct);
            await _uow.CompleteAsync(ct);
            return new { updated = true, item = _mapper.Map<DocenteDto>(e) };
        }

        public async Task<object?> DeleteAsync(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var e = await repo.GetByIdAsync(id, ct);
            if (e is null) return new { deleted = false, reason = "NotFound" };

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return new { deleted = true };
        }
    }
}
