
using AutoMapper;
using Domain.Entities;
using Shared.Contracts.Dtos.Alumno;
using Shared.Contracts.Dtos.Carrera;
using Shared.Contracts.Dtos.Dia;
using Shared.Contracts.Dtos.Docente;
using Shared.Contracts.Dtos.Gestion;
using Shared.Contracts.Dtos.Grupo;
using Shared.Contracts.Dtos.GrupoMateria;
using Shared.Contracts.Dtos.Materia;
using Shared.Contracts.Dtos.MateriaPlanEstudio;
using Shared.Contracts.Dtos.Nivel;
using Shared.Contracts.Dtos.PlanEstudio;
using Shared.Contracts.Dtos.Prerequisito;

namespace Shared.Mapping
{
  public class MappingProfiles : Profile
  {
    public MappingProfiles()
    {

      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<AlumnoCreateDto, Alumno>();
      CreateMap<AlumnoUpdateDto, Alumno>();

      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<Alumno, AlumnoDto>();

      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<MateriaCreateDto, Materia>();
      CreateMap<MateriaUpdateDto, Materia>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<Materia, MateriaDto>();

      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<GrupoCreateDto, Grupo>();
      CreateMap<GrupoUpdateDto, Grupo>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<Grupo, GrupoDto>();

      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<GrupoMateriaCreateDto, GrupoMateria>();
      CreateMap<GrupoMateriaUpdateDto, GrupoMateria>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<GrupoMateria, GrupoMateriaDto>();


      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<CarreraCreateDto, Carrera>();
      CreateMap<CarreraUpdateDto, Carrera>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<Carrera, CarreraDto>();

      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<DiaCreateDto, Dia>();
      CreateMap<DiaUpdateDto, Dia>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<Dia, DiaDto>();

      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<DocenteCreateDto, Docente>();
      CreateMap<DocenteUpdateDto, Docente>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<Docente, DocenteDto>();

      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<GestionCreateDto, Gestion>();
      CreateMap<GestionUpdateDto, Gestion>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<Gestion, GestionDto>();

      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<NivelCreateDto, Nivel>();
      CreateMap<NivelUpdateDto, Nivel>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<Nivel, NivelDto>();

      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<PlanEstudioCreateDto, PlanEstudio>();
      CreateMap<PlanEstudioUpdateDto, PlanEstudio>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<PlanEstudio, PlanEstudioDto>();

      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<MateriaPlanEstudioCreateDto, MateriaPlanEstudio>();
      CreateMap<MateriaPlanEstudioUpdateDto, MateriaPlanEstudio>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<MateriaPlanEstudio, MateriaPlanEstudioDto>();



      // Mapeo de DTOs de entrada a la entidad de dominio
      CreateMap<PrerequisitoCreateDto, Prerequisito>();
      CreateMap<PrerequisitoUpdateDto, Prerequisito>();
      // Mapeo de la entidad de dominio a DTOs de salida
      CreateMap<Prerequisito, PrerequisitoDto>()
               .ForMember(dest => dest.RequisitoMateriaId,
                          opt => opt.MapFrom(src => src.Requisito.Materia.Id))
               .ForMember(dest => dest.RequisitoMateriaNombre,
                          opt => opt.MapFrom(src => src.Requisito.Materia.Nombre))
               .ForMember(dest => dest.RequisitoMateriaSigla,
                          opt => opt.MapFrom(src => src.Requisito.Materia.Sigla));
    }
  }
}