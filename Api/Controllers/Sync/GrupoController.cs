using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Grupo;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class GrupoController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GrupoController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrupoDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Grupo>();
            var grupos = await repo.Query()
                .Include(g => g.GrupoMaterias)
                .ThenInclude(gm => gm.Materia) // Carga la materia dentro de GrupoMateria
                .AsNoTracking() // Recomendado para lecturas
                .ToListAsync(ct);

            // Ahora, la colección 'GrupoMaterias' está cargada y lista para el mapeo
            var dtos = _mapper.Map<IEnumerable<GrupoDto>>(grupos);
            return Ok(dtos);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<GrupoDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Grupo>();
            var grupo = await repo.Query()
                .Include(g => g.GrupoMaterias)
                .ThenInclude(gm => gm.Materia) // Carga la materia dentro de GrupoMateria
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.Id == id, ct);

            if (grupo is null) return NotFound();

            // La entidad 'grupo' ahora tiene la colección 'GrupoMaterias' cargada
            var dto = _mapper.Map<GrupoDto>(grupo);
            return Ok(dto);
        }
        [HttpPost]
        public async Task<ActionResult<GrupoDto>> Create([FromBody] GrupoCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            // Usa el mapper para convertir el DTO en la entidad
            var entity = _mapper.Map<Grupo>(dto);

            var repo = _uow.GetRepository<Grupo>();
            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            // Usa el mapper para convertir la entidad de vuelta a un DTO de salida
            var responseDto = _mapper.Map<GrupoDto>(entity);
            return CreatedAtAction(nameof(GetById), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] GrupoUpdateDto dto, CancellationToken ct)
        {
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Grupo>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            // Usa el mapper para actualizar las propiedades de la entidad existente
            _mapper.Map(dto, existing);

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Grupo>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}