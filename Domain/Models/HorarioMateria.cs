// Domain/Models/HorarioMateria.cs
using System.Collections.Generic;
using Domain.Core;

namespace Domain.Models
{
    public class HorarioMateria : BaseEntity
    {
        public short CuposDisponibles { get; set; }
        public short CuposTotal { get; set; }
        public int? NroAula { get; set; }

        public int GestionId { get; set; }
        public Gestion Gestion { get; set; } = null!;

        public int GrupoMateriaId { get; set; }
        public GrupoMateria GrupoMateria { get; set; } = null!;

        public int ModuloId { get; set; }
        public Modulo Modulo { get; set; } = null!;

        public int? DocenteId { get; set; }
        public Docente? Docente { get; set; }

        public int HorarioId { get; set; }
        public Horario Horario { get; set; } = null!;

        public ICollection<HorarioMateriaInscripcion> HorarioMateriaInscripciones { get; set; } 
            = new List<HorarioMateriaInscripcion>();
    }
}
