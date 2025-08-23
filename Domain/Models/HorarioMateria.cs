using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
  [Table("HORARIO_MATERIA")]
  public class HorarioMateria
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    public required short CUPOS_DISPONIBLES { get; set; }

    public required short CUPOS_TOTAL { get; set; }

    public int? NRO_AULA { get; set; }

    public required int GESTION_ID { get; set; }
    public Gestion Gestion { get; set; } = null!; // Se usa 'null!'

    public required int GRUPO_MATERIA_ID { get; set; }
    public GrupoMateria GrupoMateria { get; set; } = null!; // Se usa 'null!'

    public required int MODULO_ID { get; set; }
    public Modulo Modulo { get; set; } = null!; // Se usa 'null!'

    public int? DOCENTE_ID { get; set; }
    public Docente? Docente { get; set; }

    public required int HORARIO_ID { get; set; }
    public Horario Horario { get; set; } = null!; // Se usa 'null!'

    // Propiedad de navegación - Se inicializa
    public ICollection<HorarioMateriaInscripcion> HorarioMateriaInscripciones { get; set; } = new List<HorarioMateriaInscripcion>();
  }
}