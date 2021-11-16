using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write(" Entre com Numero da Conta:  ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write(" Entre com Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write(" Haverá Depósito (S/N) ?: ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine();
                Console.Write(" Entre com Valor do Depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine(" Dados da Conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write(" Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine(" Dados da Conta Atualizado: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write(" Entre com valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine(" Dados da Conta Atualizado: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine(" Deseja Realizar mais um Depósito ou Saque ? (S/N) ");
            char operacao = char.Parse(Console.ReadLine());

           
        }
    }
}
