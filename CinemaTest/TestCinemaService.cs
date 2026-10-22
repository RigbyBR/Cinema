using AutoMapper;
using CinemaDomain;
using CinemaReposytory.Base;
using CinemaReposytory.Context;
using CinemaReposytory.Reposytory;
using CinemaService.Base;
using CinemaService.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.Text.Json;

namespace CinemaTest
{
    [TestClass]
    public class TestCinemaService
    {
        private ServiceCollection services;

        public ServiceProvider ConfigureServices()
        {
            var conStr = $"Host=localhost;Port=5432;Database=CinemaDB;Username=postgres;Password=ifsp";
            services = new ServiceCollection();

            services.AddDbContext<MyBDContext>(options => options.UseNpgsql(conStr));
            services.AddScoped<IBaseRepository<Genero>, BaseRepository<Genero>>();
            services.AddScoped<IBaseService<Genero>, BaseService<Genero>>();
            services.AddSingleton(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Genero, Genero>();
            }, NullLoggerFactory.Instance).CreateMapper());

            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestGeneroService()
        {
            var serviceProvider = ConfigureServices();
            var generoService = serviceProvider.GetService<IBaseService<Genero>>();
            var genero = new Genero { id = 4, Nome = "Romance" };
            var result = generoService.Create<Genero, Genero, GeneroValidator>(genero);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
        

    }
}