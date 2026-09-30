namespace CinemaDomain
{
    public class Ingresso : BaseEbtity
    {
        public string Documento { get; set; }


        public Sessao Sessao { get; set; }


        public System.DateTime DataCompra { get; set; }


        public System.Collections.Generic.List<IngressoItem> IngressoItens { get; set; }


        public decimal ValorTotal { get; set; }


        public string FormaPagamento { get; set; }

    }
}