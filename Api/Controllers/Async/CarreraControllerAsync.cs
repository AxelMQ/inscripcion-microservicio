// Archivo: Api/Controllers/CarreraController.cs

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Application.Interfaces;
using Api.Dtos; // ¡Añade esta línea para resolver el error!

[Route("api/Async/[controller]")]
[ApiController]
public class CarreraAsyncController : ControllerBase
{
  private readonly ICarreraRepository _carreraRepository;

  public CarreraAsyncController(ICarreraRepository carreraRepository)
  {
    _carreraRepository = carreraRepository;
  }

  // Método de mapeo de Carrera a CarreraDto
  private CarreraDto MapToDto(Carrera carrera)
  {
    return new CarreraDto
    {
      ID = carrera.ID,
      NOMBRE = carrera.NOMBRE,
      MODALIDAD = carrera.MODALIDAD,
      CODIGO = carrera.CODIGO
    };
  }

  // Método de mapeo de CarreraDto a Carrera
  private Carrera MapToEntity(CarreraDto carreraDto)
  {
    return new Carrera
    {
      ID = carreraDto.ID,
      NOMBRE = carreraDto.NOMBRE,
      MODALIDAD = carreraDto.MODALIDAD,
      CODIGO = carreraDto.CODIGO
    };
  }

  // Endpoint para obtener todos los alumnos
  [HttpGet]
  public async Task<ActionResult<IEnumerable<CarreraDto>>> GetAll()
  {
    var alumnos = await _carreraRepository.GetAllAsync();
    var alumnosDto = alumnos.Select(a => MapToDto(a)).ToList();
    return Ok(alumnosDto);
  }

  // Endpoint para obtener un carrera por ID
  [HttpGet("{id}")]
  public async Task<ActionResult<CarreraDto>> GetById(int id)
  {
    var carrera = await _carreraRepository.GetByIdAsync(id);
    if (carrera == null)
    {
      return NotFound();
    }
    var carreraDto = MapToDto(carrera);
    return Ok(carreraDto);
  }

  // Endpoint para crear un nuevo carrera
  [HttpPost]
  public async Task<ActionResult<CarreraDto>> Add(CarreraDto carreraDto)
  {
    // VERIFICACIÓN CLAVE: Si el modelo no es válido, el framework
    // ya llenó ModelState con los errores.
    if (!ModelState.IsValid)
    {
      // Devuelve un código 400 Bad Request con los errores de validación
      return BadRequest(ModelState);
    }

    var carrera = MapToEntity(carreraDto);
    await _carreraRepository.AddAsync(carrera);
    var newAlumnoDto = MapToDto(carrera);
    return CreatedAtAction(nameof(GetById), new { id = newAlumnoDto.ID }, newAlumnoDto);
  }

  // Endpoint para actualizar un carrera
  [HttpPut("{id}")]
  public async Task<ActionResult> Update(int id, CarreraDto carreraDto)
  {
    if (id != carreraDto.ID)
    {
      return BadRequest();
    }

    if (!ModelState.IsValid)
    {
      return BadRequest(ModelState);
    }

    var carrera = await _carreraRepository.GetByIdAsync(id);
    if (carrera == null)
    {
      return NotFound();
    }

    // Mapea los datos del DTO al modelo de dominio existente
    carrera.NOMBRE = carreraDto.NOMBRE;
    carrera.MODALIDAD = carreraDto.MODALIDAD;
    carrera.CODIGO = carreraDto.CODIGO;

    await _carreraRepository.UpdateAsync(carrera);
    return NoContent();
  }

  // Endpoint para eliminar un carrera
  [HttpDelete("{id}")]
  public async Task<ActionResult> Delete(int id)
  {
    var carrera = await _carreraRepository.GetByIdAsync(id);
    if (carrera == null)
    {
      return NotFound();
    }
    await _carreraRepository.DeleteAsync(id);
    return NoContent();
  }
}
