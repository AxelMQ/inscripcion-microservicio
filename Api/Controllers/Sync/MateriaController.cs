using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Materia; // 👈 plural

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class MateriaController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public MateriaController(IUnitOfWork uow) => _uow = uow;

        public sealed record class MateriaResponseDto(
            int Id,
            string Nombre,
            string Sigla,
            short Credito,
            bool EsElectiva
        );

        private static MateriaResponseDto ToResponseDto(Materia m) =>
            new(m.Id, m.Nombre, m.Sigla, m.Credito, m.EsElectiva);

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var materias = await repo.GetAllAsync(ct);
            return Ok(materias.Select(ToResponseDto).ToList());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var materia = await repo.GetByIdAsync(id, ct);
            return materia is null ? NotFound() : Ok(ToResponseDto(materia));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MateriaCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var entity = new Materia
            {
                Nombre = dto.Nombre!,
                Sigla = dto.Sigla!,
                Credito = dto.Credito,
                EsElectiva = dto.EsElectiva
            };

            var repo = _uow.GetRepository<Materia>();
            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var response = ToResponseDto(entity);
            return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] MateriaUpdateDto dto, CancellationToken ct)
        {
            if (dto.Id != id) return BadRequest("El Id del body no coincide con el de la ruta.");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Materia>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            existing.Nombre = dto.Nombre!;
            existing.Sigla = dto.Sigla!;
            existing.Credito = dto.Credito;
            existing.EsElectiva = dto.EsElectiva;

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
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
