using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class DocenteSeeder : IEntityTypeConfiguration<Docente>
{
    public void Configure(EntityTypeBuilder<Docente> builder)
    {
        builder.HasData(
            new Docente { Id = 1, Nombre = "FLORES GUZMAN VALENTIN VICTOR", Telefono = 78481515, Ci = 15157488 },
            new Docente { Id = 2, Nombre = "LOBO LIMPIAS VICTOR HUGO", Telefono = 78481516, Ci = 15157489 },
            new Docente { Id = 3, Nombre = "ARANIBAR QUIROZ MARTHA MONICA", Telefono = 78481517, Ci = 15157490 },
            new Docente { Id = 4, Nombre = "SANCHEZ VELASCO ENRIQUE", Telefono = 78481518, Ci = 15157491 },
            new Docente { Id = 5, Nombre = "CALDERON FLORES MODESTO FRANKLIN", Telefono = 78481519, Ci = 15157492 },
            new Docente { Id = 6, Nombre = "LAZO ARTEAGA CARLOS ROBERTO", Telefono = 78481520, Ci = 15157493 },
            new Docente { Id = 7, Nombre = "ZUNA VILLAGOMEZ RICARDO", Telefono = 78481521, Ci = 15157494 },
            new Docente { Id = 8, Nombre = "MOLLO MAMANI ALBERTO", Telefono = 78481522, Ci = 15157495 },
            new Docente { Id = 9, Nombre = "ALIAGA HOWARD SHARON KENNY", Telefono = 78481523, Ci = 15157496 },
            new Docente { Id = 10, Nombre = "CONTRERAS VILLEGAS JUAN CARLOS", Telefono = 78481524, Ci = 15157497 },
            new Docente { Id = 11, Nombre = "MARTINEZ CARDONA SARAH MIRNA", Telefono = 78481525, Ci = 15157498 },
            new Docente { Id = 12, Nombre = "CACERES CHACON BRAULIO", Telefono = 78481526, Ci = 15157499 },
            new Docente { Id = 13, Nombre = "GUTIERREZ BRUNO KATIME ESTHER", Telefono = 78481527, Ci = 15157500 },
            new Docente { Id = 14, Nombre = "APAZA LEON ROSNAY", Telefono = 78481528, Ci = 15157501 },
            new Docente { Id = 15, Nombre = "ZUNIGA RUIZ WILMA", Telefono = 78481529, Ci = 15157502 },
            new Docente { Id = 16, Nombre = "CLAURE MEDRANO DE OROPEZA ELIZ", Telefono = 78481530, Ci = 15157503 },
            new Docente { Id = 17, Nombre = "AVENDANO GONZALES EUDAL", Telefono = 78481531, Ci = 15157504 },
            new Docente { Id = 18, Nombre = "OROPEZA CLAURE GUSTAVO ADOLFO", Telefono = 78481532, Ci = 15157505 },
            new Docente { Id = 19, Nombre = "VALDELOMAR ORELLANA TOMAS", Telefono = 78481533, Ci = 15157506 },
            new Docente { Id = 20, Nombre = "ACOSTA CABEZAS BARTOLO JAVIER", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 21, Nombre = "CALDERON FLORES PIODESTO FRANKL", Telefono = 78481535, Ci = 15157508 },
            new Docente { Id = 22, Nombre = "ZEBALLOS PAREDES DANIEL LUIS", Telefono = 78481536, Ci = 15157509 },
            new Docente { Id = 23, Nombre = "MOLLO NAL4ANI ALBERTO", Telefono = 78481537, Ci = 15157510 },
            new Docente { Id = 24, Nombre = "GRIMALDO BRAVO PAUL", Telefono = 78481538, Ci = 15157511 },
            new Docente { Id = 25, Nombre = "LAZO ARTEAGA CARLOS ROBERTO", Telefono = 78481539, Ci = 15157512 },
            new Docente { Id = 26, Nombre = "GONZALES APARICIO MELISSA", Telefono = 78481540, Ci = 15157513 },
            new Docente { Id = 27, Nombre = "ORTEGA PAREDES FRANCISCO", Telefono = 78481541, Ci = 15157514 },
            new Docente { Id = 28, Nombre = "VILLARROEL RIVERA NATALIA", Telefono = 78481542, Ci = 15157515 },
            new Docente { Id = 29, Nombre = "CARRASCO CORDOVA LUIS", Telefono = 78481543, Ci = 15157516 },
            new Docente { Id = 30, Nombre = "MEDINA LOPEZ GLORIA", Telefono = 78481544, Ci = 15157517 },
            new Docente { Id = 31, Nombre = "MENDOZA CASTRO MARCO", Telefono = 78481545, Ci = 15157518 },
            new Docente { Id = 32, Nombre = "ALVAREZ ROMERO SANDRA", Telefono = 78481546, Ci = 15157519 },
            new Docente { Id = 33, Nombre = "RAMIREZ HUERTA CARLOS", Telefono = 78481547, Ci = 15157520 },
            new Docente { Id = 34, Nombre = "ESCOBAR FLORES VERONICA", Telefono = 78481548, Ci = 15157521 },
            new Docente { Id = 35, Nombre = "CASTILLO GOMEZ JUAN", Telefono = 78481549, Ci = 15157522 },
            new Docente { Id = 36, Nombre = "PEREZ SALAZAR LILIANA", Telefono = 78481550, Ci = 15157523 },
            new Docente { Id = 37, Nombre = "TORRES QUISPE RICARDO", Telefono = 78481551, Ci = 15157524 },
            new Docente { Id = 38, Nombre = "HUAMAN FLORES MIRIAM", Telefono = 78481552, Ci = 15157525 },
            new Docente { Id = 39, Nombre = "CHAVEZ LOPEZ EDWIN", Telefono = 78481553, Ci = 15157526 },
            new Docente { Id = 40, Nombre = "GARCIA VILLENA KARINA", Telefono = 78481554, Ci = 15157527 },
            new Docente { Id = 41, Nombre = "RODRIGUEZ SALAZAR LUIS", Telefono = 78481555, Ci = 15157528 },
            new Docente { Id = 42, Nombre = "FERNANDEZ CASTRO MARIA", Telefono = 78481556, Ci = 15157529 },
            new Docente { Id = 43, Nombre = "MARTINEZ HUAMAN PABLO", Telefono = 78481557, Ci = 15157530 },
            new Docente { Id = 44, Nombre = "QUISPE RAMOS GLADYS", Telefono = 78481558, Ci = 15157531 },
            new Docente { Id = 45, Nombre = "SALAZAR MORENO JULIO", Telefono = 78481559, Ci = 15157532 },
            new Docente { Id = 46, Nombre = "LOPEZ RIVERA ANGELA", Telefono = 78481560, Ci = 15157533 },
            new Docente { Id = 47, Nombre = "VILLANUEVA PEREZ CARLOS", Telefono = 78481561, Ci = 15157534 },
            new Docente { Id = 48, Nombre = "ORTEGA SALAZAR FABIOLA", Telefono = 78481562, Ci = 15157535 },
            new Docente { Id = 49, Nombre = "GOMEZ HUAMAN MARIO", Telefono = 78481563, Ci = 15157536 },
            new Docente { Id = 50, Nombre = "CARRASCO LOPEZ ELISA", Telefono = 78481564, Ci = 15157537 }


        );
    }
}

