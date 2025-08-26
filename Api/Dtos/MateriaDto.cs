// Api/Dtos/GrupoDto.cs
using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
  public class MateriaDto
  {
    // Opcional en Create; presente en respuestas (GET) y puede venir en Update.
    public int? ID { get; set; }

    [Required(ErrorMessage = "El campo 'NOMBRE' es obligatorio.")]
    [StringLength(50, ErrorMessage = "El campo 'NOMBRE' no puede tener más de 50 caracteres.")]
    public required string NOMBRE { get; set; }

    [Required(ErrorMessage = "El campo 'CREDITO' es obligatorio.")]
    public required short CREDITO { get; set; }
    public bool? ES_ELECTIVA { get; set; }

    [Required(ErrorMessage = "El campo 'SIGLA' es obligatorio.")]
    [StringLength(15, ErrorMessage = "El campo 'SIGLA' no puede tener más de 15 caracteres.")]
    public required string SIGLA { get; set; }
  }
}
