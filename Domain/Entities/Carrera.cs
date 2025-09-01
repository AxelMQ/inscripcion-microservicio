using Domain.Core;

namespace Domain.Entities
{
    public class Carrera : BaseEntity
    {
        public required string Codigo { get; set; }
        // 0 = PRESENCIAL ; 1 = VIRTUAL ; 2 = HIBRIDO
        public short Modalidad { get; set; }
        public required string Nombre { get; set; }
        public ICollection<PlanEstudio> PlanesEstudio { get; set; } = new List<PlanEstudio>();
    }
}
