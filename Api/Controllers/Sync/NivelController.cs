using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Contracts.Dtos.Nivel;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "sync")] 
    //[Authorize]
    public class NivelController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public NivelController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NivelDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Nivel>();
            var niveles = await repo.Query()
                .Include(n => n.MateriaPlanEstudios)
                .AsNoTracking()
                .ToListAsync(ct);

            var dtos = _mapper.Map<IEnumerable<NivelDto>>(niveles);
            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<NivelDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Nivel>();
            var nivel = await repo.Query()
                .Include(n => n.MateriaPlanEstudios)
                .AsNoTracking()
                .FirstOrDefaultAsync(n => n.Id == id, ct);

            if (nivel is null) return NotFound();

            var dto = _mapper.Map<NivelDto>(nivel);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<NivelDto>> Create([FromBody] NivelCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Nivel>();
            var entity = _mapper.Map<Nivel>(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var responseDto = _mapper.Map<NivelDto>(entity);
            return CreatedAtAction(nameof(GetById), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] NivelUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Nivel>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            _mapper.Map(dto, existing);

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

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