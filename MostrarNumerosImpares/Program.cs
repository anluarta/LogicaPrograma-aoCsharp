using System;

namespace MostrarNumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrar Numero Impares");

            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int num1;

            num1 = min;

            while (num1 <= max)
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine(num1);
                }
                num1 = num1 + 1;
            }

        }
    }
}
