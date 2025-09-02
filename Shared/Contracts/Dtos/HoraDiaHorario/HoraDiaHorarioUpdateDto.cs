using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.HoraDiaHorario
{
    public class HoraDiaHorarioUpdateDto
    {
        public int Id { get; set; }
        [Required]
        public int HoraDiaId { get; set; }
    }
}
