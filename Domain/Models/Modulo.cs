// Domain/Models/Modulo.cs
using System.Collections.Generic;
using Domain.Core;

namespace Domain.Models
{
    public class Modulo : BaseEntity
    {
        // 'short' es tipo valor → no necesita 'required'
        public short NroModulo { get; set; }

        public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
    }
}
