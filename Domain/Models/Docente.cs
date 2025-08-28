// Domain/Models/Docente.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Core;

namespace Domain.Models
{
    public class Docente : BaseEntity
    {
        [MaxLength(125)]
        public required string Nombre { get; set; }

        // Teléfono podría ser string si necesitas soportar "+" o ceros a la izquierda
        public long? Telefono { get; set; }

        public int Ci { get; set; }

        public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
    }
}
