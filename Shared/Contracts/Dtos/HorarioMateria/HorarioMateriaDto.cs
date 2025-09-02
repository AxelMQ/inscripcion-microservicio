
using Shared.Contracts.Dtos.Docente;
using Shared.Contracts.Dtos.Gestion;
using Shared.Contracts.Dtos.GrupoMateria;
using Shared.Contracts.Dtos.Horario;

namespace Shared.Contracts.Dtos.HorarioMateria
{
    public class HorarioMateriaDto
    {
        public int Id { get; set; }
        public short CuposDisponibles { get; set; }
        public short CuposTotal { get; set; }
        public int? NroAula { get; set; }
        public int GestionId { get; set; }
        public required GestionDto Gestion { get; set; }
        public int GrupoMateriaId { get; set; }
        public required GrupoMateriaDto GrupoMateria { get; set; }
        public int ModuloId { get; set; }
        //public ModuloDto Modulo { get; set; }
        public int? DocenteId { get; set; }
        public required DocenteDto Docente { get; set; }
        public int HorarioId { get; set; }
        public ICollection<HorarioDetalleDto> Horarios { get; set; } = new List<HorarioDetalleDto>();
        //public required HorarioDto Horario { get; set; }
        //public ICollection<HorarioMateriaInscripcionDto> HorarioMateriaInscripciones { get; set; } = new List<HorarioMateriaInscripcionDto>();
    }
}
