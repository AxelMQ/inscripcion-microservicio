using Application.Enums;
using System.Security.Cryptography;
using System.Text;

namespace Application.Messages
{
  public class RequestMessage
  {
    public Guid Id { get; private set; }
    public string? Token { get; private set; }
    public required OperationType Operation { get; set; }
    public required TableType Table { get; set; }
    public required string BodyJson { get; set; }
    public RequestState State { get; set; } = RequestState.Pending;

    public required string CallbackUrl { get; set; }

    public RequestMessage()
    {
      Id = Guid.NewGuid();
    }

    public void GenerateToken()
    {
      // Combina los datos que usarás para generar el token
      string dataToHash = $"{Operation}|{Table}|{BodyJson}";

      using (SHA256 sha256 = SHA256.Create())
      {
        byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(dataToHash));
        this.Token = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
      }
    }
  }
}