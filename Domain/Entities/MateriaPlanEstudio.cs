// Domain/Entities/MateriaPlanEstudio.cs
using System.Collections.Generic;
using Domain.Core;

namespace Domain.Entities
{
    public class MateriaPlanEstudio : BaseEntity
    {
        public int MateriaId { get; set; }
        public Materia Materia { get; set; } = null!;
        public int NivelId { get; set; }
        public Nivel Nivel { get; set; } = null!;
        public int PlanEstudioId { get; set; }
        public PlanEstudio PlanEstudio { get; set; } = null!;
        public ICollection<Prerequisito> MateriasRequisito { get; set; } = new List<Prerequisito>();
        public ICollection<Prerequisito> RequisitosPara { get; set; } = new List<Prerequisito>();

    }
}
