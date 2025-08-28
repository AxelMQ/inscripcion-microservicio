// Archivo: Api/Controllers/GestionController.cs

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Application.Interfaces;
using Api.Dtos; // ¡Añade esta línea para resolver el error!

[Route("api/Async/[controller]")]
[ApiController]
public class GestionControllerAsync : ControllerBase
{
  private readonly IGestionRepository _gestionRepository;

  public GestionControllerAsync(IGestionRepository gestionRepository)
  {
    _gestionRepository = gestionRepository;
  }

  // Método de mapeo de Gestion a GestionDto
  private GestionDto MapToDto(Gestion alumno)
  {
    return new GestionDto
    {
      ID = alumno.ID,
      NOMBRE = alumno.NOMBRE,
    };
  }

  // Método de mapeo de GestionDto a Gestion
  private Gestion MapToEntity(GestionDto alumnoDto)
  {
    return new Gestion
    {
      ID = alumnoDto.ID,
      NOMBRE = alumnoDto.NOMBRE
    };
  }

  // Endpoint para obtener todos los alumnos
  [HttpGet]
  public async Task<ActionResult<IEnumerable<GestionDto>>> GetAll()
  {
    var alumnos = await _gestionRepository.GetAllAsync();
    var alumnosDto = alumnos.Select(a => MapToDto(a)).ToList();
    return Ok(alumnosDto);
  }

  // Endpoint para obtener un alumno por ID
  [HttpGet("{id}")]
  public async Task<ActionResult<GestionDto>> GetById(int id)
  {
    var alumno = await _gestionRepository.GetByIdAsync(id);
    if (alumno == null)
    {
      return NotFound();
    }
    var alumnoDto = MapToDto(alumno);
    return Ok(alumnoDto);
  }

  // Endpoint para crear un nuevo alumno
  [HttpPost]
  public async Task<ActionResult<GestionDto>> Add(GestionDto alumnoDto)
  {
    // VERIFICACIÓN CLAVE: Si el modelo no es válido, el framework
    // ya llenó ModelState con los errores.
    if (!ModelState.IsValid)
    {
      // Devuelve un código 400 Bad Request con los errores de validación
      return BadRequest(ModelState);
    }

    var alumno = MapToEntity(alumnoDto);
    await _gestionRepository.AddAsync(alumno);
    var newAlumnoDto = MapToDto(alumno);
    return CreatedAtAction(nameof(GetById), new { id = newAlumnoDto.ID }, newAlumnoDto);
  }

  // Endpoint para actualizar un alumno
  [HttpPut("{id}")]
  public async Task<ActionResult> Update(int id, GestionDto alumnoDto)
  {
    if (id != alumnoDto.ID)
    {
      return BadRequest();
    }

    if (!ModelState.IsValid)
    {
      return BadRequest(ModelState);
    }

    var alumno = await _gestionRepository.GetByIdAsync(id);
    if (alumno == null)
    {
      return NotFound();
    }

    // Mapea los datos del DTO al modelo de dominio existente
    alumno.NOMBRE = alumnoDto.NOMBRE;

    await _gestionRepository.UpdateAsync(alumno);
    return NoContent();
  }

  // Endpoint para eliminar un alumno
  [HttpDelete("{id}")]
  public async Task<ActionResult> Delete(int id)
  {
    var alumno = await _gestionRepository.GetByIdAsync(id);
    if (alumno == null)
    {
      return NotFound();
    }
    await _gestionRepository.DeleteAsync(id);
    return NoContent();
  }
}
