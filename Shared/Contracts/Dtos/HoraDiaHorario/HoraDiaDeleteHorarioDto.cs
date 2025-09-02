using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.HoraDiaHorario
{
  public sealed record class HoraDiaHorarioDeleteDto
  {
    [Required]
    public int Id { get; init; }
  }
}