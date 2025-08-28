// Api/Controllers/GrupoController.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Models;
using Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GrupoController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public GrupoController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // --- Helpers de mapeo ---
        private static GrupoDto MapToDto(Grupo g) => new()
        {
            Id     = g.Id,
            Nombre = g.Nombre
        };

        private static void MapDtoToEntityForUpdate(GrupoDto dto, Grupo entity)
        {
            entity.Nombre = dto.Nombre;
        }

        // GET: api/grupo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrupoDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Grupo>();
            var grupos = await repo.GetAllAsync(ct);
            return Ok(grupos.Select(MapToDto).ToList());
        }

        // GET: api/grupo/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<GrupoDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Grupo>();
            var grupo = await repo.GetByIdAsync(id, ct);
            if (grupo is null) return NotFound();
            return Ok(MapToDto(grupo));
        }

        // POST: api/grupo
        [HttpPost]
        public async Task<ActionResult<GrupoDto>> Add([FromBody] GrupoDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Grupo>();
            var entity = new Grupo { Nombre = dto.Nombre };

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var readDto = MapToDto(entity);
            return CreatedAtAction(nameof(GetById), new { id = readDto.Id }, readDto);
        }

        // PUT: api/grupo/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] GrupoDto dto, CancellationToken ct)
        {
            if (dto.Id.HasValue && dto.Id.Value != id)
                return BadRequest("El id del cuerpo no coincide con el id de la URL.");

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Grupo>();
            var entity = await repo.GetByIdAsync(id, ct);
            if (entity is null) return NotFound();

            MapDtoToEntityForUpdate(dto, entity);
            await repo.UpdateAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            return NoContent();
        }

        // DELETE: api/grupo/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Grupo>();
            var entity = await repo.GetByIdAsync(id, ct);
            if (entity is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
