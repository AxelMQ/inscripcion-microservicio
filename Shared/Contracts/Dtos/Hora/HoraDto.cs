namespace Shared.Contracts.Dtos.Hora
{
 public class HoraDto
{
    public int Id { get; set; }
    public TimeOnly HrInicio { get; set; }
    public TimeOnly HrFin { get; set; }
    //public ICollection<HoraDiaDto> HorasDia { get; set; } = new List<HoraDiaDto>();
}
}
