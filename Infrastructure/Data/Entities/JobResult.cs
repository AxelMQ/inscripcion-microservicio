namespace Infrastructure.Data.Entities
{
    public class JobResult
    {
        public string Id { get; set; } = default!; // Hangfire JobId
        public string? Status { get; set; }
        public string? DataJson { get; set; }
        public string? Error { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime? FinishedUtc { get; set; }
    }

    public enum JobStatus
    {
        Pending, Processing, Completed, Failed
    }
}
