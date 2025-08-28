using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Core;

namespace Domain.Models
{
    public class Alumno : BaseEntity
    {
        [MaxLength(60)]                 // válido como regla de dominio
        public required string Nombre { get; set; }

        public decimal Ppa { get; set; } // precisión se define en Infra
        public int Telefono { get; set; }
        public int Registro { get; set; }

        public ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
        public ICollection<AlumnoPlanEstudio> AlumnoPlanEstudios { get; set; } = new List<AlumnoPlanEstudio>();
    }
}
