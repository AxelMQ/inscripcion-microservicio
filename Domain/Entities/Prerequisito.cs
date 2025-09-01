using Domain.Core;

namespace Domain.Entities
{
    public class Prerequisito : BaseEntity
    {
        public int MateriaPlanEstudioId { get; set; }
        public MateriaPlanEstudio MateriaPlanEstudio { get; set; } = null!;

        public int RequisitoId { get; set; }
        public MateriaPlanEstudio Requisito { get; set; } = null!;
    }
}
