using System.Security.Cryptography;
using System.Text;
using Application.Enums;

namespace Application.Messages
{
    /// Mensaje para ejecución asincrónica (no guarda estado; eso vive en JobResult).
    public class Job
    {
        /// Correlativo opcional (no es el Hangfire JobId).
        public Guid Id { get; private set; } = Guid.NewGuid();

        /// Clave de idempotencia derivada del contenido (server-side).
        public string IdempotencyKey { get; private set; } = string.Empty;

        /// Operación: Create/GetAll/GetById/Update/Delete
        public required OperationType Operation { get; set; }

        /// Recurso lógico: "alumno", "grupo", etc.
        public required string Resource { get; set; }

        /// Cuerpo JSON serializado del DTO (usar serialización estable).
        public string? BodyJson { get; set; }

        /// Cola de Hangfire.
        public string Queue { get; set; } = "default";

        /// URL de callback al completar.
        public required string CallbackUrl { get; set; }

        /// Genera y devuelve la IdempotencyKey en minúsculas (sha256 de op|resource|bodyJson).
        public string GenerateIdempotencyKey()
        {
            var raw = $"{Operation}|{Resource}|{BodyJson}";
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(raw));
            IdempotencyKey = Convert.ToHexString(bytes).ToLowerInvariant();
            return IdempotencyKey;
        }
        public override string ToString()
    => $"{Resource}.{Operation}";

    }

}
