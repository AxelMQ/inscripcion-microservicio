// Ejemplo: Api/Controllers/Async/AlumnoAsyncController.cs
using System.Text.Json;
using Application.Enums;
using Application.Messages;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Shared.Contracts.Dtos.Alumno;

[ApiController]
[Route("api/async/alumnos")]
public class AlumnoAsyncController : ControllerBase
{
    [HttpPost] // Create
    public IActionResult Create([FromBody] AlumnoCreateDto dto)
    {
        var job = new Job
        {
            Operation   = OperationType.Create,
            Resource    = "alumno",
            BodyJson    = JsonSerializer.Serialize(dto),      // 👈 string JSON
            CallbackUrl = "https://miapp/callbacks/job"
        };
        job.GenerateToken();

        var jobId = BackgroundJob.Enqueue<Infrastructure.Background.GenericJobRunner>(
            r => r.RunAsync(null, job, default));

        return Accepted($"/api/jobs/{jobId}", new { jobId, token = job.Token });
    }

    [HttpGet] // GetAll
    public IActionResult GetAll()
    {
        var job = new Job
        {
            Operation   = OperationType.GetAll,
            Resource    = "alumno",
            BodyJson    = "{}",                                 // 👈 vacío como objeto
            CallbackUrl = "https://miapp/callbacks/job"
        };
        job.GenerateToken();

        var jobId = BackgroundJob.Enqueue<Infrastructure.Background.GenericJobRunner>(
            r => r.RunAsync(null, job, default));

        return Accepted($"/api/jobs/{jobId}", new { jobId, token = job.Token });
    }

    [HttpGet("{id:int}")] // GetById
    public IActionResult GetById(int id)
    {
        var job = new Job
        {
            Operation   = OperationType.GetById,
            Resource    = "alumno",
            BodyJson    = JsonSerializer.Serialize(new { id }), // 👈 {"id": ...}
            CallbackUrl = "https://miapp/callbacks/job"
        };
        job.GenerateToken();

        var jobId = BackgroundJob.Enqueue<Infrastructure.Background.GenericJobRunner>(
            r => r.RunAsync(null, job, default));

        return Accepted($"/api/jobs/{jobId}", new { jobId, token = job.Token });
    }

    [HttpPut("{id:int}")] // Update con wrapper id + payload (si tu UpdateAsync recibe id aparte)
    public IActionResult Update(int id, [FromBody] AlumnoUpdateDto dto)
    {
        var job = new Job
        {
            Operation   = OperationType.Update,
            Resource    = "alumno",
            BodyJson    = JsonSerializer.Serialize(new { id, payload = dto }),
            CallbackUrl = "https://miapp/callbacks/job"
        };
        job.GenerateToken();

        var jobId = BackgroundJob.Enqueue<Infrastructure.Background.GenericJobRunner>(
            r => r.RunAsync(null, job, default));

        return Accepted($"/api/jobs/{jobId}", new { jobId, token = job.Token });
    }

    [HttpDelete("{id:int}")] // Delete
    public IActionResult Delete(int id)
    {
        var job = new Job
        {
            Operation   = OperationType.Delete,
            Resource    = "alumno",
            BodyJson    = JsonSerializer.Serialize(new { id }),
            CallbackUrl = "https://miapp/callbacks/job"
        };
        job.GenerateToken();

        var jobId = BackgroundJob.Enqueue<Infrastructure.Background.GenericJobRunner>(
            r => r.RunAsync(null, job, default));

        return Accepted($"/api/jobs/{jobId}", new { jobId, token = job.Token });
    }
}
