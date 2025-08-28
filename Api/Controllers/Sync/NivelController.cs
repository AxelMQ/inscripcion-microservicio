using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Nivel;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class NivelController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public NivelController(IUnitOfWork uow) => _uow = uow;

        // DTO de salida del API (mover a Api/Dtos/Responses si prefieres)
        public sealed record class NivelResponseDto(int Id, string Nombre, short Orden);

        private static NivelResponseDto ToResponse(Nivel n) => new(n.Id, n.Nombre, n.Orden);

        // GET: api/nivel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NivelResponseDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Nivel>();
            var niveles = await repo.GetAllAsync(ct);
            return Ok(niveles.Select(ToResponse).ToList());
        }

        // GET: api/nivel/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<NivelResponseDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Nivel>();
            var nivel = await repo.GetByIdAsync(id, ct);
            if (nivel is null) return NotFound();
            return Ok(ToResponse(nivel));
        }

        // POST: api/nivel
        [HttpPost]
        public async Task<ActionResult<NivelResponseDto>> Create([FromBody] NivelCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Nivel>();
            var entity = new Nivel
            {
                Nombre = dto.Nombre!,   // validado por DataAnnotations
                Orden = dto.Orden
            };

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var response = ToResponse(entity);
            return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
        }

        // PUT: api/nivel/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] NivelUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Nivel>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            existing.Nombre = dto.Nombre!;
            existing.Orden = dto.Orden;

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
