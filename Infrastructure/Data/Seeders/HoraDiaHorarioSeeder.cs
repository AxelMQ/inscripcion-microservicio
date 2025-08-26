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
                new HoraDiaHorario { ID = 1, HORARIO_ID = 1, HORA_DIA_ID = 1 }, // Lunes 07:00-08:30
                new HoraDiaHorario { ID = 2, HORARIO_ID = 1, HORA_DIA_ID = 47 }, // Miércoles 07:00-08:30
                new HoraDiaHorario { ID = 3, HORARIO_ID = 1, HORA_DIA_ID = 85 },  // Viernes 07:00-08:30

                // =========================
                // HORARIO 2: Lunes - Miércoles - Viernes (08:30 - 10:00)
                // =========================
                new HoraDiaHorario { ID = 4, HORARIO_ID = 2, HORA_DIA_ID = 3 }, // Lunes 08:30-10:00
                new HoraDiaHorario { ID = 5, HORARIO_ID = 2, HORA_DIA_ID = 48 }, // Miércoles 08:30-10:00
                new HoraDiaHorario { ID = 6, HORARIO_ID = 2, HORA_DIA_ID = 87 },  // Viernes 08:30-10:00

                // =========================
                // HORARIO 3: Lunes - Miércoles - Viernes (10:00 - 11:30)
                // =========================
                new HoraDiaHorario { ID = 7, HORARIO_ID = 3, HORA_DIA_ID = 5 }, // Lunes 10:00-11:30
                new HoraDiaHorario { ID = 8, HORARIO_ID = 3, HORA_DIA_ID = 50 }, // Miércoles 10:00-11:30
                new HoraDiaHorario { ID = 9, HORARIO_ID = 3, HORA_DIA_ID = 89 },  // Viernes 10:00-11:30

                // =========================
                // HORARIO 4: Lunes - Miércoles - Viernes (11:30 - 13:00)
                // =========================
                new HoraDiaHorario { ID = 10, HORARIO_ID = 4, HORA_DIA_ID = 6 }, // Lunes 11:30-13:00
                new HoraDiaHorario { ID = 11, HORARIO_ID = 4, HORA_DIA_ID = 51 }, // Miércoles 11:30-13:00
                new HoraDiaHorario { ID = 12, HORARIO_ID = 4, HORA_DIA_ID = 91 },  // Viernes 11:30-13:00

                // =========================
                // HORARIO 5: Lunes - Miércoles - Viernes (12:15 - 13:45)
                // =========================
                new HoraDiaHorario { ID = 13, HORARIO_ID = 5, HORA_DIA_ID = 7 }, // Lunes 12:15-13:45
                new HoraDiaHorario { ID = 14, HORARIO_ID = 5, HORA_DIA_ID = 53 }, // Miércoles 12:15-13:45
                new HoraDiaHorario { ID = 15, HORARIO_ID = 5, HORA_DIA_ID = 93 },  // Viernes 12:15-13:45

                // =========================
                // HORARIO 6: Lunes - Miércoles - Viernes (13:45 - 15:15)
                // =========================
                new HoraDiaHorario { ID = 16, HORARIO_ID = 6, HORA_DIA_ID = 9 }, // Lunes 13:45-15:15
                new HoraDiaHorario { ID = 17, HORARIO_ID = 6, HORA_DIA_ID = 54 }, // Miércoles 13:45-15:15
                new HoraDiaHorario { ID = 18, HORARIO_ID = 6, HORA_DIA_ID = 95 },  // Viernes 13:45-15:15

                // =========================
                // HORARIO 7: Lunes - Miércoles - Viernes (15:15 - 16:45)
                // =========================
                new HoraDiaHorario { ID = 19, HORARIO_ID = 7, HORA_DIA_ID = 11 }, // Lunes 15:15-16:45
                new HoraDiaHorario { ID = 20, HORARIO_ID = 7, HORA_DIA_ID = 57 }, // Miércoles 15:15-16:45
                new HoraDiaHorario { ID = 21, HORARIO_ID = 7, HORA_DIA_ID = 96 },  // Viernes 15:15-16:45

                // =========================
                // HORARIO 8: Lunes - Miércoles - Viernes (16:00 - 17:30)
                // =========================
                new HoraDiaHorario { ID = 22, HORARIO_ID = 8, HORA_DIA_ID = 13 }, // Lunes 16:00-17:30
                new HoraDiaHorario { ID = 23, HORARIO_ID = 8, HORA_DIA_ID = 60 }, // Miércoles 16:00-17:30
                new HoraDiaHorario { ID = 24, HORARIO_ID = 8, HORA_DIA_ID = 97 },  // Viernes 16:00-17:30

                // =========================
                // HORARIO 9: Lunes - Miércoles - Viernes (16:45 - 18:15)
                // =========================
                new HoraDiaHorario { ID = 25, HORARIO_ID = 9, HORA_DIA_ID = 14 }, // Lunes 16:45-18:15
                new HoraDiaHorario { ID = 26, HORARIO_ID = 9, HORA_DIA_ID = 59 }, // Miércoles 16:45-18:15
                new HoraDiaHorario { ID = 27, HORARIO_ID = 9, HORA_DIA_ID = 98 },  // Viernes 16:45-18:15

                // =========================
                // HORARIO 10: Lunes - Miércoles - Viernes (18:15 - 19:45)
                // =========================
                new HoraDiaHorario { ID = 28, HORARIO_ID = 10, HORA_DIA_ID = 15 }, // Lunes 18:15-19:45
                new HoraDiaHorario { ID = 29, HORARIO_ID = 10, HORA_DIA_ID = 61 }, // Miércoles 18:15-19:45
                new HoraDiaHorario { ID = 30, HORARIO_ID = 10, HORA_DIA_ID = 100 },  // Viernes 18:15-19:45

                // =========================
                // HORARIO 11: Lunes - Miércoles - Viernes (19:00 - 20:30)
                // =========================
                new HoraDiaHorario { ID = 31, HORARIO_ID = 11, HORA_DIA_ID = 16 }, // Lunes 19:00-20:30
                new HoraDiaHorario { ID = 32, HORARIO_ID = 11, HORA_DIA_ID = 62 }, // Miércoles 19:00-20:30
                new HoraDiaHorario { ID = 33, HORARIO_ID = 11, HORA_DIA_ID = 101 },  // Viernes 19:00-20:30

                // =========================
                // HORARIO 12: Lunes - Miércoles - Viernes (19:45 - 21:15)
                // =========================
                new HoraDiaHorario { ID = 34, HORARIO_ID = 12, HORA_DIA_ID = 18 }, // Lunes 19:45-21:15
                new HoraDiaHorario { ID = 35, HORARIO_ID = 12, HORA_DIA_ID = 63 }, // Miércoles 19:45-21:15
                new HoraDiaHorario { ID = 36, HORARIO_ID = 12, HORA_DIA_ID = 103 },  // Viernes 19:45-21:15

                // =========================
                // HORARIO 13: Lunes - Miércoles - Viernes (21:15 - 22:45)
                // =========================
                new HoraDiaHorario { ID = 37, HORARIO_ID = 13, HORA_DIA_ID = 20 }, // Lunes 21:15-22:45
                new HoraDiaHorario { ID = 38, HORARIO_ID = 13, HORA_DIA_ID = 65 }, // Miércoles 21:15-22:45
                new HoraDiaHorario { ID = 39, HORARIO_ID = 13, HORA_DIA_ID = 105 },  // Viernes 21:15-22:45

                // =========================
                // HORARIO 14: Lunes - Miércoles - Viernes (20:30 - 22:00)
                // =========================
                new HoraDiaHorario { ID = 40, HORARIO_ID = 14, HORA_DIA_ID = 19 }, // Lunes 20:30-22:00
                new HoraDiaHorario { ID = 41, HORARIO_ID = 14, HORA_DIA_ID = 64 }, // Miércoles 20:30-22:00
                new HoraDiaHorario { ID = 42, HORARIO_ID = 14, HORA_DIA_ID = 104 },  // Viernes 20:30-22:00

                //==============================================================================================

                // =========================
                // HORARIO 15: Lunes - Miércoles - Viernes - Sabado  (07:00 - 08:30)
                // =========================
                new HoraDiaHorario { ID = 43, HORARIO_ID = 15, HORA_DIA_ID = 1 }, // Lunes 07:00-08:30
                new HoraDiaHorario { ID = 44, HORARIO_ID = 15, HORA_DIA_ID = 47 }, // Miércoles 07:00-08:30
                new HoraDiaHorario { ID = 45, HORARIO_ID = 15, HORA_DIA_ID = 85 },  // Viernes 07:00-08:30
                new HoraDiaHorario { ID = 46, HORARIO_ID = 15, HORA_DIA_ID = 106 },  // Sábado 07:00-08:30

                // =========================
                // HORARIO 16: Lunes - Miércoles - Viernes (10:00 - 11:30) - Sábado (18:15 - 19:45)
                // =========================
                new HoraDiaHorario { ID = 47, HORARIO_ID = 16, HORA_DIA_ID = 5 }, // Lunes 10:00-11:30
                new HoraDiaHorario { ID = 48, HORARIO_ID = 16, HORA_DIA_ID = 50 }, // Miércoles 10:00-11:30
                new HoraDiaHorario { ID = 49, HORARIO_ID = 16, HORA_DIA_ID = 89 },  // Viernes 10:00-11:30
                new HoraDiaHorario { ID = 50, HORARIO_ID = 16, HORA_DIA_ID = 112 },  // Sábado 18:15-19:45

                // =========================
                // HORARIO 17: Lunes - Miércoles - Viernes (10:00 - 11:30) - Sábado (18:26 - 19:45)
                // =========================
                new HoraDiaHorario { ID = 51, HORARIO_ID = 17, HORA_DIA_ID = 5 }, // Lunes 10:00-11:30
                new HoraDiaHorario { ID = 52, HORARIO_ID = 17, HORA_DIA_ID = 50 }, // Miércoles 10:00-11:30
                new HoraDiaHorario { ID = 53, HORARIO_ID = 17, HORA_DIA_ID = 89 },  // Viernes 10:00-11:30
                new HoraDiaHorario { ID = 54, HORARIO_ID = 17, HORA_DIA_ID = 113 },  // Sábado 18:26-19:45

                // =========================
                // HORARIO 18: Lunes - Miércoles - Viernes (16:45 - 18:15) - Sábado (08:30 - 10:00)
                // =========================
                new HoraDiaHorario { ID = 55, HORARIO_ID = 18, HORA_DIA_ID = 14 }, // Lunes 16:45 - 18:15
                new HoraDiaHorario { ID = 56, HORARIO_ID = 18, HORA_DIA_ID = 59 }, // Miércoles 16:45 - 18:15
                new HoraDiaHorario { ID = 57, HORARIO_ID = 18, HORA_DIA_ID = 98 },  // Viernes 16:45 - 18:15
                new HoraDiaHorario { ID = 58, HORARIO_ID = 18, HORA_DIA_ID = 107 },  // Sábado 08:30 - 10:00

                // =========================
                // HORARIO 19: Lunes - Miércoles - Viernes (19:45 - 21:15) - Sábado (09:15 - 10:45)
                // =========================
                new HoraDiaHorario { ID = 59, HORARIO_ID = 19, HORA_DIA_ID = 18 }, // Lunes 19:45 - 21:15
                new HoraDiaHorario { ID = 60, HORARIO_ID = 19, HORA_DIA_ID = 63 }, // Miércoles 19:45 - 21:15
                new HoraDiaHorario { ID = 61, HORARIO_ID = 19, HORA_DIA_ID = 103 },  // Viernes 19:45 - 21:15
                new HoraDiaHorario { ID = 62, HORARIO_ID = 19, HORA_DIA_ID = 109 },  // Sábado 09:15 - 10:45

                //==============================================================================================

                // =========================
                // HORARIO 20: Lunes - Miércoles - Viernes (13:45 - 15:15) - Viernes (16:45 - 18:15)
                // =========================
                new HoraDiaHorario { ID = 63, HORARIO_ID = 20, HORA_DIA_ID = 9 }, // Lunes 13:45 - 15:15
                new HoraDiaHorario { ID = 64, HORARIO_ID = 20, HORA_DIA_ID = 54 }, // Miércoles 13:45 - 15:15
                new HoraDiaHorario { ID = 65, HORARIO_ID = 20, HORA_DIA_ID = 95 },  // Viernes 13:45 - 15:15
                new HoraDiaHorario { ID = 66, HORARIO_ID = 20, HORA_DIA_ID = 98 },  // Viernes 16:45 - 18:15

                // =========================
                // HORARIO 21: Lunes - Miércoles - Viernes (15:15 - 16:45) - Viernes (21:15 - 22:45)
                // =========================
                new HoraDiaHorario { ID = 67, HORARIO_ID = 21, HORA_DIA_ID = 11 }, // Lunes 15:15 - 16:45
                new HoraDiaHorario { ID = 68, HORARIO_ID = 21, HORA_DIA_ID = 57 }, // Miércoles 15:15 - 16:45
                new HoraDiaHorario { ID = 69, HORARIO_ID = 21, HORA_DIA_ID = 96 },  // Viernes 15:15 - 16:45
                new HoraDiaHorario { ID = 70, HORARIO_ID = 21, HORA_DIA_ID = 105 },  // Viernes 21:15 - 22:45

                // =========================
                // HORARIO 22: Lunes - Miércoles - Viernes (16:45 - 18:15) - Viernes (18:15 - 19:45)
                // =========================
                new HoraDiaHorario { ID = 71, HORARIO_ID = 22, HORA_DIA_ID = 14 }, // Lunes 16:45 - 18:15
                new HoraDiaHorario { ID = 72, HORARIO_ID = 22, HORA_DIA_ID = 59 }, // Miércoles 16:45 - 18:15
                new HoraDiaHorario { ID = 73, HORARIO_ID = 22, HORA_DIA_ID = 98 },  // Viernes 16:45 - 18:15
                new HoraDiaHorario { ID = 74, HORARIO_ID = 22, HORA_DIA_ID = 100 },  // Viernes 18:15 - 19:45

                //==============================================================================================

                // =========================
                // HORARIO 23: Lunes - Miércoles (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { ID = 75, HORARIO_ID = 23, HORA_DIA_ID = 2 }, // Lunes 07:00-09:15
                new HoraDiaHorario { ID = 76, HORARIO_ID = 23, HORA_DIA_ID = 46 }, // Miércoles 07:00-09:15

                // =========================
                // HORARIO 24: Lunes - Miércoles (09:15 - 11:30)
                // =========================
                new HoraDiaHorario { ID = 77, HORARIO_ID = 24, HORA_DIA_ID = 4 }, // Lunes 09:15-11:30
                new HoraDiaHorario { ID = 78, HORARIO_ID = 24, HORA_DIA_ID = 49 }, // Miércoles 09:15-11:30

                // =========================
                // HORARIO 25: Lunes - Miércoles (13:45 - 16:00)
                // =========================
                new HoraDiaHorario { ID = 79, HORARIO_ID = 25, HORA_DIA_ID = 10 }, // Lunes 13:45-16:00
                new HoraDiaHorario { ID = 80, HORARIO_ID = 25, HORA_DIA_ID = 55 }, // Miércoles 13:45-16:00

                // =========================
                // HORARIO 26: Lunes - Miércoles (16:00 - 18:15)
                // =========================
                new HoraDiaHorario { ID = 81, HORARIO_ID = 26, HORA_DIA_ID = 12 }, // Lunes 16:00-18:15
                new HoraDiaHorario { ID = 82, HORARIO_ID = 26, HORA_DIA_ID = 58 }, // Miércoles 16:00-18:15

                // =========================
                // HORARIO 27: Lunes - Miércoles (19:00 - 20:30)
                // =========================
                new HoraDiaHorario { ID = 83, HORARIO_ID = 27, HORA_DIA_ID = 16 }, // Lunes 19:00-20:30
                new HoraDiaHorario { ID = 84, HORARIO_ID = 27, HORA_DIA_ID = 62 }, // Miércoles 19:00-20:30

                // =========================
                // HORARIO 28: Lunes - Miércoles (19:45 - 22:00)
                // =========================
                new HoraDiaHorario { ID = 85, HORARIO_ID = 28, HORA_DIA_ID = 17 }, // Lunes 19:45-22:00
                new HoraDiaHorario { ID = 86, HORARIO_ID = 28, HORA_DIA_ID = 116 }, // Miércoles 19:45-22:00

                //==============================================================================================

                // =========================
                // HORARIO 29: Lunes - Miércoles (07:00 - 09:15) - Miercoles (14:30-16:00)
                // =========================
                new HoraDiaHorario { ID = 87, HORARIO_ID = 29, HORA_DIA_ID = 2 }, // Lunes 07:00-09:15
                new HoraDiaHorario { ID = 88, HORARIO_ID = 29, HORA_DIA_ID = 46 }, // Miércoles 07:00-09:15
                new HoraDiaHorario { ID = 89, HORARIO_ID = 29, HORA_DIA_ID = 56 }, // Miércoles 14:30-16:00

                //==============================================================================================

                // =========================
                // HORARIO 30: Lunes - Jueves (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { ID = 90, HORARIO_ID = 30, HORA_DIA_ID = 2 }, // Lunes 07:00-09:15
                new HoraDiaHorario { ID = 91, HORARIO_ID = 30, HORA_DIA_ID = 67 }, // Jueves 07:00-09:15

                //==============================================================================================

                // =========================
                // HORARIO 31: Lunes - Jueves (13:45 - 16:00) - Viernes (15:15 - 16:45)
                // =========================
                new HoraDiaHorario { ID = 92, HORARIO_ID = 31, HORA_DIA_ID = 10 }, // Lunes 13:45-16:00
                new HoraDiaHorario { ID = 93, HORARIO_ID = 31, HORA_DIA_ID = 72 }, // Jueves 13:45-16:00
                new HoraDiaHorario { ID = 94, HORARIO_ID = 31, HORA_DIA_ID = 96 }, // Viernes 15:15-16:45

                //==============================================================================================

                // =========================
                // HORARIO 32: Lunes - Viernes (07:00 - 09:15) - Martes (07:00 - 08:30)
                // =========================
                new HoraDiaHorario { ID = 95, HORARIO_ID = 32, HORA_DIA_ID = 2 }, // Lunes 07:00-09:15
                new HoraDiaHorario { ID = 96, HORARIO_ID = 32, HORA_DIA_ID = 86 }, // Viernes 07:00-09:15
                new HoraDiaHorario { ID = 97, HORARIO_ID = 32, HORA_DIA_ID = 21 }, // Martes 07:00-08:30

                //==============================================================================================

                // =========================
                // HORARIO 33: Lunes (12:15 - 13:45) - Martes - Jueves (16:00 - 18:15)
                // =========================
                new HoraDiaHorario { ID = 98, HORARIO_ID = 33, HORA_DIA_ID = 7 }, // Lunes 12:15-13:45
                new HoraDiaHorario { ID = 99, HORARIO_ID = 33, HORA_DIA_ID = 36 }, // Martes 16:00-18:15
                new HoraDiaHorario { ID = 100, HORARIO_ID = 33, HORA_DIA_ID = 76 }, // Jueves 16:00-18:15

                // =========================
                // HORARIO 34: Lunes (13:00 - 14:30) - Martes - Jueves (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { ID = 101, HORARIO_ID = 34, HORA_DIA_ID = 8 }, // Lunes 13:00-14:30
                new HoraDiaHorario { ID = 102, HORARIO_ID = 34, HORA_DIA_ID = 22 }, // Martes 07:00-09:15
                new HoraDiaHorario { ID = 103, HORARIO_ID = 34, HORA_DIA_ID = 67 }, // Jueves 07:00-09:15

                //==============================================================================================

                // =========================
                // HORARIO 35: Lunes (16:00 - 18:15) - Martes (07:00 - 08:30) - Viernes (13:45 - 16:00)
                // =========================
                new HoraDiaHorario { ID = 104, HORARIO_ID = 35, HORA_DIA_ID = 12 }, // Lunes 16:00-18:15
                new HoraDiaHorario { ID = 105, HORARIO_ID = 35, HORA_DIA_ID = 21 }, // Martes 07:00-08:30
                new HoraDiaHorario { ID = 106, HORARIO_ID = 35, HORA_DIA_ID = 94 }, // Viernes 13:45-16:00

                //==============================================================================================

                // =========================
                // HORARIO 36:  Martes (09:15 - 12:15)
                // =========================
                new HoraDiaHorario { ID = 107, HORARIO_ID = 36, HORA_DIA_ID = 24 }, // Martes 09:15 - 12:15


                //==============================================================================================

                // =========================
                // HORARIO 37:  Martes - Jueves (07:00 - 09:15) - Martes (12:15 - 13:45)
                // =========================
                new HoraDiaHorario { ID = 108, HORARIO_ID = 37, HORA_DIA_ID = 22 }, // Martes 07:00 - 09:15
                new HoraDiaHorario { ID = 109, HORARIO_ID = 37, HORA_DIA_ID = 67 }, // Jueves 07:00 - 09:15
                new HoraDiaHorario { ID = 110, HORARIO_ID = 37, HORA_DIA_ID = 28 }, // Martes 12:15 - 13:45

                // =========================
                // HORARIO 38:  Martes - Jueves (07:00 - 09:15) - Martes (11:30 - 13:00)
                // =========================
                new HoraDiaHorario { ID = 111, HORARIO_ID = 38, HORA_DIA_ID = 22 }, // Martes 07:00 - 09:15
                new HoraDiaHorario { ID = 112, HORARIO_ID = 38, HORA_DIA_ID = 67 }, // Jueves 07:00 - 09:15
                new HoraDiaHorario { ID = 113, HORARIO_ID = 38, HORA_DIA_ID = 26 }, // Martes 11:30 - 13:00

                // =========================
                // HORARIO 39:  Martes - Jueves (18:15 - 20:30) - Martes (16:45 - 18:15)
                // =========================
                new HoraDiaHorario { ID = 114, HORARIO_ID = 39, HORA_DIA_ID = 40 }, // Martes 18:15 - 20:30
                new HoraDiaHorario { ID = 115, HORARIO_ID = 39, HORA_DIA_ID = 79 }, // Jueves 18:15 - 20:30
                new HoraDiaHorario { ID = 116, HORARIO_ID = 39, HORA_DIA_ID = 37 }, // Martes 16:45 - 18:15

                //==============================================================================================

                // =========================
                // HORARIO 40:  Martes - Jueves (18:15 - 20:30) - Miercoles (20:30 - 22:00)
                // =========================
                new HoraDiaHorario { ID = 117, HORARIO_ID = 40, HORA_DIA_ID = 40 }, // Martes 18:15 - 20:30
                new HoraDiaHorario { ID = 118, HORARIO_ID = 40, HORA_DIA_ID = 79 }, // Jueves 18:15 - 20:30
                new HoraDiaHorario { ID = 119, HORARIO_ID = 40, HORA_DIA_ID = 64 }, // Miercoles 20:30 - 22:00

                //==============================================================================================

                // =========================
                // HORARIO 41:  Martes - Jueves (07:00 - 09:15) - Viernes (10:00 - 11:30)
                // =========================
                new HoraDiaHorario { ID = 120, HORARIO_ID = 41, HORA_DIA_ID = 22 }, // Martes 07:00 - 09:15
                new HoraDiaHorario { ID = 121, HORARIO_ID = 41, HORA_DIA_ID = 67 }, // Jueves 07:00 - 09:15
                new HoraDiaHorario { ID = 122, HORARIO_ID = 41, HORA_DIA_ID = 89 }, // Viernes 10:00-11:30

                // =========================
                // HORARIO 42:  Martes - Jueves (07:00 - 09:15) - Viernes (18:15 - 19:45)
                // =========================
                new HoraDiaHorario { ID = 123, HORARIO_ID = 42, HORA_DIA_ID = 22 }, // Martes 07:00 - 09:15
                new HoraDiaHorario { ID = 124, HORARIO_ID = 42, HORA_DIA_ID = 67 }, // Jueves 07:00 - 09:15
                new HoraDiaHorario { ID = 125, HORARIO_ID = 42, HORA_DIA_ID = 100 }, // Viernes 18:15 - 19:45

                // =========================
                // HORARIO 43:  Martes - Jueves (13:45 - 16:00) - Viernes (15:15 - 16:45)
                // =========================
                new HoraDiaHorario { ID = 126, HORARIO_ID = 43, HORA_DIA_ID = 32 }, // Martes 13:45 - 16:00
                new HoraDiaHorario { ID = 127, HORARIO_ID = 43, HORA_DIA_ID = 72 }, // Jueves 13:45 - 16:00
                new HoraDiaHorario { ID = 128, HORARIO_ID = 43, HORA_DIA_ID = 96 }, // Viernes 15:15 - 16:45

                // =========================
                // HORARIO 44:  Martes - Jueves (16:00 - 18:15) - Viernes (16:00 - 17:30)
                // =========================
                new HoraDiaHorario { ID = 129, HORARIO_ID = 44, HORA_DIA_ID = 36 }, // Martes 16:00 - 18:15
                new HoraDiaHorario { ID = 130, HORARIO_ID = 44, HORA_DIA_ID = 76 }, // Jueves 16:00 - 18:15
                new HoraDiaHorario { ID = 131, HORARIO_ID = 44, HORA_DIA_ID = 97 }, // Viernes 16:00 - 17:30

                //==============================================================================================

                // =========================
                // HORARIO 45:  Martes (13:45 - 15:15) - Miercoles (16:00 - 18:15) - Viernes (13:45 - 16:00)
                // =========================
                new HoraDiaHorario { ID = 132, HORARIO_ID = 45, HORA_DIA_ID = 31 }, // Martes 13:45 - 15:15
                new HoraDiaHorario { ID = 133, HORARIO_ID = 45, HORA_DIA_ID = 58 }, // Miercoles 16:00 - 18:15
                new HoraDiaHorario { ID = 134, HORARIO_ID = 45, HORA_DIA_ID = 94 }, // Viernes 13:45 - 16:00


                //==============================================================================================

                // =========================
                // HORARIO 46:  Lunes - Martes - Miercoles (15:15 - 16:45) - Martes (16:45 - 18:15)
                // =========================
                new HoraDiaHorario { ID = 135, HORARIO_ID = 46, HORA_DIA_ID = 11 }, // Lunes 15:15 - 16:45
                new HoraDiaHorario { ID = 136, HORARIO_ID = 46, HORA_DIA_ID = 33 }, // Martes 15:15 - 16:45
                new HoraDiaHorario { ID = 137, HORARIO_ID = 46, HORA_DIA_ID = 57 }, // Miercoles 15:15 - 16:45
                new HoraDiaHorario { ID = 138, HORARIO_ID = 46, HORA_DIA_ID = 37 }, // Martes 16:45-18:15


                //==============================================================================================

                // =========================
                // HORARIO 47: Miércoles (09:15 - 11:30) - Viernes (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { ID = 139, HORARIO_ID = 47, HORA_DIA_ID = 49 }, // Miércoles 09:15-11:30
                new HoraDiaHorario { ID = 140, HORARIO_ID = 47, HORA_DIA_ID = 86 }, // Viernes 07:00-09:15

                // =========================
                // HORARIO 48: Miércoles (11:30 - 13:45) - Viernes (10:00 - 12:15)
                // =========================
                new HoraDiaHorario { ID = 141, HORARIO_ID = 48, HORA_DIA_ID = 52 }, // Miércoles 11:30-13:45
                new HoraDiaHorario { ID = 142, HORARIO_ID = 48, HORA_DIA_ID = 90 }, // Viernes 10:00-12:15

                //==============================================================================================

                // =========================
                // HORARIO 49: Miércoles (10:00 - 11:30) - Viernes (15:15 - 16:45) - Sabado (15:15 - 16:45)
                // =========================
                new HoraDiaHorario { ID = 143, HORARIO_ID = 49, HORA_DIA_ID = 50 }, // Miércoles 10:00 - 11:30
                new HoraDiaHorario { ID = 144, HORARIO_ID = 49, HORA_DIA_ID = 96 }, // Viernes 15:15 - 16:45
                new HoraDiaHorario { ID = 145, HORARIO_ID = 49, HORA_DIA_ID = 111 }, // Sábado 15:15 - 16:45

                //==============================================================================================

                // =========================
                // HORARIO 50: Miércoles - Viernes (10:45 - 13:00)
                // =========================
                new HoraDiaHorario { ID = 146, HORARIO_ID = 50, HORA_DIA_ID = 114 }, // Miércoles 10:45-13:00
                new HoraDiaHorario { ID = 147, HORARIO_ID = 50, HORA_DIA_ID = 115 }, // Viernes 10:45-13:00

                // =========================
                // HORARIO 51: Miércoles (20:30 - 22:00) - Viernes (18:15 - 21:15)
                // =========================
                new HoraDiaHorario { ID = 148, HORARIO_ID = 51, HORA_DIA_ID = 64 }, // Miércoles 20:30-22:00
                new HoraDiaHorario { ID = 149, HORARIO_ID = 51, HORA_DIA_ID = 99 }, // Viernes 18:15-21:15

                //==============================================================================================

                // =========================
                // HORARIO 52: Miércoles (13:45 - 16:00) - Sabado(10:00-12:15)
                // =========================
                new HoraDiaHorario { ID = 150, HORARIO_ID = 52, HORA_DIA_ID = 55 }, // Miércoles 13:45-16:00
                new HoraDiaHorario { ID = 151, HORARIO_ID = 52, HORA_DIA_ID = 110 }, // Sábado 10:00-12:15

                //==============================================================================================

                // =========================
                // HORARIO 53: Miércoles (08:30 - 10:00) - Jueves (07:00 - 09:15) - Viernes (09:15 - 11:30)
                // =========================
                new HoraDiaHorario { ID = 152, HORARIO_ID = 53, HORA_DIA_ID = 48 }, // Miércoles 08:30-10:00
                new HoraDiaHorario { ID = 153, HORARIO_ID = 53, HORA_DIA_ID = 67 }, // Jueves 07:00-09:15
                new HoraDiaHorario { ID = 154, HORARIO_ID = 53, HORA_DIA_ID = 88 }, // Viernes 09:15-11:30

                //==============================================================================================

                // =========================
                // HORARIO 54: Jueves (11:30 - 13:45) - Viernes (11:30 - 13:45)
                // =========================
                new HoraDiaHorario { ID = 155, HORARIO_ID = 54, HORA_DIA_ID = 70 }, // Jueves 11:30-13:45
                new HoraDiaHorario { ID = 156, HORARIO_ID = 54, HORA_DIA_ID = 92 }, // Viernes 11:30-13:45


                //==============================================================================================
                // =========================
                // HORARIO 55: Martes - Viernes (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { ID = 157, HORARIO_ID = 55, HORA_DIA_ID = 22 }, // Martes 07:00-09:15
                new HoraDiaHorario { ID = 158, HORARIO_ID = 55, HORA_DIA_ID = 86 }, // Viernes 07:00-09:15

                // =========================
                // HORARIO 56: Martes (13:00 - 16:00) - Viernes (13:45 - 15:15)
                // =========================
                new HoraDiaHorario { ID = 159, HORARIO_ID = 56, HORA_DIA_ID = 29 }, // Martes 13:00-16:00
                new HoraDiaHorario { ID = 160, HORARIO_ID = 56, HORA_DIA_ID = 95 }, // Viernes 13:45-15:15

                //==============================================================================================

                
                // =========================
                // HORARIO 57: Martes - Jueves - Sabado (07:00 - 08:30)
                // =========================
                new HoraDiaHorario { ID = 161, HORARIO_ID = 57, HORA_DIA_ID = 21 }, // Martes 07:00-08:30
                new HoraDiaHorario { ID = 162, HORARIO_ID = 57, HORA_DIA_ID = 66 }, // Jueves 07:00-08:30
                new HoraDiaHorario { ID = 163, HORARIO_ID = 57, HORA_DIA_ID = 106 }, // Sábado 07:00-08:30


                //==============================================================================================

                // =========================
                // HORARIO 58: Martes - Jueves (07:00 - 09:15)
                // =========================
                new HoraDiaHorario { ID = 164, HORARIO_ID = 58, HORA_DIA_ID = 22 }, // Martes 07:00-09:15
                new HoraDiaHorario { ID = 165, HORARIO_ID = 58, HORA_DIA_ID = 86 }, // Jueves 07:00-09:15

                // =========================
                // HORARIO 59: Martes - Jueves (07:00 - 08:30)
                // =========================
                new HoraDiaHorario { ID = 166, HORARIO_ID = 59, HORA_DIA_ID = 21 }, // Martes 07:00-08:30
                new HoraDiaHorario { ID = 167, HORARIO_ID = 59, HORA_DIA_ID = 66 }, // Jueves 07:00-08:30

                // =========================
                // HORARIO 60: Martes - Jueves (09:15 - 11:30)
                // =========================
                new HoraDiaHorario { ID = 168, HORARIO_ID = 60, HORA_DIA_ID = 23 }, // Martes 09:15-11:30
                new HoraDiaHorario { ID = 169, HORARIO_ID = 60, HORA_DIA_ID = 68 }, // Jueves 09:15-11:30

                // =========================
                // HORARIO 61: Martes - Jueves (11:30 - 13:45)
                // =========================
                new HoraDiaHorario { ID = 170, HORARIO_ID = 61, HORA_DIA_ID = 27 }, // Martes 11:30-13:45
                new HoraDiaHorario { ID = 171, HORARIO_ID = 61, HORA_DIA_ID = 70 }, // Jueves 11:30-13:45

                // =========================
                // HORARIO 72: Martes - Jueves (13:00 - 15:15)
                // =========================
                new HoraDiaHorario { ID = 172, HORARIO_ID = 72, HORA_DIA_ID = 31 }, // Martes 13:00-15:15
                new HoraDiaHorario { ID = 173, HORARIO_ID = 72, HORA_DIA_ID = 71 }, // Jueves 13:00-15:15

                // =========================
                // HORARIO 73: Martes - Jueves (13:45 - 16:00)
                // =========================
                new HoraDiaHorario { ID = 174, HORARIO_ID = 73, HORA_DIA_ID = 32 }, // Martes 13:45-16:00
                new HoraDiaHorario { ID = 175, HORARIO_ID = 73, HORA_DIA_ID = 72 }, // Jueves 13:45-16:00

                // =========================
                // HORARIO 74: Martes - Jueves (15:15 - 16:45)
                // =========================
                new HoraDiaHorario { ID = 176, HORARIO_ID = 74, HORA_DIA_ID = 33 }, // Martes 15:15-16:45
                new HoraDiaHorario { ID = 177, HORARIO_ID = 74, HORA_DIA_ID = 74 }, // Jueves 15:15-16:45

                // =========================
                // HORARIO 75: Martes - Jueves (15:15 - 17:30)
                // =========================
                new HoraDiaHorario { ID = 178, HORARIO_ID = 75, HORA_DIA_ID = 34 }, // Martes 15:15-17:30
                new HoraDiaHorario { ID = 179, HORARIO_ID = 75, HORA_DIA_ID = 73 }, // Jueves 15:15-17:30

                // =========================
                // HORARIO 76: Martes - Jueves (16:00 - 18:15)
                // =========================
                new HoraDiaHorario { ID = 180, HORARIO_ID = 76, HORA_DIA_ID = 36 }, // Martes 16:00-18:15
                new HoraDiaHorario { ID = 181, HORARIO_ID = 76, HORA_DIA_ID = 76 }, // Jueves 16:00-18:15

                // =========================
                // HORARIO 77: Martes - Jueves (16:00 - 17:30)
                // =========================
                new HoraDiaHorario { ID = 182, HORARIO_ID = 77, HORA_DIA_ID = 35 }, // Martes 16:00-17:30
                new HoraDiaHorario { ID = 183, HORARIO_ID = 77, HORA_DIA_ID = 75 }, // Jueves 16:00-17:30

                // =========================
                // HORARIO 78: Martes - Jueves (17:30 - 19:00)
                // =========================
                new HoraDiaHorario { ID = 184, HORARIO_ID = 78, HORA_DIA_ID = 38 }, // Martes 17:30-19:00
                new HoraDiaHorario { ID = 185, HORARIO_ID = 78, HORA_DIA_ID = 77 }, // Jueves 17:30-19:00

                // =========================
                // HORARIO 79: Martes - Jueves (18:15 - 20:30)
                // =========================
                new HoraDiaHorario { ID = 186, HORARIO_ID = 79, HORA_DIA_ID = 40 }, // Martes 18:15-20:30
                new HoraDiaHorario { ID = 187, HORARIO_ID = 79, HORA_DIA_ID = 79 }, // Jueves 18:15-20:30

                // =========================
                // HORARIO 80: Martes - Jueves (18:15 - 19:45)
                // =========================
                new HoraDiaHorario { ID = 188, HORARIO_ID = 80, HORA_DIA_ID = 39 }, // Martes 18:15-19:45
                new HoraDiaHorario { ID = 189, HORARIO_ID = 80, HORA_DIA_ID = 78 }, // Jueves 18:15-19:45

                // =========================
                // HORARIO 81: Martes - Jueves (19:00 - 20:30)
                // =========================
                new HoraDiaHorario { ID = 190, HORARIO_ID = 81, HORA_DIA_ID = 41 }, // Martes 19:00-20:30
                new HoraDiaHorario { ID = 191, HORARIO_ID = 81, HORA_DIA_ID = 80 }, // Jueves 19:00-20:30

                // =========================
                // HORARIO 82: Martes - Jueves (19:00 - 21:15)
                // =========================
                new HoraDiaHorario { ID = 192, HORARIO_ID = 82, HORA_DIA_ID = 42 }, // Martes 19:00-21:15
                new HoraDiaHorario { ID = 193, HORARIO_ID = 82, HORA_DIA_ID = 81 }, // Jueves 19:00-21:15

                // =========================
                // HORARIO 83: Martes - Jueves (20:30 - 22:00)
                // =========================
                new HoraDiaHorario { ID = 194, HORARIO_ID = 83, HORA_DIA_ID = 43 }, // Martes 20:30-22:00
                new HoraDiaHorario { ID = 195, HORARIO_ID = 83, HORA_DIA_ID = 82 }, // Jueves 20:30-22:00

                // =========================
                // HORARIO 84: Martes - Jueves (20:30 - 22:45)
                // =========================
                new HoraDiaHorario { ID = 196, HORARIO_ID = 84, HORA_DIA_ID = 44 }, // Martes 20:30-22:45
                new HoraDiaHorario { ID = 197, HORARIO_ID = 84, HORA_DIA_ID = 83 }, // Jueves 20:30-22:45

                // =========================
                // HORARIO 85: Martes - Jueves (21:15 - 22:45)
                // =========================
                new HoraDiaHorario { ID = 198, HORARIO_ID = 85, HORA_DIA_ID = 45 }, // Martes 21:15-22:45
                new HoraDiaHorario { ID = 199, HORARIO_ID = 85, HORA_DIA_ID = 84 }, // Jueves 21:15-22:45


                //==============================================================================================

                // =========================
                // HORARIO 86: Sabado (08:00 - 11:30)
                // =========================
                new HoraDiaHorario { ID = 200, HORARIO_ID = 86, HORA_DIA_ID = 108 } // Sabado 08:00-11:30


            );
    }
}
