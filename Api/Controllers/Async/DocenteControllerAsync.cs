// Archivo: Api/Controllers/DocenteController.cs

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Application.Interfaces;
using Api.Dtos; // ¡Añade esta línea para resolver el error!

[Route("api/Async/[controller]")]
[ApiController]
public class DocenteControllerAsync : ControllerBase
{
  private readonly IDocenteRepository _docenteRepository;

  public DocenteControllerAsync(IDocenteRepository alumnoRepository)
  {
    _docenteRepository = alumnoRepository;
  }

  // Método de mapeo de Docente a DocenteDto
  private DocenteDto MapToDto(Docente docente)
  {
    return new DocenteDto
    {
      ID = docente.ID,
      NOMBRE = docente.NOMBRE,
      CI = docente.CI,
      TELEFONO = docente.TELEFONO
    };
  }

  // Método de mapeo de DocenteDto a Docente
  private Docente MapToEntity(DocenteDto docenteDto)
  {
    return new Docente
    {
      ID = docenteDto.ID,
      NOMBRE = docenteDto.NOMBRE,
      CI = docenteDto.CI,
      TELEFONO = docenteDto.TELEFONO
    };
  }

  // Endpoint para obtener todos los alumnos
  [HttpGet]
  public async Task<ActionResult<IEnumerable<DocenteDto>>> GetAll()
  {
    var alumnos = await _docenteRepository.GetAllAsync();
    var alumnosDto = alumnos.Select(a => MapToDto(a)).ToList();
    return Ok(alumnosDto);
  }

  // Endpoint para obtener un docente por ID
  [HttpGet("{id}")]
  public async Task<ActionResult<DocenteDto>> GetById(int id)
  {
    var docente = await _docenteRepository.GetByIdAsync(id);
    if (docente == null)
    {
      return NotFound();
    }
    var docenteDto = MapToDto(docente);
    return Ok(docenteDto);
  }

  // Endpoint para crear un nuevo docente
  [HttpPost]
  public async Task<ActionResult<DocenteDto>> Add(DocenteDto docenteDto)
  {
    // VERIFICACIÓN CLAVE: Si el modelo no es válido, el framework
    // ya llenó ModelState con los errores.
    if (!ModelState.IsValid)
    {
      // Devuelve un código 400 Bad Request con los errores de validación
      return BadRequest(ModelState);
    }

    var docente = MapToEntity(docenteDto);
    await _docenteRepository.AddAsync(docente);
    var newAlumnoDto = MapToDto(docente);
    return CreatedAtAction(nameof(GetById), new { id = newAlumnoDto.ID }, newAlumnoDto);
  }

  // Endpoint para actualizar un docente
  [HttpPut("{id}")]
  public async Task<ActionResult> Update(int id, DocenteDto docenteDto)
  {
    if (id != docenteDto.ID)
    {
      return BadRequest();
    }

    if (!ModelState.IsValid)
    {
      return BadRequest(ModelState);
    }

    var docente = await _docenteRepository.GetByIdAsync(id);
    if (docente == null)
    {
      return NotFound();
    }

    // Mapea los datos del DTO al modelo de dominio existente
    docente.NOMBRE = docenteDto.NOMBRE;
    docente.CI = docenteDto.CI;
    docente.TELEFONO = docenteDto.TELEFONO;

    await _docenteRepository.UpdateAsync(docente);
    return NoContent();
  }

  // Endpoint para eliminar un docente
  [HttpDelete("{id}")]
  public async Task<ActionResult> Delete(int id)
  {
    var docente = await _docenteRepository.GetByIdAsync(id);
    if (docente == null)
    {
      return NotFound();
    }
    await _docenteRepository.DeleteAsync(id);
    return NoContent();
  }
}
