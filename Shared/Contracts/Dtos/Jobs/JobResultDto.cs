namespace Shared.Contracts.Dtos.Jobs
{
    public class JobResultDto
    {
        public string Id { get; set; } = default!;
        public string IdempotencyKey { get; set; } = default!;
        public string Queue { get; set; } = default!;
        public string Resource { get; set; } = default!;
        public string Operation { get; set; } = default!;
        public string Status { get; set; } = default!;
        public string? DataJson { get; set; }
        public string? Error { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime? StartedUtc { get; set; }
        public DateTime? FinishedUtc { get; set; }
    }
}
