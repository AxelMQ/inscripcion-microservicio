// Domain/Models/Grupo.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Core;

namespace Domain.Models
{
    public class Grupo : BaseEntity
    {
        [MaxLength(15)]
        public required string Nombre { get; set; }

        public ICollection<GrupoMateria> GrupoMaterias { get; set; } = new List<GrupoMateria>();
    }
}
