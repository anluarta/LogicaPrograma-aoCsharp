using System;
using LojaMarcel.Entindades;

namespace LojaMarcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 1080,
                Momento = DateTime.Now,
                Status = StatusPedido.PagamentoPendente,

            };
            Console.WriteLine(pedido);

            string texto = StatusPedido.PagamentoPendente.ToString();//conversão de uma valor enumeração para string.
            Console.WriteLine(texto);

            StatusPedido statuspedido = Enum.Parse<StatusPedido>("Entregue");// conversão string para enumerado
            Console.WriteLine(statuspedido);
        }
    }
}
