using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("INSCRIPCION")]
    public class Inscripcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public required DateTime FECHA { get; set; }

        public required int ALUMNO_ID { get; set; }
        public Alumno Alumno { get; set; } = null!; // Se usa 'null!'

        // Propiedad de navegación - Se inicializa
        public ICollection<HorarioMateriaInscripcion> HorarioMateriaInscripciones { get; set; } = new List<HorarioMateriaInscripcion>();
    }
}