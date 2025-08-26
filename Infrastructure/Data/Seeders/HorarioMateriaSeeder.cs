using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class HorarioMateriaSeeder : IEntityTypeConfiguration<HorarioMateria>
{
    public void Configure(EntityTypeBuilder<HorarioMateria> builder)
    {
        builder.HasData(
            // ADMINISTRACION - SA
            // HORARIO 10: Lunes - Miércoles - Viernes (18:15 - 19:45)
            new HorarioMateria
            {
                ID = 1,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 1,
                HORARIO_ID = 10,
            },
            // ADMINISTRACION - SB
            // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
            new HorarioMateria
            {
                ID = 2,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 2,
                HORARIO_ID = 1,
            },
            // ADMINISTRACION - SC
            // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
            new HorarioMateria
            {
                ID = 3,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 3,
                HORARIO_ID = 1,
            },
            //------------------------------------------------------------------------------------
            // ALGEBRA LINEAL - SA
            // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
            new HorarioMateria
            {
                ID = 4,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 4,
                HORARIO_ID = 2,
            },
            // ALGEBRA LINEAL - SB
            // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
            new HorarioMateria
            {
                ID = 5,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 5,
                HORARIO_ID = 3,
            },
            // ALGEBRA LINEAL - SC
            // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
            new HorarioMateria
            {
                ID = 6,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 6,
                HORARIO_ID = 1,
            },
            // ALGEBRA LINEAL - SD
            // HORARIO 4: Lunes - Miércoles - Viernes (11:30 - 13:00)
            new HorarioMateria
            {
                ID = 7,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 7,
                HORARIO_ID = 4,
            },
            // ALGEBRA LINEAL - SE
            // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
            new HorarioMateria
            {
                ID = 8,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 8,
                HORARIO_ID = 3,
            },
            // ALGEBRA LINEAL - SF
            // HORARIO 23: Lunes - Miércoles (07:00 - 09:15)
            new HorarioMateria
            {
                ID = 9,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 9,
                HORARIO_ID = 23,
            },

            // ==========================================================

            // ANALISIS DE CIRCUITO - SA
            //  HORARIO 58: Martes - Jueves (07:00 - 09:15)
            new HorarioMateria
            {
                ID = 10,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 10,
                HORARIO_ID = 58,
            },
            // ANALISIS DE CIRCUITO - SB
            // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
            new HorarioMateria
            {
                ID = 11,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 11,
                HORARIO_ID = 1,
            },

            // ==========================================================

            // ANALISIS DE CIRCUITO ELECTRONICO - SZ
            // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
            new HorarioMateria
            {
                ID = 12,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 12,
                HORARIO_ID = 2,
            },

            // =====================================================
            // APLICACIONES CON MICROPROCESADORES - SA
            // HORARIO 76: Martes - Jueves (16:00 - 18:15)
            new HorarioMateria
            {
                ID = 13,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 13,
                HORARIO_ID = 76,
            },

        // =====================================================
        // ARQUITECTURA DE COMPUTADORAS - SA - 14
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            ID = 14,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 14,
            HORARIO_ID = 1,
        },

        // ARQUITECTURA DE COMPUTADORAS - SB - 15
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            ID = 15,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 15,
            HORARIO_ID = 79,
        },
        // =====================================================
        // ARQUITECTURA DE SOFTWARE - SA - 16
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            ID = 16,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 16,
            HORARIO_ID = 1,
        },
        // =====================================================
        // AUDITORIA INFORMATICA - SA - 17
        // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
            new HorarioMateria
            {
                ID = 17,
                CUPOS_DISPONIBLES = 30,
                CUPOS_TOTAL = 100,
                NRO_AULA = 12,
                GESTION_ID = 1,
                MODULO_ID = 1,
                DOCENTE_ID = 1,
                GRUPO_MATERIA_ID = 17,
                HORARIO_ID = 9,
            },

        // =====================================================
        // BASE DE DATOS I - SA - 18
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            ID = 18,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 18,
            HORARIO_ID = 2,
        },

        // BASE DE DATOS I - SC - 19
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            ID = 19,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 19,
            HORARIO_ID = 58,
        },

        // =====================================================
        // BASE DE DATOS II - SB - 20
        // HORARIO 50: Miércoles - Viernes (10:45 - 13:00)
        new HorarioMateria
        {
            ID = 20,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 20,
            HORARIO_ID = 50,
        },
        // BASE DE DATOS II - SD - 21
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            ID = 21,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 21,
            HORARIO_ID = 79,
        },

        // =====================================================
        // CALCULO I - F1 - 22
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            ID = 22,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 22,
            HORARIO_ID = 79,
        },

        // CALCULO I - SZ - 23
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            ID = 23,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 23,
            HORARIO_ID = 60,
        },

        // CALCULO I - CI - 24
        // HORARIO 25: Lunes - Miércoles (13:45 - 16:00)
        new HorarioMateria
        {
            ID = 24,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 24,
            HORARIO_ID = 25,
        },

        // CALCULO I - I2 - 25
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            ID = 25,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 25,
            HORARIO_ID = 1,
        },

        // CALCULO I - SF - 26
        // HORARIO 30: Lunes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            ID = 26,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 26,
            HORARIO_ID = 30,
        },

        // CALCULO I - SG - 27
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            ID = 27,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 27,
            HORARIO_ID = 76,
        },

        // CALCULO I - SI - 28
        // HORARIO 10: Lunes - Miércoles - Viernes (18:15 - 19:45)
        new HorarioMateria
        {
            ID = 28,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 28,
            HORARIO_ID = 10,
        },

        // CALCULO I - SP - 29
        // HORARIO 55: Martes - Viernes (07:00 - 09:15)
        new HorarioMateria
        {
            ID = 29,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 29,
            HORARIO_ID = 55,
        },

        // CALCULO I - Z1 - 30
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            ID = 30,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 30,
            HORARIO_ID = 60,
        },

        // CALCULO I - Z2 - 31
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            ID = 31,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 31,
            HORARIO_ID = 60,
        },

        // CALCULO I - Z3 - 32
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            ID = 32,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 32,
            HORARIO_ID = 76,
        },

        // CALCULO I - Z4 - 33
        // HORARIO 73: Martes - Jueves (13:45 - 16:00)
        new HorarioMateria
        {
            ID = 33,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 33,
            HORARIO_ID = 73,
        },

        // CALCULO I - Z5 - 34
        // HORARIO 12: Lunes - Miércoles - Viernes (19:45 - 21:15)
        new HorarioMateria
        {
            ID = 34,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 34,
            HORARIO_ID = 12,
        },

        // CALCULO I - Z6 - 35
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            ID = 35,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 35,
            HORARIO_ID = 1,
        },

        // =========================
        // CALCULO II - SB - 36
        // HORARIO 14: Lunes - Miércoles - Viernes (20:30 - 22:00)
         new HorarioMateria
         {
             ID = 36,
             CUPOS_DISPONIBLES = 30,
             CUPOS_TOTAL = 100,
             NRO_AULA = 12,
             GESTION_ID = 1,
             MODULO_ID = 1,
             DOCENTE_ID = 1,
             GRUPO_MATERIA_ID = 36,
             HORARIO_ID = 14,
         },

        // CALCULO II - SD - 37
        // HORARIO 57: Martes - Jueves - Sabado (07:00 - 08:30)
        new HorarioMateria
        {
            ID = 37,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 37,
            HORARIO_ID = 57,
        },

        // CALCULO II - R1 - 38
        // HORARIO 5: Lunes - Miércoles - Viernes (12:15 - 13:45)
        new HorarioMateria
        {
            ID = 38,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 38,
            HORARIO_ID = 5,
        },

        // CALCULO II - 1I - 39
        // HORARIO 82: Martes - Jueves (19:00 - 21:15)
        new HorarioMateria
        {
            ID = 39,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 39,
            HORARIO_ID = 82,
        },

        // CALCULO II - C1 - 40
        // HORARIO 47: Miércoles (09:15 - 11:30) - Viernes (07:00 - 09:15)
        new HorarioMateria
        {
            ID = 40,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 40,
            HORARIO_ID = 47,
        },

        // CALCULO II - SH - 41
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
         new HorarioMateria
         {
             ID = 41,
             CUPOS_DISPONIBLES = 30,
             CUPOS_TOTAL = 100,
             NRO_AULA = 12,
             GESTION_ID = 1,
             MODULO_ID = 1,
             DOCENTE_ID = 1,
             GRUPO_MATERIA_ID = 41,
             HORARIO_ID = 60,
         },

        // CALCULO II - SN - 42
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            ID = 42,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 42,
            HORARIO_ID = 76,
        },

        // =========================
        // COMPILADORES - SA - 43
        // HORARIO 4: Lunes - Miércoles - Viernes (11:30 - 13:00)
        new HorarioMateria
        {
            ID = 43,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 43,
            HORARIO_ID = 4,
        },


        // =========================
        // CONTABILIDAD - SA - 44
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            ID = 44,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 44,
            HORARIO_ID = 2,
        },

        // CONTABILIDAD - SB - 45
        // HORARIO 8: Lunes - Miércoles - Viernes (16:00 - 17:30)
        new HorarioMateria
        {
            ID = 45,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 45,
            HORARIO_ID = 8,
        },

        // ==========================
        // COSTOS Y PRESUPUESTO - SA - 46
        // HORARIO 74: Martes - Jueves (15:15 - 16:45)
        new HorarioMateria
        {
            ID = 46,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 46,
            HORARIO_ID = 74,
        },

        // ==========================
        // CRIPTOGRAFÍA Y SEGURIDAD I2 - 47
        // HORARIO 78: Martes - Jueves (17:30 - 19:00)
        new HorarioMateria
        {
            ID = 47,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 47,
            HORARIO_ID = 78,
        },

        // CRIPTOGRAFÍA Y SEGURIDAD SA - 48
        //HORARIO 77: Martes - Jueves (16:00 - 17:30)
        new HorarioMateria
        {
            ID = 48,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 48,
            HORARIO_ID = 77,
        },

        //=============================================
        // DISEÑO DE CIRCUITOS INTEGRADOS - SA- 49
        // HORARIO 59: Martes - Jueves (07:00 - 08:30)
         new HorarioMateria
         {
             ID = 49,
             CUPOS_DISPONIBLES = 30,
             CUPOS_TOTAL = 100,
             NRO_AULA = 12,
             GESTION_ID = 1,
             MODULO_ID = 1,
             DOCENTE_ID = 1,
             GRUPO_MATERIA_ID = 49,
             HORARIO_ID = 59,
         },


        //=============================================
        // ECONOMÍA PARA LA GESTIÓN - SA - 50
        // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
        new HorarioMateria
        {
            ID = 50,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 50,
            HORARIO_ID = 9,
        },

        // ECONOMÍA PARA LA GESTIÓN - SB - 51
        // HORARIO 4: Lunes - Miércoles - Viernes (11:30 - 13:00)
        new HorarioMateria
        {
            ID = 51,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 51,
            HORARIO_ID = 4,
        },

        // ===================================================
        // ECUACIONES DIFERENCIALES - NW - 52
        // HORARIO 60: Martes - Jueves (09:15 - 11:30) 
        new HorarioMateria
        {
            ID = 52,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 52,
            HORARIO_ID = 60,
        },

        // ECUACIONES DIFERENCIALES - NX - 53
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            ID = 53,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 53,
            HORARIO_ID = 79,
        },

        // ECUACIONES DIFERENCIALES - SA - 54
        // HORARIO 84: Martes - Jueves (20:30 - 22:45)
        new HorarioMateria
        {
            ID = 54,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 54,
            HORARIO_ID = 84,
        },

        // ECUACIONES DIFERENCIALES - SC - 55
        // HORARIO 84: Martes - Jueves (20:30 - 22:45)
        new HorarioMateria
        {
            ID = 55,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 55,
            HORARIO_ID = 84,
        },

        // =======================================
        // ELECTRÓNICA APLICADA A REDES - SB - 56
        // HORARIO 48: Miércoles (11:30 - 13:45) - Viernes (10:00 - 12:15)
        new HorarioMateria
        {
            ID = 56,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 56,
            HORARIO_ID = 48,
        },

        // =======================================
        // ESTRUCTURA DE DATOS I - I2 - 57
        // HORARIO 75: Martes - Jueves (15:15 - 17:30)
        new HorarioMateria
        {
            ID = 57,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 57,
            HORARIO_ID = 75,
        },

        // ESTRUCTURA DE DATOS I - SA - 58
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            ID = 58,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 58,
            HORARIO_ID = 58,
        },

        // ESTRUCTURA DE DATOS I - SB - 59
        // HORARIO 84: Martes - Jueves (20:30 - 22:45)
        new HorarioMateria
        {
            ID = 59,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 59,
            HORARIO_ID = 84,
        },

        // ESTRUCTURA DE DATOS I - SD - 60
        // HORARIO 61: Martes - Jueves (11:30 - 13:45)
        new HorarioMateria
        {
            ID = 60,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 60,
            HORARIO_ID = 61,
        },

        // ===================================================
        // ESTRUCTURA DE DATOS II - SA - 61
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            ID = 61,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 61,
            HORARIO_ID = 58,
        },

        // ESTRUCTURA DE DATOS II - SB - 62
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            ID = 62,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 62,
            HORARIO_ID = 76,
        },

        // ESTRUCTURA DE DATOS II - SX - 63
        // HORARIO 84: Martes - Jueves (20:30 - 22:45)
        new HorarioMateria
        {
            ID = 63,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 63,
            HORARIO_ID = 84,
        },

        // ====================================
        // ESTRUCTURAS DISCRETAS - SE - 64
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            ID = 64,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 64,
            HORARIO_ID = 79,
        },

        // ESTRUCTURAS DISCRETAS - SF - 65
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            ID = 65,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 65,
            HORARIO_ID = 1,
        },

        // ESTRUCTURAS DISCRETAS - SH - 66
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            ID = 66,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 66,
            HORARIO_ID = 58,
        },

        // ESTRUCTURAS DISCRETAS - SK - 67
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            ID = 67,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 67,
            HORARIO_ID = 58,
        },

        // ESTRUCTURAS DISCRETAS - Z2 - 68
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            ID = 68,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 68,
            HORARIO_ID = 2,
        },

        // ESTRUCTURAS DISCRETAS - Z3 - 69
        // HORARIO 6: Lunes - Miércoles - Viernes (13:45 - 15:15)
        new HorarioMateria
        {
            ID = 69,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 69,
            HORARIO_ID = 6,
        },

        // ESTRUCTURAS DISCRETAS - SP - 70
        // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            ID = 70,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 70,
            HORARIO_ID = 3,
        },

        // ESTRUCTURAS DISCRETAS - Z1 - 71
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            ID = 71,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 71,
            HORARIO_ID = 2,
        },

        // ESTRUCTURAS DISCRETAS - Z4 - 72
        // HORARIO 7: Lunes - Miércoles - Viernes (15:15 - 16:45)
        new HorarioMateria
        {
            ID = 72,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 72,
            HORARIO_ID = 7,
        },

        // ESTRUCTURAS DISCRETAS - Z5 - 73
        // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
        new HorarioMateria
        {
            ID = 73,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 73,
            HORARIO_ID = 9,
        },

        // ESTRUCTURAS DISCRETAS - Z6 - 74
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            ID = 74,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 74,
            HORARIO_ID = 2,
        },

        // ==========================================
        // FINANZAS PARA LA EMPRESA - SA - 75
        // HORARIO 61: Martes - Jueves (11:30 - 13:45)
        new HorarioMateria
        {
            ID = 75,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 75,
            HORARIO_ID = 61,
        },

        // FINANZAS PARA LA EMPRESA - SC - 76
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            ID = 76,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 76,
            HORARIO_ID = 58,
        },

        // ==========================================
        // FISICA I - R1 - 77
        // HORARIO 15: Lunes - Miércoles - Viernes - Sabado  (07:00 - 08:30)
        new HorarioMateria
        {
            ID = 77,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 77,
            HORARIO_ID = 15,
        },

        // FISICA I - I1 - 78
        // HORARIO 33: Lunes (12:15 - 13:45) - Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            ID = 78,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 78,
            HORARIO_ID = 33,
        },

        // FISICA I - SG - 79
        // HORARIO 34: Lunes (13:00 - 14:30) - Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            ID = 79,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 79,
            HORARIO_ID = 34,
        },

        // FISICA I - SI - 80
        // HORARIO 41:  Martes - Jueves (07:00 - 09:15) - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            ID = 80,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 80,
            HORARIO_ID = 41,
        },

        // FISICA I - SK - 81
        // HORARIO 44:  Martes - Jueves (16:00 - 18:15) - Viernes (16:00 - 17:30)
        new HorarioMateria
        {
            ID = 81,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 81,
            HORARIO_ID = 44,
        },

        // FISICA I - SM - 82
        // HORARIO 46:  Lunes - Martes - Miercoles (15:15 - 16:45) - Martes (16:45 - 18:15)
        new HorarioMateria
        {
            ID = 82,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 82,
            HORARIO_ID = 46,
        },

        // FISICA I - SP - 83
        // HORARIO 29: Lunes - Miércoles (07:00 - 09:15) - Miercoles (14:30-16:00)
        new HorarioMateria
        {
            ID = 83,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 83,
            HORARIO_ID = 29,
        },

        // FISICA I - Z1 - 84
        // HORARIO 37:  Martes - Jueves (07:00 - 09:15) - Martes (12:15 - 13:45)
        new HorarioMateria
        {
            ID = 84,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 84,
            HORARIO_ID = 37,
        },

        // FISICA I - Z2 - 85
        // HORARIO 38:  Martes - Jueves (07:00 - 09:15) - Martes (11:30 - 13:00)
        new HorarioMateria
        {
            ID = 85,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 85,
            HORARIO_ID = 38,
        },

        // FISICA I - Z3 - 86
        // HORARIO 22: Lunes - Miércoles - Viernes (16:45 - 18:15) - Viernes (18:15 - 19:45)
        new HorarioMateria
        {
            ID = 86,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 86,
            HORARIO_ID = 22,
        },

        // FISICA I - Z4 - 87
        // HORARIO 18: Lunes - Miércoles - Viernes (16:45 - 18:15) - Sábado (08:30 - 10:00)
        new HorarioMateria
        {
            ID = 87,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 87,
            HORARIO_ID = 18,
        },

        // FISICA I - Z5 - 88
        // HORARIO 39:  Martes - Jueves (18:15 - 20:30) - Martes (16:45 - 18:15)
        new HorarioMateria
        {
            ID = 88,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 88,
            HORARIO_ID = 39,
        },

        // FISICA I - Z6 - 89
        // HORARIO 16: Lunes - Miércoles - Viernes (10:00 - 11:30) - Sábado (18:15 - 19:45)
        new HorarioMateria
        {
            ID = 89,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 89,
            HORARIO_ID = 16,
        },

        // ========================================
        // FISICA II - BI - 90
        // HORARIO 42:  Martes - Jueves (07:00 - 09:15) - Viernes (18:15 - 19:45)
        new HorarioMateria
        {
            ID = 90,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 90,
            HORARIO_ID = 42,
        },

        // FISICA II - R1 - 91
        // HORARIO 19: Lunes - Miércoles - Viernes (19:45 - 21:15) - Sábado (09:15 - 10:45)
        new HorarioMateria
        {
            ID = 91,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 91,
            HORARIO_ID = 19,
        },

        // FISICA II - NW - 92
        // HORARIO 40:  Martes - Jueves (18:15 - 20:30) - Miercoles (20:30 - 22:00)
        new HorarioMateria
        {
            ID = 92,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 92,
            HORARIO_ID = 40,
        },

        // FISICA II - NX- 93
        // HORARIO 41:  Martes - Jueves (07:00 - 09:15) - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            ID = 93,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 93,
            HORARIO_ID = 41,
        },

        // FISICA II - SA -94
        // HORARIO 43:  Martes - Jueves (13:45 - 16:00) - Viernes (15:15 - 16:45)
        new HorarioMateria
        {
            ID = 94,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 94,
            HORARIO_ID = 43,
        },

        // FISICA II - SB - 95
        // HORARIO 20: Lunes - Miércoles - Viernes (13:45 - 15:15) - Viernes (16:45 - 18:15)
        new HorarioMateria
        {
            ID = 95,
            CUPOS_DISPONIBLES = 30,
            CUPOS_TOTAL = 100,
            NRO_AULA = 12,
            GESTION_ID = 1,
            MODULO_ID = 1,
            DOCENTE_ID = 1,
            GRUPO_MATERIA_ID = 95,
            HORARIO_ID = 20,
        }

        // ====================================
        // FISICA III - SA - 96 
        // HORARIO 32: Lunes - Viernes (07:00 - 09:15) - Martes (07:00 - 08:30)

        // FISICA III - SB - 97
        // HORARIO 53: Miércoles (08:30 - 10:00) - Jueves (07:00 - 09:15) - Viernes (09:15 - 11:30)
        
        // FISICA III - SC - 98
        // FISICA III - X2 - 99
        // FISICA III - X3 - 100
        // FISICA III - X4 - 101
 
        );

    }
}
