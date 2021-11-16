using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABUADA!");

            int tabuada, quantMultiplicar;

            tabuada = int.Parse(Console.ReadLine());
            quantMultiplicar = int.Parse(Console.ReadLine());

            for (int inicial = 1; inicial <= quantMultiplicar; inicial++)
                Console.WriteLine("{0} x {1} = {2}", tabuada, inicial, (tabuada * inicial));

            Console.ReadKey();

        }
    }
}
