using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("HORARIO_MATERIA_INSCRIPCION")]
    public class HorarioMateriaInscripcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public required int HORARIO_MATERIA_ID { get; set; }
        public HorarioMateria HorarioMateria { get; set; } = null!; // Se usa 'null!'

        public required int INSCRIPCION_ID { get; set; }
        public Inscripcion Inscripcion { get; set; } = null!; // Se usa 'null!'

        
        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    }

}