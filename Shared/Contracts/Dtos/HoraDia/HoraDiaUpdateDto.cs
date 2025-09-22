using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.HoraDia
{
    public class HoraDiaUpdateDto
    {
        [Required]
        public int DiaId { get; set; }
        [Required]
        public int HoraId { get; set; }
    }
}
