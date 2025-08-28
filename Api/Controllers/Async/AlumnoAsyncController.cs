// Archivo: Api/Controllers/Async/AlumnoAsyncController.cs

using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;
using System.Text.Json;
using Application.Messages;
using Application.Enums;
using Api.Dtos;
using Microsoft.AspNetCore.Authorization;

[Route("api/async/alumnos")]
[ApiController]
[Authorize]
public class AlumnoAsyncController : ControllerBase
{
    private readonly ChannelWriter<RequestMessage> _channelWriter;

    public AlumnoAsyncController(Channel<RequestMessage> channel)
    {
        _channelWriter = channel.Writer;
    }

    // Endpoint para crear un nuevo alumno de forma asincrónica
    [HttpPost]
    public async Task<ActionResult> AddAsync([FromBody] AlumnoDto alumnoDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Serializa el DTO a un string JSON.
        var bodyJson = JsonSerializer.Serialize(alumnoDto);
        
        var requestMessage = new RequestMessage
        {
            // El ID se genera automáticamente en el constructor.
            Operation = OperationType.Insert,
            Table = TableType.Alumnos, // Usa tu Enum para la tabla de alumnos
            BodyJson = bodyJson,
            CallbackUrl = "http://tu-api/callbacks/alumnos/status" // Tu URL de callback para notificaciones
        };

        // El token de correlación es opcional pero muy recomendable
        // requestMessage.GenerateToken();

        // Envía la petición a la cola de forma asíncrona.
        await _channelWriter.WriteAsync(requestMessage);
        
        // Devuelve una respuesta 202 Accepted, indicando que la petición ha sido recibida
        // y se procesará más tarde. Opcionalmente, puedes devolver el ID de correlación
        // para que el cliente pueda rastrear la petición.
        return Accepted(new { Id = requestMessage.Id });
    }
}