using Domain.Core;

namespace Domain.Entities
{
    public class Docente : BaseEntity
    {
        public required string Nombre { get; set; }
        public long? Telefono { get; set; }
        public int Ci { get; set; }
        public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
    }
}
