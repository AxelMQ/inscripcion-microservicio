using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Domain.Entities;
using Shared.Contracts.Dtos.Inscripcion;
using AutoMapper;
using Domain.Exceptions;
using Domain.Enums;

namespace Api.Controllers.Sync;

[ApiController]
[Route("api/inscripciones")]
[ApiExplorerSettings(GroupName = "sync")]
public class InscripcionController : ControllerBase
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public InscripcionController(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }

    // GET /api/inscripciones
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var inscripciones = await _uow.GetRepository<Inscripcion>()
            .Query()
            .Include(i => i.Alumno)
            .Include(i => i.HorarioMateriaInscripciones)
                .ThenInclude(hmi => hmi.HorarioMateria)
                    .ThenInclude(hm => hm.GrupoMateria)
                        .ThenInclude(gm => gm.Materia)
            .Include(i => i.HorarioMateriaInscripciones)
                .ThenInclude(hmi => hmi.HorarioMateria)
                    .ThenInclude(hm => hm.Docente)
            .AsNoTracking()
            .ToListAsync();

        var result = inscripciones.Select(i => new
        {
            i.Id,
            Fecha = i.Fecha,
            AlumnoId = i.AlumnoId,
            AlumnoNombre = i.Alumno?.Nombre,
            Estado = i.Estado.ToString(),
            MensajeEstado = i.MensajeEstado,
            Materias = i.HorarioMateriaInscripciones.Select(hmi => new
            {
                HorarioMateriaId = hmi.HorarioMateriaId,
                MateriaNombre = hmi.HorarioMateria?.GrupoMateria?.Materia?.Nombre,
                MateriaSigla = hmi.HorarioMateria?.GrupoMateria?.Materia?.Sigla,
                Grupo = hmi.HorarioMateria?.GrupoMateria?.Grupo?.Nombre,
                Docente = hmi.HorarioMateria?.Docente?.Nombre,
                CuposDisponibles = hmi.HorarioMateria?.CuposDisponibles,
                CuposTotal = hmi.HorarioMateria?.CuposTotal
            }),
            CreatedAt = i.CreatedAt,
            UpdatedAt = i.UpdatedAt
        });

        return Ok(result);
    }

    // GET /api/inscripciones/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var inscripcion = await _uow.GetRepository<Inscripcion>()
            .Query()
            .Include(i => i.Alumno)
            .Include(i => i.HorarioMateriaInscripciones)
                .ThenInclude(hmi => hmi.HorarioMateria)
                    .ThenInclude(hm => hm.GrupoMateria)
                        .ThenInclude(gm => gm.Materia)
            .Include(i => i.HorarioMateriaInscripciones)
                .ThenInclude(hmi => hmi.HorarioMateria)
                    .ThenInclude(hm => hm.Docente)
            .AsNoTracking()
            .FirstOrDefaultAsync(i => i.Id == id);

        if (inscripcion == null)
            throw new InscripcionNotFoundException(id);

        var result = new
        {
            inscripcion.Id,
            Fecha = inscripcion.Fecha,
            AlumnoId = inscripcion.AlumnoId,
            AlumnoNombre = inscripcion.Alumno?.Nombre,
            Estado = inscripcion.Estado.ToString(),
            MensajeEstado = inscripcion.MensajeEstado,
            Materias = inscripcion.HorarioMateriaInscripciones.Select(hmi => new
            {
                HorarioMateriaId = hmi.HorarioMateriaId,
                MateriaNombre = hmi.HorarioMateria?.GrupoMateria?.Materia?.Nombre,
                MateriaSigla = hmi.HorarioMateria?.GrupoMateria?.Materia?.Sigla,
                Grupo = hmi.HorarioMateria?.GrupoMateria?.Grupo?.Nombre,
                Docente = hmi.HorarioMateria?.Docente?.Nombre,
                CuposDisponibles = hmi.HorarioMateria?.CuposDisponibles,
                CuposTotal = hmi.HorarioMateria?.CuposTotal
            }),
            CreatedAt = inscripcion.CreatedAt,
            UpdatedAt = inscripcion.UpdatedAt
        };

        return Ok(result);
    }

    // GET /api/inscripciones/alumno/{alumnoId}
    [HttpGet("alumno/{alumnoId}")]
    public async Task<IActionResult> GetByAlumno(int alumnoId)
    {
        // Verificar que el alumno existe
        var alumno = await _uow.GetRepository<Alumno>()
            .Query()
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.Id == alumnoId);

        if (alumno == null)
            throw new AlumnoNotFoundException(alumnoId);

        var inscripciones = await _uow.GetRepository<Inscripcion>()
            .Query()
            .Include(i => i.Alumno)
            .Include(i => i.HorarioMateriaInscripciones)
                .ThenInclude(hmi => hmi.HorarioMateria)
                    .ThenInclude(hm => hm.GrupoMateria)
                        .ThenInclude(gm => gm.Materia)
            .Include(i => i.HorarioMateriaInscripciones)
                .ThenInclude(hmi => hmi.HorarioMateria)
                    .ThenInclude(hm => hm.Docente)
            .Where(i => i.AlumnoId == alumnoId)
            .AsNoTracking()
            .ToListAsync();

        var result = inscripciones.Select(i => new
        {
            i.Id,
            Fecha = i.Fecha,
            AlumnoId = i.AlumnoId,
            AlumnoNombre = i.Alumno?.Nombre,
            Estado = i.Estado.ToString(),
            MensajeEstado = i.MensajeEstado,
            Materias = i.HorarioMateriaInscripciones.Select(hmi => new
            {
                HorarioMateriaId = hmi.HorarioMateriaId,
                MateriaNombre = hmi.HorarioMateria?.GrupoMateria?.Materia?.Nombre,
                MateriaSigla = hmi.HorarioMateria?.GrupoMateria?.Materia?.Sigla,
                Grupo = hmi.HorarioMateria?.GrupoMateria?.Grupo?.Nombre,
                Docente = hmi.HorarioMateria?.Docente?.Nombre,
                CuposDisponibles = hmi.HorarioMateria?.CuposDisponibles,
                CuposTotal = hmi.HorarioMateria?.CuposTotal
            }),
            CreatedAt = i.CreatedAt,
            UpdatedAt = i.UpdatedAt
        });

        return Ok(result);
    }

    // POST /api/inscripciones
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] InscripcionCreateDto dto)
    {
        // Validar que el alumno existe
        var alumno = await _uow.GetRepository<Alumno>()
            .Query()
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.Id == dto.AlumnoId);

        if (alumno == null)
            throw new AlumnoNotFoundException(dto.AlumnoId);

        // Validar que el horario de materia existe y tiene cupos disponibles
        var horarioMateria = await _uow.GetRepository<HorarioMateria>()
            .Query()
            .AsNoTracking()
            .FirstOrDefaultAsync(hm => hm.Id == dto.HorarioMateriaId);

        if (horarioMateria == null)
            throw new HorarioMateriaNotFoundException(dto.HorarioMateriaId);

        if (horarioMateria.CuposDisponibles <= 0)
            throw new NoSeatsAvailableException($"No hay cupos disponibles para el horario de materia {dto.HorarioMateriaId}");

        // Crear la inscripción
        var inscripcion = new Inscripcion
        {
            Fecha = DateTime.UtcNow,
            AlumnoId = dto.AlumnoId,
            Estado = RequestState.Pending,
            MensajeEstado = "Inscripción pendiente de procesamiento"
        };

        await _uow.GetRepository<Inscripcion>().AddAsync(inscripcion);
        await _uow.CompleteAsync();

        // Crear la relación con el horario de materia
        var horarioMateriaInscripcion = new HorarioMateriaInscripcion
        {
            InscripcionId = inscripcion.Id,
            HorarioMateriaId = dto.HorarioMateriaId
        };

        await _uow.GetRepository<HorarioMateriaInscripcion>().AddAsync(horarioMateriaInscripcion);

        await _uow.CompleteAsync();

        return CreatedAtAction(nameof(GetById), new { id = inscripcion.Id }, new
        {
            inscripcion.Id,
            inscripcion.Fecha,
            inscripcion.AlumnoId,
            Estado = inscripcion.Estado.ToString(),
            MensajeEstado = inscripcion.MensajeEstado
        });
    }

    // PUT /api/inscripciones/{id}/confirmar
    [HttpPut("{id}/confirmar")]
    public async Task<IActionResult> ConfirmarInscripcion(int id)
    {
        var inscripcion = await _uow.GetRepository<Inscripcion>()
            .Query()
            .Include(i => i.HorarioMateriaInscripciones)
            .FirstOrDefaultAsync(i => i.Id == id);

        if (inscripcion == null)
            throw new InscripcionNotFoundException(id);

        if (inscripcion.Estado != RequestState.Pending)
            throw new BusinessRuleException("EstadoInvalido", 
                "Solo se pueden confirmar inscripciones en estado Pending");

        // Verificar cupos disponibles para cada horario de materia
        foreach (var hmi in inscripcion.HorarioMateriaInscripciones)
        {
            var horarioMateria = await _uow.GetRepository<HorarioMateria>()
                .Query()
                .FirstOrDefaultAsync(hm => hm.Id == hmi.HorarioMateriaId);

            if (horarioMateria == null)
                throw new HorarioMateriaNotFoundException(hmi.HorarioMateriaId);

            if (horarioMateria.CuposDisponibles <= 0)
                throw new NoSeatsAvailableException($"No hay cupos disponibles para el horario de materia {hmi.HorarioMateriaId}");
        }

        // Confirmar la inscripción
        inscripcion.Estado = RequestState.Completed;
        inscripcion.MensajeEstado = "Inscripción confirmada exitosamente";

        // Reducir cupos disponibles
        foreach (var hmi in inscripcion.HorarioMateriaInscripciones)
        {
            var horarioMateria = await _uow.GetRepository<HorarioMateria>()
                .Query()
                .FirstOrDefaultAsync(hm => hm.Id == hmi.HorarioMateriaId);

            if (horarioMateria != null)
            {
                horarioMateria.CuposDisponibles--;
            }
        }

        await _uow.GetRepository<Inscripcion>().UpdateAsync(inscripcion);
        await _uow.CompleteAsync();

        return Ok(new
        {
            inscripcion.Id,
            Estado = inscripcion.Estado.ToString(),
            MensajeEstado = inscripcion.MensajeEstado
        });
    }

    // PUT /api/inscripciones/{id}/rechazar
    [HttpPut("{id}/rechazar")]
    public async Task<IActionResult> RechazarInscripcion(int id, [FromBody] RechazarInscripcionDto dto)
    {
        var inscripcion = await _uow.GetRepository<Inscripcion>()
            .Query()
            .FirstOrDefaultAsync(i => i.Id == id);

        if (inscripcion == null)
            throw new InscripcionNotFoundException(id);

        if (inscripcion.Estado != RequestState.Pending)
            throw new BusinessRuleException("EstadoInvalido", 
                "Solo se pueden rechazar inscripciones en estado Pending");

        inscripcion.Estado = RequestState.Failed;
        inscripcion.MensajeEstado = dto.Motivo ?? "Inscripción rechazada";

        await _uow.GetRepository<Inscripcion>().UpdateAsync(inscripcion);
        await _uow.CompleteAsync();

        return Ok(new
        {
            inscripcion.Id,
            Estado = inscripcion.Estado.ToString(),
            MensajeEstado = inscripcion.MensajeEstado
        });
    }
}