using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class PrerequisitoSeeder : IEntityTypeConfiguration<Prerequisito>
{
    public void Configure(EntityTypeBuilder<Prerequisito> builder)
    {
        // Un contador para generar IDs negativos únicos para los datos de inicialización.
        // Esto es necesario para que Entity Framework Core pueda rastrear los registros.
        int nextId = -1;

        builder.HasData(

            // ===========================================
            // ===== INGENIERIA INFORMATICA (PLAN 1) =====
            // ===========================================
            
            // SEMESTRE 1
            // - CALCULO 1 [1]
            // - ESTRUCTURA DISCRETA [2]
            // - INTRODUCCION A LA INFORMATICA [3]
            // - FISICA I [4]
            // - INGLES TECNICO I [5]

            // SEMESTRE 2
            // - CALCULO II [6]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 6, RequisitoId = 1 }, // CALCULO 1
            // - ALGEBRA LINEAL [7]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 7, RequisitoId = 2 }, // ESTRUCTURA DISCRETA
            // - PROGRAMACION I [8]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 8, RequisitoId = 3 }, // INTRODUCCION A LA INFORMATICA
            // - FISICA II [9]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 9, RequisitoId = 4 }, // FISICA I
            // - INGLES TECNICO II [10]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 10, RequisitoId = 5 }, // INGLES TECNICO I

            // SEMESTRE 3
            // - ECUACIONES DIFERENCIALES [11]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 11, RequisitoId = 6 }, // CALCULO II
            // - PROGRAMACION II [12]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 12, RequisitoId = 7 }, // ALGEBRA LINEAL
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 12, RequisitoId = 8 }, // PROGRAMACION I
            // - ARQUITECTURA DE COMPUTADORAS [13]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 13, RequisitoId = 8 }, // PROGRAMACION I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 13, RequisitoId = 9 }, // FISICA II
            // - FISICA III [14]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 14, RequisitoId = 9 }, // FISICA II
            // - ADMINISTRACION [15]
            // new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 15, RequisitoId = - }, // ---

            // SEMESTRE 4
            // - PROBABILIDAD Y ESTADISTICA I [16]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 16, RequisitoId = 6 }, // CALCULO II
            // - METODOS NUMERICOS [17]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 17, RequisitoId = 11 }, // ECUACIONES DIFERENCIALES
            // - ESTRUCTURA DE DATOS I [18]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 18, RequisitoId = 12 }, // PROGRAMACION II
            // - PROGRAMACION ENSAMBLADOR [19]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 19, RequisitoId = 13 }, // ARQUITECTURA DE COMPUTADORAS
            // - CONTABILIDAD [20]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 20, RequisitoId = 15 }, // ADMINISTRACION

            // SEMESTRE 5
            // - PROBABILIDAD Y ESTADISTICA II [21]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 21, RequisitoId = 16 }, // PROBABILIDAD Y ESTADISTICA I
            // - PROGRAMACION LOGICA Y FUNCIONAL [22]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 22, RequisitoId = 18 }, // ESTRUCTURA DE DATOS I
            // - ESTRUCTURA DE DATOS II [23]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 23, RequisitoId = 18 }, // ESTRUCTURA DE DATOS I
            // - BASE DE DATOS I [24]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 24, RequisitoId = 18 }, // ESTRUCTURA DE DATOS I
            // - LENGUAJES FORMALES [25]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 25, RequisitoId = 18 }, // ESTRUCTURA DE DATOS I

            // SEMESTRE 6
            // - INVESTIGACION OPERATIVA I [26]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 26, RequisitoId = 21 }, // PROBABILIDAD Y ESTADISTICA I
            // - SISTEMA DE INFORMACION I [27]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 27, RequisitoId = 24 }, // BASE DE DATOS I
            // - SISTEMAS OPERATIVOS I [28]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 28, RequisitoId = 23 }, // ESTRUCTURA DE DATOS II
            // - BASE DE DATOS II [29]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 29, RequisitoId = 24 }, // BASE DE DATOS I
            // - COMPILADORES [30]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 30, RequisitoId = 25 }, // LENGUAJES FORMALES
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 30, RequisitoId = 23 }, // ESTRUCTURA DE DATOS II

            // SEMESTRE 7
            // - INVESTIGACION OPERATIVA II [31]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 31, RequisitoId = 26 }, // INVESTIGACION OPERATIVA I
            // - INTELIGENCIA ARTIFICAL [32]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 32, RequisitoId = 30 }, // PROGRAMACION LOGICA Y FUNCIONAL
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 32, RequisitoId = 23 }, // ESTRUCTURA DE DATOS II
            // - SISTEMAS OPERATIVOS II [33]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 33, RequisitoId = 28 }, // SISTEMAS OPERATIVOS I
            // - REDES I [34]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 34, RequisitoId = 28 }, // SISTEMAS OPERATIVOS I
            // - SISTEMAS DE INFORMACION II [38]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 35, RequisitoId = 27 }, // SISTEMA DE INFORMACION I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 35, RequisitoId = 29 }, // BASE DE DATOS II

            // SEMESTRE 8
            // - PREPARACION Y EVALUACION DE PROYECTOS [36]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 36, RequisitoId = 31 }, // INVESTIGACION OPERATIVA II
            // - SISTEMAS EXPERTOS [37]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 37, RequisitoId = 32 }, // INTELIGENCIA ARTIFICAL
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 37, RequisitoId = 35 }, // SISTEMAS DE INFORMACION II
            // - SISTEMAS DE INFORMACION GEOGRAFICA [44]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 38, RequisitoId = 35 }, // SISTEMA DE INFORMACION II
            // - REDES II [39]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 39, RequisitoId = 34 }, // REDES I
            // - INGENIERIA DE SOFTWARE I [35]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 40, RequisitoId = 35 }, // SISTEMAS DE INFORMACION II

            // SEMESTRE 9
            // - TALLER DE GRADO I [41]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 41, RequisitoId = 36 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 41, RequisitoId = 37 }, // SISTEMAS EXPERTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 41, RequisitoId = 38 }, // SISTEMA DE INFORMACION GEOGRAFICA
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 41, RequisitoId = 39 }, // REDES II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 41, RequisitoId = 40 }, // INGENIERIA DE SOFTWARE I
            // - INGENIERIA DE SOFTWARE II [40]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 44, RequisitoId = 36 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 44, RequisitoId = 37 }, // SISTEMAS EXPERTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 44, RequisitoId = 38 }, // SISTEMA DE INFORMACION GEOGRAFICA
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 44, RequisitoId = 39 }, // REDES II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 44, RequisitoId = 40 }, // INGENIERIA DE SOFTWARE I
            // - TECNOLOGIA WEB [42]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 42, RequisitoId = 36 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 42, RequisitoId = 37 }, // SISTEMAS EXPERTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 42, RequisitoId = 38 }, // SISTEMA DE INFORMACION GEOGRAFICA
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 42, RequisitoId = 39 }, // REDES II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 42, RequisitoId = 40 }, // INGENIERIA DE SOFTWARE I
            // - ARQUITECTURA DE SOFTWARE [43]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 43, RequisitoId = 36 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 43, RequisitoId = 37 }, // SISTEMAS EXPERTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 43, RequisitoId = 38 }, // SISTEMA DE INFORMACION GEOGRAFICA
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 43, RequisitoId = 39 }, // REDES II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 43, RequisitoId = 40 }, // INGENIERIA DE SOFTWARE I

            // SEMESTRE 10
            // - MODALIDAD DE TITULACION LICENCIATURA [58]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 45, RequisitoId = 41 }, // TALLER DE GRADO I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 45, RequisitoId = 44 }, // INGENIERIA DE SOFTWARE II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 45, RequisitoId = 42 }, // TECNOLOGIA WEB
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 45, RequisitoId = 43 }, // ARQUITECTURA DE SOFTWARE


            // ===========================================
            // ===== INGENIERÍA EN SISTEMAS (PLAN 2) =====
            // ===========================================

            // SEMESTRE 1
            // - FISICA I [4]
            // - INTRODUCCION A LA INFORMATICA [3]
            // - ESTRUCTURA DISCRETA [2]
            // - INGLES TECNICO I [5]
            // - CALCULO 1 [1]

            // SEMESTRE 2
            // - FISICA II [9]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 54, RequisitoId = 49 }, // FISICA I
            // - PROGRAMACION I [8]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 53, RequisitoId = 48 }, // INTRODUCCION A LA INFORMATICA
            // - INGLES TECNICO II [10]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 55, RequisitoId = 50 }, // INGLES TECNICO I
            // - CALCULO II [6]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 51, RequisitoId = 46 }, // CALCULO 1
            // - ALGEBRA LINEAL [7]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 52, RequisitoId = 47 }, // ESTRUCTURA DISCRETA

            // SEMESTRE 3
            // - ADMINISTRACION [15]
            // new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 60, RequisitoId = -- },
            // - PROGRAMACION II [12]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 57, RequisitoId = 53 }, // PROGRAMACION I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 57, RequisitoId = 52 }, // ALGEBRA LINEAL
            // - ARQUITECTURA DE COMPUTADORAS [13]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 58, RequisitoId = 53 }, // PROGRAMACION I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 58, RequisitoId = 54 }, // FISICA II
            // - ECUACIONES DIFERENCIALES [11]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 56, RequisitoId = 51 }, // CALCULO II
            // - FISICA III [14]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 59, RequisitoId = 54 }, // FISICA II


            // SEMESTRE 4
            // - CONTABILIDAD [20]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 65, RequisitoId = 60 }, // ADMINISTRACION
            // - ESTRUCTURA DE DATOS I [18]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 63, RequisitoId = 57 }, // PROGRAMACION II
            // - PROGRAMACION ENSAMBLADOR [19]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 64, RequisitoId = 58 }, // ARQUITECTURA DE COMPUTADORAS
            // - PROBABILIDAD Y ESTADISTICA I [16]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 61, RequisitoId = 51 }, // CALCULO II
            // - METODOS NUMERICOS [17]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 62, RequisitoId = 56 }, // ECUACIONES DIFERENCIALES

            // SEMESTRE 5
            // - ORGANIZACION Y METODOS [53]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 71, RequisitoId = 65 }, // CONTABILIDAD
            // - ECONOMIA PARA LA GESTION [54]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 72, RequisitoId = 65 }, // CONTABILIDAD
            // - ESTRUCTURA DE DATOS II [23]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 68, RequisitoId = 63 }, // ESTRUCTURA DE DATOS I
            // - BASE DE DATOS I [24]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 69, RequisitoId = 63 }, // ESTRUCTURA DE DATOS I
            // - PROBABILIDAD Y ESTADISTICA II [21]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 66, RequisitoId = 61 }, // PROBABILIDAD Y ESTADISTICA I

            // SEMESTRE 6
            // - FINANZAS PARA LA EMPRESA [55]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 78, RequisitoId = 71 }, // ORGANIZACION Y METODOS
            // - BASE DE DATOS II [29]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 76, RequisitoId = 69 }, // BASE DE DATOS I
            // - SISTEMAS OPERATIVOS I [28]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 75, RequisitoId = 68 }, // ESTRUCTURA DE DATOS II
            // - SISTEMA DE INFORMACION I [27]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 74, RequisitoId = 69 }, // BASE DE DATOS I
            // - INVESTIGACION OPERATIVA I [26]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 73, RequisitoId = 66 }, // PROBABILIDAD Y ESTADISTICA II


            // SEMESTRE 7
            // - SISTEMAS OPERATIVOS II [33]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 81, RequisitoId = 75 }, // SISTEMAS OPERATIVOS I
            // - SISTEMA PARA EL SOPORTE A LA TOMA DE DECISIONS [56]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 84, RequisitoId = 74 }, // SISTEMA DE INFORMACION I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 84, RequisitoId = 76 }, // BASE DE DATOS II
            // - INVESTIGACION OPERATIVA II [31]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 79, RequisitoId = 73 }, // INVESTIGACION OPERATIVA I
            // - REDES I [34]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 82, RequisitoId = 75 }, // SISTEMAS OPERATIVOS I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 82, RequisitoId = 76 }, // BASE DE DATOS I
            // - SISTEMAS DE INFORMACION II [38]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 83, RequisitoId = 74 }, // SISTEMA DE INFORMACION I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 83, RequisitoId = 76 }, // BASE DE DATOS II

            // SEMESTRE 8
            // - PREPARACION Y EVALUACION DE PROYECTOS [36]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 85, RequisitoId = 79 }, // INVESTIGACION OPERATIVA II
            // - INGENIERIA DE SOFTWARE I [35]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 87, RequisitoId = 83 }, // SISTEMAS DE INFORMACION II
            // - REDES II [39]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 88, RequisitoId = 82 }, // REDES I
            // - SISTEMAS DE INFORMACION GEOGRAFICA [44]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 89, RequisitoId = 83 }, // SISTEMA DE INFORMACION II
            // - AUDITORIA INFORMATICA [57]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 90, RequisitoId = 78 }, // FINANZAS PARA LA EMPRESA
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 90, RequisitoId = 83 }, // SISTEMAS DE INFORMACION II


            // SEMESTRE 9
            // - TALLER DE GRADO I [41]
            // new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 91, RequisitoId = - }, // --
            // - INGENIERIA DE SOFTWARE II [40]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 94, RequisitoId = 89 }, // SISTEMA DE INFORMACION GEOGRAFICA
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 94, RequisitoId = 88 }, // REDES II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 94, RequisitoId = 87 }, // INGENIERIA DE SOFTWARE I
            // - TECNOLOGIA WEB [42]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 92, RequisitoId = 90 }, // AUDITORIA INFORMATICA
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 92, RequisitoId = 85 }, // PREPARACION Y EVALUACION DE PROYECTOS
            // - ARQUITECTURA DE SOFTWARE [43]
            // new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 93, RequisitoId = - }, // --

            // SEMESTRE 10
            // - MODALIDAD DE TITULACION LICENCIATURA [58]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 95, RequisitoId = 91 }, // TALLER DE GRADO I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 95, RequisitoId = 94 }, // INGENIERIA DE SOFTWARE II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 95, RequisitoId = 92 }, // TECNOLOGIA WEB
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 95, RequisitoId = 93 }, // ARQUITECTURA DE SOFTWARE

            // ===========================================
            // ===== INGENIERÍA EN REDES (PLAN 3) =====
            // ===========================================

            // SEMESTRE 1
            // - CALCULO 1 [1]
            // - ESTRUCTURA DISCRETA [2]
            // - INTRODUCCION A LA INFORMATICA [3]
            // - FISICA I [4]
            // - INGLES TECNICO I [5]

            // SEMESTRE 2
            // - CALCULO II [6]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 101, RequisitoId = 96 }, // CALCULO 1
            // - ALGEBRA LINEAL [7]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 102, RequisitoId = 97 }, // ESTRUCTURA DISCRETA
            // - PROGRAMACION I [8]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 103, RequisitoId = 98 }, // INTRODUCCION A LA INFORMATICA
            // - FISICA II [9]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 104, RequisitoId = 99 }, // FISICA I
            // - INGLES TECNICO II [10]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 105, RequisitoId = 100 }, // INGLES TECNICO I

            // SEMESTRE 3
            // - ECUACIONES DIFERENCIALES [11]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 106, RequisitoId = 101 }, // CALCULO II
            // - PROGRAMACION II [12]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 107, RequisitoId = 102 }, // ALGEBRA LINEAL
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 107, RequisitoId = 103 }, // PROGRAMACION I
            // - ARQUITECTURA DE COMPUTADORAS [13]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 108, RequisitoId = 103 }, // PROGRAMACION I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 108, RequisitoId = 104 }, // FISICA II
            // - ANALISIS DE CIRCUITO [75]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 109, RequisitoId = 104 }, // FISICA II
            // - TEORIA DE CAMPOS [76]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 110, RequisitoId = 104 }, // FISICA II


            // SEMESTRE 4
            // - METODOS NUMERICOS [17]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 112, RequisitoId = 106 }, // ECUACIONES DIFERENCIALES
            // - PROBABILIDAD Y ESTADISTICA I [16]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 111, RequisitoId = 101 }, // CALCULO II
            // - ESTRUCTURA DE DATOS I [18]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 113, RequisitoId = 107 }, // PROGRAMACION II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 113, RequisitoId = 96 }, // CALCULO I
            // - PROGRAMACION ENSAMBLADOR [19]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 114, RequisitoId = 108 }, // ARQUITECTURA DE COMPUTADORAS
            // - ANALISIS CIRCUITOS ELECTRONICOS [77]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 115, RequisitoId = 109 }, // ANALISIS DE CIRCUITOS

            // SEMESTRE 5
            // - PROBABILIDAD Y ESTADISTICA II [21]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 116, RequisitoId = 111 }, // PROBABILIDAD Y ESTADISTICA I
            // - BASE DE DATOS I [24]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 117, RequisitoId = 113 }, // ESTRUCTURA DE DATOS I
            // - ELECTRONICA APLICADA A REDES [78]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 118, RequisitoId = 115 }, // ANALISIS DE CIRCUITO ELECTRONICO
            // - SISTEMAS LOGICOS Y DIGITALES I [79]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 119, RequisitoId = 115 }, // ANALISIS DE CIRCUITO ELECTRONICO
            // - SEÑALES Y SISTEMAS [80]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 120, RequisitoId = 110 }, // TEORIA DE CAMPOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 120, RequisitoId = 106 }, // ECUACIONES DIFERENCIALES

            // SEMESTRE 6
            // - SISTEMA OPERATIVO I [28]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 123, RequisitoId = 116 }, // PROBABILIDAD Y ESTADISTICA II
            // - BASE DE DATOS II [29]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 124, RequisitoId = 117 }, // BASE DE DATOS I
            // - INVESTIGACION OPERATIVA I [26]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 125, RequisitoId = 121 }, // SISTEMA OPERATIVO I
            // - SISTEMAS LOGICOS Y DIGITALES II [83]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 126, RequisitoId = 119 }, // SISTEMAS LOGICOS Y DIGITALES I
            // - INTERPRETACION DE SISTEMAS Y SEÑALES. [84]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 127, RequisitoId = 120 }, // SEÑALES Y SISTEMAS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 127, RequisitoId = 112 }, // METODOS NUMERICOS

            // SEMESTRE 7
            // - INVESTIGACION OPERATIVA II [31]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 133, RequisitoId = 125 }, // INVESTIGACION OPERATIVA I
            // - SISTEMAS OPERATIVOS II [33]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 132, RequisitoId = 123 }, // SISTEMAS OPERATIVOS I
            // - REDES I [34]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 131, RequisitoId = 123 }, // SISTEMAS OPERATIVOS I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 131, RequisitoId = 120 }, // SEÑALES Y SISTEMAS
            // - APLIC. MICROP. [87]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 134, RequisitoId = 126 }, // SIST. LOG. DIG. II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 134, RequisitoId = 114 }, // PROGRAMACION ENSAMBLADOR
            // - SISTEMAS DE COM. [88]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 135, RequisitoId = 127 }, // INT. SIS. SEÑALES
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 135, RequisitoId = 120 }, // SEÑALES Y SISTEMAS

            // SEMESTRE 8
            // - PREPARACION Y EVALUACION DE PROYECTOS [36]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 139, RequisitoId = 133 }, // INVESTIGACION OPERATIVA II
            // - TALLER ANAL. RED. [91]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 140, RequisitoId = 131 }, // REDES I
            // - REDES II [39]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 138, RequisitoId = 131 }, // REDES I
            // - LEG. REDES. COM [92]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 141, RequisitoId = 131 }, // REDES I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 141, RequisitoId = 135 }, // SISTEMA DE COMUNICACION I
            // - SISTEMAS DE COMUNICACION II [93]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 142, RequisitoId = 135 }, // SISTEMAS DE COMUNICACION I


            // SEMESTRE 9
            // - TALLER DE GRADO I [41]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 145, RequisitoId = 139 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 145, RequisitoId = 140 }, // TALLER ANAL. RED.
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 145, RequisitoId = 138 }, // REDES II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 145, RequisitoId = 141 }, // LEG. REDES. COM.
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 145, RequisitoId = 142 }, // SIS. DE COM II
            // - TECNOLOGIA WEB [42]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 146, RequisitoId = 139 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 146, RequisitoId = 140 }, // TALLER ANAL. RED.
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 146, RequisitoId = 138 }, // REDES II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 146, RequisitoId = 141 }, // LEG. REDES. COM.
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 146, RequisitoId = 142 }, // SIS. DE COM II
            // - GEST. ADM. RED. [96]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 147, RequisitoId = 139 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 147, RequisitoId = 140 }, // TALLER ANAL. RED.
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 147, RequisitoId = 138 }, // REDES II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 147, RequisitoId = 141 }, // LEG. REDES. COM.
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 147, RequisitoId = 142 }, // SIS. DE COM II
            // - REDE. IN. CO. MOV. [97]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 148, RequisitoId = 139 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 148, RequisitoId = 140 }, // TALLER ANAL. RED.
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 148, RequisitoId = 138 }, // REDES II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 148, RequisitoId = 141 }, // LEG. REDES. COM.
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 148, RequisitoId = 142 }, // SIS. DE COM II
            // - SEG. RED. TR. DAT. [98]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 149, RequisitoId = 139 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 149, RequisitoId = 140 }, // TALLER ANAL. RED.
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 149, RequisitoId = 138 }, // REDES II
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 149, RequisitoId = 141 }, // LEG REDES COM
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 149, RequisitoId = 142 }, // SIS. DE COM II

            // SEMESTRE 10
            // - MODALIDAD DE TITULACION LICENCIATURA [100]
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 150, RequisitoId = 145 }, // TALLER DE GRADO I
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 150, RequisitoId = 147 }, // --
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 150, RequisitoId = 146 }, // TECNOLOGIA WEB
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 150, RequisitoId = 148 }, // --
            new Prerequisito { Id = nextId--, MateriaPlanEstudioId = 150, RequisitoId = 149 } // --

        );
    }
}
