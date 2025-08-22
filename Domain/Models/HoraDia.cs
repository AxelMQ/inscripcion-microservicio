using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
  [Table("HORA_DIA")]
  public class HoraDia
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    public required int DIA_ID { get; set; }
    public Dia Dia { get; set; } = null!; // Se usa 'null!'

    public required int HORA_ID { get; set; }
    public Hora Hora { get; set; } = null!; // Se usa 'null!'

    // Propiedad de navegación - Se inicializa
    public ICollection<HoraDiaHorario> HorasDiaHorario { get; set; } = new List<HoraDiaHorario>();
  }
}