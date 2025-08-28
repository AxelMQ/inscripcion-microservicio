// Domain/Models/Gestion.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Core;

namespace Domain.Models
{
    public class Gestion : BaseEntity
    {
        [MaxLength(25)]
        public required string Nombre { get; set; }

        public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
    }
}
