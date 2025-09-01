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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
                DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
                DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
             DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            ModuloId = 1,
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
            DocenteId = 1,
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
             DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
             DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
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
            DocenteId = 1,
            GrupoMateriaId = 95,
            HorarioId = 20,
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
