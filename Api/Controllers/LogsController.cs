using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogsController : ControllerBase
    {
        [HttpGet("latest")]
        public IActionResult GetLatestLogs([FromQuery] int lines = 50)
        {
            try
            {
                var logPath = "logs";
                var logFiles = Directory.GetFiles(logPath, "*.log")
                    .OrderByDescending(f => System.IO.File.GetLastWriteTime(f))
                    .FirstOrDefault();

                if (logFiles == null)
                {
                    return NotFound(new { message = "No se encontraron archivos de log" });
                }

                var logContent = System.IO.File.ReadAllLines(logFiles)
                    .TakeLast(lines)
                    .ToArray();

                return Ok(new
                {
                    file = Path.GetFileName(logFiles),
                    lastModified = System.IO.File.GetLastWriteTime(logFiles),
                    lines = logContent,
                    totalLines = logContent.Length
                });
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error al leer logs");
                return StatusCode(500, new { message = "Error al leer logs", error = ex.Message });
            }
        }

        [HttpGet("files")]
        public IActionResult GetLogFiles()
        {
            try
            {
                var logPath = "logs";
                var logFiles = Directory.GetFiles(logPath, "*.log")
                    .Select(f => new
                    {
                        name = Path.GetFileName(f),
                        size = new FileInfo(f).Length,
                        lastModified = System.IO.File.GetLastWriteTime(f),
                        path = f
                    })
                    .OrderByDescending(f => f.lastModified)
                    .ToArray();

                return Ok(new
                {
                    files = logFiles,
                    totalFiles = logFiles.Length
                });
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error al listar archivos de log");
                return StatusCode(500, new { message = "Error al listar logs", error = ex.Message });
            }
        }

        [HttpGet("search")]
        public IActionResult SearchLogs([FromQuery] string searchTerm, [FromQuery] int lines = 100)
        {
            try
            {
                var logPath = "logs";
                var logFiles = Directory.GetFiles(logPath, "*.log")
                    .OrderByDescending(f => System.IO.File.GetLastWriteTime(f))
                    .FirstOrDefault();

                if (logFiles == null)
                {
                    return NotFound(new { message = "No se encontraron archivos de log" });
                }

                var allLines = System.IO.File.ReadAllLines(logFiles);
                var matchingLines = allLines
                    .Where(line => line.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    .TakeLast(lines)
                    .ToArray();

                return Ok(new
                {
                    file = Path.GetFileName(logFiles),
                    searchTerm = searchTerm,
                    matchingLines = matchingLines,
                    totalMatches = matchingLines.Length,
                    totalLinesSearched = allLines.Length
                });
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error al buscar en logs");
                return StatusCode(500, new { message = "Error al buscar en logs", error = ex.Message });
            }
        }
    }
}
