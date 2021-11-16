using System;

namespace OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores Atribuição");

            int a = 100;

            a += 100;
            a -= 50;
            a *= 2;
            a /= 2;
            a--;
            a++;
            Console.WriteLine(a);

            string s = "ABC";
            s += "Marcel";
            Console.WriteLine(s);

        }
    }
}
