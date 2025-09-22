using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class JobResultConfiguration : IEntityTypeConfiguration<JobResult>
    {
        public void Configure(EntityTypeBuilder<JobResult> b)
        {
            // PK
            b.HasKey(x => x.Id);

            // IdempotencyKey: índice no único
            b.Property(x => x.IdempotencyKey)
                .IsRequired()
                .HasMaxLength(200);

            b.HasIndex(x => x.IdempotencyKey)
                .HasDatabaseName("ix_job_results_idemkey");

            // Queue
            b.Property(x => x.Queue)
                .IsRequired()
                .HasMaxLength(100);

            // Resource
            b.Property(x => x.Resource)
                .IsRequired()
                .HasMaxLength(100);

            // Operation
            b.Property(x => x.Operation)
                .IsRequired()
                .HasMaxLength(50);

            // Status (enum -> string o int según tu modelo)
            b.Property(x => x.Status)
                .IsRequired()
                .HasConversion<string>() // guarda como texto
                .HasMaxLength(20);

            // DataJson (contenido dinámico, puede ser largo)
            b.Property(x => x.DataJson)
                .HasColumnType("text");

            // Error (mensaje de error, puede ser largo)
            b.Property(x => x.Error)
                .HasColumnType("text");

            // Timestamps
            b.Property(x => x.CreatedUtc)
                .IsRequired();

            b.Property(x => x.StartedUtc)
                .IsRequired(false);

            b.Property(x => x.FinishedUtc)
                .IsRequired(false);

            // Nombre de la tabla explícito (opcional)
            b.ToTable("job_results");
        }
    }
}
