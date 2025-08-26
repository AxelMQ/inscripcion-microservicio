// Archivo: Api/Controllers/DiaController.cs

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Application.Interfaces;
using Api.Dtos; // ¡Añade esta línea para resolver el error!

[Route("api/[controller]")]
[ApiController]
public class DiaController : ControllerBase
{
  private readonly IDiaRepository _diaRepository;

  public DiaController(IDiaRepository diaRepository)
  {
    _diaRepository = diaRepository;
  }

  // Método de mapeo de Dia a DiaDto
  private DiaDto MapToDto(Dia dia)
  {
    return new DiaDto
    {
      ID = dia.ID,
      NOMBRE = dia.NOMBRE,
    };
  }

  // Método de mapeo de DiaDto a Dia
  private Dia MapToEntity(DiaDto alumnoDto)
  {
    return new Dia
    {
      ID = alumnoDto.ID,
      NOMBRE = alumnoDto.NOMBRE
    };
  }

  // Endpoint para obtener todos los alumnos
  [HttpGet]
  public async Task<ActionResult<IEnumerable<DiaDto>>> GetAll()
  {
    var alumnos = await _diaRepository.GetAllAsync();
    var alumnosDto = alumnos.Select(a => MapToDto(a)).ToList();
    return Ok(alumnosDto);
  }

  // Endpoint para obtener un dia por ID
  [HttpGet("{id}")]
  public async Task<ActionResult<DiaDto>> GetById(int id)
  {
    var dia = await _diaRepository.GetByIdAsync(id);
    if (dia == null)
    {
      return NotFound();
    }
    var alumnoDto = MapToDto(dia);
    return Ok(alumnoDto);
  }

  // Endpoint para crear un nuevo dia
  [HttpPost]
  public async Task<ActionResult<DiaDto>> Add(DiaDto alumnoDto)
  {
    // VERIFICACIÓN CLAVE: Si el modelo no es válido, el framework
    // ya llenó ModelState con los errores.
    if (!ModelState.IsValid)
    {
      // Devuelve un código 400 Bad Request con los errores de validación
      return BadRequest(ModelState);
    }

    var dia = MapToEntity(alumnoDto);
    await _diaRepository.AddAsync(dia);
    var newAlumnoDto = MapToDto(dia);
    return CreatedAtAction(nameof(GetById), new { id = newAlumnoDto.ID }, newAlumnoDto);
  }

  // Endpoint para actualizar un dia
  [HttpPut("{id}")]
  public async Task<ActionResult> Update(int id, DiaDto alumnoDto)
  {
    if (id != alumnoDto.ID)
    {
      return BadRequest();
    }

    if (!ModelState.IsValid)
    {
      return BadRequest(ModelState);
    }

    var dia = await _diaRepository.GetByIdAsync(id);
    if (dia == null)
    {
      return NotFound();
    }

    // Mapea los datos del DTO al modelo de dominio existente
    dia.NOMBRE = alumnoDto.NOMBRE;

    await _diaRepository.UpdateAsync(dia);
    return NoContent();
  }

  // Endpoint para eliminar un dia
  [HttpDelete("{id}")]
  public async Task<ActionResult> Delete(int id)
  {
    var dia = await _diaRepository.GetByIdAsync(id);
    if (dia == null)
    {
      return NotFound();
    }
    await _diaRepository.DeleteAsync(id);
    return NoContent();
  }
}
