using Domain.Core;

namespace Domain.Entities
{
    public class GrupoMateria : BaseEntity
    {
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; } = null!;
        public int MateriaId { get; set; }
        public Materia Materia { get; set; } = null!;
        public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
    }
}
