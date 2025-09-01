// Domain/Entities/Dia.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Domain.Core;

namespace Domain.Entities
{
    public class Dia : BaseEntity
    {
        public required string Nombre { get; set; }
        public ICollection<HoraDia> HorasDia { get; set; } = new List<HoraDia>();
    }
}
