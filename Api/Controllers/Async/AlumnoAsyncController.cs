// Ejemplo: Api/Controllers/Async/AlumnoAsyncController.cs
using System.Text.Json;
using Application.Enums;
using Application.Messages;
using Hangfire;
using Hangfire.States;
using Infrastructure.Background;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Alumno;

namespace Api.Controllers.Async;

[ApiController]
[Route("api/async/alumnos")]
public class AlumnoAsyncController : ControllerBase
{
    private readonly IBackgroundJobClient worker;

    public AlumnoAsyncController(IBackgroundJobClient worker)
    {
        this.worker = worker;
    }

    [HttpPost] // Create → cola default
    public IActionResult Create([FromBody] AlumnoCreateDto dto)
    {
        var job = new Job
        {
            Operation = OperationType.Create,
            Resource = "alumno",
            BodyJson = JsonSerializer.Serialize(dto),
            CallbackUrl = "https://miapp/callbacks/job"
        };
        job.GenerateToken();

        var jobId = worker.Enqueue<Worker>(
            r => r.RunAsync(null, job, default));

        return Accepted($"/api/jobs/{jobId}", new { jobId, token = job.Token });
    }

    [HttpGet] // GetAll → cola critical
    public IActionResult GetAll()
    {
        var job = new Job
        {
            Operation = OperationType.GetAll,
            Resource = "alumno",
            BodyJson = "{}",
            CallbackUrl = "https://miapp/callbacks/job"
        };
        job.GenerateToken();

        var jobId = worker.Create<Worker>(
            r => r.RunAsync(null, job, default),
            new EnqueuedState("critical")
        );

        return Accepted($"/api/jobs/{jobId}", new { jobId, token = job.Token });
    }

    [HttpGet("{id:int}")] // GetById → cola default
    public IActionResult GetById(int id)
    {
        var job = new Job
        {
            Operation = OperationType.GetById,
            Resource = "alumno",
            BodyJson = JsonSerializer.Serialize(new { id }),
            CallbackUrl = "https://miapp/callbacks/job"
        };
        job.GenerateToken();

        var jobId = worker.Enqueue<Worker>(
            r => r.RunAsync(null, job, default));

        return Accepted($"/api/jobs/{jobId}", new { jobId, token = job.Token });
    }

    [HttpPut("{id:int}")] // Update → cola default
    public IActionResult Update(int id, [FromBody] AlumnoUpdateDto dto)
    {
        var job = new Job
        {
            Operation = OperationType.Update,
            Resource = "alumno",
            BodyJson = JsonSerializer.Serialize(new { id, payload = dto }),
            CallbackUrl = "https://miapp/callbacks/job"
        };
        job.GenerateToken();

        var jobId = worker.Enqueue<Worker>(
            r => r.RunAsync(null, job, default));

        return Accepted($"/api/jobs/{jobId}", new { jobId, token = job.Token });
    }

    [HttpDelete("{id:int}")] // Delete → cola default
    public IActionResult Delete(int id)
    {
        var job = new Job
        {
            Operation = OperationType.Delete,
            Resource = "alumno",
            BodyJson = JsonSerializer.Serialize(new { id }),
            CallbackUrl = "https://miapp/callbacks/job"
        };
        job.GenerateToken();

        var jobId = worker.Enqueue<Worker>(
            r => r.RunAsync(null, job, default));

        return Accepted($"/api/jobs/{jobId}", new { jobId, token = job.Token });
    }
}
