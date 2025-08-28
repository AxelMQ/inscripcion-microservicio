// Api/Controllers/AlumnoController.cs
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
    public class AlumnoController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public AlumnoController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // --- Mapping helpers ---
        private static AlumnoDto MapToDto(Alumno alumno) => new()
        {
            Id        = alumno.Id,
            Nombre    = alumno.Nombre,
            Ppa       = alumno.Ppa,
            Telefono  = alumno.Telefono,
            Registro  = alumno.Registro
        };

        private static Alumno MapToEntity(AlumnoDto dto) => new()
        {
            Id        = dto.Id,
            Nombre    = dto.Nombre,
            Ppa       = dto.Ppa,
            Telefono  = dto.Telefono,
            Registro  = dto.Registro
        };

        // GET: api/alumno
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlumnoDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Alumno>();
            var alumnos = await repo.GetAllAsync(ct);
            return Ok(alumnos.Select(MapToDto).ToList());
        }

        // GET: api/alumno/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<AlumnoDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Alumno>();
            var alumno = await repo.GetByIdAsync(id, ct);
            if (alumno is null) return NotFound();
            return Ok(MapToDto(alumno));
        }

        // POST: api/alumno
        [HttpPost]
        public async Task<ActionResult<AlumnoDto>> Add([FromBody] AlumnoDto alumnoDto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Alumno>();
            var entity = MapToEntity(alumnoDto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var createdDto = MapToDto(entity);
            return CreatedAtAction(nameof(GetById), new { id = createdDto.Id }, createdDto);
        }

        // PUT: api/alumno/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] AlumnoDto alumnoDto, CancellationToken ct)
        {
            if (id != alumnoDto.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Alumno>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            // mapear cambios
            existing.Nombre   = alumnoDto.Nombre;
            existing.Ppa      = alumnoDto.Ppa;
            existing.Telefono = alumnoDto.Telefono;
            existing.Registro = alumnoDto.Registro;

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        // DELETE: api/alumno/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Alumno>();

            // opcional: verificar existencia
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
