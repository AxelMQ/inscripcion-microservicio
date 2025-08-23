using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ALUMNO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOMBRE = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    PPA = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    TELEFONO = table.Column<int>(type: "integer", nullable: true),
                    REGISTRO = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALUMNO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CARRERA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CODIGO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    MODALIDAD = table.Column<short>(type: "smallint", nullable: false),
                    NOMBRE = table.Column<string>(type: "character varying(63)", maxLength: 63, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARRERA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DIA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOMBRE = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DOCENTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOMBRE = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    TELEFONO = table.Column<long>(type: "bigint", nullable: true),
                    CI = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOCENTE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GESTION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOMBRE = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GESTION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GRUPO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOMBRE = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRUPO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HORA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HR_INICIO = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    HR_FIN = table.Column<TimeOnly>(type: "time without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HORA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HORARIO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HORARIO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MATERIA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CREDITO = table.Column<short>(type: "smallint", nullable: false),
                    ES_ELECTIVA = table.Column<bool>(type: "boolean", nullable: true),
                    NOMBRE = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SIGLA = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MATERIA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MODULO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NRO_MODULO = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MODULO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NIVEL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOMBRE = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NIVEL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INSCRIPCION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FECHA = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ALUMNO_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSCRIPCION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_INSCRIPCION_ALUMNO_ALUMNO_ID",
                        column: x => x.ALUMNO_ID,
                        principalTable: "ALUMNO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PLAN_ESTUDIO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CODIGO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    CARRERA_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLAN_ESTUDIO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PLAN_ESTUDIO_CARRERA_CARRERA_ID",
                        column: x => x.CARRERA_ID,
                        principalTable: "CARRERA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HORA_DIA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DIA_ID = table.Column<int>(type: "integer", nullable: false),
                    HORA_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HORA_DIA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HORA_DIA_DIA_DIA_ID",
                        column: x => x.DIA_ID,
                        principalTable: "DIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HORA_DIA_HORA_HORA_ID",
                        column: x => x.HORA_ID,
                        principalTable: "HORA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GRUPO_MATERIA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GRUPO_ID = table.Column<int>(type: "integer", nullable: false),
                    MATERIA_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRUPO_MATERIA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GRUPO_MATERIA_GRUPO_GRUPO_ID",
                        column: x => x.GRUPO_ID,
                        principalTable: "GRUPO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GRUPO_MATERIA_MATERIA_MATERIA_ID",
                        column: x => x.MATERIA_ID,
                        principalTable: "MATERIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MATERIA_PLAN_ESTUDIO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MATERIA_ID = table.Column<int>(type: "integer", nullable: false),
                    NIVEL_ID = table.Column<int>(type: "integer", nullable: false),
                    PLAN_ESTUDIO_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MATERIA_PLAN_ESTUDIO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MATERIA_PLAN_ESTUDIO_MATERIA_MATERIA_ID",
                        column: x => x.MATERIA_ID,
                        principalTable: "MATERIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MATERIA_PLAN_ESTUDIO_NIVEL_NIVEL_ID",
                        column: x => x.NIVEL_ID,
                        principalTable: "NIVEL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MATERIA_PLAN_ESTUDIO_PLAN_ESTUDIO_PLAN_ESTUDIO_ID",
                        column: x => x.PLAN_ESTUDIO_ID,
                        principalTable: "PLAN_ESTUDIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HORA_DIA_HORARIO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HORA_DIA_ID = table.Column<int>(type: "integer", nullable: false),
                    HORARIO_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HORA_DIA_HORARIO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HORA_DIA_HORARIO_HORARIO_HORARIO_ID",
                        column: x => x.HORARIO_ID,
                        principalTable: "HORARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HORA_DIA_HORARIO_HORA_DIA_HORA_DIA_ID",
                        column: x => x.HORA_DIA_ID,
                        principalTable: "HORA_DIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HORARIO_MATERIA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CUPOS_DISPONIBLES = table.Column<short>(type: "smallint", nullable: false),
                    CUPOS_TOTAL = table.Column<short>(type: "smallint", nullable: false),
                    NRO_AULA = table.Column<int>(type: "integer", nullable: true),
                    GESTION_ID = table.Column<int>(type: "integer", nullable: false),
                    GRUPO_MATERIA_ID = table.Column<int>(type: "integer", nullable: false),
                    MODULO_ID = table.Column<int>(type: "integer", nullable: false),
                    DOCENTE_ID = table.Column<int>(type: "integer", nullable: true),
                    HORARIO_ID = table.Column<int>(type: "integer", nullable: false),
                    MateriaPlanEstudioID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HORARIO_MATERIA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HORARIO_MATERIA_DOCENTE_DOCENTE_ID",
                        column: x => x.DOCENTE_ID,
                        principalTable: "DOCENTE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HORARIO_MATERIA_GESTION_GESTION_ID",
                        column: x => x.GESTION_ID,
                        principalTable: "GESTION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HORARIO_MATERIA_GRUPO_MATERIA_GRUPO_MATERIA_ID",
                        column: x => x.GRUPO_MATERIA_ID,
                        principalTable: "GRUPO_MATERIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HORARIO_MATERIA_HORARIO_HORARIO_ID",
                        column: x => x.HORARIO_ID,
                        principalTable: "HORARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HORARIO_MATERIA_MATERIA_PLAN_ESTUDIO_MateriaPlanEstudioID",
                        column: x => x.MateriaPlanEstudioID,
                        principalTable: "MATERIA_PLAN_ESTUDIO",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HORARIO_MATERIA_MODULO_MODULO_ID",
                        column: x => x.MODULO_ID,
                        principalTable: "MODULO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PREREQUISITO",
                columns: table => new
                {
                    MATERIA_PLAN_ESTUDIO_ID = table.Column<int>(type: "integer", nullable: false),
                    REQUISITO_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PREREQUISITO", x => new { x.MATERIA_PLAN_ESTUDIO_ID, x.REQUISITO_ID });
                    table.ForeignKey(
                        name: "FK_PREREQUISITO_MATERIA_PLAN_ESTUDIO_MATERIA_PLAN_ESTUDIO_ID",
                        column: x => x.MATERIA_PLAN_ESTUDIO_ID,
                        principalTable: "MATERIA_PLAN_ESTUDIO",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PREREQUISITO_MATERIA_PLAN_ESTUDIO_REQUISITO_ID",
                        column: x => x.REQUISITO_ID,
                        principalTable: "MATERIA_PLAN_ESTUDIO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HORARIO_MATERIA_INSCRIPCION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HORARIO_MATERIA_ID = table.Column<int>(type: "integer", nullable: false),
                    INSCRIPCION_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HORARIO_MATERIA_INSCRIPCION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HORARIO_MATERIA_INSCRIPCION_HORARIO_MATERIA_HORARIO_MATERIA~",
                        column: x => x.HORARIO_MATERIA_ID,
                        principalTable: "HORARIO_MATERIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HORARIO_MATERIA_INSCRIPCION_INSCRIPCION_INSCRIPCION_ID",
                        column: x => x.INSCRIPCION_ID,
                        principalTable: "INSCRIPCION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NOTA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CALIFICACION = table.Column<decimal>(type: "numeric", nullable: false),
                    ALUMNO_ID = table.Column<int>(type: "integer", nullable: true),
                    HORARIO_MATERIA_INSCRIPCION_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NOTA_ALUMNO_ALUMNO_ID",
                        column: x => x.ALUMNO_ID,
                        principalTable: "ALUMNO",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NOTA_HORARIO_MATERIA_INSCRIPCION_HORARIO_MATERIA_INSCRIPCIO~",
                        column: x => x.HORARIO_MATERIA_INSCRIPCION_ID,
                        principalTable: "HORARIO_MATERIA_INSCRIPCION",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "CARRERA",
                columns: new[] { "ID", "CODIGO", "MODALIDAD", "NOMBRE" },
                values: new object[,]
                {
                    { 1, "185", (short)0, "INGENIERIA EN REDES Y TELECOMUNICACIONES" },
                    { 2, "183", (short)0, "INGENIERIA INFORMATICA" },
                    { 3, "184", (short)0, "INGENIERIA EN SISTEMAS" }
                });

            migrationBuilder.InsertData(
                table: "DIA",
                columns: new[] { "ID", "NOMBRE" },
                values: new object[,]
                {
                    { 1, "LUNES" },
                    { 2, "MARTES" },
                    { 3, "MIERCOLES" },
                    { 4, "JUEVES" },
                    { 5, "VIERNES" },
                    { 6, "SABADO" }
                });

            migrationBuilder.InsertData(
                table: "GRUPO",
                columns: new[] { "ID", "NOMBRE" },
                values: new object[,]
                {
                    { 1, "SA" },
                    { 2, "SB" },
                    { 3, "SC" }
                });

            migrationBuilder.InsertData(
                table: "HORA",
                columns: new[] { "ID", "HR_FIN", "HR_INICIO" },
                values: new object[,]
                {
                    { 1, new TimeOnly(8, 30, 0), new TimeOnly(7, 0, 0) },
                    { 2, new TimeOnly(10, 0, 0), new TimeOnly(8, 30, 0) },
                    { 3, new TimeOnly(11, 30, 0), new TimeOnly(10, 0, 0) },
                    { 4, new TimeOnly(13, 0, 0), new TimeOnly(11, 30, 0) },
                    { 5, new TimeOnly(14, 30, 0), new TimeOnly(13, 0, 0) },
                    { 6, new TimeOnly(16, 0, 0), new TimeOnly(14, 30, 0) },
                    { 7, new TimeOnly(9, 15, 0), new TimeOnly(7, 0, 0) },
                    { 8, new TimeOnly(11, 30, 0), new TimeOnly(9, 15, 0) },
                    { 9, new TimeOnly(13, 0, 0), new TimeOnly(11, 30, 0) },
                    { 10, new TimeOnly(18, 15, 0), new TimeOnly(16, 0, 0) },
                    { 11, new TimeOnly(20, 30, 0), new TimeOnly(18, 15, 0) },
                    { 12, new TimeOnly(22, 45, 0), new TimeOnly(20, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "MATERIA",
                columns: new[] { "ID", "CREDITO", "ES_ELECTIVA", "NOMBRE", "SIGLA" },
                values: new object[,]
                {
                    { 1, (short)10, false, "INTRODUCCION A LA INFORMATICA", "INF110" },
                    { 2, (short)10, false, "ESTRUCTURAS DISCRETAS", "INF119" },
                    { 3, (short)10, false, "FISICA I", "FIS100" },
                    { 4, (short)10, false, "INGLES TECNICO I", "LIN100" },
                    { 5, (short)10, false, "CALCULO I", "MAT101" },
                    { 6, (short)10, false, "ALGEBRA LINEAL", "MAT103" },
                    { 7, (short)10, false, "PROGRAMACION I", "INF120" },
                    { 8, (short)10, false, "CALCULO I", "MAT102" },
                    { 9, (short)10, false, "FISICA II", "FIS102" },
                    { 10, (short)10, false, "INGLES TECNICO II", "LIN101" },
                    { 11, (short)10, false, "ARQUITECTURA DE COMPUTADORAS", "INF211" },
                    { 12, (short)10, false, "PROGRAMACION II", "INF210" },
                    { 13, (short)10, false, "ADMINISTRACION", "ADM100" },
                    { 14, (short)10, false, "FISICA III", "FIS200" },
                    { 15, (short)10, false, "ECUACIONES DIFERENCIALES", "MAT207" },
                    { 16, (short)10, false, "ANALISIS DE CIRCUITOS", "RDS210" },
                    { 17, (short)10, false, "TEORIA DE CAMPOS", "ELT241" },
                    { 18, (short)10, false, "PROBABILIDAD Y ESTADISTICA I", "MAT202" },
                    { 19, (short)10, false, "CONTABILIDAD", "ADM200" },
                    { 20, (short)10, false, "PROGRAMACION ENSAMBLADOR", "INF221" },
                    { 21, (short)10, false, "ESTRUCTURA DE DATOS I", "INF220" },
                    { 22, (short)10, false, "METODOS NUMERICOS", "MAT205" },
                    { 23, (short)10, false, "ANALISIS DE CIRCUITOS ELECTRONICOS", "RDS220" },
                    { 24, (short)10, false, "LENGUAJES FORMALES", "INF319" },
                    { 25, (short)10, false, "PROGRAMACION LOGICA Y FUNCIONAL", "INF318" },
                    { 26, (short)10, false, "BASE DE DATROS I", "INF312" },
                    { 27, (short)10, false, "ESTRUCTURA DE DATOS II", "INF310" },
                    { 28, (short)10, false, "PROBABILIDAD Y ESTADISTICA II", "MAT302" },
                    { 29, (short)10, false, "ORGANIZACION Y METODOS", "ADM330" },
                    { 30, (short)10, false, "ECONOMIA PARA LA GESTION", "ECO300" },
                    { 31, (short)10, false, "SISTEMAS LOGICOS Y DIGITALES I", "ELT352" },
                    { 32, (short)10, false, "ELECTRONICA APLICADA A REDES", "RDS310" },
                    { 33, (short)10, false, "SEÑALES Y SISTEMAS", "ELT354" },
                    { 34, (short)10, false, "BASE DE DATOS II", "INF322" },
                    { 35, (short)10, false, "INVESTIGACION OPERATIVA I", "MAT329" },
                    { 36, (short)10, false, "COMPILADORES", "INF329" },
                    { 37, (short)10, false, "SISTEMAS OPERATIVOS I", "INF323" },
                    { 38, (short)10, false, "SISTEMAS DE INFORMACION I", "INF342" },
                    { 39, (short)10, false, "FINANZAS PARA LA EMPRESA", "ECO320" },
                    { 40, (short)10, false, "SISTEMAS LOGICOS Y DIGITALES II", "ELT362" },
                    { 41, (short)10, false, "INTERPRETACION DE SISTEMAS Y SEÑALES", "RDS320" },
                    { 42, (short)10, false, "REDES I", "INF433" },
                    { 43, (short)10, false, "SISTEMAS OPERATIVOS II", "INF413" },
                    { 44, (short)10, false, "INTELIGENCIA ARTIFICIAL", "INF418" },
                    { 45, (short)10, false, "SISTEMAS DE INFORMACION II", "INF412" },
                    { 46, (short)10, false, "INVESTIGACION OPERATIVA II", "MAT419" },
                    { 47, (short)10, false, "SISTEMAS PARA EL SOPORTE A LA TOMA DE DESICIONES", "INF432" },
                    { 48, (short)10, false, "SISTEMAS DE COMUNICACION I", "ELT374" },
                    { 49, (short)10, false, "APPS CON MICROPROCESADORES", "RDS410" },
                    { 50, (short)10, false, "INGENIERIA DE SOFTWARE I", "INF422" },
                    { 51, (short)10, false, "REDES II", "INF423" },
                    { 52, (short)10, false, "SISTEMAS DE INFORMACION GEOGRAFICA", "INF442" },
                    { 53, (short)10, false, "PREPARACION Y EVALUACION DE PROYECTO", "ECO449" },
                    { 54, (short)10, false, "SISTEMAS EXPERTOS", "INF428" },
                    { 55, (short)10, false, "AUDITORIA INFORMATICA", "INF462" },
                    { 56, (short)10, false, "TALLER DE ANALISIS Y DESEÑO DE REDES", "RDS421" },
                    { 57, (short)10, false, "SISTEMAS DE COMUNICACION II", "ELT384" },
                    { 58, (short)10, false, "LEGISLACION EN REDES Y COMUNICACIONES", "RDS429" },
                    { 59, (short)10, false, "INGENIERIA DE SOFTWARE II", "INF512" },
                    { 60, (short)10, false, "ARQUITECTURA DE SOFTWARE", "INF552" },
                    { 61, (short)10, false, "TECNOLOGIA WEB", "INF513" },
                    { 62, (short)10, false, "TALLER DE GRADO I", "INF511" },
                    { 63, (short)10, false, "GESTION Y ADMINISTRACION DE REDES", "RDS511" },
                    { 64, (short)10, false, "REDES INALAMBRICAS Y COMUNICACIONES MOVILES", "RDS512" },
                    { 65, (short)10, false, "SEGURIDAD EN REDES Y TRANSMISION DE DATOS", "RDS519" },
                    { 66, (short)10, false, "MODALIDAD DE GRADUACION ", "GRL001" },
                    { 67, (short)10, true, "MODELACION Y SIMULACION DE SISTEMAS", "ELC101" },
                    { 68, (short)10, true, "PROGRAMACION GRAFICA", "ELC102" },
                    { 69, (short)10, true, "TOPICOS AVANZADOS DE PROGRAMACION", "ELC103" },
                    { 70, (short)10, true, "PROGRAMACION DE APLICACIONES DE TIEMPO REAL", "ELC104" },
                    { 71, (short)10, true, "SISTEMAS DISTRIBUIDOS", "ELC105" },
                    { 72, (short)10, true, "INTERACCION HOMBRE COMPUTADOR", "ELC106" },
                    { 73, (short)10, true, "CRIPTOGRAFICA Y SEGURIDAD", "ELC107" },
                    { 74, (short)10, true, "CONTROL Y AUTOMATIZACION", "ELC108" },
                    { 75, (short)10, true, "DISEÑO DE CIRCUITOS INTEGRADOS", "ELC201" },
                    { 76, (short)10, true, "INSTRUMENTACION", "ELC202" },
                    { 77, (short)10, true, "SISTEMAS DE COMUNICACION SCADA", "ELC203" },
                    { 78, (short)10, true, "TELEVISION DIGITAL", "ELC204" },
                    { 79, (short)10, true, "DOMOTICA", "ELC205" },
                    { 80, (short)10, true, "LINEAS Y TRANSMISION DE ANTES", "ELC206" },
                    { 81, (short)10, true, "TECNICAS PARA PRESENTACION PARA INGENIERIA", "ELC207" },
                    { 82, (short)10, true, "REDES ADHOC", "ELC208" },
                    { 83, (short)10, true, "ADMINISTRACION DE RECURSOS HUMANOS", "ELC001" },
                    { 84, (short)10, true, "COSTOS Y PRESUPUESTOS", "ELC002" },
                    { 85, (short)10, true, "PRODUCCION Y MARKETING", "ELC003" },
                    { 86, (short)10, true, "REINGENIERIA", "ELC004" },
                    { 87, (short)10, true, "INGENIERIA DE CALIDAD", "ELC005" },
                    { 88, (short)10, true, "BENCHMARKING", "ELC006" },
                    { 89, (short)10, true, "INTRODUCCION A LA MACROECONOMIA", "ELC007" },
                    { 90, (short)10, true, "LEGISLACION EN CIENCIAS DE LA COMPUTACION", "ELC008" }
                });

            migrationBuilder.InsertData(
                table: "NIVEL",
                columns: new[] { "ID", "NOMBRE" },
                values: new object[,]
                {
                    { 1, "1 SEMESTRE" },
                    { 2, "2 SEMESTRE" },
                    { 3, "3 SEMESTRE" },
                    { 4, "4 SEMESTRE" },
                    { 5, "5 SEMESTRE" },
                    { 6, "6 SEMESTRE" },
                    { 7, "7 SEMESTRE" },
                    { 8, "8 SEMESTRE" },
                    { 9, "9 SEMESTRE" },
                    { 10, "10 SEMESTRE" }
                });

            migrationBuilder.InsertData(
                table: "GRUPO_MATERIA",
                columns: new[] { "ID", "GRUPO_ID", "MATERIA_ID" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 2, 1, 6 },
                    { 3, 2, 7 },
                    { 4, 2, 8 },
                    { 5, 3, 9 }
                });

            migrationBuilder.InsertData(
                table: "HORA_DIA",
                columns: new[] { "ID", "DIA_ID", "HORA_ID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 3, 1 },
                    { 7, 3, 2 },
                    { 8, 3, 3 },
                    { 9, 3, 4 },
                    { 10, 3, 5 },
                    { 11, 5, 1 },
                    { 12, 5, 2 },
                    { 13, 5, 3 },
                    { 14, 5, 4 },
                    { 15, 5, 5 },
                    { 16, 2, 7 },
                    { 17, 2, 8 },
                    { 18, 2, 9 },
                    { 19, 2, 10 },
                    { 20, 2, 11 },
                    { 21, 2, 12 },
                    { 22, 4, 7 },
                    { 23, 4, 8 },
                    { 24, 4, 9 },
                    { 25, 4, 10 },
                    { 26, 4, 11 },
                    { 27, 4, 12 }
                });

            migrationBuilder.InsertData(
                table: "PLAN_ESTUDIO",
                columns: new[] { "ID", "CARRERA_ID", "CODIGO" },
                values: new object[,]
                {
                    { 1, 2, "ING-INF" },
                    { 2, 3, "ING-SIS" },
                    { 3, 1, "ING-RED" }
                });

            migrationBuilder.InsertData(
                table: "MATERIA_PLAN_ESTUDIO",
                columns: new[] { "ID", "MATERIA_ID", "NIVEL_ID", "PLAN_ESTUDIO_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 1, 1 },
                    { 3, 3, 1, 1 },
                    { 4, 4, 1, 1 },
                    { 5, 5, 1, 1 },
                    { 6, 6, 2, 1 },
                    { 7, 7, 2, 1 },
                    { 8, 8, 2, 1 },
                    { 9, 9, 2, 1 },
                    { 10, 10, 2, 1 },
                    { 11, 11, 3, 1 },
                    { 12, 12, 3, 1 },
                    { 13, 13, 3, 1 },
                    { 14, 14, 3, 1 },
                    { 15, 15, 3, 1 },
                    { 16, 18, 4, 1 },
                    { 17, 19, 4, 1 },
                    { 18, 20, 4, 1 },
                    { 19, 21, 4, 1 },
                    { 20, 22, 4, 1 },
                    { 21, 24, 5, 1 },
                    { 22, 25, 5, 1 },
                    { 23, 26, 5, 1 },
                    { 24, 27, 5, 1 },
                    { 25, 28, 5, 1 },
                    { 26, 34, 6, 1 },
                    { 27, 35, 6, 1 },
                    { 28, 36, 6, 1 },
                    { 29, 37, 6, 1 },
                    { 30, 38, 6, 1 },
                    { 31, 42, 7, 1 },
                    { 32, 43, 7, 1 },
                    { 33, 44, 7, 1 },
                    { 34, 45, 7, 1 },
                    { 35, 46, 7, 1 },
                    { 36, 50, 8, 1 },
                    { 37, 51, 8, 1 },
                    { 38, 52, 8, 1 },
                    { 39, 53, 8, 1 },
                    { 40, 54, 8, 1 },
                    { 41, 59, 9, 1 },
                    { 42, 60, 9, 1 },
                    { 43, 61, 9, 1 },
                    { 44, 62, 9, 1 },
                    { 45, 45, 10, 1 },
                    { 46, 1, 1, 2 },
                    { 47, 2, 1, 2 },
                    { 48, 3, 1, 2 },
                    { 49, 4, 1, 2 },
                    { 50, 5, 1, 2 },
                    { 51, 6, 2, 2 },
                    { 52, 7, 2, 2 },
                    { 53, 8, 2, 2 },
                    { 54, 9, 2, 2 },
                    { 55, 10, 2, 2 },
                    { 56, 11, 3, 2 },
                    { 57, 12, 3, 2 },
                    { 58, 13, 3, 2 },
                    { 59, 14, 3, 2 },
                    { 60, 15, 3, 2 },
                    { 61, 18, 4, 2 },
                    { 62, 19, 4, 2 },
                    { 63, 20, 4, 2 },
                    { 64, 21, 4, 2 },
                    { 65, 22, 4, 2 },
                    { 66, 26, 5, 2 },
                    { 67, 27, 5, 2 },
                    { 68, 28, 5, 2 },
                    { 69, 29, 5, 2 },
                    { 70, 30, 5, 2 },
                    { 71, 34, 6, 2 },
                    { 72, 35, 6, 2 },
                    { 73, 37, 6, 2 },
                    { 74, 38, 6, 2 },
                    { 75, 39, 6, 2 },
                    { 76, 42, 7, 2 },
                    { 77, 43, 7, 2 },
                    { 78, 45, 7, 2 },
                    { 79, 46, 7, 2 },
                    { 80, 47, 7, 2 },
                    { 81, 50, 8, 2 },
                    { 82, 51, 8, 2 },
                    { 83, 52, 8, 2 },
                    { 84, 53, 8, 2 },
                    { 85, 55, 8, 2 },
                    { 86, 59, 9, 2 },
                    { 87, 60, 9, 2 },
                    { 88, 61, 9, 2 },
                    { 89, 62, 9, 2 },
                    { 90, 45, 10, 2 },
                    { 91, 1, 1, 3 },
                    { 92, 2, 1, 3 },
                    { 93, 3, 1, 3 },
                    { 94, 4, 1, 3 },
                    { 95, 5, 1, 3 },
                    { 96, 6, 2, 3 },
                    { 97, 7, 2, 3 },
                    { 98, 8, 2, 3 },
                    { 99, 9, 2, 3 },
                    { 100, 10, 2, 3 },
                    { 101, 11, 3, 3 },
                    { 102, 12, 3, 3 },
                    { 103, 15, 3, 3 },
                    { 104, 16, 3, 3 },
                    { 105, 17, 3, 3 },
                    { 106, 18, 4, 3 },
                    { 107, 20, 4, 3 },
                    { 108, 21, 4, 3 },
                    { 109, 22, 4, 3 },
                    { 110, 23, 4, 3 },
                    { 111, 26, 5, 3 },
                    { 112, 28, 5, 3 },
                    { 113, 31, 5, 3 },
                    { 114, 32, 5, 3 },
                    { 115, 33, 5, 3 },
                    { 116, 34, 6, 3 },
                    { 117, 35, 6, 3 },
                    { 118, 37, 6, 3 },
                    { 119, 40, 6, 3 },
                    { 120, 41, 6, 3 },
                    { 121, 42, 7, 3 },
                    { 122, 43, 7, 3 },
                    { 123, 46, 7, 3 },
                    { 124, 48, 7, 3 },
                    { 125, 49, 7, 3 },
                    { 126, 51, 8, 3 },
                    { 127, 53, 8, 3 },
                    { 128, 56, 8, 3 },
                    { 129, 57, 8, 3 },
                    { 130, 58, 8, 3 },
                    { 131, 61, 9, 3 },
                    { 132, 62, 9, 3 },
                    { 133, 63, 9, 3 },
                    { 134, 64, 9, 3 },
                    { 135, 65, 9, 3 },
                    { 136, 45, 10, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GRUPO_MATERIA_GRUPO_ID",
                table: "GRUPO_MATERIA",
                column: "GRUPO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GRUPO_MATERIA_MATERIA_ID",
                table: "GRUPO_MATERIA",
                column: "MATERIA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORA_DIA_DIA_ID",
                table: "HORA_DIA",
                column: "DIA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORA_DIA_HORA_ID",
                table: "HORA_DIA",
                column: "HORA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORA_DIA_HORARIO_HORA_DIA_ID",
                table: "HORA_DIA_HORARIO",
                column: "HORA_DIA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORA_DIA_HORARIO_HORARIO_ID",
                table: "HORA_DIA_HORARIO",
                column: "HORARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORARIO_MATERIA_DOCENTE_ID",
                table: "HORARIO_MATERIA",
                column: "DOCENTE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORARIO_MATERIA_GESTION_ID",
                table: "HORARIO_MATERIA",
                column: "GESTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORARIO_MATERIA_GRUPO_MATERIA_ID",
                table: "HORARIO_MATERIA",
                column: "GRUPO_MATERIA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORARIO_MATERIA_HORARIO_ID",
                table: "HORARIO_MATERIA",
                column: "HORARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORARIO_MATERIA_MateriaPlanEstudioID",
                table: "HORARIO_MATERIA",
                column: "MateriaPlanEstudioID");

            migrationBuilder.CreateIndex(
                name: "IX_HORARIO_MATERIA_MODULO_ID",
                table: "HORARIO_MATERIA",
                column: "MODULO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORARIO_MATERIA_INSCRIPCION_HORARIO_MATERIA_ID",
                table: "HORARIO_MATERIA_INSCRIPCION",
                column: "HORARIO_MATERIA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HORARIO_MATERIA_INSCRIPCION_INSCRIPCION_ID",
                table: "HORARIO_MATERIA_INSCRIPCION",
                column: "INSCRIPCION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INSCRIPCION_ALUMNO_ID",
                table: "INSCRIPCION",
                column: "ALUMNO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MATERIA_PLAN_ESTUDIO_MATERIA_ID",
                table: "MATERIA_PLAN_ESTUDIO",
                column: "MATERIA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MATERIA_PLAN_ESTUDIO_NIVEL_ID",
                table: "MATERIA_PLAN_ESTUDIO",
                column: "NIVEL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MATERIA_PLAN_ESTUDIO_PLAN_ESTUDIO_ID",
                table: "MATERIA_PLAN_ESTUDIO",
                column: "PLAN_ESTUDIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NOTA_ALUMNO_ID",
                table: "NOTA",
                column: "ALUMNO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NOTA_HORARIO_MATERIA_INSCRIPCION_ID",
                table: "NOTA",
                column: "HORARIO_MATERIA_INSCRIPCION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PLAN_ESTUDIO_CARRERA_ID",
                table: "PLAN_ESTUDIO",
                column: "CARRERA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PREREQUISITO_REQUISITO_ID",
                table: "PREREQUISITO",
                column: "REQUISITO_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HORA_DIA_HORARIO");

            migrationBuilder.DropTable(
                name: "NOTA");

            migrationBuilder.DropTable(
                name: "PREREQUISITO");

            migrationBuilder.DropTable(
                name: "HORA_DIA");

            migrationBuilder.DropTable(
                name: "HORARIO_MATERIA_INSCRIPCION");

            migrationBuilder.DropTable(
                name: "DIA");

            migrationBuilder.DropTable(
                name: "HORA");

            migrationBuilder.DropTable(
                name: "HORARIO_MATERIA");

            migrationBuilder.DropTable(
                name: "INSCRIPCION");

            migrationBuilder.DropTable(
                name: "DOCENTE");

            migrationBuilder.DropTable(
                name: "GESTION");

            migrationBuilder.DropTable(
                name: "GRUPO_MATERIA");

            migrationBuilder.DropTable(
                name: "HORARIO");

            migrationBuilder.DropTable(
                name: "MATERIA_PLAN_ESTUDIO");

            migrationBuilder.DropTable(
                name: "MODULO");

            migrationBuilder.DropTable(
                name: "ALUMNO");

            migrationBuilder.DropTable(
                name: "GRUPO");

            migrationBuilder.DropTable(
                name: "MATERIA");

            migrationBuilder.DropTable(
                name: "NIVEL");

            migrationBuilder.DropTable(
                name: "PLAN_ESTUDIO");

            migrationBuilder.DropTable(
                name: "CARRERA");
        }
    }
}
