using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class GrupoMateriaSeeder : IEntityTypeConfiguration<GrupoMateria>
{
  public void Configure(EntityTypeBuilder<GrupoMateria> builder)
  {
    builder.HasData(
        // new GrupoMateria { ID = 1, MATERIA_ID = 5, GRUPO_ID = 1 },
        // new GrupoMateria { ID = 2, MATERIA_ID = 6, GRUPO_ID = 1 },
        // new GrupoMateria { ID = 3, MATERIA_ID = 7, GRUPO_ID = 2 },
        // new GrupoMateria { ID = 4, MATERIA_ID = 8, GRUPO_ID = 2 },
        // new GrupoMateria { ID = 5, MATERIA_ID = 9, GRUPO_ID = 3 }
        
        new GrupoMateria { ID = 1, MATERIA_ID = 15, GRUPO_ID = 1 }, // ADMINISTRACION - SA
        new GrupoMateria { ID = 2, MATERIA_ID = 15, GRUPO_ID = 2 }, // ADMINISTRACION - SB
        new GrupoMateria { ID = 3, MATERIA_ID = 15, GRUPO_ID = 3 }, // ADMINISTRACION - SC

        // ALGEBRA LINEAL
        new GrupoMateria { ID = 4, MATERIA_ID = 7, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 5, MATERIA_ID = 7, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 6, MATERIA_ID = 7, GRUPO_ID = 3 }, // SC
        new GrupoMateria { ID = 7, MATERIA_ID = 7, GRUPO_ID = 4 }, // SD
        new GrupoMateria { ID = 8, MATERIA_ID = 7, GRUPO_ID = 5 }, // SE
        new GrupoMateria { ID = 9, MATERIA_ID = 7, GRUPO_ID = 6 }, // SF
        
        // ANALISIS DE CIRCUITO
        new GrupoMateria { ID = 10, MATERIA_ID = 75, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 11, MATERIA_ID = 75, GRUPO_ID = 2 }, // SB

        // ANALISIS DE CIRCUITO ELECTRONICO
        new GrupoMateria { ID = 12, MATERIA_ID = 77, GRUPO_ID = 17 }, // SZ

        // APLICACIONES CON MICROPROCESADORES
        new GrupoMateria { ID = 13, MATERIA_ID = 87, GRUPO_ID = 1 }, // SA

        // ARQUITECTURA DE COMPUTADORAS
        new GrupoMateria { ID = 14, MATERIA_ID = 13, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 15, MATERIA_ID = 13, GRUPO_ID = 2 }, // SB
        
        // ARQUITECTURA DE SOFTWARE
        new GrupoMateria { ID = 16, MATERIA_ID = 43, GRUPO_ID = 1 }, // SA

        // AUDITORIA INFORMATICA
        new GrupoMateria { ID = 17, MATERIA_ID = 57, GRUPO_ID = 1 }, // SA
        
        // BASE DE DATOS I
        new GrupoMateria { ID = 18, MATERIA_ID = 24, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 19, MATERIA_ID = 24, GRUPO_ID = 3 }, // SC

        // BASE DE DATOS II
        new GrupoMateria { ID = 20, MATERIA_ID = 29, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 21, MATERIA_ID = 29, GRUPO_ID = 4 }, // SD
        
        // CALCULO I
        new GrupoMateria { ID = 22, MATERIA_ID = 1, GRUPO_ID = 18 }, // F1
        new GrupoMateria { ID = 23, MATERIA_ID = 1, GRUPO_ID = 17 }, // SZ
        new GrupoMateria { ID = 24, MATERIA_ID = 1, GRUPO_ID = 20 }, // CI
        new GrupoMateria { ID = 25, MATERIA_ID = 1, GRUPO_ID = 22 }, // I2
        new GrupoMateria { ID = 26, MATERIA_ID = 1, GRUPO_ID = 6 }, // SF
        new GrupoMateria { ID = 27, MATERIA_ID = 1, GRUPO_ID = 7 }, // SG
        new GrupoMateria { ID = 28, MATERIA_ID = 1, GRUPO_ID = 9 }, // SI
        new GrupoMateria { ID = 29, MATERIA_ID = 1, GRUPO_ID = 13 }, // SP
        new GrupoMateria { ID = 30, MATERIA_ID = 1, GRUPO_ID = 33 }, // Z1
        new GrupoMateria { ID = 31, MATERIA_ID = 1, GRUPO_ID = 34 }, // Z2
        new GrupoMateria { ID = 32, MATERIA_ID = 1, GRUPO_ID = 35 }, // Z3
        new GrupoMateria { ID = 33, MATERIA_ID = 1, GRUPO_ID = 36 }, // Z4
        new GrupoMateria { ID = 34, MATERIA_ID = 1, GRUPO_ID = 37 }, // Z5
        new GrupoMateria { ID = 35, MATERIA_ID = 1, GRUPO_ID = 38 }, // Z6

        // CALCULO II
        new GrupoMateria { ID = 36, MATERIA_ID = 6, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 37, MATERIA_ID = 6, GRUPO_ID = 4 }, // SD
        new GrupoMateria { ID = 38, MATERIA_ID = 6, GRUPO_ID = 24 }, // R1
        new GrupoMateria { ID = 39, MATERIA_ID = 6, GRUPO_ID = 25 }, // 1I
        new GrupoMateria { ID = 40, MATERIA_ID = 6, GRUPO_ID = 21 }, // C1
        new GrupoMateria { ID = 41, MATERIA_ID = 6, GRUPO_ID = 8 }, // SH
        new GrupoMateria { ID = 42, MATERIA_ID = 6, GRUPO_ID = 11 }, // SN

        // COMPILADORES
        new GrupoMateria { ID = 43, MATERIA_ID = 30, GRUPO_ID = 1 }, // SA

        // CONTABILIDAD
        new GrupoMateria { ID = 44, MATERIA_ID = 20, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 45, MATERIA_ID = 20, GRUPO_ID = 2 }, // SB
        
        // COSTOS Y PRESUPUESTO
        new GrupoMateria { ID = 46, MATERIA_ID = 68, GRUPO_ID = 1 }, // SA

        // CRIPTOGRAFÍA Y SEGURIDAD
        new GrupoMateria { ID = 47, MATERIA_ID = 65, GRUPO_ID = 22 }, // I2
        new GrupoMateria { ID = 48, MATERIA_ID = 65, GRUPO_ID = 1 }, // SA

        // DISEÑO DE CIRCUITOS INTEGRADOS
        new GrupoMateria { ID = 49, MATERIA_ID = 81, GRUPO_ID = 1 }, // SA

        // ECONOMÍA PARA LA GESTIÓN
        new GrupoMateria { ID = 50, MATERIA_ID = 54, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 51, MATERIA_ID = 54, GRUPO_ID = 2 }, // SB

        // ECUACIONES DIFERENCIALES
        new GrupoMateria { ID = 52, MATERIA_ID = 11, GRUPO_ID = 27 }, // NW
        new GrupoMateria { ID = 53, MATERIA_ID = 11, GRUPO_ID = 28 }, // NX
        new GrupoMateria { ID = 54, MATERIA_ID = 11, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 55, MATERIA_ID = 11, GRUPO_ID = 3 }, // SC

        // ELECTRÓNICA APLICADA A REDES
        new GrupoMateria { ID = 56, MATERIA_ID = 78, GRUPO_ID = 2 }, // SB

        // ESTRUCTURA DE DATOS I
        new GrupoMateria { ID = 57, MATERIA_ID = 18, GRUPO_ID = 22 }, // I2
        new GrupoMateria { ID = 58, MATERIA_ID = 18, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 59, MATERIA_ID = 18, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 60, MATERIA_ID = 18, GRUPO_ID = 4 }, // SD
        
        // ESTRUCTURA DE DATOS II
        new GrupoMateria { ID = 61, MATERIA_ID = 23, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 62, MATERIA_ID = 23, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 63, MATERIA_ID = 23, GRUPO_ID = 16 }, // SX

        // ESTRUCTURAS DISCRETAS    
        new GrupoMateria { ID = 64, MATERIA_ID = 2, GRUPO_ID = 5 }, // SE
        new GrupoMateria { ID = 65, MATERIA_ID = 2, GRUPO_ID = 6 }, // SF
        new GrupoMateria { ID = 66, MATERIA_ID = 2, GRUPO_ID = 8 }, // SH
        new GrupoMateria { ID = 67, MATERIA_ID = 2, GRUPO_ID = 10 }, // SK
        new GrupoMateria { ID = 68, MATERIA_ID = 2, GRUPO_ID = 34 }, // Z2
        new GrupoMateria { ID = 69, MATERIA_ID = 2, GRUPO_ID = 35 }, // Z3
        new GrupoMateria { ID = 70, MATERIA_ID = 2, GRUPO_ID = 13 }, // SP
        new GrupoMateria { ID = 71, MATERIA_ID = 2, GRUPO_ID = 33 }, // Z1
        new GrupoMateria { ID = 72, MATERIA_ID = 2, GRUPO_ID = 36 }, // Z4
        new GrupoMateria { ID = 73, MATERIA_ID = 2, GRUPO_ID = 37 }, // Z5
        new GrupoMateria { ID = 74, MATERIA_ID = 2, GRUPO_ID = 38 }, // Z6

        // FINANZAS PARA LA EMPRESA
        new GrupoMateria { ID = 75, MATERIA_ID = 55, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 76, MATERIA_ID = 55, GRUPO_ID = 3 }, // SC

        // FISICA I
        new GrupoMateria { ID = 77, MATERIA_ID = 4, GRUPO_ID = 24 }, // R1
        new GrupoMateria { ID = 78, MATERIA_ID = 4, GRUPO_ID = 26 }, // I1
        new GrupoMateria { ID = 79, MATERIA_ID = 4, GRUPO_ID = 7 }, // SG
        new GrupoMateria { ID = 80, MATERIA_ID = 4, GRUPO_ID = 9 }, // SI
        new GrupoMateria { ID = 81, MATERIA_ID = 4, GRUPO_ID = 10 }, // SK
        new GrupoMateria { ID = 82, MATERIA_ID = 4, GRUPO_ID = 12 }, // SM
        new GrupoMateria { ID = 83, MATERIA_ID = 4, GRUPO_ID = 13 }, // SP
        new GrupoMateria { ID = 84, MATERIA_ID = 4, GRUPO_ID = 33 }, // Z1
        new GrupoMateria { ID = 85, MATERIA_ID = 4, GRUPO_ID = 34 }, // Z2
        new GrupoMateria { ID = 86, MATERIA_ID = 4, GRUPO_ID = 35 }, // Z3
        new GrupoMateria { ID = 87, MATERIA_ID = 4, GRUPO_ID = 36 }, // Z4
        new GrupoMateria { ID = 88, MATERIA_ID = 4, GRUPO_ID = 37 }, // Z5
        new GrupoMateria { ID = 89, MATERIA_ID = 4, GRUPO_ID = 38 }, // Z6

        // FISICA II
        new GrupoMateria { ID = 90, MATERIA_ID = 9, GRUPO_ID = 19 }, // BI
        new GrupoMateria { ID = 91, MATERIA_ID = 9, GRUPO_ID = 24 }, // R1
        new GrupoMateria { ID = 92, MATERIA_ID = 9, GRUPO_ID = 27 }, // NW
        new GrupoMateria { ID = 93, MATERIA_ID = 9, GRUPO_ID = 28 }, // NX
        new GrupoMateria { ID = 94, MATERIA_ID = 9, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 95, MATERIA_ID = 9, GRUPO_ID = 2 }, // SB

        // FISICA III
        new GrupoMateria { ID = 96, MATERIA_ID = 14, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 97, MATERIA_ID = 14, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 98, MATERIA_ID = 14, GRUPO_ID = 3 }, // SC
        new GrupoMateria { ID = 99, MATERIA_ID = 14, GRUPO_ID = 34 }, // X2
        new GrupoMateria { ID = 100, MATERIA_ID = 14, GRUPO_ID = 35 }, // X3
        new GrupoMateria { ID = 101, MATERIA_ID = 14, GRUPO_ID = 36 }, // X4

        // GESTIÓN Y ADMINISTRACIÓN DE REDES   
        new GrupoMateria { ID = 102, MATERIA_ID = 96, GRUPO_ID = 1 }, // SA

        // INGENIERÍA DE LA CALIDAD  
        new GrupoMateria { ID = 103, MATERIA_ID = 71, GRUPO_ID = 1 }, // SA

        // INGENIERÍA DE SOFTWARE I
        new GrupoMateria { ID = 104, MATERIA_ID = 35, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 105, MATERIA_ID = 35, GRUPO_ID = 3 }, // SC

        // INGENIERÍA DE SOFTWARE II
        new GrupoMateria { ID = 106, MATERIA_ID = 40, GRUPO_ID = 2 }, // SB

        // INGLÉS TÉCNICO I
        new GrupoMateria { ID = 107, MATERIA_ID = 5, GRUPO_ID = 27 }, // NW
        new GrupoMateria { ID = 108, MATERIA_ID = 5, GRUPO_ID = 28 }, // NX
        new GrupoMateria { ID = 109, MATERIA_ID = 5, GRUPO_ID = 33 }, // Z1
        new GrupoMateria { ID = 110, MATERIA_ID = 5, GRUPO_ID = 34 }, // Z2
        new GrupoMateria { ID = 111, MATERIA_ID = 5, GRUPO_ID = 35 }, // Z3
        new GrupoMateria { ID = 112, MATERIA_ID = 5, GRUPO_ID = 36 }, // Z4
        new GrupoMateria { ID = 113, MATERIA_ID = 5, GRUPO_ID = 38 }, // Z6


        // PROBABILIDAD Y ESTADÍSTICA I
        new GrupoMateria { ID = 114, MATERIA_ID = 16, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 115, MATERIA_ID = 16, GRUPO_ID = 3 }, // SC
        new GrupoMateria { ID = 116, MATERIA_ID = 16, GRUPO_ID = 4 }, // SD
        new GrupoMateria { ID = 117, MATERIA_ID = 16, GRUPO_ID = 9 }, // SI

        // PROBABILIDAD Y ESTADÍSTICA II
        new GrupoMateria { ID = 118, MATERIA_ID = 21, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 119, MATERIA_ID = 21, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 120, MATERIA_ID = 21, GRUPO_ID = 9 }, // SI

        // PRODUCCIÓN Y MARKETING
        new GrupoMateria { ID = 121, MATERIA_ID = 69, GRUPO_ID = 1 }, // SA

        // PROGRAMACIÓN LÓGICA Y FUNCIONAL
        new GrupoMateria { ID = 122, MATERIA_ID = 22, GRUPO_ID = 1 }, // SA

        // PROGRAMACIÓN ENSAMBLADOR
        new GrupoMateria { ID = 123, MATERIA_ID = 19, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 124, MATERIA_ID = 19, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 125, MATERIA_ID = 19, GRUPO_ID = 3 }, // SC
        new GrupoMateria { ID = 126, MATERIA_ID = 19, GRUPO_ID = 16 }, // SX
        
        // PROGRAMACIÓN GRÁFICA
        new GrupoMateria { ID = 127, MATERIA_ID = 60, GRUPO_ID = 1 }, // SA

        // PROGRAMACIÓN I
        new GrupoMateria { ID = 128, MATERIA_ID = 8, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 129, MATERIA_ID = 8, GRUPO_ID = 3 }, // SC
        new GrupoMateria { ID = 130, MATERIA_ID = 8, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 131, MATERIA_ID = 8, GRUPO_ID = 7 }, // SG
        new GrupoMateria { ID = 132, MATERIA_ID = 8, GRUPO_ID = 4 }, // SD
        new GrupoMateria { ID = 133, MATERIA_ID = 8, GRUPO_ID = 6 }, // SF
        new GrupoMateria { ID = 134, MATERIA_ID = 8, GRUPO_ID = 8 }, // SH
        new GrupoMateria { ID = 135, MATERIA_ID = 8, GRUPO_ID = 9 }, // SI

        // PROGRAMACIÓN II
        new GrupoMateria { ID = 136, MATERIA_ID = 12, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 137, MATERIA_ID = 12, GRUPO_ID = 4 }, // SD
        new GrupoMateria { ID = 138, MATERIA_ID = 12, GRUPO_ID = 3 }, // SC
        new GrupoMateria { ID = 139, MATERIA_ID = 12, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 140, MATERIA_ID = 12, GRUPO_ID = 9 }, // SI

        // REDES ADHOC
        new GrupoMateria { ID = 141, MATERIA_ID = 95, GRUPO_ID = 1 }, // SA

        // REDES I
        new GrupoMateria { ID = 142, MATERIA_ID = 34, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 143, MATERIA_ID = 34, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 144, MATERIA_ID = 34, GRUPO_ID = 3 }, // SC

        // REDES II
        new GrupoMateria { ID = 145, MATERIA_ID = 39, GRUPO_ID = 24 }, // R1
        new GrupoMateria { ID = 146, MATERIA_ID = 39, GRUPO_ID = 2 }, // SB
        new GrupoMateria { ID = 147, MATERIA_ID = 39, GRUPO_ID = 3 }, // SC
        
        // REDES INALÁMBRICAS Y COMUNICACIONES MÓVILES
        new GrupoMateria { ID = 148, MATERIA_ID = 97, GRUPO_ID = 1 }, // SA

        // SEGURIDAD EN REDES Y TRANSMISIÓN DE DATOS
        new GrupoMateria { ID = 149, MATERIA_ID = 98, GRUPO_ID = 1 }, // SA

        // SEÑALES Y SISTEMAS
        new GrupoMateria { ID = 150, MATERIA_ID = 80, GRUPO_ID = 24 }, // R1
        
        // SISTEMAS DE COMUNICACIÓN I
        new GrupoMateria { ID = 151, MATERIA_ID = 88, GRUPO_ID = 14 }, // SR

        // SISTEMAS DE COMUNICACIÓN II
        new GrupoMateria { ID = 152, MATERIA_ID = 93, GRUPO_ID = 14 }, // SR

        // SISTEMAS DE COMUNICACIÓN SCADA
        new GrupoMateria { ID = 153, MATERIA_ID = 85, GRUPO_ID = 24 }, // R1

        // SISTEMAS DE INFORMACIÓN GEOGRÁFICA
        new GrupoMateria { ID = 154, MATERIA_ID = 44, GRUPO_ID = 9 }, // SI
        new GrupoMateria { ID = 155, MATERIA_ID = 44, GRUPO_ID = 1 }, // SA

        // SISTEMAS DE INFORMACIÓN I
        new GrupoMateria { ID = 156, MATERIA_ID = 27, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 157, MATERIA_ID = 27, GRUPO_ID = 3 }, // SC

        // SISTEMAS DE INFORMACIÓN II
        new GrupoMateria { ID = 158, MATERIA_ID = 38, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 159, MATERIA_ID = 38, GRUPO_ID = 2 }, // SB

        // SISTEMAS EXPERTOS
        new GrupoMateria { ID = 160, MATERIA_ID = 37, GRUPO_ID = 2 }, // SB

        // SISTEMAS LÓGICOS Y DIGITALES I
        new GrupoMateria { ID = 161, MATERIA_ID = 79, GRUPO_ID = 23 }, // ER

        // SISTEMAS LÓGICOS Y DIGITALES II
        new GrupoMateria { ID = 162, MATERIA_ID = 83, GRUPO_ID = 24 }, // R1
        
        // SISTEMAS OPERATIVOS I
        new GrupoMateria { ID = 163, MATERIA_ID = 28, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 164, MATERIA_ID = 28, GRUPO_ID = 3 }, // SC

        // SISTEMAS OPERATIVOS II
        new GrupoMateria { ID = 165, MATERIA_ID = 33, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 166, MATERIA_ID = 33, GRUPO_ID = 2 }, // SB
        
        // SISTEMAS PARA EL SOPORTE A LA TOMA DE DECISIONES
        new GrupoMateria { ID = 167, MATERIA_ID = 56, GRUPO_ID = 1 }, // SA
        
        // TALLER DE ANÁLISIS Y DISEÑO DE REDES
        new GrupoMateria { ID = 168, MATERIA_ID = 91, GRUPO_ID = 1 }, // SA
        
        // TALLER DE GRADO I
        new GrupoMateria { ID = 169, MATERIA_ID = 41, GRUPO_ID = 15 }, // SS
        new GrupoMateria { ID = 170, MATERIA_ID = 41, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 171, MATERIA_ID = 41, GRUPO_ID = 3 }, // SC

        // TECNOLOGIA WEB
        new GrupoMateria { ID = 172, MATERIA_ID = 42, GRUPO_ID = 1 }, // SA
        new GrupoMateria { ID = 173, MATERIA_ID = 42, GRUPO_ID = 3 }, // SC
        
        // TELEVISIÓN DIGITAL
        new GrupoMateria { ID = 174, MATERIA_ID = 86, GRUPO_ID = 14 }, // SR

        // TEORIA DE CAMPOS
        new GrupoMateria { ID = 175, MATERIA_ID = 76, GRUPO_ID = 3 }, // SC

        // TÓPICOS AVANZADOS DE PROGRAMACIÓN
        new GrupoMateria { ID = 176, MATERIA_ID = 61, GRUPO_ID = 1 } // SA


    );
  }
}
