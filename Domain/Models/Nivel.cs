// Domain/Models/Nivel.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Core;

namespace Domain.Models
{
    public class Nivel : BaseEntity
    {
        [MaxLength(50)]
        public required string Nombre { get; set; }
        public required short Orden { get; set; }
        public ICollection<MateriaPlanEstudio> MateriaPlanEstudios { get; set; } = new List<MateriaPlanEstudio>();
    }
}
