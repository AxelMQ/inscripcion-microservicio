using Domain.Core;

namespace Domain.Entities
{
    public class Grupo : BaseEntity
    {
        public required string Nombre { get; set; }
        public ICollection<GrupoMateria> GrupoMaterias { get; set; } = new List<GrupoMateria>();
    }
}
