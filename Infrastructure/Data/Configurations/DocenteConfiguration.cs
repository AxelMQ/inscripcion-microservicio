using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class DocenteConfiguration : IEntityTypeConfiguration<Docente>
    {
        public void Configure(EntityTypeBuilder<Docente> b)
        {
            b.HasKey(x => x.Id);

            b.Property(x => x.Nombre).IsRequired().HasMaxLength(125);
            b.Property(x => x.Ci).IsRequired();

            b.HasMany(x => x.HorariosMateria)
             .WithOne(hm => hm.Docente)
             .HasForeignKey(hm => hm.DocenteId)
             .OnDelete(DeleteBehavior.SetNull); // FK opcional
        }
    }
}
