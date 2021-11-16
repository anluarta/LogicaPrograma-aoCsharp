using System;
using System.Globalization;

namespace SaidaDadosP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saída de Dados");

            char genero = 'M';
            int idade = 32;
            double saldo = 10.35784333;
            string nome = "Maria";

            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);

            // SERVE PARA DELIMITAR CASAS DECIMAIS EX: LIMITA DUAS CASAS  >>
            Console.WriteLine(saldo.ToString("F2"));

            // LIMITA 6 CASAS DECIMAIS >> a assim vai.
            Console.WriteLine(saldo.ToString("F6"));

            // imprimi como ponto em vez de vírgula (independente de país.) //format numero
            Console.WriteLine(saldo.ToString("F6", CultureInfo.InvariantCulture));

            /*ToString() forneça uma representação simplificada e direta do estado do objeto em questão. Uma maneira de atingir este objetivo é fazer 
            com que a saída forneça o valor atual dos atributos do objeto.*/

            Console.Write("Testando");//não coloca quebra de linha.
            Console.WriteLine("MARCEL SILVA"); // Automaticamente ele faz quebra de linha
            Console.WriteLine("Boa Tarde");

        }
    }
}
