// Api/Controllers/NivelController.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Api.Dtos;
using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NivelController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public NivelController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // --- helpers de mapeo ---
        private static NivelDto MapToDto(Nivel n) => new()
        {
            Id     = n.Id,
            Orden = n.Orden,
            Nombre = n.Nombre
        };

        private static Nivel MapToEntity(NivelDto dto) => new()
        {
            Id     = dto.Id,
            Orden = dto.Orden,
            Nombre = dto.Nombre
        };

        // GET: api/nivel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NivelDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Nivel>();
            var niveles = await repo.GetAllAsync(ct);
            return Ok(niveles.Select(MapToDto).ToList());
        }

        // GET: api/nivel/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<NivelDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Nivel>();
            var nivel = await repo.GetByIdAsync(id, ct);
            if (nivel is null) return NotFound();
            return Ok(MapToDto(nivel));
        }

        // POST: api/nivel
        [HttpPost]
        public async Task<ActionResult<NivelDto>> Add([FromBody] NivelDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Nivel>();
            var entity = MapToEntity(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var created = MapToDto(entity);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // PUT: api/nivel/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] NivelDto dto, CancellationToken ct)
        {
            if (id != dto.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Nivel>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            existing.Nombre = dto.Nombre;

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        // DELETE: api/nivel/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Nivel>();

            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
