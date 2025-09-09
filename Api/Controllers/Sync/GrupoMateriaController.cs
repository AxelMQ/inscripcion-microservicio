using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Contracts.Dtos.GrupoMateria;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize] // Nota: Se añade esta directiva
    public class GrupoMateriaController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GrupoMateriaController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        // GET: api/grupomaterias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrupoMateriaDto>>> GetAll(CancellationToken ct)
        {
            var dtos = await _uow.GetRepository<GrupoMateria>()
                .Query()
                .AsNoTracking()
                .ProjectTo<GrupoMateriaDto>(_mapper.ConfigurationProvider)
                .ToListAsync(ct);

            return Ok(dtos);
        }

        // GET: api/grupomaterias/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<GrupoMateriaDto>> GetById(int id, CancellationToken ct)
        {
            var dto = await _uow.GetRepository<GrupoMateria>()
                   .Query()
                   .AsNoTracking()
                   .Where(hm => hm.Id == id)
                   .ProjectTo<GrupoMateriaDto>(_mapper.ConfigurationProvider)
                   .FirstOrDefaultAsync(ct);

            if (dto is null) return NotFound();
            return Ok(dto);
        }

        // POST: api/grupomaterias
        [HttpPost]
        public async Task<ActionResult<GrupoMateriaDto>> Create([FromBody] GrupoMateriaCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            // Validaciones FKs
            var grupoRepo = _uow.GetRepository<Grupo>();
            var matRepo = _uow.GetRepository<Materia>();
            if (await grupoRepo.GetByIdAsync(dto.GrupoId, ct) is null)
                return BadRequest($"GrupoId {dto.GrupoId} no existe.");
            if (await matRepo.GetByIdAsync(dto.MateriaId, ct) is null)
                return BadRequest($"MateriaId {dto.MateriaId} no existe.");

            // Unicidad (GrupoId, MateriaId)
            var repo = _uow.GetRepository<GrupoMateria>();
            if (await repo.AnyAsync(gm => gm.GrupoId == dto.GrupoId && gm.MateriaId == dto.MateriaId, ct))
                return Conflict("Ya existe una relación para ese Grupo y Materia.");

            // Usa el mapper para convertir el DTO en la entidad
            var entity = _mapper.Map<GrupoMateria>(dto);
            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            // Relee con includes para devolver la entidad completa
            var created = await repo.Query()
                .Include(g => g.Grupo)
                .Include(g => g.Materia)
                .Include(g => g.HorariosMateria)
                .AsSplitQuery()
                .AsNoTracking()
                .FirstAsync(x => x.Id == entity.Id, ct);

            // Usa el mapper para convertir la entidad de vuelta a un DTO de salida
            var createdDto = _mapper.Map<GrupoMateriaDto>(created);
            return CreatedAtAction(nameof(GetById), new { id = createdDto.Id }, createdDto);
        }  

        // PUT: api/grupomaterias/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] GrupoMateriaUpdateDto dto, CancellationToken ct)
        {
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<GrupoMateria>();
            var entity = await repo.GetByIdAsync(id, ct);
            if (entity is null) return NotFound();

            // Usa el mapper para actualizar las propiedades de la entidad existente
            _mapper.Map(dto, entity);

            // Validar y actualizar FKs si cambian
            var grupoRepo = _uow.GetRepository<Grupo>();
            var matRepo = _uow.GetRepository<Materia>();

            if (await grupoRepo.GetByIdAsync(dto.GrupoId, ct) is null)
                return BadRequest($"GrupoId {dto.GrupoId} no existe.");

            if (await matRepo.GetByIdAsync(dto.MateriaId, ct) is null)
                return BadRequest($"MateriaId {dto.MateriaId} no existe.");

            // Unicidad con nueva combinación
            if (await repo.AnyAsync(gm => gm.Id != id && gm.GrupoId == entity.GrupoId && gm.MateriaId == entity.MateriaId, ct))
                return Conflict("Ya existe una relación para ese Grupo y Materia.");

            await repo.UpdateAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            return NoContent();
        }

        // DELETE: api/grupomaterias/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<GrupoMateria>();
            var entity = await repo.GetByIdAsync(id, ct);
            if (entity is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);

            return NoContent();
        }
    }
}