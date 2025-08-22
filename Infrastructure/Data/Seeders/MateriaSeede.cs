using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Seeders;

public class MateriaSeeder : IEntityTypeConfiguration<Materia>
{
    public void Configure(EntityTypeBuilder<Materia> builder)
    {
        builder.HasData(
            // 1 SEMESTRE
            new Materia { ID = 1, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INTRODUCCION A LA INFORMATICA", SIGLA = "INF110" },
            new Materia { ID = 2, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ESTRUCTURAS DISCRETAS", SIGLA = "INF119" },
            new Materia { ID = 3, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "FISICA I", SIGLA = "FIS100" },
            new Materia { ID = 4, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INGLES TECNICO I", SIGLA = "LIN100" },
            new Materia { ID = 5, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "CALCULO I", SIGLA = "MAT101" },

            // 2 SEMESTRE
            new Materia { ID = 6, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ALGEBRA LINEAL", SIGLA = "MAT103" },
            new Materia { ID = 7, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROGRAMACION I", SIGLA = "INF120" },
            new Materia { ID = 8, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "CALCULO I", SIGLA = "MAT102" },
            new Materia { ID = 9, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "FISICA II", SIGLA = "FIS102" },
            new Materia { ID = 10, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INGLES TECNICO II", SIGLA = "LIN101" },

            // 3 SEMESTRE
            new Materia { ID = 11, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ARQUITECTURA DE COMPUTADORAS", SIGLA = "INF211" },
            new Materia { ID = 12, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROGRAMACION II", SIGLA = "INF210" },
            new Materia { ID = 13, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ADMINISTRACION", SIGLA = "ADM100" },
            new Materia { ID = 14, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "FISICA III", SIGLA = "FIS200" },
            new Materia { ID = 15, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ECUACIONES DIFERENCIALES", SIGLA = "MAT207" },
            new Materia { ID = 16, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ANALISIS DE CIRCUITOS", SIGLA = "RDS210" },
            new Materia { ID = 17, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "TEORIA DE CAMPOS", SIGLA = "ELT241" },

            // 4 SEMESTRE
            new Materia { ID = 18, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROBABILIDAD Y ESTADISTICA I", SIGLA = "MAT202" },
            new Materia { ID = 19, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "CONTABILIDAD", SIGLA = "ADM200" },
            new Materia { ID = 20, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROGRAMACION ENSAMBLADOR", SIGLA = "INF221" },
            new Materia { ID = 21, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ESTRUCTURA DE DATOS I", SIGLA = "INF220" },
            new Materia { ID = 22, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "METODOS NUMERICOS", SIGLA = "MAT205" },
            new Materia { ID = 23, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ANALISIS DE CIRCUITOS ELECTRONICOS", SIGLA = "RDS220" },

            // 5 SEMESTRE
            new Materia { ID = 24, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "LENGUAJES FORMALES", SIGLA = "INF319" },
            new Materia { ID = 25, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROGRAMACION LOGICA Y FUNCIONAL", SIGLA = "INF318" },
            new Materia { ID = 26, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "BASE DE DATROS I", SIGLA = "INF312" },
            new Materia { ID = 27, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ESTRUCTURA DE DATOS II", SIGLA = "INF310" },
            new Materia { ID = 28, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PROBABILIDAD Y ESTADISTICA II", SIGLA = "MAT302" },
            new Materia { ID = 29, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ORGANIZACION Y METODOS", SIGLA = "ADM330" },
            new Materia { ID = 30, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ECONOMIA PARA LA GESTION", SIGLA = "ECO300" },
            new Materia { ID = 31, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS LOGICOS Y DIGITALES I", SIGLA = "ELT352" },
            new Materia { ID = 32, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ELECTRONICA APLICADA A REDES", SIGLA = "RDS310" },
            new Materia { ID = 33, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SEÑALES Y SISTEMAS", SIGLA = "ELT354" },

            // 6 SEMESTRE
            new Materia { ID = 34, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "BASE DE DATOS II", SIGLA = "INF322" },
            new Materia { ID = 35, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INVESTIGACION OPERATIVA I", SIGLA = "MAT329" },
            new Materia { ID = 36, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "COMPILADORES", SIGLA = "INF329" },
            new Materia { ID = 37, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS OPERATIVOS I", SIGLA = "INF323" },
            new Materia { ID = 38, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE INFORMACION I", SIGLA = "INF342" },
            new Materia { ID = 39, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "FINANZAS PARA LA EMPRESA", SIGLA = "ECO320" },
            new Materia { ID = 40, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS LOGICOS Y DIGITALES II", SIGLA = "ELT362" },
            new Materia { ID = 41, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INTERPRETACION DE SISTEMAS Y SEÑALES", SIGLA = "RDS320" },

            // 7 SEMESTRE
            new Materia { ID = 42, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "REDES I", SIGLA = "INF433" },
            new Materia { ID = 43, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS OPERATIVOS II", SIGLA = "INF413" },
            new Materia { ID = 44, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INTELIGENCIA ARTIFICIAL", SIGLA = "INF418" },
            new Materia { ID = 45, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE INFORMACION II", SIGLA = "INF412" },
            new Materia { ID = 46, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INVESTIGACION OPERATIVA II", SIGLA = "MAT419" },
            new Materia { ID = 47, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS PARA EL SOPORTE A LA TOMA DE DESICIONES", SIGLA = "INF432" },
            new Materia { ID = 48, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE COMUNICACION I", SIGLA = "ELT374" },
            new Materia { ID = 49, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "APPS CON MICROPROCESADORES", SIGLA = "RDS410" },

            // 8 SEMESTRE
            new Materia { ID = 50, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INGENIERIA DE SOFTWARE I", SIGLA = "INF422" },
            new Materia { ID = 51, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "REDES II", SIGLA = "INF423" },
            new Materia { ID = 52, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE INFORMACION GEOGRAFICA", SIGLA = "INF442" },
            new Materia { ID = 53, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "PREPARACION Y EVALUACION DE PROYECTO", SIGLA = "ECO449" },
            new Materia { ID = 54, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS EXPERTOS", SIGLA = "INF428" },
            new Materia { ID = 55, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "AUDITORIA INFORMATICA", SIGLA = "INF462" },
            new Materia { ID = 56, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "TALLER DE ANALISIS Y DESEÑO DE REDES", SIGLA = "RDS421" },
            new Materia { ID = 57, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SISTEMAS DE COMUNICACION II", SIGLA = "ELT384" },
            new Materia { ID = 58, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "LEGISLACION EN REDES Y COMUNICACIONES", SIGLA = "RDS429" },

            // 9 SEMESTRE
            new Materia { ID = 59, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "INGENIERIA DE SOFTWARE II", SIGLA = "INF512" },
            new Materia { ID = 60, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "ARQUITECTURA DE SOFTWARE", SIGLA = "INF552" },
            new Materia { ID = 61, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "TECNOLOGIA WEB", SIGLA = "INF513" },
            new Materia { ID = 62, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "TALLER DE GRADO I", SIGLA = "INF511" },
            new Materia { ID = 63, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "GESTION Y ADMINISTRACION DE REDES", SIGLA = "RDS511" },
            new Materia { ID = 64, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "REDES INALAMBRICAS Y COMUNICACIONES MOVILES", SIGLA = "RDS512" },
            new Materia { ID = 65, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "SEGURIDAD EN REDES Y TRANSMISION DE DATOS", SIGLA = "RDS519" },

            // 10 SEMESTRE
            new Materia { ID = 66, CREDITO = 10, ES_ELECTIVA = false, NOMBRE = "MODALIDAD DE GRADUACION ", SIGLA = "GRL001" },

            // ELECTIVAS INFORMATICA
            new Materia { ID = 67, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "MODELACION Y SIMULACION DE SISTEMAS", SIGLA = "ELC101" },
            new Materia { ID = 68, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "PROGRAMACION GRAFICA", SIGLA = "ELC102" },
            new Materia { ID = 69, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "TOPICOS AVANZADOS DE PROGRAMACION", SIGLA = "ELC103" },
            new Materia { ID = 70, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "PROGRAMACION DE APLICACIONES DE TIEMPO REAL", SIGLA = "ELC104" },
            new Materia { ID = 71, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "SISTEMAS DISTRIBUIDOS", SIGLA = "ELC105" },
            new Materia { ID = 72, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "INTERACCION HOMBRE COMPUTADOR", SIGLA = "ELC106" },
            new Materia { ID = 73, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "CRIPTOGRAFICA Y SEGURIDAD", SIGLA = "ELC107" },
            new Materia { ID = 74, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "CONTROL Y AUTOMATIZACION", SIGLA = "ELC108" },

            // ELECTIVAS REDES
            new Materia { ID = 75, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "DISEÑO DE CIRCUITOS INTEGRADOS", SIGLA = "ELC201" },
            new Materia { ID = 76, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "INSTRUMENTACION", SIGLA = "ELC202" },
            new Materia { ID = 77, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "SISTEMAS DE COMUNICACION SCADA", SIGLA = "ELC203" },
            new Materia { ID = 78, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "TELEVISION DIGITAL", SIGLA = "ELC204" },
            new Materia { ID = 79, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "DOMOTICA", SIGLA = "ELC205" },
            new Materia { ID = 80, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "LINEAS Y TRANSMISION DE ANTES", SIGLA = "ELC206" },
            new Materia { ID = 81, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "TECNICAS PARA PRESENTACION PARA INGENIERIA", SIGLA = "ELC207" },
            new Materia { ID = 82, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "REDES ADHOC", SIGLA = "ELC208" },

            // ELECTIVAS SISTEMAS
            new Materia { ID = 83, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "ADMINISTRACION DE RECURSOS HUMANOS", SIGLA = "ELC001" },
            new Materia { ID = 84, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "COSTOS Y PRESUPUESTOS", SIGLA = "ELC002" },
            new Materia { ID = 85, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "PRODUCCION Y MARKETING", SIGLA = "ELC003" },
            new Materia { ID = 86, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "REINGENIERIA", SIGLA = "ELC004" },
            new Materia { ID = 87, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "INGENIERIA DE CALIDAD", SIGLA = "ELC005" },
            new Materia { ID = 88, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "BENCHMARKING", SIGLA = "ELC006" },
            new Materia { ID = 89, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "INTRODUCCION A LA MACROECONOMIA", SIGLA = "ELC007" },
            new Materia { ID = 90, CREDITO = 10, ES_ELECTIVA = true, NOMBRE = "LEGISLACION EN CIENCIAS DE LA COMPUTACION", SIGLA = "ELC008" }
        );
    }
}
