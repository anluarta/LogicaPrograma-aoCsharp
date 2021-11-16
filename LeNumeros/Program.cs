using System;

namespace LeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Lê numeros Par ou Impar");

            int numero = 0;

            for (numero = 1; numero <= 50; numero++)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(" PAR   : " + numero);
                }
                else
                {
                    Console.WriteLine(" IMPAR : " + numero);
                }

            }
            Console.WriteLine(" Programa Finalizado ");

        }
    }
}
