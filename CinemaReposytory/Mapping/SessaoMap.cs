using Microsoft.EntityFrameworkCore;
using CinemaDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaReposytory.Mapping
{
    public class SessaoMap : IEntityTypeConfiguration<Sessao>
    {
        public void Configure(EntityTypeBuilder<Sessao> builder)
        {
            builder.ToTable("Sessao");
            builder.HasKey(x => x.id);
            builder.Property(x => x.Data);
            builder.Property(x => x.Sala);
            builder.Property(x => x.Preco);


        }
    }
}
