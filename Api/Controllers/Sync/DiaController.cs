using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Dia;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class DiaController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public DiaController(IUnitOfWork uow) => _uow = uow;

        // DTO de respuesta del API (mover a Api/Dtos/Responses si quieres)
        public sealed record class DiaResponseDto(int Id, string Nombre);

        private static DiaResponseDto ToResponse(Dia d) => new(d.Id, d.Nombre);

        // GET: api/dia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiaResponseDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Dia>();
            var dias = await repo.GetAllAsync(ct);
            return Ok(dias.Select(ToResponse).ToList());
        }

        // GET: api/dia/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<DiaResponseDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Dia>();
            var dia = await repo.GetByIdAsync(id, ct);
            if (dia is null) return NotFound();
            return Ok(ToResponse(dia));
        }

        // POST: api/dia
        [HttpPost]
        public async Task<ActionResult<DiaResponseDto>> Create([FromBody] DiaCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Dia>();
            var entity = new Dia { Nombre = dto.Nombre! };

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var response = ToResponse(entity);
            return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
        }

        // PUT: api/dia/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] DiaUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Dia>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            existing.Nombre = dto.Nombre!;

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
