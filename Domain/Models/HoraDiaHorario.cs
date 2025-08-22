using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("HORA_DIA_HORARIO")]
    public class HoraDiaHorario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public required int HORA_DIA_ID { get; set; }
        public HoraDia HoraDia { get; set; } = null!; // Se usa 'null!'

        public required int HORARIO_ID { get; set; }
        public Horario Horario { get; set; } = null!; // Se usa 'null!'
    }
}