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
                    registro = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    nombre = table.Column<string>(type: "character varying(63)", maxLength: 63, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    nombre = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    ci = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    nombre = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    nombre = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    hr_fin = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    sigla = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    nro_modulo = table.Column<short>(type: "smallint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    orden = table.Column<short>(type: "smallint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    alumno_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    carrera_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    hora_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    materia_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    plan_estudio_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    plan_estudio_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    horario_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    horario_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    materia_plan_estudio_id = table.Column<int>(type: "integer", nullable: false),
                    requisito_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_prerequisito", x => new { x.materia_plan_estudio_id, x.requisito_id });
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
                    inscripcion_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    horario_materia_inscripcion_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                columns: new[] { "id", "created_at", "nombre", "ppa", "registro", "telefono", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(8777), "Matias", 0m, 1000000, 7000000, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(8783) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(8787), "Axel", 0m, 1000001, 7000001, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(8787) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(8788), "Franco", 0m, 1000002, 7000002, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(8789) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(8790), "Luis", 0m, 1000003, 7000003, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(8790) }
                });

            migrationBuilder.InsertData(
                table: "carrera",
                columns: new[] { "id", "codigo", "created_at", "modalidad", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, "185", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9069), (short)0, "INGENIERIA EN REDES Y TELECOMUNICACIONES", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9070) },
                    { 2, "183", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9073), (short)0, "INGENIERIA INFORMATICA", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9073) },
                    { 3, "184", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9074), (short)0, "INGENIERIA EN SISTEMAS", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9075) },
                    { 4, "323", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9076), (short)0, "INGENIERIA ROBOTICA", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9076) }
                });

            migrationBuilder.InsertData(
                table: "dia",
                columns: new[] { "id", "created_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9208), "LUNES", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9208) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9210), "MARTES", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9210) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9211), "MIERCOLES", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9211) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9213), "JUEVES", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9213) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9214), "VIERNES", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9214) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9215), "SABADO", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9215) }
                });

            migrationBuilder.InsertData(
                table: "docente",
                columns: new[] { "id", "ci", "created_at", "nombre", "telefono", "updated_at" },
                values: new object[,]
                {
                    { 1, 15157488, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9339), "FLORES GUZMAN VALENTIN VICTOR", 78481515L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9340) },
                    { 2, 15157489, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9344), "LOBO LIMPIAS VICTOR HUGO", 78481516L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9345) },
                    { 3, 15157490, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9346), "ARANIBAR QUIROZ MARTHA MONICA", 78481517L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9346) },
                    { 4, 15157491, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9347), "SANCHEZ VELASCO ENRIQUE", 78481518L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9347) },
                    { 5, 15157492, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9349), "CALDERON FLORES MODESTO FRANKLIN", 78481519L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9349) },
                    { 6, 15157493, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9350), "LAZO ARTEAGA CARLOS ROBERTO", 78481520L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9350) },
                    { 7, 15157494, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9351), "ZUNA VILLAGOMEZ RICARDO", 78481521L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9352) },
                    { 8, 15157495, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9353), "MOLLO MAMANI ALBERTO", 78481522L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9353) },
                    { 9, 15157496, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9354), "ALIAGA HOWARD SHARON KENNY", 78481523L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9355) },
                    { 10, 15157497, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9356), "CONTRERAS VILLEGAS JUAN CARLOS", 78481524L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9356) },
                    { 11, 15157498, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9357), "MARTINEZ CARDONA SARAH MIRNA", 78481525L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9357) },
                    { 12, 15157499, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9422), "CACERES CHACON BRAULIO", 78481526L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9423) },
                    { 13, 15157500, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9424), "GUTIERREZ BRUNO KATIME ESTHER", 78481527L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9424) },
                    { 14, 15157501, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9425), "APAZA LEON ROSNAY", 78481528L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9426) },
                    { 15, 15157502, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9427), "ZUNIGA RUIZ WILMA", 78481529L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9427) },
                    { 16, 15157503, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9428), "CLAURE MEDRANO DE OROPEZA ELIZ", 78481530L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9429) },
                    { 17, 15157504, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9430), "AVENDANO GONZALES EUDAL", 78481531L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9430) },
                    { 18, 15157505, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9431), "OROPEZA CLAURE GUSTAVO ADOLFO", 78481532L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9431) },
                    { 19, 15157506, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9433), "VALDELOMAR ORELLANA TOMAS", 78481533L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9433) },
                    { 20, 15157507, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9434), "ACOSTA CABEZAS BARTOLO JAVIER", 78481534L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9434) },
                    { 21, 15157508, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9435), "CALDERON FLORES PIODESTO FRANKL", 78481535L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9436) },
                    { 22, 15157509, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9437), "ZEBALLOS PAREDES DANIEL LUIS", 78481536L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9437) },
                    { 23, 15157510, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9438), "MOLLO NAL4ANI ALBERTO", 78481537L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9438) },
                    { 24, 15157511, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9440), "GRIMALDO BRAVO PAUL", 78481538L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9441) },
                    { 25, 15157512, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9442), "LAZO ARTEAGA CARLOS ROBERTO", 78481539L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9442) },
                    { 26, 15157513, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9444), "GONZALES APARICIO MELISSA", 78481540L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9444) },
                    { 27, 15157514, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9445), "ORTEGA PAREDES FRANCISCO", 78481541L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9445) },
                    { 28, 15157515, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9446), "VILLARROEL RIVERA NATALIA", 78481542L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9447) },
                    { 29, 15157516, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9448), "CARRASCO CORDOVA LUIS", 78481543L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9448) },
                    { 30, 15157517, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9449), "MEDINA LOPEZ GLORIA", 78481544L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9449) },
                    { 31, 15157518, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9450), "MENDOZA CASTRO MARCO", 78481545L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9450) },
                    { 32, 15157519, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9452), "ALVAREZ ROMERO SANDRA", 78481546L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9452) },
                    { 33, 15157520, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9453), "RAMIREZ HUERTA CARLOS", 78481547L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9453) },
                    { 34, 15157521, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9454), "ESCOBAR FLORES VERONICA", 78481548L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9454) },
                    { 35, 15157522, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9455), "CASTILLO GOMEZ JUAN", 78481549L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9456) },
                    { 36, 15157523, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9457), "PEREZ SALAZAR LILIANA", 78481550L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9457) },
                    { 37, 15157524, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9458), "TORRES QUISPE RICARDO", 78481551L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9458) },
                    { 38, 15157525, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9459), "HUAMAN FLORES MIRIAM", 78481552L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9460) },
                    { 39, 15157526, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9461), "CHAVEZ LOPEZ EDWIN", 78481553L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9461) },
                    { 40, 15157527, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9462), "GARCIA VILLENA KARINA", 78481554L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9462) },
                    { 41, 15157528, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9463), "RODRIGUEZ SALAZAR LUIS", 78481555L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9464) },
                    { 42, 15157529, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9465), "FERNANDEZ CASTRO MARIA", 78481556L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9465) },
                    { 43, 15157530, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9466), "MARTINEZ HUAMAN PABLO", 78481557L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9466) },
                    { 44, 15157531, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9467), "QUISPE RAMOS GLADYS", 78481558L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9468) },
                    { 45, 15157532, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9469), "SALAZAR MORENO JULIO", 78481559L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9469) },
                    { 46, 15157533, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9470), "LOPEZ RIVERA ANGELA", 78481560L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9470) },
                    { 47, 15157534, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9471), "VILLANUEVA PEREZ CARLOS", 78481561L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9471) },
                    { 48, 15157535, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9473), "ORTEGA SALAZAR FABIOLA", 78481562L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9473) },
                    { 49, 15157536, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9474), "GOMEZ HUAMAN MARIO", 78481563L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9474) },
                    { 50, 15157537, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9475), "CARRASCO LOPEZ ELISA", 78481564L, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9475) }
                });

            migrationBuilder.InsertData(
                table: "gestion",
                columns: new[] { "id", "created_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9650), "1/2025", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9650) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9652), "2/2025", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9652) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9653), "3/2025", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9654) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9654), "4/2025", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9655) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9656), "1/2024", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9656) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9657), "2/2024", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9657) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9658), "3/2024", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9658) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9659), "4/2024", new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9659) }
                });

            migrationBuilder.InsertData(
                table: "grupo",
                columns: new[] { "id", "created_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(457), "SA", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(457) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(459), "SB", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(459) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(460), "SC", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(461) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(462), "SD", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(462) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(463), "SE", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(463) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(464), "SF", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(464) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(508), "SG", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(509) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(510), "SH", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(510) },
                    { 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(511), "SI", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(511) },
                    { 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(512), "SK", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(512) },
                    { 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(513), "SN", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(513) },
                    { 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(514), "SM", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(514) },
                    { 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(515), "SP", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(515) },
                    { 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(516), "SR", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(516) },
                    { 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(517), "SS", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(517) },
                    { 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(518), "SX", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(518) },
                    { 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(519), "SZ", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(519) },
                    { 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(520), "F1", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(520) },
                    { 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(521), "BI", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(521) },
                    { 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(522), "CI", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(522) },
                    { 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(523), "C1", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(523) },
                    { 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(524), "I2", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(524) },
                    { 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(525), "ER", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(525) },
                    { 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(526), "R1", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(526) },
                    { 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(527), "1I", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(527) },
                    { 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(528), "I1", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(528) },
                    { 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(529), "NW", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(529) },
                    { 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(530), "NX", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(530) },
                    { 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(531), "W1", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(531) },
                    { 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(532), "X2", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(533) },
                    { 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(533), "X3", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(534) },
                    { 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(534), "X4", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(535) },
                    { 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(535), "Z1", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(536) },
                    { 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(536), "Z2", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(537) },
                    { 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(537), "Z3", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(538) },
                    { 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(538), "Z4", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(539) },
                    { 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(539), "Z5", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(540) },
                    { 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(540), "Z6", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(541) }
                });

            migrationBuilder.InsertData(
                table: "hora",
                columns: new[] { "id", "created_at", "hr_fin", "hr_inicio", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2965), new TimeOnly(8, 30, 0), new TimeOnly(7, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2966) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2969), new TimeOnly(10, 0, 0), new TimeOnly(8, 30, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2969) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2971), new TimeOnly(11, 30, 0), new TimeOnly(10, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2971) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2972), new TimeOnly(13, 0, 0), new TimeOnly(11, 30, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2972) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2973), new TimeOnly(14, 30, 0), new TimeOnly(13, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2974) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2975), new TimeOnly(16, 0, 0), new TimeOnly(14, 30, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2975) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2976), new TimeOnly(9, 15, 0), new TimeOnly(7, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2976) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2977), new TimeOnly(11, 30, 0), new TimeOnly(9, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2978) },
                    { 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2979), new TimeOnly(13, 0, 0), new TimeOnly(11, 30, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2979) },
                    { 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2980), new TimeOnly(18, 15, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2980) },
                    { 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3020), new TimeOnly(20, 30, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3020) },
                    { 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3021), new TimeOnly(22, 45, 0), new TimeOnly(20, 30, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3021) },
                    { 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3022), new TimeOnly(12, 15, 0), new TimeOnly(10, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3023) },
                    { 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3024), new TimeOnly(13, 45, 0), new TimeOnly(11, 30, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3024) },
                    { 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3025), new TimeOnly(16, 0, 0), new TimeOnly(13, 45, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3025) },
                    { 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3026), new TimeOnly(16, 45, 0), new TimeOnly(15, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3027) },
                    { 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3028), new TimeOnly(17, 30, 0), new TimeOnly(15, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3028) },
                    { 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3029), new TimeOnly(19, 0, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3029) },
                    { 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3030), new TimeOnly(21, 15, 0), new TimeOnly(19, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3030) },
                    { 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3032), new TimeOnly(20, 30, 0), new TimeOnly(19, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3032) },
                    { 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3033), new TimeOnly(22, 0, 0), new TimeOnly(19, 45, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3033) },
                    { 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3034), new TimeOnly(13, 0, 0), new TimeOnly(10, 45, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3034) },
                    { 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3036), new TimeOnly(15, 15, 0), new TimeOnly(13, 45, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3036) },
                    { 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3037), new TimeOnly(15, 15, 0), new TimeOnly(13, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3037) },
                    { 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3038), new TimeOnly(16, 45, 0), new TimeOnly(15, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3038) },
                    { 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3039), new TimeOnly(17, 30, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3040) },
                    { 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3041), new TimeOnly(18, 15, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3041) },
                    { 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3042), new TimeOnly(19, 45, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3042) },
                    { 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3043), new TimeOnly(21, 15, 0), new TimeOnly(19, 45, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3044) },
                    { 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3045), new TimeOnly(22, 45, 0), new TimeOnly(21, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3045) },
                    { 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3046), new TimeOnly(22, 0, 0), new TimeOnly(20, 30, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3046) },
                    { 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3047), new TimeOnly(13, 45, 0), new TimeOnly(12, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3048) },
                    { 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3049), new TimeOnly(19, 45, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3049) },
                    { 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3050), new TimeOnly(10, 45, 0), new TimeOnly(9, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3050) },
                    { 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3051), new TimeOnly(11, 30, 0), new TimeOnly(8, 30, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3052) },
                    { 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3053), new TimeOnly(16, 0, 0), new TimeOnly(13, 0, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3053) },
                    { 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3054), new TimeOnly(12, 15, 0), new TimeOnly(9, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3054) },
                    { 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3055), new TimeOnly(21, 15, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3056) }
                });

            migrationBuilder.InsertData(
                table: "horario",
                columns: new[] { "id", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2653), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2653) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2655), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2655) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2656), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2657) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2657), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2658) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2658), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2659) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2660), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2660) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2661), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2661) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2662), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2662) },
                    { 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2663), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2663) },
                    { 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2664), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2664) },
                    { 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2665), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2665) },
                    { 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2666), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2666) },
                    { 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2667), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2668) },
                    { 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2668), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2669) },
                    { 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2670), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2670) },
                    { 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2671), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2671) },
                    { 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2672), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2672) },
                    { 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2673), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2673) },
                    { 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2674), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2674) },
                    { 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2675), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2675) },
                    { 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2676), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2676) },
                    { 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2677), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2678) },
                    { 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2678), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2679) },
                    { 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2680), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2680) },
                    { 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2681), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2681) },
                    { 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2682), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2682) },
                    { 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2683), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2684) },
                    { 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2684), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2685) },
                    { 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2686), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2686) },
                    { 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2687), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2687) },
                    { 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2688), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2688) },
                    { 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2689), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2689) },
                    { 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2690), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2690) },
                    { 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2691), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2691) },
                    { 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2692), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2692) },
                    { 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2693), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2693) },
                    { 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2694), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2694) },
                    { 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2695), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2696) },
                    { 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2696), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2697) },
                    { 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2698), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2698) },
                    { 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2699), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2699) },
                    { 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2700), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2700) },
                    { 43, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2701), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2701) },
                    { 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2702), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2702) },
                    { 45, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2703), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2704) },
                    { 46, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2704), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2705) },
                    { 47, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2705), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2706) },
                    { 48, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2707), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2707) },
                    { 49, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2708), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2708) },
                    { 50, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2709), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2709) },
                    { 51, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2710), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2710) },
                    { 52, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2711), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2711) },
                    { 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2750), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2750) },
                    { 54, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2751), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2751) },
                    { 55, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2752), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2753) },
                    { 56, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2753), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2754) },
                    { 57, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2754), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2755) },
                    { 58, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2756), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2756) },
                    { 59, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2757), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2757) },
                    { 60, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2758), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2758) },
                    { 61, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2759), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2759) },
                    { 62, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2760), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2760) },
                    { 63, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2761), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2761) },
                    { 64, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2762), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2762) },
                    { 65, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2763), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2764) },
                    { 66, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2764), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2765) },
                    { 67, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2765), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2766) },
                    { 68, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2766), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2767) },
                    { 69, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2768), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2768) },
                    { 70, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2769), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2769) },
                    { 71, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2770), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2770) },
                    { 72, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2771), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2771) },
                    { 73, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2772), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2772) },
                    { 74, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2773), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2773) },
                    { 75, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2774), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2774) },
                    { 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2775), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2776) },
                    { 77, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2776), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2777) },
                    { 78, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2777), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2778) },
                    { 79, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2778), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2779) },
                    { 80, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2779), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2780) },
                    { 81, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2780), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2781) },
                    { 82, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2782), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2782) },
                    { 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2783), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2783) },
                    { 84, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2784), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2784) },
                    { 85, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2785), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2785) },
                    { 86, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2786), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2786) },
                    { 87, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2787), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2787) }
                });

            migrationBuilder.InsertData(
                table: "materia",
                columns: new[] { "id", "created_at", "credito", "es_electiva", "nombre", "sigla", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3867), (short)5, false, "CÁLCULO I", "MAT101", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3868) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3871), (short)5, false, "ESTRUCTURAS DISCRETAS", "INF119", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3872) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3873), (short)5, false, "INTRODUCCIÓN A LA INFORMÁTICA", "INF110", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3873) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3875), (short)5, false, "FÍSICA I", "FIS100", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3875) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3876), (short)5, false, "INGLÉS TÉCNICO I", "LIN100", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3876) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3877), (short)5, false, "CÁLCULO II", "MAT102", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3878) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3879), (short)5, false, "ÁLGEBRA LINEAL", "MAT103", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3879) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3880), (short)5, false, "PROGRAMACIÓN I", "INF120", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3881) },
                    { 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3882), (short)5, false, "FÍSICA II", "FIS102", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3882) },
                    { 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3883), (short)5, false, "INGLÉS TÉCNICO II", "LIN101", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3883) },
                    { 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3885), (short)5, false, "ECUACIONES DIFERENCIALES", "MAT207", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3885) },
                    { 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3886), (short)5, false, "PROGRAMACIÓN II", "INF210", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3886) },
                    { 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3887), (short)5, false, "ARQUITECTURA DE COMPUTADORAS", "INF211", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3888) },
                    { 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3889), (short)6, false, "FÍSICA III", "FIS200", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3889) },
                    { 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3890), (short)4, false, "ADMINISTRACIÓN", "ADM100", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3891) },
                    { 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3892), (short)5, false, "PROBABILIDAD Y ESTADÍSTICA I", "MAT202", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3892) },
                    { 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3893), (short)5, false, "MÉTODOS NUMÉRICOS", "MAT205", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3893) },
                    { 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3894), (short)5, false, "ESTRUCTURA DE DATOS I", "INF220", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3895) },
                    { 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3896), (short)5, false, "PROGRAMACIÓN ENSAMBLADOR", "INF221", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3896) },
                    { 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3897), (short)4, false, "CONTABILIDAD", "ADM200", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3897) },
                    { 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3899), (short)5, false, "PROBABILIDAD Y ESTADÍSTICA II", "MAT302", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3899) },
                    { 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3900), (short)5, false, "PROGRAMACIÓN LÓGICA Y FUNCIONAL", "INF318", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3900) },
                    { 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3902), (short)5, false, "ESTRUCTURA DE DATOS II", "INF310", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3902) },
                    { 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3903), (short)5, false, "BASE DE DATOS I", "INF312", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3903) },
                    { 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3904), (short)5, false, "LENGUAJES FORMALES", "INF319", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3905) },
                    { 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3908), (short)5, false, "INVESTIGACIÓN OPERATIVA I", "MAT329", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3909) },
                    { 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3910), (short)5, false, "SISTEMAS DE INFORMACIÓN I", "INF342", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3910) },
                    { 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3911), (short)5, false, "SISTEMAS OPERATIVOS I", "INF323", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3912) },
                    { 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3913), (short)5, false, "BASE DE DATOS II", "INF322", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3913) },
                    { 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3914), (short)5, false, "COMPILADORES", "INF329", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3915) },
                    { 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3917), (short)5, false, "INVESTIGACIÓN OPERATIVA II", "MAT419", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3918) },
                    { 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3919), (short)5, false, "INTELIGENCIA ARTIFICIAL", "INF418", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3919) },
                    { 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3920), (short)5, false, "SISTEMAS OPERATIVOS II", "INF413", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3920) },
                    { 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3922), (short)5, false, "REDES I", "INF433", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3922) },
                    { 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3923), (short)5, false, "INGENIERÍA DE SOFTWARE I", "INF422", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3923) },
                    { 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3926), (short)5, false, "PREPARACIÓN Y EVALUACIÓN DE PROYECTOS", "ECO449", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3926) },
                    { 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3927), (short)5, false, "SISTEMAS EXPERTOS", "INF428", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3928) },
                    { 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3929), (short)5, false, "SISTEMAS DE INFORMACIÓN II", "INF412", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3929) },
                    { 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3930), (short)5, false, "REDES II", "INF423", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3930) },
                    { 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3932), (short)5, false, "INGENIERÍA DE SOFTWARE II", "INF512", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3932) },
                    { 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3998), (short)5, false, "TALLER DE GRADO I", "INF511", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3998) },
                    { 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4000), (short)5, false, "TECNOLOGÍA WEB", "INF513", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4000) },
                    { 43, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4001), (short)4, false, "ARQUITECTURA DE SOFTWARE", "INF552", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4002) },
                    { 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4003), (short)4, false, "SISTEMAS DE INFORMACIÓN GEOGRÁFICA", "INF442", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4003) },
                    { 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3906), (short)5, false, "ORGANIZACIÓN Y MÉTODOS", "ADM330", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3906) },
                    { 54, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3907), (short)5, false, "ECONOMÍA PARA LA GESTIÓN", "ECO300", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3907) },
                    { 55, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3916), (short)5, false, "FINANZAS PARA LA EMPRESA", "ADM320", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3916) },
                    { 56, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3924), (short)5, false, "SISTEMAS PARA EL SOPORTE A LA TOMA DE DECISIONES", "INF432", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3925) },
                    { 57, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3933), (short)4, false, "AUDITORÍA INFORMÁTICA", "INF462", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3933) },
                    { 58, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4004), (short)5, false, "MODALIDAD DE GRADUACIÓN", "GRLO01", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4004) },
                    { 59, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4006), (short)10, true, "MODELACIÓN Y SIMULACIÓN DE SISTEMAS", "ELCI01", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4006) },
                    { 60, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4007), (short)10, true, "PROGRAMACIÓN GRÁFICA", "ELCI02", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4007) },
                    { 61, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4008), (short)10, true, "TÓPICOS AVANZADOS DE PROGRAMACIÓN", "ELCI03", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4009) },
                    { 62, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4010), (short)10, true, "PROGRAMACIÓN DE APLICACIONES DE TIEMPO REAL", "ELCI04", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4010) },
                    { 63, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4011), (short)10, true, "SISTEMAS DISTRIBUIDOS", "ELCI05", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4012) },
                    { 64, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4013), (short)10, true, "INTERACCIÓN HOMBRE COMPUTADOR", "ELCI06", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4013) },
                    { 65, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4014), (short)10, true, "CRIPTOGRAFÍA Y SEGURIDAD", "ELCI07", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4014) },
                    { 66, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4016), (short)10, true, "CONTROL AND AUTOMATIZACIÓN", "ELCI08", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4016) },
                    { 67, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4017), (short)3, true, "ADMINISTRACIÓN DE RECURSOS HUMANOS", "ELC001", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4017) },
                    { 68, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4020), (short)3, true, "COSTOS Y PRESUPUESTOS", "ELC002", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4021) },
                    { 69, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4022), (short)3, true, "PRODUCCIÓN Y MARKETING", "ELC003", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4022) },
                    { 70, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4023), (short)3, true, "REINGENIERÍA", "ELC004", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4023) },
                    { 71, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4025), (short)3, true, "INGENIERÍA DE LA CALIDAD", "ELC005", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4025) },
                    { 72, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4026), (short)3, true, "BENCHMARKING", "ELC006", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4026) },
                    { 73, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4027), (short)3, true, "INTRODUCCIÓN A LA MACROECONOMÍA", "ELC007", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4028) },
                    { 74, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4029), (short)3, true, "LEGISLACIÓN EN CIENCIAS DE LA COMPUTACIÓN", "ELC008", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4029) },
                    { 75, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4030), (short)5, false, "ANÁLISIS DE CIRCUITOS", "RDS210", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4030) },
                    { 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4032), (short)5, false, "TEORÍA DE CAMPOS", "ELT241", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4032) },
                    { 77, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4033), (short)4, false, "ANÁLISIS DE CIRCUITOS ELECTRÓNICOS", "RDS220", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4033) },
                    { 78, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4034), (short)5, false, "ELECTRÓNICA APLICADA A REDES", "RDS310", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4035) },
                    { 79, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4036), (short)5, false, "SISTEMAS LÓGICOS Y DIGITALES I", "ELT352", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4036) },
                    { 80, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4037), (short)5, false, "SEÑALES Y SISTEMAS", "ELT354", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4037) },
                    { 81, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4039), (short)5, true, "DISEÑO DE CIRCUITOS INTEGRADOS", "ELC201", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4039) },
                    { 82, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4040), (short)5, true, "INSTRUMENTACIÓN", "ELC202", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4040) },
                    { 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4041), (short)5, false, "SISTEMAS LÓGICOS Y DIGITALES II", "ELT362", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4042) },
                    { 84, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4043), (short)5, false, "INTERPRETACIÓN DE SISTEMAS Y SEÑALES", "RDS320", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4043) },
                    { 85, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4044), (short)5, true, "SISTEMAS DE COMUNICACIÓN SCADA", "ELC203", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4045) },
                    { 86, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4046), (short)5, true, "TELEVISIÓN DIGITAL", "ELC204", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4046) },
                    { 87, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4047), (short)5, false, "APLICACIONES CON MICROPROCESADORES", "RDS410", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4047) },
                    { 88, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4049), (short)5, false, "SISTEMAS DE COMUNICACIÓN I", "ELT374", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4049) },
                    { 89, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4050), (short)5, true, "DOMÓTICA", "ELC205", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4050) },
                    { 90, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4051), (short)5, false, "LÍNEAS DE TRANSMISIÓN Y ANTENAS", "ELC206", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4052) },
                    { 91, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4053), (short)5, false, "TALLER DE ANÁLISIS Y DISEÑO DE REDES", "RDS421", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4053) },
                    { 92, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4054), (short)5, false, "LEGISLACIÓN EN REDES Y COMUNICACIONES", "RS429", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4055) },
                    { 93, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4056), (short)5, false, "SISTEMAS DE COMUNICACIÓN II", "ELC384", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4056) },
                    { 94, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4057), (short)5, true, "TÉCNICAS DE PRESENTACIÓN PARA INGENIERÍA", "ELC207", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4057) },
                    { 95, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4058), (short)5, true, "REDES ADHOC", "ELC208", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4059) },
                    { 96, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4060), (short)5, false, "GESTIÓN Y ADMINISTRACIÓN DE REDES", "RDS511", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4060) },
                    { 97, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4061), (short)5, false, "REDES INALÁMBRICAS Y COMUNICACIONES MÓVILES", "RDS512", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4062) },
                    { 98, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4063), (short)5, false, "SEGURIDAD EN REDES Y TRANSMISIÓN DE DATOS", "RDS519", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4063) },
                    { 99, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4064), (short)5, false, "MODALIDAD DE TITULACIÓN A NIVEL TÉCNICO SUPERIOR", "GRT001", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4064) },
                    { 100, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4066), (short)5, false, "MODALIDAD DE TITULACIÓN LICENCIATURA", "GRL001", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4066) }
                });

            migrationBuilder.InsertData(
                table: "modulo",
                columns: new[] { "id", "created_at", "nro_modulo", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4334), (short)236, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4334) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4336), (short)225, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4336) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4337), (short)260, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4337) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4338), (short)224, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4338) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4339), (short)256, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4339) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4340), (short)222, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4340) }
                });

            migrationBuilder.InsertData(
                table: "nivel",
                columns: new[] { "id", "created_at", "nombre", "orden", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4477), "1 SEMESTRE", (short)1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4477) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4480), "2 SEMESTRE", (short)2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4480) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4481), "3 SEMESTRE", (short)3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4481) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4482), "4 SEMESTRE", (short)4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4483) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4484), "5 SEMESTRE", (short)5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4484) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4485), "6 SEMESTRE", (short)6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4485) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4486), "7 SEMESTRE", (short)7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4486) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4487), "8 SEMESTRE", (short)8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4487) },
                    { 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4488), "9 SEMESTRE", (short)9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4488) },
                    { 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4489), "10 SEMESTRE", (short)10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4490) }
                });

            migrationBuilder.InsertData(
                table: "grupo_materia",
                columns: new[] { "id", "created_at", "grupo_id", "materia_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9825), 1, 15, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9825) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9828), 2, 15, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9828) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9829), 3, 15, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9830) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9830), 1, 7, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9831) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9832), 2, 7, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9832) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9833), 3, 7, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9833) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9834), 4, 7, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9834) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9835), 5, 7, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9835) },
                    { 9, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9836), 6, 7, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9837) },
                    { 10, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9838), 1, 75, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9838) },
                    { 11, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9839), 2, 75, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9839) },
                    { 12, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9840), 17, 77, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9840) },
                    { 13, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9841), 1, 87, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9841) },
                    { 14, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9842), 1, 13, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9843) },
                    { 15, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9844), 2, 13, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9844) },
                    { 16, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9845), 1, 43, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9845) },
                    { 17, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9846), 1, 57, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9846) },
                    { 18, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9847), 1, 24, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9847) },
                    { 19, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9848), 3, 24, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9848) },
                    { 20, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9849), 2, 29, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9850) },
                    { 21, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9851), 4, 29, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9851) },
                    { 22, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9852), 18, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9852) },
                    { 23, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9853), 17, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9853) },
                    { 24, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9854), 20, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9854) },
                    { 25, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9855), 22, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9855) },
                    { 26, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9856), 6, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9857) },
                    { 27, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9857), 7, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9858) },
                    { 28, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9859), 9, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9859) },
                    { 29, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9860), 13, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9860) },
                    { 30, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9861), 33, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9861) },
                    { 31, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9862), 34, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9862) },
                    { 32, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9863), 35, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9863) },
                    { 33, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9864), 36, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9864) },
                    { 34, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9865), 37, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9866) },
                    { 35, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9866), 38, 1, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9867) },
                    { 36, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9868), 2, 6, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9868) },
                    { 37, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9869), 4, 6, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9869) },
                    { 38, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9870), 24, 6, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9870) },
                    { 39, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9871), 25, 6, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9871) },
                    { 40, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9872), 21, 6, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9872) },
                    { 41, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9873), 8, 6, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9874) },
                    { 42, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9874), 11, 6, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9875) },
                    { 43, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9876), 1, 30, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9876) },
                    { 44, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9877), 1, 20, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9877) },
                    { 45, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9878), 2, 20, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9878) },
                    { 46, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9879), 1, 68, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9879) },
                    { 47, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9880), 22, 65, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9880) },
                    { 48, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9881), 1, 65, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9881) },
                    { 49, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9882), 1, 81, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9883) },
                    { 50, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9883), 1, 54, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9884) },
                    { 51, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9884), 2, 54, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9885) },
                    { 52, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9886), 27, 11, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9886) },
                    { 53, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9887), 28, 11, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9887) },
                    { 54, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9888), 1, 11, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9888) },
                    { 55, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9889), 3, 11, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9889) },
                    { 56, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9890), 2, 78, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9890) },
                    { 57, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9891), 22, 18, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9891) },
                    { 58, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9892), 1, 18, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9893) },
                    { 59, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9893), 2, 18, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9894) },
                    { 60, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9895), 4, 18, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9895) },
                    { 61, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9896), 1, 23, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9896) },
                    { 62, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9897), 2, 23, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9897) },
                    { 63, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9898), 16, 23, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9898) },
                    { 64, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9899), 5, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9899) },
                    { 65, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9900), 6, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9900) },
                    { 66, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9901), 8, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9902) },
                    { 67, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9903), 10, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9903) },
                    { 68, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9904), 34, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9904) },
                    { 69, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9905), 35, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9905) },
                    { 70, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9906), 13, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9906) },
                    { 71, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9907), 33, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9907) },
                    { 72, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9908), 36, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9908) },
                    { 73, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9943), 37, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9944) },
                    { 74, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9945), 38, 2, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9945) },
                    { 75, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9946), 1, 55, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9946) },
                    { 76, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9947), 3, 55, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9947) },
                    { 77, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9948), 24, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9948) },
                    { 78, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9949), 26, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9949) },
                    { 79, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9950), 7, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9951) },
                    { 80, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9952), 9, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9952) },
                    { 81, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9953), 10, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9953) },
                    { 82, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9954), 12, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9954) },
                    { 83, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9955), 13, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9955) },
                    { 84, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9956), 33, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9956) },
                    { 85, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9957), 34, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9957) },
                    { 86, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9958), 35, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9959) },
                    { 87, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9960), 36, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9960) },
                    { 88, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9961), 37, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9961) },
                    { 89, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9962), 38, 4, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9962) },
                    { 90, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9963), 19, 9, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9963) },
                    { 91, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9964), 24, 9, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9965) },
                    { 92, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9966), 27, 9, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9966) },
                    { 93, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9967), 28, 9, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9967) },
                    { 94, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9968), 1, 9, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9968) },
                    { 95, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9969), 2, 9, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9969) },
                    { 96, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9970), 1, 14, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9970) },
                    { 97, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9971), 2, 14, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9971) },
                    { 98, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9973), 3, 14, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9973) },
                    { 99, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9974), 34, 14, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9975) },
                    { 100, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9975), 35, 14, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9976) },
                    { 101, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9977), 36, 14, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9977) },
                    { 102, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9978), 1, 96, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9978) },
                    { 103, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9979), 1, 71, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9979) },
                    { 104, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9980), 2, 35, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9980) },
                    { 105, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9981), 3, 35, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9981) },
                    { 106, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9982), 2, 40, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9983) },
                    { 107, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9984), 27, 5, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9984) },
                    { 108, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9985), 28, 5, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9985) },
                    { 109, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9986), 33, 5, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9986) },
                    { 110, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9987), 34, 5, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9987) },
                    { 111, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9988), 35, 5, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9988) },
                    { 112, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9989), 36, 5, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9990) },
                    { 113, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9990), 38, 5, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9991) },
                    { 114, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9992), 2, 16, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9992) },
                    { 115, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9993), 3, 16, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9993) },
                    { 116, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9994), 4, 16, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9994) },
                    { 117, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9995), 9, 16, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9995) },
                    { 118, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9996), 1, 21, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9996) },
                    { 119, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9997), 2, 21, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9997) },
                    { 120, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9998), 9, 21, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9999) },
                    { 121, new DateTime(2025, 9, 2, 1, 37, 25, 986, DateTimeKind.Utc).AddTicks(9999), 1, 69, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc) },
                    { 122, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1), 1, 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1) },
                    { 123, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2), 1, 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2) },
                    { 124, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3), 2, 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3) },
                    { 125, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4), 3, 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4) },
                    { 126, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(5), 16, 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(5) },
                    { 127, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(6), 1, 60, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(6) },
                    { 128, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(7), 1, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(8) },
                    { 129, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(8), 3, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(9) },
                    { 130, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(10), 2, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(10) },
                    { 131, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(11), 7, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(11) },
                    { 132, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(12), 4, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(12) },
                    { 133, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(13), 6, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(13) },
                    { 134, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(14), 8, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(14) },
                    { 135, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(15), 9, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(15) },
                    { 136, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(16), 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(17) },
                    { 137, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(17), 4, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(18) },
                    { 138, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(19), 3, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(19) },
                    { 139, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(20), 2, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(20) },
                    { 140, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(21), 9, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(21) },
                    { 141, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(22), 1, 95, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(22) },
                    { 142, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(23), 1, 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(23) },
                    { 143, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(24), 2, 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(24) },
                    { 144, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(25), 3, 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(26) },
                    { 145, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(27), 24, 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(27) },
                    { 146, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(28), 2, 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(28) },
                    { 147, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(29), 3, 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(29) },
                    { 148, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(30), 1, 97, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(30) },
                    { 149, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(31), 1, 98, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(31) },
                    { 150, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(32), 24, 80, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(32) },
                    { 151, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(33), 14, 88, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(34) },
                    { 152, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(69), 14, 93, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(69) },
                    { 153, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(70), 24, 85, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(70) },
                    { 154, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(71), 9, 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(71) },
                    { 155, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(72), 1, 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(73) },
                    { 156, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(73), 1, 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(74) },
                    { 157, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(75), 3, 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(75) },
                    { 158, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(166), 1, 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(167) },
                    { 159, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(168), 2, 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(168) },
                    { 160, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(169), 2, 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(169) },
                    { 161, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(170), 23, 79, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(170) },
                    { 162, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(171), 24, 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(171) },
                    { 163, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(172), 1, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(172) },
                    { 164, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(173), 3, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(174) },
                    { 165, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(175), 1, 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(175) },
                    { 166, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(176), 2, 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(176) },
                    { 167, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(177), 1, 56, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(177) },
                    { 168, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(178), 1, 91, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(178) },
                    { 169, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(179), 15, 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(179) },
                    { 170, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(180), 1, 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(181) },
                    { 171, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(182), 3, 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(182) },
                    { 172, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(183), 1, 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(183) },
                    { 173, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(184), 3, 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(185) },
                    { 174, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(186), 14, 86, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(186) },
                    { 175, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(187), 3, 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(187) },
                    { 176, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(188), 1, 61, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(188) }
                });

            migrationBuilder.InsertData(
                table: "hora_dia",
                columns: new[] { "id", "created_at", "dia_id", "hora_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1290), 1, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1291) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1294), 1, 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1294) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1295), 1, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1296) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1297), 1, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1297) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1298), 1, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1298) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1299), 1, 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1299) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1300), 1, 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1300) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1301), 1, 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1302) },
                    { 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1302), 1, 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1303) },
                    { 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1304), 1, 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1304) },
                    { 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1305), 1, 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1305) },
                    { 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1306), 1, 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1306) },
                    { 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1307), 1, 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1307) },
                    { 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1308), 1, 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1309) },
                    { 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1310), 1, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1310) },
                    { 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1311), 1, 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1311) },
                    { 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1312), 1, 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1312) },
                    { 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1313), 1, 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1313) },
                    { 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1314), 1, 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1315) },
                    { 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1316), 1, 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1316) },
                    { 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1317), 2, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1317) },
                    { 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1318), 2, 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1318) },
                    { 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1319), 2, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1319) },
                    { 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1320), 2, 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1321) },
                    { 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1322), 2, 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1322) },
                    { 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1323), 2, 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1324) },
                    { 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1325), 2, 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1325) },
                    { 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1326), 2, 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1326) },
                    { 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1327), 2, 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1327) },
                    { 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1328), 2, 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1329) },
                    { 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1330), 2, 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1330) },
                    { 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1332), 2, 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1333) },
                    { 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1334), 2, 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1335) },
                    { 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1335), 2, 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1336) },
                    { 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1337), 2, 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1337) },
                    { 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1338), 2, 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1338) },
                    { 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1339), 2, 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1339) },
                    { 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1340), 2, 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1341) },
                    { 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1342), 2, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1342) },
                    { 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1343), 2, 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1343) },
                    { 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1344), 2, 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1345) },
                    { 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1346), 2, 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1346) },
                    { 43, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1347), 2, 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1347) },
                    { 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1348), 2, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1349) },
                    { 45, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1349), 2, 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1350) },
                    { 46, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1351), 3, 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1351) },
                    { 47, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1352), 3, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1352) },
                    { 48, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1353), 3, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1353) },
                    { 49, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1354), 3, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1355) },
                    { 50, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1356), 3, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1356) },
                    { 51, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1357), 3, 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1357) },
                    { 52, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1358), 3, 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1358) },
                    { 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1359), 3, 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1359) },
                    { 54, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1360), 3, 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1361) },
                    { 55, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1361), 3, 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1362) },
                    { 56, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1363), 3, 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1363) },
                    { 57, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1364), 3, 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1364) },
                    { 58, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1365), 3, 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1365) },
                    { 59, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1366), 3, 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1367) },
                    { 60, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1367), 3, 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1368) },
                    { 61, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1369), 3, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1369) },
                    { 62, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1370), 3, 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1370) },
                    { 63, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1371), 3, 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1371) },
                    { 64, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1372), 3, 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1373) },
                    { 65, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1374), 3, 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1374) },
                    { 66, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1376), 4, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1376) },
                    { 67, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1377), 4, 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1378) },
                    { 68, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1378), 4, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1379) },
                    { 69, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1380), 4, 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1380) },
                    { 70, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1381), 4, 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1381) },
                    { 71, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1382), 4, 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1382) },
                    { 72, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1383), 4, 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1383) },
                    { 73, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1384), 4, 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1385) },
                    { 74, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1386), 4, 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1386) },
                    { 75, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1387), 4, 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1388) },
                    { 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1389), 4, 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1389) },
                    { 77, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1449), 4, 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1450) },
                    { 78, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1451), 4, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1451) },
                    { 79, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1452), 4, 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1452) },
                    { 80, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1453), 4, 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1453) },
                    { 81, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1454), 4, 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1455) },
                    { 82, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1456), 4, 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1456) },
                    { 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1457), 4, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1457) },
                    { 84, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1458), 4, 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1458) },
                    { 85, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1459), 5, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1460) },
                    { 86, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1460), 5, 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1461) },
                    { 87, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1462), 5, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1462) },
                    { 88, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1463), 5, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1463) },
                    { 89, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1464), 5, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1464) },
                    { 90, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1465), 5, 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1466) },
                    { 91, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1467), 3, 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1467) },
                    { 92, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1468), 5, 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1468) },
                    { 93, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1469), 5, 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1469) },
                    { 94, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1470), 5, 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1470) },
                    { 95, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1471), 5, 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1472) },
                    { 96, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1472), 5, 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1473) },
                    { 97, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1474), 5, 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1474) },
                    { 98, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1475), 5, 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1475) },
                    { 99, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1476), 5, 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1476) },
                    { 100, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1477), 5, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1477) },
                    { 101, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1478), 5, 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1479) },
                    { 102, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1479), 5, 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1480) },
                    { 103, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1481), 5, 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1481) },
                    { 104, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1482), 5, 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1482) },
                    { 105, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1483), 5, 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1483) },
                    { 106, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1484), 6, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1485) },
                    { 107, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1485), 6, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1486) },
                    { 108, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1487), 6, 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1487) },
                    { 109, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1488), 6, 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1488) },
                    { 110, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1489), 6, 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1489) },
                    { 111, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1490), 6, 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1490) },
                    { 112, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1491), 6, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1492) },
                    { 113, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1492), 6, 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1493) },
                    { 114, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1494), 3, 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1494) },
                    { 115, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1495), 5, 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1495) },
                    { 116, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1496), 3, 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(1496) }
                });

            migrationBuilder.InsertData(
                table: "plan_estudio",
                columns: new[] { "id", "carrera_id", "codigo", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 2, "ING-INF", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4609), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4609) },
                    { 2, 3, "ING-SIS", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4612), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4612) },
                    { 3, 1, "ING-RED", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4614), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4614) },
                    { 4, 4, "ING-ROB", new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4615), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4615) }
                });

            migrationBuilder.InsertData(
                table: "hora_dia_horario",
                columns: new[] { "id", "created_at", "hora_dia_id", "horario_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(698), 1, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(699) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(700), 47, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(701) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(702), 85, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(702) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(703), 3, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(703) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(704), 48, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(704) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(705), 87, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(705) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(706), 5, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(707) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(708), 50, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(708) },
                    { 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(709), 89, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(709) },
                    { 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(710), 6, 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(710) },
                    { 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(711), 51, 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(711) },
                    { 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(712), 91, 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(712) },
                    { 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(713), 7, 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(713) },
                    { 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(714), 53, 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(714) },
                    { 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(715), 93, 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(715) },
                    { 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(716), 9, 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(716) },
                    { 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(717), 54, 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(717) },
                    { 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(718), 95, 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(718) },
                    { 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(719), 11, 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(719) },
                    { 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(720), 57, 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(720) },
                    { 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(721), 96, 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(721) },
                    { 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(722), 13, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(722) },
                    { 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(723), 60, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(723) },
                    { 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(725), 97, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(725) },
                    { 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(726), 14, 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(726) },
                    { 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(727), 59, 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(727) },
                    { 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(728), 98, 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(728) },
                    { 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(729), 15, 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(730) },
                    { 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(730), 61, 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(731) },
                    { 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(731), 100, 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(732) },
                    { 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(733), 16, 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(733) },
                    { 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(734), 62, 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(734) },
                    { 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(735), 101, 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(735) },
                    { 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(773), 18, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(773) },
                    { 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(774), 63, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(774) },
                    { 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(775), 103, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(775) },
                    { 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(777), 20, 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(777) },
                    { 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(779), 65, 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(779) },
                    { 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(780), 105, 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(781) },
                    { 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(781), 19, 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(782) },
                    { 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(782), 64, 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(783) },
                    { 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(783), 104, 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(784) },
                    { 43, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(784), 1, 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(785) },
                    { 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(785), 47, 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(786) },
                    { 45, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(786), 85, 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(787) },
                    { 46, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(787), 106, 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(788) },
                    { 47, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(788), 5, 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(789) },
                    { 48, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(789), 50, 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(790) },
                    { 49, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(790), 89, 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(791) },
                    { 50, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(791), 112, 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(792) },
                    { 51, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(792), 5, 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(793) },
                    { 52, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(793), 50, 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(794) },
                    { 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(794), 89, 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(795) },
                    { 54, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(795), 113, 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(796) },
                    { 55, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(796), 14, 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(796) },
                    { 56, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(797), 59, 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(797) },
                    { 57, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(798), 98, 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(798) },
                    { 58, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(799), 107, 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(799) },
                    { 59, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(800), 18, 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(800) },
                    { 60, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(801), 63, 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(801) },
                    { 61, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(802), 103, 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(802) },
                    { 62, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(803), 109, 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(803) },
                    { 63, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(804), 9, 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(804) },
                    { 64, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(805), 54, 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(806) },
                    { 65, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(806), 95, 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(807) },
                    { 66, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(807), 98, 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(808) },
                    { 67, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(808), 11, 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(809) },
                    { 68, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(809), 57, 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(810) },
                    { 69, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(810), 96, 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(811) },
                    { 70, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(811), 105, 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(812) },
                    { 71, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(812), 14, 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(813) },
                    { 72, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(813), 59, 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(814) },
                    { 73, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(815), 98, 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(815) },
                    { 74, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(816), 100, 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(816) },
                    { 75, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(817), 2, 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(817) },
                    { 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(818), 46, 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(818) },
                    { 77, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(819), 4, 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(819) },
                    { 78, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(820), 49, 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(820) },
                    { 79, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(821), 10, 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(821) },
                    { 80, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(822), 55, 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(822) },
                    { 81, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(823), 12, 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(823) },
                    { 82, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(824), 58, 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(824) },
                    { 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(825), 16, 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(825) },
                    { 84, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(826), 62, 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(826) },
                    { 85, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(827), 17, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(827) },
                    { 86, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(828), 116, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(828) },
                    { 87, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(829), 2, 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(829) },
                    { 88, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(830), 46, 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(830) },
                    { 89, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(831), 56, 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(831) },
                    { 90, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(832), 2, 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(832) },
                    { 91, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(833), 67, 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(833) },
                    { 92, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(834), 10, 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(834) },
                    { 93, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(835), 72, 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(835) },
                    { 94, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(836), 96, 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(836) },
                    { 95, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(837), 2, 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(837) },
                    { 96, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(838), 86, 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(838) },
                    { 97, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(839), 21, 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(839) },
                    { 98, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(840), 7, 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(840) },
                    { 99, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(841), 36, 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(841) },
                    { 100, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(842), 76, 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(842) },
                    { 101, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(843), 8, 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(843) },
                    { 102, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(844), 22, 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(844) },
                    { 103, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(845), 67, 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(845) },
                    { 104, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(846), 12, 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(846) },
                    { 105, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(847), 21, 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(847) },
                    { 106, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(848), 94, 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(848) },
                    { 107, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(849), 24, 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(849) },
                    { 108, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(850), 22, 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(850) },
                    { 109, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(850), 67, 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(851) },
                    { 110, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(851), 28, 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(852) },
                    { 111, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(852), 22, 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(853) },
                    { 112, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(853), 67, 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(854) },
                    { 113, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(854), 26, 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(855) },
                    { 114, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(855), 40, 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(856) },
                    { 115, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(856), 79, 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(857) },
                    { 116, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(857), 37, 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(858) },
                    { 117, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(858), 40, 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(859) },
                    { 118, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(859), 79, 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(860) },
                    { 119, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(860), 64, 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(861) },
                    { 120, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(861), 22, 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(862) },
                    { 121, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(862), 67, 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(862) },
                    { 122, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(863), 89, 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(863) },
                    { 123, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(864), 22, 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(864) },
                    { 124, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(865), 67, 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(865) },
                    { 125, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(866), 100, 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(866) },
                    { 126, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(867), 32, 43, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(867) },
                    { 127, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(868), 72, 43, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(868) },
                    { 128, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(869), 96, 43, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(869) },
                    { 129, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(870), 36, 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(870) },
                    { 130, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(871), 76, 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(871) },
                    { 131, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(872), 97, 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(872) },
                    { 132, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(873), 31, 45, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(873) },
                    { 133, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(874), 58, 45, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(874) },
                    { 134, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(875), 94, 45, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(875) },
                    { 135, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(876), 11, 46, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(876) },
                    { 136, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(877), 33, 46, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(877) },
                    { 137, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(878), 57, 46, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(878) },
                    { 138, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(879), 37, 46, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(879) },
                    { 139, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(880), 49, 47, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(880) },
                    { 140, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(881), 86, 47, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(881) },
                    { 141, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(882), 52, 48, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(882) },
                    { 142, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(883), 90, 48, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(883) },
                    { 143, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(884), 50, 49, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(884) },
                    { 144, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(885), 96, 49, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(885) },
                    { 145, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(886), 111, 49, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(886) },
                    { 146, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(887), 114, 50, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(887) },
                    { 147, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(888), 115, 50, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(888) },
                    { 148, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(888), 64, 51, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(889) },
                    { 149, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(889), 99, 51, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(890) },
                    { 150, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(890), 55, 52, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(891) },
                    { 151, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(891), 110, 52, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(892) },
                    { 152, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(892), 48, 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(893) },
                    { 153, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(893), 67, 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(894) },
                    { 154, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(894), 88, 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(895) },
                    { 155, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(895), 70, 54, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(896) },
                    { 156, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(896), 92, 54, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(897) },
                    { 157, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(897), 22, 55, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(898) },
                    { 158, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(898), 86, 55, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(899) },
                    { 159, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(899), 29, 56, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(900) },
                    { 160, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(900), 95, 56, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(901) },
                    { 161, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(901), 21, 57, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(902) },
                    { 162, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(924), 66, 57, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(925) },
                    { 163, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(926), 106, 57, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(926) },
                    { 164, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(927), 22, 58, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(927) },
                    { 165, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(928), 86, 58, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(928) },
                    { 166, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(929), 21, 59, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(929) },
                    { 167, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(930), 66, 59, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(930) },
                    { 168, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(931), 23, 60, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(931) },
                    { 169, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(932), 68, 60, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(932) },
                    { 170, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(933), 27, 61, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(933) },
                    { 171, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(934), 70, 61, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(934) },
                    { 172, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(935), 31, 72, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(935) },
                    { 173, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(936), 71, 72, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(936) },
                    { 174, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(937), 32, 73, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(937) },
                    { 175, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(938), 72, 73, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(938) },
                    { 176, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(939), 33, 74, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(939) },
                    { 177, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(940), 74, 74, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(940) },
                    { 178, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(941), 34, 75, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(941) },
                    { 179, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(942), 73, 75, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(942) },
                    { 180, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(943), 36, 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(943) },
                    { 181, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(944), 76, 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(944) },
                    { 182, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(945), 35, 77, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(945) },
                    { 183, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(946), 75, 77, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(946) },
                    { 184, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(947), 38, 78, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(947) },
                    { 185, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(948), 77, 78, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(948) },
                    { 186, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(949), 40, 79, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(949) },
                    { 187, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(950), 79, 79, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(950) },
                    { 188, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(951), 39, 80, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(951) },
                    { 189, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(952), 78, 80, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(952) },
                    { 190, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(953), 41, 81, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(953) },
                    { 191, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(954), 80, 81, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(954) },
                    { 192, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(955), 42, 82, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(955) },
                    { 193, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(956), 81, 82, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(956) },
                    { 194, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(957), 43, 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(957) },
                    { 195, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(957), 82, 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(958) },
                    { 196, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(958), 44, 84, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(959) },
                    { 197, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(959), 83, 84, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(960) },
                    { 198, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(960), 45, 85, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(961) },
                    { 199, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(961), 84, 85, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(962) },
                    { 200, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(962), 108, 86, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(963) }
                });

            migrationBuilder.InsertData(
                table: "horario_materia",
                columns: new[] { "id", "created_at", "cupos_disponibles", "cupos_total", "docente_id", "gestion_id", "grupo_materia_id", "horario_id", "modulo_id", "nro_aula", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2092), (short)30, (short)100, 1, 1, 1, 10, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2092) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2098), (short)30, (short)100, 1, 1, 2, 1, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2099) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2101), (short)30, (short)100, 1, 1, 3, 1, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2101) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2133), (short)30, (short)100, 1, 1, 4, 2, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2134) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2136), (short)30, (short)100, 1, 1, 5, 3, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2137) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2138), (short)30, (short)100, 1, 1, 6, 1, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2139) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2140), (short)30, (short)100, 1, 1, 7, 4, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2141) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2142), (short)30, (short)100, 1, 1, 8, 3, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2143) },
                    { 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2144), (short)30, (short)100, 1, 1, 9, 23, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2145) },
                    { 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2146), (short)30, (short)100, 1, 1, 10, 58, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2147) },
                    { 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2149), (short)30, (short)100, 1, 1, 11, 1, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2149) },
                    { 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2151), (short)30, (short)100, 1, 1, 12, 2, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2151) },
                    { 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2153), (short)30, (short)100, 1, 1, 13, 76, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2153) },
                    { 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2155), (short)30, (short)100, 1, 1, 14, 1, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2155) },
                    { 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2157), (short)30, (short)100, 1, 1, 15, 79, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2157) },
                    { 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2158), (short)30, (short)100, 1, 1, 16, 1, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2159) },
                    { 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2160), (short)30, (short)100, 1, 1, 17, 9, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2161) },
                    { 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2162), (short)30, (short)100, 1, 1, 18, 2, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2163) },
                    { 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2164), (short)30, (short)100, 1, 1, 19, 58, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2165) },
                    { 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2166), (short)30, (short)100, 1, 1, 20, 50, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2167) },
                    { 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2168), (short)30, (short)100, 1, 1, 21, 79, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2169) },
                    { 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2170), (short)30, (short)100, 1, 1, 22, 79, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2171) },
                    { 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2172), (short)30, (short)100, 1, 1, 23, 60, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2173) },
                    { 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2175), (short)30, (short)100, 1, 1, 24, 25, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2175) },
                    { 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2177), (short)30, (short)100, 1, 1, 25, 1, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2177) },
                    { 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2179), (short)30, (short)100, 1, 1, 26, 30, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2179) },
                    { 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2181), (short)30, (short)100, 1, 1, 27, 76, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2181) },
                    { 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2183), (short)30, (short)100, 1, 1, 28, 10, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2183) },
                    { 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2185), (short)30, (short)100, 1, 1, 29, 55, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2185) },
                    { 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2187), (short)30, (short)100, 1, 1, 30, 60, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2187) },
                    { 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2189), (short)30, (short)100, 1, 1, 31, 60, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2189) },
                    { 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2191), (short)30, (short)100, 1, 1, 32, 76, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2191) },
                    { 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2193), (short)30, (short)100, 1, 1, 33, 73, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2193) },
                    { 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2195), (short)30, (short)100, 1, 1, 34, 12, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2195) },
                    { 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2197), (short)30, (short)100, 1, 1, 35, 1, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2197) },
                    { 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2199), (short)30, (short)100, 1, 1, 36, 14, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2199) },
                    { 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2201), (short)30, (short)100, 1, 1, 37, 57, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2201) },
                    { 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2203), (short)30, (short)100, 1, 1, 38, 5, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2203) },
                    { 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2205), (short)30, (short)100, 1, 1, 39, 82, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2205) },
                    { 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2207), (short)30, (short)100, 1, 1, 40, 47, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2207) },
                    { 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2209), (short)30, (short)100, 1, 1, 41, 60, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2209) },
                    { 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2211), (short)30, (short)100, 1, 1, 42, 76, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2211) },
                    { 43, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2213), (short)30, (short)100, 1, 1, 43, 4, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2213) },
                    { 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2215), (short)30, (short)100, 1, 1, 44, 2, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2215) },
                    { 45, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2217), (short)30, (short)100, 1, 1, 45, 8, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2217) },
                    { 46, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2219), (short)30, (short)100, 1, 1, 46, 74, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2219) },
                    { 47, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2221), (short)30, (short)100, 1, 1, 47, 78, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2221) },
                    { 48, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2223), (short)30, (short)100, 1, 1, 48, 77, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2223) },
                    { 49, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2225), (short)30, (short)100, 1, 1, 49, 59, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2225) },
                    { 50, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2227), (short)30, (short)100, 1, 1, 50, 9, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2227) },
                    { 51, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2229), (short)30, (short)100, 1, 1, 51, 4, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2229) },
                    { 52, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2231), (short)30, (short)100, 1, 1, 52, 60, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2231) },
                    { 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2233), (short)30, (short)100, 1, 1, 53, 79, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2233) },
                    { 54, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2288), (short)30, (short)100, 1, 1, 54, 84, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2289) },
                    { 55, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2291), (short)30, (short)100, 1, 1, 55, 84, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2291) },
                    { 56, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2293), (short)30, (short)100, 1, 1, 56, 48, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2293) },
                    { 57, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2295), (short)30, (short)100, 1, 1, 57, 75, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2295) },
                    { 58, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2297), (short)30, (short)100, 1, 1, 58, 58, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2297) },
                    { 59, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2300), (short)30, (short)100, 1, 1, 59, 84, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2300) },
                    { 60, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2302), (short)30, (short)100, 1, 1, 60, 61, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2302) },
                    { 61, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2304), (short)30, (short)100, 1, 1, 61, 58, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2304) },
                    { 62, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2306), (short)30, (short)100, 1, 1, 62, 76, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2306) },
                    { 63, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2308), (short)30, (short)100, 1, 1, 63, 84, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2308) },
                    { 64, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2310), (short)30, (short)100, 1, 1, 64, 79, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2310) },
                    { 65, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2312), (short)30, (short)100, 1, 1, 65, 1, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2312) },
                    { 66, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2314), (short)30, (short)100, 1, 1, 66, 58, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2314) },
                    { 67, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2316), (short)30, (short)100, 1, 1, 67, 58, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2316) },
                    { 68, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2318), (short)30, (short)100, 1, 1, 68, 2, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2318) },
                    { 69, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2320), (short)30, (short)100, 1, 1, 69, 6, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2320) },
                    { 70, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2322), (short)30, (short)100, 1, 1, 70, 3, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2322) },
                    { 71, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2324), (short)30, (short)100, 1, 1, 71, 2, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2324) },
                    { 72, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2326), (short)30, (short)100, 1, 1, 72, 7, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2326) },
                    { 73, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2328), (short)30, (short)100, 1, 1, 73, 9, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2328) },
                    { 74, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2330), (short)30, (short)100, 1, 1, 74, 2, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2330) },
                    { 75, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2332), (short)30, (short)100, 1, 1, 75, 61, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2333) },
                    { 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2334), (short)30, (short)100, 1, 1, 76, 58, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2335) },
                    { 77, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2336), (short)30, (short)100, 1, 1, 77, 15, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2337) },
                    { 78, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2338), (short)30, (short)100, 1, 1, 78, 33, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2339) },
                    { 79, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2340), (short)30, (short)100, 1, 1, 79, 34, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2341) },
                    { 80, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2342), (short)30, (short)100, 1, 1, 80, 41, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2343) },
                    { 81, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2344), (short)30, (short)100, 1, 1, 81, 44, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2345) },
                    { 82, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2346), (short)30, (short)100, 1, 1, 82, 46, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2347) },
                    { 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2348), (short)30, (short)100, 1, 1, 83, 29, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2349) },
                    { 84, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2350), (short)30, (short)100, 1, 1, 84, 37, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2351) },
                    { 85, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2352), (short)30, (short)100, 1, 1, 85, 38, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2353) },
                    { 86, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2354), (short)30, (short)100, 1, 1, 86, 22, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2355) },
                    { 87, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2356), (short)30, (short)100, 1, 1, 87, 18, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2356) },
                    { 88, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2358), (short)30, (short)100, 1, 1, 88, 39, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2359) },
                    { 89, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2361), (short)30, (short)100, 1, 1, 89, 16, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2361) },
                    { 90, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2363), (short)30, (short)100, 1, 1, 90, 42, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2363) },
                    { 91, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2365), (short)30, (short)100, 1, 1, 91, 19, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2366) },
                    { 92, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2367), (short)30, (short)100, 1, 1, 92, 40, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2368) },
                    { 93, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2369), (short)30, (short)100, 1, 1, 93, 41, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2370) },
                    { 94, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2371), (short)30, (short)100, 1, 1, 94, 43, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2372) },
                    { 95, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2373), (short)30, (short)100, 1, 1, 95, 20, 1, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(2374) }
                });

            migrationBuilder.InsertData(
                table: "materia_plan_estudio",
                columns: new[] { "id", "created_at", "materia_id", "nivel_id", "plan_estudio_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3211), 1, 1, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3212) },
                    { 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3216), 2, 1, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3216) },
                    { 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3217), 3, 1, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3218) },
                    { 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3219), 4, 1, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3219) },
                    { 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3220), 5, 1, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3220) },
                    { 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3221), 6, 2, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3222) },
                    { 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3223), 7, 2, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3223) },
                    { 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3224), 8, 2, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3224) },
                    { 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3226), 9, 2, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3226) },
                    { 10, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3227), 10, 2, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3227) },
                    { 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3228), 11, 3, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3229) },
                    { 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3230), 12, 3, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3230) },
                    { 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3231), 13, 3, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3231) },
                    { 14, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3233), 14, 3, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3233) },
                    { 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3234), 15, 3, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3234) },
                    { 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3235), 16, 4, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3236) },
                    { 17, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3275), 17, 4, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3275) },
                    { 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3277), 18, 4, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3277) },
                    { 19, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3278), 19, 4, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3278) },
                    { 20, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3280), 20, 4, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3280) },
                    { 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3281), 21, 5, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3281) },
                    { 22, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3282), 22, 5, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3283) },
                    { 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3284), 23, 5, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3284) },
                    { 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3285), 24, 5, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3285) },
                    { 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3286), 25, 5, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3287) },
                    { 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3288), 26, 6, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3288) },
                    { 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3289), 27, 6, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3289) },
                    { 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3291), 28, 6, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3291) },
                    { 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3292), 29, 6, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3292) },
                    { 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3294), 30, 6, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3294) },
                    { 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3295), 31, 7, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3295) },
                    { 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3296), 32, 7, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3297) },
                    { 33, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3298), 33, 7, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3298) },
                    { 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3299), 34, 7, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3299) },
                    { 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3301), 38, 7, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3301) },
                    { 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3302), 36, 8, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3302) },
                    { 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3304), 37, 8, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3304) },
                    { 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3305), 44, 8, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3305) },
                    { 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3307), 39, 8, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3307) },
                    { 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3308), 35, 8, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3308) },
                    { 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3309), 41, 9, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3310) },
                    { 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3312), 42, 9, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3313) },
                    { 43, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3314), 43, 9, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3314) },
                    { 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3311), 40, 9, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3311) },
                    { 45, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3315), 100, 10, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3316) },
                    { 46, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3317), 1, 1, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3317) },
                    { 47, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3318), 2, 1, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3318) },
                    { 48, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3320), 3, 1, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3320) },
                    { 49, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3321), 4, 1, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3321) },
                    { 50, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3323), 5, 1, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3323) },
                    { 51, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3324), 6, 2, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3324) },
                    { 52, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3325), 7, 2, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3326) },
                    { 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3327), 8, 2, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3327) },
                    { 54, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3328), 9, 2, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3328) },
                    { 55, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3330), 10, 2, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3330) },
                    { 56, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3331), 11, 3, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3331) },
                    { 57, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3333), 12, 3, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3333) },
                    { 58, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3334), 13, 3, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3335) },
                    { 59, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3336), 14, 3, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3336) },
                    { 60, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3337), 15, 3, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3337) },
                    { 61, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3338), 16, 4, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3339) },
                    { 62, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3340), 17, 4, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3340) },
                    { 63, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3341), 18, 4, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3342) },
                    { 64, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3343), 19, 4, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3343) },
                    { 65, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3344), 20, 4, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3344) },
                    { 66, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3346), 21, 5, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3346) },
                    { 68, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3347), 23, 5, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3347) },
                    { 69, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3349), 24, 5, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3349) },
                    { 71, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3383), 53, 5, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3384) },
                    { 72, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3385), 54, 5, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3385) },
                    { 73, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3386), 26, 6, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3387) },
                    { 74, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3388), 27, 6, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3388) },
                    { 75, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3389), 28, 6, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3389) },
                    { 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3391), 29, 6, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3391) },
                    { 78, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3392), 55, 6, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3392) },
                    { 79, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3393), 31, 7, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3394) },
                    { 81, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3395), 33, 7, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3395) },
                    { 82, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3396), 34, 7, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3397) },
                    { 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3398), 38, 7, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3398) },
                    { 84, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3399), 56, 7, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3399) },
                    { 85, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3400), 36, 8, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3401) },
                    { 87, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3402), 35, 8, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3402) },
                    { 88, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3403), 39, 8, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3404) },
                    { 89, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3405), 44, 8, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3405) },
                    { 90, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3406), 57, 8, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3406) },
                    { 91, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3407), 41, 9, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3408) },
                    { 92, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3409), 42, 9, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3409) },
                    { 93, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3410), 43, 9, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3411) },
                    { 94, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3412), 40, 9, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3412) },
                    { 95, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3413), 100, 10, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3413) },
                    { 96, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3414), 1, 1, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3415) },
                    { 97, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3416), 2, 1, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3416) },
                    { 98, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3417), 3, 1, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3417) },
                    { 99, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3419), 4, 1, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3419) },
                    { 100, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3420), 5, 1, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3420) },
                    { 101, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3422), 6, 2, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3422) },
                    { 102, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3423), 7, 2, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3423) },
                    { 103, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3425), 8, 2, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3425) },
                    { 104, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3426), 9, 2, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3426) },
                    { 105, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3427), 10, 2, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3428) },
                    { 106, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3429), 11, 3, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3429) },
                    { 107, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3430), 12, 3, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3431) },
                    { 108, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3432), 13, 3, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3432) },
                    { 109, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3433), 75, 3, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3433) },
                    { 110, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3435), 76, 3, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3435) },
                    { 111, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3436), 16, 4, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3436) },
                    { 112, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3438), 17, 4, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3438) },
                    { 113, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3439), 18, 4, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3439) },
                    { 114, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3440), 19, 4, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3441) },
                    { 115, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3442), 77, 4, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3442) },
                    { 116, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3443), 21, 5, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3444) },
                    { 117, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3445), 24, 5, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3445) },
                    { 118, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3446), 78, 5, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3446) },
                    { 119, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3448), 79, 5, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3448) },
                    { 120, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3449), 80, 5, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3449) },
                    { 121, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3451), 81, 5, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3451) },
                    { 122, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3452), 82, 5, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3452) },
                    { 123, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3453), 28, 6, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3454) },
                    { 124, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3455), 29, 6, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3455) },
                    { 125, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3490), 26, 6, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3491) },
                    { 126, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3492), 83, 6, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3492) },
                    { 127, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3493), 84, 6, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3493) },
                    { 128, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3495), 85, 6, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3495) },
                    { 129, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3496), 86, 6, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3496) },
                    { 130, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3497), 99, 6, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3498) },
                    { 131, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3499), 34, 7, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3499) },
                    { 132, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3500), 33, 7, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3500) },
                    { 133, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3502), 31, 7, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3502) },
                    { 134, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3503), 87, 7, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3503) },
                    { 135, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3504), 88, 7, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3505) },
                    { 136, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3506), 89, 7, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3506) },
                    { 137, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3507), 90, 7, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3507) },
                    { 138, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3509), 39, 8, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3509) },
                    { 139, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3510), 36, 8, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3510) },
                    { 140, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3511), 91, 8, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3512) },
                    { 141, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3513), 92, 8, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3513) },
                    { 142, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3514), 93, 8, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3514) },
                    { 143, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3516), 94, 8, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3516) },
                    { 144, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3517), 95, 8, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3517) },
                    { 145, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3518), 41, 9, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3519) },
                    { 146, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3520), 42, 9, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3520) },
                    { 147, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3521), 96, 9, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3521) },
                    { 148, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3522), 97, 9, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3523) },
                    { 149, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3524), 98, 9, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3524) },
                    { 150, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3525), 100, 10, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(3526) }
                });

            migrationBuilder.InsertData(
                table: "prerequisito",
                columns: new[] { "materia_plan_estudio_id", "requisito_id", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4739), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4740) },
                    { 7, 2, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4742), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4743) },
                    { 8, 3, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4743), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4743) },
                    { 9, 4, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4744), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4744) },
                    { 10, 5, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4745), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4745) },
                    { 11, 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4746), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4746) },
                    { 12, 7, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4746), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4747) },
                    { 12, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4747), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4748) },
                    { 13, 8, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4748), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4748) },
                    { 13, 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4749), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4749) },
                    { 14, 9, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4750), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4750) },
                    { 16, 6, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4751), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4751) },
                    { 17, 11, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4752), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4752) },
                    { 18, 12, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4752), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4753) },
                    { 19, 13, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4753), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4753) },
                    { 20, 15, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4754), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4754) },
                    { 21, 16, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4793), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4793) },
                    { 22, 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4794), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4794) },
                    { 23, 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4795), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4795) },
                    { 24, 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4796), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4796) },
                    { 25, 18, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4797), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4797) },
                    { 26, 21, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4801), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4801) },
                    { 27, 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4803), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4803) },
                    { 28, 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4803), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4804) },
                    { 29, 24, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4804), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4804) },
                    { 30, 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4806), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4806) },
                    { 30, 25, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4805), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4805) },
                    { 31, 26, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4807), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4807) },
                    { 32, 23, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4809), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4809) },
                    { 32, 30, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4808), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4808) },
                    { 33, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4809), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4810) },
                    { 34, 28, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4810), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4811) },
                    { 35, 27, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4811), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4812) },
                    { 35, 29, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4812), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4812) },
                    { 36, 31, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4813), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4813) },
                    { 37, 32, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4814), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4814) },
                    { 37, 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4815), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4815) },
                    { 38, 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4816), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4816) },
                    { 39, 34, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4817), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4817) },
                    { 40, 35, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4818), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4818) },
                    { 41, 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4819), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4819) },
                    { 41, 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4819), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4820) },
                    { 41, 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4820), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4821) },
                    { 41, 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4821), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4821) },
                    { 41, 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4822), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4822) },
                    { 42, 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4828), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4828) },
                    { 42, 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4829), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4829) },
                    { 42, 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4829), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4830) },
                    { 42, 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4830), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4831) },
                    { 42, 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4831), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4831) },
                    { 43, 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4832), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4832) },
                    { 43, 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4833), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4833) },
                    { 43, 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4834), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4835) },
                    { 43, 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4835), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4836) },
                    { 43, 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4837), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4837) },
                    { 44, 36, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4823), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4823) },
                    { 44, 37, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4824), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4824) },
                    { 44, 38, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4824), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4825) },
                    { 44, 39, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4825), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4826) },
                    { 44, 40, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4826), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4826) },
                    { 45, 41, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4838), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4838) },
                    { 45, 42, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4839), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4839) },
                    { 45, 43, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4840), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4840) },
                    { 45, 44, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4838), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4839) },
                    { 51, 46, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4843), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4844) },
                    { 52, 47, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4844), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4845) },
                    { 53, 48, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4842), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4842) },
                    { 54, 49, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4841), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4841) },
                    { 55, 50, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4843), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4843) },
                    { 56, 51, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4848), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4848) },
                    { 57, 52, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4846), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4846) },
                    { 57, 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4845), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4845) },
                    { 58, 53, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4847), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4847) },
                    { 58, 54, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4847), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4848) },
                    { 59, 54, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4849), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4849) },
                    { 61, 51, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4852), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4853) },
                    { 62, 56, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4853), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4853) },
                    { 63, 57, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4851), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4851) },
                    { 64, 58, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4851), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4852) },
                    { 65, 60, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4850), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4850) },
                    { 66, 61, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4857), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4857) },
                    { 68, 63, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4856), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4856) },
                    { 69, 63, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4856), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4857) },
                    { 71, 65, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4854), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4854) },
                    { 72, 65, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4855), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4855) },
                    { 73, 66, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4861), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4862) },
                    { 74, 69, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4860), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4861) },
                    { 75, 68, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4860), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4860) },
                    { 76, 69, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4859), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4859) },
                    { 78, 71, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4858), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4858) },
                    { 79, 73, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4864), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4865) },
                    { 81, 75, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4862), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4862) },
                    { 82, 75, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4865), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4866) },
                    { 83, 74, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4866), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4866) },
                    { 83, 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4867), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4867) },
                    { 84, 74, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4863), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4863) },
                    { 84, 76, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4864), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4864) },
                    { 85, 79, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4868), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4868) },
                    { 87, 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4869), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4869) },
                    { 88, 82, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4869), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4870) },
                    { 89, 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4870), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4870) },
                    { 90, 78, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4871), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4871) },
                    { 90, 83, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4872), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4872) },
                    { 92, 85, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4876), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4876) },
                    { 92, 90, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4875), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4875) },
                    { 94, 87, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4874), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4874) },
                    { 94, 88, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4873), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4874) },
                    { 94, 89, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4873), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4873) },
                    { 95, 91, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4877), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4877) },
                    { 95, 92, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4878), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4879) },
                    { 95, 93, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4879), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4879) },
                    { 95, 94, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4877), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4878) },
                    { 101, 96, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4880), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4880) },
                    { 102, 97, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4881), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4882) },
                    { 103, 98, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4882), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4882) },
                    { 104, 99, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4883), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4883) },
                    { 105, 100, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4884), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4884) },
                    { 106, 101, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4885), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4885) },
                    { 107, 102, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4886), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4886) },
                    { 107, 103, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4886), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4887) },
                    { 108, 103, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4887), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4887) },
                    { 108, 104, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4888), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4888) },
                    { 109, 104, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4889), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4889) },
                    { 110, 104, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4890), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4890) },
                    { 111, 101, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4891), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4891) },
                    { 112, 106, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4890), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4891) },
                    { 113, 96, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4893), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4893) },
                    { 113, 107, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4892), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4892) },
                    { 114, 108, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4894), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4894) },
                    { 115, 109, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4895), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4895) },
                    { 116, 111, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4895), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4896) },
                    { 117, 113, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4896), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4897) },
                    { 118, 115, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4897), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4897) },
                    { 119, 115, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4898), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4898) },
                    { 120, 106, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4899), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4900) },
                    { 120, 110, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4899), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4899) },
                    { 123, 116, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4900), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4901) },
                    { 124, 117, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4901), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4901) },
                    { 125, 121, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4902), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4902) },
                    { 126, 119, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4903), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4903) },
                    { 127, 112, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4905), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4905) },
                    { 127, 120, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4904), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4904) },
                    { 131, 120, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4941), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4942) },
                    { 131, 123, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4940), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4941) },
                    { 132, 123, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4906), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4906) },
                    { 133, 125, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4905), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4906) },
                    { 134, 114, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4943), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4943) },
                    { 134, 126, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4942), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4943) },
                    { 135, 120, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4945), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4945) },
                    { 135, 127, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4944), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4944) },
                    { 138, 131, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4947), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4948) },
                    { 139, 133, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4946), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4946) },
                    { 140, 131, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4947), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4947) },
                    { 141, 131, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4948), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4948) },
                    { 141, 135, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4949), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4949) },
                    { 142, 135, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4950), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4950) },
                    { 145, 138, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4952), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4953) },
                    { 145, 139, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4951), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4951) },
                    { 145, 140, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4952), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4952) },
                    { 145, 141, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4953), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4954) },
                    { 145, 142, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4954), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4954) },
                    { 146, 138, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4957), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4957) },
                    { 146, 139, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4955), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4955) },
                    { 146, 140, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4956), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4956) },
                    { 146, 141, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4958), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4958) },
                    { 146, 142, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4958), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4959) },
                    { 147, 138, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4961), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4961) },
                    { 147, 139, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4959), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4959) },
                    { 147, 140, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4960), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4960) },
                    { 147, 141, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4962), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4962) },
                    { 147, 142, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4963), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4963) },
                    { 148, 138, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4965), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4965) },
                    { 148, 139, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4964), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4964) },
                    { 148, 140, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4964), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4965) },
                    { 148, 141, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4966), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4966) },
                    { 148, 142, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4967), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4967) },
                    { 149, 138, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4969), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4970) },
                    { 149, 139, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4968), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4968) },
                    { 149, 140, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4969), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4969) },
                    { 149, 141, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4970), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4970) },
                    { 149, 142, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4971), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4971) },
                    { 150, 145, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4972), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4972) },
                    { 150, 146, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4973), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4974) },
                    { 150, 147, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4973), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4973) },
                    { 150, 148, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4974), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4975) },
                    { 150, 149, new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4975), new DateTime(2025, 9, 2, 1, 37, 25, 987, DateTimeKind.Utc).AddTicks(4975) }
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
                name: "ix_prerequisito_materia_plan_estudio_id",
                table: "prerequisito",
                column: "materia_plan_estudio_id");

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
