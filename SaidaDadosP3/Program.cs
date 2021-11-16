using System;

namespace SaidaDadosP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Saída de Dados P3");

            Console.WriteLine("Digite uma frase");
            string x = Console.ReadLine();

            //Split é tudo que separar a frase com "|" ou outro caracteres que eu determinar.
            string[] y = x.Split('|');

            string name1 = y[0];
            string name2 = y[1];
            string name3 = y[2];
            
            

            Console.WriteLine(" ========================= ");

            Console.WriteLine(" Sua resposta foi: ");
            Console.WriteLine(y);

            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);
            //Console.WriteLine(name4);
            //Console.WriteLine(name5);

            Console.ReadKey();
        }
    }
}
