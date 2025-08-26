using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("ALUMNO")]
    public class Alumno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(60)]
        public required string NOMBRE { get; set; }

        [Column(TypeName = "numeric(10, 2)")]
        public required decimal PPA { get; set; }

        public int? TELEFONO { get; set; }

        public required int REGISTRO { get; set; }

        // Propiedad de navegación - Se inicializa
        public ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
        public ICollection<AlumnoPlanEstudio> AlumnoPlanEstudios { get; set; } = new List<AlumnoPlanEstudio>();
    }
}