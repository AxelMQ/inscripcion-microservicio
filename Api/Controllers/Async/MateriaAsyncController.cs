// Api/Controllers/Async/MateriaAsyncController.cs
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Channels;
using Application.Enums;
using Application.Messages;
using Shared.Contracts.Dtos.Materia;

namespace Api.Controllers.Async
{
    [ApiController]
    [Route("api/[controller]")]
    public class MateriaAsyncController : ControllerBase
    {
        private readonly ChannelWriter<RequestMessage> _writer;
        private readonly RequestStatusTracker _tracker;

        private static readonly JsonSerializerOptions JsonOpts = new(JsonSerializerDefaults.Web)
        {
            PropertyNameCaseInsensitive = true
        };

        public MateriaAsyncController(Channel<RequestMessage> channel, RequestStatusTracker tracker)
        {
            _writer = channel.Writer;
            _tracker = tracker;
        }

        // POST /api/async/materias
        [HttpPost]
        public async Task<ActionResult> EnqueueCreate([FromBody] MateriaCreateDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var req = new RequestMessage
            {
                Operation   = OperationType.Insert,
                Table       = TableType.Materias,
                BodyJson    = JsonSerializer.Serialize(dto, JsonOpts),
                CallbackUrl = "http://tu-api/callbacks/materias/status"
            };

            _tracker.AddRequest(req.Id, "En cola.");
            req.GenerateToken();
            await _writer.WriteAsync(req);

            var statusUrl = Url.Content($"~/api/status/{req.Id}");
            return Accepted(new { RequestId = req.Id, Status = "Pending", StatusUrl = statusUrl });
        }

        // PUT /api/async/materias/{id}
        [HttpPut("{id:int}")]
        public async Task<ActionResult> EnqueueUpdate(int id, [FromBody] MateriaUpdateDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (dto.Id != id) return BadRequest("El Id del body no coincide con el de la ruta.");

            var req = new RequestMessage
            {
                Operation   = OperationType.Update,
                Table       = TableType.Materias,
                BodyJson    = JsonSerializer.Serialize(dto, JsonOpts),
                CallbackUrl = "http://tu-api/callbacks/materias/status"
            };

            _tracker.AddRequest(req.Id, "En cola.");
            req.GenerateToken();
            await _writer.WriteAsync(req);

            var statusUrl = Url.Content($"~/api/status/{req.Id}");
            return Accepted(new { RequestId = req.Id, Status = "Pending", StatusUrl = statusUrl });
        }

        // DELETE /api/async/materias/{id}
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> EnqueueDelete(int id)
        {
            var dto = new MateriaDeleteDto { Id = id };

            var req = new RequestMessage
            {
                Operation   = OperationType.Delete,
                Table       = TableType.Materias,
                BodyJson    = JsonSerializer.Serialize(dto, JsonOpts),
                CallbackUrl = "http://tu-api/callbacks/materias/status"
            };

            _tracker.AddRequest(req.Id, "En cola.");
            req.GenerateToken();
            await _writer.WriteAsync(req);

            var statusUrl = Url.Content($"~/api/status/{req.Id}");
            return Accepted(new { RequestId = req.Id, Status = "Pending", StatusUrl = statusUrl });
        }

        // GET /api/async/materias
        [HttpGet]
        public async Task<ActionResult> EnqueueGetAll()
        {
            var req = new RequestMessage
            {
                Operation   = OperationType.GetAll,
                Table       = TableType.Materias,
                BodyJson    = "{}",
                CallbackUrl = "http://tu-api/callbacks/materias/status"
            };

            _tracker.AddRequest(req.Id, "En cola.");
            req.GenerateToken();
            await _writer.WriteAsync(req);

            var statusUrl = Url.Content($"~/api/status/{req.Id}");
            return Accepted(new { RequestId = req.Id, Status = "Pending", StatusUrl = statusUrl });
        }

        // GET /api/async/materias/enqueue/{id}
        [HttpGet("enqueue/{id:int}")]
        public async Task<ActionResult> EnqueueGetById(int id)
        {
            // Puedes definir un IdDto compartido si quieres evitar el tipo anónimo
            var req = new RequestMessage
            {
                Operation   = OperationType.GetById,
                Table       = TableType.Materias,
                BodyJson    = JsonSerializer.Serialize(new { Id = id }, JsonOpts),
                CallbackUrl = "http://tu-api/callbacks/materias/status"
            };

            _tracker.AddRequest(req.Id, "En cola.");
            req.GenerateToken();
            await _writer.WriteAsync(req);

            var statusUrl = Url.Content($"~/api/status/{req.Id}");
            return Accepted(new { RequestId = req.Id, Status = "Pending", StatusUrl = statusUrl });
        }
    }
}
