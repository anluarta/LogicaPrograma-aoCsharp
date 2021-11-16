using System;
using System.Globalization;

namespace SaidaDadosP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saida de Dados P4");

            //Fazer programa p/executar a seguinte intereção com o usuário, lendo os valores destacados em vermelho,
            // e depois mostrar os dados na tela:
            // Seu nome, quantidade de quartos, preço de um produto, seu ultimo nome, idade e altura na mesma linha.

            Console.WriteLine(" Digite seu nome Completo :");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quarto tem na Residência? ");
            int num_quarto = int.Parse(Console.ReadLine());

            Console.WriteLine(" Qual valor do Produto?");
            double prod = double.Parse(Console.ReadLine());

            Console.WriteLine(" Digite seu ultimo Nome,idade e altura:");
            string frasecomp = Console.ReadLine();

            string[] frasecort = frasecomp.Split(",");           

            Console.WriteLine(" Resultado Esperado ");

            Console.WriteLine(name);
            Console.WriteLine(num_quarto);
            Console.WriteLine(prod.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(frasecomp);

            Console.ReadKey();


        }
    }
}
