// Shared/Contracts/Dtos/Alumno/AlumnoDeleteDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Alumno
{
  public sealed record class AlumnoDeleteDto
  {
    [Required]
    public int Id { get; init; }
  }
}