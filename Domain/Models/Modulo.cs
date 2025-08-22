using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
[Table("MODULO")]
public class Modulo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    public required short NRO_MODULO { get; set; }

    // Propiedad de navegación - Se inicializa
    public ICollection<HorarioMateria> HorariosMateria { get; set; } = new List<HorarioMateria>();
}
}