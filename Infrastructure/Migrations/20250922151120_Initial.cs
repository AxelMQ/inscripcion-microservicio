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
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(5836), "Matias", 0m, 1000000, 7000000, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(5838) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(5842), "Axel", 0m, 1000001, 7000001, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(5843) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(5844), "Franco", 0m, 1000002, 7000002, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(5845) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(5846), "Luis", 0m, 1000003, 7000003, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(5846) }
                });

            migrationBuilder.InsertData(
                table: "carrera",
                columns: new[] { "id", "codigo", "created_at", "modalidad", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, "185", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6266), (short)0, "INGENIERIA EN REDES Y TELECOMUNICACIONES", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6266) },
                    { 2, "183", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6269), (short)0, "INGENIERIA INFORMATICA", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6269) },
                    { 3, "184", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6271), (short)0, "INGENIERIA EN SISTEMAS", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6271) },
                    { 4, "323", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6272), (short)0, "INGENIERIA ROBOTICA", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6272) }
                });

            migrationBuilder.InsertData(
                table: "dia",
                columns: new[] { "id", "created_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6420), "LUNES", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6420) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6422), "MARTES", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6422) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6423), "MIERCOLES", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6423) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6424), "JUEVES", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6424) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6425), "VIERNES", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6425) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6426), "SABADO", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6427) }
                });

            migrationBuilder.InsertData(
                table: "docente",
                columns: new[] { "id", "ci", "created_at", "nombre", "telefono", "updated_at" },
                values: new object[,]
                {
                    { 1, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6580), "ABARCA SOTA NANCY", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6581) },
                    { 2, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6586), "ACOSTA CABEZAS BARTOLO JAVIER", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6587) },
                    { 3, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6588), "AGUILAR MARTINEZ DOMINGO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6588) },
                    { 4, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6589), "ARANIBAR QUIROZ M. MONICA", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6590) },
                    { 5, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6591), "ALPIRE RIVERO GERMAN", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6591) },
                    { 6, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6593), "ARGOTE CLAROS IRMA ISABEL", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6593) },
                    { 7, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6594), "AVENDAÑO GONZALES EUDAL", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6594) },
                    { 8, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6595), "BARROSO VIRUEZ GINO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6596) },
                    { 9, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6597), "BALCAZAR VEIZAGA EVANS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6597) },
                    { 10, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6598), "CALISAYA AJHUACHO MAGNO EDWIN", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6598) },
                    { 11, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6600), "CABALLERO RUA MAURICIO CHRISTIAN", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6600) },
                    { 12, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6601), "CABELLO MERIDA JUAN RUBEN", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6601) },
                    { 13, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6603), "CACERES CHACON BRAULIO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6603) },
                    { 14, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6604), "CANO CESPEDES JORGE", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6604) },
                    { 15, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6605), "CASTRO MARISCAL JHONNY", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6606) },
                    { 16, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6607), "CALIZAYA AJHUACHO MAGNO EDWIN", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6607) },
                    { 17, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6608), "CALDERON FLORES MODESTO FRANKLIN", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6609) },
                    { 18, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6610), "CALLE TERRAZAS EDWIN", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6610) },
                    { 19, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6612), "CARVAJAL CORDERO MARCIO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6612) },
                    { 20, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6613), "CARRENO PEREIRA ANDRES", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6613) },
                    { 21, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6614), "CAMPOS BARRERA MARIO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6615) },
                    { 22, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6616), "CAYOJA LUCANA VICTOR MILTON", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6616) },
                    { 23, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6617), "CLAURE MEDRANO DE OROPEZA ELIZ", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6617) },
                    { 24, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6619), "CHANIN AVICHACRA JUAN MANUEL", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6619) },
                    { 25, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6620), "CHAU WONG JORGE", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6620) },
                    { 26, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6621), "CORTEZ UZEDA JULIO MARTIN", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6622) },
                    { 27, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6623), "CONTRERAS VILLEGAS JUAN CARLOS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6623) },
                    { 28, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6624), "DURAN CESPEDES BERTHY RONALD", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6625) },
                    { 29, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6626), "FLORES FLORES MARCOS OSCAR", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6626) },
                    { 30, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6627), "FLORES GUZMAN VALENTIN VICTOR", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6627) },
                    { 31, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6628), "FLORES CUELLAD DAVID LUIS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6629) },
                    { 32, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6630), "GARZON CUELLAR ANGELICA", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6630) },
                    { 33, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6631), "GUTIERREZ BRUNO KATIME ESTHER", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6631) },
                    { 34, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6633), "GIANELLA PEREDO EDUARDO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6633) },
                    { 35, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6634), "GUARACHI SOLANO JONATHAN FELIX", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6634) },
                    { 36, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6635), "GUTHRIE PACHECO JHONNY DAVID", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6636) },
                    { 37, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6637), "GRAGEDA ESCUDERO MARIO WILSON", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6637) },
                    { 38, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6638), "GRIMALDO BRAVO PAUL", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6638) },
                    { 39, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6640), "GONZALES SANDOVAL JORGE ANTONIO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6640) },
                    { 40, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6641), "HINOJOSA SAAVEDRA JOSE SAID", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6641) },
                    { 41, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6642), "JUSTINIANO ROCA RONALD", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6643) },
                    { 42, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6730), "LAMAS RODRIGUEZ MARCOS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6730) },
                    { 43, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6732), "LAZO ARTEAGA CARLOS ALBERTO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6732) },
                    { 44, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6734), "LOPEZ WINNIPEG MARIO MILTON", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6734) },
                    { 45, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6735), "LOPEZ NEGRETTY MARY DUNNIA", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6735) },
                    { 46, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6736), "LOBO LIMPIAS VICTOR HUGO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6736) },
                    { 47, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6738), "MARTINEZ CARDONA SARAH MIRNA", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6738) },
                    { 48, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6739), "MARTINEZ CANEDO ROLANDO ANTONI", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6739) },
                    { 49, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6740), "MIRANDA CARRASCO CARLOS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6741) },
                    { 50, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6742), "MORALES MENDEZ MAGALY", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6742) },
                    { 51, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6743), "MOLLO MAMANI ALBERTO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6743) },
                    { 52, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6745), "MONRROY DIPP VICTOR FERNANDO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6745) },
                    { 53, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6746), "OROPEZA CLAURE GUSTAVO ADOLFO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6746) },
                    { 54, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6747), "OROSCO GOMEZ RUBEN", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6747) },
                    { 55, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6749), "ORTIZ ARTEAGA VICTOR HUGO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6749) },
                    { 56, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6750), "OQUENDO HEREDIA FREDDY MIGUEL", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6750) },
                    { 57, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6751), "PAZ MENDOZA ROBERTO CARLOS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6752) },
                    { 58, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6753), "PINTO VARGAS EDUARDO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6753) },
                    { 59, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6754), "PEINADO PEREIRA JUAN CARLOS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6754) },
                    { 60, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6756), "PEINADO PEREIRA MIGUEL JESUS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6756) },
                    { 61, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6758), "PEREZ FERREIRA UBALDO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6758) },
                    { 62, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6759), "PEREZ DELGADILLO SHIRLEY EULAL", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6759) },
                    { 63, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6761), "ROMAN ROCA RUFINO WILBERTO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6761) },
                    { 64, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6762), "ROSALES FUENTES JORGE MARCELO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6762) },
                    { 65, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6763), "SANCHEZ VELASCO ENRIQUE", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6764) },
                    { 66, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6765), "SANCHEZ RIOJA EDWIN ALEJANDRO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6765) },
                    { 67, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6766), "SALVATIERRA MERCADO ROLANDO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6766) },
                    { 68, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6768), "SELAYA GARVIZU IVAN VLADISHLAV", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6768) },
                    { 69, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6769), "SILES MUÑOZ FELIX", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6769) },
                    { 70, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6770), "TEJERINA GUERRA JULIO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6771) },
                    { 71, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6772), "TERRAZAS SOTO RICARDO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6772) },
                    { 72, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6773), "VACA PINTO CESPEDES ROBERTO CARLOS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6774) },
                    { 73, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6775), "VALDELOMAR ORELLANA TOMAS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6775) },
                    { 74, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6776), "VARGAS CASTILLO CIRO EDGAR", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6776) },
                    { 75, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6778), "VARGAS PEÑA LEONARDO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6778) },
                    { 76, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6779), "VARGAS YAPURA EDWIN", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6779) },
                    { 77, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6780), "VALLET VALLET CORRADO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6780) },
                    { 78, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6782), "VEIZAGA GONZALES JOSUE OBED", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6782) },
                    { 79, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6783), "VELASCO GUAMAN ANGEL", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6783) },
                    { 80, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6785), "VILLAGOMEZ MELGAR JOSE JUNIOR", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6785) },
                    { 81, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6786), "ZEBALLOS PAREDES DANIEL LUIS", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6786) },
                    { 82, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6787), "ZUNA VILLAGOMEZ JULIO", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6788) },
                    { 83, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6789), "ZUÑIGA RUIZ WILMA", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6789) },
                    { 84, 15157507, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6790), "POR DESIGNAR", 78481534L, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(6790) }
                });

            migrationBuilder.InsertData(
                table: "gestion",
                columns: new[] { "id", "created_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7028), "1/2025", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7029) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7031), "2/2025", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7031) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7032), "3/2025", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7032) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7033), "4/2025", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7034) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7035), "1/2024", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7035) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7036), "2/2024", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7036) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7037), "3/2024", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7037) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7097), "4/2024", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7098) }
                });

            migrationBuilder.InsertData(
                table: "grupo",
                columns: new[] { "id", "created_at", "nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7879), "SA", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7879) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7881), "SB", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7882) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7883), "SC", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7883) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7884), "SD", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7884) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7885), "SE", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7885) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7886), "SF", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7886) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7887), "SG", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7887) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7888), "SH", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7888) },
                    { 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7889), "SI", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7890) },
                    { 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7890), "SK", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7891) },
                    { 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7892), "SN", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7892) },
                    { 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7893), "SM", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7893) },
                    { 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7894), "SP", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7894) },
                    { 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7895), "SR", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7895) },
                    { 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7896), "SS", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7896) },
                    { 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7897), "SX", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7897) },
                    { 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7898), "SZ", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7898) },
                    { 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7899), "F1", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7900) },
                    { 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7900), "BI", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7901) },
                    { 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7902), "CI", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7902) },
                    { 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7903), "C1", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7903) },
                    { 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7904), "I2", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7904) },
                    { 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7905), "ER", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7905) },
                    { 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7906), "R1", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7906) },
                    { 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7907), "1I", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7907) },
                    { 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7908), "I1", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7909) },
                    { 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7910), "NW", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7910) },
                    { 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7911), "NX", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7911) },
                    { 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7912), "W1", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7912) },
                    { 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7913), "X2", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7913) },
                    { 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7914), "X3", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7915) },
                    { 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7916), "X4", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7916) },
                    { 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7917), "Z1", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7917) },
                    { 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7918), "Z2", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7918) },
                    { 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7919), "Z3", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7919) },
                    { 36, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7920), "Z4", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7921) },
                    { 37, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7922), "Z5", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7922) },
                    { 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7923), "Z6", new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7923) }
                });

            migrationBuilder.InsertData(
                table: "hora",
                columns: new[] { "id", "created_at", "hr_fin", "hr_inicio", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(438), new TimeOnly(8, 30, 0), new TimeOnly(7, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(439) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(443), new TimeOnly(10, 0, 0), new TimeOnly(8, 30, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(443) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(444), new TimeOnly(11, 30, 0), new TimeOnly(10, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(445) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(446), new TimeOnly(13, 0, 0), new TimeOnly(11, 30, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(446) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(475), new TimeOnly(14, 30, 0), new TimeOnly(13, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(475) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(476), new TimeOnly(16, 0, 0), new TimeOnly(14, 30, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(476) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(478), new TimeOnly(9, 15, 0), new TimeOnly(7, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(478) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(479), new TimeOnly(11, 30, 0), new TimeOnly(9, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(479) },
                    { 9, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(480), new TimeOnly(13, 0, 0), new TimeOnly(11, 30, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(481) },
                    { 10, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(482), new TimeOnly(18, 15, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(482) },
                    { 11, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(483), new TimeOnly(20, 30, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(483) },
                    { 12, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(484), new TimeOnly(22, 45, 0), new TimeOnly(20, 30, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(485) },
                    { 13, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(486), new TimeOnly(12, 15, 0), new TimeOnly(10, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(486) },
                    { 14, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(487), new TimeOnly(13, 45, 0), new TimeOnly(11, 30, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(487) },
                    { 15, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(488), new TimeOnly(16, 0, 0), new TimeOnly(13, 45, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(489) },
                    { 16, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(490), new TimeOnly(16, 45, 0), new TimeOnly(15, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(490) },
                    { 17, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(491), new TimeOnly(17, 30, 0), new TimeOnly(15, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(491) },
                    { 18, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(492), new TimeOnly(19, 0, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(493) },
                    { 19, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(494), new TimeOnly(21, 15, 0), new TimeOnly(19, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(494) },
                    { 20, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(495), new TimeOnly(20, 30, 0), new TimeOnly(19, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(495) },
                    { 21, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(496), new TimeOnly(22, 0, 0), new TimeOnly(19, 45, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(497) },
                    { 22, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(498), new TimeOnly(13, 0, 0), new TimeOnly(10, 45, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(498) },
                    { 23, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(499), new TimeOnly(15, 15, 0), new TimeOnly(13, 45, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(499) },
                    { 24, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(500), new TimeOnly(15, 15, 0), new TimeOnly(13, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(501) },
                    { 25, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(502), new TimeOnly(16, 45, 0), new TimeOnly(15, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(502) },
                    { 26, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(503), new TimeOnly(17, 30, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(503) },
                    { 27, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(504), new TimeOnly(18, 15, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(505) },
                    { 28, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(506), new TimeOnly(19, 45, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(506) },
                    { 29, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(507), new TimeOnly(21, 15, 0), new TimeOnly(19, 45, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(507) },
                    { 30, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(509), new TimeOnly(22, 45, 0), new TimeOnly(21, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(509) },
                    { 31, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(510), new TimeOnly(22, 0, 0), new TimeOnly(20, 30, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(510) },
                    { 32, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(511), new TimeOnly(13, 45, 0), new TimeOnly(12, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(512) },
                    { 33, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(513), new TimeOnly(19, 45, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(513) },
                    { 34, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(514), new TimeOnly(10, 45, 0), new TimeOnly(9, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(514) },
                    { 35, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(515), new TimeOnly(11, 30, 0), new TimeOnly(8, 30, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(516) },
                    { 36, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(517), new TimeOnly(16, 0, 0), new TimeOnly(13, 0, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(517) },
                    { 37, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(518), new TimeOnly(12, 15, 0), new TimeOnly(9, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(518) },
                    { 38, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(520), new TimeOnly(21, 15, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(520) }
                });

            migrationBuilder.InsertData(
                table: "horario",
                columns: new[] { "id", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(76), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(77) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(78), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(78) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(79), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(80) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(81), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(81) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(82), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(82) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(83), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(83) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(84), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(84) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(85), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(85) },
                    { 9, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(86), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(86) },
                    { 10, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(87), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(87) },
                    { 11, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(88), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(88) },
                    { 12, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(89), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(90) },
                    { 13, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(91), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(91) },
                    { 14, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(92), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(92) },
                    { 15, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(93), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(93) },
                    { 16, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(94), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(94) },
                    { 17, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(95), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(95) },
                    { 18, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(96), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(96) },
                    { 19, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(97), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(97) },
                    { 20, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(98), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(98) },
                    { 21, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(99), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(99) },
                    { 22, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(100), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(101) },
                    { 23, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(101), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(102) },
                    { 24, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(102), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(103) },
                    { 25, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(103), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(104) },
                    { 26, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(105), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(105) },
                    { 27, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(106), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(106) },
                    { 28, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(107), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(107) },
                    { 29, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(108), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(108) },
                    { 30, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(109), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(109) },
                    { 31, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(110), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(110) },
                    { 32, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(111), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(111) },
                    { 33, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(112), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(112) },
                    { 34, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(113), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(113) },
                    { 35, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(114), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(115) },
                    { 36, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(115), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(116) },
                    { 37, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(117), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(117) },
                    { 38, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(118), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(118) },
                    { 39, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(119), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(119) },
                    { 40, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(120), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(120) },
                    { 41, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(123), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(123) },
                    { 42, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(124), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(124) },
                    { 43, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(125), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(125) },
                    { 44, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(126), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(126) },
                    { 45, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(127), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(127) },
                    { 46, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(128), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(128) },
                    { 47, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(129), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(129) },
                    { 48, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(171), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(172) },
                    { 49, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(173), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(173) },
                    { 50, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(174), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(174) },
                    { 51, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(175), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(175) },
                    { 52, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(176), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(176) },
                    { 53, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(177), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(177) },
                    { 54, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(178), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(178) },
                    { 55, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(180), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(180) },
                    { 56, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(181), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(181) },
                    { 57, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(182), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(182) },
                    { 58, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(183), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(183) },
                    { 59, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(184), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(184) },
                    { 60, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(185), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(185) },
                    { 61, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(186), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(186) },
                    { 62, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(187), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(187) },
                    { 63, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(188), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(188) },
                    { 64, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(189), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(190) },
                    { 65, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(190), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(191) },
                    { 66, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(192), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(192) },
                    { 67, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(193), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(193) },
                    { 68, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(194), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(194) },
                    { 69, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(195), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(195) },
                    { 70, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(196), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(196) },
                    { 71, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(197), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(197) },
                    { 72, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(198), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(198) },
                    { 73, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(199), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(200) },
                    { 74, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(200), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(201) },
                    { 75, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(202), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(202) },
                    { 76, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(203), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(203) },
                    { 77, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(204), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(204) },
                    { 78, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(205), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(205) },
                    { 79, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(206), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(207) },
                    { 80, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(208), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(208) },
                    { 81, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(209), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(209) },
                    { 82, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(210), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(210) },
                    { 83, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(211), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(211) },
                    { 84, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(212), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(212) },
                    { 85, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(213), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(213) },
                    { 86, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(214), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(214) },
                    { 87, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(216), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(216) }
                });

            migrationBuilder.InsertData(
                table: "materia",
                columns: new[] { "id", "created_at", "credito", "es_electiva", "nombre", "sigla", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1475), (short)5, false, "CÁLCULO I", "MAT101", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1476) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1479), (short)5, false, "ESTRUCTURAS DISCRETAS", "INF119", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1479) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1481), (short)5, false, "INTRODUCCIÓN A LA INFORMÁTICA", "INF110", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1481) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1482), (short)5, false, "FÍSICA I", "FIS100", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1483) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1484), (short)5, false, "INGLÉS TÉCNICO I", "LIN100", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1484) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1486), (short)5, false, "CÁLCULO II", "MAT102", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1486) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1487), (short)5, false, "ÁLGEBRA LINEAL", "MAT103", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1487) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1488), (short)5, false, "PROGRAMACIÓN I", "INF120", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1489) },
                    { 9, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1490), (short)5, false, "FÍSICA II", "FIS102", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1490) },
                    { 10, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1491), (short)5, false, "INGLÉS TÉCNICO II", "LIN101", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1492) },
                    { 11, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1493), (short)5, false, "ECUACIONES DIFERENCIALES", "MAT207", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1493) },
                    { 12, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1494), (short)5, false, "PROGRAMACIÓN II", "INF210", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1495) },
                    { 13, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1496), (short)5, false, "ARQUITECTURA DE COMPUTADORAS", "INF211", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1496) },
                    { 14, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1497), (short)6, false, "FÍSICA III", "FIS200", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1498) },
                    { 15, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1499), (short)4, false, "ADMINISTRACIÓN", "ADM100", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1499) },
                    { 16, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1500), (short)5, false, "PROBABILIDAD Y ESTADÍSTICA I", "MAT202", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1501) },
                    { 17, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1502), (short)5, false, "MÉTODOS NUMÉRICOS", "MAT205", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1502) },
                    { 18, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1503), (short)5, false, "ESTRUCTURA DE DATOS I", "INF220", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1504) },
                    { 19, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1505), (short)5, false, "PROGRAMACIÓN ENSAMBLADOR", "INF221", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1505) },
                    { 20, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1506), (short)4, false, "CONTABILIDAD", "ADM200", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1507) },
                    { 21, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1508), (short)5, false, "PROBABILIDAD Y ESTADÍSTICA II", "MAT302", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1508) },
                    { 22, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1509), (short)5, false, "PROGRAMACIÓN LÓGICA Y FUNCIONAL", "INF318", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1510) },
                    { 23, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1511), (short)5, false, "ESTRUCTURA DE DATOS II", "INF310", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1511) },
                    { 24, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1513), (short)5, false, "BASE DE DATOS I", "INF312", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1513) },
                    { 25, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1514), (short)5, false, "LENGUAJES FORMALES", "INF319", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1514) },
                    { 26, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1519), (short)5, false, "INVESTIGACIÓN OPERATIVA I", "MAT329", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1519) },
                    { 27, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1520), (short)5, false, "SISTEMAS DE INFORMACIÓN I", "INF342", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1521) },
                    { 28, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1522), (short)5, false, "SISTEMAS OPERATIVOS I", "INF323", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1522) },
                    { 29, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1523), (short)5, false, "BASE DE DATOS II", "INF322", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1523) },
                    { 30, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1525), (short)5, false, "COMPILADORES", "INF329", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1525) },
                    { 31, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1528), (short)5, false, "INVESTIGACIÓN OPERATIVA II", "MAT419", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1528) },
                    { 32, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1529), (short)5, false, "INTELIGENCIA ARTIFICIAL", "INF418", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1529) },
                    { 33, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1531), (short)5, false, "SISTEMAS OPERATIVOS II", "INF413", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1531) },
                    { 34, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1533), (short)5, false, "REDES I", "INF433", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1533) },
                    { 35, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1534), (short)5, false, "INGENIERÍA DE SOFTWARE I", "INF422", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1534) },
                    { 36, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1537), (short)5, false, "PREPARACIÓN Y EVALUACIÓN DE PROYECTOS", "ECO449", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1537) },
                    { 37, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1539), (short)5, false, "SISTEMAS EXPERTOS", "INF428", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1539) },
                    { 38, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1580), (short)5, false, "SISTEMAS DE INFORMACIÓN II", "INF412", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1580) },
                    { 39, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1582), (short)5, false, "REDES II", "INF423", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1583) },
                    { 40, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1584), (short)5, false, "INGENIERÍA DE SOFTWARE II", "INF512", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1584) },
                    { 41, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1587), (short)5, false, "TALLER DE GRADO I", "INF511", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1587) },
                    { 42, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1588), (short)5, false, "TECNOLOGÍA WEB", "INF513", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1588) },
                    { 43, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1590), (short)4, false, "ARQUITECTURA DE SOFTWARE", "INF552", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1590) },
                    { 44, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1591), (short)4, false, "SISTEMAS DE INFORMACIÓN GEOGRÁFICA", "INF442", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1592) },
                    { 53, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1516), (short)5, false, "ORGANIZACIÓN Y MÉTODOS", "ADM330", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1516) },
                    { 54, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1517), (short)5, false, "ECONOMÍA PARA LA GESTIÓN", "ECO300", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1517) },
                    { 55, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1526), (short)5, false, "FINANZAS PARA LA EMPRESA", "ADM320", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1526) },
                    { 56, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1536), (short)5, false, "SISTEMAS PARA EL SOPORTE A LA TOMA DE DECISIONES", "INF432", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1536) },
                    { 57, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1585), (short)4, false, "AUDITORÍA INFORMÁTICA", "INF462", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1585) },
                    { 58, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1593), (short)5, false, "MODALIDAD DE GRADUACIÓN", "GRLO01", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1593) },
                    { 59, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1594), (short)10, true, "MODELACIÓN Y SIMULACIÓN DE SISTEMAS", "ELCI01", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1594) },
                    { 60, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1596), (short)10, true, "PROGRAMACIÓN GRÁFICA", "ELCI02", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1596) },
                    { 61, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1597), (short)10, true, "TÓPICOS AVANZADOS DE PROGRAMACIÓN", "ELCI03", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1598) },
                    { 62, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1599), (short)10, true, "PROGRAMACIÓN DE APLICACIONES DE TIEMPO REAL", "ELCI04", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1599) },
                    { 63, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1601), (short)10, true, "SISTEMAS DISTRIBUIDOS", "ELCI05", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1601) },
                    { 64, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1602), (short)10, true, "INTERACCIÓN HOMBRE COMPUTADOR", "ELCI06", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1603) },
                    { 65, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1604), (short)10, true, "CRIPTOGRAFÍA Y SEGURIDAD", "ELCI07", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1604) },
                    { 66, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1605), (short)10, true, "CONTROL AND AUTOMATIZACIÓN", "ELCI08", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1605) },
                    { 67, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1607), (short)3, true, "ADMINISTRACIÓN DE RECURSOS HUMANOS", "ELC001", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1607) },
                    { 68, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1608), (short)3, true, "COSTOS Y PRESUPUESTOS", "ELC002", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1608) },
                    { 69, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1610), (short)3, true, "PRODUCCIÓN Y MARKETING", "ELC003", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1610) },
                    { 70, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1611), (short)3, true, "REINGENIERÍA", "ELC004", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1611) },
                    { 71, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1612), (short)3, true, "INGENIERÍA DE LA CALIDAD", "ELC005", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1613) },
                    { 72, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1614), (short)3, true, "BENCHMARKING", "ELC006", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1614) },
                    { 73, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1615), (short)3, true, "INTRODUCCIÓN A LA MACROECONOMÍA", "ELC007", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1616) },
                    { 74, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1617), (short)3, true, "LEGISLACIÓN EN CIENCIAS DE LA COMPUTACIÓN", "ELC008", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1617) },
                    { 75, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1618), (short)5, false, "ANÁLISIS DE CIRCUITOS", "RDS210", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1619) },
                    { 76, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1620), (short)5, false, "TEORÍA DE CAMPOS", "ELT241", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1620) },
                    { 77, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1621), (short)4, false, "ANÁLISIS DE CIRCUITOS ELECTRÓNICOS", "RDS220", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1622) },
                    { 78, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1623), (short)5, false, "ELECTRÓNICA APLICADA A REDES", "RDS310", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1623) },
                    { 79, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1624), (short)5, false, "SISTEMAS LÓGICOS Y DIGITALES I", "ELT352", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1625) },
                    { 80, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1626), (short)5, false, "SEÑALES Y SISTEMAS", "ELT354", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1626) },
                    { 81, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1627), (short)5, true, "DISEÑO DE CIRCUITOS INTEGRADOS", "ELC201", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1627) },
                    { 82, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1629), (short)5, true, "INSTRUMENTACIÓN", "ELC202", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1629) },
                    { 83, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1630), (short)5, false, "SISTEMAS LÓGICOS Y DIGITALES II", "ELT362", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1630) },
                    { 84, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1632), (short)5, false, "INTERPRETACIÓN DE SISTEMAS Y SEÑALES", "RDS320", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1632) },
                    { 85, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1633), (short)5, true, "SISTEMAS DE COMUNICACIÓN SCADA", "ELC203", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1633) },
                    { 86, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1635), (short)5, true, "TELEVISIÓN DIGITAL", "ELC204", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1635) },
                    { 87, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1636), (short)5, false, "APLICACIONES CON MICROPROCESADORES", "RDS410", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1636) },
                    { 88, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1638), (short)5, false, "SISTEMAS DE COMUNICACIÓN I", "ELT374", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1638) },
                    { 89, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1639), (short)5, true, "DOMÓTICA", "ELC205", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1639) },
                    { 90, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1641), (short)5, false, "LÍNEAS DE TRANSMISIÓN Y ANTENAS", "ELC206", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1641) },
                    { 91, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1643), (short)5, false, "TALLER DE ANÁLISIS Y DISEÑO DE REDES", "RDS421", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1643) },
                    { 92, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1645), (short)5, false, "LEGISLACIÓN EN REDES Y COMUNICACIONES", "RS429", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1646) },
                    { 93, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1647), (short)5, false, "SISTEMAS DE COMUNICACIÓN II", "ELC384", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1648) },
                    { 94, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1649), (short)5, true, "TÉCNICAS DE PRESENTACIÓN PARA INGENIERÍA", "ELC207", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1649) },
                    { 95, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1651), (short)5, true, "REDES ADHOC", "ELC208", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1651) },
                    { 96, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1652), (short)5, false, "GESTIÓN Y ADMINISTRACIÓN DE REDES", "RDS511", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1652) },
                    { 97, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1654), (short)5, false, "REDES INALÁMBRICAS Y COMUNICACIONES MÓVILES", "RDS512", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1654) },
                    { 98, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1656), (short)5, false, "SEGURIDAD EN REDES Y TRANSMISIÓN DE DATOS", "RDS519", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1656) },
                    { 99, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1658), (short)5, false, "MODALIDAD DE TITULACIÓN A NIVEL TÉCNICO SUPERIOR", "GRT001", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1658) },
                    { 100, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1660), (short)5, false, "MODALIDAD DE TITULACIÓN LICENCIATURA", "GRL001", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1661) }
                });

            migrationBuilder.InsertData(
                table: "modulo",
                columns: new[] { "id", "created_at", "nro_modulo", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1922), (short)236, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1922) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1924), (short)225, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1924) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1925), (short)260, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1925) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1926), (short)224, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1926) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1927), (short)256, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1927) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1928), (short)222, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1928) }
                });

            migrationBuilder.InsertData(
                table: "nivel",
                columns: new[] { "id", "created_at", "nombre", "orden", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2074), "1 SEMESTRE", (short)1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2074) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2077), "2 SEMESTRE", (short)2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2077) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2078), "3 SEMESTRE", (short)3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2078) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2079), "4 SEMESTRE", (short)4, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2079) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2080), "5 SEMESTRE", (short)5, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2081) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2082), "6 SEMESTRE", (short)6, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2082) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2083), "7 SEMESTRE", (short)7, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2083) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2084), "8 SEMESTRE", (short)8, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2084) },
                    { 9, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2085), "9 SEMESTRE", (short)9, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2086) },
                    { 10, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2087), "10 SEMESTRE", (short)10, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2087) }
                });

            migrationBuilder.InsertData(
                table: "grupo_materia",
                columns: new[] { "id", "created_at", "grupo_id", "materia_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7247), 1, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7247) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7249), 2, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7249) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7250), 3, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7250) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7251), 1, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7252) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7253), 2, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7253) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7254), 3, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7254) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7255), 4, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7255) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7256), 5, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7256) },
                    { 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7257), 6, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7258) },
                    { 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7259), 1, 75, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7259) },
                    { 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7260), 2, 75, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7260) },
                    { 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7261), 17, 77, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7261) },
                    { 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7262), 1, 87, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7263) },
                    { 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7264), 1, 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7264) },
                    { 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7265), 2, 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7265) },
                    { 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7266), 1, 43, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7266) },
                    { 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7267), 1, 57, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7268) },
                    { 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7269), 1, 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7269) },
                    { 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7270), 3, 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7270) },
                    { 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7271), 2, 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7271) },
                    { 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7272), 4, 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7273) },
                    { 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7274), 18, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7274) },
                    { 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7275), 17, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7275) },
                    { 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7276), 20, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7276) },
                    { 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7277), 22, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7278) },
                    { 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7279), 6, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7279) },
                    { 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7280), 7, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7280) },
                    { 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7281), 9, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7281) },
                    { 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7282), 13, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7283) },
                    { 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7284), 33, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7284) },
                    { 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7285), 34, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7285) },
                    { 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7286), 35, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7286) },
                    { 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7287), 36, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7287) },
                    { 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7288), 37, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7289) },
                    { 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7290), 38, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7290) },
                    { 36, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7291), 2, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7291) },
                    { 37, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7292), 4, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7292) },
                    { 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7293), 24, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7293) },
                    { 39, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7294), 25, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7295) },
                    { 40, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7296), 21, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7296) },
                    { 41, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7297), 8, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7297) },
                    { 42, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7298), 11, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7298) },
                    { 43, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7299), 1, 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7299) },
                    { 44, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7300), 1, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7301) },
                    { 45, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7302), 2, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7303) },
                    { 46, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7305), 1, 68, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7305) },
                    { 47, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7306), 22, 65, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7306) },
                    { 48, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7307), 1, 65, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7307) },
                    { 49, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7308), 1, 81, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7309) },
                    { 50, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7310), 1, 54, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7310) },
                    { 51, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7311), 2, 54, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7311) },
                    { 52, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7312), 27, 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7312) },
                    { 53, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7313), 28, 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7313) },
                    { 54, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7314), 1, 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7315) },
                    { 55, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7316), 3, 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7316) },
                    { 56, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7317), 2, 78, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7317) },
                    { 57, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7319), 22, 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7319) },
                    { 58, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7360), 1, 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7360) },
                    { 59, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7361), 2, 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7362) },
                    { 60, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7363), 4, 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7363) },
                    { 61, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7364), 1, 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7364) },
                    { 62, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7365), 2, 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7365) },
                    { 63, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7366), 16, 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7366) },
                    { 64, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7367), 5, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7368) },
                    { 65, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7369), 6, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7369) },
                    { 66, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7370), 8, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7370) },
                    { 67, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7371), 10, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7371) },
                    { 68, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7372), 34, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7373) },
                    { 69, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7377), 35, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7377) },
                    { 70, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7378), 13, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7379) },
                    { 71, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7380), 33, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7380) },
                    { 72, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7381), 36, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7381) },
                    { 73, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7382), 37, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7382) },
                    { 74, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7383), 38, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7384) },
                    { 75, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7386), 1, 55, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7386) },
                    { 76, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7387), 3, 55, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7387) },
                    { 77, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7389), 24, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7389) },
                    { 78, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7390), 26, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7390) },
                    { 79, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7391), 7, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7391) },
                    { 80, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7392), 9, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7392) },
                    { 81, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7393), 10, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7394) },
                    { 82, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7395), 12, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7395) },
                    { 83, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7396), 13, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7396) },
                    { 84, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7397), 33, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7397) },
                    { 85, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7398), 34, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7398) },
                    { 86, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7399), 35, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7400) },
                    { 87, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7401), 36, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7401) },
                    { 88, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7402), 37, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7402) },
                    { 89, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7403), 38, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7403) },
                    { 90, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7404), 19, 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7404) },
                    { 91, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7406), 24, 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7406) },
                    { 92, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7407), 27, 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7407) },
                    { 93, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7408), 28, 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7408) },
                    { 94, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7409), 1, 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7409) },
                    { 95, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7410), 2, 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7411) },
                    { 96, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7412), 1, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7412) },
                    { 97, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7413), 2, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7413) },
                    { 98, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7414), 3, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7414) },
                    { 99, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7415), 34, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7415) },
                    { 100, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7417), 35, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7417) },
                    { 101, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7418), 36, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7419) },
                    { 102, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7420), 1, 96, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7420) },
                    { 103, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7421), 1, 71, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7421) },
                    { 104, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7422), 2, 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7422) },
                    { 105, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7423), 3, 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7423) },
                    { 106, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7424), 2, 40, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7425) },
                    { 107, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7425), 27, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7426) },
                    { 108, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7427), 28, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7427) },
                    { 109, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7428), 33, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7428) },
                    { 110, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7429), 34, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7429) },
                    { 111, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7430), 35, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7430) },
                    { 112, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7431), 36, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7432) },
                    { 113, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7433), 38, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7433) },
                    { 114, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7434), 2, 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7434) },
                    { 115, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7435), 3, 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7435) },
                    { 116, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7436), 4, 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7437) },
                    { 117, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7438), 9, 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7438) },
                    { 118, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7439), 1, 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7439) },
                    { 119, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7440), 2, 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7440) },
                    { 120, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7441), 9, 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7442) },
                    { 121, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7443), 1, 69, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7443) },
                    { 122, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7444), 1, 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7444) },
                    { 123, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7445), 1, 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7445) },
                    { 124, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7446), 2, 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7447) },
                    { 125, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7447), 3, 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7448) },
                    { 126, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7449), 16, 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7449) },
                    { 127, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7450), 1, 60, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7450) },
                    { 128, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7451), 1, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7451) },
                    { 129, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7452), 3, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7453) },
                    { 130, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7454), 2, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7454) },
                    { 131, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7456), 7, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7457) },
                    { 132, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7458), 4, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7458) },
                    { 133, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7459), 6, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7459) },
                    { 134, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7460), 8, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7460) },
                    { 135, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7461), 9, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7461) },
                    { 136, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7462), 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7463) },
                    { 137, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7498), 4, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7498) },
                    { 138, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7499), 3, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7499) },
                    { 139, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7500), 2, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7500) },
                    { 140, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7501), 9, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7501) },
                    { 141, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7502), 1, 95, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7503) },
                    { 142, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7504), 1, 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7504) },
                    { 143, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7505), 2, 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7505) },
                    { 144, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7506), 3, 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7507) },
                    { 145, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7507), 24, 39, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7508) },
                    { 146, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7509), 2, 39, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7509) },
                    { 147, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7510), 3, 39, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7510) },
                    { 148, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7511), 1, 97, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7511) },
                    { 149, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7512), 1, 98, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7513) },
                    { 150, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7514), 24, 80, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7514) },
                    { 151, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7515), 14, 88, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7515) },
                    { 152, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7516), 14, 93, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7516) },
                    { 153, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7517), 24, 85, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7517) },
                    { 154, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7518), 9, 44, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7519) },
                    { 155, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7520), 1, 44, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7520) },
                    { 156, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7521), 1, 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7521) },
                    { 157, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7522), 3, 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7522) },
                    { 158, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7523), 1, 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7523) },
                    { 159, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7524), 2, 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7525) },
                    { 160, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7526), 2, 37, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7526) },
                    { 161, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7527), 23, 79, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7527) },
                    { 162, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7528), 24, 83, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7529) },
                    { 163, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7530), 1, 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7530) },
                    { 164, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7531), 3, 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7531) },
                    { 165, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7532), 1, 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7532) },
                    { 166, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7533), 2, 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7534) },
                    { 167, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7535), 1, 56, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7535) },
                    { 168, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7536), 1, 91, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7536) },
                    { 169, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7537), 15, 41, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7537) },
                    { 170, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7538), 1, 41, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7539) },
                    { 171, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7539), 3, 41, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7540) },
                    { 172, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7541), 1, 42, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7541) },
                    { 173, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7542), 3, 42, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7542) },
                    { 174, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7543), 14, 86, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7543) },
                    { 175, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7544), 3, 76, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7545) },
                    { 176, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7546), 1, 61, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(7546) }
                });

            migrationBuilder.InsertData(
                table: "hora_dia",
                columns: new[] { "id", "created_at", "dia_id", "hora_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8685), 1, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8685) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8688), 1, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8689) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8690), 1, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8690) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8691), 1, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8691) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8692), 1, 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8692) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8694), 1, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8694) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8695), 1, 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8695) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8696), 1, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8696) },
                    { 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8697), 1, 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8697) },
                    { 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8699), 1, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8699) },
                    { 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8700), 1, 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8700) },
                    { 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8701), 1, 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8701) },
                    { 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8702), 1, 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8702) },
                    { 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8703), 1, 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8704) },
                    { 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8705), 1, 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8705) },
                    { 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8706), 1, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8706) },
                    { 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8707), 1, 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8707) },
                    { 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8708), 1, 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8708) },
                    { 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8709), 1, 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8710) },
                    { 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8711), 1, 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8711) },
                    { 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8712), 2, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8712) },
                    { 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8713), 2, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8713) },
                    { 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8714), 2, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8714) },
                    { 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8715), 2, 37, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8716) },
                    { 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8716), 2, 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8717) },
                    { 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8718), 2, 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8718) },
                    { 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8719), 2, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8719) },
                    { 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8720), 2, 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8720) },
                    { 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8721), 2, 36, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8721) },
                    { 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8722), 2, 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8722) },
                    { 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8723), 2, 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8724) },
                    { 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8725), 2, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8725) },
                    { 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8726), 2, 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8726) },
                    { 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8727), 2, 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8727) },
                    { 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8728), 2, 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8729) },
                    { 36, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8729), 2, 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8730) },
                    { 37, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8731), 2, 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8731) },
                    { 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8732), 2, 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8732) },
                    { 39, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8733), 2, 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8733) },
                    { 40, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8734), 2, 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8734) },
                    { 41, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8735), 2, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8735) },
                    { 42, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8736), 2, 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8737) },
                    { 43, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8738), 2, 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8738) },
                    { 44, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8739), 2, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8739) },
                    { 45, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8740), 2, 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8740) },
                    { 46, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8741), 3, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8741) },
                    { 47, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8742), 3, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8743) },
                    { 48, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8744), 3, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8744) },
                    { 49, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8745), 3, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8745) },
                    { 50, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8746), 3, 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8746) },
                    { 51, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8747), 3, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8747) },
                    { 52, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8748), 3, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8749) },
                    { 53, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8750), 3, 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8750) },
                    { 54, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8751), 3, 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8752) },
                    { 55, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8753), 3, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8753) },
                    { 56, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8755), 3, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8755) },
                    { 57, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8756), 3, 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8757) },
                    { 58, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8758), 3, 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8758) },
                    { 59, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8759), 3, 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8759) },
                    { 60, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8760), 3, 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8761) },
                    { 61, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8761), 3, 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8762) },
                    { 62, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8834), 3, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8834) },
                    { 63, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8835), 3, 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8836) },
                    { 64, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8837), 3, 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8837) },
                    { 65, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8838), 3, 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8838) },
                    { 66, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8839), 4, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8839) },
                    { 67, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8840), 4, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8840) },
                    { 68, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8842), 4, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8842) },
                    { 69, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8843), 4, 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8843) },
                    { 70, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8844), 4, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8844) },
                    { 71, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8845), 4, 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8845) },
                    { 72, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8846), 4, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8847) },
                    { 73, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8847), 4, 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8848) },
                    { 74, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8849), 4, 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8849) },
                    { 75, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8850), 4, 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8850) },
                    { 76, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8851), 4, 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8851) },
                    { 77, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8852), 4, 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8852) },
                    { 78, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8853), 4, 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8854) },
                    { 79, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8854), 4, 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8855) },
                    { 80, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8856), 4, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8856) },
                    { 81, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8857), 4, 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8857) },
                    { 82, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8858), 4, 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8859) },
                    { 83, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8860), 4, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8860) },
                    { 84, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8861), 4, 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8861) },
                    { 85, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8862), 5, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8862) },
                    { 86, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8865), 5, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8865) },
                    { 87, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8869), 5, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8869) },
                    { 88, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8870), 5, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8871) },
                    { 89, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8872), 5, 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8872) },
                    { 90, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8874), 5, 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8874) },
                    { 91, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8876), 3, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8876) },
                    { 92, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8877), 5, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8877) },
                    { 93, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8878), 5, 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8878) },
                    { 94, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8880), 5, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8880) },
                    { 95, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8882), 5, 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8882) },
                    { 96, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8883), 5, 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8883) },
                    { 97, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8884), 5, 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8884) },
                    { 98, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8885), 5, 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8886) },
                    { 99, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8886), 5, 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8887) },
                    { 100, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8888), 5, 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8888) },
                    { 101, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8889), 5, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8889) },
                    { 102, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8890), 5, 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8890) },
                    { 103, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8891), 5, 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8892) },
                    { 104, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8892), 5, 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8893) },
                    { 105, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8894), 5, 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8894) },
                    { 106, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8895), 6, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8895) },
                    { 107, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8896), 6, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8896) },
                    { 108, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8897), 6, 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8897) },
                    { 109, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8898), 6, 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8898) },
                    { 110, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8899), 6, 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8900) },
                    { 111, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8901), 6, 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8901) },
                    { 112, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8902), 6, 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8902) },
                    { 113, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8903), 6, 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8903) },
                    { 114, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8904), 3, 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8904) },
                    { 115, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8905), 5, 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8906) },
                    { 116, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8907), 3, 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8907) }
                });

            migrationBuilder.InsertData(
                table: "plan_estudio",
                columns: new[] { "id", "carrera_id", "codigo", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 1, 2, "ING-INF", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2229), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2230) },
                    { 2, 3, "ING-SIS", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2232), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2233) },
                    { 3, 1, "ING-RED", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2234), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2234) },
                    { 4, 4, "ING-ROB", new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2235), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2236) }
                });

            migrationBuilder.InsertData(
                table: "hora_dia_horario",
                columns: new[] { "id", "created_at", "hora_dia_id", "horario_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8093), 1, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8094) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8096), 47, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8096) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8097), 85, 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8097) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8098), 3, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8098) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8099), 48, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8099) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8100), 87, 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8100) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8101), 5, 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8101) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8102), 50, 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8102) },
                    { 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8143), 89, 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8143) },
                    { 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8144), 6, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8144) },
                    { 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8145), 51, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8145) },
                    { 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8146), 91, 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8146) },
                    { 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8147), 7, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8147) },
                    { 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8148), 53, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8148) },
                    { 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8149), 93, 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8149) },
                    { 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8150), 9, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8150) },
                    { 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8151), 54, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8151) },
                    { 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8152), 95, 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8152) },
                    { 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8153), 11, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8153) },
                    { 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8154), 57, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8154) },
                    { 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8155), 96, 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8155) },
                    { 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8155), 13, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8156) },
                    { 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8157), 60, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8157) },
                    { 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8157), 97, 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8158) },
                    { 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8158), 14, 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8159) },
                    { 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8159), 59, 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8160) },
                    { 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8160), 98, 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8161) },
                    { 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8161), 15, 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8162) },
                    { 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8162), 61, 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8163) },
                    { 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8163), 100, 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8163) },
                    { 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8164), 16, 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8164) },
                    { 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8165), 62, 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8165) },
                    { 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8166), 101, 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8166) },
                    { 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8167), 18, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8167) },
                    { 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8168), 63, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8168) },
                    { 36, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8169), 103, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8169) },
                    { 37, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8170), 20, 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8170) },
                    { 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8171), 65, 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8171) },
                    { 39, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8172), 105, 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8172) },
                    { 40, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8173), 19, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8173) },
                    { 41, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8174), 64, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8174) },
                    { 42, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8175), 104, 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8175) },
                    { 43, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8176), 1, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8176) },
                    { 44, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8177), 47, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8177) },
                    { 45, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8178), 85, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8178) },
                    { 46, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8179), 106, 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8179) },
                    { 47, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8180), 5, 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8180) },
                    { 48, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8181), 50, 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8181) },
                    { 49, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8182), 89, 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8182) },
                    { 50, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8183), 112, 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8183) },
                    { 51, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8184), 5, 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8184) },
                    { 52, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8185), 50, 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8185) },
                    { 53, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8186), 89, 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8186) },
                    { 54, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8187), 113, 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8187) },
                    { 55, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8188), 14, 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8188) },
                    { 56, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8189), 59, 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8189) },
                    { 57, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8189), 98, 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8190) },
                    { 58, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8190), 107, 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8191) },
                    { 59, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8191), 18, 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8192) },
                    { 60, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8192), 63, 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8192) },
                    { 61, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8193), 103, 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8193) },
                    { 62, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8194), 109, 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8194) },
                    { 63, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8195), 9, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8195) },
                    { 64, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8196), 54, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8196) },
                    { 65, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8197), 95, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8197) },
                    { 66, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8198), 98, 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8198) },
                    { 67, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8199), 11, 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8199) },
                    { 68, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8200), 57, 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8200) },
                    { 69, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8201), 96, 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8201) },
                    { 70, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8203), 105, 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8203) },
                    { 71, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8203), 14, 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8204) },
                    { 72, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8204), 59, 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8205) },
                    { 73, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8205), 98, 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8206) },
                    { 74, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8206), 100, 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8207) },
                    { 75, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8207), 2, 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8208) },
                    { 76, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8208), 46, 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8209) },
                    { 77, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8209), 4, 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8209) },
                    { 78, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8210), 49, 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8210) },
                    { 79, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8211), 10, 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8211) },
                    { 80, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8212), 55, 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8212) },
                    { 81, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8213), 12, 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8213) },
                    { 82, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8214), 58, 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8214) },
                    { 83, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8215), 16, 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8215) },
                    { 84, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8216), 62, 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8216) },
                    { 85, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8217), 17, 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8217) },
                    { 86, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8218), 116, 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8218) },
                    { 87, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8219), 2, 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8219) },
                    { 88, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8219), 46, 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8220) },
                    { 89, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8220), 56, 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8221) },
                    { 90, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8221), 2, 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8222) },
                    { 91, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8222), 67, 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8223) },
                    { 92, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8223), 10, 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8223) },
                    { 93, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8224), 72, 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8224) },
                    { 94, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8226), 96, 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8226) },
                    { 95, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8227), 2, 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8227) },
                    { 96, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8228), 86, 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8228) },
                    { 97, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8229), 21, 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8229) },
                    { 98, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8230), 7, 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8230) },
                    { 99, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8231), 36, 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8231) },
                    { 100, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8231), 76, 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8232) },
                    { 101, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8232), 8, 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8233) },
                    { 102, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8233), 22, 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8234) },
                    { 103, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8234), 67, 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8234) },
                    { 104, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8235), 12, 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8235) },
                    { 105, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8236), 21, 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8236) },
                    { 106, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8237), 94, 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8237) },
                    { 107, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8238), 24, 36, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8238) },
                    { 108, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8239), 22, 37, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8239) },
                    { 109, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8240), 67, 37, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8240) },
                    { 110, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8241), 28, 37, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8241) },
                    { 111, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8242), 22, 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8242) },
                    { 112, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8243), 67, 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8243) },
                    { 113, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8243), 26, 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8244) },
                    { 114, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8244), 40, 39, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8245) },
                    { 115, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8245), 79, 39, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8246) },
                    { 116, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8246), 37, 39, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8246) },
                    { 117, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8247), 40, 40, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8247) },
                    { 118, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8248), 79, 40, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8248) },
                    { 119, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8249), 64, 40, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8249) },
                    { 120, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8250), 22, 41, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8250) },
                    { 121, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8251), 67, 41, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8251) },
                    { 122, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8252), 89, 41, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8252) },
                    { 123, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8253), 22, 42, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8253) },
                    { 124, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8254), 67, 42, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8254) },
                    { 125, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8255), 100, 42, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8255) },
                    { 126, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8256), 32, 43, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8256) },
                    { 127, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8256), 72, 43, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8257) },
                    { 128, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8257), 96, 43, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8258) },
                    { 129, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8258), 36, 44, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8258) },
                    { 130, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8259), 76, 44, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8259) },
                    { 131, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8261), 97, 44, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8261) },
                    { 132, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8262), 31, 45, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8262) },
                    { 133, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8263), 58, 45, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8263) },
                    { 134, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8264), 94, 45, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8264) },
                    { 135, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8265), 11, 46, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8265) },
                    { 136, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8266), 33, 46, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8266) },
                    { 137, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8300), 57, 46, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8300) },
                    { 138, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8301), 37, 46, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8302) },
                    { 139, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8302), 49, 47, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8303) },
                    { 140, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8303), 86, 47, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8304) },
                    { 141, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8304), 52, 48, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8305) },
                    { 142, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8305), 90, 48, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8306) },
                    { 143, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8306), 50, 49, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8307) },
                    { 144, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8307), 96, 49, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8307) },
                    { 145, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8308), 111, 49, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8308) },
                    { 146, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8309), 114, 50, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8309) },
                    { 147, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8310), 115, 50, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8310) },
                    { 148, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8311), 64, 51, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8311) },
                    { 149, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8312), 99, 51, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8312) },
                    { 150, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8313), 55, 52, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8313) },
                    { 151, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8314), 110, 52, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8314) },
                    { 152, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8315), 48, 53, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8315) },
                    { 153, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8316), 67, 53, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8316) },
                    { 154, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8317), 88, 53, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8317) },
                    { 155, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8318), 70, 54, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8318) },
                    { 156, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8319), 92, 54, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8319) },
                    { 157, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8320), 22, 55, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8320) },
                    { 158, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8320), 86, 55, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8321) },
                    { 159, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8321), 29, 56, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8322) },
                    { 160, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8322), 95, 56, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8323) },
                    { 161, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8323), 21, 57, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8324) },
                    { 162, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8324), 66, 57, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8324) },
                    { 163, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8325), 106, 57, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8325) },
                    { 164, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8326), 22, 58, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8326) },
                    { 165, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8327), 86, 58, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8327) },
                    { 166, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8328), 21, 59, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8328) },
                    { 167, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8329), 66, 59, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8329) },
                    { 168, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8330), 23, 60, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8330) },
                    { 169, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8331), 68, 60, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8331) },
                    { 170, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8332), 27, 61, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8332) },
                    { 171, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8333), 70, 61, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8333) },
                    { 172, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8334), 31, 72, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8334) },
                    { 173, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8335), 71, 72, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8335) },
                    { 174, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8336), 32, 73, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8336) },
                    { 175, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8337), 72, 73, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8337) },
                    { 176, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8338), 33, 74, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8338) },
                    { 177, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8339), 74, 74, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8339) },
                    { 178, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8340), 34, 75, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8340) },
                    { 179, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8341), 73, 75, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8341) },
                    { 180, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8342), 36, 76, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8342) },
                    { 181, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8343), 76, 76, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8343) },
                    { 182, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8343), 35, 77, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8344) },
                    { 183, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8344), 75, 77, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8345) },
                    { 184, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8345), 38, 78, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8346) },
                    { 185, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8346), 77, 78, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8347) },
                    { 186, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8347), 40, 79, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8348) },
                    { 187, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8348), 79, 79, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8349) },
                    { 188, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8349), 39, 80, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8349) },
                    { 189, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8350), 78, 80, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8350) },
                    { 190, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8351), 41, 81, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8351) },
                    { 191, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8352), 80, 81, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8352) },
                    { 192, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8353), 42, 82, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8353) },
                    { 193, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8354), 81, 82, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8354) },
                    { 194, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8355), 43, 83, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8355) },
                    { 195, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8356), 82, 83, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8356) },
                    { 196, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8357), 44, 84, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8357) },
                    { 197, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8358), 83, 84, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8358) },
                    { 198, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8359), 45, 85, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8359) },
                    { 199, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8360), 84, 85, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8360) },
                    { 200, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8360), 108, 86, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(8361) }
                });

            migrationBuilder.InsertData(
                table: "horario_materia",
                columns: new[] { "id", "created_at", "cupos_disponibles", "cupos_total", "docente_id", "gestion_id", "grupo_materia_id", "horario_id", "modulo_id", "nro_aula", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9220), (short)30, (short)100, 29, 1, 1, 10, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9220) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9228), (short)30, (short)100, 29, 1, 2, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9228) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9230), (short)30, (short)100, 12, 1, 3, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9230) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9232), (short)30, (short)100, 26, 1, 4, 2, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9232) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9235), (short)30, (short)100, 26, 1, 5, 3, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9235) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9237), (short)30, (short)100, 26, 1, 6, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9237) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9239), (short)30, (short)100, 26, 1, 7, 4, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9239) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9241), (short)30, (short)100, 33, 1, 8, 3, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9241) },
                    { 9, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9247), (short)30, (short)100, 34, 1, 9, 23, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9247) },
                    { 10, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9250), (short)30, (short)100, 52, 1, 10, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9250) },
                    { 11, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9252), (short)30, (short)100, 52, 1, 11, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9252) },
                    { 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9254), (short)30, (short)100, 52, 1, 12, 2, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9254) },
                    { 13, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9256), (short)30, (short)100, 19, 1, 13, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9256) },
                    { 14, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9257), (short)30, (short)100, 40, 1, 14, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9258) },
                    { 15, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9260), (short)30, (short)100, 40, 1, 15, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9260) },
                    { 16, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9262), (short)30, (short)100, 78, 1, 16, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9262) },
                    { 17, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9264), (short)30, (short)100, 75, 1, 17, 9, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9264) },
                    { 18, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9266), (short)30, (short)100, 78, 1, 18, 2, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9266) },
                    { 19, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9268), (short)30, (short)100, 78, 1, 19, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9268) },
                    { 20, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9270), (short)30, (short)100, 61, 1, 20, 50, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9270) },
                    { 21, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9272), (short)30, (short)100, 61, 1, 21, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9272) },
                    { 22, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9273), (short)30, (short)100, 7, 1, 22, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9274) },
                    { 23, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9275), (short)30, (short)100, 41, 1, 23, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9276) },
                    { 24, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9277), (short)30, (short)100, 70, 1, 24, 25, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9278) },
                    { 25, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9279), (short)30, (short)100, 41, 1, 25, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9279) },
                    { 26, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9281), (short)30, (short)100, 50, 1, 26, 30, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9281) },
                    { 27, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9283), (short)30, (short)100, 10, 1, 27, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9283) },
                    { 28, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9285), (short)30, (short)100, 53, 1, 28, 10, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9285) },
                    { 29, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9290), (short)30, (short)100, 28, 1, 29, 55, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9291) },
                    { 30, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9292), (short)30, (short)100, 69, 1, 30, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9292) },
                    { 31, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9295), (short)30, (short)100, 1, 1, 31, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9295) },
                    { 32, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9297), (short)30, (short)100, 49, 1, 32, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9297) },
                    { 33, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9299), (short)30, (short)100, 73, 1, 33, 73, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9299) },
                    { 34, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9302), (short)30, (short)100, 2, 1, 34, 12, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9302) },
                    { 35, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9305), (short)30, (short)100, 20, 1, 35, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9305) },
                    { 36, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9307), (short)30, (short)100, 43, 1, 36, 14, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9307) },
                    { 37, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9309), (short)30, (short)100, 20, 1, 37, 57, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9309) },
                    { 38, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9311), (short)30, (short)100, 35, 1, 38, 5, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9311) },
                    { 39, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9312), (short)30, (short)100, 1, 1, 39, 82, 3, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9313) },
                    { 40, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9314), (short)30, (short)100, 50, 1, 40, 47, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9315) },
                    { 41, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9316), (short)30, (short)100, 79, 1, 41, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9317) },
                    { 42, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9363), (short)30, (short)100, 84, 1, 42, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9363) },
                    { 43, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9365), (short)30, (short)100, 8, 1, 43, 4, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9365) },
                    { 44, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9367), (short)30, (short)100, 29, 1, 44, 2, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9367) },
                    { 45, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9369), (short)30, (short)100, 54, 1, 45, 8, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9369) },
                    { 46, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9371), (short)30, (short)100, 24, 1, 46, 74, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9371) },
                    { 47, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9373), (short)30, (short)100, 62, 1, 47, 78, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9373) },
                    { 48, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9375), (short)30, (short)100, 62, 1, 48, 77, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9375) },
                    { 49, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9377), (short)30, (short)100, 40, 1, 49, 59, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9377) },
                    { 50, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9379), (short)30, (short)100, 71, 1, 50, 9, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9380) },
                    { 51, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9381), (short)30, (short)100, 71, 1, 51, 4, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9382) },
                    { 52, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9383), (short)30, (short)100, 49, 1, 52, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9383) },
                    { 53, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9385), (short)30, (short)100, 37, 1, 53, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9385) },
                    { 54, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9387), (short)30, (short)100, 37, 1, 54, 84, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9387) },
                    { 55, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9389), (short)30, (short)100, 7, 1, 55, 84, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9389) },
                    { 56, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9392), (short)30, (short)100, 69, 1, 56, 48, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9392) },
                    { 57, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9394), (short)30, (short)100, 59, 1, 57, 75, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9394) },
                    { 58, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9396), (short)30, (short)100, 44, 1, 58, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9396) },
                    { 59, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9398), (short)30, (short)100, 21, 1, 59, 84, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9398) },
                    { 60, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9400), (short)30, (short)100, 44, 1, 60, 61, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9400) },
                    { 61, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9402), (short)30, (short)100, 59, 1, 61, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9402) },
                    { 62, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9403), (short)30, (short)100, 72, 1, 62, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9404) },
                    { 63, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9405), (short)30, (short)100, 76, 1, 63, 84, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9406) },
                    { 64, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9407), (short)30, (short)100, 74, 1, 64, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9408) },
                    { 65, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9409), (short)30, (short)100, 47, 1, 65, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9410) },
                    { 66, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9411), (short)30, (short)100, 49, 1, 66, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9412) },
                    { 67, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9413), (short)30, (short)100, 33, 1, 67, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9414) },
                    { 68, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9415), (short)30, (short)100, 13, 1, 68, 2, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9416) },
                    { 69, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9418), (short)30, (short)100, 13, 1, 69, 6, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9418) },
                    { 70, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9420), (short)30, (short)100, 47, 1, 70, 3, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9420) },
                    { 71, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9422), (short)30, (short)100, 33, 1, 71, 2, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9422) },
                    { 72, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9424), (short)30, (short)100, 13, 1, 72, 7, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9424) },
                    { 73, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9426), (short)30, (short)100, 33, 1, 73, 9, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9426) },
                    { 74, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9428), (short)30, (short)100, 47, 1, 74, 2, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9429) },
                    { 75, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9430), (short)30, (short)100, 71, 1, 75, 61, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9431) },
                    { 76, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9432), (short)30, (short)100, 12, 1, 76, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9432) },
                    { 77, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9434), (short)30, (short)100, 4, 1, 77, 15, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9434) },
                    { 78, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9436), (short)30, (short)100, 42, 1, 78, 33, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9436) },
                    { 79, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9438), (short)30, (short)100, 67, 1, 79, 34, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9438) },
                    { 80, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9440), (short)30, (short)100, 22, 1, 80, 41, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9440) },
                    { 81, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9442), (short)30, (short)100, 22, 1, 81, 44, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9442) },
                    { 82, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9444), (short)30, (short)100, 65, 1, 82, 46, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9444) },
                    { 83, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9446), (short)30, (short)100, 14, 1, 83, 29, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9446) },
                    { 84, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9448), (short)30, (short)100, 55, 1, 84, 37, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9448) },
                    { 85, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9450), (short)30, (short)100, 63, 1, 85, 38, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9450) },
                    { 86, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9453), (short)30, (short)100, 25, 1, 86, 22, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9453) },
                    { 87, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9455), (short)30, (short)100, 17, 1, 87, 18, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9455) },
                    { 88, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9457), (short)30, (short)100, 43, 1, 88, 39, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9457) },
                    { 89, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9459), (short)30, (short)100, 17, 1, 89, 16, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9459) },
                    { 90, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9461), (short)30, (short)100, 81, 1, 90, 42, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9461) },
                    { 91, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9463), (short)30, (short)100, 63, 1, 91, 19, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9463) },
                    { 92, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9464), (short)30, (short)100, 17, 1, 92, 40, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9465) },
                    { 93, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9504), (short)30, (short)100, 17, 1, 93, 41, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9504) },
                    { 94, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9506), (short)30, (short)100, 81, 1, 94, 43, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9506) },
                    { 95, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9508), (short)30, (short)100, 81, 1, 95, 20, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9508) },
                    { 96, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9510), (short)30, (short)100, 56, 1, 96, 32, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9510) },
                    { 97, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9512), (short)30, (short)100, 6, 1, 97, 53, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9512) },
                    { 98, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9513), (short)30, (short)100, 64, 1, 98, 21, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9514) },
                    { 99, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9515), (short)30, (short)100, 82, 1, 99, 35, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9516) },
                    { 100, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9517), (short)30, (short)100, 56, 1, 100, 31, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9518) },
                    { 101, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9519), (short)30, (short)100, 3, 1, 101, 45, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9520) },
                    { 102, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9522), (short)30, (short)100, 75, 1, 102, 10, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9522) },
                    { 103, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9524), (short)30, (short)100, 18, 1, 103, 27, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9524) },
                    { 104, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9526), (short)30, (short)100, 48, 1, 104, 7, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9526) },
                    { 105, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9528), (short)30, (short)100, 48, 1, 105, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9528) },
                    { 106, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9530), (short)30, (short)100, 48, 1, 106, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9530) },
                    { 107, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9532), (short)30, (short)100, 5, 1, 107, 3, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9532) },
                    { 108, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9534), (short)30, (short)100, 5, 1, 108, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9534) },
                    { 109, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9536), (short)30, (short)100, 23, 1, 109, 3, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9536) },
                    { 110, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9538), (short)30, (short)100, 23, 1, 110, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9538) },
                    { 111, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9539), (short)30, (short)100, 83, 1, 111, 73, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9540) },
                    { 112, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9541), (short)30, (short)100, 83, 1, 112, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9542) },
                    { 113, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9543), (short)30, (short)100, 23, 1, 113, 73, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9543) },
                    { 114, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9545), (short)30, (short)100, 14, 1, 114, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9545) },
                    { 115, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9547), (short)30, (short)100, 13, 1, 115, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9547) },
                    { 116, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9550), (short)30, (short)100, 15, 1, 116, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9550) },
                    { 117, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9552), (short)30, (short)100, 66, 1, 117, 82, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9552) },
                    { 118, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9554), (short)30, (short)100, 13, 1, 118, 3, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9554) },
                    { 119, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9555), (short)30, (short)100, 14, 1, 119, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9556) },
                    { 120, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9557), (short)30, (short)100, 36, 1, 120, 11, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9558) },
                    { 121, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9559), (short)30, (short)100, 6, 1, 121, 80, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9560) },
                    { 122, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9561), (short)30, (short)100, 8, 1, 122, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9562) },
                    { 123, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9563), (short)30, (short)100, 77, 1, 123, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9564) },
                    { 124, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9566), (short)30, (short)100, 77, 1, 124, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9566) },
                    { 125, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9568), (short)30, (short)100, 77, 1, 125, 3, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9568) },
                    { 126, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9570), (short)30, (short)100, 30, 1, 126, 28, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9570) },
                    { 127, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9572), (short)30, (short)100, 60, 1, 127, 86, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9573) },
                    { 128, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9574), (short)30, (short)100, 9, 1, 128, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9575) },
                    { 129, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9576), (short)30, (short)100, 60, 1, 129, 9, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9577) },
                    { 130, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9578), (short)30, (short)100, 51, 1, 130, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9579) },
                    { 131, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9580), (short)30, (short)100, 51, 1, 131, 12, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9580) },
                    { 132, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9582), (short)30, (short)100, 76, 1, 132, 9, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9582) },
                    { 133, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9585), (short)30, (short)100, 9, 1, 133, 3, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9585) },
                    { 134, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9587), (short)30, (short)100, 60, 1, 134, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9587) },
                    { 135, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9589), (short)30, (short)100, 51, 1, 135, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9589) },
                    { 136, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9590), (short)30, (short)100, 27, 1, 136, 73, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9591) },
                    { 137, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9592), (short)30, (short)100, 45, 1, 137, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9593) },
                    { 138, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9594), (short)30, (short)100, 27, 1, 138, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9595) },
                    { 139, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9596), (short)30, (short)100, 27, 1, 139, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9597) },
                    { 140, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9598), (short)30, (short)100, 62, 1, 140, 8, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9598) },
                    { 141, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9601), (short)30, (short)100, 80, 1, 141, 85, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9601) },
                    { 142, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9603), (short)30, (short)100, 52, 1, 142, 12, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9603) },
                    { 143, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9605), (short)30, (short)100, 39, 1, 143, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9605) },
                    { 144, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9643), (short)30, (short)100, 80, 1, 144, 82, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9643) },
                    { 145, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9645), (short)30, (short)100, 57, 1, 145, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9645) },
                    { 146, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9647), (short)30, (short)100, 39, 1, 146, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9647) },
                    { 147, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9649), (short)30, (short)100, 39, 1, 147, 10, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9649) },
                    { 148, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9651), (short)30, (short)100, 11, 1, 148, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9651) },
                    { 149, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9653), (short)30, (short)100, 9, 1, 149, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9653) },
                    { 150, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9655), (short)30, (short)100, 43, 1, 150, 49, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9655) },
                    { 151, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9657), (short)30, (short)100, 68, 1, 151, 52, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9657) },
                    { 152, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9658), (short)30, (short)100, 68, 1, 152, 56, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9659) },
                    { 153, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9660), (short)30, (short)100, 64, 1, 153, 80, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9661) },
                    { 154, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9663), (short)30, (short)100, 62, 1, 154, 72, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9663) },
                    { 155, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9665), (short)30, (short)100, 17, 1, 155, 10, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9665) },
                    { 156, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9667), (short)30, (short)100, 32, 1, 156, 60, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9667) },
                    { 157, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9669), (short)30, (short)100, 32, 1, 157, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9669) },
                    { 158, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9671), (short)30, (short)100, 32, 1, 158, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9671) },
                    { 159, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9673), (short)30, (short)100, 48, 1, 159, 9, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9673) },
                    { 160, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9676), (short)30, (short)100, 8, 1, 160, 3, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9676) },
                    { 161, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9678), (short)30, (short)100, 11, 1, 161, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9678) },
                    { 162, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9679), (short)30, (short)100, 40, 1, 162, 54, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9680) },
                    { 163, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9682), (short)30, (short)100, 8, 1, 163, 1, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9682) },
                    { 164, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9683), (short)30, (short)100, 8, 1, 164, 2, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9684) },
                    { 165, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9685), (short)30, (short)100, 65, 1, 165, 2, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9686) },
                    { 166, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9687), (short)30, (short)100, 18, 1, 166, 76, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9688) },
                    { 167, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9689), (short)30, (short)100, 60, 1, 167, 10, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9690) },
                    { 168, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9691), (short)30, (short)100, 39, 1, 168, 13, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9691) },
                    { 169, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9693), (short)30, (short)100, 80, 1, 169, 12, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9693) },
                    { 170, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9695), (short)30, (short)100, 76, 1, 170, 12, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9695) },
                    { 171, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9697), (short)30, (short)100, 48, 1, 171, 84, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9697) },
                    { 172, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9699), (short)30, (short)100, 9, 1, 172, 2, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9699) },
                    { 173, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9701), (short)30, (short)100, 9, 1, 173, 58, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9701) },
                    { 174, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9703), (short)30, (short)100, 64, 1, 174, 36, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9703) },
                    { 175, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9705), (short)30, (short)100, 64, 1, 175, 3, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9705) },
                    { 176, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9707), (short)30, (short)100, 60, 1, 176, 79, 1, 12, new DateTime(2025, 9, 22, 15, 11, 19, 463, DateTimeKind.Utc).AddTicks(9707) }
                });

            migrationBuilder.InsertData(
                table: "materia_plan_estudio",
                columns: new[] { "id", "created_at", "materia_id", "nivel_id", "plan_estudio_id", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(759), 1, 1, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(759) },
                    { 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(764), 2, 1, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(764) },
                    { 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(765), 3, 1, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(765) },
                    { 4, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(767), 4, 1, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(767) },
                    { 5, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(768), 5, 1, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(768) },
                    { 6, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(769), 6, 2, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(770) },
                    { 7, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(771), 7, 2, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(771) },
                    { 8, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(772), 8, 2, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(773) },
                    { 9, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(774), 9, 2, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(774) },
                    { 10, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(775), 10, 2, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(775) },
                    { 11, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(777), 11, 3, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(777) },
                    { 12, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(845), 12, 3, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(845) },
                    { 13, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(847), 13, 3, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(847) },
                    { 14, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(848), 14, 3, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(848) },
                    { 15, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(849), 15, 3, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(850) },
                    { 16, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(851), 16, 4, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(851) },
                    { 17, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(852), 17, 4, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(853) },
                    { 18, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(854), 18, 4, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(854) },
                    { 19, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(855), 19, 4, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(855) },
                    { 20, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(856), 20, 4, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(857) },
                    { 21, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(858), 21, 5, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(858) },
                    { 22, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(859), 22, 5, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(860) },
                    { 23, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(861), 23, 5, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(861) },
                    { 24, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(862), 24, 5, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(862) },
                    { 25, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(863), 25, 5, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(864) },
                    { 26, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(865), 26, 6, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(865) },
                    { 27, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(866), 27, 6, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(867) },
                    { 28, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(868), 28, 6, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(868) },
                    { 29, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(869), 29, 6, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(870) },
                    { 30, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(871), 30, 6, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(871) },
                    { 31, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(872), 31, 7, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(872) },
                    { 32, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(873), 32, 7, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(874) },
                    { 33, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(875), 33, 7, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(875) },
                    { 34, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(876), 34, 7, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(876) },
                    { 35, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(878), 38, 7, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(878) },
                    { 36, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(880), 36, 8, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(880) },
                    { 37, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(881), 37, 8, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(881) },
                    { 38, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(883), 44, 8, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(883) },
                    { 39, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(884), 39, 8, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(884) },
                    { 40, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(886), 35, 8, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(886) },
                    { 41, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(887), 41, 9, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(888) },
                    { 42, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(890), 42, 9, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(890) },
                    { 43, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(892), 43, 9, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(892) },
                    { 44, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(889), 40, 9, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(889) },
                    { 45, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(893), 100, 10, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(893) },
                    { 46, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(894), 1, 1, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(895) },
                    { 47, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(896), 2, 1, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(896) },
                    { 48, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(897), 3, 1, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(897) },
                    { 49, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(899), 4, 1, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(899) },
                    { 50, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(900), 5, 1, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(900) },
                    { 51, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(901), 6, 2, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(902) },
                    { 52, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(903), 7, 2, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(903) },
                    { 53, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(905), 8, 2, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(905) },
                    { 54, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(907), 9, 2, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(907) },
                    { 55, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(908), 10, 2, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(908) },
                    { 56, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(909), 11, 3, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(910) },
                    { 57, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(911), 12, 3, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(911) },
                    { 58, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(912), 13, 3, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(912) },
                    { 59, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(914), 14, 3, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(914) },
                    { 60, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(915), 15, 3, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(915) },
                    { 61, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(916), 16, 4, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(917) },
                    { 62, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(918), 17, 4, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(918) },
                    { 63, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(919), 18, 4, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(919) },
                    { 64, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(967), 19, 4, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(968) },
                    { 65, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(969), 20, 4, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(969) },
                    { 66, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(970), 21, 5, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(971) },
                    { 68, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(972), 23, 5, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(972) },
                    { 69, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(973), 24, 5, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(974) },
                    { 71, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(975), 53, 5, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(975) },
                    { 72, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(976), 54, 5, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(976) },
                    { 73, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(977), 26, 6, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(978) },
                    { 74, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(979), 27, 6, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(979) },
                    { 75, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(980), 28, 6, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(980) },
                    { 76, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(982), 29, 6, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(982) },
                    { 78, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(983), 55, 6, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(983) },
                    { 79, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(984), 31, 7, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(984) },
                    { 81, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(986), 33, 7, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(986) },
                    { 82, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(987), 34, 7, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(987) },
                    { 83, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(989), 38, 7, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(989) },
                    { 84, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(990), 56, 7, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(990) },
                    { 85, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(991), 36, 8, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(991) },
                    { 87, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(993), 35, 8, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(993) },
                    { 88, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(994), 39, 8, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(994) },
                    { 89, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(995), 44, 8, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(996) },
                    { 90, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(997), 57, 8, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(997) },
                    { 91, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(998), 41, 9, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(998) },
                    { 92, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1000), 42, 9, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1000) },
                    { 93, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1001), 43, 9, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1001) },
                    { 94, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1003), 40, 9, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1003) },
                    { 95, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1004), 100, 10, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1004) },
                    { 96, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1005), 1, 1, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1006) },
                    { 97, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1007), 2, 1, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1007) },
                    { 98, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1008), 3, 1, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1008) },
                    { 99, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1009), 4, 1, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1010) },
                    { 100, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1011), 5, 1, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1011) },
                    { 101, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1012), 6, 2, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1012) },
                    { 102, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1014), 7, 2, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1014) },
                    { 103, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1015), 8, 2, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1015) },
                    { 104, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1016), 9, 2, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1017) },
                    { 105, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1018), 10, 2, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1018) },
                    { 106, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1019), 11, 3, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1019) },
                    { 107, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1021), 12, 3, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1021) },
                    { 108, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1022), 13, 3, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1022) },
                    { 109, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1023), 75, 3, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1024) },
                    { 110, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1025), 76, 3, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1025) },
                    { 111, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1026), 16, 4, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1026) },
                    { 112, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1027), 17, 4, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1028) },
                    { 113, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1029), 18, 4, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1029) },
                    { 114, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1030), 19, 4, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1030) },
                    { 115, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1032), 77, 4, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1032) },
                    { 116, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1033), 21, 5, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1033) },
                    { 117, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1035), 24, 5, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1035) },
                    { 118, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1036), 78, 5, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1036) },
                    { 119, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1037), 79, 5, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1038) },
                    { 120, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1076), 80, 5, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1077) },
                    { 121, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1078), 81, 5, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1078) },
                    { 122, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1079), 82, 5, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1080) },
                    { 123, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1081), 28, 6, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1081) },
                    { 124, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1082), 29, 6, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1082) },
                    { 125, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1083), 26, 6, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1084) },
                    { 126, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1085), 83, 6, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1085) },
                    { 127, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1086), 84, 6, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1086) },
                    { 128, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1088), 85, 6, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1088) },
                    { 129, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1089), 86, 6, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1089) },
                    { 130, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1090), 99, 6, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1091) },
                    { 131, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1092), 34, 7, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1092) },
                    { 132, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1093), 33, 7, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1094) },
                    { 133, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1095), 31, 7, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1095) },
                    { 134, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1096), 87, 7, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1096) },
                    { 135, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1098), 88, 7, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1098) },
                    { 136, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1099), 89, 7, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1099) },
                    { 137, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1100), 90, 7, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1101) },
                    { 138, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1102), 39, 8, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1102) },
                    { 139, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1103), 36, 8, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1103) },
                    { 140, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1105), 91, 8, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1105) },
                    { 141, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1106), 92, 8, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1106) },
                    { 142, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1107), 93, 8, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1107) },
                    { 143, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1109), 94, 8, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1109) },
                    { 144, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1110), 95, 8, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1110) },
                    { 145, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1111), 41, 9, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1112) },
                    { 146, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1113), 42, 9, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1113) },
                    { 147, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1114), 96, 9, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1115) },
                    { 148, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1116), 97, 9, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1116) },
                    { 149, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1117), 98, 9, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1117) },
                    { 150, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1118), 100, 10, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(1119) }
                });

            migrationBuilder.InsertData(
                table: "prerequisito",
                columns: new[] { "materia_plan_estudio_id", "requisito_id", "created_at", "updated_at" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2372), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2372) },
                    { 7, 2, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2374), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2374) },
                    { 8, 3, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2375), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2375) },
                    { 9, 4, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2376), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2376) },
                    { 10, 5, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2377), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2377) },
                    { 11, 6, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2378), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2378) },
                    { 12, 7, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2379), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2379) },
                    { 12, 8, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2420), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2420) },
                    { 13, 8, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2421), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2422) },
                    { 13, 9, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2422), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2422) },
                    { 14, 9, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2423), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2423) },
                    { 16, 6, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2424), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2424) },
                    { 17, 11, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2426), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2426) },
                    { 18, 12, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2426), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2427) },
                    { 19, 13, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2427), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2427) },
                    { 20, 15, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2428), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2428) },
                    { 21, 16, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2429), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2429) },
                    { 22, 18, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2430), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2430) },
                    { 23, 18, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2431), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2431) },
                    { 24, 18, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2432), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2432) },
                    { 25, 18, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2433), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2433) },
                    { 26, 21, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2433), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2434) },
                    { 27, 24, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2434), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2435) },
                    { 28, 23, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2435), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2435) },
                    { 29, 24, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2436), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2436) },
                    { 30, 23, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2438), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2438) },
                    { 30, 25, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2437), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2437) },
                    { 31, 26, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2439), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2439) },
                    { 32, 23, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2441), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2441) },
                    { 32, 30, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2440), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2440) },
                    { 33, 28, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2441), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2442) },
                    { 34, 28, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2442), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2443) },
                    { 35, 27, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2443), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2443) },
                    { 35, 29, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2444), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2444) },
                    { 36, 31, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2445), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2445) },
                    { 37, 32, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2446), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2446) },
                    { 37, 35, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2447), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2447) },
                    { 38, 35, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2448), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2448) },
                    { 39, 34, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2448), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2449) },
                    { 40, 35, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2449), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2450) },
                    { 41, 36, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2450), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2450) },
                    { 41, 37, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2451), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2451) },
                    { 41, 38, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2452), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2452) },
                    { 41, 39, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2453), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2453) },
                    { 41, 40, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2454), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2454) },
                    { 42, 36, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2460), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2460) },
                    { 42, 37, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2461), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2461) },
                    { 42, 38, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2462), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2462) },
                    { 42, 39, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2462), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2463) },
                    { 42, 40, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2464), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2464) },
                    { 43, 36, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2465), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2465) },
                    { 43, 37, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2466), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2466) },
                    { 43, 38, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2466), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2467) },
                    { 43, 39, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2467), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2468) },
                    { 43, 40, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2468), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2468) },
                    { 44, 36, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2455), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2455) },
                    { 44, 37, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2455), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2456) },
                    { 44, 38, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2456), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2457) },
                    { 44, 39, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2457), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2457) },
                    { 44, 40, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2459), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2459) },
                    { 45, 41, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2469), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2469) },
                    { 45, 42, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2471), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2471) },
                    { 45, 43, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2472), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2472) },
                    { 45, 44, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2470), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2470) },
                    { 51, 46, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2475), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2475) },
                    { 52, 47, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2476), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2476) },
                    { 53, 48, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2473), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2474) },
                    { 54, 49, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2472), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2473) },
                    { 55, 50, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2474), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2474) },
                    { 56, 51, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2481), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2481) },
                    { 57, 52, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2477), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2478) },
                    { 57, 53, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2477), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2477) },
                    { 58, 53, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2478), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2479) },
                    { 58, 54, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2480), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2480) },
                    { 59, 54, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2481), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2482) },
                    { 61, 51, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2485), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2485) },
                    { 62, 56, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2486), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2486) },
                    { 63, 57, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2483), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2483) },
                    { 64, 58, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2484), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2484) },
                    { 65, 60, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2482), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2483) },
                    { 66, 61, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2490), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2490) },
                    { 68, 63, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2488), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2489) },
                    { 69, 63, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2489), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2490) },
                    { 71, 65, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2487), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2487) },
                    { 72, 65, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2488), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2488) },
                    { 73, 66, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2495), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2495) },
                    { 74, 69, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2494), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2494) },
                    { 75, 68, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2493), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2493) },
                    { 76, 69, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2492), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2492) },
                    { 78, 71, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2491), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2491) },
                    { 79, 73, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2498), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2498) },
                    { 81, 75, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2495), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2496) },
                    { 82, 75, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2499), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2499) },
                    { 83, 74, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2500), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2500) },
                    { 83, 76, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2501), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2501) },
                    { 84, 74, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2496), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2497) },
                    { 84, 76, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2497), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2497) },
                    { 85, 79, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2501), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2502) },
                    { 87, 83, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2502), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2503) },
                    { 88, 82, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2503), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2504) },
                    { 89, 83, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2504), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2504) },
                    { 90, 78, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2505), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2505) },
                    { 90, 83, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2506), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2506) },
                    { 92, 85, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2510), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2511) },
                    { 92, 90, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2510), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2510) },
                    { 94, 87, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2509), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2509) },
                    { 94, 88, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2508), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2508) },
                    { 94, 89, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2507), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2507) },
                    { 95, 91, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2511), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2511) },
                    { 95, 92, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2513), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2513) },
                    { 95, 93, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2514), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2514) },
                    { 95, 94, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2512), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2512) },
                    { 101, 96, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2515), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2515) },
                    { 102, 97, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2516), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2516) },
                    { 103, 98, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2516), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2517) },
                    { 104, 99, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2517), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2517) },
                    { 105, 100, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2518) },
                    { 106, 101, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2519), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2519) },
                    { 107, 102, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2520), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2520) },
                    { 107, 103, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2521), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2521) },
                    { 108, 103, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2522), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2522) },
                    { 108, 104, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2522), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2523) },
                    { 109, 104, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2523), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2524) },
                    { 110, 104, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2524), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2524) },
                    { 111, 101, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2526), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2526) },
                    { 112, 106, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2525), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2525) },
                    { 113, 96, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2528), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2528) },
                    { 113, 107, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2527), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2527) },
                    { 114, 108, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2528), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2529) },
                    { 115, 109, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2529), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2530) },
                    { 116, 111, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2530), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2530) },
                    { 117, 113, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2531), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2531) },
                    { 118, 115, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2532), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2532) },
                    { 119, 115, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2533), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2533) },
                    { 120, 106, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2558), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2558) },
                    { 120, 110, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2533), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2534) },
                    { 123, 116, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2559), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2559) },
                    { 124, 117, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2560), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2560) },
                    { 125, 121, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2561), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2561) },
                    { 126, 119, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2562), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2562) },
                    { 127, 112, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2564), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2564) },
                    { 127, 120, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2563), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2563) },
                    { 131, 120, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2567), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2568) },
                    { 131, 123, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2566), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2567) },
                    { 132, 123, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2565), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2566) },
                    { 133, 125, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2565), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2565) },
                    { 134, 114, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2569), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2569) },
                    { 134, 126, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2568), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2568) },
                    { 135, 120, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2571), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2571) },
                    { 135, 127, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2570), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2570) },
                    { 138, 131, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2573), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2574) },
                    { 139, 133, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2572), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2572) },
                    { 140, 131, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2573), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2573) },
                    { 141, 131, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2574), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2575) },
                    { 141, 135, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2575), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2575) },
                    { 142, 135, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2576), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2576) },
                    { 145, 138, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2579), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2579) },
                    { 145, 139, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2577), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2577) },
                    { 145, 140, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2578), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2578) },
                    { 145, 141, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2580), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2580) },
                    { 145, 142, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2580), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2581) },
                    { 146, 138, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2583), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2583) },
                    { 146, 139, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2581), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2581) },
                    { 146, 140, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2582), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2582) },
                    { 146, 141, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2584), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2584) },
                    { 146, 142, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2585), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2585) },
                    { 147, 138, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2587), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2588) },
                    { 147, 139, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2586), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2586) },
                    { 147, 140, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2587), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2587) },
                    { 147, 141, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2588), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2588) },
                    { 147, 142, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2589), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2589) },
                    { 148, 138, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2592), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2592) },
                    { 148, 139, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2590), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2590) },
                    { 148, 140, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2591), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2591) },
                    { 148, 141, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2593), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2593) },
                    { 148, 142, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2593), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2594) },
                    { 149, 138, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2596), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2596) },
                    { 149, 139, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2594), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2595) },
                    { 149, 140, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2595), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2595) },
                    { 149, 141, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2597), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2597) },
                    { 149, 142, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2598), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2598) },
                    { 150, 145, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2599), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2599) },
                    { 150, 146, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2600), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2601) },
                    { 150, 147, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2600), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2600) },
                    { 150, 148, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2601), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2601) },
                    { 150, 149, new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2602), new DateTime(2025, 9, 22, 15, 11, 19, 464, DateTimeKind.Utc).AddTicks(2602) }
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
