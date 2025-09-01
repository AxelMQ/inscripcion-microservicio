using System.ComponentModel.DataAnnotations;
namespace Shared.Contracts.Dtos.MateriaPlanEstudio
{
  public sealed record class MateriaPlanEstudioDeleteDto
  {
    [Required]
    public int Id { get; init; }
  }
}
