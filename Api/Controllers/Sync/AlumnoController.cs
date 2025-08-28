// Archivo: Api/Controllers/AlumnoController.cs

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Application.Interfaces;
using Api.Dtos; // ¡Añade esta línea para resolver el error!

[Route("api/[controller]")]
[ApiController]
public class AlumnoController : ControllerBase
{
    private readonly IAlumnoRepository _alumnoRepository;

    public AlumnoController(IAlumnoRepository alumnoRepository)
    {
        _alumnoRepository = alumnoRepository;
    }

    // Método de mapeo de Alumno a AlumnoDto
    private AlumnoDto MapToDto(Alumno alumno)
    {
        return new AlumnoDto
        {
            ID = alumno.ID,
            NOMBRE = alumno.NOMBRE,
            PPA = alumno.PPA,
            TELEFONO = alumno.TELEFONO,
            REGISTRO = alumno.REGISTRO
        };
    }

    // Método de mapeo de AlumnoDto a Alumno
    private Alumno MapToEntity(AlumnoDto alumnoDto)
    {
        return new Alumno
        {
            ID = alumnoDto.ID,
            NOMBRE = alumnoDto.NOMBRE,
            PPA = alumnoDto.PPA,
            TELEFONO = alumnoDto.TELEFONO,
            REGISTRO = alumnoDto.REGISTRO
        };
    }

    // Endpoint para obtener todos los alumnos
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AlumnoDto>>> GetAll()
    {
        var alumnos = await _alumnoRepository.GetAllAsync();
        var alumnosDto = alumnos.Select(a => MapToDto(a)).ToList();
        return Ok(alumnosDto);
    }

    // Endpoint para obtener un alumno por ID
    [HttpGet("{id}")]
    public async Task<ActionResult<AlumnoDto>> GetById(int id)
    {
        var alumno = await _alumnoRepository.GetByIdAsync(id);
        if (alumno == null)
        {
            return NotFound();
        }
        var alumnoDto = MapToDto(alumno);
        return Ok(alumnoDto);
    }

    // Endpoint para crear un nuevo alumno
    [HttpPost]
    public async Task<ActionResult<AlumnoDto>> Add(AlumnoDto alumnoDto)
    {
        // VERIFICACIÓN CLAVE: Si el modelo no es válido, el framework
        // ya llenó ModelState con los errores.
        if (!ModelState.IsValid)
        {
            // Devuelve un código 400 Bad Request con los errores de validación
            return BadRequest(ModelState);
        }

        var alumno = MapToEntity(alumnoDto);
        await _alumnoRepository.AddAsync(alumno);
        var newAlumnoDto = MapToDto(alumno);
        return CreatedAtAction(nameof(GetById), new { id = newAlumnoDto.ID }, newAlumnoDto);
    }

    // Endpoint para actualizar un alumno
    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, AlumnoDto alumnoDto)
    {
        if (id != alumnoDto.ID)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var alumno = await _alumnoRepository.GetByIdAsync(id);
        if (alumno == null)
        {
            return NotFound();
        }

        // Mapea los datos del DTO al modelo de dominio existente
        alumno.NOMBRE = alumnoDto.NOMBRE;
        alumno.PPA = alumnoDto.PPA;
        alumno.TELEFONO = alumnoDto.TELEFONO;
        alumno.REGISTRO = alumnoDto.REGISTRO;

        await _alumnoRepository.UpdateAsync(alumno);
        return NoContent();
    }

    // Endpoint para eliminar un alumno
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var alumno = await _alumnoRepository.GetByIdAsync(id);
        if (alumno == null)
        {
            return NotFound();
        }
        await _alumnoRepository.DeleteAsync(id);
        return NoContent();
    }
}
