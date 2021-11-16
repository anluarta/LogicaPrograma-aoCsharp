using System;

namespace SaidaDadosP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // imprimindo de uma forma eficiente

            int idade = 32;
            double saldo = 10.35784333;
            string nome = "Maria";


            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //Placeholders
            Console.WriteLine("A Sr " + nome + " tem " + idade + " Anos e tem um saldo de  " + saldo); //Concatenação
            Console.WriteLine($"{nome} tem  {idade} anos e tem o saldo igual a {saldo:F2} reais"); //interpolação 
        }
    }
}
