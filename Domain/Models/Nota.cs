using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
  [Table("NOTA")]
  public class Nota
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    public required decimal CALIFICACION { get; set; }
    public int? ALUMNO_ID { get; set; }
    public Alumno Alumno { get; set; } = null!;
    public int? HORARIO_MATERIA_INSCRIPCION_ID { get; set; }
    public HorarioMateriaInscripcion HorarioMateriaInscripcion { get; set; } = null!;
  }
}