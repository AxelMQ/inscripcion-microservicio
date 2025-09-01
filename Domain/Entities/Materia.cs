// Domain/Entities/Materia.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Domain.Core;

namespace Domain.Entities
{
    public class Materia : BaseEntity
    {
        public short Credito { get; set; }            // valida >0 en capa de aplicación si aplica
        public bool EsElectiva { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;
        public ICollection<MateriaPlanEstudio> MateriaPlanEstudios { get; set; } = new List<MateriaPlanEstudio>();
        public ICollection<GrupoMateria> GrupoMaterias { get; set; } = new List<GrupoMateria>();
    }

}
