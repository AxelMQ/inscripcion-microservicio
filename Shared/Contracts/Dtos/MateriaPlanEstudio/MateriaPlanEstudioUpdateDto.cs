
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.MateriaPlanEstudio
{
  public sealed record class MateriaPlanEstudioUpdateDto
  {
    [Required]
    public int MateriaId { get; init; }

    [Required]
    public int NivelId { get; init; }

    [Required]
    public int PlanEstudioId { get; init; }
  }
}
