using Application.Enums;

public class RequestStatusRecord
{
    public Guid RequestId { get; set; }
    public RequestState Status { get; set; }
    public string Message { get; set; } = string.Empty;
    public string? ErrorMessage { get; set; }
    public string? ResultDataJson { get; set; }
}