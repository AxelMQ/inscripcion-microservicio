// Api/Controllers/AlumnoController.cs
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Alumno;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class AlumnoController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public AlumnoController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlumnoDto>>> GetAll(CancellationToken ct)
        {
            var repo = _uow.GetRepository<Alumno>();
            var alumnos = await repo.GetAllAsync(ct);
            var dtos = _mapper.Map<IEnumerable<AlumnoDto>>(alumnos); // Usa el mapeador
            return Ok(dtos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AlumnoDto>> GetById(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Alumno>();
            var alumno = await repo.GetByIdAsync(id, ct);
            if (alumno is null) return NotFound();
            var dto = _mapper.Map<AlumnoDto>(alumno); // Usa el mapeador
            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<AlumnoDto>> Create([FromBody] AlumnoCreateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var repo = _uow.GetRepository<Alumno>();
            var entity = _mapper.Map<Alumno>(dto); // Usa el mapeador para crear la entidad

            await repo.AddAsync(entity, ct);
            await _uow.CompleteAsync(ct);

            var responseDto = _mapper.Map<AlumnoDto>(entity); // Usa el mapeador para la respuesta
            return CreatedAtAction(nameof(GetById), new { id = responseDto.Id }, responseDto);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] AlumnoUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id de la ruta no coincide con el Id del body.");

            var repo = _uow.GetRepository<Alumno>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            _mapper.Map(dto, existing); // Mapea los datos del DTO a la entidad existente

            await repo.UpdateAsync(existing, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct)
        {
            var repo = _uow.GetRepository<Alumno>();
            var existing = await repo.GetByIdAsync(id, ct);
            if (existing is null) return NotFound();

            await repo.DeleteAsync(id, ct);
            await _uow.CompleteAsync(ct);
            return NoContent();
        }
    }
}