// Api/Controllers/StatusController.cs
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

[Route("api/status")]
[ApiController]
// [Authorize]
public class StatusController : ControllerBase
{
    private readonly RequestStatusTracker _tracker;

    public StatusController(RequestStatusTracker tracker) => _tracker = tracker;

    [HttpGet("{id:guid}")]
    public IActionResult GetStatus(Guid id)
    {
        var status = _tracker.GetStatus(id);
        if (status is null)
            return NotFound(new { message = "Id de petición no encontrado." });

        object? resultData = null;
        if (!string.IsNullOrWhiteSpace(status.ResultDataJson))
        {
            // 👇 convierte el string a JSON “desenrollado”
            resultData = JsonSerializer.Deserialize<object>(status.ResultDataJson);
            // alternativa más ligera:
            // resultData = JsonDocument.Parse(status.ResultDataJson).RootElement;
        }

        return Ok(new
        {
            requestId    = status.RequestId,
            status       = status.Status.ToString(),
            message      = status.Message,
            errorMessage = status.ErrorMessage,
            resultData, // 👈 ahora como JSON anidado
            createdUtc   = status.CreatedUtc,
            completedUtc = status.CompletedUtc
        });
    }
}
