using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
    public class NivelDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [StringLength(60, ErrorMessage = "El campo 'Nombre' no puede tener más de 60 caracteres.")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El campo 'Orden' es obligatorio.")]
        public required short Orden { get; set; }
    }
}
