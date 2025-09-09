// Api/Controllers/HorarioMateriaAsyncController.cs
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Hangfire;
using Application.Enums;
using Application.Messages;
using Infrastructure.Background;
using Shared.Contracts.Dtos.HorarioMateria;

namespace Api.Controllers.Async;

[ApiController]
[Route("api/[controller]")]
public class HorarioMateriaAsyncController : ControllerBase
{
    private readonly IBackgroundJobClient _worker;
    private static readonly JsonSerializerOptions _json = new(JsonSerializerDefaults.Web);

    public HorarioMateriaAsyncController(IBackgroundJobClient jobs)
    {
        _worker = jobs;
    }
    // GET api/horarioMateria
    [HttpGet]
    public IActionResult GetAll()
    {
        var job = new Job
        {
            Operation = OperationType.GetAll,
            Resource = "horarioMateria",
            BodyJson = null, // ahora sí puedes dejarlo nulo
            CallbackUrl = "https://mi-callback/horarioMateria/getall"
        };
        job.GenerateToken();

        var jid = _worker.Enqueue<Worker>(w => w.RunAsync(null, job, default));
        return Accepted(new { jobId = jid, job.Token });
    }
    // POST api/horarioMateria
    [HttpPost]
    public IActionResult Create([FromBody] HorarioMateriaCreateDto dto)
    {
        var job = new Job
        {
            Operation = OperationType.Create,
            Resource = "horarioMateria",
            BodyJson = JsonSerializer.Serialize(dto, _json),
            CallbackUrl = "https://mi-callback/horarioMateria/create"
        };
        job.GenerateToken();

        var jid = _worker.Enqueue<Worker>(w => w.RunAsync(null, job, default));
        return Accepted(new { jobId = jid, job.Token });
    }



    // GET api/horarioMateria/123
    [HttpGet("{id:int}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var body = new { id };
        var job = new Job
        {
            Operation = OperationType.GetById,
            Resource = "horarioMateria",
            BodyJson = JsonSerializer.Serialize(body, _json),
            CallbackUrl = "https://mi-callback/horarioMateria/getbyid"
        };
        job.GenerateToken();

        var jid = _worker.Enqueue<Worker>(w => w.RunAsync(null, job, default));
        return Accepted(new { jobId = jid, job.Token });
    }

    // PUT api/horarioMateria/123
    [HttpPut("{id:int}")]
    public IActionResult Update([FromRoute] int id, [FromBody] HorarioMateriaUpdateDto dto)
    {
        // BodyJson se arma como { id, dto }
        var body = new { id, dto };
        var job = new Job
        {
            Operation = OperationType.Update,
            Resource = "horarioMateria",
            BodyJson = JsonSerializer.Serialize(body, _json),
            CallbackUrl = "https://mi-callback/horarioMateria/update"
        };
        job.GenerateToken();

        var jid = _worker.Enqueue<Worker>(w => w.RunAsync(null, job, default));
        return Accepted(new { jobId = jid, job.Token });
    }

    // DELETE api/horarioMateria/123
    [HttpDelete("{id:int}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var body = new { id };
        var job = new Job
        {
            Operation = OperationType.Delete,
            Resource = "horarioMateria",
            BodyJson = JsonSerializer.Serialize(body, _json),
            CallbackUrl = "https://mi-callback/horarioMateria/delete"
        };
        job.GenerateToken();

        var jid = _worker.Enqueue<Worker>(w => w.RunAsync(null, job, default));
        return Accepted(new { jobId = jid, job.Token });
    }
}
