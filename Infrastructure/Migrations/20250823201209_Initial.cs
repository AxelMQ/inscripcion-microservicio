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
                    { 3, "184", (short)0, "INGENIERIA EN SISTEMAS" },
                    { 4, "323", (short)0, "INGENIERIA ROBOTICA" }
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
                table: "DOCENTE",
                columns: new[] { "ID", "CI", "NOMBRE", "TELEFONO" },
                values: new object[,]
                {
                    { 1, 15157488, "FLORES GUZMAN VALENTIN VICTOR", 78481515L },
                    { 2, 15157489, "LOBO LIMPIAS VICTOR HUGO", 78481516L },
                    { 3, 15157490, "ARANIBAR QUIROZ MARTHA MONICA", 78481517L },
                    { 4, 15157491, "SANCHEZ VELASCO ENRIQUE", 78481518L },
                    { 5, 15157492, "CALDERON FLORES MODESTO FRANKLIN", 78481519L },
                    { 6, 15157493, "LAZO ARTEAGA CARLOS ROBERTO", 78481520L },
                    { 7, 15157494, "ZUNA VILLAGOMEZ RICARDO", 78481521L },
                    { 8, 15157495, "MOLLO MAMANI ALBERTO", 78481522L },
                    { 9, 15157496, "ALIAGA HOWARD SHARON KENNY", 78481523L },
                    { 10, 15157497, "CONTRERAS VILLEGAS JUAN CARLOS", 78481524L },
                    { 11, 15157498, "MARTINEZ CARDONA SARAH MIRNA", 78481525L },
                    { 12, 15157499, "CACERES CHACON BRAULIO", 78481526L },
                    { 13, 15157500, "GUTIERREZ BRUNO KATIME ESTHER", 78481527L },
                    { 14, 15157501, "APAZA LEON ROSNAY", 78481528L },
                    { 15, 15157502, "ZUNIGA RUIZ WILMA", 78481529L },
                    { 16, 15157503, "CLAURE MEDRANO DE OROPEZA ELIZ", 78481530L },
                    { 17, 15157504, "AVENDANO GONZALES EUDAL", 78481531L },
                    { 18, 15157505, "OROPEZA CLAURE GUSTAVO ADOLFO", 78481532L },
                    { 19, 15157506, "VALDELOMAR ORELLANA TOMAS", 78481533L },
                    { 20, 15157507, "ACOSTA CABEZAS BARTOLO JAVIER", 78481534L },
                    { 21, 15157508, "CALDERON FLORES PIODESTO FRANKL", 78481535L },
                    { 22, 15157509, "ZEBALLOS PAREDES DANIEL LUIS", 78481536L },
                    { 23, 15157510, "MOLLO NAL4ANI ALBERTO", 78481537L },
                    { 24, 15157511, "GRIMALDO BRAVO PAUL", 78481538L },
                    { 25, 15157512, "LAZO ARTEAGA CARLOS ROBERTO", 78481539L },
                    { 26, 15157513, "GONZALES APARICIO MELISSA", 78481540L },
                    { 27, 15157514, "ORTEGA PAREDES FRANCISCO", 78481541L },
                    { 28, 15157515, "VILLARROEL RIVERA NATALIA", 78481542L },
                    { 29, 15157516, "CARRASCO CORDOVA LUIS", 78481543L },
                    { 30, 15157517, "MEDINA LOPEZ GLORIA", 78481544L },
                    { 31, 15157518, "MENDOZA CASTRO MARCO", 78481545L },
                    { 32, 15157519, "ALVAREZ ROMERO SANDRA", 78481546L },
                    { 33, 15157520, "RAMIREZ HUERTA CARLOS", 78481547L },
                    { 34, 15157521, "ESCOBAR FLORES VERONICA", 78481548L },
                    { 35, 15157522, "CASTILLO GOMEZ JUAN", 78481549L },
                    { 36, 15157523, "PEREZ SALAZAR LILIANA", 78481550L },
                    { 37, 15157524, "TORRES QUISPE RICARDO", 78481551L },
                    { 38, 15157525, "HUAMAN FLORES MIRIAM", 78481552L },
                    { 39, 15157526, "CHAVEZ LOPEZ EDWIN", 78481553L },
                    { 40, 15157527, "GARCIA VILLENA KARINA", 78481554L },
                    { 41, 15157528, "RODRIGUEZ SALAZAR LUIS", 78481555L },
                    { 42, 15157529, "FERNANDEZ CASTRO MARIA", 78481556L },
                    { 43, 15157530, "MARTINEZ HUAMAN PABLO", 78481557L },
                    { 44, 15157531, "QUISPE RAMOS GLADYS", 78481558L },
                    { 45, 15157532, "SALAZAR MORENO JULIO", 78481559L },
                    { 46, 15157533, "LOPEZ RIVERA ANGELA", 78481560L },
                    { 47, 15157534, "VILLANUEVA PEREZ CARLOS", 78481561L },
                    { 48, 15157535, "ORTEGA SALAZAR FABIOLA", 78481562L },
                    { 49, 15157536, "GOMEZ HUAMAN MARIO", 78481563L },
                    { 50, 15157537, "CARRASCO LOPEZ ELISA", 78481564L }
                });

            migrationBuilder.InsertData(
                table: "GESTION",
                columns: new[] { "ID", "NOMBRE" },
                values: new object[,]
                {
                    { 1, "1/2025" },
                    { 2, "2/2025" },
                    { 3, "3/2025" },
                    { 4, "4/2025" },
                    { 5, "1/2024" },
                    { 6, "2/2024" },
                    { 7, "3/2024" },
                    { 8, "4/2024" }
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
                    { 1, (short)5, false, "CÁLCULO I", "MAT101" },
                    { 2, (short)5, false, "ESTRUCTURAS DISCRETAS", "INF119" },
                    { 3, (short)5, false, "INTRODUCCIÓN A LA INFORMÁTICA", "INF110" },
                    { 4, (short)5, false, "FÍSICA I", "FIS100" },
                    { 5, (short)5, false, "INGLÉS TÉCNICO I", "LIN100" },
                    { 6, (short)5, false, "CÁLCULO II", "MAT102" },
                    { 7, (short)5, false, "ÁLGEBRA LINEAL", "MAT103" },
                    { 8, (short)5, false, "PROGRAMACIÓN I", "INF120" },
                    { 9, (short)5, false, "FÍSICA II", "FIS102" },
                    { 10, (short)5, false, "INGLÉS TÉCNICO II", "LIN101" },
                    { 11, (short)5, false, "ECUACIONES DIFERENCIALES", "MAT207" },
                    { 12, (short)5, false, "PROGRAMACIÓN II", "INF210" },
                    { 13, (short)5, false, "ARQUITECTURA DE COMPUTADORAS", "INF211" },
                    { 14, (short)6, false, "FÍSICA III", "FIS200" },
                    { 15, (short)4, false, "ADMINISTRACIÓN", "ADM100" },
                    { 16, (short)5, false, "PROBABILIDAD Y ESTADÍSTICA I", "MAT202" },
                    { 17, (short)5, false, "MÉTODOS NUMÉRICOS", "MAT205" },
                    { 18, (short)5, false, "ESTRUCTURA DE DATOS I", "INF220" },
                    { 19, (short)5, false, "PROGRAMACIÓN ENSAMBLADOR", "INF221" },
                    { 20, (short)4, false, "CONTABILIDAD", "ADM200" },
                    { 21, (short)5, false, "PROBABILIDAD Y ESTADÍSTICA II", "MAT302" },
                    { 22, (short)5, false, "PROGRAMACIÓN LÓGICA Y FUNCIONAL I", "INF318" },
                    { 23, (short)5, false, "ESTRUCTURA DE DATOS II", "INF310" },
                    { 24, (short)5, false, "BASE DE DATOS I", "INF312" },
                    { 25, (short)5, false, "LENGUAJES FORMALES", "INF319" },
                    { 26, (short)5, false, "INVESTIGACIÓN OPERATIVA I", "MAT329" },
                    { 27, (short)5, false, "SISTEMAS DE INFORMACIÓN I", "INF342" },
                    { 28, (short)5, false, "SISTEMAS OPERATIVOS I", "INF323" },
                    { 29, (short)5, false, "BASE DE DATOS II", "INF322" },
                    { 30, (short)5, false, "COMPILADORES", "INF329" },
                    { 31, (short)5, false, "INVESTIGACIÓN OPERATIVA II", "MAT419" },
                    { 32, (short)5, false, "INTELIGENCIA ARTIFICIAL", "INF418" },
                    { 33, (short)5, false, "SISTEMAS OPERATIVOS II", "INF413" },
                    { 34, (short)5, false, "REDES I", "INF433" },
                    { 35, (short)5, false, "INGENIERÍA DE SOFTWARE I", "INF412" },
                    { 36, (short)5, false, "PREPARACIÓN Y EVALUACIÓN DE PROYECTOS", "EC0449" },
                    { 37, (short)5, false, "SISTEMAS EXPERTOS", "INF428" },
                    { 38, (short)5, false, "SISTEMAS DE INFORMACIÓN II", "INF442" },
                    { 39, (short)5, false, "REDES II", "INF423" },
                    { 40, (short)5, false, "INGENIERÍA DE SOFTWARE II", "INF512" },
                    { 41, (short)5, false, "TALLER DE GRADO I", "INF511" },
                    { 42, (short)5, false, "TECNOLOGÍA WEB", "INF513" },
                    { 43, (short)4, false, "ARQUITECTURA DE SOFTWARE", "INF552" },
                    { 44, (short)4, false, "SISTEMAS DE INFORMACIÓN GEOGRÁFICA", "INF442" },
                    { 53, (short)5, false, "ORGANIZACIÓN Y MÉTODOS", "ADM330" },
                    { 54, (short)5, false, "ECONOMÍA PARA LA GESTIÓN", "ECO300" },
                    { 55, (short)5, false, "FINANZAS PARA LA EMPRESA", "ADM320" },
                    { 56, (short)5, false, "SISTEMAS PARA EL SOPORTE A LA TOMA DE DECISIONES", "INF343" },
                    { 57, (short)4, false, "AUDITORÍA INFORMÁTICA", "INF462" },
                    { 58, (short)5, false, "MODALIDAD DE GRADUACIÓN", "GRLO01" },
                    { 59, (short)10, true, "MODELACIÓN Y SIMULACIÓN DE SISTEMAS", "ELCI01" },
                    { 60, (short)10, true, "PROGRAMACIÓN GRÁFICA", "ELCI02" },
                    { 61, (short)10, true, "TÓPICOS AVANZADOS DE PROGRAMACIÓN", "ELCI03" },
                    { 62, (short)10, true, "PROGRAMACIÓN DE APLICACIONES DE TIEMPO REAL", "ELCI04" },
                    { 63, (short)10, true, "SISTEMAS DISTRIBUIDOS", "ELCI05" },
                    { 64, (short)10, true, "INTERACCIÓN HOMBRE COMPUTADOR", "ELCI06" },
                    { 65, (short)10, true, "CRIPTOGRAFÍA Y SEGURIDAD", "ELCI07" },
                    { 66, (short)10, true, "CONTROL AND AUTOMATIZACIÓN", "ELCI08" },
                    { 67, (short)3, true, "ADMINISTRACIÓN DE RECURSOS HUMANOS", "ELC001" },
                    { 68, (short)3, true, "COSTOS Y PRESUPUESTOS", "ELC002" },
                    { 69, (short)3, true, "PRODUCCIÓN Y MARKETING", "ELC003" },
                    { 70, (short)3, true, "REINGENIERÍA", "ELC004" },
                    { 71, (short)3, true, "INGENIERÍA DE LA CALIDAD", "ELC005" },
                    { 72, (short)3, true, "BENCHMARKING", "ELC006" },
                    { 73, (short)3, true, "INTRODUCCIÓN A LA MACROECONOMÍA", "ELC007" },
                    { 74, (short)3, true, "LEGISLACIÓN EN CIENCIAS DE LA COMPUTACIÓN", "ELC008" },
                    { 75, (short)5, false, "ANÁLISIS DE CIRCUITOS", "RD5210" },
                    { 76, (short)5, false, "TEORÍA DE CAMPOS", "ELT341" },
                    { 77, (short)4, false, "ANÁLISIS DE CIRCUITOS ELECTRÓNICOS", "RD5220" },
                    { 78, (short)5, false, "ELECTRÓNICA APLICADA A REDES", "RD5310" },
                    { 79, (short)5, false, "SISTEMAS LÓGICOS Y DIGITALES I", "ELT352" },
                    { 80, (short)5, false, "SEÑALES Y SISTEMAS", "ELT354" },
                    { 81, (short)5, true, "DISEÑO DE CIRCUITOS INTEGRADOS", "ELC201" },
                    { 82, (short)5, true, "INSTRUMENTACIÓN", "ELC202" },
                    { 83, (short)5, false, "SISTEMAS LÓGICOS Y DIGITALES II", "ELT382" },
                    { 84, (short)5, false, "INTERPRETACIÓN DE SISTEMAS Y SEÑALES", "RD5320" },
                    { 85, (short)5, true, "SISTEMAS DE COMUNICACIÓN SCADA", "ELC203" },
                    { 86, (short)5, true, "TELEVISIÓN DIGITAL", "ELC204" },
                    { 87, (short)5, false, "APLICACIONES CON MICROPROCESADORES", "RD5410" },
                    { 88, (short)5, false, "SISTEMAS DE COMUNICACIÓN I", "ELT374" },
                    { 89, (short)5, true, "DOMÓTICA", "ELC206" },
                    { 90, (short)5, false, "LÍNEAS DE TRANSMISIÓN Y ANTENAS", "ELT384" },
                    { 91, (short)5, false, "TALLER DE ANÁLISIS Y DISEÑO DE REDES", "RD5421" },
                    { 92, (short)5, false, "LEGISLACIÓN EN REDES Y COMUNICACIONES", "RD5422" },
                    { 93, (short)5, false, "SISTEMAS DE COMUNICACIÓN II", "ELT384" },
                    { 94, (short)5, true, "TÉCNICAS DE PRESENTACIÓN PARA INGENIERÍA", "ELC207" },
                    { 95, (short)5, true, "REDES ADHOC", "ELC208" },
                    { 96, (short)5, false, "GESTIÓN Y ADMINISTRACIÓN DE REDES", "RD5511" },
                    { 97, (short)5, false, "REDES INALÁMBRICAS Y COMUNICACIONES MÓVILES", "RD5512" },
                    { 98, (short)5, false, "SEGURIDAD EN REDES Y TRANSMISIÓN DE DATOS", "RD5519" },
                    { 99, (short)5, false, "MODALIDAD DE TITULACIÓN A NIVEL TÉCNICO SUPERIOR", "GRT001" },
                    { 100, (short)5, false, "MODALIDAD DE TITULACIÓN LICENCIATURA", "GRLO01" },
                    { 101, (short)5, false, "TALLER DE GRADO I", "INFST1" },
                    { 102, (short)5, false, "ROBÓTICA AVANZADA", "ROBM05" },
                    { 103, (short)5, false, "ROBOT OPERATING SYSTEM", "ROBM04" },
                    { 104, (short)5, false, "SISTEMAS DE CONTROL II", "ROBM03" },
                    { 105, (short)5, false, "AUTOMATIZACIÓN Y CONTROL", "ROBM02" },
                    { 106, (short)5, false, "VISIÓN COMPUTACIONAL", "ROBM07" },
                    { 107, (short)5, false, "ROBÓTICA INDUSTRIAL", "ROBM04" },
                    { 108, (short)5, false, "INTERNET DE LAS COSAS", "ROBM06" },
                    { 109, (short)5, false, "TALLER DE CONTROL", "ROBM05" },
                    { 110, (short)5, false, "INSTRUMENTACIÓN INDUSTRIAL", "ELC202" },
                    { 111, (short)5, false, "LIDERAZGO, EMPRENDIMIENTO Y STARTUPS", "MET200" },
                    { 112, (short)5, false, "SISTEMAS EMBEBIDOS", "ROBR203" },
                    { 113, (short)5, false, "SISTEMAS DE CONTROL I", "ROBR01" },
                    { 114, (short)5, false, "ACTUADORES Y SENSORES", "ROBR02" },
                    { 115, (short)5, false, "PROCESAMIENTO DIGITAL DE SEÑALES", "ROBS20" },
                    { 116, (short)5, false, "CIRCUITOS DIGITALES", "ROBR04" },
                    { 117, (short)5, false, "ELECTRÓNICO Y MAGNETISMO", "ROBR201" },
                    { 118, (short)5, false, "ANÁLISIS DE CIRCUITOS", "ROBS210" },
                    { 119, (short)5, false, "DINÁMICA", "ROBR203" },
                    { 120, (short)5, false, "TECNOLOGÍAS DE LA MANUFACTURA", "ROBR02" },
                    { 121, (short)5, false, "ESTÁTICA", "ROBR03" },
                    { 122, (short)5, false, "PENSAMIENTO CRÍTICO Y CREATIVO", "ROBR04" },
                    { 123, (short)5, false, "INTRODUCCIÓN A LA ROBÓTICA", "ROBR01" },
                    { 124, (short)5, false, "DIBUJO MECÁNICO EN CAD", "ROBR02" },
                    { 125, (short)5, false, "METODOLOGÍA DE LA INVESTIGACIÓN", "MET100" },
                    { 126, (short)5, false, "CIRCUITOS ELECTRÓNICOS I", "ELT352" },
                    { 127, (short)5, false, "CIRCUITOS ELECTRÓNICOS II", "ELT352" }
                });

            migrationBuilder.InsertData(
                table: "MODULO",
                columns: new[] { "ID", "NRO_MODULO" },
                values: new object[,]
                {
                    { 1, (short)236 },
                    { 2, (short)225 },
                    { 3, (short)260 },
                    { 4, (short)224 },
                    { 5, (short)256 },
                    { 6, (short)222 }
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
                    { 3, 1, "ING-RED" },
                    { 4, 4, "ING-ROB" }
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
                    { 16, 16, 4, 1 },
                    { 17, 17, 4, 1 },
                    { 18, 18, 4, 1 },
                    { 19, 19, 4, 1 },
                    { 20, 20, 4, 1 },
                    { 21, 21, 5, 1 },
                    { 22, 22, 5, 1 },
                    { 23, 23, 5, 1 },
                    { 24, 24, 5, 1 },
                    { 25, 25, 5, 1 },
                    { 26, 26, 6, 1 },
                    { 27, 27, 6, 1 },
                    { 28, 28, 6, 1 },
                    { 29, 29, 6, 1 },
                    { 30, 30, 6, 1 },
                    { 31, 31, 7, 1 },
                    { 32, 32, 7, 1 },
                    { 33, 33, 7, 1 },
                    { 34, 34, 7, 1 },
                    { 35, 35, 7, 1 },
                    { 36, 36, 8, 1 },
                    { 37, 37, 8, 1 },
                    { 38, 38, 8, 1 },
                    { 39, 39, 8, 1 },
                    { 40, 40, 8, 1 },
                    { 41, 41, 9, 1 },
                    { 42, 42, 9, 1 },
                    { 43, 43, 9, 1 },
                    { 44, 44, 9, 1 },
                    { 45, 58, 10, 1 },
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
                    { 61, 16, 4, 2 },
                    { 62, 17, 4, 2 },
                    { 63, 18, 4, 2 },
                    { 64, 19, 4, 2 },
                    { 65, 20, 4, 2 },
                    { 66, 21, 5, 2 },
                    { 67, 22, 5, 2 },
                    { 68, 23, 5, 2 },
                    { 69, 24, 5, 2 },
                    { 70, 25, 5, 2 },
                    { 71, 53, 5, 2 },
                    { 72, 54, 5, 2 },
                    { 73, 26, 6, 2 },
                    { 74, 27, 6, 2 },
                    { 75, 28, 6, 2 },
                    { 76, 29, 6, 2 },
                    { 77, 30, 6, 2 },
                    { 78, 55, 6, 2 },
                    { 79, 31, 7, 2 },
                    { 80, 32, 7, 2 },
                    { 81, 33, 7, 2 },
                    { 82, 34, 7, 2 },
                    { 83, 35, 7, 2 },
                    { 84, 56, 7, 2 },
                    { 85, 36, 8, 2 },
                    { 86, 37, 8, 2 },
                    { 87, 38, 8, 2 },
                    { 88, 39, 8, 2 },
                    { 89, 40, 8, 2 },
                    { 90, 57, 8, 2 },
                    { 91, 41, 9, 2 },
                    { 92, 42, 9, 2 },
                    { 93, 43, 9, 2 },
                    { 94, 44, 9, 2 },
                    { 95, 58, 10, 2 },
                    { 96, 1, 1, 3 },
                    { 97, 2, 1, 3 },
                    { 98, 3, 1, 3 },
                    { 99, 4, 1, 3 },
                    { 100, 5, 1, 3 },
                    { 101, 6, 2, 3 },
                    { 102, 7, 2, 3 },
                    { 103, 8, 2, 3 },
                    { 104, 9, 2, 3 },
                    { 105, 10, 2, 3 },
                    { 106, 11, 3, 3 },
                    { 107, 12, 3, 3 },
                    { 108, 13, 3, 3 },
                    { 109, 14, 3, 3 },
                    { 110, 15, 3, 3 },
                    { 111, 16, 4, 3 },
                    { 112, 17, 4, 3 },
                    { 113, 18, 4, 3 },
                    { 114, 19, 4, 3 },
                    { 115, 75, 4, 3 },
                    { 116, 76, 5, 3 },
                    { 117, 77, 5, 3 },
                    { 118, 78, 5, 3 },
                    { 119, 79, 5, 3 },
                    { 120, 80, 5, 3 },
                    { 121, 1, 1, 4 },
                    { 122, 2, 1, 4 },
                    { 123, 3, 1, 4 },
                    { 124, 4, 1, 4 },
                    { 125, 5, 1, 4 },
                    { 126, 6, 2, 4 },
                    { 127, 7, 2, 4 },
                    { 128, 8, 2, 4 },
                    { 129, 9, 2, 4 },
                    { 130, 10, 2, 4 },
                    { 131, 11, 3, 4 },
                    { 132, 12, 3, 4 },
                    { 133, 13, 3, 4 },
                    { 134, 14, 3, 4 },
                    { 135, 15, 3, 4 },
                    { 136, 16, 4, 4 },
                    { 137, 17, 4, 4 },
                    { 138, 18, 4, 4 },
                    { 139, 19, 4, 4 },
                    { 140, 101, 4, 4 },
                    { 141, 102, 5, 4 },
                    { 142, 103, 5, 4 },
                    { 143, 104, 5, 4 },
                    { 144, 105, 5, 4 },
                    { 145, 106, 5, 4 }
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
