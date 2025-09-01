using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Contracts.Dtos.Dia;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class DiaController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public DiaController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiaDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Dia>();
            var dias = await repo.Query()
                .Include(d => d.HorasDia)
                .AsNoTracking()
                .ToListAsync(ct);

            var dtos = _mapper.Map<IEnumerable<DiaDto>>(dias);
            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<DiaDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Dia>();
            var dia = await repo.Query()
                .Include(d => d.HorasDia)
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.Id == id, ct);

            if (dia is null) return NotFound();

            var dto = _mapper.Map<DiaDto>(dia);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<DiaDto>> Create([FromBody] DiaCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Dia>();
            var entity = _mapper.Map<Dia>(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var responseDto = _mapper.Map<DiaDto>(entity);
            return CreatedAtAction(nameof(GetById), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] DiaUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Dia>();
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
            var repo = _uow.GetRepository<Dia>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}