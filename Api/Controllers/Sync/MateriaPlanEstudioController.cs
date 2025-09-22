using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Contracts.Dtos.MateriaPlanEstudio;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "sync")] 
    //[Authorize]
    public class MateriaPlanEstudioController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public MateriaPlanEstudioController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MateriaPlanEstudioDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<MateriaPlanEstudio>();

            var data = await repo.Query()
                .Include(x => x.Materia)
                .Include(x => x.Nivel)
                .Include(x => x.PlanEstudio)
                .Include(x => x.MateriasRequisito)
                    .ThenInclude(p => p.Requisito)
                        .ThenInclude(mpe => mpe.Materia)
                // LÍNEA AÑADIDA: Incluir la relación inversa "requisitosPara"
                .Include(x => x.RequisitosPara)
                    .ThenInclude(p => p.MateriaPlanEstudio)
                        .ThenInclude(mpe => mpe.Materia)
                .AsSplitQuery()
                .AsNoTracking()
                .ToListAsync(ct);

            var dtos = _mapper.Map<IEnumerable<MateriaPlanEstudioDto>>(data);
            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<MateriaPlanEstudioDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<MateriaPlanEstudio>();

            var item = await repo.Query()
                .Include(x => x.Materia)
                .Include(x => x.Nivel)
                .Include(x => x.PlanEstudio)
                .Include(x => x.MateriasRequisito)
                    .ThenInclude(p => p.Requisito)
                        .ThenInclude(mpe => mpe.Materia)
                // LÍNEA AÑADIDA: Incluir la relación inversa "requisitosPara"
                .Include(x => x.RequisitosPara)
                    .ThenInclude(p => p.MateriaPlanEstudio)
                        .ThenInclude(mpe => mpe.Materia)
                .AsSplitQuery()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id, ct);

            if (item is null) return NotFound();

            var dto = _mapper.Map<MateriaPlanEstudioDto>(item);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<MateriaPlanEstudioDto>> Create([FromBody] MateriaPlanEstudioCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repoMpe = _uow.GetRepository<MateriaPlanEstudio>();
            var repoMat = _uow.GetRepository<Materia>();
            var repoNiv = _uow.GetRepository<Nivel>();
            var repoPla = _uow.GetRepository<PlanEstudio>();

            if (await repoMat.GetByIdAsync(dto.MateriaId, ct) is null)
                return BadRequest($"MateriaId {dto.MateriaId} no existe.");
            if (await repoNiv.GetByIdAsync(dto.NivelId, ct) is null)
                return BadRequest($"NivelId {dto.NivelId} no existe.");
            if (await repoPla.GetByIdAsync(dto.PlanEstudioId, ct) is null)
                return BadRequest($"PlanEstudioId {dto.PlanEstudioId} no existe.");

            var exists = await repoMpe.AnyAsync(x =>
                x.PlanEstudioId == dto.PlanEstudioId &&
                x.MateriaId == dto.MateriaId &&
                x.NivelId == dto.NivelId, ct);

            if (exists) return Conflict("Ya existe esa materia en ese plan y nivel.");

            var entity = _mapper.Map<MateriaPlanEstudio>(dto);

            await repoMpe.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var created = await repoMpe.Query()
                .Include(x => x.Materia)
                .Include(x => x.Nivel)
                .Include(x => x.PlanEstudio)
                .AsNoTracking()
                .FirstAsync(x => x.Id == entity.Id, ct);

            var createdDto = _mapper.Map<MateriaPlanEstudioDto>(created);
            return CreatedAtAction(nameof(GetById), new { id = createdDto.Id }, createdDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] MateriaPlanEstudioUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id del body no coincide con el de la ruta.");

            var repoMpe = _uow.GetRepository<MateriaPlanEstudio>();
            var existing = await repoMpe.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            _mapper.Map(dto, existing);

            var dup = await repoMpe.AnyAsync(x =>
                x.Id != id &&
                x.PlanEstudioId == existing.PlanEstudioId &&
                x.MateriaId == existing.MateriaId &&
                x.NivelId == existing.NivelId, ct);

            if (dup) return Conflict("Ya existe esa materia en ese plan y nivel.");

            await repoMpe.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<MateriaPlanEstudio>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
