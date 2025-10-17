// Api/Controllers/AlumnoController.cs
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Alumno;
using Serilog;

namespace Api.Controllers.Sync
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    [ApiExplorerSettings(GroupName = "sync")]
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
            try
            {
                Log.Information("👥 [HTTP 200] Obteniendo lista de alumnos desde PostgreSQL");

                var repo = _uow.GetRepository<Alumno>();
                var alumnos = await repo.GetAllAsync(ct);
                var dtos = _mapper.Map<IEnumerable<AlumnoDto>>(alumnos);

                Log.Information("✅ [HTTP 200] Lista de alumnos obtenida desde PostgreSQL - Total: {Count} alumnos", alumnos.Count());
                return Ok(dtos);
            }
            catch (OperationCanceledException)
            {
                Log.Warning("⏰ [HTTP 408] Operación cancelada - Timeout al obtener alumnos");
                return StatusCode(408, new { message = "Operación cancelada por timeout" });
            }
            catch (Exception ex)
            {
                Log.Error(ex, "💥 [HTTP 500] Error al obtener lista de alumnos desde PostgreSQL");
                return StatusCode(500, new
                {
                    message = "Error interno del servidor al obtener alumnos",
                    error = "Error de conexión a la base de datos PostgreSQL"
                });
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AlumnoDto>> GetById(int id, CancellationToken ct)
        {
            try
            {
                Log.Information("🔍 [HTTP 200] Buscando alumno con ID: {AlumnoId} desde PostgreSQL", id);

                var repo = _uow.GetRepository<Alumno>();
                var alumno = await repo.GetByIdAsync(id, ct);

                if (alumno is null)
                {
                    Log.Warning("❌ [HTTP 404] Alumno no encontrado en PostgreSQL - ID: {AlumnoId}", id);
                    return NotFound(new
                    {
                        message = $"Alumno con ID {id} no encontrado",
                        id = id,
                        source = "PostgreSQL Database"
                    });
                }

                var dto = _mapper.Map<AlumnoDto>(alumno);
                Log.Information("✅ [HTTP 200] Alumno encontrado en PostgreSQL - ID: {AlumnoId}, Nombre: {Nombre}, Registro: {Registro}, Telefono: {Telefono}", id, alumno.Nombre, alumno.Registro, alumno.Telefono);
                return Ok(dto);
            }
            catch (OperationCanceledException)
            {
                Log.Warning("⏰ [HTTP 408] Operación cancelada - Timeout al buscar alumno ID: {AlumnoId}", id);
                return StatusCode(408, new { message = "Operación cancelada por timeout" });
            }
            catch (Exception ex)
            {
                Log.Error(ex, "💥 [HTTP 500] Error al buscar alumno ID: {AlumnoId} en PostgreSQL", id);
                return StatusCode(500, new
                {
                    message = "Error interno del servidor al buscar alumno",
                    id = id,
                    error = "Error de conexión a la base de datos PostgreSQL"
                });
            }
        }

        [HttpPost]
        public async Task<ActionResult<AlumnoDto>> Create([FromBody] AlumnoCreateDto dto, CancellationToken ct)
        {
            try
            {
                Log.Information("➕ [HTTP 201] Creando nuevo alumno en PostgreSQL - Nombre: {Nombre}, Registro: {Registro}", dto.Nombre, dto.Registro);

                if (!ModelState.IsValid)
                {
                    Log.Warning("❌ [HTTP 400] Datos de alumno inválidos - Errores: {@Errors}", ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage)));
                    return BadRequest(new
                    {
                        message = "Datos de alumno inválidos",
                        errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage))
                    });
                }

                var repo = _uow.GetRepository<Alumno>();
                var entity = _mapper.Map<Alumno>(dto);

                await repo.AddAsync(entity, ct);
                await _uow.CompleteAsync(ct);

                var responseDto = _mapper.Map<AlumnoDto>(entity);
                Log.Information("✅ [HTTP 201] Alumno creado exitosamente en PostgreSQL - ID: {Id}, Nombre: {Nombre}", responseDto.Id, responseDto.Nombre);
                return CreatedAtAction(nameof(GetById), new { id = responseDto.Id }, responseDto);
            }
            catch (OperationCanceledException)
            {
                Log.Warning("⏰ [HTTP 408] Operación cancelada - Timeout al crear alumno");
                return StatusCode(408, new { message = "Operación cancelada por timeout" });
            }
            catch (Exception ex)
            {
                Log.Error(ex, "💥 [HTTP 500] Error al crear alumno en PostgreSQL - Nombre: {Nombre}", dto.Nombre);
                return StatusCode(500, new
                {
                    message = "Error interno del servidor al crear alumno",
                    error = "Error de conexión a la base de datos PostgreSQL"
                });
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] AlumnoUpdateDto dto, CancellationToken ct)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

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