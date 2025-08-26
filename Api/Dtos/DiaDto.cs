using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
  public class DiaDto
  {
    public int ID { get; set; }

    [Required(ErrorMessage = "El campo 'NOMBRE' es obligatorio.")]
    [StringLength(63, ErrorMessage = "El campo 'NOMBRE' no puede tener más de 63 caracteres.")]
    public required string NOMBRE { get; set; }

  }
}
