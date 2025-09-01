// Domain/Entities/Horario.cs
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Core;

namespace Domain.Entities
{
    public class Horario : BaseEntity
    {
        public ICollection<HoraDiaHorario> HorasDiaHorario { get; set; } = new List<HoraDiaHorario>();
        public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
    }
}
