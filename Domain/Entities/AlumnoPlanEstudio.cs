using Domain.Core;

namespace Domain.Entities
{
  public class AlumnoPlanEstudio : BaseEntity
  {
    public int AlumnoId { get; set; }
    public int PlanEstudioId { get; set; }
    public Alumno Alumno { get; set; } = null!;
    public PlanEstudio PlanEstudio { get; set; } = null!;
  }
}