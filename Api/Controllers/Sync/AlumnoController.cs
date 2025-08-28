using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Alumno;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class AlumnoController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public AlumnoController(IUnitOfWork uow) => _uow = uow;

        // DTO de respuesta del API (puedes moverlo a Api/Dtos/Responses si prefieres)
        public sealed record class AlumnoResponseDto(
            int Id,
            string Nombre,
            decimal Ppa,
            int? Telefono,   // si quieres permitir null en la respuesta
            int Registro
        );

        // helpers de mapeo
        private static AlumnoResponseDto ToResponse(Alumno a) =>
            new(a.Id, a.Nombre, a.Ppa, a.Telefono, a.Registro);

        // GET: api/alumno
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlumnoResponseDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Alumno>();
            var alumnos = await repo.GetAllAsync(ct);
            return Ok(alumnos.Select(ToResponse).ToList());
        }

        // GET: api/alumno/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<AlumnoResponseDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Alumno>();
            var alumno = await repo.GetByIdAsync(id, ct);
            if (alumno is null) return NotFound();
            return Ok(ToResponse(alumno));
        }

        // POST: api/alumno
        [HttpPost]
        public async Task<ActionResult<AlumnoResponseDto>> Create([FromBody] AlumnoCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Alumno>();
            var entity = new Alumno
            {
                Nombre = dto.Nombre!,
                Ppa = dto.Ppa,
                Telefono = dto.Telefono, // si dto lo define nullable, ajusta el tipo en Domain si aplica
                Registro = dto.Registro
            };

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var response = ToResponse(entity);
            return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
        }

        // PUT: api/alumno/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] AlumnoUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Alumno>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            existing.Nombre = dto.Nombre!;
            existing.Ppa = dto.Ppa;
            existing.Telefono = dto.Telefono;
            existing.Registro = dto.Registro;

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        // DELETE: api/alumno/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Alumno>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
