using System;
using System.Globalization;

namespace ExerciciosDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desconto a Realizar");

            double preco = double.Parse(Console.ReadLine());


            if (preco > 100)
            {
                double desconto = preco * 0.50;
            }

            Console.WriteLine(desconto.ToString("F2"), CultureInfo.InvariantCulture));

        }
    }
}
