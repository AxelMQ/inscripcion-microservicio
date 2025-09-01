
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.PlanEstudio
{
  public sealed record class PlanEstudioUpdateDto
  {
    [Required]
    public int Id { get; init; }

    [Required]
    public int MateriaId { get; init; }

    [Required]
    public int NivelId { get; init; }

    [Required]
    public int PlanEstudioId { get; init; }
  }
}
