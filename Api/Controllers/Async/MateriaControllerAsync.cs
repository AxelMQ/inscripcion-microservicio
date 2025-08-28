using Api.Dtos;
using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    // Define el controlador como una API y la ruta base
    [ApiController]
    [Route("api/Async/[controller]")]
    public class MateriasControllerAsync : ControllerBase
    {
        private readonly IMateriaRepository _materiaRepository;

        // Inyección de dependencias del repositorio
        public MateriasControllerAsync(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        // GET /api/materias
        // Obtiene todas las materias
        [HttpGet]
        public async Task<IActionResult> GetAllMaterias()
        {
            var materias = await _materiaRepository.GetAllAsync();
            var materiasDto = new List<MateriaDto>();

            foreach (var materia in materias)
            {
                materiasDto.Add(new MateriaDto
                {
                    ID = materia.ID,
                    NOMBRE = materia.NOMBRE,
                    CREDITO = materia.CREDITO,
                    ES_ELECTIVA = materia.ES_ELECTIVA,
                    SIGLA = materia.SIGLA
                });
            }

            return Ok(materiasDto); // Retorna 200 OK con la lista de materias
        }

        // GET /api/materias/{id}
        // Obtiene una materia por su ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMateriaById(int id)
        {
            var materia = await _materiaRepository.GetByIdAsync(id);

            if (materia == null)
            {
                return NotFound(); // Retorna 404 si la materia no se encuentra
            }

            // Mapea la entidad a un DTO para la respuesta
            var materiaDto = new MateriaDto
            {
                ID = materia.ID,
                NOMBRE = materia.NOMBRE,
                CREDITO = materia.CREDITO,
                ES_ELECTIVA = materia.ES_ELECTIVA,
                SIGLA = materia.SIGLA
            };

            return Ok(materiaDto); // Retorna 200 OK con los datos
        }
        
        // POST /api/materias
        // Crea una nueva materia
        [HttpPost]
        public async Task<IActionResult> CreateMateria([FromBody] MateriaDto materiaDto)
        {
            // Mapea el DTO a la entidad del dominio
            var materia = new Materia
            {
                NOMBRE = materiaDto.NOMBRE,
                CREDITO = materiaDto.CREDITO,
                ES_ELECTIVA = materiaDto.ES_ELECTIVA,
                SIGLA = materiaDto.SIGLA
            };

            await _materiaRepository.AddAsync(materia);
            
            // Retorna una respuesta 201 Created con la nueva materia
            materiaDto.ID = materia.ID; // Asigna el ID generado por la BD
            return CreatedAtAction(nameof(GetMateriaById), new { id = materia.ID }, materiaDto);
        }

        // PUT /api/materias/{id}
        // Actualiza una materia existente
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMateria(int id, [FromBody] MateriaDto materiaDto)
        {
            // Valida que el ID del DTO coincida con el ID de la ruta
            if (materiaDto.ID != id)
            {
                return BadRequest("El ID del DTO no coincide con el ID de la ruta.");
            }

            // Busca la materia en la base de datos para asegurarte de que existe
            var existingMateria = await _materiaRepository.GetByIdAsync(id);
            if (existingMateria == null)
            {
                return NotFound();
            }

            // Mapea los datos del DTO a la entidad
            existingMateria.NOMBRE = materiaDto.NOMBRE;
            existingMateria.CREDITO = materiaDto.CREDITO;
            existingMateria.ES_ELECTIVA = materiaDto.ES_ELECTIVA ?? false;
            existingMateria.SIGLA = materiaDto.SIGLA;

            await _materiaRepository.UpdateAsync(existingMateria);
            
            // Retorna una respuesta 204 No Content para una actualización exitosa
            return NoContent();
        }

        // DELETE /api/materias/{id}
        // Elimina una materia
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMateria(int id)
        {
            var materia = await _materiaRepository.GetByIdAsync(id);
            if (materia == null)
            {
                return NotFound();
            }
            
            await _materiaRepository.DeleteAsync(id);
            
            // Retorna una respuesta 204 No Content para una eliminación exitosa
            return NoContent();
        }
    }
}
