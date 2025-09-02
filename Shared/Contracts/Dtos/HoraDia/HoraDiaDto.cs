using Shared.Contracts.Dtos.Dia;
using Shared.Contracts.Dtos.Hora;

namespace Shared.Contracts.Dtos.HoraDia
{
    public class HoraDiaDto
    {
        public int Id { get; set; }
        public int DiaId { get; set; }
        public required DiaDto Dia { get; set; }
        public int HoraId { get; set; }
        public required HoraDto Hora { get; set; }
    }
}
