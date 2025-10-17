using Serilog;
using System.Net;
using System.Text.Json;

namespace Api.Middleware
{
    public class DatabaseErrorMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<DatabaseErrorMiddleware> _logger;

        public DatabaseErrorMiddleware(RequestDelegate next, ILogger<DatabaseErrorMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            
            object response;
            int statusCode;

            // Detectar tipo de error
            switch (exception)
            {
                case Npgsql.NpgsqlException pgEx:
                    Log.Error(pgEx, "🐘 [HTTP 500] Error de PostgreSQL - Código: {ErrorCode}, Mensaje: {Message}", pgEx.SqlState, pgEx.Message);
                    response = new
                    {
                        message = "Error de base de datos PostgreSQL",
                        error = "Error de conexión a PostgreSQL",
                        code = pgEx.SqlState,
                        source = "PostgreSQL Database",
                        timestamp = DateTime.UtcNow,
                        path = context.Request.Path.Value,
                        method = context.Request.Method
                    };
                    statusCode = (int)HttpStatusCode.InternalServerError;
                    break;

                case TimeoutException:
                    Log.Warning("⏰ [HTTP 408] Timeout en operación de base de datos");
                    response = new
                    {
                        message = "Timeout en la operación de base de datos",
                        error = "La operación tardó demasiado tiempo",
                        source = "Database Connection",
                        timestamp = DateTime.UtcNow,
                        path = context.Request.Path.Value,
                        method = context.Request.Method
                    };
                    statusCode = (int)HttpStatusCode.RequestTimeout;
                    break;

                case OperationCanceledException:
                    Log.Warning("⏰ [HTTP 408] Operación cancelada");
                    response = new
                    {
                        message = "Operación cancelada",
                        error = "La operación fue cancelada por el cliente",
                        source = "Client Request",
                        timestamp = DateTime.UtcNow,
                        path = context.Request.Path.Value,
                        method = context.Request.Method
                    };
                    statusCode = (int)HttpStatusCode.RequestTimeout;
                    break;

                default:
                    Log.Error(exception, "💥 [HTTP 500] Error inesperado");
                    response = new
                    {
                        message = "Error interno del servidor",
                        timestamp = DateTime.UtcNow,
                        path = context.Request.Path.Value,
                        method = context.Request.Method
                    };
                    statusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            context.Response.StatusCode = statusCode;
            var jsonResponse = JsonSerializer.Serialize(response, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            await context.Response.WriteAsync(jsonResponse);
        }
    }
}
