using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class HorarioMateriaConfiguration : IEntityTypeConfiguration<HorarioMateria>
    {
        public void Configure(EntityTypeBuilder<HorarioMateria> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.CuposDisponibles).IsRequired();
            b.Property(x => x.CuposTotal).IsRequired();
            b.Property(x => x.NroAula);

            b.Property(x => x.GestionId).IsRequired();
            b.Property(x => x.GrupoMateriaId).IsRequired();
            b.Property(x => x.ModuloId).IsRequired();
            b.Property(x => x.HorarioId).IsRequired();

            b.HasOne(x => x.Gestion)
             .WithMany(g => g.HorariosMateria)
             .HasForeignKey(x => x.GestionId);

            b.HasOne(x => x.GrupoMateria)
             .WithMany(gm => gm.HorariosMateria)
             .HasForeignKey(x => x.GrupoMateriaId);

            b.HasOne(x => x.Modulo)
             .WithMany(m => m.HorariosMateria)
             .HasForeignKey(x => x.ModuloId);

            b.HasOne(x => x.Docente)
             .WithMany(d => d.HorariosMateria)
             .HasForeignKey(x => x.DocenteId)
             .OnDelete(DeleteBehavior.SetNull); // opcional

            b.HasOne(x => x.Horario)
             .WithMany(h => h.HorariosMateria)
             .HasForeignKey(x => x.HorarioId);

            b.HasMany(x => x.HorarioMateriaInscripciones)
             .WithOne(hmi => hmi.HorarioMateria)
             .HasForeignKey(hmi => hmi.HorarioMateriaId);
        }
    }
}
