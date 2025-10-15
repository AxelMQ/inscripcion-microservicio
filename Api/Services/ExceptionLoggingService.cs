using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Domain.Exceptions;

namespace Api.Services
{
    public interface IExceptionLoggingService
    {
        void LogException(Exception exception, string? userId = null, Dictionary<string, object>? additionalData = null);
        void LogBusinessException(BusinessRuleException exception, string? userId = null);
        void LogValidationException(ValidationException exception, string? userId = null);
        void LogDomainException(Exception exception, string? userId = null);
    }

    public class ExceptionLoggingService : IExceptionLoggingService
    {
        private readonly ILogger<ExceptionLoggingService> _logger;

        public ExceptionLoggingService(ILogger<ExceptionLoggingService> logger)
        {
            _logger = logger;
        }

        public void LogException(Exception exception, string? userId = null, Dictionary<string, object>? additionalData = null)
        {
            var logData = new Dictionary<string, object>
            {
                ["ExceptionType"] = exception.GetType().Name,
                ["Message"] = exception.Message,
                ["StackTrace"] = exception.StackTrace ?? string.Empty,
                ["Timestamp"] = DateTime.UtcNow,
                ["UserId"] = userId ?? "Anonymous"
            };

            if (additionalData != null)
            {
                foreach (var item in additionalData)
                {
                    logData[item.Key] = item.Value;
                }
            }

            _logger.LogError(exception, "Excepción capturada: {ExceptionType} - {Message} - UserId: {UserId}", 
                exception.GetType().Name, exception.Message, userId ?? "Anonymous");
        }

        public void LogBusinessException(BusinessRuleException exception, string? userId = null)
        {
            _logger.LogWarning("Violación de regla de negocio: {RuleName} - {Message} - UserId: {UserId}", 
                exception.RuleName, exception.Message, userId ?? "Anonymous");
        }

        public void LogValidationException(ValidationException exception, string? userId = null)
        {
            _logger.LogWarning("Error de validación: {Message} - UserId: {UserId} - Errors: {@Errors}", 
                exception.Message, userId ?? "Anonymous", exception.Errors);
        }

        public void LogDomainException(Exception exception, string? userId = null)
        {
            var exceptionType = exception.GetType().Name;
            
            switch (exception)
            {
                case HorarioMateriaNotFoundException ex:
                    _logger.LogWarning("HorarioMateria no encontrado: ID {HorarioMateriaId} - UserId: {UserId}", 
                        ex.HorarioMateriaId, userId ?? "Anonymous");
                    break;
                case AlumnoNotFoundException ex:
                    _logger.LogWarning("Alumno no encontrado: ID {AlumnoId} - UserId: {UserId}", 
                        ex.AlumnoId, userId ?? "Anonymous");
                    break;
                case InscripcionNotFoundException ex:
                    _logger.LogWarning("Inscripción no encontrada: ID {InscripcionId} - UserId: {UserId}", 
                        ex.InscripcionId, userId ?? "Anonymous");
                    break;
                case NoSeatsAvailableException ex:
                    _logger.LogWarning("No hay cupos disponibles: {Message} - UserId: {UserId}", 
                        ex.Message, userId ?? "Anonymous");
                    break;
                default:
                    _logger.LogWarning("Excepción de dominio: {ExceptionType} - {Message} - UserId: {UserId}", 
                        exceptionType, exception.Message, userId ?? "Anonymous");
                    break;
            }
        }
    }
}
