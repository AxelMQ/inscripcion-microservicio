using Domain.Entities;
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
                Id = 1,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 29,
                GrupoMateriaId = 1,
                HorarioId = 10,
            },
            // ADMINISTRACION - SB
            // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
            new HorarioMateria
            {
                Id = 2,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 29,
                GrupoMateriaId = 2,
                HorarioId = 1,
            },
            // ADMINISTRACION - SC
            // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
            new HorarioMateria
            {
                Id = 3,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 12,
                GrupoMateriaId = 3,
                HorarioId = 1,
            },
            //------------------------------------------------------------------------------------
            // ALGEBRA LINEAL - SA
            // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
            new HorarioMateria
            {
                Id = 4,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 26,
                GrupoMateriaId = 4,
                HorarioId = 2,
            },
            // ALGEBRA LINEAL - SB
            // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
            new HorarioMateria
            {
                Id = 5,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 26,
                GrupoMateriaId = 5,
                HorarioId = 3,
            },
            // ALGEBRA LINEAL - SC
            // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
            new HorarioMateria
            {
                Id = 6,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 26,
                GrupoMateriaId = 6,
                HorarioId = 1,
            },
            // ALGEBRA LINEAL - SD
            // HORARIO 4: Lunes - Miércoles - Viernes (11:30 - 13:00)
            new HorarioMateria
            {
                Id = 7,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 26,
                GrupoMateriaId = 7,
                HorarioId = 4,
            },
            // ALGEBRA LINEAL - SE
            // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
            new HorarioMateria
            {
                Id = 8,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 33,
                GrupoMateriaId = 8,
                HorarioId = 3,
            },
            // ALGEBRA LINEAL - SF
            // HORARIO 23: Lunes - Miércoles (07:00 - 09:15)
            new HorarioMateria
            {
                Id = 9,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 34,
                GrupoMateriaId = 9,
                HorarioId = 23,
            },

            // ==========================================================

            // ANALISIS DE CIRCUITO - SA
            //  HORARIO 58: Martes - Jueves (07:00 - 09:15)
            new HorarioMateria
            {
                Id = 10,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 52,
                GrupoMateriaId = 10,
                HorarioId = 58,
            },
            // ANALISIS DE CIRCUITO - SB
            // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
            new HorarioMateria
            {
                Id = 11,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 52,
                GrupoMateriaId = 11,
                HorarioId = 1,
            },

            // ==========================================================

            // ANALISIS DE CIRCUITO ELECTRONICO - SZ
            // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
            new HorarioMateria
            {
                Id = 12,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 52,
                GrupoMateriaId = 12,
                HorarioId = 2,
            },

            // =====================================================
            // APLICACIONES CON MICROPROCESADORES - SA
            // HORARIO 76: Martes - Jueves (16:00 - 18:15)
            new HorarioMateria
            {
                Id = 13,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 19,
                GrupoMateriaId = 13,
                HorarioId = 76,
            },

        // =====================================================
        // ARQUITECTURA DE COMPUTADORAS - SA - 14
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 14,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 40,
            GrupoMateriaId = 14,
            HorarioId = 1,
        },

        // ARQUITECTURA DE COMPUTADORAS - SB - 15
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 15,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 40,
            GrupoMateriaId = 15,
            HorarioId = 79,
        },
        // =====================================================
        // ARQUITECTURA DE SOFTWARE - SA - 16
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 16,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 78,
            GrupoMateriaId = 16,
            HorarioId = 1,
        },
        // =====================================================
        // AUDITORIA INFORMATICA - SA - 17
        // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
            new HorarioMateria
            {
                Id = 17,
                CuposDisponibles = 30,
                CuposTotal = 100,
                NroAula = 12,
                GestionId = 1,
                ModuloId = 1,
                DocenteId = 75,
                GrupoMateriaId = 17,
                HorarioId = 9,
            },

        // =====================================================
        // BASE DE DATOS I - SA - 18
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            Id = 18,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 78,
            GrupoMateriaId = 18,
            HorarioId = 2,
        },

        // BASE DE DATOS I - SC - 19
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 19,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 78,
            GrupoMateriaId = 19,
            HorarioId = 58,
        },

        // =====================================================
        // BASE DE DATOS II - SB - 20
        // HORARIO 50: Miércoles - Viernes (10:45 - 13:00)
        new HorarioMateria
        {
            Id = 20,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 61,
            GrupoMateriaId = 20,
            HorarioId = 50,
        },
        // BASE DE DATOS II - SD - 21
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 21,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 61,
            GrupoMateriaId = 21,
            HorarioId = 79,
        },

        // =====================================================
        // CALCULO I - F1 - 22
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 22,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 7,
            GrupoMateriaId = 22,
            HorarioId = 79,
        },

        // CALCULO I - SZ - 23
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            Id = 23,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 41,
            GrupoMateriaId = 23,
            HorarioId = 60,
        },

        // CALCULO I - CI - 24
        // HORARIO 25: Lunes - Miércoles (13:45 - 16:00)
        new HorarioMateria
        {
            Id = 24,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 70,
            GrupoMateriaId = 24,
            HorarioId = 25,
        },

        // CALCULO I - I2 - 25
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 25,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 41,
            GrupoMateriaId = 25,
            HorarioId = 1,
        },

        // CALCULO I - SF - 26
        // HORARIO 30: Lunes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 26,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 50,
            GrupoMateriaId = 26,
            HorarioId = 30,
        },

        // CALCULO I - SG - 27
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 27,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 10,
            GrupoMateriaId = 27,
            HorarioId = 76,
        },

        // CALCULO I - SI - 28
        // HORARIO 10: Lunes - Miércoles - Viernes (18:15 - 19:45)
        new HorarioMateria
        {
            Id = 28,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 53,
            GrupoMateriaId = 28,
            HorarioId = 10,
        },

        // CALCULO I - SP - 29
        // HORARIO 55: Martes - Viernes (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 29,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 28,
            GrupoMateriaId = 29,
            HorarioId = 55,
        },

        // CALCULO I - Z1 - 30
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            Id = 30,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 69,
            GrupoMateriaId = 30,
            HorarioId = 60,
        },

        // CALCULO I - Z2 - 31
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            Id = 31,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 1,
            GrupoMateriaId = 31,
            HorarioId = 60,
        },

        // CALCULO I - Z3 - 32
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 32,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 49,
            GrupoMateriaId = 32,
            HorarioId = 76,
        },

        // CALCULO I - Z4 - 33
        // HORARIO 73: Martes - Jueves (13:45 - 16:00)
        new HorarioMateria
        {
            Id = 33,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 73,
            GrupoMateriaId = 33,
            HorarioId = 73,
        },

        // CALCULO I - Z5 - 34
        // HORARIO 12: Lunes - Miércoles - Viernes (19:45 - 21:15)
        new HorarioMateria
        {
            Id = 34,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 2,
            GrupoMateriaId = 34,
            HorarioId = 12,
        },

        // CALCULO I - Z6 - 35
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 35,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 20,
            GrupoMateriaId = 35,
            HorarioId = 1,
        },

        // =========================
        // CALCULO II - SB - 36
        // HORARIO 14: Lunes - Miércoles - Viernes (20:30 - 22:00)
         new HorarioMateria
         {
             Id = 36,
             CuposDisponibles = 30,
             CuposTotal = 100,
             NroAula = 12,
             GestionId = 1,
             ModuloId = 1,
             DocenteId = 43,
             GrupoMateriaId = 36,
             HorarioId = 14,
         },

        // CALCULO II - SD - 37
        // HORARIO 57: Martes - Jueves - Sabado (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 37,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 20,
            GrupoMateriaId = 37,
            HorarioId = 57,
        },

        // CALCULO II - R1 - 38
        // HORARIO 5: Lunes - Miércoles - Viernes (12:15 - 13:45)
        new HorarioMateria
        {
            Id = 38,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 35,
            GrupoMateriaId = 38,
            HorarioId = 5,
        },

        // CALCULO II - 1I - 39
        // HORARIO 82: Martes - Jueves (19:00 - 21:15)
        new HorarioMateria
        {
            Id = 39,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 3,
            DocenteId = 1,
            GrupoMateriaId = 39,
            HorarioId = 82,
        },

        // CALCULO II - C1 - 40
        // HORARIO 47: Miércoles (09:15 - 11:30) - Viernes (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 40,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 50,
            GrupoMateriaId = 40,
            HorarioId = 47,
        },

        // CALCULO II - SH - 41
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
         new HorarioMateria
         {
             Id = 41,
             CuposDisponibles = 30,
             CuposTotal = 100,
             NroAula = 12,
             GestionId = 1,
             ModuloId = 1,
             DocenteId = 79,
             GrupoMateriaId = 41,
             HorarioId = 60,
         },

        // CALCULO II - SN - 42
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 42,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 84,
            GrupoMateriaId = 42,
            HorarioId = 76,
        },

        // =========================
        // COMPILADORES - SA - 43
        // HORARIO 4: Lunes - Miércoles - Viernes (11:30 - 13:00)
        new HorarioMateria
        {
            Id = 43,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 8,
            GrupoMateriaId = 43,
            HorarioId = 4,
        },


        // =========================
        // CONTABILIDAD - SA - 44
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            Id = 44,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 29,
            GrupoMateriaId = 44,
            HorarioId = 2,
        },

        // CONTABILIDAD - SB - 45
        // HORARIO 8: Lunes - Miércoles - Viernes (16:00 - 17:30)
        new HorarioMateria
        {
            Id = 45,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 54,
            GrupoMateriaId = 45,
            HorarioId = 8,
        },

        // ==========================
        // COSTOS Y PRESUPUESTO - SA - 46
        // HORARIO 74: Martes - Jueves (15:15 - 16:45)
        new HorarioMateria
        {
            Id = 46,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 24,
            GrupoMateriaId = 46,
            HorarioId = 74,
        },

        // ==========================
        // CRIPTOGRAFÍA Y SEGURIDAD I2 - 47
        // HORARIO 78: Martes - Jueves (17:30 - 19:00)
        new HorarioMateria
        {
            Id = 47,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 62,
            GrupoMateriaId = 47,
            HorarioId = 78,
        },

        // CRIPTOGRAFÍA Y SEGURIDAD SA - 48
        //HORARIO 77: Martes - Jueves (16:00 - 17:30)
        new HorarioMateria
        {
            Id = 48,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 62,
            GrupoMateriaId = 48,
            HorarioId = 77,
        },

        //=============================================
        // DISEÑO DE CIRCUITOS INTEGRADOS - SA- 49
        // HORARIO 59: Martes - Jueves (07:00 - 08:30)
         new HorarioMateria
         {
             Id = 49,
             CuposDisponibles = 30,
             CuposTotal = 100,
             NroAula = 12,
             GestionId = 1,
             ModuloId = 1,
             DocenteId = 40,
             GrupoMateriaId = 49,
             HorarioId = 59,
         },


        //=============================================
        // ECONOMÍA PARA LA GESTIÓN - SA - 50
        // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
        new HorarioMateria
        {
            Id = 50,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 71,
            GrupoMateriaId = 50,
            HorarioId = 9,
        },

        // ECONOMÍA PARA LA GESTIÓN - SB - 51
        // HORARIO 4: Lunes - Miércoles - Viernes (11:30 - 13:00)
        new HorarioMateria
        {
            Id = 51,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 71,
            GrupoMateriaId = 51,
            HorarioId = 4,
        },

        // ===================================================
        // ECUACIONES DIFERENCIALES - NW - 52
        // HORARIO 60: Martes - Jueves (09:15 - 11:30) 
        new HorarioMateria
        {
            Id = 52,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 49,
            GrupoMateriaId = 52,
            HorarioId = 60,
        },

        // ECUACIONES DIFERENCIALES - NX - 53
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 53,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 37,
            GrupoMateriaId = 53,
            HorarioId = 79,
        },

        // ECUACIONES DIFERENCIALES - SA - 54
        // HORARIO 84: Martes - Jueves (20:30 - 22:45)
        new HorarioMateria
        {
            Id = 54,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 37,
            GrupoMateriaId = 54,
            HorarioId = 84,
        },

        // ECUACIONES DIFERENCIALES - SC - 55
        // HORARIO 84: Martes - Jueves (20:30 - 22:45)
        new HorarioMateria
        {
            Id = 55,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 7,
            GrupoMateriaId = 55,
            HorarioId = 84,
        },

        // =======================================
        // ELECTRÓNICA APLICADA A REDES - SB - 56
        // HORARIO 48: Miércoles (11:30 - 13:45) - Viernes (10:00 - 12:15)
        new HorarioMateria
        {
            Id = 56,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 69,
            GrupoMateriaId = 56,
            HorarioId = 48,
        },

        // =======================================
        // ESTRUCTURA DE DATOS I - I2 - 57
        // HORARIO 75: Martes - Jueves (15:15 - 17:30)
        new HorarioMateria
        {
            Id = 57,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 59,
            GrupoMateriaId = 57,
            HorarioId = 75,
        },

        // ESTRUCTURA DE DATOS I - SA - 58
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 58,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 44,
            GrupoMateriaId = 58,
            HorarioId = 58,
        },

        // ESTRUCTURA DE DATOS I - SB - 59
        // HORARIO 84: Martes - Jueves (20:30 - 22:45)
        new HorarioMateria
        {
            Id = 59,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 21,
            GrupoMateriaId = 59,
            HorarioId = 84,
        },

        // ESTRUCTURA DE DATOS I - SD - 60
        // HORARIO 61: Martes - Jueves (11:30 - 13:45)
        new HorarioMateria
        {
            Id = 60,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 44,
            GrupoMateriaId = 60,
            HorarioId = 61,
        },

        // ===================================================
        // ESTRUCTURA DE DATOS II - SA - 61
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 61,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 59,
            GrupoMateriaId = 61,
            HorarioId = 58,
        },

        // ESTRUCTURA DE DATOS II - SB - 62
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 62,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 72,
            GrupoMateriaId = 62,
            HorarioId = 76,
        },

        // ESTRUCTURA DE DATOS II - SX - 63
        // HORARIO 84: Martes - Jueves (20:30 - 22:45)
        new HorarioMateria
        {
            Id = 63,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 76,
            GrupoMateriaId = 63,
            HorarioId = 84,
        },

        // ====================================
        // ESTRUCTURAS DISCRETAS - SE - 64
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 64,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 74,
            GrupoMateriaId = 64,
            HorarioId = 79,
        },

        // ESTRUCTURAS DISCRETAS - SF - 65
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 65,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 47,
            GrupoMateriaId = 65,
            HorarioId = 1,
        },

        // ESTRUCTURAS DISCRETAS - SH - 66
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 66,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 49,
            GrupoMateriaId = 66,
            HorarioId = 58,
        },

        // ESTRUCTURAS DISCRETAS - SK - 67
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 67,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 33,
            GrupoMateriaId = 67,
            HorarioId = 58,
        },

        // ESTRUCTURAS DISCRETAS - Z2 - 68
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            Id = 68,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 13,
            GrupoMateriaId = 68,
            HorarioId = 2,
        },

        // ESTRUCTURAS DISCRETAS - Z3 - 69
        // HORARIO 6: Lunes - Miércoles - Viernes (13:45 - 15:15)
        new HorarioMateria
        {
            Id = 69,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 13,
            GrupoMateriaId = 69,
            HorarioId = 6,
        },

        // ESTRUCTURAS DISCRETAS - SP - 70
        // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            Id = 70,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 47,
            GrupoMateriaId = 70,
            HorarioId = 3,
        },

        // ESTRUCTURAS DISCRETAS - Z1 - 71
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            Id = 71,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 33,
            GrupoMateriaId = 71,
            HorarioId = 2,
        },

        // ESTRUCTURAS DISCRETAS - Z4 - 72
        // HORARIO 7: Lunes - Miércoles - Viernes (15:15 - 16:45)
        new HorarioMateria
        {
            Id = 72,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 13,
            GrupoMateriaId = 72,
            HorarioId = 7,
        },

        // ESTRUCTURAS DISCRETAS - Z5 - 73
        // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
        new HorarioMateria
        {
            Id = 73,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 33,
            GrupoMateriaId = 73,
            HorarioId = 9,
        },

        // ESTRUCTURAS DISCRETAS - Z6 - 74
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            Id = 74,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 47,
            GrupoMateriaId = 74,
            HorarioId = 2,
        },

        // ==========================================
        // FINANZAS PARA LA EMPRESA - SA - 75
        // HORARIO 61: Martes - Jueves (11:30 - 13:45)
        new HorarioMateria
        {
            Id = 75,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 71,
            GrupoMateriaId = 75,
            HorarioId = 61,
        },

        // FINANZAS PARA LA EMPRESA - SC - 76
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 76,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 12,
            GrupoMateriaId = 76,
            HorarioId = 58,
        },

        // ==========================================
        // FISICA I - R1 - 77
        // HORARIO 15: Lunes - Miércoles - Viernes - Sabado  (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 77,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 4,
            GrupoMateriaId = 77,
            HorarioId = 15,
        },

        // FISICA I - I1 - 78
        // HORARIO 33: Lunes (12:15 - 13:45) - Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 78,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 42,
            GrupoMateriaId = 78,
            HorarioId = 33,
        },

        // FISICA I - SG - 79
        // HORARIO 34: Lunes (13:00 - 14:30) - Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 79,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 67,
            GrupoMateriaId = 79,
            HorarioId = 34,
        },

        // FISICA I - SI - 80
        // HORARIO 41:  Martes - Jueves (07:00 - 09:15) - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            Id = 80,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 22,
            GrupoMateriaId = 80,
            HorarioId = 41,
        },

        // FISICA I - SK - 81
        // HORARIO 44:  Martes - Jueves (16:00 - 18:15) - Viernes (16:00 - 17:30)
        new HorarioMateria
        {
            Id = 81,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 22,
            GrupoMateriaId = 81,
            HorarioId = 44,
        },

        // FISICA I - SM - 82
        // HORARIO 46:  Lunes - Martes - Miercoles (15:15 - 16:45) - Martes (16:45 - 18:15)
        new HorarioMateria
        {
            Id = 82,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 65,
            GrupoMateriaId = 82,
            HorarioId = 46,
        },

        // FISICA I - SP - 83
        // HORARIO 29: Lunes - Miércoles (07:00 - 09:15) - Miercoles (14:30-16:00)
        new HorarioMateria
        {
            Id = 83,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 14,
            GrupoMateriaId = 83,
            HorarioId = 29,
        },

        // FISICA I - Z1 - 84
        // HORARIO 37:  Martes - Jueves (07:00 - 09:15) - Martes (12:15 - 13:45)
        new HorarioMateria
        {
            Id = 84,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 55,
            GrupoMateriaId = 84,
            HorarioId = 37,
        },

        // FISICA I - Z2 - 85
        // HORARIO 38:  Martes - Jueves (07:00 - 09:15) - Martes (11:30 - 13:00)
        new HorarioMateria
        {
            Id = 85,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 63,
            GrupoMateriaId = 85,
            HorarioId = 38,
        },

        // FISICA I - Z3 - 86
        // HORARIO 22: Lunes - Miércoles - Viernes (16:45 - 18:15) - Viernes (18:15 - 19:45)
        new HorarioMateria
        {
            Id = 86,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 25,
            GrupoMateriaId = 86,
            HorarioId = 22,
        },

        // FISICA I - Z4 - 87
        // HORARIO 18: Lunes - Miércoles - Viernes (16:45 - 18:15) - Sábado (08:30 - 10:00)
        new HorarioMateria
        {
            Id = 87,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 17,
            GrupoMateriaId = 87,
            HorarioId = 18,
        },

        // FISICA I - Z5 - 88
        // HORARIO 39:  Martes - Jueves (18:15 - 20:30) - Martes (16:45 - 18:15)
        new HorarioMateria
        {
            Id = 88,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 43,
            GrupoMateriaId = 88,
            HorarioId = 39,
        },

        // FISICA I - Z6 - 89
        // HORARIO 16: Lunes - Miércoles - Viernes (10:00 - 11:30) - Sábado (18:15 - 19:45)
        new HorarioMateria
        {
            Id = 89,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 17,
            GrupoMateriaId = 89,
            HorarioId = 16,
        },

        // ========================================
        // FISICA II - BI - 90
        // HORARIO 42:  Martes - Jueves (07:00 - 09:15) - Viernes (18:15 - 19:45)
        new HorarioMateria
        {
            Id = 90,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 81,
            GrupoMateriaId = 90,
            HorarioId = 42,
        },

        // FISICA II - R1 - 91
        // HORARIO 19: Lunes - Miércoles - Viernes (19:45 - 21:15) - Sábado (09:15 - 10:45)
        new HorarioMateria
        {
            Id = 91,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 63,
            GrupoMateriaId = 91,
            HorarioId = 19,
        },

        // FISICA II - NW - 92
        // HORARIO 40:  Martes - Jueves (18:15 - 20:30) - Miercoles (20:30 - 22:00)
        new HorarioMateria
        {
            Id = 92,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 17,
            GrupoMateriaId = 92,
            HorarioId = 40,
        },

        // FISICA II - NX- 93
        // HORARIO 41:  Martes - Jueves (07:00 - 09:15) - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            Id = 93,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 17,
            GrupoMateriaId = 93,
            HorarioId = 41,
        },

        // FISICA II - SA -94
        // HORARIO 43:  Martes - Jueves (13:45 - 16:00) - Viernes (15:15 - 16:45)
        new HorarioMateria
        {
            Id = 94,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 81,
            GrupoMateriaId = 94,
            HorarioId = 43,
        },

        // FISICA II - SB - 95
        // HORARIO 20: Lunes - Miércoles - Viernes (13:45 - 15:15) - Viernes (16:45 - 18:15)
        new HorarioMateria
        {
            Id = 95,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 81,
            GrupoMateriaId = 95,
            HorarioId = 20,
        },

        // ====================================
        // FISICA III - SA - 96 
        // HORARIO 32: Lunes - Viernes (07:00 - 09:15) - Martes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 96,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 56,
            GrupoMateriaId = 96,
            HorarioId = 32,
        },

        // FISICA III - SB - 97
        // HORARIO 53: Miércoles (08:30 - 10:00) - Jueves (07:00 - 09:15) - Viernes (09:15 - 11:30)
        new HorarioMateria
        {
            Id = 97,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 6,
            GrupoMateriaId = 97,
            HorarioId = 53,
        },

        // FISICA III - SC - 98
        // HORARIO 21: Lunes - Miércoles - Viernes (15:15 - 16:45) - Viernes (21:15 - 22:45)
        new HorarioMateria
        {
            Id = 98,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 64,
            GrupoMateriaId = 98,
            HorarioId = 21,
        },

        // FISICA III - X2 - 99
        // HORARIO 35: Lunes (16:00 - 18:15) - Martes (07:00 - 08:30) - Viernes (13:45 - 16:00)
        new HorarioMateria
        {
            Id = 99,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 82,
            GrupoMateriaId = 99,
            HorarioId = 35,
        },

        // FISICA III - X3 - 100
        // HORARIO 31: Lunes - Jueves (13:45 - 16:00) - Viernes (15:15 - 16:45)
        new HorarioMateria
        {
            Id = 100,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 56,
            GrupoMateriaId = 100,
            HorarioId = 31,
        },

        // FISICA III - X4 - 101
        // HORARIO 45:  Martes (13:45 - 15:15) - Miercoles (16:00 - 18:15) - Viernes (13:45 - 16:00)
        new HorarioMateria
        {
            Id = 101,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 3,
            GrupoMateriaId = 101,
            HorarioId = 45,
        },

        //================================================================
        // GESTIÓN Y ADMINISTRACIÓN DE REDES - SA -102
        // HORARIO 10: Lunes - Miércoles - Viernes (18:15 - 19:45)
        new HorarioMateria
        {
            Id = 102,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 75,
            GrupoMateriaId = 102,
            HorarioId = 10,
        },

        //====================================================================
        // INGENIERÍA DE LA CALIDAD - SA - 103
        // HORARIO 27: Lunes - Miércoles (19:00 - 20:30)
        new HorarioMateria
        {
            Id = 103,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 18,
            GrupoMateriaId = 103,
            HorarioId = 27,
        },

        //====================================================================
        // INGENIERÍA DE SOFTWARE I - SB - 104
        // HORARIO 7: Lunes - Miércoles - Viernes (15:15 - 16:45)
        new HorarioMateria
        {
            Id = 104,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 48,
            GrupoMateriaId = 104,
            HorarioId = 7,
        },

        //==========================================================================
        // INGENIERÍA DE SOFTWARE I - SC - 105
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 105,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 48,
            GrupoMateriaId = 105,
            HorarioId = 76,
        },

        //==========================================================================
        // INGENIERÍA DE SOFTWARE II - SB -106
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 106,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 48,
            GrupoMateriaId = 106,
            HorarioId = 79,
        },

        //==========================================================================
        // INGLÉS TÉCNICO I - NW - 107
        // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            Id = 107,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 5,
            GrupoMateriaId = 107,
            HorarioId = 3,
        },

        // INGLÉS TÉCNICO I - NX - 108
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 108,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 5,
            GrupoMateriaId = 108,
            HorarioId = 76,
        },

        // INGLÉS TÉCNICO I - Z1 - 109
        // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            Id = 109,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 23,
            GrupoMateriaId = 109,
            HorarioId = 3,
        },

        // INGLÉS TÉCNICO I - Z2 - 110
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 110,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 23,
            GrupoMateriaId = 110,
            HorarioId = 1,
        },

        // INGLÉS TÉCNICO I - Z3 - 111
        // HORARIO 73: Martes - Jueves (13:45 - 16:00)
        new HorarioMateria
        {
            Id = 111,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 83,
            GrupoMateriaId = 111,
            HorarioId = 73,
        },

        // INGLÉS TÉCNICO I - Z4 - 112
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 112,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 83,
            GrupoMateriaId = 112,
            HorarioId = 76,
        },

        // INGLÉS TÉCNICO I - Z5 - 113
        // HORARIO 73: Martes - Jueves (13:45 - 16:00)
        new HorarioMateria
        {
            Id = 113,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 23,
            GrupoMateriaId = 113,
            HorarioId = 73,
        },

        //=============================================================
        // PROBABILIDAD Y ESTADÍSTICA I - SB - 114
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            Id = 114,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 14,
            GrupoMateriaId = 114,
            HorarioId = 60,
        },

        // PROBABILIDAD Y ESTADÍSTICA I - SC - 115
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 115,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 13,
            GrupoMateriaId = 115,
            HorarioId = 1,
        },

        // PROBABILIDAD Y ESTADÍSTICA I - SD - 116
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 116,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 15,
            GrupoMateriaId = 116,
            HorarioId = 79,
        },

        // PROBABILIDAD Y ESTADÍSTICA I - SI - 117
        // HORARIO 82: Martes - Jueves (19:00 - 21:15)
        new HorarioMateria
        {
            Id = 117,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 66,
            GrupoMateriaId = 117,
            HorarioId = 82,
        },

        //=============================================================
        // PROBABILIDAD Y ESTADÍSTICA II - SA - 118
        // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            Id = 118,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 13,
            GrupoMateriaId = 118,
            HorarioId = 3,
        },

        // PROBABILIDAD Y ESTADÍSTICA II - SB - 119
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            Id = 119,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 14,
            GrupoMateriaId = 119,
            HorarioId = 60,
        },

        // PROBABILIDAD Y ESTADÍSTICA II - SI - 120
        // HORARIO 11: Lunes - Miércoles - Viernes (19:00 - 20:30)
        new HorarioMateria
        {
            Id = 120,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 36,
            GrupoMateriaId = 120,
            HorarioId = 11,
        },

        // ================================================
        // PRODUCCIÓN Y MARKETING - SA - 121
        // HORARIO 80: Martes - Jueves (18:15 - 19:45)
        new HorarioMateria
        {
            Id = 121,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 6,
            GrupoMateriaId = 121,
            HorarioId = 80,
        },

        // ================================================
        // PROGRAMACIÓN LÓGICA Y FUNCIONAL - SA - 122
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 122,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 8,
            GrupoMateriaId = 122,
            HorarioId = 79,
        },

        // ================================================
        // PROGRAMACIÓN ENSAMBLADOR - SA - 123
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 123,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 77,
            GrupoMateriaId = 123,
            HorarioId = 1,
        },

        // PROGRAMACIÓN ENSAMBLADOR - SB - 124
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 124,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 77,
            GrupoMateriaId = 124,
            HorarioId = 58,
        },

        // PROGRAMACIÓN ENSAMBLADOR - SC - 125
        // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            Id = 125,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 77,
            GrupoMateriaId = 125,
            HorarioId = 3,
        },

        // PROGRAMACIÓN ENSAMBLADOR - SX - 126
        // HORARIO 28: Lunes - Miércoles (19:45 - 22:00)
        new HorarioMateria
        {
            Id = 126,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 30,
            GrupoMateriaId = 126,
            HorarioId = 28,
        },

        // ================================================
        // PROGRAMACIÓN GRÁFICA - SA - 127 
        // HORARIO 86: Sabado (08:00 - 11:30)
        new HorarioMateria
        {
            Id = 127,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 60,
            GrupoMateriaId = 127,
            HorarioId = 86,
        },

        // ================================================
        // PROGRAMACIÓN I - SA - 128
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 128,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 9,
            GrupoMateriaId = 128,
            HorarioId = 1,
        },

        // PROGRAMACIÓN I - SC - 129
        // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
        new HorarioMateria
        {
            Id = 129,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 60,
            GrupoMateriaId = 129,
            HorarioId = 9,
        },

        // PROGRAMACIÓN I - SB - 130
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 130,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 51,
            GrupoMateriaId = 130,
            HorarioId = 58,
        },

        // PROGRAMACIÓN I - SG - 131
        // HORARIO 12: Lunes - Miércoles - Viernes (19:45 - 21:15)
        new HorarioMateria
        {
            Id = 131,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 51,
            GrupoMateriaId = 131,
            HorarioId = 12,
        },

        // PROGRAMACIÓN I - SD - 132
        // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
        new HorarioMateria
        {
            Id = 132,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 76,
            GrupoMateriaId = 132,
            HorarioId = 9,
        },

        // PROGRAMACIÓN I - SF - 133
        // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            Id = 133,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 9,
            GrupoMateriaId = 133,
            HorarioId = 3,
        },

        // PROGRAMACIÓN I - SH - 134
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 134,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 60,
            GrupoMateriaId = 134,
            HorarioId = 76,
        },

        // PROGRAMACIÓN I - SI - 135
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 135,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 51,
            GrupoMateriaId = 135,
            HorarioId = 1,
        },

        // ================================================
        // PROGRAMACIÓN II - SA - 136
        // HORARIO 73: Martes - Jueves (13:45 - 16:00)
        new HorarioMateria
        {
            Id = 136,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 27,
            GrupoMateriaId = 136,
            HorarioId = 73,
        },

        // PROGRAMACIÓN II - SD - 137
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 137,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 45,
            GrupoMateriaId = 137,
            HorarioId = 79,
        },

        // PROGRAMACIÓN II - SC - 138
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 138,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 27,
            GrupoMateriaId = 138,
            HorarioId = 58,
        },

        // PROGRAMACIÓN II - SB - 139
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            Id = 139,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 27,
            GrupoMateriaId = 139,
            HorarioId = 60,
        },

        // PROGRAMACIÓN II - SI - 140
        // HORARIO 8: Lunes - Miércoles - Viernes (16:00 - 17:30)
        new HorarioMateria
        {
            Id = 140,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 62,
            GrupoMateriaId = 140,
            HorarioId = 8,
        },

        // ================================================
        // REDES ADHOC - SA - 141
        // HORARIO 85: Martes - Jueves (21:15 - 22:45)
        new HorarioMateria
        {
            Id = 141,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 80,
            GrupoMateriaId = 141,
            HorarioId = 85,
        },

        // ================================================
        // REDES I - SA - 142
        // HORARIO 12: Lunes - Miércoles - Viernes (19:45 - 21:15)
        new HorarioMateria
        {
            Id = 142,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 52,
            GrupoMateriaId = 142,
            HorarioId = 12,
        },

        // REDES I - SB - 143
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            Id = 143,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 39,
            GrupoMateriaId = 143,
            HorarioId = 60,
        },

        // REDES I - SC - 144
        // HORARIO 82: Martes - Jueves (19:00 - 21:15)
        new HorarioMateria
        {
            Id = 144,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 80,
            GrupoMateriaId = 144,
            HorarioId = 82,
        },

        // ================================================
        // REDES II - R1 - 145
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 145,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 57,
            GrupoMateriaId = 145,
            HorarioId = 1,
        },

        // REDES II - SB - 146
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 146,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 39,
            GrupoMateriaId = 146,
            HorarioId = 79,
        },

        // REDES II - SC - 147
        // HORARIO 10: Lunes - Miércoles - Viernes (18:15 - 19:45)
        new HorarioMateria
        {
            Id = 147,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 39,
            GrupoMateriaId = 147,
            HorarioId = 10,
        },

        // ================================================
        // REDES INALÁMBRICAS Y COMUNICACIONES MÓVILES - SA - 148
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 148,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 11,
            GrupoMateriaId = 148,
            HorarioId = 79,
        },

        // ================================================
        // SEGURIDAD EN REDES Y TRANSMISIÓN DE DATOS - SA - 149
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            Id = 149,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 9,
            GrupoMateriaId = 149,
            HorarioId = 60,
        },

        // ================================================
        // SEÑALES Y SISTEMAS - R1 - 150
        // HORARIO 49: Miércoles (10:00 - 11:30) - Viernes (15:15 - 16:45) - Sabado (15:15 - 16:45)
        new HorarioMateria
        {
            Id = 150,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 43,
            GrupoMateriaId = 150,
            HorarioId = 49,
        },

        // ================================================
        // SISTEMAS DE COMUNICACIÓN I - SR - 151
        // HORARIO 52: Miércoles (13:45 - 16:00) - Sabado(10:00-12:15)
        new HorarioMateria
        {
            Id = 151,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 68,
            GrupoMateriaId = 151,
            HorarioId = 52,
        },

        // ================================================
        // SISTEMAS DE COMUNICACIÓN II - SR - 152
        // HORARIO 56: Martes (13:00 - 16:00) - Viernes (13:45 - 15:15)
        new HorarioMateria
        {
            Id = 152,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 68,
            GrupoMateriaId = 152,
            HorarioId = 56,
        },

        // ================================================
        // SISTEMAS DE COMUNICACIÓN SCADA - R1 - 153
        // HORARIO 80: Martes - Jueves (18:15 - 19:45)
        new HorarioMateria
        {
            Id = 153,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 64,
            GrupoMateriaId = 153,
            HorarioId = 80,
        },

        // ================================================
        // SISTEMAS DE INFORMACIÓN GEOGRÁFICA - SI - 154
        // HORARIO 72: Martes - Jueves (13:00 - 15:15)
        new HorarioMateria
        {
            Id = 154,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 62,
            GrupoMateriaId = 154,
            HorarioId = 72,
        },

        // SISTEMAS DE INFORMACIÓN GEOGRÁFICA - SA - 155
        // HORARIO 10: Lunes - Miércoles - Viernes (18:15 - 19:45)
        new HorarioMateria
        {
            Id = 155,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 17,
            GrupoMateriaId = 155,
            HorarioId = 10,
        },

        // ================================================
        // SISTEMAS DE INFORMACIÓN I - SA - 156
        // HORARIO 60: Martes - Jueves (09:15 - 11:30)
        new HorarioMateria
        {
            Id = 156,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 32,
            GrupoMateriaId = 156,
            HorarioId = 60,
        },

        // SISTEMAS DE INFORMACIÓN I - SC - 157
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 157,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 32,
            GrupoMateriaId = 157,
            HorarioId = 1,
        },

        // ================================================
        // SISTEMAS DE INFORMACIÓN II - SA - 158
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 158,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 32,
            GrupoMateriaId = 158,
            HorarioId = 58,
        },

        // SISTEMAS DE INFORMACIÓN II - SB - 159
        // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
        new HorarioMateria
        {
            Id = 159,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 48,
            GrupoMateriaId = 159,
            HorarioId = 9,
        },

        // ================================================
        // SISTEMAS EXPERTOS - SB - 160
        // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            Id = 160,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 8,
            GrupoMateriaId = 160,
            HorarioId = 3,
        },

        // ================================================
        // SISTEMAS LÓGICOS Y DIGITALES I - ER - 161
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 161,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 11,
            GrupoMateriaId = 161,
            HorarioId = 76,
        },

        // ================================================
        // SISTEMAS LÓGICOS Y DIGITALES II - R1 - 162
        // HORARIO 54: Jueves (11:30 - 13:45) - Viernes (11:30 - 13:45)
        new HorarioMateria
        {
            Id = 162,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 40,
            GrupoMateriaId = 162,
            HorarioId = 54,
        },

        // ================================================
        // SISTEMAS OPERATIVOS I - SA - 163
        // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
        new HorarioMateria
        {
            Id = 163,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 8,
            GrupoMateriaId = 163,
            HorarioId = 1,
        },

        // SISTEMAS OPERATIVOS I - SC - 164
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            Id = 164,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 8,
            GrupoMateriaId = 164,
            HorarioId = 2,
        },

        // ================================================
        // SISTEMAS OPERATIVOS II - SA - 165
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            Id = 165,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 65,
            GrupoMateriaId = 165,
            HorarioId = 2,
        },

        // SISTEMAS OPERATIVOS II - SB - 166
        // HORARIO 76: Martes - Jueves (16:00 - 18:15)
        new HorarioMateria
        {
            Id = 166,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 18,
            GrupoMateriaId = 166,
            HorarioId = 76,
        },

        // ================================================
        // SISTEMAS PARA EL SOPORTE A LA TOMA DE DECISIONES - SA - 167
        // HORARIO 10: Lunes - Miércoles - Viernes (18:15 - 19:45)
        new HorarioMateria
        {
            Id = 167,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 60,
            GrupoMateriaId = 167,
            HorarioId = 10,
        },

        // ================================================
        // TALLER DE ANÁLISIS Y DISEÑO DE REDES - SA - 168
        // HORARIO 13: Lunes - Miércoles - Viernes (21:15 - 22:45)
        new HorarioMateria
        {
            Id = 168,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 39,
            GrupoMateriaId = 168,
            HorarioId = 13,
        },

        // ================================================
        // TALLER DE GRADO I - SS - 169
        // HORARIO 12: Lunes - Miércoles - Viernes (19:45 - 21:15)
        new HorarioMateria
        {
            Id = 169,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 80,
            GrupoMateriaId = 169,
            HorarioId = 12,
        },

        // TALLER DE GRADO I - SA - 170
        // HORARIO 12: Lunes - Miércoles - Viernes (19:45 - 21:15)
        new HorarioMateria
        {
            Id = 170,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 76,
            GrupoMateriaId = 170,
            HorarioId = 12,
        },

        // TALLER DE GRADO I - SC - 171
        // HORARIO 84: Martes - Jueves (20:30 - 22:45)
        new HorarioMateria
        {
            Id = 171,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 48,
            GrupoMateriaId = 171,
            HorarioId = 84,
        },

        // ================================================
        // TECNOLOGIA WEB - SA - 172
        // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
        new HorarioMateria
        {
            Id = 172,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 9,
            GrupoMateriaId = 172,
            HorarioId = 2,
        },

        // TECNOLOGIA WEB - SC - 173
        // HORARIO 58: Martes - Jueves (07:00 - 09:15)
        new HorarioMateria
        {
            Id = 173,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 9,
            GrupoMateriaId = 173,
            HorarioId = 58,
        },

        // ================================================
        // TELEVISIÓN DIGITAL - SR - 174 
        // HORARIO 36:  Martes (09:15 - 12:15)
        new HorarioMateria
        {
            Id = 174,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 64,
            GrupoMateriaId = 174,
            HorarioId = 36,
        },

        // ================================================
        // TEORIA DE CAMPOS - SC - 175
        // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
        new HorarioMateria
        {
            Id = 175,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 64,
            GrupoMateriaId = 175,
            HorarioId = 3,
        },

        // ================================================
        // TÓPICOS AVANZADOS DE PROGRAMACIÓN - SA - 176
        // HORARIO 79: Martes - Jueves (18:15 - 20:30)
        new HorarioMateria
        {
            Id = 176,
            CuposDisponibles = 30,
            CuposTotal = 100,
            NroAula = 12,
            GestionId = 1,
            ModuloId = 1,
            DocenteId = 60,
            GrupoMateriaId = 176,
            HorarioId = 79,
        }

        // ================================================
        );

    }
}
