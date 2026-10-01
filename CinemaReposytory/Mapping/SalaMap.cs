using Microsoft.EntityFrameworkCore;
using CinemaDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaReposytory.Mapping
{
    public class SalaMap : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.ToTable("Sala");
            builder.HasKey(x => x.id);
            builder.Property(x => x.Numero);
            builder.Property(x => x.Capacidade);
            builder.Property(x => x.Fileiras);
            builder.Property(x => x.Assentos);


        }
    }
}
