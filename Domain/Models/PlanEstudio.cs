using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
[Table("PLAN_ESTUDIO")]
public class PlanEstudio
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    [StringLength(10)]
    public required string CODIGO { get; set; }

    public required int CARRERA_ID { get; set; }
    public Carrera Carrera { get; set; } = null!; // Se usa 'null!' porque el mapeo de EF lo inicializará

    // Propiedad de navegación - Se inicializa
    public ICollection<MateriaPlanEstudio> MateriaPlanEstudios { get; set; } = new List<MateriaPlanEstudio>();
}
}