using Microsoft.EntityFrameworkCore;
using CinemaDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaReposytory.Mapping
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filme");
            builder.HasKey(x => x.id);
            builder.Property(x => x.Nome)
                .IsRequired(true)
                .HasMaxLength(50);
            builder.Property(x => x.Classificacao)
                .IsRequired(false)
                .HasMaxLength(20);
            builder.HasOne(x => x.Genero) // relacionamentro com o genero
                .WithMany()
                .IsRequired(true);
            builder.Property(x => x.Duracao)
                .HasMaxLength(120);


        }
    }
}
