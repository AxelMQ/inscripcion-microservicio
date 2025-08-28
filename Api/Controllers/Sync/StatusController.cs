// Api/Controllers/StatusController.cs
using Microsoft.AspNetCore.Mvc;
using System;

[Route("api/status")]
[ApiController]
public class StatusController : ControllerBase
{
    private readonly RequestStatusTracker _tracker;

    public StatusController(RequestStatusTracker tracker)
    {
        _tracker = tracker;
    }

    [HttpGet("{id}")]
    public IActionResult GetStatus(Guid id)
    {
        var status = _tracker.GetStatus(id);
        if (status == null)
        {
            return NotFound("ID de petición no encontrado.");
        }
        return Ok(status);
    }
}