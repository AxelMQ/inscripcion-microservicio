using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
  [Table("HORA")]
  public class Hora
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    public required TimeOnly HR_INICIO { get; set; }

    public required TimeOnly HR_FIN { get; set; }

    // Propiedad de navegación - Se inicializa
    public ICollection<HoraDia> HorasDia { get; set; } = new List<HoraDia>();
  }

}