namespace Shared.Contracts.Dtos.Inscripcion;

public class InscripcionDto
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public int AlumnoId { get; set; }
    public int HorarioMateriaId { get; set; }
}


