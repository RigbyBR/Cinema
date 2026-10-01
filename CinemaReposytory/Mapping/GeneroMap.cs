using Microsoft.EntityFrameworkCore;
using CinemaDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaReposytory.Mapping
{
    public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Genero");
            builder.HasKey(x => x.id);
            builder.Property(x => x.Nome)
                //.HasColumnName("NomeDoGenero")
                .IsRequired(true)
                .HasMaxLength(50);
     
        }
    }
}
