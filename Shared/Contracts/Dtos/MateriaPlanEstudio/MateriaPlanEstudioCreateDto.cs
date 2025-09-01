namespace Shared.Contracts.Dtos.MateriaPlanEstudio
{
  using System.ComponentModel.DataAnnotations;

  public sealed record class MateriaPlanEstudioCreateDto
  {
    [Required]
    public int MateriaId { get; init; }

    [Required]
    public int NivelId { get; init; }

    [Required]
    public int PlanEstudioId { get; init; }
  }
}
