using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class JobResultConfiguration : IEntityTypeConfiguration<JobResult>
    {
        public void Configure(EntityTypeBuilder<JobResult> b)
        {
            // Especificar el nombre de la tabla en PostgreSQL
            b.ToTable("job_results");
            
            // PK
            b.HasKey(x => x.Id);
            
            // Configurar la columna Id
            b.Property(x => x.Id)
             .HasColumnName("id");

            // Configurar columnas de BaseEntity
            b.Property(x => x.CreatedAt)
             .HasColumnName("created_at");
             
            b.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at");

            // IdempotencyKey: índice no único
            b.Property(x => x.IdempotencyKey)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("idempotency_key");

            b.HasIndex(x => x.IdempotencyKey)
                .HasDatabaseName("ix_job_results_idemkey");

            // Queue
            b.Property(x => x.Queue)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("queue");

            // Resource
            b.Property(x => x.Resource)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("resource");

            // Operation
            b.Property(x => x.Operation)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("operation");

            // Status (enum -> string o int según tu modelo)
            b.Property(x => x.Status)
                .IsRequired()
                .HasConversion<string>() // guarda como texto
                .HasMaxLength(20)
                .HasColumnName("status");

            // DataJson (contenido dinámico, puede ser largo)
            b.Property(x => x.DataJson)
                .HasColumnType("text")
                .HasColumnName("data_json");

            // Error (mensaje de error, puede ser largo)
            b.Property(x => x.Error)
                .HasColumnType("text")
                .HasColumnName("error");

            // Timestamps
            b.Property(x => x.CreatedUtc)
                .IsRequired()
                .HasColumnName("created_utc");

            b.Property(x => x.StartedUtc)
                .IsRequired(false)
                .HasColumnName("started_utc");

            b.Property(x => x.FinishedUtc)
                .IsRequired(false)
                .HasColumnName("finished_utc");
        }
    }
}
