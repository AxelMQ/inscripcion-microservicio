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
            new MateriaPlanEstudio { ID = 1, MATERIA_ID = 1, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 2, MATERIA_ID = 2, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 3, MATERIA_ID = 3, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 4, MATERIA_ID = 4, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 5, MATERIA_ID = 5, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 1 },

            // SEMESTRE 2
            new MateriaPlanEstudio { ID = 6, MATERIA_ID = 6, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 7, MATERIA_ID = 7, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 8, MATERIA_ID = 8, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 9, MATERIA_ID = 9, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 10, MATERIA_ID = 10, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 1 },

            // SEMESTRE 3
            new MateriaPlanEstudio { ID = 11, MATERIA_ID = 11, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 12, MATERIA_ID = 12, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 13, MATERIA_ID = 13, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 14, MATERIA_ID = 14, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 15, MATERIA_ID = 15, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 1 },

            // SEMESTRE 4
            new MateriaPlanEstudio { ID = 16, MATERIA_ID = 16, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 17, MATERIA_ID = 17, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 18, MATERIA_ID = 18, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 19, MATERIA_ID = 19, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 20, MATERIA_ID = 20, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 1 },

            // SEMESTRE 5
            new MateriaPlanEstudio { ID = 21, MATERIA_ID = 21, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 22, MATERIA_ID = 22, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 23, MATERIA_ID = 23, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 24, MATERIA_ID = 24, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 25, MATERIA_ID = 25, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 1 },

            // SEMESTRE 6
            new MateriaPlanEstudio { ID = 26, MATERIA_ID = 26, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 27, MATERIA_ID = 27, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 28, MATERIA_ID = 28, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 29, MATERIA_ID = 29, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 30, MATERIA_ID = 30, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 1 },

            // SEMESTRE 7
            new MateriaPlanEstudio { ID = 31, MATERIA_ID = 31, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 32, MATERIA_ID = 32, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 33, MATERIA_ID = 33, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 34, MATERIA_ID = 34, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 35, MATERIA_ID = 35, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 1 },

            // SEMESTRE 8
            new MateriaPlanEstudio { ID = 36, MATERIA_ID = 36, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 37, MATERIA_ID = 37, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 38, MATERIA_ID = 38, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 39, MATERIA_ID = 39, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 40, MATERIA_ID = 40, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 1 },

            // SEMESTRE 9
            new MateriaPlanEstudio { ID = 41, MATERIA_ID = 41, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 42, MATERIA_ID = 42, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 43, MATERIA_ID = 43, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 1 },
            new MateriaPlanEstudio { ID = 44, MATERIA_ID = 44, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 1 },

            // GRADUACIÓN
            new MateriaPlanEstudio { ID = 45, MATERIA_ID = 58, NIVEL_ID = 10, PLAN_ESTUDIO_ID = 1 },

            // ===== INGENIERÍA EN SISTEMAS (PLAN 2) =====
            // SEMESTRES 1-4 (MISMAS MATERIAS QUE INFORMÁTICA)
            new MateriaPlanEstudio { ID = 46, MATERIA_ID = 1, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 47, MATERIA_ID = 2, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 48, MATERIA_ID = 3, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 49, MATERIA_ID = 4, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 50, MATERIA_ID = 5, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 2 },

            new MateriaPlanEstudio { ID = 51, MATERIA_ID = 6, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 52, MATERIA_ID = 7, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 53, MATERIA_ID = 8, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 54, MATERIA_ID = 9, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 55, MATERIA_ID = 10, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 2 },

            new MateriaPlanEstudio { ID = 56, MATERIA_ID = 11, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 57, MATERIA_ID = 12, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 58, MATERIA_ID = 13, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 59, MATERIA_ID = 14, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 60, MATERIA_ID = 15, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 2 },

            new MateriaPlanEstudio { ID = 61, MATERIA_ID = 16, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 62, MATERIA_ID = 17, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 63, MATERIA_ID = 18, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 64, MATERIA_ID = 19, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 65, MATERIA_ID = 20, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 2 },

            // SEMESTRE 5 (SISTEMAS - MATERIAS ESPECÍFICAS)
            new MateriaPlanEstudio { ID = 66, MATERIA_ID = 21, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 67, MATERIA_ID = 22, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 68, MATERIA_ID = 23, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 69, MATERIA_ID = 24, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 70, MATERIA_ID = 25, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 71, MATERIA_ID = 53, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 72, MATERIA_ID = 54, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },

            // SEMESTRE 6 (SISTEMAS)
            new MateriaPlanEstudio { ID = 73, MATERIA_ID = 26, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 74, MATERIA_ID = 27, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 75, MATERIA_ID = 28, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 76, MATERIA_ID = 29, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 77, MATERIA_ID = 30, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 78, MATERIA_ID = 55, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },

            // SEMESTRE 7 (SISTEMAS)
            new MateriaPlanEstudio { ID = 79, MATERIA_ID = 31, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 80, MATERIA_ID = 32, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 81, MATERIA_ID = 33, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 82, MATERIA_ID = 34, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 83, MATERIA_ID = 35, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 84, MATERIA_ID = 56, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },

            // SEMESTRE 8 (SISTEMAS)
            new MateriaPlanEstudio { ID = 85, MATERIA_ID = 36, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 86, MATERIA_ID = 37, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 87, MATERIA_ID = 38, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 88, MATERIA_ID = 39, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 89, MATERIA_ID = 40, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 90, MATERIA_ID = 57, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },

            // SEMESTRE 9 (SISTEMAS)
            new MateriaPlanEstudio { ID = 91, MATERIA_ID = 41, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 92, MATERIA_ID = 42, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 93, MATERIA_ID = 43, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 2 },
            new MateriaPlanEstudio { ID = 94, MATERIA_ID = 44, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 2 },

            // GRADUACIÓN SISTEMAS
            new MateriaPlanEstudio { ID = 95, MATERIA_ID = 58, NIVEL_ID = 10, PLAN_ESTUDIO_ID = 2 },

            // ===== INGENIERÍA EN REDES (PLAN 3) =====
            // SEMESTRES 1-3 (MISMAS MATERIAS)
            new MateriaPlanEstudio { ID = 96, MATERIA_ID = 1, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 97, MATERIA_ID = 2, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 98, MATERIA_ID = 3, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 99, MATERIA_ID = 4, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 100, MATERIA_ID = 5, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 3 },

            new MateriaPlanEstudio { ID = 101, MATERIA_ID = 6, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 102, MATERIA_ID = 7, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 103, MATERIA_ID = 8, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 104, MATERIA_ID = 9, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 105, MATERIA_ID = 10, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 3 },

            new MateriaPlanEstudio { ID = 106, MATERIA_ID = 11, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 107, MATERIA_ID = 12, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 108, MATERIA_ID = 13, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 109, MATERIA_ID = 14, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 110, MATERIA_ID = 15, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 3 },

            // SEMESTRE 4 (REDES - MATERIAS ESPECÍFICAS)
            new MateriaPlanEstudio { ID = 111, MATERIA_ID = 16, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 112, MATERIA_ID = 17, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 113, MATERIA_ID = 18, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 114, MATERIA_ID = 19, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 3 },
            new MateriaPlanEstudio { ID = 115, MATERIA_ID = 75, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 3 }, // ANÁLISIS DE CIRCUITOS

            // CONTINUAR CON EL RESTO DE MATERIAS DE REDES...
            // SEMESTRE 5 (REDES)
            new MateriaPlanEstudio { ID = 116, MATERIA_ID = 76, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 3 }, // TEORÍA DE CAMPOS
            new MateriaPlanEstudio { ID = 117, MATERIA_ID = 77, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 3 }, // ANÁLISIS CIRCUITOS ELECTRÓNICOS
            new MateriaPlanEstudio { ID = 118, MATERIA_ID = 78, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 3 }, // ELECTRÓNICA APLICADA A REDES
            new MateriaPlanEstudio { ID = 119, MATERIA_ID = 79, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 3 }, // SISTEMAS LÓGICOS Y DIGITALES I
            new MateriaPlanEstudio { ID = 120, MATERIA_ID = 80, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 3 }, // SEÑALES Y SISTEMAS

            // ===== INGENIERÍA ROBÓTICA (PLAN 4) =====
            // SEMESTRES 1-3 (MISMAS MATERIAS)
            new MateriaPlanEstudio { ID = 121, MATERIA_ID = 1, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 122, MATERIA_ID = 2, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 123, MATERIA_ID = 3, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 124, MATERIA_ID = 4, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 125, MATERIA_ID = 5, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 4 },

            new MateriaPlanEstudio { ID = 126, MATERIA_ID = 6, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 127, MATERIA_ID = 7, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 128, MATERIA_ID = 8, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 129, MATERIA_ID = 9, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 130, MATERIA_ID = 10, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 4 },

            new MateriaPlanEstudio { ID = 131, MATERIA_ID = 11, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 132, MATERIA_ID = 12, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 133, MATERIA_ID = 13, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 134, MATERIA_ID = 14, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 135, MATERIA_ID = 15, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 4 },

            // SEMESTRE 4 (ROBÓTICA - MATERIAS ESPECÍFICAS)
            new MateriaPlanEstudio { ID = 136, MATERIA_ID = 16, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 137, MATERIA_ID = 17, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 138, MATERIA_ID = 18, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 139, MATERIA_ID = 19, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 4 },
            new MateriaPlanEstudio { ID = 140, MATERIA_ID = 101, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 4 }, // TALLER DE GRADO I ROBÓTICA

            // CONTINUAR CON EL RESTO DE MATERIAS DE ROBÓTICA...
            // SEMESTRE 5 (ROBÓTICA)
            new MateriaPlanEstudio { ID = 141, MATERIA_ID = 102, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 4 }, // ROBÓTICA AVANZADA
            new MateriaPlanEstudio { ID = 142, MATERIA_ID = 103, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 4 }, // ROBOT OPERATING SYSTEM
            new MateriaPlanEstudio { ID = 143, MATERIA_ID = 104, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 4 }, // SISTEMAS DE CONTROL II
            new MateriaPlanEstudio { ID = 144, MATERIA_ID = 105, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 4 }, // AUTOMATIZACIÓN Y CONTROL
            new MateriaPlanEstudio { ID = 145, MATERIA_ID = 106, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 4 }  // VISIÓN COMPUTACIONAL
        );


        // // ==========================================================
        // // INGENIERIA INFORMATICA (PLAN_ESTUDIO_ID = 1)
        // // ==========================================================
        // // PRIMER SEMESTRE
        // new MateriaPlanEstudio { ID = 1, MATERIA_ID = 1, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 2, MATERIA_ID = 2, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 3, MATERIA_ID = 3, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 4, MATERIA_ID = 4, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 5, MATERIA_ID = 5, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 1 },
        // // SEGUNDO SEMESTRE
        // new MateriaPlanEstudio { ID = 6, MATERIA_ID = 6, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 7, MATERIA_ID = 7, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 8, MATERIA_ID = 8, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 9, MATERIA_ID = 9, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 10, MATERIA_ID = 10, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 1 },
        // // TERCER SEMESTRE
        // new MateriaPlanEstudio { ID = 11, MATERIA_ID = 11, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 12, MATERIA_ID = 12, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 13, MATERIA_ID = 13, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 14, MATERIA_ID = 14, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 15, MATERIA_ID = 15, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 1 },
        // // CUARTO SEMESTRE
        // new MateriaPlanEstudio { ID = 16, MATERIA_ID = 18, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 17, MATERIA_ID = 19, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 18, MATERIA_ID = 20, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 19, MATERIA_ID = 21, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 20, MATERIA_ID = 22, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 1 },
        // // QUINTO SEMESTRE
        // new MateriaPlanEstudio { ID = 21, MATERIA_ID = 24, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 22, MATERIA_ID = 25, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 23, MATERIA_ID = 26, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 24, MATERIA_ID = 27, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 25, MATERIA_ID = 28, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 1 },
        // // SEXTO SEMESTRE
        // new MateriaPlanEstudio { ID = 26, MATERIA_ID = 34, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 27, MATERIA_ID = 35, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 28, MATERIA_ID = 36, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 29, MATERIA_ID = 37, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 30, MATERIA_ID = 38, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 1 },
        // // SEPTIMO SEMESTRE
        // new MateriaPlanEstudio { ID = 31, MATERIA_ID = 42, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 32, MATERIA_ID = 43, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 33, MATERIA_ID = 44, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 34, MATERIA_ID = 45, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 35, MATERIA_ID = 46, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 1 },
        // // OCTAVO SEMESTRE
        // new MateriaPlanEstudio { ID = 36, MATERIA_ID = 50, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 37, MATERIA_ID = 51, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 38, MATERIA_ID = 52, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 39, MATERIA_ID = 53, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 40, MATERIA_ID = 54, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 1 },
        // // NOVENO SEMESTRE
        // new MateriaPlanEstudio { ID = 41, MATERIA_ID = 59, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 42, MATERIA_ID = 60, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 43, MATERIA_ID = 61, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 1 },
        // new MateriaPlanEstudio { ID = 44, MATERIA_ID = 62, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 1 },
        // // DECIMO SEMESTRE
        // new MateriaPlanEstudio { ID = 45, MATERIA_ID = 45, NIVEL_ID = 10, PLAN_ESTUDIO_ID = 1 },


        // // ==========================================================
        // // INGENIERIA EN SISTEMAS (PLAN_ESTUDIO_ID = 2)
        // // ==========================================================
        // // PRIMER SEMESTRE
        // new MateriaPlanEstudio { ID = 46, MATERIA_ID = 1, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 47, MATERIA_ID = 2, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 48, MATERIA_ID = 3, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 49, MATERIA_ID = 4, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 50, MATERIA_ID = 5, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 2 },
        // // SEGUNDO SEMESTRE
        // new MateriaPlanEstudio { ID = 51, MATERIA_ID = 6, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 52, MATERIA_ID = 7, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 53, MATERIA_ID = 8, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 54, MATERIA_ID = 9, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 55, MATERIA_ID = 10, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 2 },
        // // TERCER SEMESTRE
        // new MateriaPlanEstudio { ID = 56, MATERIA_ID = 11, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 57, MATERIA_ID = 12, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 58, MATERIA_ID = 13, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 59, MATERIA_ID = 14, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 60, MATERIA_ID = 15, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 2 },
        // // CUARTO SEMESTRE
        // new MateriaPlanEstudio { ID = 61, MATERIA_ID = 18, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 62, MATERIA_ID = 19, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 63, MATERIA_ID = 20, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 64, MATERIA_ID = 21, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 65, MATERIA_ID = 22, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 2 },
        // // QUINTO SEMESTRE
        // new MateriaPlanEstudio { ID = 66, MATERIA_ID = 26, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 67, MATERIA_ID = 27, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 68, MATERIA_ID = 28, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 69, MATERIA_ID = 29, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 70, MATERIA_ID = 30, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 2 },
        // // SEXTO SEMESTRE
        // new MateriaPlanEstudio { ID = 71, MATERIA_ID = 34, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 72, MATERIA_ID = 35, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 73, MATERIA_ID = 37, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 74, MATERIA_ID = 38, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 75, MATERIA_ID = 39, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 2 },
        // // SEPTIMO SEMESTRE
        // new MateriaPlanEstudio { ID = 76, MATERIA_ID = 42, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 77, MATERIA_ID = 43, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 78, MATERIA_ID = 45, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 79, MATERIA_ID = 46, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 80, MATERIA_ID = 47, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 2 },
        // // OCTAVO SEMESTRE
        // new MateriaPlanEstudio { ID = 81, MATERIA_ID = 50, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 82, MATERIA_ID = 51, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 83, MATERIA_ID = 52, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 84, MATERIA_ID = 53, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 85, MATERIA_ID = 55, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 2 },
        // // NOVENO SEMESTRE
        // new MateriaPlanEstudio { ID = 86, MATERIA_ID = 59, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 87, MATERIA_ID = 60, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 88, MATERIA_ID = 61, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 2 },
        // new MateriaPlanEstudio { ID = 89, MATERIA_ID = 62, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 2 },
        // // DECIMO SEMESTRE
        // new MateriaPlanEstudio { ID = 90, MATERIA_ID = 45, NIVEL_ID = 10, PLAN_ESTUDIO_ID = 2 },


        // // ==========================================================
        // // INGENIERIA EN REDES Y TELECOMUNICACIONES (PLAN_ESTUDIO_ID = 3)
        // // ==========================================================
        // // PRIMER SEMESTRE
        // new MateriaPlanEstudio { ID = 91, MATERIA_ID = 1, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 92, MATERIA_ID = 2, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 93, MATERIA_ID = 3, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 94, MATERIA_ID = 4, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 95, MATERIA_ID = 5, NIVEL_ID = 1, PLAN_ESTUDIO_ID = 3 },
        // // SEGUNDO SEMESTRE
        // new MateriaPlanEstudio { ID = 96, MATERIA_ID = 6, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 97, MATERIA_ID = 7, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 98, MATERIA_ID = 8, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 99, MATERIA_ID = 9, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 100, MATERIA_ID = 10, NIVEL_ID = 2, PLAN_ESTUDIO_ID = 3 },
        // // TERCER SEMESTRE
        // new MateriaPlanEstudio { ID = 101, MATERIA_ID = 11, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 102, MATERIA_ID = 12, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 103, MATERIA_ID = 15, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 104, MATERIA_ID = 16, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 105, MATERIA_ID = 17, NIVEL_ID = 3, PLAN_ESTUDIO_ID = 3 },
        // // CUARTO SEMESTRE
        // new MateriaPlanEstudio { ID = 106, MATERIA_ID = 18, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 107, MATERIA_ID = 20, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 108, MATERIA_ID = 21, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 109, MATERIA_ID = 22, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 110, MATERIA_ID = 23, NIVEL_ID = 4, PLAN_ESTUDIO_ID = 3 },
        // // QUINTO SEMESTRE
        // new MateriaPlanEstudio { ID = 111, MATERIA_ID = 26, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 112, MATERIA_ID = 28, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 113, MATERIA_ID = 31, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 114, MATERIA_ID = 32, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 115, MATERIA_ID = 33, NIVEL_ID = 5, PLAN_ESTUDIO_ID = 3 },
        // // SEXTO SEMESTRE
        // new MateriaPlanEstudio { ID = 116, MATERIA_ID = 34, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 117, MATERIA_ID = 35, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 118, MATERIA_ID = 37, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 119, MATERIA_ID = 40, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 120, MATERIA_ID = 41, NIVEL_ID = 6, PLAN_ESTUDIO_ID = 3 },
        // // SEPTIMO SEMESTRE
        // new MateriaPlanEstudio { ID = 121, MATERIA_ID = 42, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 122, MATERIA_ID = 43, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 123, MATERIA_ID = 46, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 124, MATERIA_ID = 48, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 125, MATERIA_ID = 49, NIVEL_ID = 7, PLAN_ESTUDIO_ID = 3 },
        // // OCTAVO SEMESTRE
        // new MateriaPlanEstudio { ID = 126, MATERIA_ID = 51, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 127, MATERIA_ID = 53, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 128, MATERIA_ID = 56, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 129, MATERIA_ID = 57, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 130, MATERIA_ID = 58, NIVEL_ID = 8, PLAN_ESTUDIO_ID = 3 },
        // // NOVENO SEMESTRE
        // new MateriaPlanEstudio { ID = 131, MATERIA_ID = 61, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 132, MATERIA_ID = 62, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 133, MATERIA_ID = 63, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 134, MATERIA_ID = 64, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 3 },
        // new MateriaPlanEstudio { ID = 135, MATERIA_ID = 65, NIVEL_ID = 9, PLAN_ESTUDIO_ID = 3 },
        // // DECIMO SEMESTRE
        // new MateriaPlanEstudio { ID = 136, MATERIA_ID = 45, NIVEL_ID = 10, PLAN_ESTUDIO_ID = 3 }
        // );
    }
}