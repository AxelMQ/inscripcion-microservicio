using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
  [Table("GRUPO_MATERIA")]
  public class GrupoMateria
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    public required int GRUPO_ID { get; set; }
    public Grupo Grupo { get; set; } = null!; // Se usa 'null!'

    public required int MATERIA_ID { get; set; }
    public Materia Materia { get; set; } = null!; // Se usa 'null!'

     public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();

  }
}