// Api/Controllers/DiaController.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Models;
using Api.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class DiaController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public DiaController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // --- Mapping helpers ---
        private static DiaDto MapToDto(Dia dia) => new()
        {
            Id = dia.Id,
            Nombre = dia.Nombre
        };

        private static Dia MapToEntity(DiaDto dto) => new()
        {
            Id = dto.Id,
            Nombre = dto.Nombre
        };

        // GET: api/dia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiaDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Dia>();
            var dias = await repo.GetAllAsync(ct);
            return Ok(dias.Select(MapToDto).ToList());
        }

        // GET: api/dia/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<DiaDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Dia>();
            var dia = await repo.GetByIdAsync(id, ct);
            if (dia is null) return NotFound();
            return Ok(MapToDto(dia));
        }

        // POST: api/dia
        [HttpPost]
        public async Task<ActionResult<DiaDto>> Add([FromBody] DiaDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Dia>();
            var entity = MapToEntity(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var created = MapToDto(entity);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // PUT: api/dia/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] DiaDto dto, CancellationToken ct)
        {
            if (id != dto.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Dia>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            // Mapear cambios
            existing.Nombre = dto.Nombre;

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        // DELETE: api/dia/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Dia>();

            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
