// Api/Controllers/MateriaController.cs

using Application.Interfaces;
using AutoMapper; // Necesitas agregar esta directiva using
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Materia;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
   // [Authorize]
    public class MateriaController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper; // Inyecta el mapper aquí

        public MateriaController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var materias = await repo.GetAllAsync(ct);
            // Usa el mapper para la colección de DTOs
            var dtos = _mapper.Map<IEnumerable<MateriaDto>>(materias);
            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var materia = await repo.GetByIdAsync(id, ct);
            if (materia is null) return NotFound();
            // Usa el mapper para el DTO individual
            var dto = _mapper.Map<MateriaDto>(materia);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MateriaCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            // Usa el mapper para convertir el DTO en la entidad
            var entity = _mapper.Map<Materia>(dto);

            var repo = _uow.GetRepository<Materia>();
            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            // Usa el mapper para convertir la entidad de vuelta a un DTO de salida
            var responseDto = _mapper.Map<MateriaDto>(entity);
            return CreatedAtAction(nameof(GetById), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] MateriaUpdateDto dto, CancellationToken ct)
        {
            if (dto.Id != id) return BadRequest("El Id del body no coincide con el de la ruta.");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Materia>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            // Usa el mapper para actualizar las propiedades de la entidad existente
            _mapper.Map(dto, existing);

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Materia>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}