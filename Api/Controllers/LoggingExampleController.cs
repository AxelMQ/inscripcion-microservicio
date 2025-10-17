using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoggingExampleController : ControllerBase
    {
        [HttpGet("success")]
        public IActionResult GetSuccess()
        {
            // 200 OK - Log de información
            Log.Information("✅ [HTTP 200] Solicitud exitosa - Endpoint: /api/loggingexample/success");
            return Ok(new { message = "Operación exitosa", timestamp = DateTime.UtcNow });
        }

        [HttpGet("not-found")]
        public IActionResult GetNotFound()
        {
            // 404 Not Found - Log de advertencia
            Log.Warning("⚠️ [HTTP 404] Recurso no encontrado - Endpoint: /api/loggingexample/not-found");
            return NotFound(new { message = "Recurso no encontrado", code = 404 });
        }

        [HttpGet("unauthorized")]
        public IActionResult GetUnauthorized()
        {
            // 401 Unauthorized - Log de advertencia
            Log.Warning("🔒 [HTTP 401] Acceso no autorizado - Endpoint: /api/loggingexample/unauthorized");
            return Unauthorized(new { message = "Token de acceso requerido", code = 401 });
        }

        [HttpGet("bad-request")]
        public IActionResult GetBadRequest()
        {
            // 400 Bad Request - Log de advertencia
            Log.Warning("❌ [HTTP 400] Solicitud malformada - Endpoint: /api/loggingexample/bad-request");
            return BadRequest(new { message = "Parámetros inválidos", code = 400 });
        }

        [HttpGet("server-error")]
        public IActionResult GetServerError()
        {
            // 500 Internal Server Error - Log de error
            Log.Error("💥 [HTTP 500] Error interno del servidor - Endpoint: /api/loggingexample/server-error");
            return StatusCode(500, new { message = "Error interno del servidor", code = 500 });
        }

        [HttpGet("simulate-exception")]
        public IActionResult SimulateException()
        {
            try
            {
                // Simular una excepción
                throw new InvalidOperationException("Error simulado para demostrar logging");
            }
            
            catch (Exception ex)
            {
                // Log de error con excepción completa
                Log.Error(ex, "💥 [HTTP 500] Excepción capturada - Endpoint: /api/loggingexample/simulate-exception");
                return StatusCode(500, new { 
                    message = "Error interno del servidor", 
                    code = 500,
                    details = "Error simulado para demostrar logging"
                });
            }
        }

        [HttpGet("business-logic/{id}")]
        public IActionResult GetBusinessLogic(int id)
        {
            // Logging de lógica de negocio
            Log.Information("🔍 [HTTP 200] Iniciando lógica de negocio para ID: {Id}", id);

            if (id <= 0)
            {
                Log.Warning("⚠️ [HTTP 400] ID inválido: {Id}", id);
                return BadRequest(new { message = "ID debe ser mayor a 0", code = 400 });
            }

            if (id > 1000)
            {
                Log.Warning("⚠️ [HTTP 404] ID no encontrado: {Id}", id);
                return NotFound(new { message = "Recurso no encontrado", code = 404 });
            }

            // Simular procesamiento
            Log.Information("⚙️ [HTTP 200] Procesando lógica de negocio para ID: {Id}", id);
            
            var result = new { 
                id = id, 
                message = "Lógica de negocio ejecutada exitosamente",
                processedAt = DateTime.UtcNow
            };

            Log.Information("✅ [HTTP 200] Lógica de negocio completada para ID: {Id}", id);
            return Ok(result);
        }
    }
}
