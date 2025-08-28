// Domain/Models/PlanEstudio.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Core;

namespace Domain.Models
{
    public class PlanEstudio : BaseEntity
    {
        [MaxLength(10)]
        public required string Codigo { get; set; }

        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; } = null!;

        public ICollection<MateriaPlanEstudio> MateriaPlanEstudios { get; set; } = new List<MateriaPlanEstudio>();
        public ICollection<AlumnoPlanEstudio> AlumnoPlanEstudios { get; set; } = new List<AlumnoPlanEstudio>();
    }
}
