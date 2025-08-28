// Api/Controllers/GestionController.cs
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
    public class GestionController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public GestionController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // --- mapping helpers ---
        private static GestionDto MapToDto(Gestion g) => new()
        {
            Id     = g.Id,
            Nombre = g.Nombre
        };

        private static Gestion MapToEntity(GestionDto dto) => new()
        {
            Id     = dto.Id,
            Nombre = dto.Nombre
        };

        // GET: api/gestion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GestionDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Gestion>();
            var list = await repo.GetAllAsync(ct);
            return Ok(list.Select(MapToDto).ToList());
        }

        // GET: api/gestion/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<GestionDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Gestion>();
            var g = await repo.GetByIdAsync(id, ct);
            if (g is null) return NotFound();
            return Ok(MapToDto(g));
        }

        // POST: api/gestion
        [HttpPost]
        public async Task<ActionResult<GestionDto>> Add([FromBody] GestionDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Gestion>();
            var entity = MapToEntity(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var created = MapToDto(entity);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // PUT: api/gestion/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] GestionDto dto, CancellationToken ct)
        {
            if (id != dto.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Gestion>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            existing.Nombre = dto.Nombre;

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        // DELETE: api/gestion/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Gestion>();

            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
