using System;

namespace IFeElseP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testar se numero é par: o resto da divisão por dois é igual a zero.");

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}
