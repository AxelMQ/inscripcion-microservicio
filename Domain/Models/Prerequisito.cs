using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
[Table("PREREQUISITO")]
public class Prerequisito
{
    public required int MATERIA_PLAN_ESTUDIO_ID { get; set; }
    public MateriaPlanEstudio MateriaPlanEstudio { get; set; } = null!; // Se usa 'null!'

    public required int REQUISITO_ID { get; set; }
    public MateriaPlanEstudio Requisito { get; set; } = null!; // Se usa 'null!'
}
}