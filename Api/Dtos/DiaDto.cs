using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
  public class DiaDto
  {
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
    [StringLength(63, ErrorMessage = "El campo 'Nombre' no puede tener más de 63 caracteres.")]
    public required string Nombre { get; set; }

  }
}
