using Application.Enums;

public class RequestStatusRecord
{
    public Guid RequestId { get; set; }
    public RequestState Status { get; set; }
    public string Message { get; set; } = string.Empty;
    public string? ErrorMessage { get; set; }

    // aquí guardas el resultado serializado
    public string? ResultDataJson { get; set; }

    // opcionales para limpieza/telemetría
    public DateTime CreatedUtc { get; set; }
    public DateTime? CompletedUtc { get; set; }
}
