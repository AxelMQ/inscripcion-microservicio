using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Interfaces;
using Shared.Contracts.Dtos.HoraDia;

namespace Api.Controllers.Sync
{
  [ApiController]
  [Route("api/[controller]")]
  public class HoraDiaController : ControllerBase
  {
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public HoraDiaController(IUnitOfWork uow, IMapper mapper)
    {
      _uow = uow;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<HoraDiaDto>>> Get(CancellationToken ct)
    {
      var repo = _uow.GetRepository<HoraDia>();
      var items = await repo.Query()
          .Include(hd => hd.Dia)
          .Include(hd => hd.Hora)
          .AsNoTracking()
          .ToListAsync(ct);

      var dtos = _mapper.Map<List<HoraDiaDto>>(items);
      return Ok(dtos);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<HoraDiaDto>> GetById(int id, CancellationToken ct)
    {
      var repo = _uow.GetRepository<HoraDia>();
      var item = await repo.Query()
          .Include(hd => hd.Dia)
          .Include(hd => hd.Hora)
          .AsNoTracking()
          .FirstOrDefaultAsync(hd => hd.Id == id, ct);

      if (item == null) return NotFound();

      var dto = _mapper.Map<HoraDiaDto>(item);
      return Ok(dto);
    }

    [HttpPost]
    public async Task<ActionResult<HoraDiaDto>> Create([FromBody] HoraDiaCreateDto dto, CancellationToken ct)
    {
      var repo = _uow.GetRepository<HoraDia>();
      var horaDia = _mapper.Map<HoraDia>(dto);

      await repo.AddAsync(horaDia, ct);
      await _uow.CompleteAsync(ct);

      var createdDto = _mapper.Map<HoraDiaDto>(horaDia);
      return CreatedAtAction(nameof(GetById), new { id = createdDto.Id }, createdDto);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Update(int id, [FromBody] HoraDiaUpdateDto dto, CancellationToken ct)
    {
      if (id != dto.Id) return BadRequest();

      var repo = _uow.GetRepository<HoraDia>();
      var existingHoraDia = await repo.GetByIdAsync(id, ct);
      if (existingHoraDia == null) return NotFound();

      // Mapear las nuevas propiedades de los IDs
      _mapper.Map(dto, existingHoraDia);

      await repo.UpdateAsync(existingHoraDia, ct);
      await _uow.CompleteAsync(ct);
      return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id, CancellationToken ct)
    {
      var repo = _uow.GetRepository<HoraDia>();
      var item = await repo.GetByIdAsync(id, ct);
      if (item == null) return NotFound();

      await repo.DeleteAsync(id, ct);
      await _uow.CompleteAsync(ct);
      return NoContent();
    }
  }
}