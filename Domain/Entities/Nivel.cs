// Domain/Entities/Nivel.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Domain.Core;

namespace Domain.Entities
{
    public class Nivel : BaseEntity
    {
        public required string Nombre { get; set; }
        public required short Orden { get; set; }
        public ICollection<MateriaPlanEstudio> MateriaPlanEstudios { get; set; } = new List<MateriaPlanEstudio>();
    }
}
