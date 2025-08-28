// Archivo: Api/Controllers/Async/MateriaAsyncController.cs

using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;
using System.Text.Json;
using Application.Messages;
using Application.Enums;
using Api.Dtos;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Api.Controllers.Async
{
    [Route("api/async/materias")]
    [ApiController]
    //[Authorize]
    public class MateriaAsyncController : ControllerBase
    {
        private readonly ChannelWriter<RequestMessage> _channelWriter;
        private readonly RequestStatusTracker _tracker;

        public MateriaAsyncController(Channel<RequestMessage> channel, RequestStatusTracker tracker)
        {
            _channelWriter = channel.Writer;
            _tracker = tracker;
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] MateriaDto materiaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bodyJson = JsonSerializer.Serialize(materiaDto);

            var requestMessage = new RequestMessage
            {
                // El ID se genera en el constructor, no lo asignamos aquí.
                Operation = OperationType.Insert,
                Table = TableType.Materias,
                BodyJson = bodyJson,
                CallbackUrl = "http://tu-api/callbacks/alumnos/status"
            };

            // 1. Registra la petición con el ID que se generó automáticamente.
            _tracker.AddRequest(requestMessage.Id, "Petición recibida y en cola.");

            requestMessage.GenerateToken();

            await _channelWriter.WriteAsync(requestMessage);

            // 2. Devuelve el ID generado para que el cliente pueda rastrear la petición.
            return Accepted(new { RequestId = requestMessage.Id, Status = "Pending" });
        }
    }
}