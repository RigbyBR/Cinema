using CinemaDomain;
using CinemaReposytory.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CinemaReposytory.Context
{
    
        public partial class MyBDContext : DbContext
        {
            public DbSet<Genero> Genero { get; set; }
            public DbSet<Filme> Filme { get; set; }
            public DbSet<Sala> Sala { get; set; }
            public DbSet<Sessao> Sessao { get; set; }
            public DbSet<Ingresso> Ingresso { get; set; }
            public DbSet<IngressoItem> IngressoItem { get; set; }
            public MyBDContext(DbContextOptions<MyBDContext> options) : base(options) 
           
            {
                Database.EnsureCreated();
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genero>(new GeneroMap().Configure);
            modelBuilder.Entity<Filme>(new FilmeMap().Configure);
            modelBuilder.Entity<Sala>(new SalaMap().Configure);
            modelBuilder.Entity<Sessao>(new SessaoMap().Configure);
            modelBuilder.Entity<Ingresso>(new IngressoMap().Configure);
            modelBuilder.Entity<IngressoItem>(new IngressoItemMap().Configure);
        }

        }
    }

