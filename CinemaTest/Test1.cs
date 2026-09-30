using CinemaDomain;
using Mono.Cecil.Cil;
using System.Diagnostics;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace CinemaTest
{
    [TestClass]
    public sealed class Test1
    {
    private JsonSerializerOptions OptionsJson()
        {
            return new JsonSerializerOptions { WriteIndented = true };
        }

        [TestMethod]
        public void TestGenero()
        {
            var genero = new Genero { id = 1, Nome = "Suspense"};
            var generoJson = JsonSerializer.Serialize(genero,OptionsJson());
            Debug.WriteLine(generoJson);
            Assert.IsNotNull(generoJson);
        }
        [TestMethod]
        public void TestFilme()
        {
            var genero1 = new Genero { id = 1, Nome = "Suspense" };
            var genero2 = new Genero { id = 2, Nome = "Comedia" };
            var filme = new Filme { id = 1, Nome = "Jurassic Park", Genero = genero1, Classificacao = "18+", Duracao = 120 };
            var filmeJson = JsonSerializer.Serialize(filme, OptionsJson());
            Debug.WriteLine(filmeJson);
            Assert.IsNotNull(filmeJson);
        }

        [TestMethod]
        public void TestSala()
        {
            var sala = new Sala {id = 2, Assentos = 50, Capacidade = 100, Fileiras = 15, Numero = 1 };
            var salaJson = JsonSerializer.Serialize(sala, OptionsJson());
            Debug.WriteLine(salaJson);
            Assert.IsNotNull(salaJson);
        }

        [TestMethod]
        public void TestSessao()
        {
            var genero3 = new Genero {id = 3, Nome = "Acao" };
            var filme = new Filme { id = 4, Nome = "Hot wheels Acceleracers", Genero = genero3, Classificacao = "L", Duracao = 105 };
            var sala = new Sala { id = 2, Assentos = 40, Capacidade = 80, Fileiras = 16, Numero = 2 };
            var sessao = new Sessao { Data = new DateTime(2026, 10, 1, 19, 20, 00), Preco = 40, id = 3, Sala = sala, Filme = filme };
            var sessaoJson = JsonSerializer.Serialize(sessao, OptionsJson());
            Debug.WriteLine(sessaoJson);
            Assert.IsNotNull(sessaoJson);
        }

        [TestMethod]
        public void TestIngresso()
        {
            var genero4 = new Genero {id = 4, Nome = "comedia" };
            var filme = new Filme {id = 4, Nome = "Gente Grande", Genero = genero4, Classificacao = "L", Duracao = 135 };
            var sala = new Sala { id = 2, Assentos = 40, Capacidade = 80, Fileiras = 16, Numero = 2 };
            var sessao = new Sessao { Data = new DateTime(2026, 10, 1, 19, 20, 00), Preco = 50, id = 3, Sala = sala, Filme = filme};
            var ingresso = new Ingresso { Documento = "Rg", FormaPagamento = "Cartao/Pix", ValorTotal = 50, DataCompra = new DateTime(2026,9,15,18,15,30), IngressoItens = new List<IngressoItem> (),id = 2, Sessao = sessao, };
            var ingressoitem = new IngressoItem {Assento = 17, Fileira = 8, MeiaEntrada = false, };
            var ingressoJson = JsonSerializer.Serialize(ingresso, OptionsJson());
            Debug.WriteLine(ingressoJson);
            Assert.IsNotNull(ingressoJson);
        }
    }
}
