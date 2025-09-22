using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Interfaces;
using AutoMapper.QueryableExtensions;
using Shared.Contracts.Dtos.HorarioMateria;
namespace Api.Controllers.Sync
{

  [ApiController]
  [Route("api/[controller]")]
  [ApiExplorerSettings(GroupName = "sync")] 
  public class HorarioMateriaController : ControllerBase
  {
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public HorarioMateriaController(IUnitOfWork uow, IMapper mapper)
    {
      _uow = uow;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<HorarioMateriaDto>>> Get(CancellationToken ct)
    {
      var dtos = await _uow.GetRepository<HorarioMateria>()
          .Query()                // debe ser IQueryable<HorarioMateria>
          .AsNoTracking()
          .ProjectTo<HorarioMateriaDto>(_mapper.ConfigurationProvider)
          .ToListAsync(ct);

      return Ok(dtos);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<HorarioMateriaDto>> GetById(int id, CancellationToken ct)
    {
      var dto = await _uow.GetRepository<HorarioMateria>()
          .Query() // debe ser IQueryable<HorarioMateria>
          .AsNoTracking()
          .Where(hm => hm.Id == id)
          .ProjectTo<HorarioMateriaDto>(_mapper.ConfigurationProvider)
          .FirstOrDefaultAsync(ct);

      if (dto is null) return NotFound();
      return Ok(dto);
    }


    [HttpPost]
    public async Task<ActionResult<HorarioMateriaDto>> Create([FromBody] HorarioMateriaCreateDto dto, CancellationToken ct)
    {
      var repo = _uow.GetRepository<HorarioMateria>();
      var horarioMateria = _mapper.Map<HorarioMateria>(dto);

      await repo.AddAsync(horarioMateria, ct);
      await _uow.CompleteAsync();

      var createdDto = _mapper.Map<HorarioMateriaDto>(horarioMateria);
      return CreatedAtAction(nameof(GetById), new { id = createdDto.Id }, createdDto);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Update(int id, [FromBody] HorarioMateriaUpdateDto dto, CancellationToken ct)
    {

      var repo = _uow.GetRepository<HorarioMateria>();
      var existingItem = await repo.GetByIdAsync(id, ct);
      if (existingItem == null) return NotFound();

      _mapper.Map(dto, existingItem);

      await repo.UpdateAsync(existingItem, ct);
      await _uow.CompleteAsync(ct);
      return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id, CancellationToken ct)
    {
      var repo = _uow.GetRepository<HorarioMateria>();
      var item = await repo.GetByIdAsync(id, ct);
      if (item == null) return NotFound();

      await repo.DeleteAsync(id, ct);
      await _uow.CompleteAsync(ct);
      return NoContent();
    }
  }
}