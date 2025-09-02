// Shared/Contracts/Dtos/Grupos/GrupoDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.HoraDia
{
    public class HoraDiaCreateDto
    {
        [Required]
        public int DiaId { get; set; }
        [Required]
        public int HoraId { get; set; }
    }
}
