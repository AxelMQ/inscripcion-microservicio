using Shared.Contracts.Dtos.Dia;
using Shared.Contracts.Dtos.Hora;
using Shared.Contracts.Dtos.HoraDia;

namespace Shared.Contracts.Dtos.HoraDiaHorario
{
    public class HoraDiaHorarioDto
    {
        public int Id { get; set; }
        public int HoraDiaId { get; set; }
        public required HoraDiaDto HoraDia { get; set; }

        public HoraDto? Hora { get; set; }
        public DiaDto? Dia { get; set; }

    }
}
