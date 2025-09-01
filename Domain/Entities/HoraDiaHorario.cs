// Domain/Entities/HoraDiaHorario.cs
using Domain.Core;

namespace Domain.Entities
{
    public class HoraDiaHorario : BaseEntity
    {
        public int HoraDiaId { get; set; }
        public HoraDia HoraDia { get; set; } = null!;
        public int HorarioId { get; set; }
        public Horario Horario { get; set; } = null!;
    }
}
