// Shared/Contracts/Dtos/Alumno/AlumnoDeleteDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Materia
{
  public sealed record class MateriaDeleteDto
  {
    [Required]
    public int Id { get; init; }
  }
}