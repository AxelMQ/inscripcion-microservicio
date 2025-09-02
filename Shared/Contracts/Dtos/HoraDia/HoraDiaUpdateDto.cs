using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.HoraDia
{
    public class HoraDiaUpdateDto
    {
        public int Id { get; set; }
        [Required]
        public int DiaId { get; set; }
        [Required]
        public int HoraId { get; set; }
    }
}
