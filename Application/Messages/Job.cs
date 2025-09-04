// Application/Messages/Job.cs
using System.Security.Cryptography;
using System.Text;
using Application.Enums;

namespace Application.Messages
{
    public class Job
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string? Token { get; private set; }
        public required OperationType Operation { get; set; }   // Create/GetAll/GetById/Update/Delete
        public required string Resource { get; set; }           // "alumno", "grupo", ...
        public required string BodyJson { get; set; }           // 👈 ahora string JSON
        public RequestState State { get; set; } = RequestState.Pending;
        public required string CallbackUrl { get; set; }
        public string? ResultDataJson { get; set; }
        public string? Errors { get; set; }

        public void GenerateToken()
        {
            var raw = $"{Operation}|{Resource}|{BodyJson}";
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(raw));
            Token = Convert.ToHexString(bytes).ToLowerInvariant();
        }
    }
}
