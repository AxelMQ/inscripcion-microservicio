using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.Hora
{
public class HoraUpdateDto
{
    public int Id { get; set; }
    [Required]
    public TimeOnly HrInicio { get; set; }
    [Required]
    public TimeOnly HrFin { get; set; }
}
}
