using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Shared.Contracts.Dtos.Inscripcion;

namespace Infrastructure.Background.Services
{
    public class InscripcionService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public InscripcionService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        // Procesa un SeatRequested y devuelve estado final
        public async Task<object?> CreateAsync(InscripcionJobDto jobDto, CancellationToken ct)
        {
            var dto = jobDto.Dto;
            var idempotencyKey = jobDto.IdempotencyKey;
            
            try
            {
                // Traer HorarioMateria con tracking para actualizar cupos
                var hmRepo = _uow.HorarioMateriaRepository;
                var hm = await hmRepo.GetByIdAsync(dto.HorarioMateriaId, ct);
                if (hm is null)
                {
                    await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, "Horario de materia no encontrado", null);
                    return new { confirmed = false, reason = "HorarioMateriaNotFound" };
                }

                // Validar cupos disponibles
                if (hm.CuposDisponibles <= 0)
                {
                    await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, "No hay cupos disponibles", null);
                    return new { confirmed = false, reason = "NoSeatsAvailable" };
                }

                // Decrementar cupos con control de concurrencia
                for (var attempt = 0; attempt < 3; attempt++)
                {
                    try
                    {
                        hm.CuposDisponibles -= 1;
                        await hmRepo.UpdateAsync(hm, ct);
                        await _uow.CompleteAsync(ct);
                        break;
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (attempt == 2)
                        {
                            await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, "Conflicto de concurrencia - reintento agotado", null);
                            return new { confirmed = false, reason = "ConcurrencyConflict" };
                        }
                        
                        // Recargar la entidad fresca para el siguiente intento
                        var fresh = await hmRepo.GetByIdAsync(dto.HorarioMateriaId, ct);
                        if (fresh is null)
                        {
                            await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, "Horario de materia no encontrado durante reintento", null);
                            return new { confirmed = false, reason = "HorarioMateriaNotFound" };
                        }
                        hm = fresh;
                        continue;
                    }
                }

                // Crear la inscripción exitosa
                var insRepo = _uow.GetRepository<Inscripcion>();
                var hmiRepo = _uow.GetRepository<HorarioMateriaInscripcion>();

                var ins = new Inscripcion
                {
                    Fecha = DateTime.UtcNow,
                    AlumnoId = dto.AlumnoId,
                    Estado = RequestState.Completed,
                    MensajeEstado = "Inscripción confirmada exitosamente"
                };
                await insRepo.AddAsync(ins, ct);
                await _uow.CompleteAsync(ct);

                var link = new HorarioMateriaInscripcion
                {
                    InscripcionId = ins.Id,
                    HorarioMateriaId = dto.HorarioMateriaId,
                };
                await hmiRepo.AddAsync(link, ct);
                await _uow.CompleteAsync(ct);

                var result = new InscripcionDto
                {
                    Id = ins.Id,
                    Fecha = ins.Fecha,
                    AlumnoId = ins.AlumnoId,
                    HorarioMateriaId = dto.HorarioMateriaId,
                };

                // Actualizar el estado del job a Completed
                await UpdateJobStatusAsync(idempotencyKey, JobStatus.Completed, null, result);
                return new { confirmed = true, item = result };
            }
            catch (Exception ex)
            {
                await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, ex.Message, null);
                throw;
            }
        }

        private async Task UpdateJobStatusAsync(string idempotencyKey, JobStatus status, string? error, object? data)
        {
            try
            {
                var dbContext = (Microsoft.EntityFrameworkCore.DbContext)_uow.GetDbContext();
                var dataJson = data != null ? System.Text.Json.JsonSerializer.Serialize(data) : null;
                
                await dbContext.Database.ExecuteSqlRawAsync(
                    "UPDATE job_results SET status = {0}, finished_utc = {1}, error = {2}, data_json = {3} WHERE idempotency_key = {4}",
                    (int)status,
                    DateTime.UtcNow,
                    error,
                    dataJson,
                    idempotencyKey
                );
            }
            catch (Exception)
            {
                // Log error but don't throw to avoid masking the original error
            }
        }

        // El resto requerido por JobRegistry (GetAll/GetById/Update/Delete) puede implementarse si es necesario.
        public Task<object?> GetAllAsync(CancellationToken ct) => Task.FromResult<object?>(Array.Empty<InscripcionDto>());
        public Task<object?> GetByIdAsync(int id, CancellationToken ct) => Task.FromResult<object?>(new { found = false });
        public Task<object?> UpdateAsync(int id, object dto, CancellationToken ct) => Task.FromResult<object?>(new { updated = false });
        public Task<object?> DeleteAsync(int id, CancellationToken ct) => Task.FromResult<object?>(new { deleted = false });
    }
}