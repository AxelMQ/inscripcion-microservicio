// Domain/Models/Materia.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Core;

namespace Domain.Models
{
    public class Materia : BaseEntity
    {
        public short Credito { get; set; }

        // Si en tu dominio puede ser “desconocido”, mantenla como bool?; 
        // si no, dejala no-nullable. Aquí la dejo no-nullable.
        public bool EsElectiva { get; set; }

        [MaxLength(50)]
        public required string Nombre { get; set; }

        [MaxLength(15)]
        public required string Sigla { get; set; }

        public ICollection<MateriaPlanEstudio> MateriaPlanEstudios { get; set; } = new List<MateriaPlanEstudio>();
        public ICollection<GrupoMateria> GrupoMaterias { get; set; } = new List<GrupoMateria>();
    }
}
