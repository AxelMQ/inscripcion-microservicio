using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Docente;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class DocenteController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public DocenteController(IUnitOfWork uow) => _uow = uow;

        // DTO de respuesta del API (mover a Api/Dtos/Responses si quieres)
        public sealed record class DocenteResponseDto(
            int Id,
            string Nombre,
            int CI,
            long? Telefono
        );

        // Helpers de mapeo
        private static DocenteResponseDto ToResponse(Docente d) =>
            new(d.Id, d.Nombre, d.Ci, d.Telefono);

        // GET: api/docente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocenteResponseDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var list = await repo.GetAllAsync(ct);
            return Ok(list.Select(ToResponse).ToList());
        }

        // GET: api/docente/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<DocenteResponseDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Docente>();
            var docente = await repo.GetByIdAsync(id, ct);
            if (docente is null) return NotFound();
            return Ok(ToResponse(docente));
        }

        // POST: api/docente
        [HttpPost]
        public async Task<ActionResult<DocenteResponseDto>> Create([FromBody] DocenteCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Docente>();
            var entity = new Docente
            {
                Nombre = dto.Nombre!,  // validated por DataAnnotations
                Ci = dto.CI,
                Telefono = dto.Telefono
            };

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var response = ToResponse(entity);
            return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
        }

        // PUT: api/docente/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] DocenteUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Docente>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            existing.Nombre = dto.Nombre!;
            existing.Ci = dto.CI;
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
