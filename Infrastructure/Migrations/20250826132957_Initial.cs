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
                    { 3, "SC" },
                    { 4, "SD" },
                    { 5, "SE" },
                    { 6, "SF" },
                    { 7, "SG" },
                    { 8, "SH" },
                    { 9, "SI" },
                    { 10, "SK" },
                    { 11, "SN" },
                    { 12, "SM" },
                    { 13, "SP" },
                    { 14, "SR" },
                    { 15, "SS" },
                    { 16, "SX" },
                    { 17, "SZ" },
                    { 18, "F1" },
                    { 19, "BI" },
                    { 20, "CI" },
                    { 21, "C1" },
                    { 22, "I2" },
                    { 23, "ER" },
                    { 24, "R1" },
                    { 25, "1I" },
                    { 26, "I1" },
                    { 27, "NW" },
                    { 28, "NX" },
                    { 29, "W1" },
                    { 30, "X2" },
                    { 31, "X3" },
                    { 32, "X4" },
                    { 33, "Z1" },
                    { 34, "Z2" },
                    { 35, "Z3" },
                    { 36, "Z4" },
                    { 37, "Z5" },
                    { 38, "Z6" }
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
                    { 12, new TimeOnly(22, 45, 0), new TimeOnly(20, 30, 0) },
                    { 13, new TimeOnly(12, 15, 0), new TimeOnly(10, 0, 0) },
                    { 14, new TimeOnly(13, 45, 0), new TimeOnly(11, 30, 0) },
                    { 15, new TimeOnly(16, 0, 0), new TimeOnly(13, 45, 0) },
                    { 16, new TimeOnly(16, 45, 0), new TimeOnly(15, 15, 0) },
                    { 17, new TimeOnly(17, 30, 0), new TimeOnly(15, 15, 0) },
                    { 18, new TimeOnly(19, 0, 0), new TimeOnly(17, 30, 0) },
                    { 19, new TimeOnly(21, 15, 0), new TimeOnly(19, 0, 0) },
                    { 20, new TimeOnly(20, 30, 0), new TimeOnly(19, 0, 0) },
                    { 21, new TimeOnly(22, 0, 0), new TimeOnly(19, 45, 0) },
                    { 22, new TimeOnly(13, 0, 0), new TimeOnly(10, 45, 0) },
                    { 23, new TimeOnly(15, 15, 0), new TimeOnly(13, 45, 0) },
                    { 24, new TimeOnly(15, 15, 0), new TimeOnly(13, 0, 0) },
                    { 25, new TimeOnly(16, 45, 0), new TimeOnly(15, 15, 0) },
                    { 26, new TimeOnly(17, 30, 0), new TimeOnly(16, 0, 0) },
                    { 27, new TimeOnly(18, 15, 0), new TimeOnly(16, 45, 0) },
                    { 28, new TimeOnly(19, 45, 0), new TimeOnly(18, 15, 0) },
                    { 29, new TimeOnly(21, 15, 0), new TimeOnly(19, 45, 0) },
                    { 30, new TimeOnly(22, 45, 0), new TimeOnly(21, 15, 0) },
                    { 31, new TimeOnly(22, 0, 0), new TimeOnly(20, 30, 0) },
                    { 32, new TimeOnly(13, 45, 0), new TimeOnly(12, 15, 0) },
                    { 33, new TimeOnly(19, 45, 0), new TimeOnly(18, 26, 0) },
                    { 34, new TimeOnly(10, 45, 0), new TimeOnly(9, 15, 0) },
                    { 35, new TimeOnly(11, 30, 0), new TimeOnly(8, 30, 0) },
                    { 36, new TimeOnly(16, 0, 0), new TimeOnly(13, 0, 0) },
                    { 37, new TimeOnly(12, 15, 0), new TimeOnly(9, 15, 0) },
                    { 38, new TimeOnly(21, 15, 0), new TimeOnly(18, 15, 0) }
                });

            migrationBuilder.InsertData(
                table: "HORARIO",
                column: "ID",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    11,
                    12,
                    13,
                    14,
                    15,
                    16,
                    17,
                    18,
                    19,
                    20,
                    21,
                    22,
                    23,
                    24,
                    25,
                    26,
                    27,
                    28,
                    29,
                    30,
                    31,
                    32,
                    33,
                    34,
                    35,
                    36,
                    37,
                    38,
                    39,
                    40,
                    41,
                    42,
                    43,
                    44,
                    45,
                    46,
                    47,
                    48,
                    49,
                    50,
                    51,
                    52,
                    53,
                    54,
                    55,
                    56,
                    57,
                    58,
                    59,
                    60,
                    61,
                    62,
                    63,
                    64,
                    65,
                    66,
                    67,
                    68,
                    69,
                    70,
                    71,
                    72,
                    73,
                    74,
                    75,
                    76,
                    77,
                    78,
                    79,
                    80,
                    81,
                    82,
                    83,
                    84,
                    85,
                    86,
                    87
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
                    { 22, (short)5, false, "PROGRAMACIÓN LÓGICA Y FUNCIONAL", "INF318" },
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
                    { 35, (short)5, false, "INGENIERÍA DE SOFTWARE I", "INF422" },
                    { 36, (short)5, false, "PREPARACIÓN Y EVALUACIÓN DE PROYECTOS", "ECO449" },
                    { 37, (short)5, false, "SISTEMAS EXPERTOS", "INF428" },
                    { 38, (short)5, false, "SISTEMAS DE INFORMACIÓN II", "INF412" },
                    { 39, (short)5, false, "REDES II", "INF423" },
                    { 40, (short)5, false, "INGENIERÍA DE SOFTWARE II", "INF512" },
                    { 41, (short)5, false, "TALLER DE GRADO I", "INF511" },
                    { 42, (short)5, false, "TECNOLOGÍA WEB", "INF513" },
                    { 43, (short)4, false, "ARQUITECTURA DE SOFTWARE", "INF552" },
                    { 44, (short)4, false, "SISTEMAS DE INFORMACIÓN GEOGRÁFICA", "INF442" },
                    { 53, (short)5, false, "ORGANIZACIÓN Y MÉTODOS", "ADM330" },
                    { 54, (short)5, false, "ECONOMÍA PARA LA GESTIÓN", "ECO300" },
                    { 55, (short)5, false, "FINANZAS PARA LA EMPRESA", "ADM320" },
                    { 56, (short)5, false, "SISTEMAS PARA EL SOPORTE A LA TOMA DE DECISIONES", "INF432" },
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
                    { 75, (short)5, false, "ANÁLISIS DE CIRCUITOS", "RDS210" },
                    { 76, (short)5, false, "TEORÍA DE CAMPOS", "ELT241" },
                    { 77, (short)4, false, "ANÁLISIS DE CIRCUITOS ELECTRÓNICOS", "RDS220" },
                    { 78, (short)5, false, "ELECTRÓNICA APLICADA A REDES", "RDS310" },
                    { 79, (short)5, false, "SISTEMAS LÓGICOS Y DIGITALES I", "ELT352" },
                    { 80, (short)5, false, "SEÑALES Y SISTEMAS", "ELT354" },
                    { 81, (short)5, true, "DISEÑO DE CIRCUITOS INTEGRADOS", "ELC201" },
                    { 82, (short)5, true, "INSTRUMENTACIÓN", "ELC202" },
                    { 83, (short)5, false, "SISTEMAS LÓGICOS Y DIGITALES II", "ELT362" },
                    { 84, (short)5, false, "INTERPRETACIÓN DE SISTEMAS Y SEÑALES", "RDS320" },
                    { 85, (short)5, true, "SISTEMAS DE COMUNICACIÓN SCADA", "ELC203" },
                    { 86, (short)5, true, "TELEVISIÓN DIGITAL", "ELC204" },
                    { 87, (short)5, false, "APLICACIONES CON MICROPROCESADORES", "RDS410" },
                    { 88, (short)5, false, "SISTEMAS DE COMUNICACIÓN I", "ELT374" },
                    { 89, (short)5, true, "DOMÓTICA", "ELC205" },
                    { 90, (short)5, false, "LÍNEAS DE TRANSMISIÓN Y ANTENAS", "ELC206" },
                    { 91, (short)5, false, "TALLER DE ANÁLISIS Y DISEÑO DE REDES", "RDS421" },
                    { 92, (short)5, false, "LEGISLACIÓN EN REDES Y COMUNICACIONES", "RS429" },
                    { 93, (short)5, false, "SISTEMAS DE COMUNICACIÓN II", "ELC384" },
                    { 94, (short)5, true, "TÉCNICAS DE PRESENTACIÓN PARA INGENIERÍA", "ELC207" },
                    { 95, (short)5, true, "REDES ADHOC", "ELC208" },
                    { 96, (short)5, false, "GESTIÓN Y ADMINISTRACIÓN DE REDES", "RDS511" },
                    { 97, (short)5, false, "REDES INALÁMBRICAS Y COMUNICACIONES MÓVILES", "RDS512" },
                    { 98, (short)5, false, "SEGURIDAD EN REDES Y TRANSMISIÓN DE DATOS", "RDS519" },
                    { 99, (short)5, false, "MODALIDAD DE TITULACIÓN A NIVEL TÉCNICO SUPERIOR", "GRT001" },
                    { 100, (short)5, false, "MODALIDAD DE TITULACIÓN LICENCIATURA", "GRL001" }
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
                    { 1, 1, 15 },
                    { 2, 2, 15 },
                    { 3, 3, 15 },
                    { 4, 1, 7 },
                    { 5, 2, 7 },
                    { 6, 3, 7 },
                    { 7, 4, 7 },
                    { 8, 5, 7 },
                    { 9, 6, 7 },
                    { 10, 1, 75 },
                    { 11, 2, 75 },
                    { 12, 17, 77 },
                    { 13, 1, 87 },
                    { 14, 1, 13 },
                    { 15, 2, 13 },
                    { 16, 1, 43 },
                    { 17, 1, 57 },
                    { 18, 1, 24 },
                    { 19, 3, 24 },
                    { 20, 2, 29 },
                    { 21, 4, 29 },
                    { 22, 18, 1 },
                    { 23, 17, 1 },
                    { 24, 20, 1 },
                    { 25, 22, 1 },
                    { 26, 6, 1 },
                    { 27, 7, 1 },
                    { 28, 9, 1 },
                    { 29, 13, 1 },
                    { 30, 33, 1 },
                    { 31, 34, 1 },
                    { 32, 35, 1 },
                    { 33, 36, 1 },
                    { 34, 37, 1 },
                    { 35, 38, 1 },
                    { 36, 2, 6 },
                    { 37, 4, 6 },
                    { 38, 24, 6 },
                    { 39, 25, 6 },
                    { 40, 21, 6 },
                    { 41, 8, 6 },
                    { 42, 11, 6 },
                    { 43, 1, 30 },
                    { 44, 1, 20 },
                    { 45, 2, 20 },
                    { 46, 1, 68 },
                    { 47, 22, 65 },
                    { 48, 1, 65 },
                    { 49, 1, 81 },
                    { 50, 1, 54 },
                    { 51, 2, 54 },
                    { 52, 27, 11 },
                    { 53, 28, 11 },
                    { 54, 1, 11 },
                    { 55, 3, 11 },
                    { 56, 2, 78 },
                    { 57, 22, 18 },
                    { 58, 1, 18 },
                    { 59, 2, 18 },
                    { 60, 4, 18 },
                    { 61, 1, 23 },
                    { 62, 2, 23 },
                    { 63, 16, 23 },
                    { 64, 5, 2 },
                    { 65, 6, 2 },
                    { 66, 8, 2 },
                    { 67, 10, 2 },
                    { 68, 34, 2 },
                    { 69, 35, 2 },
                    { 70, 13, 2 },
                    { 71, 33, 2 },
                    { 72, 36, 2 },
                    { 73, 37, 2 },
                    { 74, 38, 2 },
                    { 75, 1, 55 },
                    { 76, 3, 55 },
                    { 77, 24, 4 },
                    { 78, 26, 4 },
                    { 79, 7, 4 },
                    { 80, 9, 4 },
                    { 81, 10, 4 },
                    { 82, 12, 4 },
                    { 83, 13, 4 },
                    { 84, 33, 4 },
                    { 85, 34, 4 },
                    { 86, 35, 4 },
                    { 87, 36, 4 },
                    { 88, 37, 4 },
                    { 89, 38, 4 },
                    { 90, 19, 9 },
                    { 91, 24, 9 },
                    { 92, 27, 9 },
                    { 93, 28, 9 },
                    { 94, 1, 9 },
                    { 95, 2, 9 },
                    { 96, 1, 14 },
                    { 97, 2, 14 },
                    { 98, 3, 14 },
                    { 99, 34, 14 },
                    { 100, 35, 14 },
                    { 101, 36, 14 },
                    { 102, 1, 96 },
                    { 103, 1, 71 },
                    { 104, 2, 35 },
                    { 105, 3, 35 },
                    { 106, 2, 40 },
                    { 107, 27, 5 },
                    { 108, 28, 5 },
                    { 109, 33, 5 },
                    { 110, 34, 5 },
                    { 111, 35, 5 },
                    { 112, 36, 5 },
                    { 113, 38, 5 },
                    { 114, 2, 16 },
                    { 115, 3, 16 },
                    { 116, 4, 16 },
                    { 117, 9, 16 },
                    { 118, 1, 21 },
                    { 119, 2, 21 },
                    { 120, 9, 21 },
                    { 121, 1, 69 },
                    { 122, 1, 22 },
                    { 123, 1, 19 },
                    { 124, 2, 19 },
                    { 125, 3, 19 },
                    { 126, 16, 19 },
                    { 127, 1, 60 },
                    { 128, 1, 8 },
                    { 129, 3, 8 },
                    { 130, 2, 8 },
                    { 131, 7, 8 },
                    { 132, 4, 8 },
                    { 133, 6, 8 },
                    { 134, 8, 8 },
                    { 135, 9, 8 },
                    { 136, 1, 12 },
                    { 137, 4, 12 },
                    { 138, 3, 12 },
                    { 139, 2, 12 },
                    { 140, 9, 12 },
                    { 141, 1, 95 },
                    { 142, 1, 34 },
                    { 143, 2, 34 },
                    { 144, 3, 34 },
                    { 145, 24, 39 },
                    { 146, 2, 39 },
                    { 147, 3, 39 },
                    { 148, 1, 97 },
                    { 149, 1, 98 },
                    { 150, 24, 80 },
                    { 151, 14, 88 },
                    { 152, 14, 93 },
                    { 153, 24, 85 },
                    { 154, 9, 44 },
                    { 155, 1, 44 },
                    { 156, 1, 27 },
                    { 157, 3, 27 },
                    { 158, 1, 38 },
                    { 159, 2, 38 },
                    { 160, 2, 37 },
                    { 161, 23, 79 },
                    { 162, 24, 83 },
                    { 163, 1, 28 },
                    { 164, 3, 28 },
                    { 165, 1, 33 },
                    { 166, 2, 33 },
                    { 167, 1, 56 },
                    { 168, 1, 91 },
                    { 169, 15, 41 },
                    { 170, 1, 41 },
                    { 171, 3, 41 },
                    { 172, 1, 42 },
                    { 173, 3, 42 },
                    { 174, 14, 86 },
                    { 175, 3, 76 },
                    { 176, 1, 61 }
                });

            migrationBuilder.InsertData(
                table: "HORA_DIA",
                columns: new[] { "ID", "DIA_ID", "HORA_ID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 7 },
                    { 3, 1, 2 },
                    { 4, 1, 8 },
                    { 5, 1, 3 },
                    { 6, 1, 4 },
                    { 7, 1, 32 },
                    { 8, 1, 5 },
                    { 9, 1, 23 },
                    { 10, 1, 15 },
                    { 11, 1, 25 },
                    { 12, 1, 10 },
                    { 13, 1, 26 },
                    { 14, 1, 27 },
                    { 15, 1, 28 },
                    { 16, 1, 20 },
                    { 17, 1, 21 },
                    { 18, 1, 29 },
                    { 19, 1, 31 },
                    { 20, 1, 30 },
                    { 21, 2, 1 },
                    { 22, 2, 7 },
                    { 23, 2, 8 },
                    { 24, 2, 37 },
                    { 25, 2, 22 },
                    { 26, 2, 9 },
                    { 27, 2, 14 },
                    { 28, 2, 32 },
                    { 29, 2, 36 },
                    { 30, 2, 24 },
                    { 31, 2, 23 },
                    { 32, 2, 15 },
                    { 33, 2, 25 },
                    { 34, 2, 17 },
                    { 35, 2, 26 },
                    { 36, 2, 10 },
                    { 37, 2, 27 },
                    { 38, 2, 18 },
                    { 39, 2, 28 },
                    { 40, 2, 11 },
                    { 41, 2, 20 },
                    { 42, 2, 19 },
                    { 43, 2, 31 },
                    { 44, 2, 12 },
                    { 45, 2, 30 },
                    { 46, 3, 7 },
                    { 47, 3, 1 },
                    { 48, 3, 2 },
                    { 49, 3, 8 },
                    { 50, 3, 3 },
                    { 51, 3, 4 },
                    { 52, 3, 14 },
                    { 53, 3, 32 },
                    { 54, 3, 23 },
                    { 55, 3, 15 },
                    { 56, 3, 6 },
                    { 57, 3, 25 },
                    { 58, 3, 10 },
                    { 59, 3, 27 },
                    { 60, 3, 26 },
                    { 61, 3, 28 },
                    { 62, 3, 20 },
                    { 63, 3, 29 },
                    { 64, 3, 31 },
                    { 65, 3, 30 },
                    { 66, 4, 1 },
                    { 67, 4, 7 },
                    { 68, 4, 8 },
                    { 69, 4, 22 },
                    { 70, 4, 14 },
                    { 71, 4, 24 },
                    { 72, 4, 15 },
                    { 73, 4, 17 },
                    { 74, 4, 25 },
                    { 75, 4, 26 },
                    { 76, 4, 10 },
                    { 77, 4, 18 },
                    { 78, 4, 28 },
                    { 79, 4, 11 },
                    { 80, 4, 20 },
                    { 81, 4, 19 },
                    { 82, 4, 31 },
                    { 83, 4, 12 },
                    { 84, 4, 30 },
                    { 85, 5, 1 },
                    { 86, 5, 7 },
                    { 87, 5, 2 },
                    { 88, 5, 8 },
                    { 89, 5, 3 },
                    { 90, 5, 13 },
                    { 91, 3, 4 },
                    { 92, 5, 14 },
                    { 93, 5, 32 },
                    { 94, 5, 15 },
                    { 95, 5, 23 },
                    { 96, 5, 25 },
                    { 97, 5, 26 },
                    { 98, 5, 27 },
                    { 99, 5, 38 },
                    { 100, 5, 28 },
                    { 101, 5, 20 },
                    { 102, 5, 21 },
                    { 103, 5, 29 },
                    { 104, 5, 31 },
                    { 105, 5, 30 },
                    { 106, 6, 1 },
                    { 107, 6, 2 },
                    { 108, 6, 35 },
                    { 109, 6, 34 },
                    { 110, 6, 13 },
                    { 111, 6, 25 },
                    { 112, 6, 28 },
                    { 113, 6, 33 },
                    { 114, 3, 22 },
                    { 115, 5, 22 },
                    { 116, 3, 21 }
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
                table: "HORA_DIA_HORARIO",
                columns: new[] { "ID", "HORARIO_ID", "HORA_DIA_ID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 47 },
                    { 3, 1, 85 },
                    { 4, 2, 3 },
                    { 5, 2, 48 },
                    { 6, 2, 87 },
                    { 7, 3, 5 },
                    { 8, 3, 50 },
                    { 9, 3, 89 },
                    { 10, 4, 6 },
                    { 11, 4, 51 },
                    { 12, 4, 91 },
                    { 13, 5, 7 },
                    { 14, 5, 53 },
                    { 15, 5, 93 },
                    { 16, 6, 9 },
                    { 17, 6, 54 },
                    { 18, 6, 95 },
                    { 19, 7, 11 },
                    { 20, 7, 57 },
                    { 21, 7, 96 },
                    { 22, 8, 13 },
                    { 23, 8, 60 },
                    { 24, 8, 97 },
                    { 25, 9, 14 },
                    { 26, 9, 59 },
                    { 27, 9, 98 },
                    { 28, 10, 15 },
                    { 29, 10, 61 },
                    { 30, 10, 100 },
                    { 31, 11, 16 },
                    { 32, 11, 62 },
                    { 33, 11, 101 },
                    { 34, 12, 18 },
                    { 35, 12, 63 },
                    { 36, 12, 103 },
                    { 37, 13, 20 },
                    { 38, 13, 65 },
                    { 39, 13, 105 },
                    { 40, 14, 19 },
                    { 41, 14, 64 },
                    { 42, 14, 104 },
                    { 43, 15, 1 },
                    { 44, 15, 47 },
                    { 45, 15, 85 },
                    { 46, 15, 106 },
                    { 47, 16, 5 },
                    { 48, 16, 50 },
                    { 49, 16, 89 },
                    { 50, 16, 112 },
                    { 51, 17, 5 },
                    { 52, 17, 50 },
                    { 53, 17, 89 },
                    { 54, 17, 113 },
                    { 55, 18, 14 },
                    { 56, 18, 59 },
                    { 57, 18, 98 },
                    { 58, 18, 107 },
                    { 59, 19, 18 },
                    { 60, 19, 63 },
                    { 61, 19, 103 },
                    { 62, 19, 109 },
                    { 63, 20, 9 },
                    { 64, 20, 54 },
                    { 65, 20, 95 },
                    { 66, 20, 98 },
                    { 67, 21, 11 },
                    { 68, 21, 57 },
                    { 69, 21, 96 },
                    { 70, 21, 105 },
                    { 71, 22, 14 },
                    { 72, 22, 59 },
                    { 73, 22, 98 },
                    { 74, 22, 100 },
                    { 75, 23, 2 },
                    { 76, 23, 46 },
                    { 77, 24, 4 },
                    { 78, 24, 49 },
                    { 79, 25, 10 },
                    { 80, 25, 55 },
                    { 81, 26, 12 },
                    { 82, 26, 58 },
                    { 83, 27, 16 },
                    { 84, 27, 62 },
                    { 85, 28, 17 },
                    { 86, 28, 116 },
                    { 87, 29, 2 },
                    { 88, 29, 46 },
                    { 89, 29, 56 },
                    { 90, 30, 2 },
                    { 91, 30, 67 },
                    { 92, 31, 10 },
                    { 93, 31, 72 },
                    { 94, 31, 96 },
                    { 95, 32, 2 },
                    { 96, 32, 86 },
                    { 97, 32, 21 },
                    { 98, 33, 7 },
                    { 99, 33, 36 },
                    { 100, 33, 76 },
                    { 101, 34, 8 },
                    { 102, 34, 22 },
                    { 103, 34, 67 },
                    { 104, 35, 12 },
                    { 105, 35, 21 },
                    { 106, 35, 94 },
                    { 107, 36, 24 },
                    { 108, 37, 22 },
                    { 109, 37, 67 },
                    { 110, 37, 28 },
                    { 111, 38, 22 },
                    { 112, 38, 67 },
                    { 113, 38, 26 },
                    { 114, 39, 40 },
                    { 115, 39, 79 },
                    { 116, 39, 37 },
                    { 117, 40, 40 },
                    { 118, 40, 79 },
                    { 119, 40, 64 },
                    { 120, 41, 22 },
                    { 121, 41, 67 },
                    { 122, 41, 89 },
                    { 123, 42, 22 },
                    { 124, 42, 67 },
                    { 125, 42, 100 },
                    { 126, 43, 32 },
                    { 127, 43, 72 },
                    { 128, 43, 96 },
                    { 129, 44, 36 },
                    { 130, 44, 76 },
                    { 131, 44, 97 },
                    { 132, 45, 31 },
                    { 133, 45, 58 },
                    { 134, 45, 94 },
                    { 135, 46, 11 },
                    { 136, 46, 33 },
                    { 137, 46, 57 },
                    { 138, 46, 37 },
                    { 139, 47, 49 },
                    { 140, 47, 86 },
                    { 141, 48, 52 },
                    { 142, 48, 90 },
                    { 143, 49, 50 },
                    { 144, 49, 96 },
                    { 145, 49, 111 },
                    { 146, 50, 114 },
                    { 147, 50, 115 },
                    { 148, 51, 64 },
                    { 149, 51, 99 },
                    { 150, 52, 55 },
                    { 151, 52, 110 },
                    { 152, 53, 48 },
                    { 153, 53, 67 },
                    { 154, 53, 88 },
                    { 155, 54, 70 },
                    { 156, 54, 92 },
                    { 157, 55, 22 },
                    { 158, 55, 86 },
                    { 159, 56, 29 },
                    { 160, 56, 95 },
                    { 161, 57, 21 },
                    { 162, 57, 66 },
                    { 163, 57, 106 },
                    { 164, 58, 22 },
                    { 165, 58, 86 },
                    { 166, 59, 21 },
                    { 167, 59, 66 },
                    { 168, 60, 23 },
                    { 169, 60, 68 },
                    { 170, 61, 27 },
                    { 171, 61, 70 },
                    { 172, 72, 31 },
                    { 173, 72, 71 },
                    { 174, 73, 32 },
                    { 175, 73, 72 },
                    { 176, 74, 33 },
                    { 177, 74, 74 },
                    { 178, 75, 34 },
                    { 179, 75, 73 },
                    { 180, 76, 36 },
                    { 181, 76, 76 },
                    { 182, 77, 35 },
                    { 183, 77, 75 },
                    { 184, 78, 38 },
                    { 185, 78, 77 },
                    { 186, 79, 40 },
                    { 187, 79, 79 },
                    { 188, 80, 39 },
                    { 189, 80, 78 },
                    { 190, 81, 41 },
                    { 191, 81, 80 },
                    { 192, 82, 42 },
                    { 193, 82, 81 },
                    { 194, 83, 43 },
                    { 195, 83, 82 },
                    { 196, 84, 44 },
                    { 197, 84, 83 },
                    { 198, 85, 45 },
                    { 199, 85, 84 },
                    { 200, 86, 108 }
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
                    { 35, 38, 7, 1 },
                    { 36, 36, 8, 1 },
                    { 37, 37, 8, 1 },
                    { 38, 44, 8, 1 },
                    { 39, 39, 8, 1 },
                    { 40, 35, 8, 1 },
                    { 41, 41, 9, 1 },
                    { 42, 42, 9, 1 },
                    { 43, 43, 9, 1 },
                    { 44, 40, 9, 1 },
                    { 45, 100, 10, 1 },
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
                    { 68, 23, 5, 2 },
                    { 69, 24, 5, 2 },
                    { 71, 53, 5, 2 },
                    { 72, 54, 5, 2 },
                    { 73, 26, 6, 2 },
                    { 74, 27, 6, 2 },
                    { 75, 28, 6, 2 },
                    { 76, 29, 6, 2 },
                    { 78, 55, 6, 2 },
                    { 79, 31, 7, 2 },
                    { 81, 33, 7, 2 },
                    { 82, 34, 7, 2 },
                    { 83, 38, 7, 2 },
                    { 84, 56, 7, 2 },
                    { 85, 36, 8, 2 },
                    { 87, 35, 8, 2 },
                    { 88, 39, 8, 2 },
                    { 89, 44, 8, 2 },
                    { 90, 57, 8, 2 },
                    { 91, 41, 9, 2 },
                    { 92, 42, 9, 2 },
                    { 93, 43, 9, 2 },
                    { 94, 40, 9, 2 },
                    { 95, 100, 10, 2 },
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
                    { 109, 75, 3, 3 },
                    { 110, 76, 3, 3 },
                    { 111, 16, 4, 3 },
                    { 112, 17, 4, 3 },
                    { 113, 18, 4, 3 },
                    { 114, 19, 4, 3 },
                    { 115, 77, 4, 3 },
                    { 116, 21, 5, 3 },
                    { 117, 24, 5, 3 },
                    { 118, 78, 5, 3 },
                    { 119, 79, 5, 3 },
                    { 120, 80, 5, 3 },
                    { 121, 81, 5, 3 },
                    { 122, 82, 5, 3 },
                    { 123, 28, 6, 3 },
                    { 124, 29, 6, 3 },
                    { 125, 26, 6, 3 },
                    { 126, 83, 6, 3 },
                    { 127, 84, 6, 3 },
                    { 128, 85, 6, 3 },
                    { 129, 86, 6, 3 },
                    { 130, 99, 6, 3 },
                    { 131, 34, 7, 3 },
                    { 132, 33, 7, 3 },
                    { 133, 31, 7, 3 },
                    { 134, 87, 7, 3 },
                    { 135, 88, 7, 3 },
                    { 136, 89, 7, 3 },
                    { 137, 90, 7, 3 },
                    { 138, 39, 8, 3 },
                    { 139, 36, 8, 3 },
                    { 140, 91, 8, 3 },
                    { 141, 92, 8, 3 },
                    { 142, 93, 8, 3 },
                    { 143, 94, 8, 3 },
                    { 144, 95, 8, 3 },
                    { 145, 41, 9, 3 },
                    { 146, 42, 9, 3 },
                    { 147, 96, 9, 3 },
                    { 148, 97, 9, 3 },
                    { 149, 98, 9, 3 },
                    { 150, 100, 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "PREREQUISITO",
                columns: new[] { "MATERIA_PLAN_ESTUDIO_ID", "REQUISITO_ID" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 7, 2 },
                    { 8, 3 },
                    { 9, 4 },
                    { 10, 5 },
                    { 11, 6 },
                    { 12, 7 },
                    { 12, 8 },
                    { 13, 8 },
                    { 13, 9 },
                    { 14, 9 },
                    { 16, 6 },
                    { 17, 11 },
                    { 18, 12 },
                    { 19, 13 },
                    { 20, 15 },
                    { 21, 16 },
                    { 22, 18 },
                    { 23, 18 },
                    { 24, 18 },
                    { 25, 18 },
                    { 26, 21 },
                    { 27, 24 },
                    { 28, 23 },
                    { 29, 24 },
                    { 30, 23 },
                    { 30, 25 },
                    { 31, 26 },
                    { 32, 23 },
                    { 32, 30 },
                    { 33, 28 },
                    { 34, 28 },
                    { 35, 27 },
                    { 35, 29 },
                    { 36, 31 },
                    { 37, 32 },
                    { 37, 35 },
                    { 38, 35 },
                    { 39, 34 },
                    { 40, 35 },
                    { 41, 36 },
                    { 41, 37 },
                    { 41, 38 },
                    { 41, 39 },
                    { 41, 40 },
                    { 42, 36 },
                    { 42, 37 },
                    { 42, 38 },
                    { 42, 39 },
                    { 42, 40 },
                    { 43, 36 },
                    { 43, 37 },
                    { 43, 38 },
                    { 43, 39 },
                    { 43, 40 },
                    { 44, 36 },
                    { 44, 37 },
                    { 44, 38 },
                    { 44, 39 },
                    { 44, 40 },
                    { 45, 41 },
                    { 45, 42 },
                    { 45, 43 },
                    { 45, 44 },
                    { 51, 46 },
                    { 52, 47 },
                    { 53, 48 },
                    { 54, 49 },
                    { 55, 50 },
                    { 56, 51 },
                    { 57, 52 },
                    { 57, 53 },
                    { 58, 53 },
                    { 58, 54 },
                    { 59, 54 },
                    { 61, 51 },
                    { 62, 56 },
                    { 63, 57 },
                    { 64, 58 },
                    { 65, 60 },
                    { 66, 61 },
                    { 68, 63 },
                    { 69, 63 },
                    { 71, 65 },
                    { 72, 65 },
                    { 73, 66 },
                    { 74, 69 },
                    { 75, 68 },
                    { 76, 69 },
                    { 78, 71 },
                    { 79, 73 },
                    { 81, 75 },
                    { 82, 75 },
                    { 83, 74 },
                    { 83, 76 },
                    { 84, 74 },
                    { 84, 76 },
                    { 85, 79 },
                    { 87, 83 },
                    { 88, 82 },
                    { 89, 83 },
                    { 90, 78 },
                    { 90, 83 },
                    { 92, 85 },
                    { 92, 90 },
                    { 94, 87 },
                    { 94, 88 },
                    { 94, 89 },
                    { 95, 91 },
                    { 95, 92 },
                    { 95, 93 },
                    { 95, 94 },
                    { 101, 96 },
                    { 102, 97 },
                    { 103, 98 },
                    { 104, 99 },
                    { 105, 100 },
                    { 106, 101 },
                    { 107, 102 },
                    { 107, 103 },
                    { 108, 103 },
                    { 108, 104 },
                    { 109, 104 },
                    { 110, 104 },
                    { 111, 101 },
                    { 112, 106 },
                    { 113, 96 },
                    { 113, 107 },
                    { 114, 108 },
                    { 115, 109 },
                    { 116, 111 },
                    { 117, 113 },
                    { 118, 115 },
                    { 119, 115 },
                    { 120, 106 },
                    { 120, 110 },
                    { 123, 116 },
                    { 124, 117 },
                    { 125, 121 },
                    { 126, 119 },
                    { 127, 112 },
                    { 127, 120 },
                    { 131, 120 },
                    { 131, 123 },
                    { 132, 123 },
                    { 133, 125 },
                    { 134, 114 },
                    { 134, 126 },
                    { 135, 120 },
                    { 135, 127 },
                    { 138, 131 },
                    { 139, 133 },
                    { 140, 131 },
                    { 141, 131 },
                    { 141, 135 },
                    { 142, 135 },
                    { 145, 138 },
                    { 145, 139 },
                    { 145, 140 },
                    { 145, 141 },
                    { 145, 142 },
                    { 146, 138 },
                    { 146, 139 },
                    { 146, 140 },
                    { 146, 141 },
                    { 146, 142 },
                    { 147, 138 },
                    { 147, 139 },
                    { 147, 140 },
                    { 147, 141 },
                    { 147, 142 },
                    { 148, 138 },
                    { 148, 139 },
                    { 148, 140 },
                    { 148, 141 },
                    { 148, 142 },
                    { 149, 138 },
                    { 149, 139 },
                    { 149, 140 },
                    { 149, 141 },
                    { 149, 142 },
                    { 150, 145 },
                    { 150, 146 },
                    { 150, 147 },
                    { 150, 148 },
                    { 150, 149 }
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
