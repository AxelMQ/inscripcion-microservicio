// Domain/Entities/Modulo.cs
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Core;

namespace Domain.Entities
{
    public class Modulo : BaseEntity
    {
        public short NroModulo { get; set; }
        public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
    }
}
