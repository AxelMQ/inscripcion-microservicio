// Domain/Models/Dia.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Core;

namespace Domain.Models
{
    public class Dia : BaseEntity
    {
        [MaxLength(15)]
        public required string Nombre { get; set; }

        public ICollection<HoraDia> HorasDia { get; set; } = new List<HoraDia>();
    }
}
