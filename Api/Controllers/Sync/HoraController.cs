using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Interfaces;
using Shared.Contracts.Dtos.Hora;

namespace Api.Controllers.Sync
{
  [ApiController]
  [Route("api/[controller]")]
  [ApiExplorerSettings(GroupName = "sync")] 
  public class HoraController : ControllerBase
  {
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public HoraController(IUnitOfWork uow, IMapper mapper)
    {
      _uow = uow;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<HoraDto>>> Get(CancellationToken ct)
    {
      var repo = _uow.GetRepository<Hora>();
      var items = await repo.Query()
          .AsNoTracking()
          .ToListAsync(ct);

      var dtos = _mapper.Map<List<HoraDto>>(items);
      return Ok(dtos);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<HoraDto>> GetById(int id, CancellationToken ct)
    {
      var repo = _uow.GetRepository<Hora>();
      var item = await repo.Query()
          .AsNoTracking()
          .FirstOrDefaultAsync(h => h.Id == id, ct);

      if (item == null) return NotFound();

      var dto = _mapper.Map<HoraDto>(item);
      return Ok(dto);
    }

    [HttpPost]
    public async Task<ActionResult<HoraDto>> Create([FromBody] HoraCreateDto dto, CancellationToken ct)
    {
      var repo = _uow.GetRepository<Hora>();
      var hora = _mapper.Map<Hora>(dto);

      await repo.AddAsync(hora, ct);
      await _uow.CompleteAsync(ct);

      var createdDto = _mapper.Map<HoraDto>(hora);
      return CreatedAtAction(nameof(GetById), new { id = createdDto.Id }, createdDto);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Update(int id, [FromBody] HoraUpdateDto dto, CancellationToken ct)
    {
      if (id != dto.Id) return BadRequest();

      var repo = _uow.GetRepository<Hora>();
      var existingHora = await repo.Query()
          .FirstOrDefaultAsync(h => h.Id == id, ct);

      if (existingHora == null) return NotFound();

      _mapper.Map(dto, existingHora);

      await repo.UpdateAsync(existingHora, ct);
      await _uow.CompleteAsync(ct);
      return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id, CancellationToken ct)
    {
      var repo = _uow.GetRepository<Hora>();
      var item = await repo.GetByIdAsync(id, ct);
      if (item == null) return NotFound();

      await repo.DeleteAsync(id, ct);
      await _uow.CompleteAsync(ct);
      return NoContent();
    }
  }
}