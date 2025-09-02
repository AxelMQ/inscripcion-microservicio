using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.HorarioMateria
{
    public class HorarioMateriaUpdateDto
    {
        public int Id { get; set; }
        public short CuposDisponibles { get; set; }
        public short CuposTotal { get; set; }
        public int? NroAula { get; set; }
        public int GestionId { get; set; }
        public int GrupoMateriaId { get; set; }
        public int ModuloId { get; set; }
        public int? DocenteId { get; set; }
        public int HorarioId { get; set; }
    }
}
