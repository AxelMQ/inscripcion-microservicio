// Domain/Entities/HorarioMateriaInscripcion.cs
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Core;

namespace Domain.Entities
{
    public class HorarioMateriaInscripcion : BaseEntity
    {
        public int HorarioMateriaId { get; set; }
        public HorarioMateria HorarioMateria { get; set; } = null!;
        public int InscripcionId { get; set; }
        public Inscripcion Inscripcion { get; set; } = null!;
        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    }
}
