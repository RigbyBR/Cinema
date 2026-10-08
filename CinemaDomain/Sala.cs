using CinemaDomain.Base;

namespace CinemaDomain
{
    public class Sala : BaseEntity
    {
        public int Numero { get; set; }


        public int Capacidade { get; set; }


        public int Fileiras { get; set; }


        public int Assentos { get; set; }

    }
}