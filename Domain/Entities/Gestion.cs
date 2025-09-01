// Domain/Entities/Gestion.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Core;

namespace Domain.Entities
{
    public class Gestion : BaseEntity
    {
        public required string Nombre { get; set; }
        public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
    }
}
