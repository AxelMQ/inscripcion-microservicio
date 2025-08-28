// Api/Dtos/GrupoDto.cs
using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
  public class MateriaDto
  {
    // Opcional en Create; presente en respuestas (GET) y puede venir en Update.
    public int? Id { get; set; }

    [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
    [StringLength(50, ErrorMessage = "El campo 'Nombre' no puede tener más de 50 caracteres.")]
    public required string Nombre { get; set; }

    [Required(ErrorMessage = "El campo 'Credito' es obligatorio.")]
    public required short Credito { get; set; }
    public bool? EsElectiva { get; set; }

    [Required(ErrorMessage = "El campo 'Sigla' es obligatorio.")]
    [StringLength(15, ErrorMessage = "El campo 'Sigla' no puede tener más de 15 caracteres.")]
    public required string Sigla { get; set; }
  }
}
