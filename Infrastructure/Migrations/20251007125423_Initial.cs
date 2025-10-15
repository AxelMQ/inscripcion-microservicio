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
                name: "job_results",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    idempotency_key = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    queue = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    resource = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    operation = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    data_json = table.Column<string>(type: "text", nullable: true),
                    error = table.Column<string>(type: "text", nullable: true),
                    created_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    started_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    finished_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_job_results", x => x.id);
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
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(6573), "Matias", 0m, 1000000, 7000000, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(6577) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(6582), "Axel", 0m, 1000001, 7000001, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(6583) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(6586), "Franco", 0m, 1000002, 7000002, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(6587) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(6589), "Luis", 0m, 1000003, 7000003, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(6590) }
                });

            migrationBuilder.InsertData(
                table: "carrera",
                columns: new[] { "id", "codigo", "created_at", "modalidad", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, "185", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7099), (short)0, "INGENIERIA EN REDES Y TELECOMUNICACIONES", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7099) },
                    { 2, "183", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7102), (short)0, "INGENIERIA INFORMATICA", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7103) },
                    { 3, "184", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7105), (short)0, "INGENIERIA EN SISTEMAS", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7105) },
                    { 4, "323", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7107), (short)0, "INGENIERIA ROBOTICA", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7107) }
                });

            migrationBuilder.InsertData(
                table: "dia",
                columns: new[] { "id", "created_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7265), "LUNES", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7266) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7269), "MARTES", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7269) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7271), "MIERCOLES", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7271) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7272), "JUEVES", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7273) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7274), "VIERNES", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7275) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7283), "SABADO", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7283) }
                });

            migrationBuilder.InsertData(
                table: "docente",
                columns: new[] { "id", "ci", "created_at", "nombre", "telefono", "updated_at" },
                values: new object[,]
                {
                    { 1, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7440), "ABARCA SOTA NANCY", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7441) },
                    { 2, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7450), "ACOSTA CABEZAS BARTOLO JAVIER", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7450) },
                    { 3, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7453), "AGUILAR MARTINEZ DOMINGO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7453) },
                    { 4, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7455), "ARANIBAR QUIROZ M. MONICA", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7455) },
                    { 5, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7457), "ALPIRE RIVERO GERMAN", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7458) },
                    { 6, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7460), "ARGOTE CLAROS IRMA ISABEL", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7460) },
                    { 7, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7462), "AVENDAÑO GONZALES EUDAL", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7463) },
                    { 8, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7464), "BARROSO VIRUEZ GINO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7465) },
                    { 9, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7467), "BALCAZAR VEIZAGA EVANS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7467) },
                    { 10, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7469), "CALISAYA AJHUACHO MAGNO EDWIN", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7470) },
                    { 11, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7472), "CABALLERO RUA MAURICIO CHRISTIAN", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7472) },
                    { 12, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7623), "CABELLO MERIDA JUAN RUBEN", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7624) },
                    { 13, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7627), "CACERES CHACON BRAULIO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7628) },
                    { 14, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7630), "CANO CESPEDES JORGE", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7630) },
                    { 15, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7632), "CASTRO MARISCAL JHONNY", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7632) },
                    { 16, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7634), "CALIZAYA AJHUACHO MAGNO EDWIN", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7635) },
                    { 17, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7637), "CALDERON FLORES MODESTO FRANKLIN", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7637) },
                    { 18, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7639), "CALLE TERRAZAS EDWIN", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7640) },
                    { 19, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7641), "CARVAJAL CORDERO MARCIO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7642) },
                    { 20, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7644), "CARRENO PEREIRA ANDRES", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7644) },
                    { 21, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7646), "CAMPOS BARRERA MARIO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7647) },
                    { 22, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7649), "CAYOJA LUCANA VICTOR MILTON", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7649) },
                    { 23, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7651), "CLAURE MEDRANO DE OROPEZA ELIZ", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7651) },
                    { 24, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7653), "CHANIN AVICHACRA JUAN MANUEL", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7654) },
                    { 25, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7656), "CHAU WONG JORGE", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7656) },
                    { 26, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7658), "CORTEZ UZEDA JULIO MARTIN", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7658) },
                    { 27, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7660), "CONTRERAS VILLEGAS JUAN CARLOS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7661) },
                    { 28, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7663), "DURAN CESPEDES BERTHY RONALD", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7663) },
                    { 29, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7665), "FLORES FLORES MARCOS OSCAR", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7665) },
                    { 30, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7675), "FLORES GUZMAN VALENTIN VICTOR", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7676) },
                    { 31, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7677), "FLORES CUELLAD DAVID LUIS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7678) },
                    { 32, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7680), "GARZON CUELLAR ANGELICA", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7680) },
                    { 33, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7682), "GUTIERREZ BRUNO KATIME ESTHER", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7682) },
                    { 34, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7684), "GIANELLA PEREDO EDUARDO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7685) },
                    { 35, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7686), "GUARACHI SOLANO JONATHAN FELIX", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7687) },
                    { 36, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7689), "GUTHRIE PACHECO JHONNY DAVID", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7689) },
                    { 37, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7691), "GRAGEDA ESCUDERO MARIO WILSON", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7691) },
                    { 38, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7693), "GRIMALDO BRAVO PAUL", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7693) },
                    { 39, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7695), "GONZALES SANDOVAL JORGE ANTONIO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7696) },
                    { 40, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7697), "HINOJOSA SAAVEDRA JOSE SAID", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7698) },
                    { 41, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7700), "JUSTINIANO ROCA RONALD", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7700) },
                    { 42, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7703), "LAMAS RODRIGUEZ MARCOS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7704) },
                    { 43, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7705), "LAZO ARTEAGA CARLOS ALBERTO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7706) },
                    { 44, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7770), "LOPEZ WINNIPEG MARIO MILTON", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7771) },
                    { 45, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7773), "LOPEZ NEGRETTY MARY DUNNIA", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7774) },
                    { 46, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7776), "LOBO LIMPIAS VICTOR HUGO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7776) },
                    { 47, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7778), "MARTINEZ CARDONA SARAH MIRNA", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7778) },
                    { 48, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7780), "MARTINEZ CANEDO ROLANDO ANTONI", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7781) },
                    { 49, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7783), "MIRANDA CARRASCO CARLOS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7783) },
                    { 50, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7785), "MORALES MENDEZ MAGALY", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7786) },
                    { 51, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7787), "MOLLO MAMANI ALBERTO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7788) },
                    { 52, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7790), "MONRROY DIPP VICTOR FERNANDO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7790) },
                    { 53, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7792), "OROPEZA CLAURE GUSTAVO ADOLFO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7792) },
                    { 54, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7794), "OROSCO GOMEZ RUBEN", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7794) },
                    { 55, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7796), "ORTIZ ARTEAGA VICTOR HUGO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7797) },
                    { 56, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7798), "OQUENDO HEREDIA FREDDY MIGUEL", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7799) },
                    { 57, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7801), "PAZ MENDOZA ROBERTO CARLOS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7801) },
                    { 58, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7803), "PINTO VARGAS EDUARDO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7803) },
                    { 59, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7805), "PEINADO PEREIRA JUAN CARLOS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7805) },
                    { 60, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7807), "PEINADO PEREIRA MIGUEL JESUS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7807) },
                    { 61, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7812), "PEREZ FERREIRA UBALDO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7812) },
                    { 62, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7814), "PEREZ DELGADILLO SHIRLEY EULAL", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7814) },
                    { 63, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7816), "ROMAN ROCA RUFINO WILBERTO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7816) },
                    { 64, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7818), "ROSALES FUENTES JORGE MARCELO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7818) },
                    { 65, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7820), "SANCHEZ VELASCO ENRIQUE", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7821) },
                    { 66, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7822), "SANCHEZ RIOJA EDWIN ALEJANDRO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7823) },
                    { 67, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7824), "SALVATIERRA MERCADO ROLANDO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7825) },
                    { 68, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7827), "SELAYA GARVIZU IVAN VLADISHLAV", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7827) },
                    { 69, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7829), "SILES MUÑOZ FELIX", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7829) },
                    { 70, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7831), "TEJERINA GUERRA JULIO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7831) },
                    { 71, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7833), "TERRAZAS SOTO RICARDO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7834) },
                    { 72, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7835), "VACA PINTO CESPEDES ROBERTO CARLOS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7836) },
                    { 73, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7837), "VALDELOMAR ORELLANA TOMAS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7838) },
                    { 74, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7840), "VARGAS CASTILLO CIRO EDGAR", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7840) },
                    { 75, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7842), "VARGAS PEÑA LEONARDO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7842) },
                    { 76, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7844), "VARGAS YAPURA EDWIN", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7844) },
                    { 77, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7846), "VALLET VALLET CORRADO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7846) },
                    { 78, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7848), "VEIZAGA GONZALES JOSUE OBED", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7848) },
                    { 79, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7850), "VELASCO GUAMAN ANGEL", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7851) },
                    { 80, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7852), "VILLAGOMEZ MELGAR JOSE JUNIOR", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7853) },
                    { 81, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7855), "ZEBALLOS PAREDES DANIEL LUIS", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7855) },
                    { 82, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7857), "ZUNA VILLAGOMEZ JULIO", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7857) },
                    { 83, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7859), "ZUÑIGA RUIZ WILMA", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7859) },
                    { 84, 15157507, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7861), "POR DESIGNAR", 78481534L, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(7861) }
                });

            migrationBuilder.InsertData(
                table: "gestion",
                columns: new[] { "id", "created_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8174), "1/2025", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8175) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8178), "2/2025", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8178) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8180), "3/2025", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8180) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8181), "4/2025", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8182) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8183), "1/2024", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8184) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8185), "2/2024", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8185) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8187), "3/2024", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8187) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8189), "4/2024", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8189) }
                });

            migrationBuilder.InsertData(
                table: "grupo",
                columns: new[] { "id", "created_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9155), "SA", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9156) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9159), "SB", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9159) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9161), "SC", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9161) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9162), "SD", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9163) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9164), "SE", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9165) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9166), "SF", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9166) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9168), "SG", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9168) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9170), "SH", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9170) },
                    { 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9171), "SI", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9172) },
                    { 10, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9173), "SK", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9174) },
                    { 11, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9175), "SN", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9175) },
                    { 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9177), "SM", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9177) },
                    { 13, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9178), "SP", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9179) },
                    { 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9180), "SR", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9181) },
                    { 15, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9182), "SS", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9182) },
                    { 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9184), "SX", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9184) },
                    { 17, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9186), "SZ", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9186) },
                    { 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9187), "F1", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9188) },
                    { 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9189), "BI", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9190) },
                    { 20, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9191), "CI", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9191) },
                    { 21, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9193), "C1", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9193) },
                    { 22, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9194), "I2", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9195) },
                    { 23, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9196), "ER", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9197) },
                    { 24, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9198), "R1", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9199) },
                    { 25, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9200), "1I", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9200) },
                    { 26, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9202), "I1", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9202) },
                    { 27, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9203), "NW", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9204) },
                    { 28, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9205), "NX", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9206) },
                    { 29, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9207), "W1", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9207) },
                    { 30, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9209), "X2", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9209) },
                    { 31, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9210), "X3", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9211) },
                    { 32, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9212), "X4", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9212) },
                    { 33, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9213), "Z1", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9214) },
                    { 34, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9215), "Z2", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9216) },
                    { 35, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9217), "Z3", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9217) },
                    { 36, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9218), "Z4", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9219) },
                    { 37, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9220), "Z5", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9220) },
                    { 38, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9222), "Z6", new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9222) }
                });

            migrationBuilder.InsertData(
                table: "hora",
                columns: new[] { "id", "created_at", "hr_fin", "hr_inicio", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2404), new TimeOnly(8, 30, 0), new TimeOnly(7, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2404) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2414), new TimeOnly(10, 0, 0), new TimeOnly(8, 30, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2415) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2417), new TimeOnly(11, 30, 0), new TimeOnly(10, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2418) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2420), new TimeOnly(13, 0, 0), new TimeOnly(11, 30, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2420) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2422), new TimeOnly(14, 30, 0), new TimeOnly(13, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2423) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2425), new TimeOnly(16, 0, 0), new TimeOnly(14, 30, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2425) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2427), new TimeOnly(9, 15, 0), new TimeOnly(7, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2428) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2469), new TimeOnly(11, 30, 0), new TimeOnly(9, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2470) },
                    { 9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2472), new TimeOnly(13, 0, 0), new TimeOnly(11, 30, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2472) },
                    { 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2474), new TimeOnly(18, 15, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2475) },
                    { 11, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2477), new TimeOnly(20, 30, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2477) },
                    { 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2479), new TimeOnly(22, 45, 0), new TimeOnly(20, 30, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2479) },
                    { 13, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2481), new TimeOnly(12, 15, 0), new TimeOnly(10, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2482) },
                    { 14, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2483), new TimeOnly(13, 45, 0), new TimeOnly(11, 30, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2484) },
                    { 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2487), new TimeOnly(16, 0, 0), new TimeOnly(13, 45, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2487) },
                    { 16, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2497), new TimeOnly(16, 45, 0), new TimeOnly(15, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2497) },
                    { 17, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2499), new TimeOnly(17, 30, 0), new TimeOnly(15, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2499) },
                    { 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2501), new TimeOnly(19, 0, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2501) },
                    { 19, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2503), new TimeOnly(21, 15, 0), new TimeOnly(19, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2504) },
                    { 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2505), new TimeOnly(20, 30, 0), new TimeOnly(19, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2506) },
                    { 21, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2507), new TimeOnly(22, 0, 0), new TimeOnly(19, 45, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2508) },
                    { 22, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2510), new TimeOnly(13, 0, 0), new TimeOnly(10, 45, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2510) },
                    { 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2512), new TimeOnly(15, 15, 0), new TimeOnly(13, 45, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2512) },
                    { 24, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2514), new TimeOnly(15, 15, 0), new TimeOnly(13, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2514) },
                    { 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2516), new TimeOnly(16, 45, 0), new TimeOnly(15, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2516) },
                    { 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2518), new TimeOnly(17, 30, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2518) },
                    { 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2520), new TimeOnly(18, 15, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2521) },
                    { 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2522), new TimeOnly(19, 45, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2523) },
                    { 29, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2524), new TimeOnly(21, 15, 0), new TimeOnly(19, 45, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2525) },
                    { 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2526), new TimeOnly(22, 45, 0), new TimeOnly(21, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2527) },
                    { 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2530), new TimeOnly(22, 0, 0), new TimeOnly(20, 30, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2531) },
                    { 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2532), new TimeOnly(13, 45, 0), new TimeOnly(12, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2533) },
                    { 33, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2534), new TimeOnly(19, 45, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2535) },
                    { 34, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2537), new TimeOnly(10, 45, 0), new TimeOnly(9, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2537) },
                    { 35, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2539), new TimeOnly(11, 30, 0), new TimeOnly(8, 30, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2539) },
                    { 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2542), new TimeOnly(16, 0, 0), new TimeOnly(13, 0, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2542) },
                    { 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2544), new TimeOnly(12, 15, 0), new TimeOnly(9, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2544) },
                    { 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2546), new TimeOnly(21, 15, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2547) }
                });

            migrationBuilder.InsertData(
                table: "horario",
                columns: new[] { "id", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1964), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1965) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1967), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1967) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1968), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1969) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1970), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1971) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1972), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1972) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1974), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1974) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1975), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1976) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1977), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1977) },
                    { 9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1978), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1979) },
                    { 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1980), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1980) },
                    { 11, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1982), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1982) },
                    { 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1983), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1984) },
                    { 13, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1985), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1985) },
                    { 14, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1987), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1987) },
                    { 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1988), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1989) },
                    { 16, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1990), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1990) },
                    { 17, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1991), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1992) },
                    { 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1993), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1993) },
                    { 19, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1994), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1995) },
                    { 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1996), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1997) },
                    { 21, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1998), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1998) },
                    { 22, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1999), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2000) },
                    { 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2001), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2002) },
                    { 24, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2003), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2003) },
                    { 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2004), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2005) },
                    { 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2006), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2007) },
                    { 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2008), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2008) },
                    { 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2009), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2010) },
                    { 29, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2011), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2011) },
                    { 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2013), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2013) },
                    { 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2014), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2015) },
                    { 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2016), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2016) },
                    { 33, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2017), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2018) },
                    { 34, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2019), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2019) },
                    { 35, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2021), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2021) },
                    { 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2022), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2023) },
                    { 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2024), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2024) },
                    { 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2025), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2026) },
                    { 39, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2027), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2027) },
                    { 40, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2029), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2029) },
                    { 41, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2030), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2031) },
                    { 42, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2032), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2032) },
                    { 43, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2035), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2035) },
                    { 44, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2037), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2037) },
                    { 45, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2038), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2039) },
                    { 46, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2040), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2040) },
                    { 47, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2041), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2042) },
                    { 48, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2043), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2043) },
                    { 49, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2045), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2045) },
                    { 50, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2088), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2089) },
                    { 51, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2091), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2092) },
                    { 52, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2093), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2093) },
                    { 53, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2095), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2095) },
                    { 54, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2097), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2097) },
                    { 55, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2098), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2099) },
                    { 56, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2100), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2100) },
                    { 57, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2102), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2102) },
                    { 58, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2103), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2104) },
                    { 59, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2105), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2105) },
                    { 60, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2106), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2107) },
                    { 61, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2108), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2108) },
                    { 62, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2110), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2110) },
                    { 63, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2111), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2112) },
                    { 64, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2113), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2113) },
                    { 65, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2115), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2115) },
                    { 66, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2116), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2117) },
                    { 67, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2118), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2118) },
                    { 68, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2119), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2120) },
                    { 69, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2121), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2122) },
                    { 70, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2123), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2123) },
                    { 71, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2124), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2125) },
                    { 72, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2126), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2126) },
                    { 73, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2128), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2128) },
                    { 74, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2129), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2130) },
                    { 75, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2131), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2131) },
                    { 76, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2133), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2133) },
                    { 77, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2134), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2135) },
                    { 78, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2136), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2136) },
                    { 79, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2137), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2138) },
                    { 80, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2139), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2140) },
                    { 81, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2141), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2141) },
                    { 82, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2142), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2143) },
                    { 83, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2144), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2144) },
                    { 84, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2146), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2146) },
                    { 85, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2147), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2148) },
                    { 86, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2149), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2149) },
                    { 87, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2150), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2151) }
                });

            migrationBuilder.InsertData(
                table: "materia",
                columns: new[] { "id", "created_at", "credito", "es_electiva", "nombre", "sigla", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3500), (short)5, false, "CÁLCULO I", "MAT101", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3501) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3509), (short)5, false, "ESTRUCTURAS DISCRETAS", "INF119", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3510) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3512), (short)5, false, "INTRODUCCIÓN A LA INFORMÁTICA", "INF110", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3513) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3515), (short)5, false, "FÍSICA I", "FIS100", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3515) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3517), (short)5, false, "INGLÉS TÉCNICO I", "LIN100", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3518) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3520), (short)5, false, "CÁLCULO II", "MAT102", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3520) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3522), (short)5, false, "ÁLGEBRA LINEAL", "MAT103", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3523) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3525), (short)5, false, "PROGRAMACIÓN I", "INF120", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3525) },
                    { 9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3527), (short)5, false, "FÍSICA II", "FIS102", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3528) },
                    { 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3529), (short)5, false, "INGLÉS TÉCNICO II", "LIN101", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3530) },
                    { 11, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3532), (short)5, false, "ECUACIONES DIFERENCIALES", "MAT207", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3532) },
                    { 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3534), (short)5, false, "PROGRAMACIÓN II", "INF210", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3534) },
                    { 13, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3536), (short)5, false, "ARQUITECTURA DE COMPUTADORAS", "INF211", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3537) },
                    { 14, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3539), (short)6, false, "FÍSICA III", "FIS200", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3539) },
                    { 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3541), (short)4, false, "ADMINISTRACIÓN", "ADM100", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3541) },
                    { 16, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3543), (short)5, false, "PROBABILIDAD Y ESTADÍSTICA I", "MAT202", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3544) },
                    { 17, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3546), (short)5, false, "MÉTODOS NUMÉRICOS", "MAT205", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3546) },
                    { 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3548), (short)5, false, "ESTRUCTURA DE DATOS I", "INF220", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3548) },
                    { 19, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3550), (short)5, false, "PROGRAMACIÓN ENSAMBLADOR", "INF221", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3550) },
                    { 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3552), (short)4, false, "CONTABILIDAD", "ADM200", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3553) },
                    { 21, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3555), (short)5, false, "PROBABILIDAD Y ESTADÍSTICA II", "MAT302", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3555) },
                    { 22, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3557), (short)5, false, "PROGRAMACIÓN LÓGICA Y FUNCIONAL", "INF318", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3557) },
                    { 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3559), (short)5, false, "ESTRUCTURA DE DATOS II", "INF310", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3560) },
                    { 24, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3562), (short)5, false, "BASE DE DATOS I", "INF312", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3562) },
                    { 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3564), (short)5, false, "LENGUAJES FORMALES", "INF319", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3564) },
                    { 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3571), (short)5, false, "INVESTIGACIÓN OPERATIVA I", "MAT329", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3571) },
                    { 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3573), (short)5, false, "SISTEMAS DE INFORMACIÓN I", "INF342", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3573) },
                    { 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3575), (short)5, false, "SISTEMAS OPERATIVOS I", "INF323", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3576) },
                    { 29, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3577), (short)5, false, "BASE DE DATOS II", "INF322", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3578) },
                    { 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3586), (short)5, false, "COMPILADORES", "INF329", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3587) },
                    { 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3591), (short)5, false, "INVESTIGACIÓN OPERATIVA II", "MAT419", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3591) },
                    { 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3593), (short)5, false, "INTELIGENCIA ARTIFICIAL", "INF418", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3593) },
                    { 33, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3595), (short)5, false, "SISTEMAS OPERATIVOS II", "INF413", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3596) },
                    { 34, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3598), (short)5, false, "REDES I", "INF433", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3598) },
                    { 35, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3600), (short)5, false, "INGENIERÍA DE SOFTWARE I", "INF422", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3600) },
                    { 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3604), (short)5, false, "PREPARACIÓN Y EVALUACIÓN DE PROYECTOS", "ECO449", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3605) },
                    { 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3607), (short)5, false, "SISTEMAS EXPERTOS", "INF428", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3607) },
                    { 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3609), (short)5, false, "SISTEMAS DE INFORMACIÓN II", "INF412", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3609) },
                    { 39, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3611), (short)5, false, "REDES II", "INF423", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3612) },
                    { 40, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3656), (short)5, false, "INGENIERÍA DE SOFTWARE II", "INF512", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3656) },
                    { 41, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3661), (short)5, false, "TALLER DE GRADO I", "INF511", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3662) },
                    { 42, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3664), (short)5, false, "TECNOLOGÍA WEB", "INF513", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3664) },
                    { 43, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3666), (short)4, false, "ARQUITECTURA DE SOFTWARE", "INF552", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3666) },
                    { 44, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3668), (short)4, false, "SISTEMAS DE INFORMACIÓN GEOGRÁFICA", "INF442", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3669) },
                    { 53, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3566), (short)5, false, "ORGANIZACIÓN Y MÉTODOS", "ADM330", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3566) },
                    { 54, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3568), (short)5, false, "ECONOMÍA PARA LA GESTIÓN", "ECO300", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3569) },
                    { 55, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3589), (short)5, false, "FINANZAS PARA LA EMPRESA", "ADM320", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3589) },
                    { 56, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3602), (short)5, false, "SISTEMAS PARA EL SOPORTE A LA TOMA DE DECISIONES", "INF432", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3603) },
                    { 57, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3659), (short)4, false, "AUDITORÍA INFORMÁTICA", "INF462", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3659) },
                    { 58, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3671), (short)5, false, "MODALIDAD DE GRADUACIÓN", "GRLO01", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3671) },
                    { 59, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3673), (short)10, true, "MODELACIÓN Y SIMULACIÓN DE SISTEMAS", "ELCI01", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3673) },
                    { 60, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3675), (short)10, true, "PROGRAMACIÓN GRÁFICA", "ELCI02", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3676) },
                    { 61, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3678), (short)10, true, "TÓPICOS AVANZADOS DE PROGRAMACIÓN", "ELCI03", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3678) },
                    { 62, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3680), (short)10, true, "PROGRAMACIÓN DE APLICACIONES DE TIEMPO REAL", "ELCI04", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3680) },
                    { 63, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3684), (short)10, true, "SISTEMAS DISTRIBUIDOS", "ELCI05", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3684) },
                    { 64, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3686), (short)10, true, "INTERACCIÓN HOMBRE COMPUTADOR", "ELCI06", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3686) },
                    { 65, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3688), (short)10, true, "CRIPTOGRAFÍA Y SEGURIDAD", "ELCI07", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3689) },
                    { 66, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3690), (short)10, true, "CONTROL AND AUTOMATIZACIÓN", "ELCI08", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3691) },
                    { 67, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3693), (short)3, true, "ADMINISTRACIÓN DE RECURSOS HUMANOS", "ELC001", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3693) },
                    { 68, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3695), (short)3, true, "COSTOS Y PRESUPUESTOS", "ELC002", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3696) },
                    { 69, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3698), (short)3, true, "PRODUCCIÓN Y MARKETING", "ELC003", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3698) },
                    { 70, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3700), (short)3, true, "REINGENIERÍA", "ELC004", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3700) },
                    { 71, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3702), (short)3, true, "INGENIERÍA DE LA CALIDAD", "ELC005", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3703) },
                    { 72, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3705), (short)3, true, "BENCHMARKING", "ELC006", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3705) },
                    { 73, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3707), (short)3, true, "INTRODUCCIÓN A LA MACROECONOMÍA", "ELC007", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3707) },
                    { 74, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3709), (short)3, true, "LEGISLACIÓN EN CIENCIAS DE LA COMPUTACIÓN", "ELC008", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3710) },
                    { 75, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3711), (short)5, false, "ANÁLISIS DE CIRCUITOS", "RDS210", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3712) },
                    { 76, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3714), (short)5, false, "TEORÍA DE CAMPOS", "ELT241", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3714) },
                    { 77, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3716), (short)4, false, "ANÁLISIS DE CIRCUITOS ELECTRÓNICOS", "RDS220", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3716) },
                    { 78, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3718), (short)5, false, "ELECTRÓNICA APLICADA A REDES", "RDS310", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3719) },
                    { 79, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3721), (short)5, false, "SISTEMAS LÓGICOS Y DIGITALES I", "ELT352", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3721) },
                    { 80, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3723), (short)5, false, "SEÑALES Y SISTEMAS", "ELT354", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3723) },
                    { 81, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3725), (short)5, true, "DISEÑO DE CIRCUITOS INTEGRADOS", "ELC201", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3725) },
                    { 82, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3727), (short)5, true, "INSTRUMENTACIÓN", "ELC202", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3728) },
                    { 83, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3730), (short)5, false, "SISTEMAS LÓGICOS Y DIGITALES II", "ELT362", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3730) },
                    { 84, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3732), (short)5, false, "INTERPRETACIÓN DE SISTEMAS Y SEÑALES", "RDS320", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3733) },
                    { 85, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3735), (short)5, true, "SISTEMAS DE COMUNICACIÓN SCADA", "ELC203", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3735) },
                    { 86, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3737), (short)5, true, "TELEVISIÓN DIGITAL", "ELC204", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3737) },
                    { 87, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3739), (short)5, false, "APLICACIONES CON MICROPROCESADORES", "RDS410", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3740) },
                    { 88, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3742), (short)5, false, "SISTEMAS DE COMUNICACIÓN I", "ELT374", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3742) },
                    { 89, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3744), (short)5, true, "DOMÓTICA", "ELC205", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3744) },
                    { 90, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3746), (short)5, false, "LÍNEAS DE TRANSMISIÓN Y ANTENAS", "ELC206", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3746) },
                    { 91, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3748), (short)5, false, "TALLER DE ANÁLISIS Y DISEÑO DE REDES", "RDS421", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3749) },
                    { 92, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3750), (short)5, false, "LEGISLACIÓN EN REDES Y COMUNICACIONES", "RS429", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3751) },
                    { 93, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3753), (short)5, false, "SISTEMAS DE COMUNICACIÓN II", "ELC384", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3753) },
                    { 94, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3756), (short)5, true, "TÉCNICAS DE PRESENTACIÓN PARA INGENIERÍA", "ELC207", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3756) },
                    { 95, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3759), (short)5, true, "REDES ADHOC", "ELC208", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3760) },
                    { 96, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3761), (short)5, false, "GESTIÓN Y ADMINISTRACIÓN DE REDES", "RDS511", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3762) },
                    { 97, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3765), (short)5, false, "REDES INALÁMBRICAS Y COMUNICACIONES MÓVILES", "RDS512", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3765) },
                    { 98, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3768), (short)5, false, "SEGURIDAD EN REDES Y TRANSMISIÓN DE DATOS", "RDS519", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3768) },
                    { 99, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3770), (short)5, false, "MODALIDAD DE TITULACIÓN A NIVEL TÉCNICO SUPERIOR", "GRT001", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3771) },
                    { 100, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3773), (short)5, false, "MODALIDAD DE TITULACIÓN LICENCIATURA", "GRL001", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3773) }
                });

            migrationBuilder.InsertData(
                table: "modulo",
                columns: new[] { "id", "created_at", "nro_modulo", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4037), (short)236, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4038) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4040), (short)225, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4040) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4041), (short)260, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4042) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4043), (short)224, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4044) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4045), (short)256, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4045) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4047), (short)222, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4047) }
                });

            migrationBuilder.InsertData(
                table: "nivel",
                columns: new[] { "id", "created_at", "nombre", "orden", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4193), "1 SEMESTRE", (short)1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4194) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4196), "2 SEMESTRE", (short)2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4197) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4198), "3 SEMESTRE", (short)3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4199) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4200), "4 SEMESTRE", (short)4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4201) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4202), "5 SEMESTRE", (short)5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4202) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4204), "6 SEMESTRE", (short)6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4204) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4206), "7 SEMESTRE", (short)7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4206) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4207), "8 SEMESTRE", (short)8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4208) },
                    { 9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4209), "9 SEMESTRE", (short)9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4210) },
                    { 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4211), "10 SEMESTRE", (short)10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4212) }
                });

            migrationBuilder.InsertData(
                table: "grupo_materia",
                columns: new[] { "id", "created_at", "grupo_id", "materia_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8397), 1, 15, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8397) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8401), 2, 15, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8402) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8403), 3, 15, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8404) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8405), 1, 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8406) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8407), 2, 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8408) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8409), 3, 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8410) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8411), 4, 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8412) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8413), 5, 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8414) },
                    { 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8415), 6, 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8416) },
                    { 10, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8417), 1, 75, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8418) },
                    { 11, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8419), 2, 75, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8420) },
                    { 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8421), 17, 77, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8422) },
                    { 13, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8423), 1, 87, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8424) },
                    { 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8425), 1, 13, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8426) },
                    { 15, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8427), 2, 13, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8428) },
                    { 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8429), 1, 43, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8430) },
                    { 17, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8431), 1, 57, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8432) },
                    { 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8433), 1, 24, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8434) },
                    { 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8435), 3, 24, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8436) },
                    { 20, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8437), 2, 29, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8438) },
                    { 21, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8439), 4, 29, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8439) },
                    { 22, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8441), 18, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8441) },
                    { 23, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8443), 17, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8443) },
                    { 24, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8445), 20, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8445) },
                    { 25, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8447), 22, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8447) },
                    { 26, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8449), 6, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8449) },
                    { 27, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8450), 7, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8451) },
                    { 28, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8452), 9, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8453) },
                    { 29, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8454), 13, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8455) },
                    { 30, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8456), 33, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8456) },
                    { 31, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8458), 34, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8458) },
                    { 32, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8460), 35, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8460) },
                    { 33, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8461), 36, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8462) },
                    { 34, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8463), 37, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8464) },
                    { 35, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8465), 38, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8465) },
                    { 36, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8467), 2, 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8467) },
                    { 37, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8469), 4, 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8469) },
                    { 38, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8470), 24, 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8471) },
                    { 39, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8473), 25, 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8473) },
                    { 40, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8475), 21, 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8475) },
                    { 41, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8476), 8, 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8477) },
                    { 42, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8478), 11, 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8479) },
                    { 43, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8480), 1, 30, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8480) },
                    { 44, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8482), 1, 20, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8482) },
                    { 45, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8484), 2, 20, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8484) },
                    { 46, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8485), 1, 68, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8486) },
                    { 47, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8487), 22, 65, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8487) },
                    { 48, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8489), 1, 65, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8489) },
                    { 49, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8491), 1, 81, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8491) },
                    { 50, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8492), 1, 54, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8493) },
                    { 51, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8494), 2, 54, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8495) },
                    { 52, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8496), 27, 11, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8496) },
                    { 53, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8498), 28, 11, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8498) },
                    { 54, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8500), 1, 11, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8500) },
                    { 55, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8501), 3, 11, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8502) },
                    { 56, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8503), 2, 78, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8504) },
                    { 57, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8505), 22, 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8505) },
                    { 58, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8507), 1, 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8507) },
                    { 59, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8508), 2, 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8509) },
                    { 60, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8510), 4, 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8511) },
                    { 61, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8554), 1, 23, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8555) },
                    { 62, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8557), 2, 23, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8557) },
                    { 63, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8559), 16, 23, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8559) },
                    { 64, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8561), 5, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8561) },
                    { 65, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8563), 6, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8563) },
                    { 66, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8565), 8, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8565) },
                    { 67, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8567), 10, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8567) },
                    { 68, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8569), 34, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8569) },
                    { 69, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8571), 35, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8571) },
                    { 70, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8572), 13, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8573) },
                    { 71, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8574), 33, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8575) },
                    { 72, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8576), 36, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8576) },
                    { 73, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8578), 37, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8578) },
                    { 74, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8580), 38, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8580) },
                    { 75, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8581), 1, 55, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8582) },
                    { 76, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8583), 3, 55, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8584) },
                    { 77, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8585), 24, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8586) },
                    { 78, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8587), 26, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8587) },
                    { 79, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8589), 7, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8589) },
                    { 80, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8591), 9, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8591) },
                    { 81, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8592), 10, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8593) },
                    { 82, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8594), 12, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8595) },
                    { 83, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8596), 13, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8597) },
                    { 84, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8598), 33, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8598) },
                    { 85, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8600), 34, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8600) },
                    { 86, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8601), 35, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8602) },
                    { 87, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8603), 36, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8604) },
                    { 88, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8605), 37, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8605) },
                    { 89, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8607), 38, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8607) },
                    { 90, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8609), 19, 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8609) },
                    { 91, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8610), 24, 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8611) },
                    { 92, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8612), 27, 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8613) },
                    { 93, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8614), 28, 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8614) },
                    { 94, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8616), 1, 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8616) },
                    { 95, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8618), 2, 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8618) },
                    { 96, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8619), 1, 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8620) },
                    { 97, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8621), 2, 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8622) },
                    { 98, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8623), 3, 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8623) },
                    { 99, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8625), 34, 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8625) },
                    { 100, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8628), 35, 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8628) },
                    { 101, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8630), 36, 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8630) },
                    { 102, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8631), 1, 96, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8632) },
                    { 103, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8633), 1, 71, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8634) },
                    { 104, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8635), 2, 35, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8635) },
                    { 105, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8637), 3, 35, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8637) },
                    { 106, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8638), 2, 40, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8639) },
                    { 107, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8640), 27, 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8641) },
                    { 108, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8642), 28, 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8642) },
                    { 109, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8644), 33, 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8644) },
                    { 110, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8646), 34, 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8646) },
                    { 111, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8647), 35, 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8648) },
                    { 112, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8649), 36, 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8649) },
                    { 113, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8651), 38, 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8651) },
                    { 114, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8653), 2, 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8653) },
                    { 115, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8654), 3, 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8655) },
                    { 116, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8656), 4, 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8657) },
                    { 117, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8658), 9, 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8658) },
                    { 118, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8660), 1, 21, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8660) },
                    { 119, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8662), 2, 21, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8662) },
                    { 120, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8663), 9, 21, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8664) },
                    { 121, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8665), 1, 69, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8665) },
                    { 122, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8667), 1, 22, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8667) },
                    { 123, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8669), 1, 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8669) },
                    { 124, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8670), 2, 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8671) },
                    { 125, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8672), 3, 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8673) },
                    { 126, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8674), 16, 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8674) },
                    { 127, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8676), 1, 60, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8676) },
                    { 128, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8677), 1, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8678) },
                    { 129, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8679), 3, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8680) },
                    { 130, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8681), 2, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8681) },
                    { 131, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8684), 7, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8684) },
                    { 132, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8686), 4, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8686) },
                    { 133, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8688), 6, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8688) },
                    { 134, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8689), 8, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8690) },
                    { 135, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8691), 9, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8691) },
                    { 136, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8693), 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8693) },
                    { 137, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8695), 4, 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8695) },
                    { 138, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8696), 3, 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8697) },
                    { 139, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8698), 2, 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8698) },
                    { 140, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8740), 9, 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8740) },
                    { 141, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8742), 1, 95, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8742) },
                    { 142, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8744), 1, 34, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8744) },
                    { 143, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8746), 2, 34, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8746) },
                    { 144, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8748), 3, 34, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8748) },
                    { 145, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8750), 24, 39, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8750) },
                    { 146, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8752), 2, 39, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8752) },
                    { 147, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8753), 3, 39, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8754) },
                    { 148, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8755), 1, 97, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8755) },
                    { 149, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8757), 1, 98, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8757) },
                    { 150, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8759), 24, 80, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8759) },
                    { 151, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8760), 14, 88, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8761) },
                    { 152, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8762), 14, 93, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8763) },
                    { 153, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8764), 24, 85, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8764) },
                    { 154, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8766), 9, 44, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8766) },
                    { 155, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8768), 1, 44, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8768) },
                    { 156, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8769), 1, 27, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8770) },
                    { 157, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8771), 3, 27, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8772) },
                    { 158, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8773), 1, 38, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8773) },
                    { 159, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8775), 2, 38, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8775) },
                    { 160, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8777), 2, 37, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8777) },
                    { 161, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8778), 23, 79, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8779) },
                    { 162, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8780), 24, 83, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8781) },
                    { 163, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8782), 1, 28, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8782) },
                    { 164, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8784), 3, 28, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8784) },
                    { 165, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8786), 1, 33, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8786) },
                    { 166, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8787), 2, 33, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8788) },
                    { 167, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8789), 1, 56, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8790) },
                    { 168, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8791), 1, 91, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8791) },
                    { 169, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8793), 15, 41, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8793) },
                    { 170, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8795), 1, 41, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8795) },
                    { 171, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8796), 3, 41, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8797) },
                    { 172, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8798), 1, 42, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8799) },
                    { 173, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8800), 3, 42, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8800) },
                    { 174, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8802), 14, 86, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8802) },
                    { 175, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8804), 3, 76, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8804) },
                    { 176, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8805), 1, 61, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(8806) }
                });

            migrationBuilder.InsertData(
                table: "hora_dia",
                columns: new[] { "id", "created_at", "dia_id", "hora_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(284), 1, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(284) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(288), 1, 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(288) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(290), 1, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(291) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(292), 1, 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(293) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(294), 1, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(295) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(296), 1, 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(297) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(298), 1, 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(299) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(300), 1, 5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(301) },
                    { 9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(302), 1, 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(303) },
                    { 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(304), 1, 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(305) },
                    { 11, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(306), 1, 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(307) },
                    { 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(308), 1, 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(308) },
                    { 13, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(310), 1, 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(310) },
                    { 14, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(312), 1, 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(312) },
                    { 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(314), 1, 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(314) },
                    { 16, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(316), 1, 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(316) },
                    { 17, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(318), 1, 21, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(318) },
                    { 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(320), 1, 29, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(320) },
                    { 19, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(321), 1, 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(322) },
                    { 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(323), 1, 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(324) },
                    { 21, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(325), 2, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(325) },
                    { 22, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(327), 2, 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(327) },
                    { 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(329), 2, 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(329) },
                    { 24, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(330), 2, 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(331) },
                    { 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(332), 2, 22, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(333) },
                    { 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(334), 2, 9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(334) },
                    { 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(336), 2, 14, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(336) },
                    { 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(338), 2, 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(338) },
                    { 29, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(339), 2, 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(340) },
                    { 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(341), 2, 24, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(342) },
                    { 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(343), 2, 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(343) },
                    { 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(345), 2, 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(345) },
                    { 33, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(347), 2, 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(347) },
                    { 34, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(348), 2, 17, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(349) },
                    { 35, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(350), 2, 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(351) },
                    { 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(352), 2, 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(352) },
                    { 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(354), 2, 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(354) },
                    { 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(355), 2, 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(356) },
                    { 39, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(357), 2, 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(358) },
                    { 40, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(359), 2, 11, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(359) },
                    { 41, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(361), 2, 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(361) },
                    { 42, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(363), 2, 19, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(363) },
                    { 43, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(364), 2, 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(365) },
                    { 44, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(366), 2, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(367) },
                    { 45, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(368), 2, 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(368) },
                    { 46, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(370), 3, 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(370) },
                    { 47, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(371), 3, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(372) },
                    { 48, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(373), 3, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(374) },
                    { 49, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(375), 3, 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(375) },
                    { 50, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(377), 3, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(377) },
                    { 51, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(379), 3, 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(379) },
                    { 52, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(382), 3, 14, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(382) },
                    { 53, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(384), 3, 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(384) },
                    { 54, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(385), 3, 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(386) },
                    { 55, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(387), 3, 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(388) },
                    { 56, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(389), 3, 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(389) },
                    { 57, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(391), 3, 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(391) },
                    { 58, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(393), 3, 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(393) },
                    { 59, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(394), 3, 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(395) },
                    { 60, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(396), 3, 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(396) },
                    { 61, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(398), 3, 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(398) },
                    { 62, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(400), 3, 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(400) },
                    { 63, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(401), 3, 29, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(402) },
                    { 64, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(403), 3, 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(404) },
                    { 65, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(405), 3, 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(405) },
                    { 66, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(407), 4, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(407) },
                    { 67, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(438), 4, 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(442) },
                    { 68, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(444), 4, 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(445) },
                    { 69, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(446), 4, 22, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(447) },
                    { 70, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(448), 4, 14, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(449) },
                    { 71, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(450), 4, 24, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(451) },
                    { 72, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(452), 4, 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(453) },
                    { 73, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(454), 4, 17, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(455) },
                    { 74, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(456), 4, 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(456) },
                    { 75, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(458), 4, 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(458) },
                    { 76, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(460), 4, 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(460) },
                    { 77, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(462), 4, 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(462) },
                    { 78, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(464), 4, 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(464) },
                    { 79, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(466), 4, 11, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(466) },
                    { 80, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(468), 4, 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(468) },
                    { 81, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(470), 4, 19, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(470) },
                    { 82, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(472), 4, 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(472) },
                    { 83, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(473), 4, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(474) },
                    { 84, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(475), 4, 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(476) },
                    { 85, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(477), 5, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(478) },
                    { 86, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(479), 5, 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(480) },
                    { 87, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(481), 5, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(481) },
                    { 88, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(483), 5, 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(483) },
                    { 89, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(485), 5, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(485) },
                    { 90, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(487), 5, 13, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(487) },
                    { 91, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(489), 3, 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(489) },
                    { 92, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(491), 5, 14, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(491) },
                    { 93, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(493), 5, 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(493) },
                    { 94, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(494), 5, 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(495) },
                    { 95, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(496), 5, 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(497) },
                    { 96, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(498), 5, 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(499) },
                    { 97, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(500), 5, 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(501) },
                    { 98, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(502), 5, 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(503) },
                    { 99, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(504), 5, 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(504) },
                    { 100, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(506), 5, 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(506) },
                    { 101, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(508), 5, 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(508) },
                    { 102, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(510), 5, 21, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(510) },
                    { 103, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(512), 5, 29, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(512) },
                    { 104, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(514), 5, 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(514) },
                    { 105, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(515), 5, 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(516) },
                    { 106, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(517), 6, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(518) },
                    { 107, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(519), 6, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(520) },
                    { 108, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(521), 6, 35, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(522) },
                    { 109, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(523), 6, 34, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(523) },
                    { 110, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(525), 6, 13, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(525) },
                    { 111, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(527), 6, 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(527) },
                    { 112, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(529), 6, 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(529) },
                    { 113, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(531), 6, 33, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(531) },
                    { 114, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(533), 3, 22, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(533) },
                    { 115, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(534), 5, 22, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(535) },
                    { 116, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(536), 3, 21, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(537) }
                });

            migrationBuilder.InsertData(
                table: "plan_estudio",
                columns: new[] { "id", "carrera_id", "codigo", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 2, "ING-INF", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4369), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4369) },
                    { 2, 3, "ING-SIS", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4371), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4372) },
                    { 3, 1, "ING-RED", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4374), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4374) },
                    { 4, 4, "ING-ROB", new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4376), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4376) }
                });

            migrationBuilder.InsertData(
                table: "hora_dia_horario",
                columns: new[] { "id", "created_at", "hora_dia_id", "horario_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9435), 1, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9436) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9440), 47, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9440) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9442), 85, 1, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9442) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9443), 3, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9444) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9445), 48, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9445) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9447), 87, 2, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9447) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9448), 5, 3, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9449) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9450), 50, 3, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9450) },
                    { 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9451), 89, 3, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9452) },
                    { 10, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9453), 6, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9454) },
                    { 11, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9455), 51, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9455) },
                    { 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9456), 91, 4, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9457) },
                    { 13, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9458), 7, 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9458) },
                    { 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9555), 53, 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9556) },
                    { 15, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9558), 93, 5, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9559) },
                    { 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9560), 9, 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9561) },
                    { 17, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9562), 54, 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9562) },
                    { 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9563), 95, 6, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9564) },
                    { 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9565), 11, 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9566) },
                    { 20, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9567), 57, 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9567) },
                    { 21, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9568), 96, 7, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9569) },
                    { 22, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9570), 13, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9570) },
                    { 23, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9572), 60, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9572) },
                    { 24, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9573), 97, 8, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9574) },
                    { 25, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9575), 14, 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9575) },
                    { 26, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9577), 59, 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9577) },
                    { 27, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9578), 98, 9, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9579) },
                    { 28, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9580), 15, 10, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9580) },
                    { 29, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9581), 61, 10, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9582) },
                    { 30, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9583), 100, 10, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9583) },
                    { 31, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9585), 16, 11, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9585) },
                    { 32, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9586), 62, 11, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9587) },
                    { 33, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9588), 101, 11, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9588) },
                    { 34, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9590), 18, 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9590) },
                    { 35, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9591), 63, 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9592) },
                    { 36, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9593), 103, 12, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9593) },
                    { 37, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9594), 20, 13, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9595) },
                    { 38, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9596), 65, 13, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9596) },
                    { 39, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9600), 105, 13, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9600) },
                    { 40, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9601), 19, 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9602) },
                    { 41, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9603), 64, 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9603) },
                    { 42, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9604), 104, 14, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9605) },
                    { 43, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9606), 1, 15, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9606) },
                    { 44, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9608), 47, 15, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9608) },
                    { 45, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9609), 85, 15, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9610) },
                    { 46, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9611), 106, 15, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9611) },
                    { 47, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9612), 5, 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9613) },
                    { 48, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9614), 50, 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9614) },
                    { 49, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9616), 89, 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9616) },
                    { 50, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9617), 112, 16, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9618) },
                    { 51, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9619), 5, 17, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9619) },
                    { 52, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9620), 50, 17, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9621) },
                    { 53, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9622), 89, 17, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9622) },
                    { 54, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9624), 113, 17, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9624) },
                    { 55, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9625), 14, 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9626) },
                    { 56, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9627), 59, 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9627) },
                    { 57, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9629), 98, 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9629) },
                    { 58, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9630), 107, 18, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9631) },
                    { 59, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9632), 18, 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9632) },
                    { 60, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9634), 63, 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9634) },
                    { 61, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9635), 103, 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9636) },
                    { 62, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9637), 109, 19, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9637) },
                    { 63, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9639), 9, 20, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9639) },
                    { 64, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9640), 54, 20, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9641) },
                    { 65, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9642), 95, 20, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9642) },
                    { 66, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9643), 98, 20, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9644) },
                    { 67, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9645), 11, 21, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9645) },
                    { 68, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9647), 57, 21, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9647) },
                    { 69, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9648), 96, 21, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9649) },
                    { 70, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9651), 105, 21, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9652) },
                    { 71, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9653), 14, 22, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9653) },
                    { 72, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9654), 59, 22, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9655) },
                    { 73, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9656), 98, 22, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9656) },
                    { 74, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9658), 100, 22, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9658) },
                    { 75, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9659), 2, 23, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9660) },
                    { 76, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9661), 46, 23, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9661) },
                    { 77, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9662), 4, 24, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9663) },
                    { 78, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9664), 49, 24, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9664) },
                    { 79, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9666), 10, 25, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9666) },
                    { 80, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9667), 55, 25, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9668) },
                    { 81, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9669), 12, 26, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9669) },
                    { 82, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9670), 58, 26, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9671) },
                    { 83, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9672), 16, 27, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9672) },
                    { 84, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9674), 62, 27, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9674) },
                    { 85, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9675), 17, 28, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9676) },
                    { 86, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9677), 116, 28, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9677) },
                    { 87, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9678), 2, 29, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9679) },
                    { 88, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9680), 46, 29, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9680) },
                    { 89, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9682), 56, 29, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9682) },
                    { 90, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9683), 2, 30, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9684) },
                    { 91, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9685), 67, 30, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9685) },
                    { 92, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9686), 10, 31, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9687) },
                    { 93, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9688), 72, 31, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9688) },
                    { 94, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9690), 96, 31, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9690) },
                    { 95, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9691), 2, 32, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9692) },
                    { 96, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9693), 86, 32, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9693) },
                    { 97, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9694), 21, 32, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9695) },
                    { 98, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9696), 7, 33, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9696) },
                    { 99, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9698), 36, 33, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9698) },
                    { 100, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9699), 76, 33, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9700) },
                    { 101, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9701), 8, 34, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9701) },
                    { 102, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9702), 22, 34, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9703) },
                    { 103, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9704), 67, 34, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9704) },
                    { 104, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9705), 12, 35, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9706) },
                    { 105, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9707), 21, 35, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9707) },
                    { 106, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9709), 94, 35, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9709) },
                    { 107, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9710), 24, 36, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9711) },
                    { 108, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9712), 22, 37, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9712) },
                    { 109, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9713), 67, 37, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9714) },
                    { 110, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9715), 28, 37, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9715) },
                    { 111, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9717), 22, 38, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9717) },
                    { 112, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9718), 67, 38, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9719) },
                    { 113, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9720), 26, 38, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9720) },
                    { 114, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9721), 40, 39, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9722) },
                    { 115, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9723), 79, 39, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9723) },
                    { 116, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9724), 37, 39, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9725) },
                    { 117, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9726), 40, 40, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9726) },
                    { 118, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9728), 79, 40, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9728) },
                    { 119, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9729), 64, 40, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9730) },
                    { 120, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9731), 22, 41, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9731) },
                    { 121, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9732), 67, 41, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9733) },
                    { 122, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9734), 89, 41, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9734) },
                    { 123, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9736), 22, 42, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9736) },
                    { 124, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9737), 67, 42, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9738) },
                    { 125, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9739), 100, 42, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9739) },
                    { 126, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9740), 32, 43, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9741) },
                    { 127, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9742), 72, 43, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9742) },
                    { 128, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9743), 96, 43, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9744) },
                    { 129, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9745), 36, 44, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9745) },
                    { 130, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9747), 76, 44, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9747) },
                    { 131, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9750), 97, 44, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9750) },
                    { 132, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9751), 31, 45, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9752) },
                    { 133, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9753), 58, 45, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9753) },
                    { 134, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9754), 94, 45, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9755) },
                    { 135, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9756), 11, 46, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9756) },
                    { 136, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9757), 33, 46, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9758) },
                    { 137, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9759), 57, 46, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9759) },
                    { 138, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9761), 37, 46, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9761) },
                    { 139, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9762), 49, 47, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9763) },
                    { 140, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9764), 86, 47, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9764) },
                    { 141, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9765), 52, 48, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9766) },
                    { 142, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9810), 90, 48, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9811) },
                    { 143, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9812), 50, 49, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9813) },
                    { 144, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9814), 96, 49, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9814) },
                    { 145, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9815), 111, 49, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9816) },
                    { 146, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9817), 114, 50, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9817) },
                    { 147, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9819), 115, 50, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9819) },
                    { 148, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9821), 64, 51, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9821) },
                    { 149, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9822), 99, 51, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9823) },
                    { 150, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9824), 55, 52, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9824) },
                    { 151, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9825), 110, 52, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9826) },
                    { 152, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9827), 48, 53, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9828) },
                    { 153, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9829), 67, 53, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9829) },
                    { 154, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9830), 88, 53, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9831) },
                    { 155, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9832), 70, 54, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9832) },
                    { 156, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9834), 92, 54, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9834) },
                    { 157, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9835), 22, 55, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9836) },
                    { 158, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9837), 86, 55, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9837) },
                    { 159, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9839), 29, 56, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9839) },
                    { 160, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9840), 95, 56, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9841) },
                    { 161, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9842), 21, 57, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9842) },
                    { 162, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9845), 66, 57, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9845) },
                    { 163, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9846), 106, 57, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9847) },
                    { 164, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9848), 22, 58, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9849) },
                    { 165, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9850), 86, 58, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9850) },
                    { 166, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9851), 21, 59, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9852) },
                    { 167, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9853), 66, 59, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9853) },
                    { 168, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9855), 23, 60, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9855) },
                    { 169, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9856), 68, 60, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9857) },
                    { 170, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9858), 27, 61, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9858) },
                    { 171, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9859), 70, 61, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9860) },
                    { 172, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9861), 31, 72, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9861) },
                    { 173, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9863), 71, 72, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9863) },
                    { 174, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9864), 32, 73, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9865) },
                    { 175, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9866), 72, 73, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9866) },
                    { 176, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9867), 33, 74, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9868) },
                    { 177, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9869), 74, 74, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9869) },
                    { 178, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9871), 34, 75, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9871) },
                    { 179, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9872), 73, 75, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9873) },
                    { 180, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9874), 36, 76, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9874) },
                    { 181, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9876), 76, 76, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9876) },
                    { 182, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9877), 35, 77, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9878) },
                    { 183, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9879), 75, 77, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9879) },
                    { 184, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9881), 38, 78, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9881) },
                    { 185, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9882), 77, 78, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9883) },
                    { 186, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9884), 40, 79, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9884) },
                    { 187, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9886), 79, 79, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9886) },
                    { 188, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9887), 39, 80, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9888) },
                    { 189, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9889), 78, 80, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9889) },
                    { 190, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9890), 41, 81, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9891) },
                    { 191, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9892), 80, 81, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9892) },
                    { 192, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9894), 42, 82, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9894) },
                    { 193, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9895), 81, 82, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9896) },
                    { 194, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9897), 43, 83, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9897) },
                    { 195, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9898), 82, 83, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9899) },
                    { 196, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9900), 44, 84, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9900) },
                    { 197, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9902), 83, 84, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9902) },
                    { 198, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9903), 45, 85, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9904) },
                    { 199, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9905), 84, 85, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9905) },
                    { 200, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9906), 108, 86, new DateTime(2025, 10, 7, 12, 54, 21, 782, DateTimeKind.Utc).AddTicks(9907) }
                });

            migrationBuilder.InsertData(
                table: "horario_materia",
                columns: new[] { "id", "created_at", "cupos_disponibles", "cupos_total", "docente_id", "gestion_id", "grupo_materia_id", "horario_id", "modulo_id", "nro_aula", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(859), (short)30, (short)100, 29, 1, 1, 10, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(860) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(866), (short)30, (short)100, 29, 1, 2, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(866) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(870), (short)30, (short)100, 12, 1, 3, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(870) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(873), (short)30, (short)100, 26, 1, 4, 2, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(874) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(877), (short)30, (short)100, 26, 1, 5, 3, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(877) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(880), (short)30, (short)100, 26, 1, 6, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(880) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(883), (short)30, (short)100, 26, 1, 7, 4, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(884) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(886), (short)30, (short)100, 33, 1, 8, 3, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(887) },
                    { 9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(890), (short)30, (short)100, 34, 1, 9, 23, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(890) },
                    { 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(893), (short)30, (short)100, 52, 1, 10, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(893) },
                    { 11, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(896), (short)30, (short)100, 52, 1, 11, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(896) },
                    { 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(900), (short)30, (short)100, 52, 1, 12, 2, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(900) },
                    { 13, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(903), (short)30, (short)100, 19, 1, 13, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(904) },
                    { 14, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(906), (short)30, (short)100, 40, 1, 14, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(907) },
                    { 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(909), (short)30, (short)100, 40, 1, 15, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(910) },
                    { 16, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(913), (short)30, (short)100, 78, 1, 16, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(913) },
                    { 17, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(916), (short)30, (short)100, 75, 1, 17, 9, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(916) },
                    { 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(919), (short)30, (short)100, 78, 1, 18, 2, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(919) },
                    { 19, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(922), (short)30, (short)100, 78, 1, 19, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(922) },
                    { 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(925), (short)30, (short)100, 61, 1, 20, 50, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(925) },
                    { 21, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(928), (short)30, (short)100, 61, 1, 21, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(929) },
                    { 22, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(931), (short)30, (short)100, 7, 1, 22, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(932) },
                    { 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(934), (short)30, (short)100, 41, 1, 23, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(935) },
                    { 24, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(939), (short)30, (short)100, 70, 1, 24, 25, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(940) },
                    { 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(943), (short)30, (short)100, 41, 1, 25, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(943) },
                    { 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(946), (short)30, (short)100, 50, 1, 26, 30, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(946) },
                    { 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(949), (short)30, (short)100, 10, 1, 27, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(949) },
                    { 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(952), (short)30, (short)100, 53, 1, 28, 10, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(952) },
                    { 29, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(955), (short)30, (short)100, 28, 1, 29, 55, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(955) },
                    { 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(958), (short)30, (short)100, 69, 1, 30, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(958) },
                    { 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(961), (short)30, (short)100, 1, 1, 31, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(961) },
                    { 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(964), (short)30, (short)100, 49, 1, 32, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(964) },
                    { 33, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(967), (short)30, (short)100, 73, 1, 33, 73, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(967) },
                    { 34, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(970), (short)30, (short)100, 2, 1, 34, 12, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(970) },
                    { 35, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(973), (short)30, (short)100, 20, 1, 35, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(973) },
                    { 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(976), (short)30, (short)100, 43, 1, 36, 14, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(976) },
                    { 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(980), (short)30, (short)100, 20, 1, 37, 57, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(981) },
                    { 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(983), (short)30, (short)100, 35, 1, 38, 5, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(984) },
                    { 39, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(986), (short)30, (short)100, 1, 1, 39, 82, 3, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(987) },
                    { 40, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(989), (short)30, (short)100, 50, 1, 40, 47, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(990) },
                    { 41, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(992), (short)30, (short)100, 79, 1, 41, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(993) },
                    { 42, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(995), (short)30, (short)100, 84, 1, 42, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(996) },
                    { 43, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1053), (short)30, (short)100, 8, 1, 43, 4, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1053) },
                    { 44, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1057), (short)30, (short)100, 29, 1, 44, 2, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1057) },
                    { 45, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1060), (short)30, (short)100, 54, 1, 45, 8, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1061) },
                    { 46, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1063), (short)30, (short)100, 24, 1, 46, 74, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1064) },
                    { 47, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1068), (short)30, (short)100, 62, 1, 47, 78, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1068) },
                    { 48, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1071), (short)30, (short)100, 62, 1, 48, 77, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1072) },
                    { 49, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1075), (short)30, (short)100, 40, 1, 49, 59, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1075) },
                    { 50, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1078), (short)30, (short)100, 71, 1, 50, 9, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1078) },
                    { 51, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1081), (short)30, (short)100, 71, 1, 51, 4, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1082) },
                    { 52, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1084), (short)30, (short)100, 49, 1, 52, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1085) },
                    { 53, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1087), (short)30, (short)100, 37, 1, 53, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1088) },
                    { 54, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1091), (short)30, (short)100, 37, 1, 54, 84, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1091) },
                    { 55, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1094), (short)30, (short)100, 7, 1, 55, 84, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1094) },
                    { 56, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1097), (short)30, (short)100, 69, 1, 56, 48, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1097) },
                    { 57, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1100), (short)30, (short)100, 59, 1, 57, 75, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1100) },
                    { 58, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1103), (short)30, (short)100, 44, 1, 58, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1104) },
                    { 59, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1106), (short)30, (short)100, 21, 1, 59, 84, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1107) },
                    { 60, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1109), (short)30, (short)100, 44, 1, 60, 61, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1110) },
                    { 61, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1112), (short)30, (short)100, 59, 1, 61, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1113) },
                    { 62, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1115), (short)30, (short)100, 72, 1, 62, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1116) },
                    { 63, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1119), (short)30, (short)100, 76, 1, 63, 84, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1119) },
                    { 64, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1122), (short)30, (short)100, 74, 1, 64, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1122) },
                    { 65, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1125), (short)30, (short)100, 47, 1, 65, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1125) },
                    { 66, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1128), (short)30, (short)100, 49, 1, 66, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1128) },
                    { 67, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1131), (short)30, (short)100, 33, 1, 67, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1131) },
                    { 68, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1134), (short)30, (short)100, 13, 1, 68, 2, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1135) },
                    { 69, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1137), (short)30, (short)100, 13, 1, 69, 6, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1138) },
                    { 70, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1141), (short)30, (short)100, 47, 1, 70, 3, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1141) },
                    { 71, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1144), (short)30, (short)100, 33, 1, 71, 2, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1144) },
                    { 72, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1147), (short)30, (short)100, 13, 1, 72, 7, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1147) },
                    { 73, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1150), (short)30, (short)100, 33, 1, 73, 9, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1150) },
                    { 74, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1153), (short)30, (short)100, 47, 1, 74, 2, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1153) },
                    { 75, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1156), (short)30, (short)100, 71, 1, 75, 61, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1156) },
                    { 76, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1160), (short)30, (short)100, 12, 1, 76, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1161) },
                    { 77, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1163), (short)30, (short)100, 4, 1, 77, 15, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1164) },
                    { 78, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1166), (short)30, (short)100, 42, 1, 78, 33, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1167) },
                    { 79, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1169), (short)30, (short)100, 67, 1, 79, 34, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1170) },
                    { 80, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1173), (short)30, (short)100, 22, 1, 80, 41, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1173) },
                    { 81, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1176), (short)30, (short)100, 22, 1, 81, 44, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1176) },
                    { 82, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1179), (short)30, (short)100, 65, 1, 82, 46, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1179) },
                    { 83, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1182), (short)30, (short)100, 14, 1, 83, 29, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1182) },
                    { 84, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1185), (short)30, (short)100, 55, 1, 84, 37, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1185) },
                    { 85, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1188), (short)30, (short)100, 63, 1, 85, 38, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1188) },
                    { 86, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1191), (short)30, (short)100, 25, 1, 86, 22, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1191) },
                    { 87, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1194), (short)30, (short)100, 17, 1, 87, 18, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1194) },
                    { 88, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1197), (short)30, (short)100, 43, 1, 88, 39, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1197) },
                    { 89, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1201), (short)30, (short)100, 17, 1, 89, 16, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1201) },
                    { 90, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1204), (short)30, (short)100, 81, 1, 90, 42, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1204) },
                    { 91, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1207), (short)30, (short)100, 63, 1, 91, 19, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1207) },
                    { 92, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1210), (short)30, (short)100, 17, 1, 92, 40, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1211) },
                    { 93, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1213), (short)30, (short)100, 17, 1, 93, 41, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1214) },
                    { 94, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1216), (short)30, (short)100, 81, 1, 94, 43, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1217) },
                    { 95, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1258), (short)30, (short)100, 81, 1, 95, 20, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1258) },
                    { 96, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1261), (short)30, (short)100, 56, 1, 96, 32, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1262) },
                    { 97, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1264), (short)30, (short)100, 6, 1, 97, 53, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1265) },
                    { 98, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1267), (short)30, (short)100, 64, 1, 98, 21, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1268) },
                    { 99, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1271), (short)30, (short)100, 82, 1, 99, 35, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1271) },
                    { 100, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1274), (short)30, (short)100, 56, 1, 100, 31, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1274) },
                    { 101, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1277), (short)30, (short)100, 3, 1, 101, 45, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1277) },
                    { 102, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1280), (short)30, (short)100, 75, 1, 102, 10, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1280) },
                    { 103, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1283), (short)30, (short)100, 18, 1, 103, 27, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1284) },
                    { 104, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1286), (short)30, (short)100, 48, 1, 104, 7, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1287) },
                    { 105, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1289), (short)30, (short)100, 48, 1, 105, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1290) },
                    { 106, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1293), (short)30, (short)100, 48, 1, 106, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1293) },
                    { 107, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1296), (short)30, (short)100, 5, 1, 107, 3, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1296) },
                    { 108, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1299), (short)30, (short)100, 5, 1, 108, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1299) },
                    { 109, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1302), (short)30, (short)100, 23, 1, 109, 3, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1302) },
                    { 110, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1305), (short)30, (short)100, 23, 1, 110, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1305) },
                    { 111, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1308), (short)30, (short)100, 83, 1, 111, 73, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1309) },
                    { 112, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1311), (short)30, (short)100, 83, 1, 112, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1312) },
                    { 113, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1314), (short)30, (short)100, 23, 1, 113, 73, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1315) },
                    { 114, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1317), (short)30, (short)100, 14, 1, 114, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1318) },
                    { 115, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1322), (short)30, (short)100, 13, 1, 115, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1322) },
                    { 116, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1325), (short)30, (short)100, 15, 1, 116, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1325) },
                    { 117, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1328), (short)30, (short)100, 66, 1, 117, 82, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1329) },
                    { 118, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1331), (short)30, (short)100, 13, 1, 118, 3, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1332) },
                    { 119, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1334), (short)30, (short)100, 14, 1, 119, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1335) },
                    { 120, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1337), (short)30, (short)100, 36, 1, 120, 11, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1338) },
                    { 121, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1340), (short)30, (short)100, 6, 1, 121, 80, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1341) },
                    { 122, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1343), (short)30, (short)100, 8, 1, 122, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1344) },
                    { 123, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1346), (short)30, (short)100, 77, 1, 123, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1347) },
                    { 124, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1349), (short)30, (short)100, 77, 1, 124, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1350) },
                    { 125, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1353), (short)30, (short)100, 77, 1, 125, 3, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1353) },
                    { 126, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1356), (short)30, (short)100, 30, 1, 126, 28, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1356) },
                    { 127, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1359), (short)30, (short)100, 60, 1, 127, 86, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1359) },
                    { 128, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1367), (short)30, (short)100, 9, 1, 128, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1367) },
                    { 129, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1370), (short)30, (short)100, 60, 1, 129, 9, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1370) },
                    { 130, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1374), (short)30, (short)100, 51, 1, 130, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1374) },
                    { 131, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1378), (short)30, (short)100, 51, 1, 131, 12, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1378) },
                    { 132, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1381), (short)30, (short)100, 76, 1, 132, 9, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1381) },
                    { 133, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1384), (short)30, (short)100, 9, 1, 133, 3, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1384) },
                    { 134, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1387), (short)30, (short)100, 60, 1, 134, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1388) },
                    { 135, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1390), (short)30, (short)100, 51, 1, 135, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1391) },
                    { 136, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1393), (short)30, (short)100, 27, 1, 136, 73, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1394) },
                    { 137, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1397), (short)30, (short)100, 45, 1, 137, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1397) },
                    { 138, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1400), (short)30, (short)100, 27, 1, 138, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1400) },
                    { 139, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1403), (short)30, (short)100, 27, 1, 139, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1403) },
                    { 140, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1406), (short)30, (short)100, 62, 1, 140, 8, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1406) },
                    { 141, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1410), (short)30, (short)100, 80, 1, 141, 85, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1410) },
                    { 142, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1413), (short)30, (short)100, 52, 1, 142, 12, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1414) },
                    { 143, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1416), (short)30, (short)100, 39, 1, 143, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1417) },
                    { 144, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1419), (short)30, (short)100, 80, 1, 144, 82, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1420) },
                    { 145, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1422), (short)30, (short)100, 57, 1, 145, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1423) },
                    { 146, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1482), (short)30, (short)100, 39, 1, 146, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1483) },
                    { 147, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1486), (short)30, (short)100, 39, 1, 147, 10, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1486) },
                    { 148, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1489), (short)30, (short)100, 11, 1, 148, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1490) },
                    { 149, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1492), (short)30, (short)100, 9, 1, 149, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1493) },
                    { 150, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1496), (short)30, (short)100, 43, 1, 150, 49, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1496) },
                    { 151, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1499), (short)30, (short)100, 68, 1, 151, 52, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1499) },
                    { 152, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1502), (short)30, (short)100, 68, 1, 152, 56, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1503) },
                    { 153, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1505), (short)30, (short)100, 64, 1, 153, 80, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1506) },
                    { 154, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1509), (short)30, (short)100, 62, 1, 154, 72, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1509) },
                    { 155, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1512), (short)30, (short)100, 17, 1, 155, 10, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1512) },
                    { 156, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1515), (short)30, (short)100, 32, 1, 156, 60, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1516) },
                    { 157, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1519), (short)30, (short)100, 32, 1, 157, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1519) },
                    { 158, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1522), (short)30, (short)100, 32, 1, 158, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1522) },
                    { 159, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1525), (short)30, (short)100, 48, 1, 159, 9, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1525) },
                    { 160, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1528), (short)30, (short)100, 8, 1, 160, 3, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1528) },
                    { 161, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1531), (short)30, (short)100, 11, 1, 161, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1531) },
                    { 162, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1534), (short)30, (short)100, 40, 1, 162, 54, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1535) },
                    { 163, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1537), (short)30, (short)100, 8, 1, 163, 1, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1538) },
                    { 164, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1540), (short)30, (short)100, 8, 1, 164, 2, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1541) },
                    { 165, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1543), (short)30, (short)100, 65, 1, 165, 2, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1544) },
                    { 166, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1546), (short)30, (short)100, 18, 1, 166, 76, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1547) },
                    { 167, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1549), (short)30, (short)100, 60, 1, 167, 10, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1550) },
                    { 168, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1552), (short)30, (short)100, 39, 1, 168, 13, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1553) },
                    { 169, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1556), (short)30, (short)100, 80, 1, 169, 12, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1556) },
                    { 170, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1559), (short)30, (short)100, 76, 1, 170, 12, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1559) },
                    { 171, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1562), (short)30, (short)100, 48, 1, 171, 84, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1562) },
                    { 172, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1565), (short)30, (short)100, 9, 1, 172, 2, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1565) },
                    { 173, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1568), (short)30, (short)100, 9, 1, 173, 58, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1568) },
                    { 174, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1571), (short)30, (short)100, 64, 1, 174, 36, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1571) },
                    { 175, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1574), (short)30, (short)100, 64, 1, 175, 3, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1574) },
                    { 176, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1580), (short)30, (short)100, 60, 1, 176, 79, 1, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(1580) }
                });

            migrationBuilder.InsertData(
                table: "materia_plan_estudio",
                columns: new[] { "id", "created_at", "materia_id", "nivel_id", "plan_estudio_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2742), 1, 1, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2742) },
                    { 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2746), 2, 1, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2747) },
                    { 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2749), 3, 1, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2749) },
                    { 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2751), 4, 1, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2752) },
                    { 5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2753), 5, 1, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2754) },
                    { 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2756), 6, 2, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2756) },
                    { 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2758), 7, 2, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2758) },
                    { 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2760), 8, 2, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2760) },
                    { 9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2762), 9, 2, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2762) },
                    { 10, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2764), 10, 2, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2764) },
                    { 11, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2766), 11, 3, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2767) },
                    { 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2768), 12, 3, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2769) },
                    { 13, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2770), 13, 3, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2771) },
                    { 14, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2773), 14, 3, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2773) },
                    { 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2775), 15, 3, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2775) },
                    { 16, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2802), 16, 4, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2803) },
                    { 17, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2805), 17, 4, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2806) },
                    { 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2807), 18, 4, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2808) },
                    { 19, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2810), 19, 4, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2810) },
                    { 20, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2812), 20, 4, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2812) },
                    { 21, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2814), 21, 5, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2814) },
                    { 22, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2816), 22, 5, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2816) },
                    { 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2818), 23, 5, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2819) },
                    { 24, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2820), 24, 5, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2821) },
                    { 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2822), 25, 5, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2823) },
                    { 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2824), 26, 6, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2825) },
                    { 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2827), 27, 6, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2827) },
                    { 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2829), 28, 6, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2829) },
                    { 29, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2831), 29, 6, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2831) },
                    { 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2833), 30, 6, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2833) },
                    { 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2835), 31, 7, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2835) },
                    { 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2837), 32, 7, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2837) },
                    { 33, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2839), 33, 7, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2839) },
                    { 34, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2841), 34, 7, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2841) },
                    { 35, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2843), 38, 7, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2844) },
                    { 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2845), 36, 8, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2846) },
                    { 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2847), 37, 8, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2848) },
                    { 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2849), 44, 8, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2850) },
                    { 39, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2851), 39, 8, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2852) },
                    { 40, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2854), 35, 8, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2854) },
                    { 41, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2856), 41, 9, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2856) },
                    { 42, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2860), 42, 9, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2860) },
                    { 43, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2862), 43, 9, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2862) },
                    { 44, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2858), 40, 9, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2858) },
                    { 45, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2864), 100, 10, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2864) },
                    { 46, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2866), 1, 1, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2866) },
                    { 47, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2868), 2, 1, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2868) },
                    { 48, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2870), 3, 1, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2871) },
                    { 49, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2872), 4, 1, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2873) },
                    { 50, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2874), 5, 1, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2875) },
                    { 51, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2876), 6, 2, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2877) },
                    { 52, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2878), 7, 2, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2879) },
                    { 53, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2880), 8, 2, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2881) },
                    { 54, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2882), 9, 2, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2883) },
                    { 55, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2885), 10, 2, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2885) },
                    { 56, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2887), 11, 3, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2887) },
                    { 57, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2889), 12, 3, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2889) },
                    { 58, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2891), 13, 3, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2891) },
                    { 59, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2893), 14, 3, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2893) },
                    { 60, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2895), 15, 3, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2895) },
                    { 61, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2897), 16, 4, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2897) },
                    { 62, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2899), 17, 4, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2899) },
                    { 63, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2901), 18, 4, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2901) },
                    { 64, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2903), 19, 4, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2903) },
                    { 65, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2956), 20, 4, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2957) },
                    { 66, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2959), 21, 5, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2960) },
                    { 68, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2962), 23, 5, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2962) },
                    { 69, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2964), 24, 5, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2964) },
                    { 71, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2966), 53, 5, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2966) },
                    { 72, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2968), 54, 5, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2969) },
                    { 73, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2970), 26, 6, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2971) },
                    { 74, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2972), 27, 6, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2973) },
                    { 75, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2974), 28, 6, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2975) },
                    { 76, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2977), 29, 6, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2977) },
                    { 78, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2979), 55, 6, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2979) },
                    { 79, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2981), 31, 7, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2981) },
                    { 81, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2983), 33, 7, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2983) },
                    { 82, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2985), 34, 7, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2985) },
                    { 83, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2987), 38, 7, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2988) },
                    { 84, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2991), 56, 7, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2991) },
                    { 85, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2993), 36, 8, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2994) },
                    { 87, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2995), 35, 8, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2996) },
                    { 88, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2997), 39, 8, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2998) },
                    { 89, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(2999), 44, 8, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3000) },
                    { 90, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3001), 57, 8, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3002) },
                    { 91, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3003), 41, 9, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3004) },
                    { 92, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3005), 42, 9, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3006) },
                    { 93, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3008), 43, 9, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3008) },
                    { 94, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3010), 40, 9, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3010) },
                    { 95, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3012), 100, 10, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3012) },
                    { 96, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3014), 1, 1, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3014) },
                    { 97, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3016), 2, 1, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3016) },
                    { 98, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3018), 3, 1, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3019) },
                    { 99, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3020), 4, 1, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3021) },
                    { 100, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3022), 5, 1, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3023) },
                    { 101, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3024), 6, 2, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3025) },
                    { 102, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3026), 7, 2, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3027) },
                    { 103, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3029), 8, 2, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3029) },
                    { 104, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3031), 9, 2, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3031) },
                    { 105, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3033), 10, 2, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3033) },
                    { 106, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3035), 11, 3, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3035) },
                    { 107, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3037), 12, 3, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3037) },
                    { 108, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3039), 13, 3, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3039) },
                    { 109, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3041), 75, 3, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3041) },
                    { 110, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3043), 76, 3, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3043) },
                    { 111, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3046), 16, 4, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3047) },
                    { 112, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3048), 17, 4, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3049) },
                    { 113, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3050), 18, 4, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3051) },
                    { 114, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3053), 19, 4, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3053) },
                    { 115, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3055), 77, 4, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3055) },
                    { 116, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3057), 21, 5, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3057) },
                    { 117, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3059), 24, 5, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3059) },
                    { 118, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3061), 78, 5, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3061) },
                    { 119, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3063), 79, 5, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3063) },
                    { 120, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3065), 80, 5, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3065) },
                    { 121, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3067), 81, 5, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3067) },
                    { 122, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3125), 82, 5, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3126) },
                    { 123, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3128), 28, 6, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3128) },
                    { 124, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3130), 29, 6, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3130) },
                    { 125, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3132), 26, 6, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3133) },
                    { 126, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3134), 83, 6, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3135) },
                    { 127, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3137), 84, 6, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3137) },
                    { 128, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3139), 85, 6, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3139) },
                    { 129, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3141), 86, 6, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3141) },
                    { 130, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3143), 99, 6, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3143) },
                    { 131, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3145), 34, 7, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3145) },
                    { 132, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3147), 33, 7, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3148) },
                    { 133, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3149), 31, 7, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3150) },
                    { 134, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3151), 87, 7, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3152) },
                    { 135, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3153), 88, 7, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3154) },
                    { 136, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3156), 89, 7, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3156) },
                    { 137, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3158), 90, 7, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3158) },
                    { 138, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3160), 39, 8, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3160) },
                    { 139, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3162), 36, 8, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3162) },
                    { 140, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3164), 91, 8, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3164) },
                    { 141, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3166), 92, 8, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3166) },
                    { 142, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3168), 93, 8, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3168) },
                    { 143, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3170), 94, 8, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3170) },
                    { 144, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3172), 95, 8, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3173) },
                    { 145, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3174), 41, 9, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3175) },
                    { 146, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3176), 42, 9, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3177) },
                    { 147, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3178), 96, 9, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3179) },
                    { 148, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3180), 97, 9, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3181) },
                    { 149, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3182), 98, 9, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3183) },
                    { 150, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3185), 100, 10, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(3185) }
                });

            migrationBuilder.InsertData(
                table: "prerequisito",
                columns: new[] { "materia_plan_estudio_id", "requisito_id", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4513), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4513) },
                    { 7, 2, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4515), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4516) },
                    { 8, 3, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4517), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4518) },
                    { 9, 4, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4519), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4519) },
                    { 10, 5, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4520), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4521) },
                    { 11, 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4522), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4522) },
                    { 12, 7, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4523), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4524) },
                    { 12, 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4525), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4525) },
                    { 13, 8, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4526), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4527) },
                    { 13, 9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4528), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4528) },
                    { 14, 9, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4529), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4530) },
                    { 16, 6, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4581), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4582) },
                    { 17, 11, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4583), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4583) },
                    { 18, 12, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4584), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4585) },
                    { 19, 13, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4586), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4586) },
                    { 20, 15, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4587), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4588) },
                    { 21, 16, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4589), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4589) },
                    { 22, 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4590), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4591) },
                    { 23, 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4592), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4592) },
                    { 24, 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4593), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4594) },
                    { 25, 18, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4595), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4595) },
                    { 26, 21, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4596), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4597) },
                    { 27, 24, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4598), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4598) },
                    { 28, 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4599), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4600) },
                    { 29, 24, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4601), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4601) },
                    { 30, 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4604), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4604) },
                    { 30, 25, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4602), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4602) },
                    { 31, 26, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4605), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4605) },
                    { 32, 23, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4609), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4609) },
                    { 32, 30, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4607), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4608) },
                    { 33, 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4610), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4611) },
                    { 34, 28, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4612), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4612) },
                    { 35, 27, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4613), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4614) },
                    { 35, 29, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4615), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4615) },
                    { 36, 31, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4616), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4617) },
                    { 37, 32, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4618), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4618) },
                    { 37, 35, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4619), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4619) },
                    { 38, 35, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4620), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4621) },
                    { 39, 34, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4622), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4622) },
                    { 40, 35, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4623), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4624) },
                    { 41, 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4625), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4625) },
                    { 41, 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4626), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4627) },
                    { 41, 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4629), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4630) },
                    { 41, 39, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4631), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4631) },
                    { 41, 40, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4632), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4633) },
                    { 42, 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4641), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4641) },
                    { 42, 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4642), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4643) },
                    { 42, 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4644), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4644) },
                    { 42, 39, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4645), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4646) },
                    { 42, 40, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4647), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4647) },
                    { 43, 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4648), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4649) },
                    { 43, 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4650), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4650) },
                    { 43, 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4651), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4651) },
                    { 43, 39, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4653), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4653) },
                    { 43, 40, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4654), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4654) },
                    { 44, 36, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4634), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4634) },
                    { 44, 37, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4635), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4636) },
                    { 44, 38, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4637), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4637) },
                    { 44, 39, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4638), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4638) },
                    { 44, 40, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4639), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4640) },
                    { 45, 41, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4655), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4656) },
                    { 45, 42, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4658), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4659) },
                    { 45, 43, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4660), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4660) },
                    { 45, 44, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4657), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4657) },
                    { 51, 46, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4665), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4666) },
                    { 52, 47, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4667), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4667) },
                    { 53, 48, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4663), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4663) },
                    { 54, 49, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4661), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4662) },
                    { 55, 50, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4664), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4664) },
                    { 56, 51, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4674), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4674) },
                    { 57, 52, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4670), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4670) },
                    { 57, 53, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4668), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4669) },
                    { 58, 53, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4671), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4671) },
                    { 58, 54, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4672), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4673) },
                    { 59, 54, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4675), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4676) },
                    { 61, 51, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4681), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4681) },
                    { 62, 56, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4684), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4684) },
                    { 63, 57, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4678), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4679) },
                    { 64, 58, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4680), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4680) },
                    { 65, 60, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4677), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4677) },
                    { 66, 61, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4691), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4691) },
                    { 68, 63, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4688), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4689) },
                    { 69, 63, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4690), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4690) },
                    { 71, 65, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4685), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4686) },
                    { 72, 65, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4687), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4687) },
                    { 73, 66, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4698), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4699) },
                    { 74, 69, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4697), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4697) },
                    { 75, 68, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4695), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4696) },
                    { 76, 69, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4694), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4694) },
                    { 78, 71, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4692), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4693) },
                    { 79, 73, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4704), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4704) },
                    { 81, 75, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4700), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4700) },
                    { 82, 75, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4705), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4706) },
                    { 83, 74, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4707), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4707) },
                    { 83, 76, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4708), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4709) },
                    { 84, 74, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4701), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4701) },
                    { 84, 76, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4702), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4703) },
                    { 85, 79, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4710), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4710) },
                    { 87, 83, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4711), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4712) },
                    { 88, 82, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4713), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4713) },
                    { 89, 83, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4714), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4714) },
                    { 90, 78, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4715), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4716) },
                    { 90, 83, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4717), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4717) },
                    { 92, 85, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4724), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4725) },
                    { 92, 90, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4723), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4723) },
                    { 94, 87, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4721), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4722) },
                    { 94, 88, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4720), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4720) },
                    { 94, 89, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4718), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4719) },
                    { 95, 91, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4726), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4726) },
                    { 95, 92, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4728), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4729) },
                    { 95, 93, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4730), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4730) },
                    { 95, 94, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4727), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4727) },
                    { 101, 96, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4731), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4732) },
                    { 102, 97, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4733), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4733) },
                    { 103, 98, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4734), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4735) },
                    { 104, 99, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4737), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4737) },
                    { 105, 100, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4738), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4739) },
                    { 106, 101, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4740), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4740) },
                    { 107, 102, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4741), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4742) },
                    { 107, 103, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4743), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4743) },
                    { 108, 103, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4744), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4745) },
                    { 108, 104, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4746), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4746) },
                    { 109, 104, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4747), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4748) },
                    { 110, 104, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4749), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4749) },
                    { 111, 101, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4752), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4752) },
                    { 112, 106, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4750), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4751) },
                    { 113, 96, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4755), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4755) },
                    { 113, 107, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4753), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4753) },
                    { 114, 108, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4756), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4756) },
                    { 115, 109, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4757), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4758) },
                    { 116, 111, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4759), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4759) },
                    { 117, 113, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4760), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4761) },
                    { 118, 115, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4762), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4762) },
                    { 119, 115, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4763), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4764) },
                    { 120, 106, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4766), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4767) },
                    { 120, 110, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4765), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4765) },
                    { 123, 116, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4768), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4768) },
                    { 124, 117, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4769), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4770) },
                    { 125, 121, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4771), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4771) },
                    { 126, 119, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4813), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4813) },
                    { 127, 112, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4816), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4816) },
                    { 127, 120, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4814), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4815) },
                    { 131, 120, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4821), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4822) },
                    { 131, 123, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4820), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4820) },
                    { 132, 123, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4819), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4819) },
                    { 133, 125, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4817), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4818) },
                    { 134, 114, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4825), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4826) },
                    { 134, 126, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4823), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4823) },
                    { 135, 120, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4828), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4829) },
                    { 135, 127, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4827), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4827) },
                    { 138, 131, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4833), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4833) },
                    { 139, 133, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4830), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4830) },
                    { 140, 131, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4831), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4832) },
                    { 141, 131, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4834), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4834) },
                    { 141, 135, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4836), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4836) },
                    { 142, 135, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4837), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4837) },
                    { 145, 138, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4841), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4842) },
                    { 145, 139, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4838), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4839) },
                    { 145, 140, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4840), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4840) },
                    { 145, 141, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4843), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4843) },
                    { 145, 142, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4844), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4845) },
                    { 146, 138, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4849), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4849) },
                    { 146, 139, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4846), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4846) },
                    { 146, 140, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4847), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4848) },
                    { 146, 141, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4850), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4850) },
                    { 146, 142, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4851), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4852) },
                    { 147, 138, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4856), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4856) },
                    { 147, 139, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4853), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4853) },
                    { 147, 140, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4854), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4855) },
                    { 147, 141, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4857), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4858) },
                    { 147, 142, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4859), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4859) },
                    { 148, 138, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4863), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4863) },
                    { 148, 139, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4860), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4861) },
                    { 148, 140, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4862), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4862) },
                    { 148, 141, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4864), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4865) },
                    { 148, 142, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4866), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4866) },
                    { 149, 138, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4870), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4871) },
                    { 149, 139, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4867), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4868) },
                    { 149, 140, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4869), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4869) },
                    { 149, 141, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4872), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4872) },
                    { 149, 142, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4873), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4874) },
                    { 150, 145, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4875), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4875) },
                    { 150, 146, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4878), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4878) },
                    { 150, 147, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4876), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4877) },
                    { 150, 148, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4879), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4879) },
                    { 150, 149, new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4880), new DateTime(2025, 10, 7, 12, 54, 21, 783, DateTimeKind.Utc).AddTicks(4881) }
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
                name: "ix_job_results_idemkey",
                table: "job_results",
                column: "idempotency_key");

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
                name: "job_results");

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
