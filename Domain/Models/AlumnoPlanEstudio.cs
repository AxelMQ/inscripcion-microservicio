using Domain.Core;

namespace Domain.Models
{
  public class AlumnoPlanEstudio : BaseEntity
  {
    // FKs (tipos de valor no necesitan 'required')
    public int AlumnoId { get; set; }
    public int PlanEstudioId { get; set; }

    // Navegaciones (no-null en runtime)
    public Alumno Alumno { get; set; } = null!;
    public PlanEstudio PlanEstudio { get; set; } = null!;
  }
}