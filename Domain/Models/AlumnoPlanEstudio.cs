using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
  [Table("ALUMNO_CARRERA")]
  public class AlumnoPlanEstudio
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    public required int ALUMNO_ID { get; set; }
    public Alumno Alumno { get; set; } = null!; // Se usa 'null!'
    public required int PLAN_ESTUDIO_ID { get; set; }
    public PlanEstudio PlanEstudio { get; set; } = null!; // Se usa 'null!'
  }
}