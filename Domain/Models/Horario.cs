using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
  [Table("HORARIO")]
  public class Horario
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    // Propiedades de navegación - Se inicializan
    public ICollection<HoraDiaHorario> HorasDiaHorario { get; set; } = new List<HoraDiaHorario>();
    public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
  }
}