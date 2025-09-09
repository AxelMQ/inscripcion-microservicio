
using System.ComponentModel.DataAnnotations;
namespace Shared.Contracts.Dtos.Alumno
{
  public sealed record class AlumnoUpdateDto
  {
    [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
    [StringLength(60, ErrorMessage = "El campo 'Nombre' no puede tener más de 60 caracteres.")]
    public required string Nombre { get; init; }

    [Required(ErrorMessage = "El campo 'Ppa' es obligatorio.")]
    public decimal Ppa { get; init; }

    public int Telefono { get; init; }

    [Required(ErrorMessage = "El campo 'Registro' es obligatorio.")]
    public int Registro { get; init; }
  }
}
