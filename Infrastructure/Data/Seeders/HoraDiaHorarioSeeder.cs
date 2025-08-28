using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class HoraDiaHorarioSeeder : IEntityTypeConfiguration<HoraDiaHorario>
{
    public void Configure(EntityTypeBuilder<HoraDiaHorario> builder)
    {
        builder.HasData(
                // =========================
                // HORARIO 1: Lunes - Miércoles - Viernes (07:00 - 08:30)
                // =========================
                new HoraDiaHorario { Id = 1, HorarioId = 1, HoraDiaId = 1 }, // Lunes 07:00-08:30
                new HoraDiaHorario { Id = 2, HorarioId = 1, HoraDiaId = 47 }, // Miércoles 07:00-08:30
                new HoraDiaHorario { Id = 3, HorarioId = 1, HoraDiaId = 85 },  // Viernes 07:00-08:30

                // =========================
                // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
                // =========================
                new HoraDiaHorario { Id = 4, HorarioId = 2, HoraDiaId = 3 }, // Lunes 08:30-10:00
                new HoraDiaHorario { Id = 5, HorarioId = 2, HoraDiaId = 48 }, // Miércoles 08:30-10:00
                new HoraDiaHorario { Id = 6, HorarioId = 2, HoraDiaId = 87 },  // Viernes 08:30-10:00

                // =========================
                // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
                // =========================
                new HoraDiaHorario { Id = 7, HorarioId = 3, HoraDiaId = 5 }, // Lunes 10:00-11:30
                new HoraDiaHorario { Id = 8, HorarioId = 3, HoraDiaId = 50 }, // Miércoles 10:00-11:30
                new HoraDiaHorario { Id = 9, HorarioId = 3, HoraDiaId = 89 },  // Viernes 10:00-11:30

                // =========================
                // HORARIO 4: Lunes - Miércoles - Viernes (11:30 - 13:00)
                // =========================
                new HoraDiaHorario { Id = 10, HorarioId = 4, HoraDiaId = 6 }, // Lunes 11:30-13:00
                new HoraDiaHorario { Id = 11, HorarioId = 4, HoraDiaId = 51 }, // Miércoles 11:30-13:00
                new HoraDiaHorario { Id = 12, HorarioId = 4, HoraDiaId = 91 },  // Viernes 11:30-13:00

                // =========================
                // HORARIO 5: Lunes - Miércoles - Viernes (12:15 - 13:45)
                // =========================
                new HoraDiaHorario { Id = 13, HorarioId = 5, HoraDiaId = 7 }, // Lunes 12:15-13:45
                new HoraDiaHorario { Id = 14, HorarioId = 5, HoraDiaId = 53 }, // Miércoles 12:15-13:45
                new HoraDiaHorario { Id = 15, HorarioId = 5, HoraDiaId = 93 },  // Viernes 12:15-13:45

                // =========================
                // HORARIO 6: Lunes - Miércoles - Viernes (13:45 - 15:15)
                // =========================
                new HoraDiaHorario { Id = 16, HorarioId = 6, HoraDiaId = 9 }, // Lunes 13:45-15:15
                new HoraDiaHorario { Id = 17, HorarioId = 6, HoraDiaId = 54 }, // Miércoles 13:45-15:15
                new HoraDiaHorario { Id = 18, HorarioId = 6, HoraDiaId = 95 },  // Viernes 13:45-15:15

                // =========================
                // HORARIO 7: Lunes - Miércoles - Viernes (15:15 - 16:45)
                // =========================
                new HoraDiaHorario { Id = 19, HorarioId = 7, HoraDiaId = 11 }, // Lunes 15:15-16:45
                new HoraDiaHorario { Id = 20, HorarioId = 7, HoraDiaId = 57 }, // Miércoles 15:15-16:45
                new HoraDiaHorario { Id = 21, HorarioId = 7, HoraDiaId = 96 },  // Viernes 15:15-16:45

                // =========================
                // HORARIO 8: Lunes - Miércoles - Viernes (16:00 - 17:30)
                // =========================
                new HoraDiaHorario { Id = 22, HorarioId = 8, HoraDiaId = 13 }, // Lunes 16:00-17:30
                new HoraDiaHorario { Id = 23, HorarioId = 8, HoraDiaId = 60 }, // Miércoles 16:00-17:30
                new HoraDiaHorario { Id = 24, HorarioId = 8, HoraDiaId = 97 },  // Viernes 16:00-17:30

                // =========================
                // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
                // =========================
                new HoraDiaHorario { Id = 25, HorarioId = 9, HoraDiaId = 14 }, // Lunes 16:45-18:15
                new HoraDiaHorario { Id = 26, HorarioId = 9, HoraDiaId = 59 }, // Miércoles 16:45-18:15
                new HoraDiaHorario { Id = 27, HorarioId = 9, HoraDiaId = 98 },  // Viernes 16:45-18:15

                // =========================
                // HORARIO 10: Lunes - Miércoles - Viernes (18:15 - 19:45)
                // =========================
                new HoraDiaHorario { Id = 28, HorarioId = 10, HoraDiaId = 15 }, // Lunes 18:15-19:45
                new HoraDiaHorario { Id = 29, HorarioId = 10, HoraDiaId = 61 }, // Miércoles 18:15-19:45
                new HoraDiaHorario { Id = 30, HorarioId = 10, HoraDiaId = 100 },  // Viernes 18:15-19:45

                // =========================
                // HORARIO 11: Lunes - Miércoles - Viernes (19:00 - 20:30)
                // =========================
                new HoraDiaHorario { Id = 31, HorarioId = 11, HoraDiaId = 16 }, // Lunes 19:00-20:30
                new HoraDiaHorario { Id = 32, HorarioId = 11, HoraDiaId = 62 }, // Miércoles 19:00-20:30
                new HoraDiaHorario { Id = 33, HorarioId = 11, HoraDiaId = 101 },  // Viernes 19:00-20:30

                // =========================
                // HORARIO 12: Lunes - Miércoles - Viernes (19:45 - 21:15)
                // =========================
                new HoraDiaHorario { Id = 34, HorarioId = 12, HoraDiaId = 18 }, // Lunes 19:45-21:15
                new HoraDiaHorario { Id = 35, HorarioId = 12, HoraDiaId = 63 }, // Miércoles 19:45-21:15
                new HoraDiaHorario { Id = 36, HorarioId = 12, HoraDiaId = 103 },  // Viernes 19:45-21:15

                // =========================
                // HORARIO 13: Lunes - Miércoles - Viernes (21:15 - 22:45)
                // =========================
                new HoraDiaHorario { Id = 37, HorarioId = 13, HoraDiaId = 20 }, // Lunes 21:15-22:45
                new HoraDiaHorario { Id = 38, HorarioId = 13, HoraDiaId = 65 }, // Miércoles 21:15-22:45
                new HoraDiaHorario { Id = 39, HorarioId = 13, HoraDiaId = 105 },  // Viernes 21:15-22:45

                // =========================
                // HORARIO 14: Lunes - Miércoles - Viernes (20:30 - 22:00)
                // =========================
                new HoraDiaHorario { Id = 40, HorarioId = 14, HoraDiaId = 19 }, // Lunes 20:30-22:00
                new HoraDiaHorario { Id = 41, HorarioId = 14, HoraDiaId = 64 }, // Miércoles 20:30-22:00
                new HoraDiaHorario { Id = 42, HorarioId = 14, HoraDiaId = 104 },  // Viernes 20:30-22:00

                //==============================================================================================

                // =========================
                // HORARIO 15: Lunes - Miércoles - Viernes - Sabado  (07:00 - 08:30)
                // =========================
                new HoraDiaHorario { Id = 43, HorarioId = 15, HoraDiaId = 1 }, // Lunes 07:00-08:30
                new HoraDiaHorario { Id = 44, HorarioId = 15, HoraDiaId = 47 }, // Miércoles 07:00-08:30
                new HoraDiaHorario { Id = 45, HorarioId = 15, HoraDiaId = 85 },  // Viernes 07:00-08:30
                new HoraDiaHorario { Id = 46, HorarioId = 15, HoraDiaId = 106 },  // Sábado 07:00-08:30

                // =========================
                // HORARIO 16: Lunes - Miércoles - Viernes (10:00 - 11:30) - Sábado (18:15 - 19:45)
                // =========================
                new HoraDiaHorario { Id = 47, HorarioId = 16, HoraDiaId = 5 }, // Lunes 10:00-11:30
                new HoraDiaHorario { Id = 48, HorarioId = 16, HoraDiaId = 50 }, // Miércoles 10:00-11:30
                new HoraDiaHorario { Id = 49, HorarioId = 16, HoraDiaId = 89 },  // Viernes 10:00-11:30
                new HoraDiaHorario { Id = 50, HorarioId = 16, HoraDiaId = 112 },  // Sábado 18:15-19:45

                // =========================
                // HORARIO 17: Lunes - Miércoles - Viernes (10:00 - 11:30) - Sábado (18:26 - 19:45)
                // =========================
                new HoraDiaHorario { Id = 51, HorarioId = 17, HoraDiaId = 5 }, // Lunes 10:00-11:30
                new HoraDiaHorario { Id = 52, HorarioId = 17, HoraDiaId = 50 }, // Miércoles 10:00-11:30
                new HoraDiaHorario { Id = 53, HorarioId = 17, HoraDiaId = 89 },  // Viernes 10:00-11:30
                new HoraDiaHorario { Id = 54, HorarioId = 17, HoraDiaId = 113 },  // Sábado 18:26-19:45

                // =========================
                // HORARIO 18: Lunes - Miércoles - Viernes (16:45 - 18:15) - Sábado (08:30 - 10:00)
                // =========================
                new HoraDiaHorario { Id = 55, HorarioId = 18, HoraDiaId = 14 }, // Lunes 16:45 - 18:15
                new HoraDiaHorario { Id = 56, HorarioId = 18, HoraDiaId = 59 }, // Miércoles 16:45 - 18:15
                new HoraDiaHorario { Id = 57, HorarioId = 18, HoraDiaId = 98 },  // Viernes 16:45 - 18:15
                new HoraDiaHorario { Id = 58, HorarioId = 18, HoraDiaId = 107 },  // Sábado 08:30 - 10:00

                // =========================
                // HORARIO 19: Lunes - Miércoles - Viernes (19:45 - 21:15) - Sábado (09:15 - 10:45)
                // =========================
                new HoraDiaHorario { Id = 59, HorarioId = 19, HoraDiaId = 18 }, // Lunes 19:45 - 21:15
                new HoraDiaHorario { Id = 60, HorarioId = 19, HoraDiaId = 63 }, // Miércoles 19:45 - 21:15
                new HoraDiaHorario { Id = 61, HorarioId = 19, HoraDiaId = 103 },  // Viernes 19:45 - 21:15
                new HoraDiaHorario { Id = 62, HorarioId = 19, HoraDiaId = 109 },  // Sábado 09:15 - 10:45

                //==============================================================================================

                // =========================
                // HORARIO 20: Lunes - Miércoles - Viernes (13:45 - 15:15) - Viernes (16:45 - 18:15)
                // =========================
                new HoraDiaHorario { Id = 63, HorarioId = 20, HoraDiaId = 9 }, // Lunes 13:45 - 15:15
                new HoraDiaHorario { Id = 64, HorarioId = 20, HoraDiaId = 54 }, // Miércoles 13:45 - 15:15
                new HoraDiaHorario { Id = 65, HorarioId = 20, HoraDiaId = 95 },  // Viernes 13:45 - 15:15
                new HoraDiaHorario { Id = 66, HorarioId = 20, HoraDiaId = 98 },  // Viernes 16:45 - 18:15

                // =========================
                // HORARIO 21: Lunes - Miércoles - Viernes (15:15 - 16:45) - Viernes (21:15 - 22:45)
                // =========================
                new HoraDiaHorario { Id = 67, HorarioId = 21, HoraDiaId = 11 }, // Lunes 15:15 - 16:45
                new HoraDiaHorario { Id = 68, HorarioId = 21, HoraDiaId = 57 }, // Miércoles 15:15 - 16:45
                new HoraDiaHorario { Id = 69, HorarioId = 21, HoraDiaId = 96 },  // Viernes 15:15 - 16:45
                new HoraDiaHorario { Id = 70, HorarioId = 21, HoraDiaId = 105 },  // Viernes 21:15 - 22:45

                // =========================
                // HORARIO 22: Lunes - Miércoles - Viernes (16:45 - 18:15) - Viernes (18:15 - 19:45)
                // =========================
                new HoraDiaHorario { Id = 71, HorarioId = 22, HoraDiaId = 14 }, // Lunes 16:45 - 18:15
                new HoraDiaHorario { Id = 72, HorarioId = 22, HoraDiaId = 59 }, // Miércoles 16:45 - 18:15
                new HoraDiaHorario { Id = 73, HorarioId = 22, HoraDiaId = 98 },  // Viernes 16:45 - 18:15
                new HoraDiaHorario { Id = 74, HorarioId = 22, HoraDiaId = 100 },  // Viernes 18:15 - 19:45

                //==============================================================================================

                // =========================
                // HORARIO 23: Lunes - Miércoles (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { Id = 75, HorarioId = 23, HoraDiaId = 2 }, // Lunes 07:00-09:15
                new HoraDiaHorario { Id = 76, HorarioId = 23, HoraDiaId = 46 }, // Miércoles 07:00-09:15

                // =========================
                // HORARIO 24: Lunes - Miércoles (09:15 - 11:30)
                // =========================
                new HoraDiaHorario { Id = 77, HorarioId = 24, HoraDiaId = 4 }, // Lunes 09:15-11:30
                new HoraDiaHorario { Id = 78, HorarioId = 24, HoraDiaId = 49 }, // Miércoles 09:15-11:30

                // =========================
                // HORARIO 25: Lunes - Miércoles (13:45 - 16:00)
                // =========================
                new HoraDiaHorario { Id = 79, HorarioId = 25, HoraDiaId = 10 }, // Lunes 13:45-16:00
                new HoraDiaHorario { Id = 80, HorarioId = 25, HoraDiaId = 55 }, // Miércoles 13:45-16:00

                // =========================
                // HORARIO 26: Lunes - Miércoles (16:00 - 18:15)
                // =========================
                new HoraDiaHorario { Id = 81, HorarioId = 26, HoraDiaId = 12 }, // Lunes 16:00-18:15
                new HoraDiaHorario { Id = 82, HorarioId = 26, HoraDiaId = 58 }, // Miércoles 16:00-18:15

                // =========================
                // HORARIO 27: Lunes - Miércoles (19:00 - 20:30)
                // =========================
                new HoraDiaHorario { Id = 83, HorarioId = 27, HoraDiaId = 16 }, // Lunes 19:00-20:30
                new HoraDiaHorario { Id = 84, HorarioId = 27, HoraDiaId = 62 }, // Miércoles 19:00-20:30

                // =========================
                // HORARIO 28: Lunes - Miércoles (19:45 - 22:00)
                // =========================
                new HoraDiaHorario { Id = 85, HorarioId = 28, HoraDiaId = 17 }, // Lunes 19:45-22:00
                new HoraDiaHorario { Id = 86, HorarioId = 28, HoraDiaId = 116 }, // Miércoles 19:45-22:00

                //==============================================================================================

                // =========================
                // HORARIO 29: Lunes - Miércoles (07:00 - 09:15) - Miercoles (14:30-16:00)
                // =========================
                new HoraDiaHorario { Id = 87, HorarioId = 29, HoraDiaId = 2 }, // Lunes 07:00-09:15
                new HoraDiaHorario { Id = 88, HorarioId = 29, HoraDiaId = 46 }, // Miércoles 07:00-09:15
                new HoraDiaHorario { Id = 89, HorarioId = 29, HoraDiaId = 56 }, // Miércoles 14:30-16:00

                //==============================================================================================

                // =========================
                // HORARIO 30: Lunes - Jueves (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { Id = 90, HorarioId = 30, HoraDiaId = 2 }, // Lunes 07:00-09:15
                new HoraDiaHorario { Id = 91, HorarioId = 30, HoraDiaId = 67 }, // Jueves 07:00-09:15

                //==============================================================================================

                // =========================
                // HORARIO 31: Lunes - Jueves (13:45 - 16:00) - Viernes (15:15 - 16:45)
                // =========================
                new HoraDiaHorario { Id = 92, HorarioId = 31, HoraDiaId = 10 }, // Lunes 13:45-16:00
                new HoraDiaHorario { Id = 93, HorarioId = 31, HoraDiaId = 72 }, // Jueves 13:45-16:00
                new HoraDiaHorario { Id = 94, HorarioId = 31, HoraDiaId = 96 }, // Viernes 15:15-16:45

                //==============================================================================================

                // =========================
                // HORARIO 32: Lunes - Viernes (07:00 - 09:15) - Martes (07:00 - 08:30)
                // =========================
                new HoraDiaHorario { Id = 95, HorarioId = 32, HoraDiaId = 2 }, // Lunes 07:00-09:15
                new HoraDiaHorario { Id = 96, HorarioId = 32, HoraDiaId = 86 }, // Viernes 07:00-09:15
                new HoraDiaHorario { Id = 97, HorarioId = 32, HoraDiaId = 21 }, // Martes 07:00-08:30

                //==============================================================================================

                // =========================
                // HORARIO 33: Lunes (12:15 - 13:45) - Martes - Jueves (16:00 - 18:15)
                // =========================
                new HoraDiaHorario { Id = 98, HorarioId = 33, HoraDiaId = 7 }, // Lunes 12:15-13:45
                new HoraDiaHorario { Id = 99, HorarioId = 33, HoraDiaId = 36 }, // Martes 16:00-18:15
                new HoraDiaHorario { Id = 100, HorarioId = 33, HoraDiaId = 76 }, // Jueves 16:00-18:15

                // =========================
                // HORARIO 34: Lunes (13:00 - 14:30) - Martes - Jueves (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { Id = 101, HorarioId = 34, HoraDiaId = 8 }, // Lunes 13:00-14:30
                new HoraDiaHorario { Id = 102, HorarioId = 34, HoraDiaId = 22 }, // Martes 07:00-09:15
                new HoraDiaHorario { Id = 103, HorarioId = 34, HoraDiaId = 67 }, // Jueves 07:00-09:15

                //==============================================================================================

                // =========================
                // HORARIO 35: Lunes (16:00 - 18:15) - Martes (07:00 - 08:30) - Viernes (13:45 - 16:00)
                // =========================
                new HoraDiaHorario { Id = 104, HorarioId = 35, HoraDiaId = 12 }, // Lunes 16:00-18:15
                new HoraDiaHorario { Id = 105, HorarioId = 35, HoraDiaId = 21 }, // Martes 07:00-08:30
                new HoraDiaHorario { Id = 106, HorarioId = 35, HoraDiaId = 94 }, // Viernes 13:45-16:00

                //==============================================================================================

                // =========================
                // HORARIO 36:  Martes (09:15 - 12:15)
                // =========================
                new HoraDiaHorario { Id = 107, HorarioId = 36, HoraDiaId = 24 }, // Martes 09:15 - 12:15


                //==============================================================================================

                // =========================
                // HORARIO 37:  Martes - Jueves (07:00 - 09:15) - Martes (12:15 - 13:45)
                // =========================
                new HoraDiaHorario { Id = 108, HorarioId = 37, HoraDiaId = 22 }, // Martes 07:00 - 09:15
                new HoraDiaHorario { Id = 109, HorarioId = 37, HoraDiaId = 67 }, // Jueves 07:00 - 09:15
                new HoraDiaHorario { Id = 110, HorarioId = 37, HoraDiaId = 28 }, // Martes 12:15 - 13:45

                // =========================
                // HORARIO 38:  Martes - Jueves (07:00 - 09:15) - Martes (11:30 - 13:00)
                // =========================
                new HoraDiaHorario { Id = 111, HorarioId = 38, HoraDiaId = 22 }, // Martes 07:00 - 09:15
                new HoraDiaHorario { Id = 112, HorarioId = 38, HoraDiaId = 67 }, // Jueves 07:00 - 09:15
                new HoraDiaHorario { Id = 113, HorarioId = 38, HoraDiaId = 26 }, // Martes 11:30 - 13:00

                // =========================
                // HORARIO 39:  Martes - Jueves (18:15 - 20:30) - Martes (16:45 - 18:15)
                // =========================
                new HoraDiaHorario { Id = 114, HorarioId = 39, HoraDiaId = 40 }, // Martes 18:15 - 20:30
                new HoraDiaHorario { Id = 115, HorarioId = 39, HoraDiaId = 79 }, // Jueves 18:15 - 20:30
                new HoraDiaHorario { Id = 116, HorarioId = 39, HoraDiaId = 37 }, // Martes 16:45 - 18:15

                //==============================================================================================

                // =========================
                // HORARIO 40:  Martes - Jueves (18:15 - 20:30) - Miercoles (20:30 - 22:00)
                // =========================
                new HoraDiaHorario { Id = 117, HorarioId = 40, HoraDiaId = 40 }, // Martes 18:15 - 20:30
                new HoraDiaHorario { Id = 118, HorarioId = 40, HoraDiaId = 79 }, // Jueves 18:15 - 20:30
                new HoraDiaHorario { Id = 119, HorarioId = 40, HoraDiaId = 64 }, // Miercoles 20:30 - 22:00

                //==============================================================================================

                // =========================
                // HORARIO 41:  Martes - Jueves (07:00 - 09:15) - Viernes (10:00 - 11:30)
                // =========================
                new HoraDiaHorario { Id = 120, HorarioId = 41, HoraDiaId = 22 }, // Martes 07:00 - 09:15
                new HoraDiaHorario { Id = 121, HorarioId = 41, HoraDiaId = 67 }, // Jueves 07:00 - 09:15
                new HoraDiaHorario { Id = 122, HorarioId = 41, HoraDiaId = 89 }, // Viernes 10:00-11:30

                // =========================
                // HORARIO 42:  Martes - Jueves (07:00 - 09:15) - Viernes (18:15 - 19:45)
                // =========================
                new HoraDiaHorario { Id = 123, HorarioId = 42, HoraDiaId = 22 }, // Martes 07:00 - 09:15
                new HoraDiaHorario { Id = 124, HorarioId = 42, HoraDiaId = 67 }, // Jueves 07:00 - 09:15
                new HoraDiaHorario { Id = 125, HorarioId = 42, HoraDiaId = 100 }, // Viernes 18:15 - 19:45

                // =========================
                // HORARIO 43:  Martes - Jueves (13:45 - 16:00) - Viernes (15:15 - 16:45)
                // =========================
                new HoraDiaHorario { Id = 126, HorarioId = 43, HoraDiaId = 32 }, // Martes 13:45 - 16:00
                new HoraDiaHorario { Id = 127, HorarioId = 43, HoraDiaId = 72 }, // Jueves 13:45 - 16:00
                new HoraDiaHorario { Id = 128, HorarioId = 43, HoraDiaId = 96 }, // Viernes 15:15 - 16:45

                // =========================
                // HORARIO 44:  Martes - Jueves (16:00 - 18:15) - Viernes (16:00 - 17:30)
                // =========================
                new HoraDiaHorario { Id = 129, HorarioId = 44, HoraDiaId = 36 }, // Martes 16:00 - 18:15
                new HoraDiaHorario { Id = 130, HorarioId = 44, HoraDiaId = 76 }, // Jueves 16:00 - 18:15
                new HoraDiaHorario { Id = 131, HorarioId = 44, HoraDiaId = 97 }, // Viernes 16:00 - 17:30

                //==============================================================================================

                // =========================
                // HORARIO 45:  Martes (13:45 - 15:15) - Miercoles (16:00 - 18:15) - Viernes (13:45 - 16:00)
                // =========================
                new HoraDiaHorario { Id = 132, HorarioId = 45, HoraDiaId = 31 }, // Martes 13:45 - 15:15
                new HoraDiaHorario { Id = 133, HorarioId = 45, HoraDiaId = 58 }, // Miercoles 16:00 - 18:15
                new HoraDiaHorario { Id = 134, HorarioId = 45, HoraDiaId = 94 }, // Viernes 13:45 - 16:00


                //==============================================================================================

                // =========================
                // HORARIO 46:  Lunes - Martes - Miercoles (15:15 - 16:45) - Martes (16:45 - 18:15)
                // =========================
                new HoraDiaHorario { Id = 135, HorarioId = 46, HoraDiaId = 11 }, // Lunes 15:15 - 16:45
                new HoraDiaHorario { Id = 136, HorarioId = 46, HoraDiaId = 33 }, // Martes 15:15 - 16:45
                new HoraDiaHorario { Id = 137, HorarioId = 46, HoraDiaId = 57 }, // Miercoles 15:15 - 16:45
                new HoraDiaHorario { Id = 138, HorarioId = 46, HoraDiaId = 37 }, // Martes 16:45-18:15


                //==============================================================================================

                // =========================
                // HORARIO 47: Miércoles (09:15 - 11:30) - Viernes (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { Id = 139, HorarioId = 47, HoraDiaId = 49 }, // Miércoles 09:15-11:30
                new HoraDiaHorario { Id = 140, HorarioId = 47, HoraDiaId = 86 }, // Viernes 07:00-09:15

                // =========================
                // HORARIO 48: Miércoles (11:30 - 13:45) - Viernes (10:00 - 12:15)
                // =========================
                new HoraDiaHorario { Id = 141, HorarioId = 48, HoraDiaId = 52 }, // Miércoles 11:30-13:45
                new HoraDiaHorario { Id = 142, HorarioId = 48, HoraDiaId = 90 }, // Viernes 10:00-12:15

                //==============================================================================================

                // =========================
                // HORARIO 49: Miércoles (10:00 - 11:30) - Viernes (15:15 - 16:45) - Sabado (15:15 - 16:45)
                // =========================
                new HoraDiaHorario { Id = 143, HorarioId = 49, HoraDiaId = 50 }, // Miércoles 10:00 - 11:30
                new HoraDiaHorario { Id = 144, HorarioId = 49, HoraDiaId = 96 }, // Viernes 15:15 - 16:45
                new HoraDiaHorario { Id = 145, HorarioId = 49, HoraDiaId = 111 }, // Sábado 15:15 - 16:45

                //==============================================================================================

                // =========================
                // HORARIO 50: Miércoles - Viernes (10:45 - 13:00)
                // =========================
                new HoraDiaHorario { Id = 146, HorarioId = 50, HoraDiaId = 114 }, // Miércoles 10:45-13:00
                new HoraDiaHorario { Id = 147, HorarioId = 50, HoraDiaId = 115 }, // Viernes 10:45-13:00

                // =========================
                // HORARIO 51: Miércoles (20:30 - 22:00) - Viernes (18:15 - 21:15)
                // =========================
                new HoraDiaHorario { Id = 148, HorarioId = 51, HoraDiaId = 64 }, // Miércoles 20:30-22:00
                new HoraDiaHorario { Id = 149, HorarioId = 51, HoraDiaId = 99 }, // Viernes 18:15-21:15

                //==============================================================================================

                // =========================
                // HORARIO 52: Miércoles (13:45 - 16:00) - Sabado(10:00-12:15)
                // =========================
                new HoraDiaHorario { Id = 150, HorarioId = 52, HoraDiaId = 55 }, // Miércoles 13:45-16:00
                new HoraDiaHorario { Id = 151, HorarioId = 52, HoraDiaId = 110 }, // Sábado 10:00-12:15

                //==============================================================================================

                // =========================
                // HORARIO 53: Miércoles (08:30 - 10:00) - Jueves (07:00 - 09:15) - Viernes (09:15 - 11:30)
                // =========================
                new HoraDiaHorario { Id = 152, HorarioId = 53, HoraDiaId = 48 }, // Miércoles 08:30-10:00
                new HoraDiaHorario { Id = 153, HorarioId = 53, HoraDiaId = 67 }, // Jueves 07:00-09:15
                new HoraDiaHorario { Id = 154, HorarioId = 53, HoraDiaId = 88 }, // Viernes 09:15-11:30

                //==============================================================================================

                // =========================
                // HORARIO 54: Jueves (11:30 - 13:45) - Viernes (11:30 - 13:45)
                // =========================
                new HoraDiaHorario { Id = 155, HorarioId = 54, HoraDiaId = 70 }, // Jueves 11:30-13:45
                new HoraDiaHorario { Id = 156, HorarioId = 54, HoraDiaId = 92 }, // Viernes 11:30-13:45


                //==============================================================================================
                // =========================
                // HORARIO 55: Martes - Viernes (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { Id = 157, HorarioId = 55, HoraDiaId = 22 }, // Martes 07:00-09:15
                new HoraDiaHorario { Id = 158, HorarioId = 55, HoraDiaId = 86 }, // Viernes 07:00-09:15

                // =========================
                // HORARIO 56: Martes (13:00 - 16:00) - Viernes (13:45 - 15:15)
                // =========================
                new HoraDiaHorario { Id = 159, HorarioId = 56, HoraDiaId = 29 }, // Martes 13:00-16:00
                new HoraDiaHorario { Id = 160, HorarioId = 56, HoraDiaId = 95 }, // Viernes 13:45-15:15

                //==============================================================================================

                
                // =========================
                // HORARIO 57: Martes - Jueves - Sabado (07:00 - 08:30)
                // =========================
                new HoraDiaHorario { Id = 161, HorarioId = 57, HoraDiaId = 21 }, // Martes 07:00-08:30
                new HoraDiaHorario { Id = 162, HorarioId = 57, HoraDiaId = 66 }, // Jueves 07:00-08:30
                new HoraDiaHorario { Id = 163, HorarioId = 57, HoraDiaId = 106 }, // Sábado 07:00-08:30


                //==============================================================================================

                // =========================
                // HORARIO 58: Martes - Jueves (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { Id = 164, HorarioId = 58, HoraDiaId = 22 }, // Martes 07:00-09:15
                new HoraDiaHorario { Id = 165, HorarioId = 58, HoraDiaId = 86 }, // Jueves 07:00-09:15

                // =========================
                // HORARIO 59: Martes - Jueves (07:00 - 08:30)
                // =========================
                new HoraDiaHorario { Id = 166, HorarioId = 59, HoraDiaId = 21 }, // Martes 07:00-08:30
                new HoraDiaHorario { Id = 167, HorarioId = 59, HoraDiaId = 66 }, // Jueves 07:00-08:30

                // =========================
                // HORARIO 60: Martes - Jueves (09:15 - 11:30)
                // =========================
                new HoraDiaHorario { Id = 168, HorarioId = 60, HoraDiaId = 23 }, // Martes 09:15-11:30
                new HoraDiaHorario { Id = 169, HorarioId = 60, HoraDiaId = 68 }, // Jueves 09:15-11:30

                // =========================
                // HORARIO 61: Martes - Jueves (11:30 - 13:45)
                // =========================
                new HoraDiaHorario { Id = 170, HorarioId = 61, HoraDiaId = 27 }, // Martes 11:30-13:45
                new HoraDiaHorario { Id = 171, HorarioId = 61, HoraDiaId = 70 }, // Jueves 11:30-13:45

                // =========================
                // HORARIO 72: Martes - Jueves (13:00 - 15:15)
                // =========================
                new HoraDiaHorario { Id = 172, HorarioId = 72, HoraDiaId = 31 }, // Martes 13:00-15:15
                new HoraDiaHorario { Id = 173, HorarioId = 72, HoraDiaId = 71 }, // Jueves 13:00-15:15

                // =========================
                // HORARIO 73: Martes - Jueves (13:45 - 16:00)
                // =========================
                new HoraDiaHorario { Id = 174, HorarioId = 73, HoraDiaId = 32 }, // Martes 13:45-16:00
                new HoraDiaHorario { Id = 175, HorarioId = 73, HoraDiaId = 72 }, // Jueves 13:45-16:00

                // =========================
                // HORARIO 74: Martes - Jueves (15:15 - 16:45)
                // =========================
                new HoraDiaHorario { Id = 176, HorarioId = 74, HoraDiaId = 33 }, // Martes 15:15-16:45
                new HoraDiaHorario { Id = 177, HorarioId = 74, HoraDiaId = 74 }, // Jueves 15:15-16:45

                // =========================
                // HORARIO 75: Martes - Jueves (15:15 - 17:30)
                // =========================
                new HoraDiaHorario { Id = 178, HorarioId = 75, HoraDiaId = 34 }, // Martes 15:15-17:30
                new HoraDiaHorario { Id = 179, HorarioId = 75, HoraDiaId = 73 }, // Jueves 15:15-17:30

                // =========================
                // HORARIO 76: Martes - Jueves (16:00 - 18:15)
                // =========================
                new HoraDiaHorario { Id = 180, HorarioId = 76, HoraDiaId = 36 }, // Martes 16:00-18:15
                new HoraDiaHorario { Id = 181, HorarioId = 76, HoraDiaId = 76 }, // Jueves 16:00-18:15

                // =========================
                // HORARIO 77: Martes - Jueves (16:00 - 17:30)
                // =========================
                new HoraDiaHorario { Id = 182, HorarioId = 77, HoraDiaId = 35 }, // Martes 16:00-17:30
                new HoraDiaHorario { Id = 183, HorarioId = 77, HoraDiaId = 75 }, // Jueves 16:00-17:30

                // =========================
                // HORARIO 78: Martes - Jueves (17:30 - 19:00)
                // =========================
                new HoraDiaHorario { Id = 184, HorarioId = 78, HoraDiaId = 38 }, // Martes 17:30-19:00
                new HoraDiaHorario { Id = 185, HorarioId = 78, HoraDiaId = 77 }, // Jueves 17:30-19:00

                // =========================
                // HORARIO 79: Martes - Jueves (18:15 - 20:30)
                // =========================
                new HoraDiaHorario { Id = 186, HorarioId = 79, HoraDiaId = 40 }, // Martes 18:15-20:30
                new HoraDiaHorario { Id = 187, HorarioId = 79, HoraDiaId = 79 }, // Jueves 18:15-20:30

                // =========================
                // HORARIO 80: Martes - Jueves (18:15 - 19:45)
                // =========================
                new HoraDiaHorario { Id = 188, HorarioId = 80, HoraDiaId = 39 }, // Martes 18:15-19:45
                new HoraDiaHorario { Id = 189, HorarioId = 80, HoraDiaId = 78 }, // Jueves 18:15-19:45

                // =========================
                // HORARIO 81: Martes - Jueves (19:00 - 20:30)
                // =========================
                new HoraDiaHorario { Id = 190, HorarioId = 81, HoraDiaId = 41 }, // Martes 19:00-20:30
                new HoraDiaHorario { Id = 191, HorarioId = 81, HoraDiaId = 80 }, // Jueves 19:00-20:30

                // =========================
                // HORARIO 82: Martes - Jueves (19:00 - 21:15)
                // =========================
                new HoraDiaHorario { Id = 192, HorarioId = 82, HoraDiaId = 42 }, // Martes 19:00-21:15
                new HoraDiaHorario { Id = 193, HorarioId = 82, HoraDiaId = 81 }, // Jueves 19:00-21:15

                // =========================
                // HORARIO 83: Martes - Jueves (20:30 - 22:00)
                // =========================
                new HoraDiaHorario { Id = 194, HorarioId = 83, HoraDiaId = 43 }, // Martes 20:30-22:00
                new HoraDiaHorario { Id = 195, HorarioId = 83, HoraDiaId = 82 }, // Jueves 20:30-22:00

                // =========================
                // HORARIO 84: Martes - Jueves (20:30 - 22:45)
                // =========================
                new HoraDiaHorario { Id = 196, HorarioId = 84, HoraDiaId = 44 }, // Martes 20:30-22:45
                new HoraDiaHorario { Id = 197, HorarioId = 84, HoraDiaId = 83 }, // Jueves 20:30-22:45

                // =========================
                // HORARIO 85: Martes - Jueves (21:15 - 22:45)
                // =========================
                new HoraDiaHorario { Id = 198, HorarioId = 85, HoraDiaId = 45 }, // Martes 21:15-22:45
                new HoraDiaHorario { Id = 199, HorarioId = 85, HoraDiaId = 84 }, // Jueves 21:15-22:45


                //==============================================================================================

                // =========================
                // HORARIO 86: Sabado (08:00 - 11:30)
                // =========================
                new HoraDiaHorario { Id = 200, HorarioId = 86, HoraDiaId = 108 } // Sabado 08:00-11:30


            );
    }
}
