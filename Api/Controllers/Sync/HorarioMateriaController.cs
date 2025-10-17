using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Interfaces;
using AutoMapper.QueryableExtensions;
using Shared.Contracts.Dtos.HorarioMateria;
using Domain.Exceptions;
using Serilog;
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
      try
      {
        Log.Information("📚 [HTTP 200] Obteniendo lista de horarios de materia desde PostgreSQL");
        
        var dtos = await _uow.GetRepository<HorarioMateria>()
            .Query()                // debe ser IQueryable<HorarioMateria>
            .AsNoTracking()
            .ProjectTo<HorarioMateriaDto>(_mapper.ConfigurationProvider)
            .ToListAsync(ct);

        Log.Information("✅ [HTTP 200] Lista de horarios de materia obtenida desde PostgreSQL - Total: {Count} horarios", dtos.Count);
        return Ok(dtos);
      }
      catch (OperationCanceledException)
      {
        Log.Warning("⏰ [HTTP 408] Operación cancelada - Timeout al obtener horarios de materia");
        return StatusCode(408, new { message = "Operación cancelada por timeout" });
      }
      catch (Exception ex)
      {
        Log.Error(ex, "💥 [HTTP 500] Error al obtener lista de horarios de materia desde PostgreSQL");
        return StatusCode(500, new { 
          message = "Error interno del servidor al obtener horarios de materia",
          error = "Error de conexión a la base de datos PostgreSQL"
        });
      }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<HorarioMateriaDto>> GetById(int id, CancellationToken ct)
    {
      try
      {
        Log.Information("🔍 [HTTP 200] Buscando horario de materia con ID: {HorarioMateriaId} desde PostgreSQL", id);
        
        var dto = await _uow.GetRepository<HorarioMateria>()
            .Query() // debe ser IQueryable<HorarioMateria>
            .AsNoTracking()
            .Where(hm => hm.Id == id)
            .ProjectTo<HorarioMateriaDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(ct);

        if (dto is null)
        {
          Log.Warning("❌ [HTTP 404] Horario de materia no encontrado en PostgreSQL - ID: {HorarioMateriaId}", id);
          return NotFound(new { 
            message = $"Horario de materia con ID {id} no encontrado",
            id = id,
            source = "PostgreSQL Database"
          });
        }
        
        Log.Information("✅ [HTTP 200] Horario de materia encontrado en PostgreSQL - ID: {HorarioMateriaId}, Aula: {NroAula}, Cupos: {CuposDisponibles}/{CuposTotal}", 
          id, dto.NroAula, dto.CuposDisponibles, dto.CuposTotal);
        return Ok(dto);
      }
      catch (OperationCanceledException)
      {
        Log.Warning("⏰ [HTTP 408] Operación cancelada - Timeout al buscar horario de materia ID: {HorarioMateriaId}", id);
        return StatusCode(408, new { message = "Operación cancelada por timeout" });
      }
      catch (Exception ex)
      {
        Log.Error(ex, "💥 [HTTP 500] Error al buscar horario de materia ID: {HorarioMateriaId} en PostgreSQL", id);
        return StatusCode(500, new { 
          message = "Error interno del servidor al buscar horario de materia",
          id = id,
          error = "Error de conexión a la base de datos PostgreSQL"
        });
      }
    }


    [HttpPost]
    public async Task<ActionResult<HorarioMateriaDto>> Create([FromBody] HorarioMateriaCreateDto dto, CancellationToken ct)
    {
      try
      {
        Log.Information("➕ [HTTP 201] Creando nuevo horario de materia desde PostgreSQL");
        
        var repo = _uow.GetRepository<HorarioMateria>();
        var horarioMateria = _mapper.Map<HorarioMateria>(dto);

        await repo.AddAsync(horarioMateria, ct);
        await _uow.CompleteAsync();

        var createdDto = _mapper.Map<HorarioMateriaDto>(horarioMateria);
        
        Log.Information("✅ [HTTP 201] Horario de materia creado en PostgreSQL - ID: {HorarioMateriaId}, Aula: {NroAula}, Cupos: {CuposTotal}", 
          createdDto.Id, createdDto.NroAula, createdDto.CuposTotal);
        
        return CreatedAtAction(nameof(GetById), new { id = createdDto.Id }, createdDto);
      }
      catch (OperationCanceledException)
      {
        Log.Warning("⏰ [HTTP 408] Operación cancelada - Timeout al crear horario de materia");
        return StatusCode(408, new { message = "Operación cancelada por timeout" });
      }
      catch (Exception ex)
      {
        Log.Error(ex, "💥 [HTTP 500] Error al crear horario de materia en PostgreSQL");
        return StatusCode(500, new { 
          message = "Error interno del servidor al crear horario de materia",
          error = "Error de conexión a la base de datos PostgreSQL"
        });
      }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Update(int id, [FromBody] HorarioMateriaUpdateDto dto, CancellationToken ct)
    {
      var repo = _uow.GetRepository<HorarioMateria>();
      var existingItem = await repo.GetByIdAsync(id, ct);
      if (existingItem == null) 
        throw new HorarioMateriaNotFoundException(id);

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
      if (item == null) 
        throw new HorarioMateriaNotFoundException(id);

      await repo.DeleteAsync(id, ct);
      await _uow.CompleteAsync(ct);
      return NoContent();
    }
  }
}