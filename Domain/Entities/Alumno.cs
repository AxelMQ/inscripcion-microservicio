using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Domain.Core;

namespace Domain.Entities
{
    public class Alumno : BaseEntity
    {
        public required string Nombre { get; set; }
        public decimal Ppa { get; set; }
        public int Telefono { get; set; }
        public int Registro { get; set; }
        public ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
        public ICollection<AlumnoPlanEstudio> AlumnoPlanEstudios { get; set; } = new List<AlumnoPlanEstudio>();
    }
}
