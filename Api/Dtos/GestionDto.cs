// Archivo: Api/Dtos/AlumnoDto.cs

using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
  public class GestionDto
  {
    public int ID { get; set; }

    [Required(ErrorMessage = "El campo 'NOMBRE' es obligatorio.")]
    [StringLength(60, ErrorMessage = "El campo 'NOMBRE' no puede tener más de 60 caracteres.")]
    public required string NOMBRE { get; set; }
  }
}
