// Domain/Entities/Inscripcion.cs
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Core;
using Domain.Enums;

namespace Domain.Entities
{
    public class Inscripcion : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; } = null!;
        public RequestState Estado { get; set; } = RequestState.Pending;
        public string? MensajeEstado { get; set; }
        public ICollection<HorarioMateriaInscripcion> HorarioMateriaInscripciones { get; set; }
                    = new List<HorarioMateriaInscripcion>();
    }
}
