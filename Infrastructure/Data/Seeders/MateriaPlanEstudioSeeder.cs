using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class MateriaPlanEstudioSeeder : IEntityTypeConfiguration<MateriaPlanEstudio>
{
    public void Configure(EntityTypeBuilder<MateriaPlanEstudio> builder)
    {
        builder.HasData(
            // ===== INGENIERÍA INFORMÁTICA (PLAN 1) =====
            // SEMESTRE 1
            new MateriaPlanEstudio { Id = 1, MateriaId = 1, NivelId = 1, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 2, MateriaId = 2, NivelId = 1, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 3, MateriaId = 3, NivelId = 1, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 4, MateriaId = 4, NivelId = 1, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 5, MateriaId = 5, NivelId = 1, PlanEstudioId = 1 },

            // SEMESTRE 2
            new MateriaPlanEstudio { Id = 6, MateriaId = 6, NivelId = 2, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 7, MateriaId = 7, NivelId = 2, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 8, MateriaId = 8, NivelId = 2, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 9, MateriaId = 9, NivelId = 2, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 10, MateriaId = 10, NivelId = 2, PlanEstudioId = 1 },

            // SEMESTRE 3
            new MateriaPlanEstudio { Id = 11, MateriaId = 11, NivelId = 3, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 12, MateriaId = 12, NivelId = 3, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 13, MateriaId = 13, NivelId = 3, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 14, MateriaId = 14, NivelId = 3, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 15, MateriaId = 15, NivelId = 3, PlanEstudioId = 1 },

            // SEMESTRE 4
            new MateriaPlanEstudio { Id = 16, MateriaId = 16, NivelId = 4, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 17, MateriaId = 17, NivelId = 4, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 18, MateriaId = 18, NivelId = 4, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 19, MateriaId = 19, NivelId = 4, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 20, MateriaId = 20, NivelId = 4, PlanEstudioId = 1 },

            // SEMESTRE 5
            new MateriaPlanEstudio { Id = 21, MateriaId = 21, NivelId = 5, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 22, MateriaId = 22, NivelId = 5, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 23, MateriaId = 23, NivelId = 5, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 24, MateriaId = 24, NivelId = 5, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 25, MateriaId = 25, NivelId = 5, PlanEstudioId = 1 },

            // SEMESTRE 6
            new MateriaPlanEstudio { Id = 26, MateriaId = 26, NivelId = 6, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 27, MateriaId = 27, NivelId = 6, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 28, MateriaId = 28, NivelId = 6, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 29, MateriaId = 29, NivelId = 6, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 30, MateriaId = 30, NivelId = 6, PlanEstudioId = 1 },

            // SEMESTRE 7
            new MateriaPlanEstudio { Id = 31, MateriaId = 31, NivelId = 7, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 32, MateriaId = 32, NivelId = 7, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 33, MateriaId = 33, NivelId = 7, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 34, MateriaId = 34, NivelId = 7, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 35, MateriaId = 38, NivelId = 7, PlanEstudioId = 1 },

            // SEMESTRE 8
            new MateriaPlanEstudio { Id = 36, MateriaId = 36, NivelId = 8, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 37, MateriaId = 37, NivelId = 8, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 38, MateriaId = 44, NivelId = 8, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 39, MateriaId = 39, NivelId = 8, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 40, MateriaId = 35, NivelId = 8, PlanEstudioId = 1 },

            // SEMESTRE 9
            new MateriaPlanEstudio { Id = 41, MateriaId = 41, NivelId = 9, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 44, MateriaId = 40, NivelId = 9, PlanEstudioId = 1 },
            new MateriaPlanEstudio { Id = 42, MateriaId = 42, NivelId = 9, PlanEstudioId = 1 }, 
            new MateriaPlanEstudio { Id = 43, MateriaId = 43, NivelId = 9, PlanEstudioId = 1 },

            // GRADUACIÓN
            new MateriaPlanEstudio { Id = 45, MateriaId = 100, NivelId = 10, PlanEstudioId = 1 },

            // ===== INGENIERÍA EN SISTEMAS (PLAN 2) =====
            // SEMESTRES 1-4 (MISMAS MATERIAS QUE INFORMÁTICA)
            new MateriaPlanEstudio { Id = 46, MateriaId = 1, NivelId = 1, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 47, MateriaId = 2, NivelId = 1, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 48, MateriaId = 3, NivelId = 1, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 49, MateriaId = 4, NivelId = 1, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 50, MateriaId = 5, NivelId = 1, PlanEstudioId = 2 },

            new MateriaPlanEstudio { Id = 51, MateriaId = 6, NivelId = 2, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 52, MateriaId = 7, NivelId = 2, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 53, MateriaId = 8, NivelId = 2, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 54, MateriaId = 9, NivelId = 2, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 55, MateriaId = 10, NivelId = 2, PlanEstudioId = 2 },

            new MateriaPlanEstudio { Id = 56, MateriaId = 11, NivelId = 3, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 57, MateriaId = 12, NivelId = 3, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 58, MateriaId = 13, NivelId = 3, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 59, MateriaId = 14, NivelId = 3, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 60, MateriaId = 15, NivelId = 3, PlanEstudioId = 2 },

            new MateriaPlanEstudio { Id = 61, MateriaId = 16, NivelId = 4, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 62, MateriaId = 17, NivelId = 4, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 63, MateriaId = 18, NivelId = 4, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 64, MateriaId = 19, NivelId = 4, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 65, MateriaId = 20, NivelId = 4, PlanEstudioId = 2 },

            // SEMESTRE 5 (SISTEMAS - MATERIAS ESPECÍFICAS)
            new MateriaPlanEstudio { Id = 66, MateriaId = 21, NivelId = 5, PlanEstudioId = 2 },
            // new MateriaPlanEstudio { Id = 67, MateriaId = 22, NivelId = 5, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 68, MateriaId = 23, NivelId = 5, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 69, MateriaId = 24, NivelId = 5, PlanEstudioId = 2 },
            // new MateriaPlanEstudio { Id = 70, MateriaId = 25, NivelId = 5, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 71, MateriaId = 53, NivelId = 5, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 72, MateriaId = 54, NivelId = 5, PlanEstudioId = 2 },

            // SEMESTRE 6 (SISTEMAS)
            new MateriaPlanEstudio { Id = 73, MateriaId = 26, NivelId = 6, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 74, MateriaId = 27, NivelId = 6, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 75, MateriaId = 28, NivelId = 6, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 76, MateriaId = 29, NivelId = 6, PlanEstudioId = 2 },
            // new MateriaPlanEstudio { Id = 77, MateriaId = 30, NivelId = 6, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 78, MateriaId = 55, NivelId = 6, PlanEstudioId = 2 },

            // SEMESTRE 7 (SISTEMAS)
            new MateriaPlanEstudio { Id = 79, MateriaId = 31, NivelId = 7, PlanEstudioId = 2 },
            // new MateriaPlanEstudio { Id = 80, MateriaId = 32, NivelId = 7, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 81, MateriaId = 33, NivelId = 7, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 82, MateriaId = 34, NivelId = 7, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 83, MateriaId = 38, NivelId = 7, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 84, MateriaId = 56, NivelId = 7, PlanEstudioId = 2 },

            // SEMESTRE 8 (SISTEMAS)
            new MateriaPlanEstudio { Id = 85, MateriaId = 36, NivelId = 8, PlanEstudioId = 2 },
            // new MateriaPlanEstudio { Id = 86, MateriaId = 37, NivelId = 8, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 87, MateriaId = 35, NivelId = 8, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 88, MateriaId = 39, NivelId = 8, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 89, MateriaId = 44, NivelId = 8, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 90, MateriaId = 57, NivelId = 8, PlanEstudioId = 2 },

            // SEMESTRE 9 (SISTEMAS)
            new MateriaPlanEstudio { Id = 91, MateriaId = 41, NivelId = 9, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 92, MateriaId = 42, NivelId = 9, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 93, MateriaId = 43, NivelId = 9, PlanEstudioId = 2 },
            new MateriaPlanEstudio { Id = 94, MateriaId = 40, NivelId = 9, PlanEstudioId = 2 },

            // GRADUACIÓN SISTEMAS
            new MateriaPlanEstudio { Id = 95, MateriaId = 100, NivelId = 10, PlanEstudioId = 2 },

            // ===== INGENIERÍA EN REDES (PLAN 3) =====
            // SEMESTRES 1-3 (MISMAS MATERIAS)
            new MateriaPlanEstudio { Id = 96, MateriaId = 1, NivelId = 1, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 97, MateriaId = 2, NivelId = 1, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 98, MateriaId = 3, NivelId = 1, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 99, MateriaId = 4, NivelId = 1, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 100, MateriaId = 5, NivelId = 1, PlanEstudioId = 3 },

            new MateriaPlanEstudio { Id = 101, MateriaId = 6, NivelId = 2, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 102, MateriaId = 7, NivelId = 2, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 103, MateriaId = 8, NivelId = 2, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 104, MateriaId = 9, NivelId = 2, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 105, MateriaId = 10, NivelId = 2, PlanEstudioId = 3 },

            new MateriaPlanEstudio { Id = 106, MateriaId = 11, NivelId = 3, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 107, MateriaId = 12, NivelId = 3, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 108, MateriaId = 13, NivelId = 3, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 109, MateriaId = 75, NivelId = 3, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 110, MateriaId = 76, NivelId = 3, PlanEstudioId = 3 },

            // SEMESTRE 4 
            new MateriaPlanEstudio { Id = 111, MateriaId = 16, NivelId = 4, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 112, MateriaId = 17, NivelId = 4, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 113, MateriaId = 18, NivelId = 4, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 114, MateriaId = 19, NivelId = 4, PlanEstudioId = 3 },
            new MateriaPlanEstudio { Id = 115, MateriaId = 77, NivelId = 4, PlanEstudioId = 3 }, 

            // SEMESTRE 5 (REDES)
            new MateriaPlanEstudio { Id = 116, MateriaId = 21, NivelId = 5, PlanEstudioId = 3 }, // PROBABILIDAD Y ESTADÍSTICA II
            new MateriaPlanEstudio { Id = 117, MateriaId = 24, NivelId = 5, PlanEstudioId = 3 }, // BASE DE DATOS I
            new MateriaPlanEstudio { Id = 118, MateriaId = 78, NivelId = 5, PlanEstudioId = 3 }, // ELECTRONICA APLICADA A REDES
            new MateriaPlanEstudio { Id = 119, MateriaId = 79, NivelId = 5, PlanEstudioId = 3 }, // SISTEMAS LOGICOS Y DIGITALES I
            new MateriaPlanEstudio { Id = 120, MateriaId = 80, NivelId = 5, PlanEstudioId = 3 }, // SEÑALES Y SISTEMAS
            new MateriaPlanEstudio { Id = 121, MateriaId = 81, NivelId = 5, PlanEstudioId = 3 }, // DISEÑO DE CIRCUITOS INTEGRADOS
            new MateriaPlanEstudio { Id = 122, MateriaId = 82, NivelId = 5, PlanEstudioId = 3 }, // INSTRUMENTACION

            // SEMESTRE 6
            new MateriaPlanEstudio { Id = 123, MateriaId = 28, NivelId = 6, PlanEstudioId = 3 }, // SISTEMA OPERATIVO I
            new MateriaPlanEstudio { Id = 124, MateriaId = 29, NivelId = 6, PlanEstudioId = 3 }, // BASE DE DATOS II
            new MateriaPlanEstudio { Id = 125, MateriaId = 26, NivelId = 6, PlanEstudioId = 3 }, // INVESTIGACION OPERATIVA I
            new MateriaPlanEstudio { Id = 126, MateriaId = 83, NivelId = 6, PlanEstudioId = 3 }, // SISTEMAS LOGICOS Y DIGITALES II
            new MateriaPlanEstudio { Id = 127, MateriaId = 84, NivelId = 6, PlanEstudioId = 3 }, // INTERPRETACION DE SISTEMAS Y SEÑALES
            new MateriaPlanEstudio { Id = 128, MateriaId = 85, NivelId = 6, PlanEstudioId = 3 }, // SISTEMAS DE COMUNICACION SCADA
            new MateriaPlanEstudio { Id = 129, MateriaId = 86, NivelId = 6, PlanEstudioId = 3 }, // TELEVISION DIGITAL

            new MateriaPlanEstudio { Id = 130, MateriaId = 99, NivelId = 6, PlanEstudioId = 3 }, // MODALIDAD TITULACION A NIVEL TECNICO

            // SEMESTRE 7
            new MateriaPlanEstudio { Id = 131, MateriaId = 34, NivelId = 7, PlanEstudioId = 3 }, // REDES I
            new MateriaPlanEstudio { Id = 132, MateriaId = 33, NivelId = 7, PlanEstudioId = 3 }, // SISTEMAS OPERATIVOS II
            new MateriaPlanEstudio { Id = 133, MateriaId = 31, NivelId = 7, PlanEstudioId = 3 }, // INVESTIGACION OPERATIVA II
            new MateriaPlanEstudio { Id = 134, MateriaId = 87, NivelId = 7, PlanEstudioId = 3 }, // APLICACIONES CON MICROPROCESADORES
            new MateriaPlanEstudio { Id = 135, MateriaId = 88, NivelId = 7, PlanEstudioId = 3 }, // SISTEMAS DE COMUNICACION I
            new MateriaPlanEstudio { Id = 136, MateriaId = 89, NivelId = 7, PlanEstudioId = 3 }, // DOMOTICA
            new MateriaPlanEstudio { Id = 137, MateriaId = 90, NivelId = 7, PlanEstudioId = 3 }, // LINEAS DE TRANSMISION Y ANTENAS

            // SEMESTRE 8
            new MateriaPlanEstudio { Id = 138, MateriaId = 39, NivelId = 8, PlanEstudioId = 3 }, // REDES II
            new MateriaPlanEstudio { Id = 139, MateriaId = 36, NivelId = 8, PlanEstudioId = 3 }, // PREPARACION Y EVALUACION DE PROYECTO
            new MateriaPlanEstudio { Id = 140, MateriaId = 91, NivelId = 8, PlanEstudioId = 3 }, // TALLER DE ANALISIS DE DISEÑO DE REDES
            new MateriaPlanEstudio { Id = 141, MateriaId = 92, NivelId = 8, PlanEstudioId = 3 }, // LEGISLACION EN REDES Y COMUNICACIONES
            new MateriaPlanEstudio { Id = 142, MateriaId = 93, NivelId = 8, PlanEstudioId = 3 }, // SISTEMAS DE COMUNICACION II
            new MateriaPlanEstudio { Id = 143, MateriaId = 94, NivelId = 8, PlanEstudioId = 3 }, // TECNICAS DE PRESENTACION PARA INGENIERIA
            new MateriaPlanEstudio { Id = 144, MateriaId = 95, NivelId = 8, PlanEstudioId = 3 }, // REDES ADHOC

            // SEMESTRE 9
            new MateriaPlanEstudio { Id = 145, MateriaId = 41, NivelId = 9, PlanEstudioId = 3 }, // TALLER DE GRADO I
            new MateriaPlanEstudio { Id = 146, MateriaId = 42, NivelId = 9, PlanEstudioId = 3 }, // TECNOLOGIA WEB
            new MateriaPlanEstudio { Id = 147, MateriaId = 96, NivelId = 9, PlanEstudioId = 3 }, // GESTION Y ADMINISTRACION EN REDES
            new MateriaPlanEstudio { Id = 148, MateriaId = 97, NivelId = 9, PlanEstudioId = 3 }, // REDES INALAMBRICAS Y COMUNICACIONES MOVILES
            new MateriaPlanEstudio { Id = 149, MateriaId = 98, NivelId = 9, PlanEstudioId = 3 }, // SEGURIDAD EN REDES Y TRANSMISION DE DATOS

            // SEMESTRE 10
            new MateriaPlanEstudio { Id = 150, MateriaId = 100, NivelId = 10, PlanEstudioId = 3 } // MODALIDAD DE TITULACION

        );


        // // ==========================================================
        // // INGENIERIA INFORMATICA (PlanEstudioId = 1)
        // // ==========================================================
        // // PRIMER SEMESTRE
        // new MateriaPlanEstudio { Id = 1, MateriaId = 1, NivelId = 1, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 2, MateriaId = 2, NivelId = 1, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 3, MateriaId = 3, NivelId = 1, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 4, MateriaId = 4, NivelId = 1, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 5, MateriaId = 5, NivelId = 1, PlanEstudioId = 1 },
        // // SEGUNDO SEMESTRE
        // new MateriaPlanEstudio { Id = 6, MateriaId = 6, NivelId = 2, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 7, MateriaId = 7, NivelId = 2, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 8, MateriaId = 8, NivelId = 2, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 9, MateriaId = 9, NivelId = 2, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 10, MateriaId = 10, NivelId = 2, PlanEstudioId = 1 },
        // // TERCER SEMESTRE
        // new MateriaPlanEstudio { Id = 11, MateriaId = 11, NivelId = 3, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 12, MateriaId = 12, NivelId = 3, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 13, MateriaId = 13, NivelId = 3, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 14, MateriaId = 14, NivelId = 3, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 15, MateriaId = 15, NivelId = 3, PlanEstudioId = 1 },
        // // CUARTO SEMESTRE
        // new MateriaPlanEstudio { Id = 16, MateriaId = 18, NivelId = 4, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 17, MateriaId = 19, NivelId = 4, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 18, MateriaId = 20, NivelId = 4, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 19, MateriaId = 21, NivelId = 4, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 20, MateriaId = 22, NivelId = 4, PlanEstudioId = 1 },
        // // QUINTO SEMESTRE
        // new MateriaPlanEstudio { Id = 21, MateriaId = 24, NivelId = 5, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 22, MateriaId = 25, NivelId = 5, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 23, MateriaId = 26, NivelId = 5, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 24, MateriaId = 27, NivelId = 5, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 25, MateriaId = 28, NivelId = 5, PlanEstudioId = 1 },
        // // SEXTO SEMESTRE
        // new MateriaPlanEstudio { Id = 26, MateriaId = 34, NivelId = 6, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 27, MateriaId = 35, NivelId = 6, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 28, MateriaId = 36, NivelId = 6, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 29, MateriaId = 37, NivelId = 6, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 30, MateriaId = 38, NivelId = 6, PlanEstudioId = 1 },
        // // SEPTIMO SEMESTRE
        // new MateriaPlanEstudio { Id = 31, MateriaId = 42, NivelId = 7, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 32, MateriaId = 43, NivelId = 7, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 33, MateriaId = 44, NivelId = 7, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 34, MateriaId = 45, NivelId = 7, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 35, MateriaId = 46, NivelId = 7, PlanEstudioId = 1 },
        // // OCTAVO SEMESTRE
        // new MateriaPlanEstudio { Id = 36, MateriaId = 50, NivelId = 8, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 37, MateriaId = 51, NivelId = 8, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 38, MateriaId = 52, NivelId = 8, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 39, MateriaId = 53, NivelId = 8, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 40, MateriaId = 54, NivelId = 8, PlanEstudioId = 1 },
        // // NOVENO SEMESTRE
        // new MateriaPlanEstudio { Id = 41, MateriaId = 59, NivelId = 9, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 42, MateriaId = 60, NivelId = 9, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 43, MateriaId = 61, NivelId = 9, PlanEstudioId = 1 },
        // new MateriaPlanEstudio { Id = 44, MateriaId = 62, NivelId = 9, PlanEstudioId = 1 },
        // // DECIMO SEMESTRE
        // new MateriaPlanEstudio { Id = 45, MateriaId = 45, NivelId = 10, PlanEstudioId = 1 },


        // // ==========================================================
        // // INGENIERIA EN SISTEMAS (PlanEstudioId = 2)
        // // ==========================================================
        // // PRIMER SEMESTRE
        // new MateriaPlanEstudio { Id = 46, MateriaId = 1, NivelId = 1, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 47, MateriaId = 2, NivelId = 1, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 48, MateriaId = 3, NivelId = 1, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 49, MateriaId = 4, NivelId = 1, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 50, MateriaId = 5, NivelId = 1, PlanEstudioId = 2 },
        // // SEGUNDO SEMESTRE
        // new MateriaPlanEstudio { Id = 51, MateriaId = 6, NivelId = 2, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 52, MateriaId = 7, NivelId = 2, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 53, MateriaId = 8, NivelId = 2, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 54, MateriaId = 9, NivelId = 2, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 55, MateriaId = 10, NivelId = 2, PlanEstudioId = 2 },
        // // TERCER SEMESTRE
        // new MateriaPlanEstudio { Id = 56, MateriaId = 11, NivelId = 3, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 57, MateriaId = 12, NivelId = 3, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 58, MateriaId = 13, NivelId = 3, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 59, MateriaId = 14, NivelId = 3, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 60, MateriaId = 15, NivelId = 3, PlanEstudioId = 2 },
        // // CUARTO SEMESTRE
        // new MateriaPlanEstudio { Id = 61, MateriaId = 18, NivelId = 4, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 62, MateriaId = 19, NivelId = 4, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 63, MateriaId = 20, NivelId = 4, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 64, MateriaId = 21, NivelId = 4, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 65, MateriaId = 22, NivelId = 4, PlanEstudioId = 2 },
        // // QUINTO SEMESTRE
        // new MateriaPlanEstudio { Id = 66, MateriaId = 26, NivelId = 5, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 67, MateriaId = 27, NivelId = 5, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 68, MateriaId = 28, NivelId = 5, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 69, MateriaId = 29, NivelId = 5, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 70, MateriaId = 30, NivelId = 5, PlanEstudioId = 2 },
        // // SEXTO SEMESTRE
        // new MateriaPlanEstudio { Id = 71, MateriaId = 34, NivelId = 6, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 72, MateriaId = 35, NivelId = 6, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 73, MateriaId = 37, NivelId = 6, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 74, MateriaId = 38, NivelId = 6, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 75, MateriaId = 39, NivelId = 6, PlanEstudioId = 2 },
        // // SEPTIMO SEMESTRE
        // new MateriaPlanEstudio { Id = 76, MateriaId = 42, NivelId = 7, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 77, MateriaId = 43, NivelId = 7, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 78, MateriaId = 45, NivelId = 7, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 79, MateriaId = 46, NivelId = 7, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 80, MateriaId = 47, NivelId = 7, PlanEstudioId = 2 },
        // // OCTAVO SEMESTRE
        // new MateriaPlanEstudio { Id = 81, MateriaId = 50, NivelId = 8, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 82, MateriaId = 51, NivelId = 8, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 83, MateriaId = 52, NivelId = 8, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 84, MateriaId = 53, NivelId = 8, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 85, MateriaId = 55, NivelId = 8, PlanEstudioId = 2 },
        // // NOVENO SEMESTRE
        // new MateriaPlanEstudio { Id = 86, MateriaId = 59, NivelId = 9, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 87, MateriaId = 60, NivelId = 9, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 88, MateriaId = 61, NivelId = 9, PlanEstudioId = 2 },
        // new MateriaPlanEstudio { Id = 89, MateriaId = 62, NivelId = 9, PlanEstudioId = 2 },
        // // DECIMO SEMESTRE
        // new MateriaPlanEstudio { Id = 90, MateriaId = 45, NivelId = 10, PlanEstudioId = 2 },


        // // ==========================================================
        // // INGENIERIA EN REDES Y TELECOMUNICACIONES (PlanEstudioId = 3)
        // // ==========================================================
        // // PRIMER SEMESTRE
        // new MateriaPlanEstudio { Id = 91, MateriaId = 1, NivelId = 1, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 92, MateriaId = 2, NivelId = 1, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 93, MateriaId = 3, NivelId = 1, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 94, MateriaId = 4, NivelId = 1, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 95, MateriaId = 5, NivelId = 1, PlanEstudioId = 3 },
        // // SEGUNDO SEMESTRE
        // new MateriaPlanEstudio { Id = 96, MateriaId = 6, NivelId = 2, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 97, MateriaId = 7, NivelId = 2, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 98, MateriaId = 8, NivelId = 2, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 99, MateriaId = 9, NivelId = 2, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 100, MateriaId = 10, NivelId = 2, PlanEstudioId = 3 },
        // // TERCER SEMESTRE
        // new MateriaPlanEstudio { Id = 101, MateriaId = 11, NivelId = 3, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 102, MateriaId = 12, NivelId = 3, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 103, MateriaId = 15, NivelId = 3, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 104, MateriaId = 16, NivelId = 3, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 105, MateriaId = 17, NivelId = 3, PlanEstudioId = 3 },
        // // CUARTO SEMESTRE
        // new MateriaPlanEstudio { Id = 106, MateriaId = 18, NivelId = 4, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 107, MateriaId = 20, NivelId = 4, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 108, MateriaId = 21, NivelId = 4, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 109, MateriaId = 22, NivelId = 4, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 110, MateriaId = 23, NivelId = 4, PlanEstudioId = 3 },
        // // QUINTO SEMESTRE
        // new MateriaPlanEstudio { Id = 111, MateriaId = 26, NivelId = 5, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 112, MateriaId = 28, NivelId = 5, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 113, MateriaId = 31, NivelId = 5, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 114, MateriaId = 32, NivelId = 5, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 115, MateriaId = 33, NivelId = 5, PlanEstudioId = 3 },
        // // SEXTO SEMESTRE
        // new MateriaPlanEstudio { Id = 116, MateriaId = 34, NivelId = 6, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 117, MateriaId = 35, NivelId = 6, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 118, MateriaId = 37, NivelId = 6, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 119, MateriaId = 40, NivelId = 6, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 120, MateriaId = 41, NivelId = 6, PlanEstudioId = 3 },
        // // SEPTIMO SEMESTRE
        // new MateriaPlanEstudio { Id = 121, MateriaId = 42, NivelId = 7, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 122, MateriaId = 43, NivelId = 7, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 123, MateriaId = 46, NivelId = 7, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 124, MateriaId = 48, NivelId = 7, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 125, MateriaId = 49, NivelId = 7, PlanEstudioId = 3 },
        // // OCTAVO SEMESTRE
        // new MateriaPlanEstudio { Id = 126, MateriaId = 51, NivelId = 8, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 127, MateriaId = 53, NivelId = 8, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 128, MateriaId = 56, NivelId = 8, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 129, MateriaId = 57, NivelId = 8, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 130, MateriaId = 58, NivelId = 8, PlanEstudioId = 3 },
        // // NOVENO SEMESTRE
        // new MateriaPlanEstudio { Id = 131, MateriaId = 61, NivelId = 9, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 132, MateriaId = 62, NivelId = 9, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 133, MateriaId = 63, NivelId = 9, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 134, MateriaId = 64, NivelId = 9, PlanEstudioId = 3 },
        // new MateriaPlanEstudio { Id = 135, MateriaId = 65, NivelId = 9, PlanEstudioId = 3 },
        // // DECIMO SEMESTRE
        // new MateriaPlanEstudio { Id = 136, MateriaId = 45, NivelId = 10, PlanEstudioId = 3 }
        // );
    }
}