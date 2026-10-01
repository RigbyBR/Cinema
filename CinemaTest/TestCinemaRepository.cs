using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;
using System.Text.Json;

namespace CinemaTest
{
    [TestClass]
    public class TestCinemaRepository
    {
        public partial class MyBDContext : DbContext
        {
            public DbSet<Genero> Genero { get; set; }
            public DbSet<Filme> Filme { get; set; }
            public DbSet<Sala> Sala { get; set; }
            public DbSet<Sessao> Sessao { get; set; }
            public DbSet<Ingresso> Ingresso { get; set; }
            public DbSet<IngressoItem> IngressoItem { get; set; }
            public MyBDContext()
            {
                Database.EnsureCreated(); 
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                var server = "localhost";
                var port = "5432";
                var username = "postgres";
                var password = "ifsp";
                var database = "CinemaDB";
                var conStr = $"Host={server};Port={port};Database={database};Username={username};Password={password};";

                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseNpgsql(conStr);
                }
            }
        }
        [TestMethod]
        public void CriarBanco()
        {
            using (var db = new MyBDContext())
            {
                Assert.IsNotNull(db);
            }
        }
        [TestMethod]
        public void insertGenero()
        {
            using(var db = new MyBDContext())
            {
                var genero = new Genero { id = 1, Nome = "Comédia" };
                db.Genero.Add(genero);
                genero = new Genero { id = 2, Nome = "Terror" };
                db.Genero.Add(genero);
                genero = new Genero { id = 3, Nome = "Ação" };
                db.Genero.Add(genero);
                db.SaveChanges();
            }
        }
        [TestMethod]
        public void ListarGenero()
        {
            using (var db = new MyBDContext())
            {
                foreach (var item in db.Genero)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }

    }
}