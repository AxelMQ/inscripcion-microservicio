using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Contracts.Dtos.PlanEstudio;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "sync")] 
   //[Authorize]
    public class PlanEstudioController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public PlanEstudioController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanEstudioDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<PlanEstudio>();
            var planes = await repo.Query()
                .Include(p => p.Carrera)
                .Include(p => p.MateriaPlanEstudios)
                .ThenInclude(mp => mp.Materia)
                .AsNoTracking()
                .ToListAsync(ct);

            var dtos = _mapper.Map<IEnumerable<PlanEstudioDto>>(planes);
            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PlanEstudioDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<PlanEstudio>();
            var plan = await repo.Query()
                .Include(p => p.Carrera)
                .Include(p => p.MateriaPlanEstudios)
                .ThenInclude(mp => mp.Materia)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id, ct);

            if (plan is null) return NotFound();

            var dto = _mapper.Map<PlanEstudioDto>(plan);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<PlanEstudioDto>> Create([FromBody] PlanEstudioCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<PlanEstudio>();
            var repoCarrera = _uow.GetRepository<Carrera>();

            if (await repoCarrera.GetByIdAsync(dto.CarreraId, ct) is null)
                return BadRequest($"CarreraId {dto.CarreraId} no existe.");

            var exists = await repo.AnyAsync(p =>
                p.Codigo == dto.Codigo &&
                p.CarreraId == dto.CarreraId, ct);

            if (exists) return Conflict("Ya existe un plan de estudio con ese código para esa carrera.");

            var entity = _mapper.Map<PlanEstudio>(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var responseDto = _mapper.Map<PlanEstudioDto>(entity);
            return CreatedAtAction(nameof(GetById), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] PlanEstudioUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<PlanEstudio>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            _mapper.Map(dto, existing);

            var dup = await repo.AnyAsync(p =>
                p.Id != id &&
                p.Codigo == existing.Codigo &&
                p.CarreraId == existing.CarreraId, ct);

            if (dup) return Conflict("Ya existe un plan de estudio con ese código para esa carrera.");

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<PlanEstudio>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}