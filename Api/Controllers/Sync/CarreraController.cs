using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Carrera;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "sync")] 
    //[Authorize]
    public class CarreraController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CarreraController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarreraDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var carreras = await repo.GetAllAsync(ct);
            return Ok(_mapper.Map<IEnumerable<CarreraDto>>(carreras));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CarreraDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Carrera>();
            var carrera = await repo.GetByIdAsync(id, ct);
            if (carrera is null) return NotFound();
            return Ok(_mapper.Map<CarreraDto>(carrera));
        }

        [HttpPost]
        public async Task<ActionResult<CarreraDto>> Create([FromBody] CarreraCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Carrera>();
            var entity = _mapper.Map<Carrera>(dto);

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var responseDto = _mapper.Map<CarreraDto>(entity);
            return CreatedAtAction(nameof(GetById), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] CarreraUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Carrera>();
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
            var repo = _uow.GetRepository<Carrera>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}
