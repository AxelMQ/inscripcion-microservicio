using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class MateriaSeeder : IEntityTypeConfiguration<Materia>
{
    public void Configure(EntityTypeBuilder<Materia> builder)
    {
        builder.HasData(
            // // 1 SEMESTRE
            // new Materia { ID = 1, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INTRODUCCION A LA INFORMATICA", SIGLA = "INF110" },
            // new Materia { ID = 2, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ESTRUCTURAS DISCRETAS", SIGLA = "INF119" },
            // new Materia { ID = 3, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "FISICA I", SIGLA = "FIS100" },
            // new Materia { ID = 4, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INGLES TECNICO I", SIGLA = "LIN100" },
            // new Materia { ID = 5, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "CALCULO I", SIGLA = "MAT101" },

            // // 2 SEMESTRE
            // new Materia { ID = 6, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ALGEBRA LINEAL", SIGLA = "MAT103" },
            // new Materia { ID = 7, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROGRAMACION I", SIGLA = "INF120" },
            // new Materia { ID = 8, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "CALCULO I", SIGLA = "MAT102" },
            // new Materia { ID = 9, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "FISICA II", SIGLA = "FIS102" },
            // new Materia { ID = 10, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INGLES TECNICO II", SIGLA = "LIN101" },

            // // 3 SEMESTRE
            // new Materia { ID = 11, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ARQUITECTURA DE COMPUTADORAS", SIGLA = "INF211" },
            // new Materia { ID = 12, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROGRAMACION II", SIGLA = "INF210" },
            // new Materia { ID = 13, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ADMINISTRACION", SIGLA = "ADM100" },
            // new Materia { ID = 14, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "FISICA III", SIGLA = "FIS200" },
            // new Materia { ID = 15, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ECUACIONES DIFERENCIALES", SIGLA = "MAT207" },
            // new Materia { ID = 16, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ANALISIS DE CIRCUITOS", SIGLA = "RDS210" },
            // new Materia { ID = 17, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "TEORIA DE CAMPOS", SIGLA = "ELT241" },

            // // 4 SEMESTRE
            // new Materia { ID = 18, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROBABILIDAD Y ESTADISTICA I", SIGLA = "MAT202" },
            // new Materia { ID = 19, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "CONTABILIDAD", SIGLA = "ADM200" },
            // new Materia { ID = 20, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROGRAMACION ENSAMBLADOR", SIGLA = "INF221" },
            // new Materia { ID = 21, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ESTRUCTURA DE DATOS I", SIGLA = "INF220" },
            // new Materia { ID = 22, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "METODOS NUMERICOS", SIGLA = "MAT205" },
            // new Materia { ID = 23, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ANALISIS DE CIRCUITOS ELECTRONICOS", SIGLA = "RDS220" },

            // // 5 SEMESTRE
            // new Materia { ID = 24, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "LENGUAJES FORMALES", SIGLA = "INF319" },
            // new Materia { ID = 25, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROGRAMACION LOGICA Y FUNCIONAL", SIGLA = "INF318" },
            // new Materia { ID = 26, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "BASE DE DATROS I", SIGLA = "INF312" },
            // new Materia { ID = 27, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ESTRUCTURA DE DATOS II", SIGLA = "INF310" },
            // new Materia { ID = 28, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROBABILIDAD Y ESTADISTICA II", SIGLA = "MAT302" },
            // new Materia { ID = 29, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ORGANIZACION Y METODOS", SIGLA = "ADM330" },
            // new Materia { ID = 30, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ECONOMIA PARA LA GESTION", SIGLA = "ECO300" },
            // new Materia { ID = 31, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS LOGICOS Y DIGITALES I", SIGLA = "ELT352" },
            // new Materia { ID = 32, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ELECTRONICA APLICADA A REDES", SIGLA = "RDS310" },
            // new Materia { ID = 33, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SEÑALES Y SISTEMAS", SIGLA = "ELT354" },

            // // 6 SEMESTRE
            // new Materia { ID = 34, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "BASE DE DATOS II", SIGLA = "INF322" },
            // new Materia { ID = 35, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INVESTIGACION OPERATIVA I", SIGLA = "MAT329" },
            // new Materia { ID = 36, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "COMPILADORES", SIGLA = "INF329" },
            // new Materia { ID = 37, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS OPERATIVOS I", SIGLA = "INF323" },
            // new Materia { ID = 38, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE INFORMACION I", SIGLA = "INF342" },
            // new Materia { ID = 39, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "FINANZAS PARA LA EMPRESA", SIGLA = "ECO320" },
            // new Materia { ID = 40, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS LOGICOS Y DIGITALES II", SIGLA = "ELT362" },
            // new Materia { ID = 41, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INTERPRETACION DE SISTEMAS Y SEÑALES", SIGLA = "RDS320" },

            // // 7 SEMESTRE
            // new Materia { ID = 42, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "REDES I", SIGLA = "INF433" },
            // new Materia { ID = 43, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS OPERATIVOS II", SIGLA = "INF413" },
            // new Materia { ID = 44, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INTELIGENCIA ARTIFICIAL", SIGLA = "INF418" },
            // new Materia { ID = 45, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE INFORMACION II", SIGLA = "INF412" },
            // new Materia { ID = 46, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INVESTIGACION OPERATIVA II", SIGLA = "MAT419" },
            // new Materia { ID = 47, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS PARA EL SOPORTE A LA TOMA DE DESICIONES", SIGLA = "INF432" },
            // new Materia { ID = 48, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE COMUNICACION I", SIGLA = "ELT374" },
            // new Materia { ID = 49, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "APPS CON MICROPROCESADORES", SIGLA = "RDS410" },

            // // 8 SEMESTRE
            // new Materia { ID = 50, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INGENIERIA DE SOFTWARE I", SIGLA = "INF422" },
            // new Materia { ID = 51, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "REDES II", SIGLA = "INF423" },
            // new Materia { ID = 52, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE INFORMACION GEOGRAFICA", SIGLA = "INF442" },
            // new Materia { ID = 53, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PREPARACION Y EVALUACION DE PROYECTO", SIGLA = "ECO449" },
            // new Materia { ID = 54, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS EXPERTOS", SIGLA = "INF428" },
            // new Materia { ID = 55, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "AUDITORIA INFORMATICA", SIGLA = "INF462" },
            // new Materia { ID = 56, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "TALLER DE ANALISIS Y DESEÑO DE REDES", SIGLA = "RDS421" },
            // new Materia { ID = 57, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE COMUNICACION II", SIGLA = "ELT384" },
            // new Materia { ID = 58, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "LEGISLACION EN REDES Y COMUNICACIONES", SIGLA = "RDS429" },

            // // 9 SEMESTRE
            // new Materia { ID = 59, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INGENIERIA DE SOFTWARE II", SIGLA = "INF512" },
            // new Materia { ID = 60, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ARQUITECTURA DE SOFTWARE", SIGLA = "INF552" },
            // new Materia { ID = 61, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "TECNOLOGIA WEB", SIGLA = "INF513" },
            // new Materia { ID = 62, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "TALLER DE GRADO I", SIGLA = "INF511" },
            // new Materia { ID = 63, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "GESTION Y ADMINISTRACION DE REDES", SIGLA = "RDS511" },
            // new Materia { ID = 64, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "REDES INALAMBRICAS Y COMUNICACIONES MOVILES", SIGLA = "RDS512" },
            // new Materia { ID = 65, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SEGURIDAD EN REDES Y TRANSMISION DE DATOS", SIGLA = "RDS519" },

            // // 10 SEMESTRE
            // new Materia { ID = 66, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "MODALIDAD DE GRADUACION ", SIGLA = "GRL001" },

            // // ELECTIVAS INFORMATICA
            // new Materia { ID = 67, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "MODELACION Y SIMULACION DE SISTEMAS", SIGLA = "ELC101" },
            // new Materia { ID = 68, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "PROGRAMACION GRAFICA", SIGLA = "ELC102" },
            // new Materia { ID = 69, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "TOPICOS AVANZADOS DE PROGRAMACION", SIGLA = "ELC103" },
            // new Materia { ID = 70, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "PROGRAMACION DE APLICACIONES DE TIEMPO REAL", SIGLA = "ELC104" },
            // new Materia { ID = 71, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "SISTEMAS DISTRIBUIDOS", SIGLA = "ELC105" },
            // new Materia { ID = 72, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "INTERACCION HOMBRE COMPUTADOR", SIGLA = "ELC106" },
            // new Materia { ID = 73, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "CRIPTOGRAFICA Y SEGURIDAD", SIGLA = "ELC107" },
            // new Materia { ID = 74, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "CONTROL Y AUTOMATIZACION", SIGLA = "ELC108" },

            // // ELECTIVAS REDES
            // new Materia { ID = 75, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "DISEÑO DE CIRCUITOS INTEGRADOS", SIGLA = "ELC201" },
            // new Materia { ID = 76, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "INSTRUMENTACION", SIGLA = "ELC202" },
            // new Materia { ID = 77, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "SISTEMAS DE COMUNICACION SCADA", SIGLA = "ELC203" },
            // new Materia { ID = 78, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "TELEVISION DIGITAL", SIGLA = "ELC204" },
            // new Materia { ID = 79, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "DOMOTICA", SIGLA = "ELC205" },
            // new Materia { ID = 80, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "LINEAS Y TRANSMISION DE ANTES", SIGLA = "ELC206" },
            // new Materia { ID = 81, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "TECNICAS PARA PRESENTACION PARA INGENIERIA", SIGLA = "ELC207" },
            // new Materia { ID = 82, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "REDES ADHOC", SIGLA = "ELC208" },

            // // ELECTIVAS SISTEMAS
            // new Materia { ID = 83, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "ADMINISTRACION DE RECURSOS HUMANOS", SIGLA = "ELC001" },
            // new Materia { ID = 84, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "COSTOS Y PRESUPUESTOS", SIGLA = "ELC002" },
            // new Materia { ID = 85, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "PRODUCCION Y MARKETING", SIGLA = "ELC003" },
            // new Materia { ID = 86, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "REINGENIERIA", SIGLA = "ELC004" },
            // new Materia { ID = 87, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "INGENIERIA DE CALIDAD", SIGLA = "ELC005" },
            // new Materia { ID = 88, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "BENCHMARKING", SIGLA = "ELC006" },
            // new Materia { ID = 89, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "INTRODUCCION A LA MACROECONOMIA", SIGLA = "ELC007" },
            // new Materia { ID = 90, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "LEGISLACION EN CIENCIAS DE LA COMPUTACION", SIGLA = "ELC008" }

            // SEMESTRE 1 - MATERIAS COMUNES
            new Materia { ID = 1, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "CÁLCULO I", SIGLA = "MAT101" },
            new Materia { ID = 2, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ESTRUCTURAS DISCRETAS", SIGLA = "INF119" },
            new Materia { ID = 3, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INTRODUCCIÓN A LA INFORMÁTICA", SIGLA = "INF110" },
            new Materia { ID = 4, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "FÍSICA I", SIGLA = "FIS100" },
            new Materia { ID = 5, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INGLÉS TÉCNICO I", SIGLA = "LIN100" },

            // SEMESTRE 2 - MATERIAS COMUNES
            new Materia { ID = 6, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "CÁLCULO II", SIGLA = "MAT102" },
            new Materia { ID = 7, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ÁLGEBRA LINEAL", SIGLA = "MAT103" },
            new Materia { ID = 8, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "PROGRAMACIÓN I", SIGLA = "INF120" },
            new Materia { ID = 9, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "FÍSICA II", SIGLA = "FIS102" },
            new Materia { ID = 10, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INGLÉS TÉCNICO II", SIGLA = "LIN101" },

            // SEMESTRE 3 - MATERIAS COMUNES
            new Materia { ID = 11, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ECUACIONES DIFERENCIALES", SIGLA = "MAT207" },
            new Materia { ID = 12, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "PROGRAMACIÓN II", SIGLA = "INF210" },
            new Materia { ID = 13, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ARQUITECTURA DE COMPUTADORAS", SIGLA = "INF211" },
            new Materia { ID = 14, CREDITO = 6, ES_ELECTIVA = false, NOMBRE = "FÍSICA III", SIGLA = "FIS200" },
            new Materia { ID = 15, CREDITO = 4, ES_ELECTIVA = false, NOMBRE = "ADMINISTRACIÓN", SIGLA = "ADM100" },

            // SEMESTRE 4 - MATERIAS COMUNES
            new Materia { ID = 16, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "PROBABILIDAD Y ESTADÍSTICA I", SIGLA = "MAT202" },
            new Materia { ID = 17, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "MÉTODOS NUMÉRICOS", SIGLA = "MAT205" },
            new Materia { ID = 18, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ESTRUCTURA DE DATOS I", SIGLA = "INF220" },
            new Materia { ID = 19, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "PROGRAMACIÓN ENSAMBLADOR", SIGLA = "INF221" },
            new Materia { ID = 20, CREDITO = 4, ES_ELECTIVA = false, NOMBRE = "CONTABILIDAD", SIGLA = "ADM200" },

            // SEMESTRE 5 - INFORMÁTICA/SISTEMAS
            new Materia { ID = 21, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "PROBABILIDAD Y ESTADÍSTICA II", SIGLA = "MAT302" },
            new Materia { ID = 22, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "PROGRAMACIÓN LÓGICA Y FUNCIONAL", SIGLA = "INF318" },
            new Materia { ID = 23, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ESTRUCTURA DE DATOS II", SIGLA = "INF310" },
            new Materia { ID = 24, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "BASE DE DATOS I", SIGLA = "INF312" },
            new Materia { ID = 25, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "LENGUAJES FORMALES", SIGLA = "INF319" },

            // SEMESTRE 5 - SISTEMAS (ESPECÍFICAS)
            new Materia { ID = 53, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ORGANIZACIÓN Y MÉTODOS", SIGLA = "ADM330" },
            new Materia { ID = 54, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ECONOMÍA PARA LA GESTIÓN", SIGLA = "ECO300" },

            // SEMESTRE 6 - INFORMÁTICA/SISTEMAS
            new Materia { ID = 26, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INVESTIGACIÓN OPERATIVA I", SIGLA = "MAT329" },
            new Materia { ID = 27, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE INFORMACIÓN I", SIGLA = "INF342" },
            new Materia { ID = 28, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS OPERATIVOS I", SIGLA = "INF323" },
            new Materia { ID = 29, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "BASE DE DATOS II", SIGLA = "INF322" },
            new Materia { ID = 30, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "COMPILADORES", SIGLA = "INF329" },

            // SEMESTRE 6 - SISTEMAS (ESPECÍFICA)
            new Materia { ID = 55, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "FINANZAS PARA LA EMPRESA", SIGLA = "ADM320" },

            // SEMESTRE 7 - INFORMÁTICA/SISTEMAS
            new Materia { ID = 31, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INVESTIGACIÓN OPERATIVA II", SIGLA = "MAT419" },
            new Materia { ID = 32, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INTELIGENCIA ARTIFICIAL", SIGLA = "INF418" },
            new Materia { ID = 33, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS OPERATIVOS II", SIGLA = "INF413" },
            new Materia { ID = 34, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "REDES I", SIGLA = "INF433" },
            new Materia { ID = 35, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INGENIERÍA DE SOFTWARE I", SIGLA = "INF422" },

            // SEMESTRE 7 - SISTEMAS (ESPECÍFICA)
            new Materia { ID = 56, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS PARA EL SOPORTE A LA TOMA DE DECISIONES", SIGLA = "INF432" },

            // SEMESTRE 8 - INFORMÁTICA/SISTEMAS
            new Materia { ID = 36, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "PREPARACIÓN Y EVALUACIÓN DE PROYECTOS", SIGLA = "ECO449" },
            new Materia { ID = 37, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS EXPERTOS", SIGLA = "INF428" },
            new Materia { ID = 38, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE INFORMACIÓN II", SIGLA = "INF412" },
            new Materia { ID = 39, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "REDES II", SIGLA = "INF423" },
            new Materia { ID = 40, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INGENIERÍA DE SOFTWARE II", SIGLA = "INF512" },

            // SEMESTRE 8 - SISTEMAS (ESPECÍFICA)
            new Materia { ID = 57, CREDITO = 4, ES_ELECTIVA = false, NOMBRE = "AUDITORÍA INFORMÁTICA", SIGLA = "INF462" },

            // SEMESTRE 9 - INFORMÁTICA
            new Materia { ID = 41, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "TALLER DE GRADO I", SIGLA = "INF511" },
            new Materia { ID = 42, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "TECNOLOGÍA WEB", SIGLA = "INF513" },
            new Materia { ID = 43, CREDITO = 4, ES_ELECTIVA = false, NOMBRE = "ARQUITECTURA DE SOFTWARE", SIGLA = "INF552" },
            new Materia { ID = 44, CREDITO = 4, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE INFORMACIÓN GEOGRÁFICA", SIGLA = "INF442" },

            // MATERIA DE GRADUACIÓN
            new Materia { ID = 58, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "MODALIDAD DE GRADUACIÓN", SIGLA = "GRLO01" },

            // MATERIAS ELECTIVAS INFORMÁTICA
            new Materia { ID = 59, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "MODELACIÓN Y SIMULACIÓN DE SISTEMAS", SIGLA = "ELCI01" },
            new Materia { ID = 60, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "PROGRAMACIÓN GRÁFICA", SIGLA = "ELCI02" },
            new Materia { ID = 61, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "TÓPICOS AVANZADOS DE PROGRAMACIÓN", SIGLA = "ELCI03" },
            new Materia { ID = 62, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "PROGRAMACIÓN DE APLICACIONES DE TIEMPO REAL", SIGLA = "ELCI04" },
            new Materia { ID = 63, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "SISTEMAS DISTRIBUIDOS", SIGLA = "ELCI05" },
            new Materia { ID = 64, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "INTERACCIÓN HOMBRE COMPUTADOR", SIGLA = "ELCI06" },
            new Materia { ID = 65, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "CRIPTOGRAFÍA Y SEGURIDAD", SIGLA = "ELCI07" },
            new Materia { ID = 66, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "CONTROL AND AUTOMATIZACIÓN", SIGLA = "ELCI08" },

            // MATERIAS ELECTIVAS SISTEMAS
            new Materia { ID = 67, CREDITO = 3, ES_ELECTIVA = true, NOMBRE = "ADMINISTRACIÓN DE RECURSOS HUMANOS", SIGLA = "ELC001" },
            new Materia { ID = 68, CREDITO = 3, ES_ELECTIVA = true, NOMBRE = "COSTOS Y PRESUPUESTOS", SIGLA = "ELC002" },
            new Materia { ID = 69, CREDITO = 3, ES_ELECTIVA = true, NOMBRE = "PRODUCCIÓN Y MARKETING", SIGLA = "ELC003" },
            new Materia { ID = 70, CREDITO = 3, ES_ELECTIVA = true, NOMBRE = "REINGENIERÍA", SIGLA = "ELC004" },
            new Materia { ID = 71, CREDITO = 3, ES_ELECTIVA = true, NOMBRE = "INGENIERÍA DE LA CALIDAD", SIGLA = "ELC005" },
            new Materia { ID = 72, CREDITO = 3, ES_ELECTIVA = true, NOMBRE = "BENCHMARKING", SIGLA = "ELC006" },
            new Materia { ID = 73, CREDITO = 3, ES_ELECTIVA = true, NOMBRE = "INTRODUCCIÓN A LA MACROECONOMÍA", SIGLA = "ELC007" },
            new Materia { ID = 74, CREDITO = 3, ES_ELECTIVA = true, NOMBRE = "LEGISLACIÓN EN CIENCIAS DE LA COMPUTACIÓN", SIGLA = "ELC008" },

            // MATERIAS DE REDES (CORREGIDAS)
            new Materia { ID = 75, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ANÁLISIS DE CIRCUITOS", SIGLA = "RDS210" },
            new Materia { ID = 76, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "TEORÍA DE CAMPOS", SIGLA = "ELT241" },
            new Materia { ID = 77, CREDITO = 4, ES_ELECTIVA = false, NOMBRE = "ANÁLISIS DE CIRCUITOS ELECTRÓNICOS", SIGLA = "RDS220" },
            new Materia { ID = 78, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ELECTRÓNICA APLICADA A REDES", SIGLA = "RDS310" },
            new Materia { ID = 79, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS LÓGICOS Y DIGITALES I", SIGLA = "ELT352" },
            new Materia { ID = 80, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SEÑALES Y SISTEMAS", SIGLA = "ELT354" },
            new Materia { ID = 81, CREDITO = 5, ES_ELECTIVA = true, NOMBRE = "DISEÑO DE CIRCUITOS INTEGRADOS", SIGLA = "ELC201" },
            new Materia { ID = 82, CREDITO = 5, ES_ELECTIVA = true, NOMBRE = "INSTRUMENTACIÓN", SIGLA = "ELC202" },

            //SEMESTRE 6
            new Materia { ID = 83, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS LÓGICOS Y DIGITALES II", SIGLA = "ELT362" },
            new Materia { ID = 84, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INTERPRETACIÓN DE SISTEMAS Y SEÑALES", SIGLA = "RDS320" },
            new Materia { ID = 85, CREDITO = 5, ES_ELECTIVA = true, NOMBRE = "SISTEMAS DE COMUNICACIÓN SCADA", SIGLA = "ELC203" },
            new Materia { ID = 86, CREDITO = 5, ES_ELECTIVA = true, NOMBRE = "TELEVISIÓN DIGITAL", SIGLA = "ELC204" },

            //SEMESTRE 7
            new Materia { ID = 87, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "APLICACIONES CON MICROPROCESADORES", SIGLA = "RDS410" },
            new Materia { ID = 88, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE COMUNICACIÓN I", SIGLA = "ELT374" },
            new Materia { ID = 89, CREDITO = 5, ES_ELECTIVA = true, NOMBRE = "DOMÓTICA", SIGLA = "ELC205" },
            new Materia { ID = 90, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "LÍNEAS DE TRANSMISIÓN Y ANTENAS", SIGLA = "ELC206" },

            //SEMESTRE 8
            new Materia { ID = 91, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "TALLER DE ANÁLISIS Y DISEÑO DE REDES", SIGLA = "RDS421" },
            new Materia { ID = 92, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "LEGISLACIÓN EN REDES Y COMUNICACIONES", SIGLA = "RS429" },
            new Materia { ID = 93, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE COMUNICACIÓN II", SIGLA = "ELC384" },
            new Materia { ID = 94, CREDITO = 5, ES_ELECTIVA = true, NOMBRE = "TÉCNICAS DE PRESENTACIÓN PARA INGENIERÍA", SIGLA = "ELC207" },
            new Materia { ID = 95, CREDITO = 5, ES_ELECTIVA = true, NOMBRE = "REDES ADHOC", SIGLA = "ELC208" },

            //SEMESTRE 9
            new Materia { ID = 96, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "GESTIÓN Y ADMINISTRACIÓN DE REDES", SIGLA = "RDS511" },
            new Materia { ID = 97, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "REDES INALÁMBRICAS Y COMUNICACIONES MÓVILES", SIGLA = "RDS512" },
            new Materia { ID = 98, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SEGURIDAD EN REDES Y TRANSMISIÓN DE DATOS", SIGLA = "RDS519" },

            // MATERIAS DE TITULACIÓN
            new Materia { ID = 99, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "MODALIDAD DE TITULACIÓN A NIVEL TÉCNICO SUPERIOR", SIGLA = "GRT001" },
            new Materia { ID = 100, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "MODALIDAD DE TITULACIÓN LICENCIATURA", SIGLA = "GRL001" }

            // MATERIAS DE ROBÓTICA (CORREGIDAS)
            // new Materia { ID = 101, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "TALLER DE GRADO I", SIGLA = "INFST1" },
            // new Materia { ID = 102, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ROBÓTICA AVANZADA", SIGLA = "ROBM05" },
            // new Materia { ID = 103, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ROBOT OPERATING SYSTEM", SIGLA = "ROBM04" },
            // new Materia { ID = 104, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE CONTROL II", SIGLA = "ROBM03" },
            // new Materia { ID = 105, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "AUTOMATIZACIÓN Y CONTROL", SIGLA = "ROBM02" },
            // new Materia { ID = 106, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "VISIÓN COMPUTACIONAL", SIGLA = "ROBM07" },
            // new Materia { ID = 107, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ROBÓTICA INDUSTRIAL", SIGLA = "ROBM04" },
            // new Materia { ID = 108, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INTERNET DE LAS COSAS", SIGLA = "ROBM06" },
            // new Materia { ID = 109, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "TALLER DE CONTROL", SIGLA = "ROBM05" },
            // new Materia { ID = 110, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INSTRUMENTACIÓN INDUSTRIAL", SIGLA = "ELC202" },
            // new Materia { ID = 111, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "LIDERAZGO, EMPRENDIMIENTO Y STARTUPS", SIGLA = "MET200" },
            // new Materia { ID = 112, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS EMBEBIDOS", SIGLA = "ROBR203" },
            // new Materia { ID = 113, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE CONTROL I", SIGLA = "ROBR01" },
            // new Materia { ID = 114, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ACTUADORES Y SENSORES", SIGLA = "ROBR02" },
            // new Materia { ID = 115, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "PROCESAMIENTO DIGITAL DE SEÑALES", SIGLA = "ROBS20" },
            // new Materia { ID = 116, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "CIRCUITOS DIGITALES", SIGLA = "ROBR04" },
            // new Materia { ID = 117, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ELECTRÓNICO Y MAGNETISMO", SIGLA = "ROBR201" },
            // new Materia { ID = 118, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ANÁLISIS DE CIRCUITOS", SIGLA = "ROBS210" },
            // new Materia { ID = 119, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "DINÁMICA", SIGLA = "ROBR203" },
            // new Materia { ID = 120, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "TECNOLOGÍAS DE LA MANUFACTURA", SIGLA = "ROBR02" },
            // new Materia { ID = 121, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "ESTÁTICA", SIGLA = "ROBR03" },
            // new Materia { ID = 122, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "PENSAMIENTO CRÍTICO Y CREATIVO", SIGLA = "ROBR04" },
            // new Materia { ID = 123, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "INTRODUCCIÓN A LA ROBÓTICA", SIGLA = "ROBR01" },
            // new Materia { ID = 124, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "DIBUJO MECÁNICO EN CAD", SIGLA = "ROBR02" },
            // new Materia { ID = 125, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "METODOLOGÍA DE LA INVESTIGACIÓN", SIGLA = "MET100" },
            // new Materia { ID = 126, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "CIRCUITOS ELECTRÓNICOS I", SIGLA = "ELT352" },
            // new Materia { ID = 127, CREDITO = 5, ES_ELECTIVA = false, NOMBRE = "CIRCUITOS ELECTRÓNICOS II", SIGLA = "ELT352" }
            );
    }
}
