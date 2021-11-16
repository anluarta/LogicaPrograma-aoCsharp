using System;

namespace IFeElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Condição If e Else");

            int idade = int.Parse(Console.ReadLine());

            if (idade < 0)
            {
                Console.WriteLine(" Idade Inválida ");
            }
            else if (idade < 13)
            {
                Console.WriteLine(" Essa pessoa é Criança ");
            }
            else if (idade < 18)
            {
                Console.WriteLine(" Essa Pessoa é Adolescente ");
            }
            else
            {
                Console.WriteLine(" Essa pessoa é Adulto ");
            }
            Console.ReadLine();


        }
    }
}
