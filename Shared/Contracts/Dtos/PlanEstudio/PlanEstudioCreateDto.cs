using System.ComponentModel.DataAnnotations;
namespace Shared.Contracts.Dtos.PlanEstudio
{


  public sealed record class PlanEstudioCreateDto
  {
    [Required]
    [StringLength(50)]
    public string? Codigo { get; init; }

    [Required]
    public int CarreraId { get; init; }
  }

}
