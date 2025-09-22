using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.HoraDiaHorario
{
    public class HoraDiaHorarioUpdateDto
    {
        [Required]
        public int HoraDiaId { get; set; }
    }
}
