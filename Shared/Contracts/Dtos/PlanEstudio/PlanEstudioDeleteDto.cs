using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.PlanEstudio
{
  public sealed record class PlanEstudioDeleteDto
  {
    [Required]
    public int Id { get; init; }
  }

}
