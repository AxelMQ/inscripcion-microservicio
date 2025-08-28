// Api/Controllers/DocenteController.cs
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
    public class DocenteController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public DocenteController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // --- mapping helpers ---
        private static DocenteDto MapToDto(Docente d) => new()
        {
            Id       = d.Id,
            Nombre   = d.Nombre,
            CI       = d.Ci,
            Telefono = d.Telefono
        };

        private static Docente MapToEntity(DocenteDto dto) => new()
        {
            Id       = dto.Id,
            Nombre   = dto.Nombre,
            Ci       = dto.CI,
            Telefono = dto.Telefono
        };

        // GET: api/docente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocenteDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var list = await repo.GetAllAsync(ct);
            return Ok(list.Select(MapToDto).ToList());
        }

        // GET: api/docente/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<DocenteDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var docente = await repo.GetByIdAsync(id, ct);
            if (docente is null) return NotFound();
            return Ok(MapToDto(docente));
        }

        // POST: api/docente
        [HttpPost]
        public async Task<ActionResult<DocenteDto>> Add([FromBody] DocenteDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Docente>();
            var entity = MapToEntity(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var created = MapToDto(entity);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // PUT: api/docente/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] DocenteDto dto, CancellationToken ct)
        {
            if (id != dto.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Docente>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            existing.Nombre   = dto.Nombre;
            existing.Ci       = dto.CI;
            existing.Telefono = dto.Telefono;

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        // DELETE: api/docente/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();

            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
