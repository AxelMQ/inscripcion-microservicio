using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
[Table("NIVEL")]
public class Nivel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    [StringLength(50)]
    public required string NOMBRE { get; set; }

    // Propiedad de navegación - Se inicializa para evitar la advertencia CS8618
    public ICollection<MateriaPlanEstudio> MateriaPlanEstudios { get; set; } = new List<MateriaPlanEstudio>();
}
}