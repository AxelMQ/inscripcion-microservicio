using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
  public class CarreraDto
  {
    public int ID { get; set; }

    [Required(ErrorMessage = "El campo 'CODIGO' es obligatorio.")]
    [StringLength(10, ErrorMessage = "El campo 'CODIGO' no puede tener más de 10 caracteres.")]
    public required string CODIGO { get; set; }

    [Required(ErrorMessage = "El campo 'MODALIDAD' es obligatorio.")]
    public required short MODALIDAD { get; set; }

    [Required(ErrorMessage = "El campo 'NOMBRE' es obligatorio.")]
    [StringLength(63, ErrorMessage = "El campo 'NOMBRE' no puede tener más de 63 caracteres.")]
    public required string NOMBRE { get; set; }

  }
}
