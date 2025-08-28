// Archivo: Api/Controllers/NivelController.cs

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Application.Interfaces;
using Api.Dtos; // ¡Añade esta línea para resolver el error!

[Route("api/Async/[controller]")]
[ApiController]
public class NivelControllerAsync : ControllerBase
{
    private readonly INivelRepository _nivelRepository;

    public NivelControllerAsync(INivelRepository nivelRepository)
    {
        _nivelRepository = nivelRepository;
    }

    // Método de mapeo de Nivel a NivelDto
    private NivelDto MapToDto(Nivel Nivel)
    {
        return new NivelDto
        {
            ID = Nivel.ID,
            NOMBRE = Nivel.NOMBRE,
        };
    }

    // Método de mapeo de NivelDto a Nivel
    private Nivel MapToEntity(NivelDto NivelDto)
    {
        return new Nivel
        {
            ID = NivelDto.ID,
            NOMBRE = NivelDto.NOMBRE,
        };
    }

    // Endpoint para obtener todos los Nivels
    [HttpGet]
    public async Task<ActionResult<IEnumerable<NivelDto>>> GetAll()
    {
        var Nivels = await _nivelRepository.GetAllAsync();
        var NivelsDto = Nivels.Select(a => MapToDto(a)).ToList();
        return Ok(NivelsDto);
    }

    // Endpoint para obtener un Nivel por ID
    [HttpGet("{id}")]
    public async Task<ActionResult<NivelDto>> GetById(int id)
    {
        var Nivel = await _nivelRepository.GetByIdAsync(id);
        if (Nivel == null)
        {
            return NotFound();
        }
        var NivelDto = MapToDto(Nivel);
        return Ok(NivelDto);
    }

    // Endpoint para crear un nuevo Nivel
    [HttpPost]
    public async Task<ActionResult<NivelDto>> Add(NivelDto NivelDto)
    {
        // VERIFICACIÓN CLAVE: Si el modelo no es válido, el framework
        // ya llenó ModelState con los errores.
        if (!ModelState.IsValid)
        {
            // Devuelve un código 400 Bad Request con los errores de validación
            return BadRequest(ModelState);
        }

        var Nivel = MapToEntity(NivelDto);
        await _nivelRepository.AddAsync(Nivel);
        var newNivelDto = MapToDto(Nivel);
        return CreatedAtAction(nameof(GetById), new { id = newNivelDto.ID }, newNivelDto);
    }

    // Endpoint para actualizar un Nivel
    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, NivelDto NivelDto)
    {
        if (id != NivelDto.ID)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var Nivel = await _nivelRepository.GetByIdAsync(id);
        if (Nivel == null)
        {
            return NotFound();
        }

        // Mapea los datos del DTO al modelo de dominio existente
        Nivel.NOMBRE = NivelDto.NOMBRE;

        await _nivelRepository.UpdateAsync(Nivel);
        return NoContent();
    }

    // Endpoint para eliminar un Nivel
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var Nivel = await _nivelRepository.GetByIdAsync(id);
        if (Nivel == null)
        {
            return NotFound();
        }
        await _nivelRepository.DeleteAsync(id);
        return NoContent();
    }
}
