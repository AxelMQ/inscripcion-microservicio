// Api/Controllers/MateriasController.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Api.Dtos;
using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MateriasController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public MateriasController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // --- helpers de mapeo ---
        private static MateriaDto ToDto(Materia m) => new()
        {
            Id = m.Id,
            Nombre = m.Nombre,
            Credito = m.Credito,
            EsElectiva = m.EsElectiva,
            Sigla = m.Sigla
        };

        private static void MapDtoToEntity(MateriaDto dto, Materia entity)
        {
            entity.Nombre = dto.Nombre;
            entity.Credito = dto.Credito;
            entity.EsElectiva = dto.EsElectiva ?? false;
            entity.Sigla = dto.Sigla;
        }

        // GET /api/materias
        [HttpGet]
        public async Task<IActionResult> GetAllMaterias(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var materias = await repo.GetAllAsync(ct);
            var dtos = materias.Select(ToDto).ToList();
            return Ok(dtos);
        }

        // GET /api/materias/{id}
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetMateriaById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var materia = await repo.GetByIdAsync(id, ct);
            if (materia is null) return NotFound();
            return Ok(ToDto(materia));
        }

        // POST /api/materias
        [HttpPost]
        public async Task<IActionResult> CreateMateria([FromBody] MateriaDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Materia>();
            var entity = new Materia
            {
                Nombre = dto.Nombre,          // required
                Credito = dto.Credito,   // required
                Sigla = dto.Sigla,           // required
                EsElectiva = dto.EsElectiva ?? false
            };
            MapDtoToEntity(dto, entity);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var createdDto = ToDto(entity);
            return CreatedAtAction(nameof(GetMateriaById), new { id = createdDto.Id }, createdDto);
        }

        // PUT /api/materias/{id}
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateMateria(int id, [FromBody] MateriaDto dto, CancellationToken ct)
        {
            if (dto.Id != id) return BadRequest("El Id del DTO no coincide con el Id de la ruta.");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Materia>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            MapDtoToEntity(dto, existing);
            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);

            return NoContent();
        }

        // DELETE /api/materias/{id}
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteMateria(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);

            return NoContent();
        }
    }
}
