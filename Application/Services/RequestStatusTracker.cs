// Services/RequestStatusTracker.cs
using System.Collections.Concurrent;
using Application.Enums;
using System;

public class RequestStatusTracker
{
    private readonly ConcurrentDictionary<Guid, RequestStatusRecord> _requests = new();

    public void AddRequest(Guid requestId, string initialMessage)
    {
        _requests[requestId] = new RequestStatusRecord
        {
            RequestId = requestId,
            Status = RequestState.Pending,
            Message = initialMessage
        };
    }

    public void UpdateStatus(Guid requestId, RequestState newStatus, string message = "")
    {
        if (_requests.TryGetValue(requestId, out var record))
        {
            record.Status = newStatus;
            record.Message = message;
        }
    }

    public RequestStatusRecord? GetStatus(Guid requestId)
    {
        _requests.TryGetValue(requestId, out var record);
        return record;
    }
}