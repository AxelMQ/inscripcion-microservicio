// Domain/Models/Inscripcion.cs
using System;
using System.Collections.Generic;
using Domain.Core;

namespace Domain.Models
{
    public class Inscripcion : BaseEntity
    {
        public DateTime Fecha { get; set; }

        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; } = null!;

        public ICollection<HorarioMateriaInscripcion> HorarioMateriaInscripciones { get; set; } 
            = new List<HorarioMateriaInscripcion>();
    }
}
