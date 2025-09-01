using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class GrupoMateriaSeeder : IEntityTypeConfiguration<GrupoMateria>
{
  public void Configure(EntityTypeBuilder<GrupoMateria> builder)
  {
    builder.HasData(
        // new GrupoMateria { Id = 1, MateriaId = 5, GrupoId = 1 },
        // new GrupoMateria { Id = 2, MateriaId = 6, GrupoId = 1 },
        // new GrupoMateria { Id = 3, MateriaId = 7, GrupoId = 2 },
        // new GrupoMateria { Id = 4, MateriaId = 8, GrupoId = 2 },
        // new GrupoMateria { Id = 5, MateriaId = 9, GrupoId = 3 }
        
        new GrupoMateria { Id = 1, MateriaId = 15, GrupoId = 1 }, // ADMINISTRACION - SA
        new GrupoMateria { Id = 2, MateriaId = 15, GrupoId = 2 }, // ADMINISTRACION - SB
        new GrupoMateria { Id = 3, MateriaId = 15, GrupoId = 3 }, // ADMINISTRACION - SC

        // ALGEBRA LINEAL
        new GrupoMateria { Id = 4, MateriaId = 7, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 5, MateriaId = 7, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 6, MateriaId = 7, GrupoId = 3 }, // SC
        new GrupoMateria { Id = 7, MateriaId = 7, GrupoId = 4 }, // SD
        new GrupoMateria { Id = 8, MateriaId = 7, GrupoId = 5 }, // SE
        new GrupoMateria { Id = 9, MateriaId = 7, GrupoId = 6 }, // SF
        
        // ANALISIS DE CIRCUITO
        new GrupoMateria { Id = 10, MateriaId = 75, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 11, MateriaId = 75, GrupoId = 2 }, // SB

        // ANALISIS DE CIRCUITO ELECTRONICO
        new GrupoMateria { Id = 12, MateriaId = 77, GrupoId = 17 }, // SZ

        // APLICACIONES CON MICROPROCESADORES
        new GrupoMateria { Id = 13, MateriaId = 87, GrupoId = 1 }, // SA

        // ARQUITECTURA DE COMPUTADORAS
        new GrupoMateria { Id = 14, MateriaId = 13, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 15, MateriaId = 13, GrupoId = 2 }, // SB
        
        // ARQUITECTURA DE SOFTWARE
        new GrupoMateria { Id = 16, MateriaId = 43, GrupoId = 1 }, // SA

        // AUDITORIA INFORMATICA
        new GrupoMateria { Id = 17, MateriaId = 57, GrupoId = 1 }, // SA
        
        // BASE DE DATOS I
        new GrupoMateria { Id = 18, MateriaId = 24, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 19, MateriaId = 24, GrupoId = 3 }, // SC

        // BASE DE DATOS II
        new GrupoMateria { Id = 20, MateriaId = 29, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 21, MateriaId = 29, GrupoId = 4 }, // SD
        
        // CALCULO I
        new GrupoMateria { Id = 22, MateriaId = 1, GrupoId = 18 }, // F1
        new GrupoMateria { Id = 23, MateriaId = 1, GrupoId = 17 }, // SZ
        new GrupoMateria { Id = 24, MateriaId = 1, GrupoId = 20 }, // CI
        new GrupoMateria { Id = 25, MateriaId = 1, GrupoId = 22 }, // I2
        new GrupoMateria { Id = 26, MateriaId = 1, GrupoId = 6 }, // SF
        new GrupoMateria { Id = 27, MateriaId = 1, GrupoId = 7 }, // SG
        new GrupoMateria { Id = 28, MateriaId = 1, GrupoId = 9 }, // SI
        new GrupoMateria { Id = 29, MateriaId = 1, GrupoId = 13 }, // SP
        new GrupoMateria { Id = 30, MateriaId = 1, GrupoId = 33 }, // Z1
        new GrupoMateria { Id = 31, MateriaId = 1, GrupoId = 34 }, // Z2
        new GrupoMateria { Id = 32, MateriaId = 1, GrupoId = 35 }, // Z3
        new GrupoMateria { Id = 33, MateriaId = 1, GrupoId = 36 }, // Z4
        new GrupoMateria { Id = 34, MateriaId = 1, GrupoId = 37 }, // Z5
        new GrupoMateria { Id = 35, MateriaId = 1, GrupoId = 38 }, // Z6

        // CALCULO II
        new GrupoMateria { Id = 36, MateriaId = 6, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 37, MateriaId = 6, GrupoId = 4 }, // SD
        new GrupoMateria { Id = 38, MateriaId = 6, GrupoId = 24 }, // R1
        new GrupoMateria { Id = 39, MateriaId = 6, GrupoId = 25 }, // 1I
        new GrupoMateria { Id = 40, MateriaId = 6, GrupoId = 21 }, // C1
        new GrupoMateria { Id = 41, MateriaId = 6, GrupoId = 8 }, // SH
        new GrupoMateria { Id = 42, MateriaId = 6, GrupoId = 11 }, // SN

        // COMPILADORES
        new GrupoMateria { Id = 43, MateriaId = 30, GrupoId = 1 }, // SA

        // CONTABILIDAD
        new GrupoMateria { Id = 44, MateriaId = 20, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 45, MateriaId = 20, GrupoId = 2 }, // SB
        
        // COSTOS Y PRESUPUESTO
        new GrupoMateria { Id = 46, MateriaId = 68, GrupoId = 1 }, // SA

        // CRIPTOGRAFÍA Y SEGURIDAD
        new GrupoMateria { Id = 47, MateriaId = 65, GrupoId = 22 }, // I2
        new GrupoMateria { Id = 48, MateriaId = 65, GrupoId = 1 }, // SA

        // DISEÑO DE CIRCUITOS INTEGRADOS
        new GrupoMateria { Id = 49, MateriaId = 81, GrupoId = 1 }, // SA

        // ECONOMÍA PARA LA GESTIÓN
        new GrupoMateria { Id = 50, MateriaId = 54, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 51, MateriaId = 54, GrupoId = 2 }, // SB

        // ECUACIONES DIFERENCIALES
        new GrupoMateria { Id = 52, MateriaId = 11, GrupoId = 27 }, // NW
        new GrupoMateria { Id = 53, MateriaId = 11, GrupoId = 28 }, // NX
        new GrupoMateria { Id = 54, MateriaId = 11, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 55, MateriaId = 11, GrupoId = 3 }, // SC

        // ELECTRÓNICA APLICADA A REDES
        new GrupoMateria { Id = 56, MateriaId = 78, GrupoId = 2 }, // SB

        // ESTRUCTURA DE DATOS I
        new GrupoMateria { Id = 57, MateriaId = 18, GrupoId = 22 }, // I2
        new GrupoMateria { Id = 58, MateriaId = 18, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 59, MateriaId = 18, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 60, MateriaId = 18, GrupoId = 4 }, // SD
        
        // ESTRUCTURA DE DATOS II
        new GrupoMateria { Id = 61, MateriaId = 23, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 62, MateriaId = 23, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 63, MateriaId = 23, GrupoId = 16 }, // SX

        // ESTRUCTURAS DISCRETAS    
        new GrupoMateria { Id = 64, MateriaId = 2, GrupoId = 5 }, // SE
        new GrupoMateria { Id = 65, MateriaId = 2, GrupoId = 6 }, // SF
        new GrupoMateria { Id = 66, MateriaId = 2, GrupoId = 8 }, // SH
        new GrupoMateria { Id = 67, MateriaId = 2, GrupoId = 10 }, // SK
        new GrupoMateria { Id = 68, MateriaId = 2, GrupoId = 34 }, // Z2
        new GrupoMateria { Id = 69, MateriaId = 2, GrupoId = 35 }, // Z3
        new GrupoMateria { Id = 70, MateriaId = 2, GrupoId = 13 }, // SP
        new GrupoMateria { Id = 71, MateriaId = 2, GrupoId = 33 }, // Z1
        new GrupoMateria { Id = 72, MateriaId = 2, GrupoId = 36 }, // Z4
        new GrupoMateria { Id = 73, MateriaId = 2, GrupoId = 37 }, // Z5
        new GrupoMateria { Id = 74, MateriaId = 2, GrupoId = 38 }, // Z6

        // FINANZAS PARA LA EMPRESA
        new GrupoMateria { Id = 75, MateriaId = 55, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 76, MateriaId = 55, GrupoId = 3 }, // SC

        // FISICA I
        new GrupoMateria { Id = 77, MateriaId = 4, GrupoId = 24 }, // R1
        new GrupoMateria { Id = 78, MateriaId = 4, GrupoId = 26 }, // I1
        new GrupoMateria { Id = 79, MateriaId = 4, GrupoId = 7 }, // SG
        new GrupoMateria { Id = 80, MateriaId = 4, GrupoId = 9 }, // SI
        new GrupoMateria { Id = 81, MateriaId = 4, GrupoId = 10 }, // SK
        new GrupoMateria { Id = 82, MateriaId = 4, GrupoId = 12 }, // SM
        new GrupoMateria { Id = 83, MateriaId = 4, GrupoId = 13 }, // SP
        new GrupoMateria { Id = 84, MateriaId = 4, GrupoId = 33 }, // Z1
        new GrupoMateria { Id = 85, MateriaId = 4, GrupoId = 34 }, // Z2
        new GrupoMateria { Id = 86, MateriaId = 4, GrupoId = 35 }, // Z3
        new GrupoMateria { Id = 87, MateriaId = 4, GrupoId = 36 }, // Z4
        new GrupoMateria { Id = 88, MateriaId = 4, GrupoId = 37 }, // Z5
        new GrupoMateria { Id = 89, MateriaId = 4, GrupoId = 38 }, // Z6

        // FISICA II
        new GrupoMateria { Id = 90, MateriaId = 9, GrupoId = 19 }, // BI
        new GrupoMateria { Id = 91, MateriaId = 9, GrupoId = 24 }, // R1
        new GrupoMateria { Id = 92, MateriaId = 9, GrupoId = 27 }, // NW
        new GrupoMateria { Id = 93, MateriaId = 9, GrupoId = 28 }, // NX
        new GrupoMateria { Id = 94, MateriaId = 9, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 95, MateriaId = 9, GrupoId = 2 }, // SB

        // FISICA III
        new GrupoMateria { Id = 96, MateriaId = 14, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 97, MateriaId = 14, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 98, MateriaId = 14, GrupoId = 3 }, // SC
        new GrupoMateria { Id = 99, MateriaId = 14, GrupoId = 34 }, // X2
        new GrupoMateria { Id = 100, MateriaId = 14, GrupoId = 35 }, // X3
        new GrupoMateria { Id = 101, MateriaId = 14, GrupoId = 36 }, // X4

        // GESTIÓN Y ADMINISTRACIÓN DE REDES   
        new GrupoMateria { Id = 102, MateriaId = 96, GrupoId = 1 }, // SA

        // INGENIERÍA DE LA CALIDAD  
        new GrupoMateria { Id = 103, MateriaId = 71, GrupoId = 1 }, // SA

        // INGENIERÍA DE SOFTWARE I
        new GrupoMateria { Id = 104, MateriaId = 35, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 105, MateriaId = 35, GrupoId = 3 }, // SC

        // INGENIERÍA DE SOFTWARE II
        new GrupoMateria { Id = 106, MateriaId = 40, GrupoId = 2 }, // SB

        // INGLÉS TÉCNICO I
        new GrupoMateria { Id = 107, MateriaId = 5, GrupoId = 27 }, // NW
        new GrupoMateria { Id = 108, MateriaId = 5, GrupoId = 28 }, // NX
        new GrupoMateria { Id = 109, MateriaId = 5, GrupoId = 33 }, // Z1
        new GrupoMateria { Id = 110, MateriaId = 5, GrupoId = 34 }, // Z2
        new GrupoMateria { Id = 111, MateriaId = 5, GrupoId = 35 }, // Z3
        new GrupoMateria { Id = 112, MateriaId = 5, GrupoId = 36 }, // Z4
        new GrupoMateria { Id = 113, MateriaId = 5, GrupoId = 38 }, // Z6


        // PROBABILIDAD Y ESTADÍSTICA I
        new GrupoMateria { Id = 114, MateriaId = 16, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 115, MateriaId = 16, GrupoId = 3 }, // SC
        new GrupoMateria { Id = 116, MateriaId = 16, GrupoId = 4 }, // SD
        new GrupoMateria { Id = 117, MateriaId = 16, GrupoId = 9 }, // SI

        // PROBABILIDAD Y ESTADÍSTICA II
        new GrupoMateria { Id = 118, MateriaId = 21, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 119, MateriaId = 21, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 120, MateriaId = 21, GrupoId = 9 }, // SI

        // PRODUCCIÓN Y MARKETING
        new GrupoMateria { Id = 121, MateriaId = 69, GrupoId = 1 }, // SA

        // PROGRAMACIÓN LÓGICA Y FUNCIONAL
        new GrupoMateria { Id = 122, MateriaId = 22, GrupoId = 1 }, // SA

        // PROGRAMACIÓN ENSAMBLADOR
        new GrupoMateria { Id = 123, MateriaId = 19, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 124, MateriaId = 19, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 125, MateriaId = 19, GrupoId = 3 }, // SC
        new GrupoMateria { Id = 126, MateriaId = 19, GrupoId = 16 }, // SX
        
        // PROGRAMACIÓN GRÁFICA
        new GrupoMateria { Id = 127, MateriaId = 60, GrupoId = 1 }, // SA

        // PROGRAMACIÓN I
        new GrupoMateria { Id = 128, MateriaId = 8, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 129, MateriaId = 8, GrupoId = 3 }, // SC
        new GrupoMateria { Id = 130, MateriaId = 8, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 131, MateriaId = 8, GrupoId = 7 }, // SG
        new GrupoMateria { Id = 132, MateriaId = 8, GrupoId = 4 }, // SD
        new GrupoMateria { Id = 133, MateriaId = 8, GrupoId = 6 }, // SF
        new GrupoMateria { Id = 134, MateriaId = 8, GrupoId = 8 }, // SH
        new GrupoMateria { Id = 135, MateriaId = 8, GrupoId = 9 }, // SI

        // PROGRAMACIÓN II
        new GrupoMateria { Id = 136, MateriaId = 12, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 137, MateriaId = 12, GrupoId = 4 }, // SD
        new GrupoMateria { Id = 138, MateriaId = 12, GrupoId = 3 }, // SC
        new GrupoMateria { Id = 139, MateriaId = 12, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 140, MateriaId = 12, GrupoId = 9 }, // SI

        // REDES ADHOC
        new GrupoMateria { Id = 141, MateriaId = 95, GrupoId = 1 }, // SA

        // REDES I
        new GrupoMateria { Id = 142, MateriaId = 34, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 143, MateriaId = 34, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 144, MateriaId = 34, GrupoId = 3 }, // SC

        // REDES II
        new GrupoMateria { Id = 145, MateriaId = 39, GrupoId = 24 }, // R1
        new GrupoMateria { Id = 146, MateriaId = 39, GrupoId = 2 }, // SB
        new GrupoMateria { Id = 147, MateriaId = 39, GrupoId = 3 }, // SC
        
        // REDES INALÁMBRICAS Y COMUNICACIONES MÓVILES
        new GrupoMateria { Id = 148, MateriaId = 97, GrupoId = 1 }, // SA

        // SEGURIDAD EN REDES Y TRANSMISIÓN DE DATOS
        new GrupoMateria { Id = 149, MateriaId = 98, GrupoId = 1 }, // SA

        // SEÑALES Y SISTEMAS
        new GrupoMateria { Id = 150, MateriaId = 80, GrupoId = 24 }, // R1
        
        // SISTEMAS DE COMUNICACIÓN I
        new GrupoMateria { Id = 151, MateriaId = 88, GrupoId = 14 }, // SR

        // SISTEMAS DE COMUNICACIÓN II
        new GrupoMateria { Id = 152, MateriaId = 93, GrupoId = 14 }, // SR

        // SISTEMAS DE COMUNICACIÓN SCADA
        new GrupoMateria { Id = 153, MateriaId = 85, GrupoId = 24 }, // R1

        // SISTEMAS DE INFORMACIÓN GEOGRÁFICA
        new GrupoMateria { Id = 154, MateriaId = 44, GrupoId = 9 }, // SI
        new GrupoMateria { Id = 155, MateriaId = 44, GrupoId = 1 }, // SA

        // SISTEMAS DE INFORMACIÓN I
        new GrupoMateria { Id = 156, MateriaId = 27, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 157, MateriaId = 27, GrupoId = 3 }, // SC

        // SISTEMAS DE INFORMACIÓN II
        new GrupoMateria { Id = 158, MateriaId = 38, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 159, MateriaId = 38, GrupoId = 2 }, // SB

        // SISTEMAS EXPERTOS
        new GrupoMateria { Id = 160, MateriaId = 37, GrupoId = 2 }, // SB

        // SISTEMAS LÓGICOS Y DIGITALES I
        new GrupoMateria { Id = 161, MateriaId = 79, GrupoId = 23 }, // ER

        // SISTEMAS LÓGICOS Y DIGITALES II
        new GrupoMateria { Id = 162, MateriaId = 83, GrupoId = 24 }, // R1
        
        // SISTEMAS OPERATIVOS I
        new GrupoMateria { Id = 163, MateriaId = 28, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 164, MateriaId = 28, GrupoId = 3 }, // SC

        // SISTEMAS OPERATIVOS II
        new GrupoMateria { Id = 165, MateriaId = 33, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 166, MateriaId = 33, GrupoId = 2 }, // SB
        
        // SISTEMAS PARA EL SOPORTE A LA TOMA DE DECISIONES
        new GrupoMateria { Id = 167, MateriaId = 56, GrupoId = 1 }, // SA
        
        // TALLER DE ANÁLISIS Y DISEÑO DE REDES
        new GrupoMateria { Id = 168, MateriaId = 91, GrupoId = 1 }, // SA
        
        // TALLER DE GRADO I
        new GrupoMateria { Id = 169, MateriaId = 41, GrupoId = 15 }, // SS
        new GrupoMateria { Id = 170, MateriaId = 41, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 171, MateriaId = 41, GrupoId = 3 }, // SC

        // TECNOLOGIA WEB
        new GrupoMateria { Id = 172, MateriaId = 42, GrupoId = 1 }, // SA
        new GrupoMateria { Id = 173, MateriaId = 42, GrupoId = 3 }, // SC
        
        // TELEVISIÓN DIGITAL
        new GrupoMateria { Id = 174, MateriaId = 86, GrupoId = 14 }, // SR

        // TEORIA DE CAMPOS
        new GrupoMateria { Id = 175, MateriaId = 76, GrupoId = 3 }, // SC

        // TÓPICOS AVANZADOS DE PROGRAMACIÓN
        new GrupoMateria { Id = 176, MateriaId = 61, GrupoId = 1 } // SA


    );
  }
}
