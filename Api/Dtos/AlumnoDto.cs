// Archivo: Api/Dtos/AlumnoDto.cs

using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
    public class AlumnoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [StringLength(60, ErrorMessage = "El campo 'Nombre' no puede tener más de 60 caracteres.")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El campo 'Ppa' es obligatorio.")]
        public decimal Ppa { get; set; }

        public int Telefono { get; set; }

        [Required(ErrorMessage = "El campo 'Registro' es obligatorio.")]
        public int Registro { get; set; }
    }
}
