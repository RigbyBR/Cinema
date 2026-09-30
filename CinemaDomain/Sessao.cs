namespace CinemaDomain
{
    public class Sessao : BaseEbtity
    {
        public System.DateTime Data { get; set; }


        public Filme Filme { get; set; }


        public Sala Sala { get; set; }


        public decimal Preco { get; set; }

    }
}