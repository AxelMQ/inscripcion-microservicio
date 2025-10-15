using System.Net;
using System.Text.Json;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Api.Services;

namespace Api.Middleware
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;
        private readonly IExceptionLoggingService _exceptionLoggingService;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger, IExceptionLoggingService exceptionLoggingService)
        {
            _next = next;
            _logger = logger;
            _exceptionLoggingService = exceptionLoggingService;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // Obtener información del usuario si está disponible
                var userId = context.User?.Identity?.Name ?? context.User?.FindFirst("sub")?.Value;
                
                // Log estructurado de la excepción
                _exceptionLoggingService.LogException(ex, userId);
                
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            var errorResponse = new ErrorResponse();

            switch (exception)
            {
                case HorarioMateriaNotFoundException ex:
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    errorResponse = new ErrorResponse
                    {
                        StatusCode = response.StatusCode,
                        Message = ex.Message,
                        Details = $"HorarioMateria con ID {ex.HorarioMateriaId} no encontrado",
                        Type = "HorarioMateriaNotFound",
                        Timestamp = DateTime.UtcNow
                    };
                    break;

                case AlumnoNotFoundException ex:
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    errorResponse = new ErrorResponse
                    {
                        StatusCode = response.StatusCode,
                        Message = ex.Message,
                        Details = $"Alumno con ID {ex.AlumnoId} no encontrado",
                        Type = "AlumnoNotFound",
                        Timestamp = DateTime.UtcNow
                    };
                    break;

                case InscripcionNotFoundException ex:
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    errorResponse = new ErrorResponse
                    {
                        StatusCode = response.StatusCode,
                        Message = ex.Message,
                        Details = $"Inscripción con ID {ex.InscripcionId} no encontrada",
                        Type = "InscripcionNotFound",
                        Timestamp = DateTime.UtcNow
                    };
                    break;

                case NoSeatsAvailableException ex:
                    response.StatusCode = (int)HttpStatusCode.Conflict;
                    errorResponse = new ErrorResponse
                    {
                        StatusCode = response.StatusCode,
                        Message = ex.Message,
                        Details = "No hay cupos disponibles para la materia solicitada",
                        Type = "NoSeatsAvailable",
                        Timestamp = DateTime.UtcNow
                    };
                    break;

                case ValidationException ex:
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    errorResponse = new ErrorResponse
                    {
                        StatusCode = response.StatusCode,
                        Message = ex.Message,
                        Details = "Errores de validación en los datos enviados",
                        Type = "ValidationError",
                        ValidationErrors = ex.Errors,
                        Timestamp = DateTime.UtcNow
                    };
                    break;

                case BusinessRuleException ex:
                    response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                    errorResponse = new ErrorResponse
                    {
                        StatusCode = response.StatusCode,
                        Message = ex.Message,
                        Details = $"Violación de regla de negocio: {ex.RuleName}",
                        Type = "BusinessRuleViolation",
                        Timestamp = DateTime.UtcNow
                    };
                    break;

                case UnauthorizedAccessException:
                    response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    errorResponse = new ErrorResponse
                    {
                        StatusCode = response.StatusCode,
                        Message = "No autorizado para realizar esta acción",
                        Details = "El usuario no tiene permisos suficientes",
                        Type = "Unauthorized",
                        Timestamp = DateTime.UtcNow
                    };
                    break;

                default:
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    errorResponse = new ErrorResponse
                    {
                        StatusCode = response.StatusCode,
                        Message = "Error interno del servidor",
                        Details = "Ha ocurrido un error inesperado. Por favor, contacte al administrador.",
                        Type = "InternalServerError",
                        Timestamp = DateTime.UtcNow
                    };
                    break;
            }

            var jsonResponse = JsonSerializer.Serialize(errorResponse, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            await response.WriteAsync(jsonResponse);
        }
    }

    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public Dictionary<string, string[]>? ValidationErrors { get; set; }
    }
}
