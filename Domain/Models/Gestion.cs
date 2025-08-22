using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
  [Table("GESTION")]
  public class Gestion
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    [StringLength(25)]
    public required string NOMBRE { get; set; }

    // Propiedad de navegación - Se inicializa
    public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
  }
}