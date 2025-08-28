// Domain/Models/Materia.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Core;

namespace Domain.Models
{
public class Materia : BaseEntity
{
    public short Credito { get; set; }            // valida >0 en capa de aplicación si aplica
    public bool EsElectiva { get; set; }

    [MaxLength(50)]
    public string Nombre { get; set; } = string.Empty;

    [MaxLength(15)]
    public string Sigla { get; set; } = string.Empty;

    public ICollection<MateriaPlanEstudio> MateriaPlanEstudios { get; set; } = new List<MateriaPlanEstudio>();
    public ICollection<GrupoMateria> GrupoMaterias { get; set; } = new List<GrupoMateria>();
}

}
