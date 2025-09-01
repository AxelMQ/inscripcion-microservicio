// Shared/Contracts/Dtos/Alumno/AlumnoDeleteDto.cs
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Dtos.GrupoMateria
{
    public sealed record class GrupoMateriaDeleteDto
    {
        public int Id { get; init; }
    }
}