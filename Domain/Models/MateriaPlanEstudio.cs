using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
[Table("MATERIA_PLAN_ESTUDIO")]
public class MateriaPlanEstudio
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    public required int MATERIA_ID { get; set; }
    public Materia Materia { get; set; } = null!; // Se usa 'null!'

    public required int NIVEL_ID { get; set; }
    public Nivel Nivel { get; set; } = null!; // Se usa 'null!'

    public required int PLAN_ESTUDIO_ID { get; set; }
    public PlanEstudio PlanEstudio { get; set; } = null!; // Se usa 'null!'

    // Propiedades de navegación - Se inicializan
    public ICollection<Prerequisito> MateriasRequisito { get; set; } = new List<Prerequisito>();
    public ICollection<Prerequisito> RequisitosPara { get; set; } = new List<Prerequisito>();

    // Propiedad de navegación - Se inicializa
    public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
}
}