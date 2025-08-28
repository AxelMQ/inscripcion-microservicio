using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Grupo;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class GrupoController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public GrupoController(IUnitOfWork uow) => _uow = uow;

        // DTO de respuesta del API (mover a Api/Dtos/Responses si prefieres)
        public sealed record class GrupoResponseDto(int Id, string Nombre);

        private static GrupoResponseDto ToResponse(Grupo g) => new(g.Id, g.Nombre);

        // GET: api/grupo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrupoResponseDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Grupo>();
            var grupos = await repo.GetAllAsync(ct);
            return Ok(grupos.Select(ToResponse).ToList());
        }

        // GET: api/grupo/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<GrupoResponseDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Grupo>();
            var grupo = await repo.GetByIdAsync(id, ct);
            if (grupo is null) return NotFound();
            return Ok(ToResponse(grupo));
        }

        // POST: api/grupo
        [HttpPost]
        public async Task<ActionResult<GrupoResponseDto>> Create([FromBody] GrupoCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Grupo>();
            var entity = new Grupo { Nombre = dto.Nombre! };

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var response = ToResponse(entity);
            return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
        }

        // PUT: api/grupo/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] GrupoUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Grupo>();
            var entity = await repo.GetByIdAsync(id, ct);
            if (entity is null) return NotFound();

            entity.Nombre = dto.Nombre!;

            await repo.UpdateAsync(entity, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        // DELETE: api/grupo/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Grupo>();
            var entity = await repo.GetByIdAsync(id, ct);
            if (entity is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
