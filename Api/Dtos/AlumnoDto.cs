// Archivo: Api/Dtos/AlumnoDto.cs

using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
    public class AlumnoDto
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El campo 'NOMBRE' es obligatorio.")]
        [StringLength(60, ErrorMessage = "El campo 'NOMBRE' no puede tener más de 60 caracteres.")]
        public string NOMBRE { get; set; }

        [Required(ErrorMessage = "El campo 'PPA' es obligatorio.")]
        public decimal PPA { get; set; }
        
        public int? TELEFONO { get; set; }

        [Required(ErrorMessage = "El campo 'REGISTRO' es obligatorio.")]
        public int REGISTRO { get; set; }
    }
}
