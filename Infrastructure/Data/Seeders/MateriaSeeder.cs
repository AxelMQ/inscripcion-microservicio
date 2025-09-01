using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class MateriaSeeder : IEntityTypeConfiguration<Materia>
{
    public void Configure(EntityTypeBuilder<Materia> builder)
    {
        builder.HasData(
            // // 1 SEMESTRE
            // new Materia { Id = 1, Credito = 10, EsElectiva = false, Nombre = "INTRODUCCION A LA INFORMATICA", Sigla = "INF110" },
            // new Materia { Id = 2, Credito = 10, EsElectiva = false, Nombre = "ESTRUCTURAS DISCRETAS", Sigla = "INF119" },
            // new Materia { Id = 3, Credito = 10, EsElectiva = false, Nombre = "FISICA I", Sigla = "FIS100" },
            // new Materia { Id = 4, Credito = 10, EsElectiva = false, Nombre = "INGLES TECNICO I", Sigla = "LIN100" },
            // new Materia { Id = 5, Credito = 10, EsElectiva = false, Nombre = "CALCULO I", Sigla = "MAT101" },

            // // 2 SEMESTRE
            // new Materia { Id = 6, Credito = 10, EsElectiva = false, Nombre = "ALGEBRA LINEAL", Sigla = "MAT103" },
            // new Materia { Id = 7, Credito = 10, EsElectiva = false, Nombre = "PROGRAMACION I", Sigla = "INF120" },
            // new Materia { Id = 8, Credito = 10, EsElectiva = false, Nombre = "CALCULO I", Sigla = "MAT102" },
            // new Materia { Id = 9, Credito = 10, EsElectiva = false, Nombre = "FISICA II", Sigla = "FIS102" },
            // new Materia { Id = 10, Credito = 10, EsElectiva = false, Nombre = "INGLES TECNICO II", Sigla = "LIN101" },

            // // 3 SEMESTRE
            // new Materia { Id = 11, Credito = 10, EsElectiva = false, Nombre = "ARQUITECTURA DE COMPUTADORAS", Sigla = "INF211" },
            // new Materia { Id = 12, Credito = 10, EsElectiva = false, Nombre = "PROGRAMACION II", Sigla = "INF210" },
            // new Materia { Id = 13, Credito = 10, EsElectiva = false, Nombre = "ADMINISTRACION", Sigla = "ADM100" },
            // new Materia { Id = 14, Credito = 10, EsElectiva = false, Nombre = "FISICA III", Sigla = "FIS200" },
            // new Materia { Id = 15, Credito = 10, EsElectiva = false, Nombre = "ECUACIONES DIFERENCIALES", Sigla = "MAT207" },
            // new Materia { Id = 16, Credito = 10, EsElectiva = false, Nombre = "ANALISIS DE CIRCUITOS", Sigla = "RDS210" },
            // new Materia { Id = 17, Credito = 10, EsElectiva = false, Nombre = "TEORIA DE CAMPOS", Sigla = "ELT241" },

            // // 4 SEMESTRE
            // new Materia { Id = 18, Credito = 10, EsElectiva = false, Nombre = "PROBABILIDAD Y ESTADISTICA I", Sigla = "MAT202" },
            // new Materia { Id = 19, Credito = 10, EsElectiva = false, Nombre = "CONTABILIDAD", Sigla = "ADM200" },
            // new Materia { Id = 20, Credito = 10, EsElectiva = false, Nombre = "PROGRAMACION ENSAMBLADOR", Sigla = "INF221" },
            // new Materia { Id = 21, Credito = 10, EsElectiva = false, Nombre = "ESTRUCTURA DE DATOS I", Sigla = "INF220" },
            // new Materia { Id = 22, Credito = 10, EsElectiva = false, Nombre = "METODOS NUMERICOS", Sigla = "MAT205" },
            // new Materia { Id = 23, Credito = 10, EsElectiva = false, Nombre = "ANALISIS DE CIRCUITOS ELECTRONICOS", Sigla = "RDS220" },

            // // 5 SEMESTRE
            // new Materia { Id = 24, Credito = 10, EsElectiva = false, Nombre = "LENGUAJES FORMALES", Sigla = "INF319" },
            // new Materia { Id = 25, Credito = 10, EsElectiva = false, Nombre = "PROGRAMACION LOGICA Y FUNCIONAL", Sigla = "INF318" },
            // new Materia { Id = 26, Credito = 10, EsElectiva = false, Nombre = "BASE DE DATROS I", Sigla = "INF312" },
            // new Materia { Id = 27, Credito = 10, EsElectiva = false, Nombre = "ESTRUCTURA DE DATOS II", Sigla = "INF310" },
            // new Materia { Id = 28, Credito = 10, EsElectiva = false, Nombre = "PROBABILIDAD Y ESTADISTICA II", Sigla = "MAT302" },
            // new Materia { Id = 29, Credito = 10, EsElectiva = false, Nombre = "ORGANIZACION Y METODOS", Sigla = "ADM330" },
            // new Materia { Id = 30, Credito = 10, EsElectiva = false, Nombre = "ECONOMIA PARA LA GESTION", Sigla = "ECO300" },
            // new Materia { Id = 31, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS LOGICOS Y DIGITALES I", Sigla = "ELT352" },
            // new Materia { Id = 32, Credito = 10, EsElectiva = false, Nombre = "ELECTRONICA APLICADA A REDES", Sigla = "RDS310" },
            // new Materia { Id = 33, Credito = 10, EsElectiva = false, Nombre = "SEÑALES Y SISTEMAS", Sigla = "ELT354" },

            // // 6 SEMESTRE
            // new Materia { Id = 34, Credito = 10, EsElectiva = false, Nombre = "BASE DE DATOS II", Sigla = "INF322" },
            // new Materia { Id = 35, Credito = 10, EsElectiva = false, Nombre = "INVESTIGACION OPERATIVA I", Sigla = "MAT329" },
            // new Materia { Id = 36, Credito = 10, EsElectiva = false, Nombre = "COMPILADORES", Sigla = "INF329" },
            // new Materia { Id = 37, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS OPERATIVOS I", Sigla = "INF323" },
            // new Materia { Id = 38, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS DE INFORMACION I", Sigla = "INF342" },
            // new Materia { Id = 39, Credito = 10, EsElectiva = false, Nombre = "FINANZAS PARA LA EMPRESA", Sigla = "ECO320" },
            // new Materia { Id = 40, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS LOGICOS Y DIGITALES II", Sigla = "ELT362" },
            // new Materia { Id = 41, Credito = 10, EsElectiva = false, Nombre = "INTERPRETACION DE SISTEMAS Y SEÑALES", Sigla = "RDS320" },

            // // 7 SEMESTRE
            // new Materia { Id = 42, Credito = 10, EsElectiva = false, Nombre = "REDES I", Sigla = "INF433" },
            // new Materia { Id = 43, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS OPERATIVOS II", Sigla = "INF413" },
            // new Materia { Id = 44, Credito = 10, EsElectiva = false, Nombre = "INTELIGENCIA ARTIFICIAL", Sigla = "INF418" },
            // new Materia { Id = 45, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS DE INFORMACION II", Sigla = "INF412" },
            // new Materia { Id = 46, Credito = 10, EsElectiva = false, Nombre = "INVESTIGACION OPERATIVA II", Sigla = "MAT419" },
            // new Materia { Id = 47, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS PARA EL SOPORTE A LA TOMA DE DESICIONES", Sigla = "INF432" },
            // new Materia { Id = 48, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS DE COMUNICACION I", Sigla = "ELT374" },
            // new Materia { Id = 49, Credito = 10, EsElectiva = false, Nombre = "APPS CON MICROPROCESADORES", Sigla = "RDS410" },

            // // 8 SEMESTRE
            // new Materia { Id = 50, Credito = 10, EsElectiva = false, Nombre = "INGENIERIA DE SOFTWARE I", Sigla = "INF422" },
            // new Materia { Id = 51, Credito = 10, EsElectiva = false, Nombre = "REDES II", Sigla = "INF423" },
            // new Materia { Id = 52, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS DE INFORMACION GEOGRAFICA", Sigla = "INF442" },
            // new Materia { Id = 53, Credito = 10, EsElectiva = false, Nombre = "PREPARACION Y EVALUACION DE PROYECTO", Sigla = "ECO449" },
            // new Materia { Id = 54, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS EXPERTOS", Sigla = "INF428" },
            // new Materia { Id = 55, Credito = 10, EsElectiva = false, Nombre = "AUDITORIA INFORMATICA", Sigla = "INF462" },
            // new Materia { Id = 56, Credito = 10, EsElectiva = false, Nombre = "TALLER DE ANALISIS Y DESEÑO DE REDES", Sigla = "RDS421" },
            // new Materia { Id = 57, Credito = 10, EsElectiva = false, Nombre = "SISTEMAS DE COMUNICACION II", Sigla = "ELT384" },
            // new Materia { Id = 58, Credito = 10, EsElectiva = false, Nombre = "LEGISLACION EN REDES Y COMUNICACIONES", Sigla = "RDS429" },

            // // 9 SEMESTRE
            // new Materia { Id = 59, Credito = 10, EsElectiva = false, Nombre = "INGENIERIA DE SOFTWARE II", Sigla = "INF512" },
            // new Materia { Id = 60, Credito = 10, EsElectiva = false, Nombre = "ARQUITECTURA DE SOFTWARE", Sigla = "INF552" },
            // new Materia { Id = 61, Credito = 10, EsElectiva = false, Nombre = "TECNOLOGIA WEB", Sigla = "INF513" },
            // new Materia { Id = 62, Credito = 10, EsElectiva = false, Nombre = "TALLER DE GRADO I", Sigla = "INF511" },
            // new Materia { Id = 63, Credito = 10, EsElectiva = false, Nombre = "GESTION Y ADMINISTRACION DE REDES", Sigla = "RDS511" },
            // new Materia { Id = 64, Credito = 10, EsElectiva = false, Nombre = "REDES INALAMBRICAS Y COMUNICACIONES MOVILES", Sigla = "RDS512" },
            // new Materia { Id = 65, Credito = 10, EsElectiva = false, Nombre = "SEGURIDAD EN REDES Y TRANSMISION DE DATOS", Sigla = "RDS519" },

            // // 10 SEMESTRE
            // new Materia { Id = 66, Credito = 10, EsElectiva = false, Nombre = "MODALIDAD DE GRADUACION ", Sigla = "GRL001" },

            // // ELECTIVAS INFORMATICA
            // new Materia { Id = 67, Credito = 10, EsElectiva = true, Nombre = "MODELACION Y SIMULACION DE SISTEMAS", Sigla = "ELC101" },
            // new Materia { Id = 68, Credito = 10, EsElectiva = true, Nombre = "PROGRAMACION GRAFICA", Sigla = "ELC102" },
            // new Materia { Id = 69, Credito = 10, EsElectiva = true, Nombre = "TOPICOS AVANZADOS DE PROGRAMACION", Sigla = "ELC103" },
            // new Materia { Id = 70, Credito = 10, EsElectiva = true, Nombre = "PROGRAMACION DE APLICACIONES DE TIEMPO REAL", Sigla = "ELC104" },
            // new Materia { Id = 71, Credito = 10, EsElectiva = true, Nombre = "SISTEMAS DISTRIBUIDOS", Sigla = "ELC105" },
            // new Materia { Id = 72, Credito = 10, EsElectiva = true, Nombre = "INTERACCION HOMBRE COMPUTADOR", Sigla = "ELC106" },
            // new Materia { Id = 73, Credito = 10, EsElectiva = true, Nombre = "CRIPTOGRAFICA Y SEGURIDAD", Sigla = "ELC107" },
            // new Materia { Id = 74, Credito = 10, EsElectiva = true, Nombre = "CONTROL Y AUTOMATIZACION", Sigla = "ELC108" },

            // // ELECTIVAS REDES
            // new Materia { Id = 75, Credito = 10, EsElectiva = true, Nombre = "DISEÑO DE CIRCUITOS INTEGRADOS", Sigla = "ELC201" },
            // new Materia { Id = 76, Credito = 10, EsElectiva = true, Nombre = "INSTRUMENTACION", Sigla = "ELC202" },
            // new Materia { Id = 77, Credito = 10, EsElectiva = true, Nombre = "SISTEMAS DE COMUNICACION SCADA", Sigla = "ELC203" },
            // new Materia { Id = 78, Credito = 10, EsElectiva = true, Nombre = "TELEVISION DIGITAL", Sigla = "ELC204" },
            // new Materia { Id = 79, Credito = 10, EsElectiva = true, Nombre = "DOMOTICA", Sigla = "ELC205" },
            // new Materia { Id = 80, Credito = 10, EsElectiva = true, Nombre = "LINEAS Y TRANSMISION DE ANTES", Sigla = "ELC206" },
            // new Materia { Id = 81, Credito = 10, EsElectiva = true, Nombre = "TECNICAS PARA PRESENTACION PARA INGENIERIA", Sigla = "ELC207" },
            // new Materia { Id = 82, Credito = 10, EsElectiva = true, Nombre = "REDES ADHOC", Sigla = "ELC208" },

            // // ELECTIVAS SISTEMAS
            // new Materia { Id = 83, Credito = 10, EsElectiva = true, Nombre = "ADMINISTRACION DE RECURSOS HUMANOS", Sigla = "ELC001" },
            // new Materia { Id = 84, Credito = 10, EsElectiva = true, Nombre = "COSTOS Y PRESUPUESTOS", Sigla = "ELC002" },
            // new Materia { Id = 85, Credito = 10, EsElectiva = true, Nombre = "PRODUCCION Y MARKETING", Sigla = "ELC003" },
            // new Materia { Id = 86, Credito = 10, EsElectiva = true, Nombre = "REINGENIERIA", Sigla = "ELC004" },
            // new Materia { Id = 87, Credito = 10, EsElectiva = true, Nombre = "INGENIERIA DE CALIDAD", Sigla = "ELC005" },
            // new Materia { Id = 88, Credito = 10, EsElectiva = true, Nombre = "BENCHMARKING", Sigla = "ELC006" },
            // new Materia { Id = 89, Credito = 10, EsElectiva = true, Nombre = "INTRODUCCION A LA MACROECONOMIA", Sigla = "ELC007" },
            // new Materia { Id = 90, Credito = 10, EsElectiva = true, Nombre = "LEGISLACION EN CIENCIAS DE LA COMPUTACION", Sigla = "ELC008" }

            // SEMESTRE 1 - MATERIAS COMUNES
            new Materia { Id = 1, Credito = 5, EsElectiva = false, Nombre = "CÁLCULO I", Sigla = "MAT101" },
            new Materia { Id = 2, Credito = 5, EsElectiva = false, Nombre = "ESTRUCTURAS DISCRETAS", Sigla = "INF119" },
            new Materia { Id = 3, Credito = 5, EsElectiva = false, Nombre = "INTRODUCCIÓN A LA INFORMÁTICA", Sigla = "INF110" },
            new Materia { Id = 4, Credito = 5, EsElectiva = false, Nombre = "FÍSICA I", Sigla = "FIS100" },
            new Materia { Id = 5, Credito = 5, EsElectiva = false, Nombre = "INGLÉS TÉCNICO I", Sigla = "LIN100" },

            // SEMESTRE 2 - MATERIAS COMUNES
            new Materia { Id = 6, Credito = 5, EsElectiva = false, Nombre = "CÁLCULO II", Sigla = "MAT102" },
            new Materia { Id = 7, Credito = 5, EsElectiva = false, Nombre = "ÁLGEBRA LINEAL", Sigla = "MAT103" },
            new Materia { Id = 8, Credito = 5, EsElectiva = false, Nombre = "PROGRAMACIÓN I", Sigla = "INF120" },
            new Materia { Id = 9, Credito = 5, EsElectiva = false, Nombre = "FÍSICA II", Sigla = "FIS102" },
            new Materia { Id = 10, Credito = 5, EsElectiva = false, Nombre = "INGLÉS TÉCNICO II", Sigla = "LIN101" },

            // SEMESTRE 3 - MATERIAS COMUNES
            new Materia { Id = 11, Credito = 5, EsElectiva = false, Nombre = "ECUACIONES DIFERENCIALES", Sigla = "MAT207" },
            new Materia { Id = 12, Credito = 5, EsElectiva = false, Nombre = "PROGRAMACIÓN II", Sigla = "INF210" },
            new Materia { Id = 13, Credito = 5, EsElectiva = false, Nombre = "ARQUITECTURA DE COMPUTADORAS", Sigla = "INF211" },
            new Materia { Id = 14, Credito = 6, EsElectiva = false, Nombre = "FÍSICA III", Sigla = "FIS200" },
            new Materia { Id = 15, Credito = 4, EsElectiva = false, Nombre = "ADMINISTRACIÓN", Sigla = "ADM100" },

            // SEMESTRE 4 - MATERIAS COMUNES
            new Materia { Id = 16, Credito = 5, EsElectiva = false, Nombre = "PROBABILIDAD Y ESTADÍSTICA I", Sigla = "MAT202" },
            new Materia { Id = 17, Credito = 5, EsElectiva = false, Nombre = "MÉTODOS NUMÉRICOS", Sigla = "MAT205" },
            new Materia { Id = 18, Credito = 5, EsElectiva = false, Nombre = "ESTRUCTURA DE DATOS I", Sigla = "INF220" },
            new Materia { Id = 19, Credito = 5, EsElectiva = false, Nombre = "PROGRAMACIÓN ENSAMBLADOR", Sigla = "INF221" },
            new Materia { Id = 20, Credito = 4, EsElectiva = false, Nombre = "CONTABILIDAD", Sigla = "ADM200" },

            // SEMESTRE 5 - INFORMÁTICA/SISTEMAS
            new Materia { Id = 21, Credito = 5, EsElectiva = false, Nombre = "PROBABILIDAD Y ESTADÍSTICA II", Sigla = "MAT302" },
            new Materia { Id = 22, Credito = 5, EsElectiva = false, Nombre = "PROGRAMACIÓN LÓGICA Y FUNCIONAL", Sigla = "INF318" },
            new Materia { Id = 23, Credito = 5, EsElectiva = false, Nombre = "ESTRUCTURA DE DATOS II", Sigla = "INF310" },
            new Materia { Id = 24, Credito = 5, EsElectiva = false, Nombre = "BASE DE DATOS I", Sigla = "INF312" },
            new Materia { Id = 25, Credito = 5, EsElectiva = false, Nombre = "LENGUAJES FORMALES", Sigla = "INF319" },

            // SEMESTRE 5 - SISTEMAS (ESPECÍFICAS)
            new Materia { Id = 53, Credito = 5, EsElectiva = false, Nombre = "ORGANIZACIÓN Y MÉTODOS", Sigla = "ADM330" },
            new Materia { Id = 54, Credito = 5, EsElectiva = false, Nombre = "ECONOMÍA PARA LA GESTIÓN", Sigla = "ECO300" },

            // SEMESTRE 6 - INFORMÁTICA/SISTEMAS
            new Materia { Id = 26, Credito = 5, EsElectiva = false, Nombre = "INVESTIGACIÓN OPERATIVA I", Sigla = "MAT329" },
            new Materia { Id = 27, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS DE INFORMACIÓN I", Sigla = "INF342" },
            new Materia { Id = 28, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS OPERATIVOS I", Sigla = "INF323" },
            new Materia { Id = 29, Credito = 5, EsElectiva = false, Nombre = "BASE DE DATOS II", Sigla = "INF322" },
            new Materia { Id = 30, Credito = 5, EsElectiva = false, Nombre = "COMPILADORES", Sigla = "INF329" },

            // SEMESTRE 6 - SISTEMAS (ESPECÍFICA)
            new Materia { Id = 55, Credito = 5, EsElectiva = false, Nombre = "FINANZAS PARA LA EMPRESA", Sigla = "ADM320" },

            // SEMESTRE 7 - INFORMÁTICA/SISTEMAS
            new Materia { Id = 31, Credito = 5, EsElectiva = false, Nombre = "INVESTIGACIÓN OPERATIVA II", Sigla = "MAT419" },
            new Materia { Id = 32, Credito = 5, EsElectiva = false, Nombre = "INTELIGENCIA ARTIFICIAL", Sigla = "INF418" },
            new Materia { Id = 33, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS OPERATIVOS II", Sigla = "INF413" },
            new Materia { Id = 34, Credito = 5, EsElectiva = false, Nombre = "REDES I", Sigla = "INF433" },
            new Materia { Id = 35, Credito = 5, EsElectiva = false, Nombre = "INGENIERÍA DE SOFTWARE I", Sigla = "INF422" },

            // SEMESTRE 7 - SISTEMAS (ESPECÍFICA)
            new Materia { Id = 56, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS PARA EL SOPORTE A LA TOMA DE DECISIONES", Sigla = "INF432" },

            // SEMESTRE 8 - INFORMÁTICA/SISTEMAS
            new Materia { Id = 36, Credito = 5, EsElectiva = false, Nombre = "PREPARACIÓN Y EVALUACIÓN DE PROYECTOS", Sigla = "ECO449" },
            new Materia { Id = 37, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS EXPERTOS", Sigla = "INF428" },
            new Materia { Id = 38, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS DE INFORMACIÓN II", Sigla = "INF412" },
            new Materia { Id = 39, Credito = 5, EsElectiva = false, Nombre = "REDES II", Sigla = "INF423" },
            new Materia { Id = 40, Credito = 5, EsElectiva = false, Nombre = "INGENIERÍA DE SOFTWARE II", Sigla = "INF512" },

            // SEMESTRE 8 - SISTEMAS (ESPECÍFICA)
            new Materia { Id = 57, Credito = 4, EsElectiva = false, Nombre = "AUDITORÍA INFORMÁTICA", Sigla = "INF462" },

            // SEMESTRE 9 - INFORMÁTICA
            new Materia { Id = 41, Credito = 5, EsElectiva = false, Nombre = "TALLER DE GRADO I", Sigla = "INF511" },
            new Materia { Id = 42, Credito = 5, EsElectiva = false, Nombre = "TECNOLOGÍA WEB", Sigla = "INF513" },
            new Materia { Id = 43, Credito = 4, EsElectiva = false, Nombre = "ARQUITECTURA DE SOFTWARE", Sigla = "INF552" },
            new Materia { Id = 44, Credito = 4, EsElectiva = false, Nombre = "SISTEMAS DE INFORMACIÓN GEOGRÁFICA", Sigla = "INF442" },

            // MATERIA DE GRADUACIÓN
            new Materia { Id = 58, Credito = 5, EsElectiva = false, Nombre = "MODALIDAD DE GRADUACIÓN", Sigla = "GRLO01" },

            // MATERIAS ELECTIVAS INFORMÁTICA
            new Materia { Id = 59, Credito = 10, EsElectiva = true, Nombre = "MODELACIÓN Y SIMULACIÓN DE SISTEMAS", Sigla = "ELCI01" },
            new Materia { Id = 60, Credito = 10, EsElectiva = true, Nombre = "PROGRAMACIÓN GRÁFICA", Sigla = "ELCI02" },
            new Materia { Id = 61, Credito = 10, EsElectiva = true, Nombre = "TÓPICOS AVANZADOS DE PROGRAMACIÓN", Sigla = "ELCI03" },
            new Materia { Id = 62, Credito = 10, EsElectiva = true, Nombre = "PROGRAMACIÓN DE APLICACIONES DE TIEMPO REAL", Sigla = "ELCI04" },
            new Materia { Id = 63, Credito = 10, EsElectiva = true, Nombre = "SISTEMAS DISTRIBUIDOS", Sigla = "ELCI05" },
            new Materia { Id = 64, Credito = 10, EsElectiva = true, Nombre = "INTERACCIÓN HOMBRE COMPUTADOR", Sigla = "ELCI06" },
            new Materia { Id = 65, Credito = 10, EsElectiva = true, Nombre = "CRIPTOGRAFÍA Y SEGURIDAD", Sigla = "ELCI07" },
            new Materia { Id = 66, Credito = 10, EsElectiva = true, Nombre = "CONTROL AND AUTOMATIZACIÓN", Sigla = "ELCI08" },

            // MATERIAS ELECTIVAS SISTEMAS
            new Materia { Id = 67, Credito = 3, EsElectiva = true, Nombre = "ADMINISTRACIÓN DE RECURSOS HUMANOS", Sigla = "ELC001" },
            new Materia { Id = 68, Credito = 3, EsElectiva = true, Nombre = "COSTOS Y PRESUPUESTOS", Sigla = "ELC002" },
            new Materia { Id = 69, Credito = 3, EsElectiva = true, Nombre = "PRODUCCIÓN Y MARKETING", Sigla = "ELC003" },
            new Materia { Id = 70, Credito = 3, EsElectiva = true, Nombre = "REINGENIERÍA", Sigla = "ELC004" },
            new Materia { Id = 71, Credito = 3, EsElectiva = true, Nombre = "INGENIERÍA DE LA CALIDAD", Sigla = "ELC005" },
            new Materia { Id = 72, Credito = 3, EsElectiva = true, Nombre = "BENCHMARKING", Sigla = "ELC006" },
            new Materia { Id = 73, Credito = 3, EsElectiva = true, Nombre = "INTRODUCCIÓN A LA MACROECONOMÍA", Sigla = "ELC007" },
            new Materia { Id = 74, Credito = 3, EsElectiva = true, Nombre = "LEGISLACIÓN EN CIENCIAS DE LA COMPUTACIÓN", Sigla = "ELC008" },

            // MATERIAS DE REDES (CORREGIDAS)
            new Materia { Id = 75, Credito = 5, EsElectiva = false, Nombre = "ANÁLISIS DE CIRCUITOS", Sigla = "RDS210" },
            new Materia { Id = 76, Credito = 5, EsElectiva = false, Nombre = "TEORÍA DE CAMPOS", Sigla = "ELT241" },
            new Materia { Id = 77, Credito = 4, EsElectiva = false, Nombre = "ANÁLISIS DE CIRCUITOS ELECTRÓNICOS", Sigla = "RDS220" },
            new Materia { Id = 78, Credito = 5, EsElectiva = false, Nombre = "ELECTRÓNICA APLICADA A REDES", Sigla = "RDS310" },
            new Materia { Id = 79, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS LÓGICOS Y DIGITALES I", Sigla = "ELT352" },
            new Materia { Id = 80, Credito = 5, EsElectiva = false, Nombre = "SEÑALES Y SISTEMAS", Sigla = "ELT354" },
            new Materia { Id = 81, Credito = 5, EsElectiva = true, Nombre = "DISEÑO DE CIRCUITOS INTEGRADOS", Sigla = "ELC201" },
            new Materia { Id = 82, Credito = 5, EsElectiva = true, Nombre = "INSTRUMENTACIÓN", Sigla = "ELC202" },

            //SEMESTRE 6
            new Materia { Id = 83, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS LÓGICOS Y DIGITALES II", Sigla = "ELT362" },
            new Materia { Id = 84, Credito = 5, EsElectiva = false, Nombre = "INTERPRETACIÓN DE SISTEMAS Y SEÑALES", Sigla = "RDS320" },
            new Materia { Id = 85, Credito = 5, EsElectiva = true, Nombre = "SISTEMAS DE COMUNICACIÓN SCADA", Sigla = "ELC203" },
            new Materia { Id = 86, Credito = 5, EsElectiva = true, Nombre = "TELEVISIÓN DIGITAL", Sigla = "ELC204" },

            //SEMESTRE 7
            new Materia { Id = 87, Credito = 5, EsElectiva = false, Nombre = "APLICACIONES CON MICROPROCESADORES", Sigla = "RDS410" },
            new Materia { Id = 88, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS DE COMUNICACIÓN I", Sigla = "ELT374" },
            new Materia { Id = 89, Credito = 5, EsElectiva = true, Nombre = "DOMÓTICA", Sigla = "ELC205" },
            new Materia { Id = 90, Credito = 5, EsElectiva = false, Nombre = "LÍNEAS DE TRANSMISIÓN Y ANTENAS", Sigla = "ELC206" },

            //SEMESTRE 8
            new Materia { Id = 91, Credito = 5, EsElectiva = false, Nombre = "TALLER DE ANÁLISIS Y DISEÑO DE REDES", Sigla = "RDS421" },
            new Materia { Id = 92, Credito = 5, EsElectiva = false, Nombre = "LEGISLACIÓN EN REDES Y COMUNICACIONES", Sigla = "RS429" },
            new Materia { Id = 93, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS DE COMUNICACIÓN II", Sigla = "ELC384" },
            new Materia { Id = 94, Credito = 5, EsElectiva = true, Nombre = "TÉCNICAS DE PRESENTACIÓN PARA INGENIERÍA", Sigla = "ELC207" },
            new Materia { Id = 95, Credito = 5, EsElectiva = true, Nombre = "REDES ADHOC", Sigla = "ELC208" },

            //SEMESTRE 9
            new Materia { Id = 96, Credito = 5, EsElectiva = false, Nombre = "GESTIÓN Y ADMINISTRACIÓN DE REDES", Sigla = "RDS511" },
            new Materia { Id = 97, Credito = 5, EsElectiva = false, Nombre = "REDES INALÁMBRICAS Y COMUNICACIONES MÓVILES", Sigla = "RDS512" },
            new Materia { Id = 98, Credito = 5, EsElectiva = false, Nombre = "SEGURIDAD EN REDES Y TRANSMISIÓN DE DATOS", Sigla = "RDS519" },

            // MATERIAS DE TITULACIÓN
            new Materia { Id = 99, Credito = 5, EsElectiva = false, Nombre = "MODALIDAD DE TITULACIÓN A NIVEL TÉCNICO SUPERIOR", Sigla = "GRT001" },
            new Materia { Id = 100, Credito = 5, EsElectiva = false, Nombre = "MODALIDAD DE TITULACIÓN LICENCIATURA", Sigla = "GRL001" }

            // MATERIAS DE ROBÓTICA (CORREGIDAS)
            // new Materia { Id = 101, Credito = 5, EsElectiva = false, Nombre = "TALLER DE GRADO I", Sigla = "INFST1" },
            // new Materia { Id = 102, Credito = 5, EsElectiva = false, Nombre = "ROBÓTICA AVANZADA", Sigla = "ROBM05" },
            // new Materia { Id = 103, Credito = 5, EsElectiva = false, Nombre = "ROBOT OPERATING SYSTEM", Sigla = "ROBM04" },
            // new Materia { Id = 104, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS DE CONTROL II", Sigla = "ROBM03" },
            // new Materia { Id = 105, Credito = 5, EsElectiva = false, Nombre = "AUTOMATIZACIÓN Y CONTROL", Sigla = "ROBM02" },
            // new Materia { Id = 106, Credito = 5, EsElectiva = false, Nombre = "VISIÓN COMPUTACIONAL", Sigla = "ROBM07" },
            // new Materia { Id = 107, Credito = 5, EsElectiva = false, Nombre = "ROBÓTICA INDUSTRIAL", Sigla = "ROBM04" },
            // new Materia { Id = 108, Credito = 5, EsElectiva = false, Nombre = "INTERNET DE LAS COSAS", Sigla = "ROBM06" },
            // new Materia { Id = 109, Credito = 5, EsElectiva = false, Nombre = "TALLER DE CONTROL", Sigla = "ROBM05" },
            // new Materia { Id = 110, Credito = 5, EsElectiva = false, Nombre = "INSTRUMENTACIÓN INDUSTRIAL", Sigla = "ELC202" },
            // new Materia { Id = 111, Credito = 5, EsElectiva = false, Nombre = "LIDERAZGO, EMPRENDIMIENTO Y STARTUPS", Sigla = "MET200" },
            // new Materia { Id = 112, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS EMBEBIDOS", Sigla = "ROBR203" },
            // new Materia { Id = 113, Credito = 5, EsElectiva = false, Nombre = "SISTEMAS DE CONTROL I", Sigla = "ROBR01" },
            // new Materia { Id = 114, Credito = 5, EsElectiva = false, Nombre = "ACTUADORES Y SENSORES", Sigla = "ROBR02" },
            // new Materia { Id = 115, Credito = 5, EsElectiva = false, Nombre = "PROCESAMIENTO DIGITAL DE SEÑALES", Sigla = "ROBS20" },
            // new Materia { Id = 116, Credito = 5, EsElectiva = false, Nombre = "CIRCUITOS DIGITALES", Sigla = "ROBR04" },
            // new Materia { Id = 117, Credito = 5, EsElectiva = false, Nombre = "ELECTRÓNICO Y MAGNETISMO", Sigla = "ROBR201" },
            // new Materia { Id = 118, Credito = 5, EsElectiva = false, Nombre = "ANÁLISIS DE CIRCUITOS", Sigla = "ROBS210" },
            // new Materia { Id = 119, Credito = 5, EsElectiva = false, Nombre = "DINÁMICA", Sigla = "ROBR203" },
            // new Materia { Id = 120, Credito = 5, EsElectiva = false, Nombre = "TECNOLOGÍAS DE LA MANUFACTURA", Sigla = "ROBR02" },
            // new Materia { Id = 121, Credito = 5, EsElectiva = false, Nombre = "ESTÁTICA", Sigla = "ROBR03" },
            // new Materia { Id = 122, Credito = 5, EsElectiva = false, Nombre = "PENSAMIENTO CRÍTICO Y CREATIVO", Sigla = "ROBR04" },
            // new Materia { Id = 123, Credito = 5, EsElectiva = false, Nombre = "INTRODUCCIÓN A LA ROBÓTICA", Sigla = "ROBR01" },
            // new Materia { Id = 124, Credito = 5, EsElectiva = false, Nombre = "DIBUJO MECÁNICO EN CAD", Sigla = "ROBR02" },
            // new Materia { Id = 125, Credito = 5, EsElectiva = false, Nombre = "METODOLOGÍA DE LA INVESTIGACIÓN", Sigla = "MET100" },
            // new Materia { Id = 126, Credito = 5, EsElectiva = false, Nombre = "CIRCUITOS ELECTRÓNICOS I", Sigla = "ELT352" },
            // new Materia { Id = 127, Credito = 5, EsElectiva = false, Nombre = "CIRCUITOS ELECTRÓNICOS II", Sigla = "ELT352" }
            );
    }
}
