using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Core; // Asegúrate de que este using apunte a la ubicación de BaseEntity

namespace Domain.Models
{
    [Table("ALUMNO")]
    public class Alumno : BaseEntity
    {
        // La propiedad ID ya no es necesaria aquí, se hereda de BaseEntity.
        // Los atributos [Key] y [DatabaseGenerated] se manejarán en la configuración de Entity Framework.

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