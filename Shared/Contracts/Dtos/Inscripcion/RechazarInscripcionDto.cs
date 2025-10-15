using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Inscripcion
{
    public class RechazarInscripcionDto
    {
        [Required(ErrorMessage = "El motivo del rechazo es requerido")]
        [StringLength(500, ErrorMessage = "El motivo no puede exceder los 500 caracteres")]
        public string Motivo { get; set; } = string.Empty;
    }
}

