// Api/Controllers/CarreraController.cs
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
    public class CarreraController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public CarreraController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // ---- Mapping helpers ----
        private static CarreraDto MapToDto(Carrera carrera) => new()
        {
            Id        = carrera.Id,
            Nombre    = carrera.Nombre,
            MODALIDAD = carrera.Modalidad,
            Codigo    = carrera.Codigo
        };

        private static Carrera MapToEntity(CarreraDto dto) => new()
        {
            Id        = dto.Id,
            Nombre    = dto.Nombre,
            Modalidad = dto.MODALIDAD,
            Codigo    = dto.Codigo
        };

        // GET: api/carrera
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarreraDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var carreras = await repo.GetAllAsync(ct);
            return Ok(carreras.Select(MapToDto).ToList());
        }

        // GET: api/carrera/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CarreraDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var carrera = await repo.GetByIdAsync(id, ct);
            if (carrera is null) return NotFound();
            return Ok(MapToDto(carrera));
        }

        // POST: api/carrera
        [HttpPost]
        public async Task<ActionResult<CarreraDto>> Add([FromBody] CarreraDto carreraDto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Carrera>();
            var entity = MapToEntity(carreraDto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var createdDto = MapToDto(entity);
            return CreatedAtAction(nameof(GetById), new { id = createdDto.Id }, createdDto);
        }

        // PUT: api/carrera/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] CarreraDto carreraDto, CancellationToken ct)
        {
            if (id != carreraDto.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Carrera>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            // mapear cambios
            existing.Nombre    = carreraDto.Nombre;
            existing.Modalidad = carreraDto.MODALIDAD;
            existing.Codigo    = carreraDto.Codigo;

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
