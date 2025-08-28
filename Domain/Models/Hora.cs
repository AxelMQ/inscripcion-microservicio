// Domain/Models/Hora.cs
using System.Collections.Generic;
using Domain.Core;

namespace Domain.Models
{
    public class Hora : BaseEntity
    {
        // TimeOnly es value type → ya es no-null; no hace falta 'required'
        public TimeOnly HrInicio { get; set; }
        public TimeOnly HrFin    { get; set; }

        public ICollection<HoraDia> HorasDia { get; set; } = new List<HoraDia>();
    }
}
