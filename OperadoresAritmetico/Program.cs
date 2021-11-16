using System;

namespace OperadoresAritmetico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores Aritmético");

            //>> * +Adição,
            //>> - Subtração,
            //>> * Multiplicação,
            //>> / Divisão,
            //>> % Resto da Divisão*
            // >> % <Tem precedência maior que +-            

            int num = 10 + 5 * 2;
            Console.WriteLine(num);

            int num1 = 30 / 2 + 2;
            Console.WriteLine(num1);

            //resultado  é (1) porque reconhece como numero int
            int num2 = 10 / 8;
            Console.WriteLine(num2);

            double teste = (double)12 / 8;
            Console.WriteLine(teste);

            // resto da divisão(mod)
            int num3 = 26 % 4; 
            Console.WriteLine(num3);
            
            int num4 = 5 + 15 * 2;
            Console.WriteLine(num4);

            //quebrando a precedência 
            int num5 = 10 % (4 + 2);
            Console.WriteLine(num5);

        }
    }
}
