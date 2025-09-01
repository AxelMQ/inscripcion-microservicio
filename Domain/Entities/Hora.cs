// Domain/Entities/Hora.cs
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Core;

namespace Domain.Entities
{
    public class Hora : BaseEntity
    {
        public TimeOnly HrInicio { get; set; }
        public TimeOnly HrFin { get; set; }
        public ICollection<HoraDia> HorasDia { get; set; } = new List<HoraDia>();
    }
}
