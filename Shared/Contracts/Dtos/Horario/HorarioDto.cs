
using Shared.Contracts.Dtos.HoraDiaHorario;
using Shared.Contracts.Dtos.HorarioMateria;

namespace Shared.Contracts.Dtos.Horario
{
    public sealed record class HorarioDto
    {
        public int Id { get; set; }
        public ICollection<HoraDiaHorarioDto> HorasDiaHorario { get; set; } = new List<HoraDiaHorarioDto>();
        public ICollection<HorarioMateriaDto> HorariosMateria { get; set; } = new List<HorarioMateriaDto>();
    }

}
