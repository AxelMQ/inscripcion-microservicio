using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class DocenteSeeder : IEntityTypeConfiguration<Docente>
{
    public void Configure(EntityTypeBuilder<Docente> builder)
    {
        builder.HasData(
            new Docente { Id = 1, Nombre = "ABARCA SOTA NANCY", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 2, Nombre = "ACOSTA CABEZAS BARTOLO JAVIER", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 3, Nombre = "AGUILAR MARTINEZ DOMINGO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 4, Nombre = "ARANIBAR QUIROZ M. MONICA", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 5, Nombre = "ALPIRE RIVERO GERMAN", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 6, Nombre = "ARGOTE CLAROS IRMA ISABEL", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 7, Nombre = "AVENDAÑO GONZALES EUDAL", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 8, Nombre = "BARROSO VIRUEZ GINO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 9, Nombre = "BALCAZAR VEIZAGA EVANS", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 10, Nombre = "CALISAYA AJHUACHO MAGNO EDWIN", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 11, Nombre = "CABALLERO RUA MAURICIO CHRISTIAN", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 12, Nombre = "CABELLO MERIDA JUAN RUBEN", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 13, Nombre = "CACERES CHACON BRAULIO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 14, Nombre = "CANO CESPEDES JORGE", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 15, Nombre = "CASTRO MARISCAL JHONNY", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 16, Nombre = "CALIZAYA AJHUACHO MAGNO EDWIN", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 17, Nombre = "CALDERON FLORES MODESTO FRANKLIN", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 18, Nombre = "CALLE TERRAZAS EDWIN", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 19, Nombre = "CARVAJAL CORDERO MARCIO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 20, Nombre = "CARRENO PEREIRA ANDRES", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 21, Nombre = "CAMPOS BARRERA MARIO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 22, Nombre = "CAYOJA LUCANA VICTOR MILTON", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 23, Nombre = "CLAURE MEDRANO DE OROPEZA ELIZ", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 24, Nombre = "CHANIN AVICHACRA JUAN MANUEL", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 25, Nombre = "CHAU WONG JORGE", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 26, Nombre = "CORTEZ UZEDA JULIO MARTIN", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 27, Nombre = "CONTRERAS VILLEGAS JUAN CARLOS", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 28, Nombre = "DURAN CESPEDES BERTHY RONALD", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 29, Nombre = "FLORES FLORES MARCOS OSCAR", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 30, Nombre = "FLORES GUZMAN VALENTIN VICTOR", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 31, Nombre = "FLORES CUELLAD DAVID LUIS", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 32, Nombre = "GARZON CUELLAR ANGELICA", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 33, Nombre = "GUTIERREZ BRUNO KATIME ESTHER", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 34, Nombre = "GIANELLA PEREDO EDUARDO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 35, Nombre = "GUARACHI SOLANO JONATHAN FELIX", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 36, Nombre = "GUTHRIE PACHECO JHONNY DAVID", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 37, Nombre = "GRAGEDA ESCUDERO MARIO WILSON", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 38, Nombre = "GRIMALDO BRAVO PAUL", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 39, Nombre = "GONZALES SANDOVAL JORGE ANTONIO", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 40, Nombre = "HINOJOSA SAAVEDRA JOSE SAID", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 41, Nombre = "JUSTINIANO ROCA RONALD", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 42, Nombre = "LAMAS RODRIGUEZ MARCOS", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 43, Nombre = "LAZO ARTEAGA CARLOS ALBERTO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 44, Nombre = "LOPEZ WINNIPEG MARIO MILTON", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 45, Nombre = "LOPEZ NEGRETTY MARY DUNNIA", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 46, Nombre = "LOBO LIMPIAS VICTOR HUGO", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 47, Nombre = "MARTINEZ CARDONA SARAH MIRNA", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 48, Nombre = "MARTINEZ CANEDO ROLANDO ANTONI", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 49, Nombre = "MIRANDA CARRASCO CARLOS", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 50, Nombre = "MORALES MENDEZ MAGALY", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 51, Nombre = "MOLLO MAMANI ALBERTO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 52, Nombre = "MONRROY DIPP VICTOR FERNANDO", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 53, Nombre = "OROPEZA CLAURE GUSTAVO ADOLFO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 54, Nombre = "OROSCO GOMEZ RUBEN", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 55, Nombre = "ORTIZ ARTEAGA VICTOR HUGO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 56, Nombre = "OQUENDO HEREDIA FREDDY MIGUEL", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 57, Nombre = "PAZ MENDOZA ROBERTO CARLOS", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 58, Nombre = "PINTO VARGAS EDUARDO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 59, Nombre = "PEINADO PEREIRA JUAN CARLOS", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 60, Nombre = "PEINADO PEREIRA MIGUEL JESUS", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 61, Nombre = "PEREZ FERREIRA UBALDO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 62, Nombre = "PEREZ DELGADILLO SHIRLEY EULAL", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 63, Nombre = "ROMAN ROCA RUFINO WILBERTO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 64, Nombre = "ROSALES FUENTES JORGE MARCELO", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 65, Nombre = "SANCHEZ VELASCO ENRIQUE", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 66, Nombre = "SANCHEZ RIOJA EDWIN ALEJANDRO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 67, Nombre = "SALVATIERRA MERCADO ROLANDO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 68, Nombre = "SELAYA GARVIZU IVAN VLADISHLAV", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 69, Nombre = "SILES MUÑOZ FELIX", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 70, Nombre = "TEJERINA GUERRA JULIO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 71, Nombre = "TERRAZAS SOTO RICARDO", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 72, Nombre = "VACA PINTO CESPEDES ROBERTO CARLOS", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 73, Nombre = "VALDELOMAR ORELLANA TOMAS", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 74, Nombre = "VARGAS CASTILLO CIRO EDGAR", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 75, Nombre = "VARGAS PEÑA LEONARDO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 76, Nombre = "VARGAS YAPURA EDWIN", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 77, Nombre = "VALLET VALLET CORRADO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 78, Nombre = "VEIZAGA GONZALES JOSUE OBED", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 79, Nombre = "VELASCO GUAMAN ANGEL", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 80, Nombre = "VILLAGOMEZ MELGAR JOSE JUNIOR", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 81, Nombre = "ZEBALLOS PAREDES DANIEL LUIS", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 82, Nombre = "ZUNA VILLAGOMEZ JULIO", Telefono = 78481534, Ci = 15157507 },
            new Docente { Id = 83, Nombre = "ZUÑIGA RUIZ WILMA", Telefono = 78481534, Ci = 15157507 },

            new Docente { Id = 84, Nombre = "POR DESIGNAR", Telefono = 78481534, Ci = 15157507 }
        );
    }
}