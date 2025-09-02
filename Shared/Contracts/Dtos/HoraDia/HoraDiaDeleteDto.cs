using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.HoraDia
{
  public sealed record class HoraDeleteDto
  {
    [Required]
    public int Id { get; init; }
  }
}