// Domain/Models/Carrera.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Core;

namespace Domain.Models
{
    public class Carrera : BaseEntity
    {
        [MaxLength(10)]
        public required string Codigo { get; set; }

        // 0 = PRESENCIAL ; 1 = VIRTUAL ; 2 = HIBRIDO
        public short Modalidad { get; set; }

        [MaxLength(63)]
        public required string Nombre { get; set; }

        // Navegación
        public ICollection<PlanEstudio> PlanesEstudio { get; set; } = new List<PlanEstudio>();
    }
}
