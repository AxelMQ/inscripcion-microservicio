using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Core;

namespace Domain.Models
{
    [Table("MATERIA")]
    public class Materia: BaseEntity
    {
        public required short CREDITO { get; set; }

        public bool? ES_ELECTIVA { get; set; }

        [StringLength(50)]
        public required string NOMBRE { get; set; }

        [StringLength(15)]
        public required string SIGLA { get; set; }

        // Propiedad de navegación - Se inicializa
        public ICollection<MateriaPlanEstudio> MateriaPlanEstudios { get; set; } = new List<MateriaPlanEstudio>();
        public ICollection<GrupoMateria> GrupoMaterias { get; set; } = new List<GrupoMateria>();
    }

}