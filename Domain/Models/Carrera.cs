using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("CARRERA")]
    public class Carrera
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(10)]
        public required string CODIGO { get; set; }

        public required short MODALIDAD { get; set; } // 0 = PRESENCIAL ; 1 = VIRTUAL ; 2 = HIBRIDO

        [StringLength(63)]
        public required string NOMBRE { get; set; }

        // Propiedad de navegación - Se inicializa
        public ICollection<PlanEstudio> PlanesEstudio { get; set; } = new List<PlanEstudio>();
    }

}