using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Shared.Contracts.Dtos.Inscripcion;
using Serilog;

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
            
            Log.Information("🚀 Iniciando proceso de inscripción para AlumnoId: {AlumnoId}, HorarioMateriaId: {HorarioMateriaId}, IdempotencyKey: {IdempotencyKey}", 
                dto.AlumnoId, dto.HorarioMateriaId, idempotencyKey);
            
            try
            {
                // Traer HorarioMateria con tracking para actualizar cupos
                var hmRepo = _uow.HorarioMateriaRepository;
                var hm = await hmRepo.GetByIdAsync(dto.HorarioMateriaId, ct);
                if (hm is null)
                {
                    Log.Warning("❌ HorarioMateria no encontrado para ID: {HorarioMateriaId}", dto.HorarioMateriaId);
                    await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, "Horario de materia no encontrado", null);
                    return new { confirmed = false, reason = "HorarioMateriaNotFound" };
                }

                Log.Information("📚 HorarioMateria encontrado - Cupos totales: {CuposTotal}, Disponibles: {CuposDisponibles}", 
                    hm.CuposTotal, hm.CuposDisponibles);

                // Validar cupos disponibles
                if (hm.CuposDisponibles <= 0)
                {
                    var errorMessage = $"No hay cupos disponibles. Cupos totales: {hm.CuposTotal}, Disponibles: {hm.CuposDisponibles}";
                    Log.Warning("🚫 No hay cupos disponibles - Cupos totales: {CuposTotal}, Disponibles: {CuposDisponibles}", 
                        hm.CuposTotal, hm.CuposDisponibles);
                    await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, errorMessage, null);
                    return new { confirmed = false, reason = "NoSeatsAvailable", message = errorMessage };
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
                            var errorMessage = $"Conflicto de concurrencia - reintento agotado. Otro usuario se inscribió simultáneamente y agotó los cupos disponibles.";
                            await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, errorMessage, null);
                            return new { confirmed = false, reason = "ConcurrencyConflict", message = errorMessage };
                        }
                        
                        // Recargar la entidad fresca para el siguiente intento
                        var fresh = await hmRepo.GetByIdAsync(dto.HorarioMateriaId, ct);
                        if (fresh is null)
                        {
                            var errorMessage = "Horario de materia no encontrado durante reintento de concurrencia";
                            await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, errorMessage, null);
                            return new { confirmed = false, reason = "HorarioMateriaNotFound", message = errorMessage };
                        }
                        
                        // Verificar si aún hay cupos después del conflicto
                        if (fresh.CuposDisponibles <= 0)
                        {
                            var errorMessage = $"Después del conflicto de concurrencia, no quedan cupos disponibles. Cupos totales: {fresh.CuposTotal}, Disponibles: {fresh.CuposDisponibles}";
                            await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, errorMessage, null);
                            return new { confirmed = false, reason = "NoSeatsAvailable", message = errorMessage };
                        }
                        
                        hm = fresh;
                        continue;
                    }
                }

                // Crear la inscripción exitosa
                Log.Information("✅ Creando inscripción exitosa para AlumnoId: {AlumnoId}", dto.AlumnoId);
                
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
                Log.Information("🎉 Inscripción completada exitosamente - InscripcionId: {InscripcionId}, AlumnoId: {AlumnoId}", 
                    ins.Id, dto.AlumnoId);
                await UpdateJobStatusAsync(idempotencyKey, JobStatus.Completed, null, result);
                return new { confirmed = true, item = result };
            }
            catch (Exception ex)
            {
                Log.Error(ex, "💥 Error inesperado durante la inscripción para AlumnoId: {AlumnoId}, HorarioMateriaId: {HorarioMateriaId}", 
                    dto.AlumnoId, dto.HorarioMateriaId);
                var errorMessage = $"Error inesperado durante la inscripción: {ex.Message}";
                await UpdateJobStatusAsync(idempotencyKey, JobStatus.Failed, errorMessage, null);
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