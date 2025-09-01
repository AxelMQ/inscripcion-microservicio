using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Grupo
{
  public sealed record class GrupoDeleteDto
  {
    [Required]
    public int Id { get; init; }
  }
}