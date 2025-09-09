// Api/Controllers/AlumnoAsyncController.cs
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Hangfire;
using Application.Enums;
using Application.Messages;
using Infrastructure.Background;
using Shared.Contracts.Dtos.Alumno;

namespace Api.Controllers.Async;

[ApiController]
[Route("api/[controller]")]
public class AlumnoAsyncController : ControllerBase
{
    private readonly IBackgroundJobClient _worker;
    private static readonly JsonSerializerOptions _json = new(JsonSerializerDefaults.Web);

    public AlumnoAsyncController(IBackgroundJobClient jobs)
    {
        _worker = jobs;
    }
    // GET api/alumno
    [HttpGet]
    public IActionResult GetAll()
    {
        var job = new Job
        {
            Operation = OperationType.GetAll,
            Resource = "alumno",
            BodyJson = null, // ahora sí puedes dejarlo nulo
            CallbackUrl = "https://mi-callback/alumno/getall"
        };
        job.GenerateToken();

        var jid = _worker.Enqueue<Worker>(w => w.RunAsync(null, job, default));
        return Accepted(new { jobId = jid, job.Token });
    }
    // POST api/alumno
    [HttpPost]
    public IActionResult Create([FromBody] AlumnoCreateDto dto)
    {
        var job = new Job
        {
            Operation = OperationType.Create,
            Resource = "alumno",
            BodyJson = JsonSerializer.Serialize(dto, _json),
            CallbackUrl = "https://mi-callback/alumno/create"
        };
        job.GenerateToken();

        var jid = _worker.Enqueue<Worker>(w => w.RunAsync(null, job, default));
        return Accepted(new { jobId = jid, job.Token });
    }



    // GET api/alumno/123
    [HttpGet("{id:int}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var body = new { id };
        var job = new Job
        {
            Operation = OperationType.GetById,
            Resource = "alumno",
            BodyJson = JsonSerializer.Serialize(body, _json),
            CallbackUrl = "https://mi-callback/alumno/getbyid"
        };
        job.GenerateToken();

        var jid = _worker.Enqueue<Worker>(w => w.RunAsync(null, job, default));
        return Accepted(new { jobId = jid, job.Token });
    }

    // PUT api/alumno/123
    [HttpPut("{id:int}")]
    public IActionResult Update([FromRoute] int id, [FromBody] AlumnoUpdateDto dto)
    {
        // BodyJson se arma como { id, dto }
        var body = new { id, dto };
        var job = new Job
        {
            Operation = OperationType.Update,
            Resource = "alumno",
            BodyJson = JsonSerializer.Serialize(body, _json),
            CallbackUrl = "https://mi-callback/alumno/update"
        };
        job.GenerateToken();

        var jid = _worker.Enqueue<Worker>(w => w.RunAsync(null, job, default));
        return Accepted(new { jobId = jid, job.Token });
    }

    // DELETE api/alumno/123
    [HttpDelete("{id:int}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var body = new { id };
        var job = new Job
        {
            Operation = OperationType.Delete,
            Resource = "alumno",
            BodyJson = JsonSerializer.Serialize(body, _json),
            CallbackUrl = "https://mi-callback/alumno/delete"
        };
        job.GenerateToken();

        var jid = _worker.Enqueue<Worker>(w => w.RunAsync(null, job, default));
        return Accepted(new { jobId = jid, job.Token });
    }
}
