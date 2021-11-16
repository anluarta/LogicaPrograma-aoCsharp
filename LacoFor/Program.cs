using System;

namespace LacoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laço For");

            int numero = 0;

            for (numero=0; numero <= 50; numero++)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine(" Programa parou");
        }
    }
}
