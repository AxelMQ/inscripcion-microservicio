using Shared.Contracts.Dtos.Dia;
using Shared.Contracts.Dtos.Hora;

namespace Shared.Contracts.Dtos.HorarioMateria
{
    public class HorarioDetalleDto
    {
        public int Id { get; set; }
        public required DiaDto Dia { get; set; }
        public required HoraDto Hora { get; set; }
    }
}