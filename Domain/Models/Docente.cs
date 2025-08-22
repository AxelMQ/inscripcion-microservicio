using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
  [Table("DOCENTE")]
  public class Docente
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    [StringLength(125)]
    public required string NOMBRE { get; set; }

    public long? TELEFONO { get; set; }

    public required int CI { get; set; }

    // Propiedad de navegación - Se inicializa
    public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
  }
}