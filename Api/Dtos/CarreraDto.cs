using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
  public class CarreraDto
  {
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo 'Codigo' es obligatorio.")]
    [StringLength(10, ErrorMessage = "El campo 'Codigo' no puede tener más de 10 caracteres.")]
    public required string Codigo { get; set; }

    [Required(ErrorMessage = "El campo 'MODALIDAD' es obligatorio.")]
    public required short MODALIDAD { get; set; }

    [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
    [StringLength(63, ErrorMessage = "El campo 'Nombre' no puede tener más de 63 caracteres.")]
    public required string Nombre { get; set; }

  }
}
