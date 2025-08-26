using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class PrerequisitoSeeder : IEntityTypeConfiguration<Prerequisito>
{
    public void Configure(EntityTypeBuilder<Prerequisito> builder)
    {
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
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 6, REQUISITO_ID = 1 }, // CALCULO 1
            // - ALGEBRA LINEAL [7]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 7, REQUISITO_ID = 2 }, // ESTRUCTURA DISCRETA
            // - PROGRAMACION I [8]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 8, REQUISITO_ID = 3 }, // INTRODUCCION A LA INFORMATICA
            // - FISICA II [9]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 9, REQUISITO_ID = 4 }, // FISICA I
            // - INGLES TECNICO II [10]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 10, REQUISITO_ID = 5 }, // INGLES TECNICO I

            // SEMESTRE 3
            // - ECUACIONES DIFERENCIALES [11]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 11, REQUISITO_ID = 6 }, // CALCULO II
            // - PROGRAMACION II [12]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 12, REQUISITO_ID = 7 }, // ALGEBRA LINEAL
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 12, REQUISITO_ID = 8 }, // PROGRAMACION I
            // - ARQUITECTURA DE COMPUTADORAS [13]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 13, REQUISITO_ID = 8 }, // PROGRAMACION I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 13, REQUISITO_ID = 9 }, // FISICA II
            // - FISICA III [14]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 14, REQUISITO_ID = 9 }, // FISICA II
            // - ADMINISTRACION [15]
            // new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 15, REQUISITO_ID = - }, // ---

            // SEMESTRE 4
            // - PROBABILIDAD Y ESTADISTICA I [16]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 16, REQUISITO_ID = 6 }, // CALCULO II
            // - METODOS NUMERICOS [17]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 17, REQUISITO_ID = 11 }, // ECUACIONES DIFERENCIALES
            // - ESTRUCTURA DE DATOS I [18]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 18, REQUISITO_ID = 12 }, // PROGRAMACION II
            // - PROGRAMACION ENSAMBLADOR [19]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 19, REQUISITO_ID = 13 }, // ARQUITECTURA DE COMPUTADORAS
            // - CONTABILIDAD [20]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 20, REQUISITO_ID = 15 }, // ADMINISTRACION

            // SEMESTRE 5
            // - PROBABILIDAD Y ESTADISTICA II [21]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 21, REQUISITO_ID = 16 }, // PROBABILIDAD Y ESTADISTICA I
            // - PROGRAMACION LOGICA Y FUNCIONAL [22]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 22, REQUISITO_ID = 18 }, // ESTRUCTURA DE DATOS I
            // - ESTRUCTURA DE DATOS II [23]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 23, REQUISITO_ID = 18 }, // ESTRUCTURA DE DATOS I
            // - BASE DE DATOS I [24]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 24, REQUISITO_ID = 18 }, // ESTRUCTURA DE DATOS I
            // - LENGUAJES FORMALES [25]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 25, REQUISITO_ID = 18 }, // ESTRUCTURA DE DATOS I

            // SEMESTRE 6
            // - INVESTIGACION OPERATIVA I [26]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 26, REQUISITO_ID = 21 }, // PROBABILIDAD Y ESTADISTICA I
            // - SISTEMA DE INFORMACION I [27]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 27, REQUISITO_ID = 24 }, // BASE DE DATOS I
            // - SISTEMAS OPERATIVOS I [28]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 28, REQUISITO_ID = 23 }, // ESTRUCTURA DE DATOS II
            // - BASE DE DATOS II [29]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 29, REQUISITO_ID = 24 }, // BASE DE DATOS I
            // - COMPILADORES [30]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 30, REQUISITO_ID = 25 }, // LENGUAJES FORMALES
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 30, REQUISITO_ID = 23 }, // ESTRUCTURA DE DATOS II

            // SEMESTRE 7
            // - INVESTIGACION OPERATIVA II [31]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 31, REQUISITO_ID = 26 }, // INVESTIGACION OPERATIVA I
            // - INTELIGENCIA ARTIFICAL [32]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 32, REQUISITO_ID = 30 }, // PROGRAMACION LOGICA Y FUNCIONAL
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 32, REQUISITO_ID = 23 }, // ESTRUCTURA DE DATOS II
            // - SISTEMAS OPERATIVOS II [33]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 33, REQUISITO_ID = 28 }, // SISTEMAS OPERATIVOS I
            // - REDES I [34]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 34, REQUISITO_ID = 28 }, // SISTEMAS OPERATIVOS I
            // - SISTEMAS DE INFORMACION II [38]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 35, REQUISITO_ID = 27 }, // SISTEMA DE INFORMACION I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 35, REQUISITO_ID = 29 }, // BASE DE DATOS II

            // SEMESTRE 8
            // - PREPARACION Y EVALUACION DE PROYECTOS [36]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 36, REQUISITO_ID = 31 }, // INVESTIGACION OPERATIVA II
            // - SISTEMAS EXPERTOS [37]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 37, REQUISITO_ID = 32 }, // INTELIGENCIA ARTIFICAL
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 37, REQUISITO_ID = 35 }, // SISTEMAS DE INFORMACION II
            // - SISTEMAS DE INFORMACION GEOGRAFICA [44]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 38, REQUISITO_ID = 35 }, // SISTEMA DE INFORMACION II
            // - REDES II [39]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 39, REQUISITO_ID = 34 }, // REDES I
            // - INGENIERIA DE SOFTWARE I [35]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 40, REQUISITO_ID = 35 }, // SISTEMAS DE INFORMACION II

            // SEMESTRE 9
            // - TALLER DE GRADO I [41]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 41, REQUISITO_ID = 36 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 41, REQUISITO_ID = 37 }, // SISTEMAS EXPERTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 41, REQUISITO_ID = 38 }, // SISTEMA DE INFORMACION GEOGRAFICA
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 41, REQUISITO_ID = 39 }, // REDES II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 41, REQUISITO_ID = 40 }, // INGENIERIA DE SOFTWARE I
            // - INGENIERIA DE SOFTWARE II [40]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 44, REQUISITO_ID = 36 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 44, REQUISITO_ID = 37 }, // SISTEMAS EXPERTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 44, REQUISITO_ID = 38 }, // SISTEMA DE INFORMACION GEOGRAFICA
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 44, REQUISITO_ID = 39 }, // REDES II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 44, REQUISITO_ID = 40 }, // INGENIERIA DE SOFTWARE I
            // - TECNOLOGIA WEB [42]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 42, REQUISITO_ID = 36 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 42, REQUISITO_ID = 37 }, // SISTEMAS EXPERTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 42, REQUISITO_ID = 38 }, // SISTEMA DE INFORMACION GEOGRAFICA
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 42, REQUISITO_ID = 39 }, // REDES II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 42, REQUISITO_ID = 40 }, // INGENIERIA DE SOFTWARE I
            // - ARQUITECTURA DE SOFTWARE [43]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 43, REQUISITO_ID = 36 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 43, REQUISITO_ID = 37 }, // SISTEMAS EXPERTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 43, REQUISITO_ID = 38 }, // SISTEMA DE INFORMACION GEOGRAFICA
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 43, REQUISITO_ID = 39 }, // REDES II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 43, REQUISITO_ID = 40 }, // INGENIERIA DE SOFTWARE I

            // SEMESTRE 10
            // - MODALIDAD DE TITULACION LICENCIATURA [58]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 45, REQUISITO_ID = 41 }, // TALLER DE GRADO I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 45, REQUISITO_ID = 44 }, // INGENIERIA DE SOFTWARE II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 45, REQUISITO_ID = 42 }, // TECNOLOGIA WEB
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 45, REQUISITO_ID = 43 }, // ARQUITECTURA DE SOFTWARE


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
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 54, REQUISITO_ID = 49 }, // FISICA I
            // - PROGRAMACION I [8]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 53, REQUISITO_ID = 48 }, // INTRODUCCION A LA INFORMATICA
            // - INGLES TECNICO II [10]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 55, REQUISITO_ID = 50 }, // INGLES TECNICO I
            // - CALCULO II [6]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 51, REQUISITO_ID = 46 }, // CALCULO 1
            // - ALGEBRA LINEAL [7]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 52, REQUISITO_ID = 47 }, // ESTRUCTURA DISCRETA

            // SEMESTRE 3
            // - ADMINISTRACION [15]
            // new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 60, REQUISITO_ID = -- }, 
            // - PROGRAMACION II [12]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 57, REQUISITO_ID = 53 }, // PROGRAMACION I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 57, REQUISITO_ID = 52 }, // ALGEBRA LINEAL
            // - ARQUITECTURA DE COMPUTADORAS [13]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 58, REQUISITO_ID = 53 }, // PROGRAMACION I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 58, REQUISITO_ID = 54 }, // FISICA II
            // - ECUACIONES DIFERENCIALES [11]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 56, REQUISITO_ID = 51 }, // CALCULO II
            // - FISICA III [14]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 59, REQUISITO_ID = 54 }, // FISICA II

            
            // SEMESTRE 4
            // - CONTABILIDAD [20]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 65, REQUISITO_ID = 60 }, // ADMINISTRACION
            // - ESTRUCTURA DE DATOS I [18]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 63, REQUISITO_ID = 57 }, // PROGRAMACION II
            // - PROGRAMACION ENSAMBLADOR [19]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 64, REQUISITO_ID = 58 }, // ARQUITECTURA DE COMPUTADORAS
            // - PROBABILIDAD Y ESTADISTICA I [16]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 61, REQUISITO_ID = 51 }, // CALCULO II
            // - METODOS NUMERICOS [17]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 62, REQUISITO_ID = 56 }, // ECUACIONES DIFERENCIALES

            // SEMESTRE 5
            // - ORGANIZACION Y METODOS [53]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 71, REQUISITO_ID = 65 }, // CONTABILIDAD
            // - ECONOMIA PARA LA GESTION [54]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 72, REQUISITO_ID = 65 }, // CONTABILIDAD
            // - ESTRUCTURA DE DATOS II [23]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 68, REQUISITO_ID = 63 }, // ESTRUCTURA DE DATOS I
            // - BASE DE DATOS I [24]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 69, REQUISITO_ID = 63 }, // ESTRUCTURA DE DATOS I
            // - PROBABILIDAD Y ESTADISTICA II [21]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 66, REQUISITO_ID = 61 }, // PROBABILIDAD Y ESTADISTICA I

            // SEMESTRE 6
            // - FINANZAS PARA LA EMPRESA [55]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 78, REQUISITO_ID = 71 }, // ORGANIZACION Y METODOS
            // - BASE DE DATOS II [29]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 76, REQUISITO_ID = 69 }, // BASE DE DATOS I
            // - SISTEMAS OPERATIVOS I [28]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 75, REQUISITO_ID = 68 }, // ESTRUCTURA DE DATOS II
            // - SISTEMA DE INFORMACION I [27]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 74, REQUISITO_ID = 69 }, // BASE DE DATOS I
            // - INVESTIGACION OPERATIVA I [26]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 73, REQUISITO_ID = 66 }, // PROBABILIDAD Y ESTADISTICA II


            // SEMESTRE 7
            // - SISTEMAS OPERATIVOS II [33]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 81, REQUISITO_ID = 75 }, // SISTEMAS OPERATIVOS I
            // - SISTEMA PARA EL SOPORTE A LA TOMA DE DECISIONS [56]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 84, REQUISITO_ID = 74 }, // SISTEMA DE INFORMACION I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 84, REQUISITO_ID = 76 }, // BASE DE DATOS II
            // - INVESTIGACION OPERATIVA II [31]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 79, REQUISITO_ID = 73 }, // INVESTIGACION OPERATIVA I
            // - REDES I [34]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 82, REQUISITO_ID = 75 }, // SISTEMAS OPERATIVOS I
            // - SISTEMAS DE INFORMACION II [38]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 83, REQUISITO_ID = 74 }, // SISTEMA DE INFORMACION I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 83, REQUISITO_ID = 76 }, // BASE DE DATOS II

            // SEMESTRE 8
            // - PREPARACION Y EVALUACION DE PROYECTOS [36]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 85, REQUISITO_ID = 79 }, // INVESTIGACION OPERATIVA II
            // - INGENIERIA DE SOFTWARE I [35]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 87, REQUISITO_ID = 83 }, // SISTEMAS DE INFORMACION II
            // - REDES II [39]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 88, REQUISITO_ID = 82 }, // REDES I
            // - SISTEMAS DE INFORMACION GEOGRAFICA [44]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 89, REQUISITO_ID = 83 }, // SISTEMA DE INFORMACION II
            // - AUDITORIA INFORMATICA [57]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 90, REQUISITO_ID = 78 }, // FINANZAS PARA LA EMPRESA
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 90, REQUISITO_ID = 83 }, // SISTEMAS DE INFORMACION II


            // SEMESTRE 9
            // - TALLER DE GRADO I [41]
            // new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 91, REQUISITO_ID = - }, // --
            // - INGENIERIA DE SOFTWARE II [40]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 94, REQUISITO_ID = 89 }, // SISTEMA DE INFORMACION GEOGRAFICA
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 94, REQUISITO_ID = 88 }, // REDES II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 94, REQUISITO_ID = 87 }, // INGENIERIA DE SOFTWARE I
            // - TECNOLOGIA WEB [42]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 92, REQUISITO_ID = 90 }, // AUDITORIA INFORMATICA
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 92, REQUISITO_ID = 85 }, // PREPARACION Y EVALUACION DE PROYECTOS
            // - ARQUITECTURA DE SOFTWARE [43]
            // new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 93, REQUISITO_ID = - }, // --

            // SEMESTRE 10
            // - MODALIDAD DE TITULACION LICENCIATURA [58]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 95, REQUISITO_ID = 91 }, // TALLER DE GRADO I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 95, REQUISITO_ID = 94 }, // INGENIERIA DE SOFTWARE II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 95, REQUISITO_ID = 92 }, // TECNOLOGIA WEB
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 95, REQUISITO_ID = 93 }, // ARQUITECTURA DE SOFTWARE
            
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
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 101, REQUISITO_ID = 96 }, // CALCULO 1
            // - ALGEBRA LINEAL [7]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 102, REQUISITO_ID = 97 }, // ESTRUCTURA DISCRETA
            // - PROGRAMACION I [8]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 103, REQUISITO_ID = 98 }, // INTRODUCCION A LA INFORMATICA
            // - FISICA II [9]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 104, REQUISITO_ID = 99 }, // FISICA I
            // - INGLES TECNICO II [10]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 105, REQUISITO_ID = 100 }, // INGLES TECNICO I

            // SEMESTRE 3
            // - ECUACIONES DIFERENCIALES [11]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 106, REQUISITO_ID = 101 }, // CALCULO II
            // - PROGRAMACION II [12]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 107, REQUISITO_ID = 102 }, // ALGEBRA LINEAL
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 107, REQUISITO_ID = 103 }, // PROGRAMACION I
            // - ARQUITECTURA DE COMPUTADORAS [13]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 108, REQUISITO_ID = 103 }, // PROGRAMACION I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 108, REQUISITO_ID = 104 }, // FISICA II
            // - ANALISIS DE CIRCUITO [75]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 109, REQUISITO_ID = 104 }, // FISICA II
            // - TEORIA DE CAMPOS [76]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 110, REQUISITO_ID = 104 }, // FISICA II
            
            
            // SEMESTRE 4
            // - METODOS NUMERICOS [17]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 112, REQUISITO_ID = 106 }, // ECUACIONES DIFERENCIALES
            // - PROBABILIDAD Y ESTADISTICA I [16]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 111, REQUISITO_ID = 101 }, // CALCULO II
            // - ESTRUCTURA DE DATOS I [18]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 113, REQUISITO_ID = 107 }, // PROGRAMACION II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 113, REQUISITO_ID = 96 }, // CALCULO I
            // - PROGRAMACION ENSAMBLADOR [19]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 114, REQUISITO_ID = 108 }, // ARQUITECTURA DE COMPUTADORAS
            // - ANALISIS CIRCUITOS ELECTRONICOS [77]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 115, REQUISITO_ID = 109 }, // ANALISIS DE CIRCUITOS

            // SEMESTRE 5
            // - PROBABILIDAD Y ESTADISTICA II [21]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 116, REQUISITO_ID = 111 }, // PROBABILIDAD Y ESTADISTICA I
            // - BASE DE DATOS I [24]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 117, REQUISITO_ID = 113 }, // ESTRUCTURA DE DATOS I
            // - ELECTRONICA APLICADA A REDES [78]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 118, REQUISITO_ID = 115 }, // ANALISIS DE CIRCUITO ELECTRONICO
            // - SISTEMAS LOGICOS Y DIGITALES I [79]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 119, REQUISITO_ID = 115 }, // ANALISIS DE CIRCUITO ELECTRONICO
            // - SEÑALES Y SISTEMAS [80]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 120, REQUISITO_ID = 110 }, // TEORIA DE CAMPOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 120, REQUISITO_ID = 106 }, // ECUACIONES DIFERENCIALES
            
            // SEMESTRE 6
            // - SISTEMA OPERATIVO I [28]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 123, REQUISITO_ID = 116 }, // PROBABILIDAD Y ESTADISTICA II
            // - BASE DE DATOS II [29]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 124, REQUISITO_ID = 117 }, // BASE DE DATOS I
            // - INVESTIGACION OPERATIVA I [26]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 125, REQUISITO_ID = 121 }, // SISTEMA OPERATIVO I
            // - SISTEMAS LOGICOS Y DIGITALES II [83]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 126, REQUISITO_ID = 119 }, // SISTEMAS LOGICOS Y DIGITALES I
            // - INTERPRETACION DE SISTEMAS Y SEÑALES. [84]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 127, REQUISITO_ID = 120 }, // SEÑALES Y SISTEMAS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 127, REQUISITO_ID = 112 }, // METODOS NUMERICOS

            // SEMESTRE 7
            // - INVESTIGACION OPERATIVA II [31]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 133, REQUISITO_ID = 125 }, // INVESTIGACION OPERATIVA I
            // - SISTEMAS OPERATIVOS II [33]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 132, REQUISITO_ID = 123 }, // SISTEMAS OPERATIVOS I
            // - REDES I [34]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 131, REQUISITO_ID = 123 }, // SISTEMAS OPERATIVOS I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 131, REQUISITO_ID = 120 }, // SEÑALES Y SISTEMAS
            // - APLIC. MICROP. [87]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 134, REQUISITO_ID = 126 }, // SIST. LOG. DIG. II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 134, REQUISITO_ID = 114 }, // PROGRAMACION ENSAMBLADOR
            // - SISTEMAS DE COM. [88]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 135, REQUISITO_ID = 127 }, // INT. SIS. SEÑALES
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 135, REQUISITO_ID = 120 }, // SEÑALES Y SISTEMAS

            // SEMESTRE 8
            // - PREPARACION Y EVALUACION DE PROYECTOS [36]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 139, REQUISITO_ID = 133 }, // INVESTIGACION OPERATIVA II
            // - TALLER ANAL. RED. [91]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 140, REQUISITO_ID = 131 }, // REDES I
            // - REDES II [39]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 138, REQUISITO_ID = 131 }, // REDES I
            // - LEG. REDES. COM [92]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 141, REQUISITO_ID = 131 }, // REDES I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 141, REQUISITO_ID = 135 }, // SISTEMA DE COMUNICACION I
            // - SISTEMAS DE COMUNICACION II [93]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 142, REQUISITO_ID = 135 }, // SISTEMAS DE COMUNICACION I

            
            // SEMESTRE 9
            // - TALLER DE GRADO I [41]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 145, REQUISITO_ID = 139 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 145, REQUISITO_ID = 140 }, // TALLER ANAL. RED.
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 145, REQUISITO_ID = 138 }, // REDES II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 145, REQUISITO_ID = 141 }, // LEG. REDES. COM.
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 145, REQUISITO_ID = 142 }, // SIS. DE COM II
            // - TECNOLOGIA WEB [42]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 146, REQUISITO_ID = 139 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 146, REQUISITO_ID = 140 }, // TALLER ANAL. RED.
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 146, REQUISITO_ID = 138 }, // REDES II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 146, REQUISITO_ID = 141 }, // LEG. REDES. COM.
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 146, REQUISITO_ID = 142 }, // SIS. DE COM II
            // - GEST. ADM. RED. [96]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 147, REQUISITO_ID = 139 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 147, REQUISITO_ID = 140 }, // TALLER ANAL. RED.
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 147, REQUISITO_ID = 138 }, // REDES II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 147, REQUISITO_ID = 141 }, // LEG. REDES. COM.
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 147, REQUISITO_ID = 142 }, // SIS. DE COM II
            // - REDE. IN. CO. MOV. [97]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 148, REQUISITO_ID = 139 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 148, REQUISITO_ID = 140 }, // TALLER ANAL. RED.
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 148, REQUISITO_ID = 138 }, // REDES II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 148, REQUISITO_ID = 141 }, // LEG. REDES. COM.
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 148, REQUISITO_ID = 142 }, // SIS. DE COM II
            // - SEG. RED. TR. DAT. [98]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 149, REQUISITO_ID = 139 }, // PREPARACION Y EVALUACION DE PROYECTOS
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 149, REQUISITO_ID = 140 }, // TALLER ANAL. RED.
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 149, REQUISITO_ID = 138 }, // REDES II
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 149, REQUISITO_ID = 141 }, // LEG REDES COM
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 149, REQUISITO_ID = 142 }, // SIS. DE COM II

            // SEMESTRE 10
            // - MODALIDAD DE TITULACION LICENCIATURA [100]
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 150, REQUISITO_ID = 145 }, // TALLER DE GRADO I
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 150, REQUISITO_ID = 147 }, // --
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 150, REQUISITO_ID = 146 }, // TECNOLOGIA WEB
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 150, REQUISITO_ID = 148 }, // --
            new Prerequisito { MATERIA_PLAN_ESTUDIO_ID = 150, REQUISITO_ID = 149 } // --

  
        );
    }
}
