using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores Lógicos");

            bool cond1 = 2 > 3 || 4 != 5;  // true
            bool cond2 = 10 > 5 && 5 > 10; //false
            bool cond3 = !(2 > 3) && 4 != 5; //true    

            Console.WriteLine(cond1);
            Console.WriteLine(cond2);
            Console.WriteLine(cond3);

            Console.WriteLine("===========================");

            bool cond4 = 10 < 5; //false
            bool cond5 = cond1 || cond2 && cond3;//true

            Console.WriteLine(cond4);
            Console.WriteLine(cond5);


        }
    }
}
