// Archivo: Api/Controllers/GrupoController.cs

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Application.Interfaces;
using Api.Dtos;

[Route("api/Async/[controller]")]
[ApiController]
public class GrupoControllerAsync : ControllerBase
{
  private readonly IGrupoRepository _grupoRepository;

  public GrupoControllerAsync(IGrupoRepository grupoRepository)
  {
    _grupoRepository = grupoRepository;
  }

  // --- Helpers de mapeo ---
  private static GrupoDto MapToDto(Grupo grupo) => new GrupoDto
  {
    ID = grupo.ID,
    NOMBRE = grupo.NOMBRE
  };

  private static void MapDtoToEntityForUpdate(GrupoDto dto, Grupo entity)
  {
    entity.NOMBRE = dto.NOMBRE;
  }

  // GET: api/grupo
  [HttpGet]
  public async Task<ActionResult<IEnumerable<GrupoDto>>> GetAll()
  {
    var grupos = await _grupoRepository.GetAllAsync();
    var dtos = grupos.Select(MapToDto).ToList();
    return Ok(dtos);
  }

  // GET: api/grupo/5
  [HttpGet("{id}")]
  public async Task<ActionResult<GrupoDto>> GetById(int id)
  {
    var grupo = await _grupoRepository.GetByIdAsync(id);
    if (grupo == null) return NotFound();

    return Ok(MapToDto(grupo));
  }

  // POST: api/grupo
  [HttpPost]
  public async Task<ActionResult<GrupoDto>> Add([FromBody] GrupoDto dto)
  {
    // [ApiController] maneja 400 por validación automáticamente.
    // Ignoramos cualquier ID que venga en el body; lo genera la BD/ORM.
    var entity = new Grupo
    {
      NOMBRE = dto.NOMBRE
    };

    await _grupoRepository.AddAsync(entity);

    var readDto = MapToDto(entity);
    return CreatedAtAction(nameof(GetById), new { id = readDto.ID }, readDto);
  }

  // PUT: api/grupo/5
  [HttpPut("{id}")]
  public async Task<IActionResult> Update(int id, [FromBody] GrupoDto dto)
  {
    // Si el body trae ID y no coincide con la URL, rechazamos para evitar inconsistencias.
    if (dto.ID.HasValue && dto.ID.Value != id)
      return BadRequest("El id del cuerpo no coincide con el id de la URL.");

    var entity = await _grupoRepository.GetByIdAsync(id);
    if (entity == null) return NotFound();

    MapDtoToEntityForUpdate(dto, entity);
    await _grupoRepository.UpdateAsync(entity);

    return NoContent();
  }

  // DELETE: api/grupo/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(int id)
  {
    var entity = await _grupoRepository.GetByIdAsync(id);
    if (entity == null) return NotFound();

    await _grupoRepository.DeleteAsync(id);
    return NoContent();
  }
}
