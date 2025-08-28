using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Gestion;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class GestionController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public GestionController(IUnitOfWork uow) => _uow = uow;

        // DTO de respuesta del API (mover a Api/Dtos/Responses si quieres)
        public sealed record class GestionResponseDto(int Id, string Nombre);

        private static GestionResponseDto ToResponse(Gestion g) => new(g.Id, g.Nombre);

        // GET: api/gestion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GestionResponseDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Gestion>();
            var list = await repo.GetAllAsync(ct);
            return Ok(list.Select(ToResponse).ToList());
        }

        // GET: api/gestion/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<GestionResponseDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Gestion>();
            var g = await repo.GetByIdAsync(id, ct);
            if (g is null) return NotFound();
            return Ok(ToResponse(g));
        }

        // POST: api/gestion
        [HttpPost]
        public async Task<ActionResult<GestionResponseDto>> Create([FromBody] GestionCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Gestion>();
            var entity = new Gestion { Nombre = dto.Nombre! };

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var response = ToResponse(entity);
            return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
        }

        // PUT: api/gestion/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] GestionUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Gestion>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            existing.Nombre = dto.Nombre!;

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
