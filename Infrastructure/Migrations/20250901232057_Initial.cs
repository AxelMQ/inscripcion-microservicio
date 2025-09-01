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
                name: "alumno",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    ppa = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    telefono = table.Column<int>(type: "integer", nullable: false),
                    registro = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_alumno", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "carrera",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    modalidad = table.Column<short>(type: "smallint", nullable: false),
                    nombre = table.Column<string>(type: "character varying(63)", maxLength: 63, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_carrera", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_dia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "docente",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    telefono = table.Column<long>(type: "bigint", nullable: true),
                    ci = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_docente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gestion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_gestion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "grupo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_grupo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hora",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    hr_inicio = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    hr_fin = table.Column<TimeOnly>(type: "time without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hora", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "horario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_horario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "materia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    credito = table.Column<short>(type: "smallint", nullable: false),
                    es_electiva = table.Column<bool>(type: "boolean", nullable: false),
                    nombre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    sigla = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_materia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "modulo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nro_modulo = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_modulo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "nivel",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    orden = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_nivel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inscripcion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alumno_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_inscripcion", x => x.id);
                    table.ForeignKey(
                        name: "fk_inscripcion_alumno_alumno_id",
                        column: x => x.alumno_id,
                        principalTable: "alumno",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "plan_estudio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    carrera_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_plan_estudio", x => x.id);
                    table.ForeignKey(
                        name: "fk_plan_estudio_carrera_carrera_id",
                        column: x => x.carrera_id,
                        principalTable: "carrera",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hora_dia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dia_id = table.Column<int>(type: "integer", nullable: false),
                    hora_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hora_dia", x => x.id);
                    table.ForeignKey(
                        name: "fk_hora_dia_dia_dia_id",
                        column: x => x.dia_id,
                        principalTable: "dia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hora_dia_hora_hora_id",
                        column: x => x.hora_id,
                        principalTable: "hora",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "grupo_materia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    grupo_id = table.Column<int>(type: "integer", nullable: false),
                    materia_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_grupo_materia", x => x.id);
                    table.ForeignKey(
                        name: "fk_grupo_materia_grupo_grupo_id",
                        column: x => x.grupo_id,
                        principalTable: "grupo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_grupo_materia_materia_materia_id",
                        column: x => x.materia_id,
                        principalTable: "materia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "alumno_plan_estudio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    alumno_id = table.Column<int>(type: "integer", nullable: false),
                    plan_estudio_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_alumno_plan_estudio", x => x.id);
                    table.ForeignKey(
                        name: "fk_alumno_plan_estudio_alumno_alumno_id",
                        column: x => x.alumno_id,
                        principalTable: "alumno",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_alumno_plan_estudio_plan_estudio_plan_estudio_id",
                        column: x => x.plan_estudio_id,
                        principalTable: "plan_estudio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "materia_plan_estudio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    materia_id = table.Column<int>(type: "integer", nullable: false),
                    nivel_id = table.Column<int>(type: "integer", nullable: false),
                    plan_estudio_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_materia_plan_estudio", x => x.id);
                    table.ForeignKey(
                        name: "fk_materia_plan_estudio_materia_materia_id",
                        column: x => x.materia_id,
                        principalTable: "materia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_materia_plan_estudio_nivel_nivel_id",
                        column: x => x.nivel_id,
                        principalTable: "nivel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_materia_plan_estudio_plan_estudio_plan_estudio_id",
                        column: x => x.plan_estudio_id,
                        principalTable: "plan_estudio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hora_dia_horario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    hora_dia_id = table.Column<int>(type: "integer", nullable: false),
                    horario_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hora_dia_horario", x => x.id);
                    table.ForeignKey(
                        name: "fk_hora_dia_horario_hora_dia_hora_dia_id",
                        column: x => x.hora_dia_id,
                        principalTable: "hora_dia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hora_dia_horario_horario_horario_id",
                        column: x => x.horario_id,
                        principalTable: "horario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "horario_materia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cupos_disponibles = table.Column<short>(type: "smallint", nullable: false),
                    cupos_total = table.Column<short>(type: "smallint", nullable: false),
                    nro_aula = table.Column<int>(type: "integer", nullable: true),
                    gestion_id = table.Column<int>(type: "integer", nullable: false),
                    grupo_materia_id = table.Column<int>(type: "integer", nullable: false),
                    modulo_id = table.Column<int>(type: "integer", nullable: false),
                    docente_id = table.Column<int>(type: "integer", nullable: true),
                    horario_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_horario_materia", x => x.id);
                    table.ForeignKey(
                        name: "fk_horario_materia_docente_docente_id",
                        column: x => x.docente_id,
                        principalTable: "docente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "fk_horario_materia_gestion_gestion_id",
                        column: x => x.gestion_id,
                        principalTable: "gestion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_horario_materia_grupo_materia_grupo_materia_id",
                        column: x => x.grupo_materia_id,
                        principalTable: "grupo_materia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_horario_materia_horario_horario_id",
                        column: x => x.horario_id,
                        principalTable: "horario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_horario_materia_modulo_modulo_id",
                        column: x => x.modulo_id,
                        principalTable: "modulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prerequisito",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    materia_plan_estudio_id = table.Column<int>(type: "integer", nullable: false),
                    requisito_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_prerequisito", x => x.id);
                    table.CheckConstraint("CK_prereq_no_self", "\"materia_plan_estudio_id\" <> \"requisito_id\"");
                    table.ForeignKey(
                        name: "fk_prerequisito_materia_plan_estudio_materia_plan_estudio_id",
                        column: x => x.materia_plan_estudio_id,
                        principalTable: "materia_plan_estudio",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_prerequisito_materia_plan_estudio_requisito_id",
                        column: x => x.requisito_id,
                        principalTable: "materia_plan_estudio",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "horario_materia_inscripcion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    horario_materia_id = table.Column<int>(type: "integer", nullable: false),
                    inscripcion_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_horario_materia_inscripcion", x => x.id);
                    table.ForeignKey(
                        name: "fk_horario_materia_inscripcion_horario_materia_horario_materia",
                        column: x => x.horario_materia_id,
                        principalTable: "horario_materia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_horario_materia_inscripcion_inscripcion_inscripcion_id",
                        column: x => x.inscripcion_id,
                        principalTable: "inscripcion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nota",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    calificacion = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    alumno_id = table.Column<int>(type: "integer", nullable: false),
                    horario_materia_inscripcion_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_nota", x => x.id);
                    table.ForeignKey(
                        name: "fk_nota_alumno_alumno_id",
                        column: x => x.alumno_id,
                        principalTable: "alumno",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "fk_nota_horario_materia_inscripcion_horario_materia_inscripcio",
                        column: x => x.horario_materia_inscripcion_id,
                        principalTable: "horario_materia_inscripcion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "alumno",
                columns: new[] { "id", "nombre", "ppa", "registro", "telefono" },
                values: new object[,]
                {
                    { 1, "Matias", 0m, 1000000, 7000000 },
                    { 2, "Axel", 0m, 1000001, 7000001 },
                    { 3, "Franco", 0m, 1000002, 7000002 },
                    { 4, "Luis", 0m, 1000003, 7000003 }
                });

            migrationBuilder.InsertData(
                table: "carrera",
                columns: new[] { "id", "codigo", "modalidad", "nombre" },
                values: new object[,]
                {
                    { 1, "185", (short)0, "INGENIERIA EN REDES Y TELECOMUNICACIONES" },
                    { 2, "183", (short)0, "INGENIERIA INFORMATICA" },
                    { 3, "184", (short)0, "INGENIERIA EN SISTEMAS" },
                    { 4, "323", (short)0, "INGENIERIA ROBOTICA" }
                });

            migrationBuilder.InsertData(
                table: "dia",
                columns: new[] { "id", "nombre" },
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
                table: "docente",
                columns: new[] { "id", "ci", "nombre", "telefono" },
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
                table: "gestion",
                columns: new[] { "id", "nombre" },
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
                table: "grupo",
                columns: new[] { "id", "nombre" },
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
                table: "hora",
                columns: new[] { "id", "hr_fin", "hr_inicio" },
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
                table: "horario",
                column: "id",
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
                table: "materia",
                columns: new[] { "id", "credito", "es_electiva", "nombre", "sigla" },
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
                table: "modulo",
                columns: new[] { "id", "nro_modulo" },
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
                table: "nivel",
                columns: new[] { "id", "nombre", "orden" },
                values: new object[,]
                {
                    { 1, "1 SEMESTRE", (short)1 },
                    { 2, "2 SEMESTRE", (short)2 },
                    { 3, "3 SEMESTRE", (short)3 },
                    { 4, "4 SEMESTRE", (short)4 },
                    { 5, "5 SEMESTRE", (short)5 },
                    { 6, "6 SEMESTRE", (short)6 },
                    { 7, "7 SEMESTRE", (short)7 },
                    { 8, "8 SEMESTRE", (short)8 },
                    { 9, "9 SEMESTRE", (short)9 },
                    { 10, "10 SEMESTRE", (short)10 }
                });

            migrationBuilder.InsertData(
                table: "grupo_materia",
                columns: new[] { "id", "grupo_id", "materia_id" },
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
                table: "hora_dia",
                columns: new[] { "id", "dia_id", "hora_id" },
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
                table: "plan_estudio",
                columns: new[] { "id", "carrera_id", "codigo" },
                values: new object[,]
                {
                    { 1, 2, "ING-INF" },
                    { 2, 3, "ING-SIS" },
                    { 3, 1, "ING-RED" },
                    { 4, 4, "ING-ROB" }
                });

            migrationBuilder.InsertData(
                table: "hora_dia_horario",
                columns: new[] { "id", "hora_dia_id", "horario_id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 47, 1 },
                    { 3, 85, 1 },
                    { 4, 3, 2 },
                    { 5, 48, 2 },
                    { 6, 87, 2 },
                    { 7, 5, 3 },
                    { 8, 50, 3 },
                    { 9, 89, 3 },
                    { 10, 6, 4 },
                    { 11, 51, 4 },
                    { 12, 91, 4 },
                    { 13, 7, 5 },
                    { 14, 53, 5 },
                    { 15, 93, 5 },
                    { 16, 9, 6 },
                    { 17, 54, 6 },
                    { 18, 95, 6 },
                    { 19, 11, 7 },
                    { 20, 57, 7 },
                    { 21, 96, 7 },
                    { 22, 13, 8 },
                    { 23, 60, 8 },
                    { 24, 97, 8 },
                    { 25, 14, 9 },
                    { 26, 59, 9 },
                    { 27, 98, 9 },
                    { 28, 15, 10 },
                    { 29, 61, 10 },
                    { 30, 100, 10 },
                    { 31, 16, 11 },
                    { 32, 62, 11 },
                    { 33, 101, 11 },
                    { 34, 18, 12 },
                    { 35, 63, 12 },
                    { 36, 103, 12 },
                    { 37, 20, 13 },
                    { 38, 65, 13 },
                    { 39, 105, 13 },
                    { 40, 19, 14 },
                    { 41, 64, 14 },
                    { 42, 104, 14 },
                    { 43, 1, 15 },
                    { 44, 47, 15 },
                    { 45, 85, 15 },
                    { 46, 106, 15 },
                    { 47, 5, 16 },
                    { 48, 50, 16 },
                    { 49, 89, 16 },
                    { 50, 112, 16 },
                    { 51, 5, 17 },
                    { 52, 50, 17 },
                    { 53, 89, 17 },
                    { 54, 113, 17 },
                    { 55, 14, 18 },
                    { 56, 59, 18 },
                    { 57, 98, 18 },
                    { 58, 107, 18 },
                    { 59, 18, 19 },
                    { 60, 63, 19 },
                    { 61, 103, 19 },
                    { 62, 109, 19 },
                    { 63, 9, 20 },
                    { 64, 54, 20 },
                    { 65, 95, 20 },
                    { 66, 98, 20 },
                    { 67, 11, 21 },
                    { 68, 57, 21 },
                    { 69, 96, 21 },
                    { 70, 105, 21 },
                    { 71, 14, 22 },
                    { 72, 59, 22 },
                    { 73, 98, 22 },
                    { 74, 100, 22 },
                    { 75, 2, 23 },
                    { 76, 46, 23 },
                    { 77, 4, 24 },
                    { 78, 49, 24 },
                    { 79, 10, 25 },
                    { 80, 55, 25 },
                    { 81, 12, 26 },
                    { 82, 58, 26 },
                    { 83, 16, 27 },
                    { 84, 62, 27 },
                    { 85, 17, 28 },
                    { 86, 116, 28 },
                    { 87, 2, 29 },
                    { 88, 46, 29 },
                    { 89, 56, 29 },
                    { 90, 2, 30 },
                    { 91, 67, 30 },
                    { 92, 10, 31 },
                    { 93, 72, 31 },
                    { 94, 96, 31 },
                    { 95, 2, 32 },
                    { 96, 86, 32 },
                    { 97, 21, 32 },
                    { 98, 7, 33 },
                    { 99, 36, 33 },
                    { 100, 76, 33 },
                    { 101, 8, 34 },
                    { 102, 22, 34 },
                    { 103, 67, 34 },
                    { 104, 12, 35 },
                    { 105, 21, 35 },
                    { 106, 94, 35 },
                    { 107, 24, 36 },
                    { 108, 22, 37 },
                    { 109, 67, 37 },
                    { 110, 28, 37 },
                    { 111, 22, 38 },
                    { 112, 67, 38 },
                    { 113, 26, 38 },
                    { 114, 40, 39 },
                    { 115, 79, 39 },
                    { 116, 37, 39 },
                    { 117, 40, 40 },
                    { 118, 79, 40 },
                    { 119, 64, 40 },
                    { 120, 22, 41 },
                    { 121, 67, 41 },
                    { 122, 89, 41 },
                    { 123, 22, 42 },
                    { 124, 67, 42 },
                    { 125, 100, 42 },
                    { 126, 32, 43 },
                    { 127, 72, 43 },
                    { 128, 96, 43 },
                    { 129, 36, 44 },
                    { 130, 76, 44 },
                    { 131, 97, 44 },
                    { 132, 31, 45 },
                    { 133, 58, 45 },
                    { 134, 94, 45 },
                    { 135, 11, 46 },
                    { 136, 33, 46 },
                    { 137, 57, 46 },
                    { 138, 37, 46 },
                    { 139, 49, 47 },
                    { 140, 86, 47 },
                    { 141, 52, 48 },
                    { 142, 90, 48 },
                    { 143, 50, 49 },
                    { 144, 96, 49 },
                    { 145, 111, 49 },
                    { 146, 114, 50 },
                    { 147, 115, 50 },
                    { 148, 64, 51 },
                    { 149, 99, 51 },
                    { 150, 55, 52 },
                    { 151, 110, 52 },
                    { 152, 48, 53 },
                    { 153, 67, 53 },
                    { 154, 88, 53 },
                    { 155, 70, 54 },
                    { 156, 92, 54 },
                    { 157, 22, 55 },
                    { 158, 86, 55 },
                    { 159, 29, 56 },
                    { 160, 95, 56 },
                    { 161, 21, 57 },
                    { 162, 66, 57 },
                    { 163, 106, 57 },
                    { 164, 22, 58 },
                    { 165, 86, 58 },
                    { 166, 21, 59 },
                    { 167, 66, 59 },
                    { 168, 23, 60 },
                    { 169, 68, 60 },
                    { 170, 27, 61 },
                    { 171, 70, 61 },
                    { 172, 31, 72 },
                    { 173, 71, 72 },
                    { 174, 32, 73 },
                    { 175, 72, 73 },
                    { 176, 33, 74 },
                    { 177, 74, 74 },
                    { 178, 34, 75 },
                    { 179, 73, 75 },
                    { 180, 36, 76 },
                    { 181, 76, 76 },
                    { 182, 35, 77 },
                    { 183, 75, 77 },
                    { 184, 38, 78 },
                    { 185, 77, 78 },
                    { 186, 40, 79 },
                    { 187, 79, 79 },
                    { 188, 39, 80 },
                    { 189, 78, 80 },
                    { 190, 41, 81 },
                    { 191, 80, 81 },
                    { 192, 42, 82 },
                    { 193, 81, 82 },
                    { 194, 43, 83 },
                    { 195, 82, 83 },
                    { 196, 44, 84 },
                    { 197, 83, 84 },
                    { 198, 45, 85 },
                    { 199, 84, 85 },
                    { 200, 108, 86 }
                });

            migrationBuilder.InsertData(
                table: "horario_materia",
                columns: new[] { "id", "cupos_disponibles", "cupos_total", "docente_id", "gestion_id", "grupo_materia_id", "horario_id", "modulo_id", "nro_aula" },
                values: new object[,]
                {
                    { 1, (short)30, (short)100, 1, 1, 1, 10, 1, 12 },
                    { 2, (short)30, (short)100, 1, 1, 2, 1, 1, 12 },
                    { 3, (short)30, (short)100, 1, 1, 3, 1, 1, 12 },
                    { 4, (short)30, (short)100, 1, 1, 4, 2, 1, 12 },
                    { 5, (short)30, (short)100, 1, 1, 5, 3, 1, 12 },
                    { 6, (short)30, (short)100, 1, 1, 6, 1, 1, 12 },
                    { 7, (short)30, (short)100, 1, 1, 7, 4, 1, 12 },
                    { 8, (short)30, (short)100, 1, 1, 8, 3, 1, 12 },
                    { 9, (short)30, (short)100, 1, 1, 9, 23, 1, 12 },
                    { 10, (short)30, (short)100, 1, 1, 10, 58, 1, 12 },
                    { 11, (short)30, (short)100, 1, 1, 11, 1, 1, 12 },
                    { 12, (short)30, (short)100, 1, 1, 12, 2, 1, 12 },
                    { 13, (short)30, (short)100, 1, 1, 13, 76, 1, 12 },
                    { 14, (short)30, (short)100, 1, 1, 14, 1, 1, 12 },
                    { 15, (short)30, (short)100, 1, 1, 15, 79, 1, 12 },
                    { 16, (short)30, (short)100, 1, 1, 16, 1, 1, 12 },
                    { 17, (short)30, (short)100, 1, 1, 17, 9, 1, 12 },
                    { 18, (short)30, (short)100, 1, 1, 18, 2, 1, 12 },
                    { 19, (short)30, (short)100, 1, 1, 19, 58, 1, 12 },
                    { 20, (short)30, (short)100, 1, 1, 20, 50, 1, 12 },
                    { 21, (short)30, (short)100, 1, 1, 21, 79, 1, 12 },
                    { 22, (short)30, (short)100, 1, 1, 22, 79, 1, 12 },
                    { 23, (short)30, (short)100, 1, 1, 23, 60, 1, 12 },
                    { 24, (short)30, (short)100, 1, 1, 24, 25, 1, 12 },
                    { 25, (short)30, (short)100, 1, 1, 25, 1, 1, 12 },
                    { 26, (short)30, (short)100, 1, 1, 26, 30, 1, 12 },
                    { 27, (short)30, (short)100, 1, 1, 27, 76, 1, 12 },
                    { 28, (short)30, (short)100, 1, 1, 28, 10, 1, 12 },
                    { 29, (short)30, (short)100, 1, 1, 29, 55, 1, 12 },
                    { 30, (short)30, (short)100, 1, 1, 30, 60, 1, 12 },
                    { 31, (short)30, (short)100, 1, 1, 31, 60, 1, 12 },
                    { 32, (short)30, (short)100, 1, 1, 32, 76, 1, 12 },
                    { 33, (short)30, (short)100, 1, 1, 33, 73, 1, 12 },
                    { 34, (short)30, (short)100, 1, 1, 34, 12, 1, 12 },
                    { 35, (short)30, (short)100, 1, 1, 35, 1, 1, 12 },
                    { 36, (short)30, (short)100, 1, 1, 36, 14, 1, 12 },
                    { 37, (short)30, (short)100, 1, 1, 37, 57, 1, 12 },
                    { 38, (short)30, (short)100, 1, 1, 38, 5, 1, 12 },
                    { 39, (short)30, (short)100, 1, 1, 39, 82, 1, 12 },
                    { 40, (short)30, (short)100, 1, 1, 40, 47, 1, 12 },
                    { 41, (short)30, (short)100, 1, 1, 41, 60, 1, 12 },
                    { 42, (short)30, (short)100, 1, 1, 42, 76, 1, 12 },
                    { 43, (short)30, (short)100, 1, 1, 43, 4, 1, 12 },
                    { 44, (short)30, (short)100, 1, 1, 44, 2, 1, 12 },
                    { 45, (short)30, (short)100, 1, 1, 45, 8, 1, 12 },
                    { 46, (short)30, (short)100, 1, 1, 46, 74, 1, 12 },
                    { 47, (short)30, (short)100, 1, 1, 47, 78, 1, 12 },
                    { 48, (short)30, (short)100, 1, 1, 48, 77, 1, 12 },
                    { 49, (short)30, (short)100, 1, 1, 49, 59, 1, 12 },
                    { 50, (short)30, (short)100, 1, 1, 50, 9, 1, 12 },
                    { 51, (short)30, (short)100, 1, 1, 51, 4, 1, 12 },
                    { 52, (short)30, (short)100, 1, 1, 52, 60, 1, 12 },
                    { 53, (short)30, (short)100, 1, 1, 53, 79, 1, 12 },
                    { 54, (short)30, (short)100, 1, 1, 54, 84, 1, 12 },
                    { 55, (short)30, (short)100, 1, 1, 55, 84, 1, 12 },
                    { 56, (short)30, (short)100, 1, 1, 56, 48, 1, 12 },
                    { 57, (short)30, (short)100, 1, 1, 57, 75, 1, 12 },
                    { 58, (short)30, (short)100, 1, 1, 58, 58, 1, 12 },
                    { 59, (short)30, (short)100, 1, 1, 59, 84, 1, 12 },
                    { 60, (short)30, (short)100, 1, 1, 60, 61, 1, 12 },
                    { 61, (short)30, (short)100, 1, 1, 61, 58, 1, 12 },
                    { 62, (short)30, (short)100, 1, 1, 62, 76, 1, 12 },
                    { 63, (short)30, (short)100, 1, 1, 63, 84, 1, 12 },
                    { 64, (short)30, (short)100, 1, 1, 64, 79, 1, 12 },
                    { 65, (short)30, (short)100, 1, 1, 65, 1, 1, 12 },
                    { 66, (short)30, (short)100, 1, 1, 66, 58, 1, 12 },
                    { 67, (short)30, (short)100, 1, 1, 67, 58, 1, 12 },
                    { 68, (short)30, (short)100, 1, 1, 68, 2, 1, 12 },
                    { 69, (short)30, (short)100, 1, 1, 69, 6, 1, 12 },
                    { 70, (short)30, (short)100, 1, 1, 70, 3, 1, 12 },
                    { 71, (short)30, (short)100, 1, 1, 71, 2, 1, 12 },
                    { 72, (short)30, (short)100, 1, 1, 72, 7, 1, 12 },
                    { 73, (short)30, (short)100, 1, 1, 73, 9, 1, 12 },
                    { 74, (short)30, (short)100, 1, 1, 74, 2, 1, 12 },
                    { 75, (short)30, (short)100, 1, 1, 75, 61, 1, 12 },
                    { 76, (short)30, (short)100, 1, 1, 76, 58, 1, 12 },
                    { 77, (short)30, (short)100, 1, 1, 77, 15, 1, 12 },
                    { 78, (short)30, (short)100, 1, 1, 78, 33, 1, 12 },
                    { 79, (short)30, (short)100, 1, 1, 79, 34, 1, 12 },
                    { 80, (short)30, (short)100, 1, 1, 80, 41, 1, 12 },
                    { 81, (short)30, (short)100, 1, 1, 81, 44, 1, 12 },
                    { 82, (short)30, (short)100, 1, 1, 82, 46, 1, 12 },
                    { 83, (short)30, (short)100, 1, 1, 83, 29, 1, 12 },
                    { 84, (short)30, (short)100, 1, 1, 84, 37, 1, 12 },
                    { 85, (short)30, (short)100, 1, 1, 85, 38, 1, 12 },
                    { 86, (short)30, (short)100, 1, 1, 86, 22, 1, 12 },
                    { 87, (short)30, (short)100, 1, 1, 87, 18, 1, 12 },
                    { 88, (short)30, (short)100, 1, 1, 88, 39, 1, 12 },
                    { 89, (short)30, (short)100, 1, 1, 89, 16, 1, 12 },
                    { 90, (short)30, (short)100, 1, 1, 90, 42, 1, 12 },
                    { 91, (short)30, (short)100, 1, 1, 91, 19, 1, 12 },
                    { 92, (short)30, (short)100, 1, 1, 92, 40, 1, 12 },
                    { 93, (short)30, (short)100, 1, 1, 93, 41, 1, 12 },
                    { 94, (short)30, (short)100, 1, 1, 94, 43, 1, 12 },
                    { 95, (short)30, (short)100, 1, 1, 95, 20, 1, 12 }
                });

            migrationBuilder.InsertData(
                table: "materia_plan_estudio",
                columns: new[] { "id", "materia_id", "nivel_id", "plan_estudio_id" },
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
                table: "prerequisito",
                columns: new[] { "id", "materia_plan_estudio_id", "requisito_id" },
                values: new object[,]
                {
                    { -187, 150, 149 },
                    { -186, 150, 148 },
                    { -185, 150, 146 },
                    { -184, 150, 147 },
                    { -183, 150, 145 },
                    { -182, 149, 142 },
                    { -181, 149, 141 },
                    { -180, 149, 138 },
                    { -179, 149, 140 },
                    { -178, 149, 139 },
                    { -177, 148, 142 },
                    { -176, 148, 141 },
                    { -175, 148, 138 },
                    { -174, 148, 140 },
                    { -173, 148, 139 },
                    { -172, 147, 142 },
                    { -171, 147, 141 },
                    { -170, 147, 138 },
                    { -169, 147, 140 },
                    { -168, 147, 139 },
                    { -167, 146, 142 },
                    { -166, 146, 141 },
                    { -165, 146, 138 },
                    { -164, 146, 140 },
                    { -163, 146, 139 },
                    { -162, 145, 142 },
                    { -161, 145, 141 },
                    { -160, 145, 138 },
                    { -159, 145, 140 },
                    { -158, 145, 139 },
                    { -157, 142, 135 },
                    { -156, 141, 135 },
                    { -155, 141, 131 },
                    { -154, 138, 131 },
                    { -153, 140, 131 },
                    { -152, 139, 133 },
                    { -151, 135, 120 },
                    { -150, 135, 127 },
                    { -149, 134, 114 },
                    { -148, 134, 126 },
                    { -147, 131, 120 },
                    { -146, 131, 123 },
                    { -145, 132, 123 },
                    { -144, 133, 125 },
                    { -143, 127, 112 },
                    { -142, 127, 120 },
                    { -141, 126, 119 },
                    { -140, 125, 121 },
                    { -139, 124, 117 },
                    { -138, 123, 116 },
                    { -137, 120, 106 },
                    { -136, 120, 110 },
                    { -135, 119, 115 },
                    { -134, 118, 115 },
                    { -133, 117, 113 },
                    { -132, 116, 111 },
                    { -131, 115, 109 },
                    { -130, 114, 108 },
                    { -129, 113, 96 },
                    { -128, 113, 107 },
                    { -127, 111, 101 },
                    { -126, 112, 106 },
                    { -125, 110, 104 },
                    { -124, 109, 104 },
                    { -123, 108, 104 },
                    { -122, 108, 103 },
                    { -121, 107, 103 },
                    { -120, 107, 102 },
                    { -119, 106, 101 },
                    { -118, 105, 100 },
                    { -117, 104, 99 },
                    { -116, 103, 98 },
                    { -115, 102, 97 },
                    { -114, 101, 96 },
                    { -113, 95, 93 },
                    { -112, 95, 92 },
                    { -111, 95, 94 },
                    { -110, 95, 91 },
                    { -109, 92, 85 },
                    { -108, 92, 90 },
                    { -107, 94, 87 },
                    { -106, 94, 88 },
                    { -105, 94, 89 },
                    { -104, 90, 83 },
                    { -103, 90, 78 },
                    { -102, 89, 83 },
                    { -101, 88, 82 },
                    { -100, 87, 83 },
                    { -99, 85, 79 },
                    { -98, 83, 76 },
                    { -97, 83, 74 },
                    { -96, 82, 76 },
                    { -95, 82, 75 },
                    { -94, 79, 73 },
                    { -93, 84, 76 },
                    { -92, 84, 74 },
                    { -91, 81, 75 },
                    { -90, 73, 66 },
                    { -89, 74, 69 },
                    { -88, 75, 68 },
                    { -87, 76, 69 },
                    { -86, 78, 71 },
                    { -85, 66, 61 },
                    { -84, 69, 63 },
                    { -83, 68, 63 },
                    { -82, 72, 65 },
                    { -81, 71, 65 },
                    { -80, 62, 56 },
                    { -79, 61, 51 },
                    { -78, 64, 58 },
                    { -77, 63, 57 },
                    { -76, 65, 60 },
                    { -75, 59, 54 },
                    { -74, 56, 51 },
                    { -73, 58, 54 },
                    { -72, 58, 53 },
                    { -71, 57, 52 },
                    { -70, 57, 53 },
                    { -69, 52, 47 },
                    { -68, 51, 46 },
                    { -67, 55, 50 },
                    { -66, 53, 48 },
                    { -65, 54, 49 },
                    { -64, 45, 43 },
                    { -63, 45, 42 },
                    { -62, 45, 44 },
                    { -61, 45, 41 },
                    { -60, 43, 40 },
                    { -59, 43, 39 },
                    { -58, 43, 38 },
                    { -57, 43, 37 },
                    { -56, 43, 36 },
                    { -55, 42, 40 },
                    { -54, 42, 39 },
                    { -53, 42, 38 },
                    { -52, 42, 37 },
                    { -51, 42, 36 },
                    { -50, 44, 40 },
                    { -49, 44, 39 },
                    { -48, 44, 38 },
                    { -47, 44, 37 },
                    { -46, 44, 36 },
                    { -45, 41, 40 },
                    { -44, 41, 39 },
                    { -43, 41, 38 },
                    { -42, 41, 37 },
                    { -41, 41, 36 },
                    { -40, 40, 35 },
                    { -39, 39, 34 },
                    { -38, 38, 35 },
                    { -37, 37, 35 },
                    { -36, 37, 32 },
                    { -35, 36, 31 },
                    { -34, 35, 29 },
                    { -33, 35, 27 },
                    { -32, 34, 28 },
                    { -31, 33, 28 },
                    { -30, 32, 23 },
                    { -29, 32, 30 },
                    { -28, 31, 26 },
                    { -27, 30, 23 },
                    { -26, 30, 25 },
                    { -25, 29, 24 },
                    { -24, 28, 23 },
                    { -23, 27, 24 },
                    { -22, 26, 21 },
                    { -21, 25, 18 },
                    { -20, 24, 18 },
                    { -19, 23, 18 },
                    { -18, 22, 18 },
                    { -17, 21, 16 },
                    { -16, 20, 15 },
                    { -15, 19, 13 },
                    { -14, 18, 12 },
                    { -13, 17, 11 },
                    { -12, 16, 6 },
                    { -11, 14, 9 },
                    { -10, 13, 9 },
                    { -9, 13, 8 },
                    { -8, 12, 8 },
                    { -7, 12, 7 },
                    { -6, 11, 6 },
                    { -5, 10, 5 },
                    { -4, 9, 4 },
                    { -3, 8, 3 },
                    { -2, 7, 2 },
                    { -1, 6, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_alumno_plan_estudio_alumno_id",
                table: "alumno_plan_estudio",
                column: "alumno_id");

            migrationBuilder.CreateIndex(
                name: "ix_alumno_plan_estudio_plan_estudio_id",
                table: "alumno_plan_estudio",
                column: "plan_estudio_id");

            migrationBuilder.CreateIndex(
                name: "ix_grupo_materia_grupo_id",
                table: "grupo_materia",
                column: "grupo_id");

            migrationBuilder.CreateIndex(
                name: "ix_grupo_materia_materia_id",
                table: "grupo_materia",
                column: "materia_id");

            migrationBuilder.CreateIndex(
                name: "ix_hora_dia_dia_id",
                table: "hora_dia",
                column: "dia_id");

            migrationBuilder.CreateIndex(
                name: "ix_hora_dia_hora_id",
                table: "hora_dia",
                column: "hora_id");

            migrationBuilder.CreateIndex(
                name: "ix_hora_dia_horario_hora_dia_id",
                table: "hora_dia_horario",
                column: "hora_dia_id");

            migrationBuilder.CreateIndex(
                name: "ix_hora_dia_horario_horario_id",
                table: "hora_dia_horario",
                column: "horario_id");

            migrationBuilder.CreateIndex(
                name: "ix_horario_materia_docente_id",
                table: "horario_materia",
                column: "docente_id");

            migrationBuilder.CreateIndex(
                name: "ix_horario_materia_gestion_id",
                table: "horario_materia",
                column: "gestion_id");

            migrationBuilder.CreateIndex(
                name: "ix_horario_materia_grupo_materia_id",
                table: "horario_materia",
                column: "grupo_materia_id");

            migrationBuilder.CreateIndex(
                name: "ix_horario_materia_horario_id",
                table: "horario_materia",
                column: "horario_id");

            migrationBuilder.CreateIndex(
                name: "ix_horario_materia_modulo_id",
                table: "horario_materia",
                column: "modulo_id");

            migrationBuilder.CreateIndex(
                name: "ix_horario_materia_inscripcion_horario_materia_id",
                table: "horario_materia_inscripcion",
                column: "horario_materia_id");

            migrationBuilder.CreateIndex(
                name: "ix_horario_materia_inscripcion_inscripcion_id",
                table: "horario_materia_inscripcion",
                column: "inscripcion_id");

            migrationBuilder.CreateIndex(
                name: "ix_inscripcion_alumno_id",
                table: "inscripcion",
                column: "alumno_id");

            migrationBuilder.CreateIndex(
                name: "ix_materia_plan_estudio_materia_id",
                table: "materia_plan_estudio",
                column: "materia_id");

            migrationBuilder.CreateIndex(
                name: "ix_materia_plan_estudio_nivel_id",
                table: "materia_plan_estudio",
                column: "nivel_id");

            migrationBuilder.CreateIndex(
                name: "ix_materia_plan_estudio_plan_estudio_id",
                table: "materia_plan_estudio",
                column: "plan_estudio_id");

            migrationBuilder.CreateIndex(
                name: "ix_nota_alumno_id",
                table: "nota",
                column: "alumno_id");

            migrationBuilder.CreateIndex(
                name: "ix_nota_horario_materia_inscripcion_id",
                table: "nota",
                column: "horario_materia_inscripcion_id");

            migrationBuilder.CreateIndex(
                name: "ix_plan_estudio_carrera_id",
                table: "plan_estudio",
                column: "carrera_id");

            migrationBuilder.CreateIndex(
                name: "ix_prerequisito_materia_plan_estudio_id_requisito_id",
                table: "prerequisito",
                columns: new[] { "materia_plan_estudio_id", "requisito_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_prerequisito_requisito_id",
                table: "prerequisito",
                column: "requisito_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alumno_plan_estudio");

            migrationBuilder.DropTable(
                name: "hora_dia_horario");

            migrationBuilder.DropTable(
                name: "nota");

            migrationBuilder.DropTable(
                name: "prerequisito");

            migrationBuilder.DropTable(
                name: "hora_dia");

            migrationBuilder.DropTable(
                name: "horario_materia_inscripcion");

            migrationBuilder.DropTable(
                name: "materia_plan_estudio");

            migrationBuilder.DropTable(
                name: "dia");

            migrationBuilder.DropTable(
                name: "hora");

            migrationBuilder.DropTable(
                name: "horario_materia");

            migrationBuilder.DropTable(
                name: "inscripcion");

            migrationBuilder.DropTable(
                name: "nivel");

            migrationBuilder.DropTable(
                name: "plan_estudio");

            migrationBuilder.DropTable(
                name: "docente");

            migrationBuilder.DropTable(
                name: "gestion");

            migrationBuilder.DropTable(
                name: "grupo_materia");

            migrationBuilder.DropTable(
                name: "horario");

            migrationBuilder.DropTable(
                name: "modulo");

            migrationBuilder.DropTable(
                name: "alumno");

            migrationBuilder.DropTable(
                name: "carrera");

            migrationBuilder.DropTable(
                name: "grupo");

            migrationBuilder.DropTable(
                name: "materia");
        }
    }
}
