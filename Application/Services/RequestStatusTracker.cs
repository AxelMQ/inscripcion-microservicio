// Services/RequestStatusTracker.cs
using System.Collections.Concurrent;
using Application.Enums;

public sealed class RequestStatusTracker
{
    private readonly ConcurrentDictionary<Guid, RequestStatusRecord> _requests = new();

    public RequestStatusRecord AddRequest(Guid requestId, string initialMessage = "Pending")
    {
        var record = new RequestStatusRecord
        {
            RequestId   = requestId,
            Status      = RequestState.Pending,
            Message     = initialMessage,
            CreatedUtc  = DateTime.UtcNow   // <- si lo agregas al record
        };
        _requests[requestId] = record;
        return record;
    }

    // Para el StatusController (y para chequear existencia)
    public bool TryGet(Guid requestId, out RequestStatusRecord record)
        => _requests.TryGetValue(requestId, out record!);

    // Actualiza estado (permite pasar mensaje y error)
    public void UpdateStatus(Guid requestId, RequestState newStatus, string? message = null, string? error = null)
    {
        if (_requests.TryGetValue(requestId, out var record))
        {
            record.Status = newStatus;
            if (message is not null) record.Message = message;
            if (error   is not null) record.ErrorMessage = error;

            if (newStatus is RequestState.Completed or RequestState.Failed)
                record.CompletedUtc = DateTime.UtcNow; // <- si lo agregas al record
        }
    }

    // Guarda el payload serializado (lista, objeto, etc.) y marca como Completed
    public void SetResult(Guid requestId, string resultJson, string? message = "Completed")
    {
        if (_requests.TryGetValue(requestId, out var record))
        {
            record.ResultDataJson = resultJson;
            record.Status = RequestState.Completed;
            if (message is not null) record.Message = message;
            record.CompletedUtc = DateTime.UtcNow; // <- si lo agregas al record
        }
    }

    // Obtiene el estado (versión que devuelve null si no existe)
    public RequestStatusRecord? GetStatus(Guid requestId)
        => _requests.TryGetValue(requestId, out var record) ? record : null;

    // Quita un request del tracker (útil para limpieza manual)
    public bool Remove(Guid requestId) => _requests.TryRemove(requestId, out _);

    // Limpia requests finalizados hace mucho tiempo (opcional)
    public int Cleanup(TimeSpan olderThan)
    {
        var cutoff = DateTime.UtcNow - olderThan;
        var removed = 0;

        foreach (var kv in _requests)
        {
            var rec = kv.Value;
            if (rec.CompletedUtc is DateTime done && done < cutoff)
            {
                if (_requests.TryRemove(kv.Key, out _))
                    removed++;
            }
        }
        return removed;
    }
}
