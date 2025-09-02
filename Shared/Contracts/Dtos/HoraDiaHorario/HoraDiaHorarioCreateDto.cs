// Shared/Contracts/Dtos/Grupos/GrupoDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.HoraDiaHorario
{
    public class HoraDiaHorarioCreateDto
    {
        [Required]
        public int HoraDiaId { get; set; }
    }
}
