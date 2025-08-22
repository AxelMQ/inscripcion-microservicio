using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
  [Table("DIA")]
  public class Dia
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    [StringLength(15)]
    public required string NOMBRE { get; set; }

    // Propiedad de navegación - Se inicializa
    public ICollection<HoraDia> HorasDia { get; set; } = new List<HoraDia>();
  }
}