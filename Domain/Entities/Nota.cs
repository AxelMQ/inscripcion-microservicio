// Domain/Entities/Nota.cs
using System.Text.Json.Serialization;
using Domain.Core;

namespace Domain.Entities
{
    public class Nota : BaseEntity
    {
        public decimal Calificacion { get; set; }
        public int AlumnoId { get; set; }
        public Alumno? Alumno { get; set; }
        public int HorarioMateriaInscripcionId { get; set; }
        public HorarioMateriaInscripcion? HorarioMateriaInscripcion { get; set; }
    }
}
