using System;
using LojaMarcel.Entintades.Enums;


namespace LojaMarcel.Entindades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }

        public override string ToString()
        {
            return Id + "," + Momento + "," + Status;
        }
    }
}
