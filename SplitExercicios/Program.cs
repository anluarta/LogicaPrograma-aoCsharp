using System;

namespace SplitExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE três palavras usando - para separar as plavras entre elas. Depois digite sem traço na próximO DEBUG");
            string x = Console.ReadLine();
            string[] y = x.Split('-');

            string name1 = y[0];
            string name2 = y[1];
            string name3 = y[2];


            Console.WriteLine(" ========================= ");


            Console.WriteLine(" Sua resposta foi: ");
            Console.WriteLine(y);
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);

        }
    }
}
