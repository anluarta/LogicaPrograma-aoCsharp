using System;
using System.Globalization;

namespace ProdutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var produto = new Produto();

            Console.WriteLine(" Entre com os dados do Produto ");

            Console.Write(" Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write(" Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write(" Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Dados do Produto : " + produto );

            Console.WriteLine("=====================================================================================");

            Console.WriteLine(" Digite Quantidade de produto para acrescentar: ");
            Console.Write(" Adicionar: ");
            int quantidades = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(quantidades);
            Console.WriteLine(" Dados Atualizado: " + produto);

            Console.WriteLine();
            Console.WriteLine(" Digite Quantidade de produto para remover ");
            Console.Write(" Remover: ");
            quantidades = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(quantidades);
            Console.WriteLine(" Dados Atualizado: " + produto);

        }
    }
}
