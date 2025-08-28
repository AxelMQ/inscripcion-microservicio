// Domain/Models/Nota.cs
using Domain.Core;

namespace Domain.Models
{
    public class Nota : BaseEntity
    {
        public decimal Calificacion { get; set; }

        // FK opcional → navigation nullable
        public int? AlumnoId { get; set; }
        public Alumno? Alumno { get; set; }

        // FK opcional → navigation nullable
        public int? HorarioMateriaInscripcionId { get; set; }
        public HorarioMateriaInscripcion? HorarioMateriaInscripcion { get; set; }
    }
}
