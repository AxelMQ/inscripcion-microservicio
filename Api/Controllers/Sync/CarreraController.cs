using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Carrera;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CarreraController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public CarreraController(IUnitOfWork uow) => _uow = uow;

        // DTO de respuesta del API (puedes moverlo a Api/Dtos/Responses)
        public sealed record class CarreraResponseDto(
            int Id,
            string Codigo,
            short Modalidad,
            string Nombre
        );

        // Helpers de mapeo
        private static CarreraResponseDto ToResponse(Carrera c) =>
            new(c.Id, c.Codigo, c.Modalidad, c.Nombre);

        // GET: api/carrera
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarreraResponseDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var carreras = await repo.GetAllAsync(ct);
            return Ok(carreras.Select(ToResponse).ToList());
        }

        // GET: api/carrera/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CarreraResponseDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var carrera = await repo.GetByIdAsync(id, ct);
            if (carrera is null) return NotFound();
            return Ok(ToResponse(carrera));
        }

        // POST: api/carrera
        [HttpPost]
        public async Task<ActionResult<CarreraResponseDto>> Create([FromBody] CarreraCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Carrera>();
            var entity = new Carrera
            {
                Codigo = dto.Codigo!,
                Modalidad = dto.MODALIDAD,  // ojo: en Domain es 'Modalidad'
                Nombre = dto.Nombre!
            };

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var response = ToResponse(entity);
            return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
        }

        // PUT: api/carrera/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] CarreraUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Carrera>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            existing.Codigo = dto.Codigo!;
            existing.Modalidad = dto.MODALIDAD;
            existing.Nombre = dto.Nombre!;

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        // DELETE: api/carrera/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
