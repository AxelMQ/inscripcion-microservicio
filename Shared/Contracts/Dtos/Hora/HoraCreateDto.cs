// Shared/Contracts/Dtos/Grupos/GrupoDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Hora
{
    public class HoraCreateDto
    {
        [Required]
        public TimeOnly HrInicio { get; set; }
        [Required]
        public TimeOnly HrFin { get; set; }
    }
}
