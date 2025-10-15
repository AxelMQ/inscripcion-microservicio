using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Inscripcion
{
    public class InscripcionCreateDto
    {
        [Required(ErrorMessage = "El ID del alumno es requerido")]
        public int AlumnoId { get; set; }

        [Required(ErrorMessage = "El ID del horario de materia es requerido")]
        public int HorarioMateriaId { get; set; }
    }
}