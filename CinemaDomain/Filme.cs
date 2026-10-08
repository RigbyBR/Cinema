using CinemaDomain.Base;

namespace CinemaDomain
{
    public class Filme : BaseEntity
    {
        public string Nome { get; set; }


        public string Classificacao { get; set; }


        public Genero Genero { get; set; }


        public int Duracao { get; set; }

    }
}