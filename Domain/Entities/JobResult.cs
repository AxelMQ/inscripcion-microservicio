namespace Domain.Entities
{
    public class JobResult
    {
        /// <summary>
        /// Hangfire JobId (clave natural).
        /// </summary>
        public string Id { get; set; } = default!;

        /// <summary>
        /// Clave de idempotencia (para detectar reintentos con mismo payload).
        /// </summary>
        public string IdempotencyKey { get; set; } = default!;

        /// <summary>
        /// Nombre de la cola donde se encoló.
        /// </summary>
        public string Queue { get; set; } = default!;

        /// <summary>
        /// Nombre del recurso lógico (ej. "alumno").
        /// </summary>
        public string Resource { get; set; } = default!;

        /// <summary>
        /// Operación ejecutada (ej. Create, Update...).
        /// </summary>
        public string Operation { get; set; } = default!;

        /// <summary>
        /// Estado del job: Pending, Processing, Completed, Failed.
        /// </summary>
        public JobStatus Status { get; set; } = JobStatus.Pending;

        /// <summary>
        /// JSON serializado con los datos de entrada/salida relevantes.
        /// </summary>
        public string? DataJson { get; set; }

        /// <summary>
        /// Error textual (si falló).
        /// </summary>
        public string? Error { get; set; }

        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
        public DateTime? StartedUtc { get; set; }
        public DateTime? FinishedUtc { get; set; }
    }

    public enum JobStatus
    {
        Pending,
        Processing,
        Completed,
        Failed
    }
}
