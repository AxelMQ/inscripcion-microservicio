// Domain/Models/Horario.cs
using System.Collections.Generic;
using Domain.Core;

namespace Domain.Models
{
    public class Horario : BaseEntity
    {
        public ICollection<HoraDiaHorario> HorasDiaHorario { get; set; } = new List<HoraDiaHorario>();
        public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
    }
}
