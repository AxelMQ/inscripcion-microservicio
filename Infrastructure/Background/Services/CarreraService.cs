using AutoMapper;
using Application.Interfaces;
using Domain.Entities;
using Shared.Contracts.Dtos.Carrera;

namespace Infrastructure.Background.Services
{
    public class CarreraService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CarreraService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<CarreraDto> CreateAsync(CarreraCreateDto dto, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var entity = _mapper.Map<Carrera>(dto);          // DTO -> Entidad
            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);
            return _mapper.Map<CarreraDto>(entity);          // Entidad -> DTO
        }

        public async Task<IEnumerable<CarreraDto>> GetAllAsync(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var list = await repo.GetAllAsync(ct);
            return _mapper.Map<IEnumerable<CarreraDto>>(list);
        }

        public async Task<object?> GetByIdAsync(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var e = await repo.GetByIdAsync(id, ct);
            return e is null ? new { found = false }
                              : new { found = true, item = _mapper.Map<CarreraDto>(e) };
        }



        // Variante B: si el Update NO trae Id en el DTO (usa wrapper con Id)
        public async Task<object?> UpdateAsync(int id, CarreraUpdateDto dto, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var e = await repo.GetByIdAsync(id, ct);
            if (e is null) return new { updated = false, reason = "NotFound" };

            _mapper.Map(dto, e);
            await repo.UpdateAsync(e, ct);
            await _uow.CompleteAsync(ct);
            return new { updated = true, item = _mapper.Map<CarreraDto>(e) };
        }

        public async Task<object?> DeleteAsync(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var e = await repo.GetByIdAsync(id, ct);
            if (e is null) return new { deleted = false, reason = "NotFound" };

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return new { deleted = true };
        }
    }
}
