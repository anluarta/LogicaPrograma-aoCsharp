using System;
using System.Globalization;

namespace IfeeElseP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média de Nota");

            double notaprova1 = double.Parse(Console.ReadLine());
            double notaprova2 = double.Parse(Console.ReadLine());
            double notaprova3 = double.Parse(Console.ReadLine());
            double notaprova4 = double.Parse(Console.ReadLine());

            double media = (notaprova1 + notaprova2 + notaprova3 + notaprova4) / 4;
            Console.WriteLine(" Resultado Aluno foi : " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media > 6.0)
            {
                Console.WriteLine(" Aluno Aprovado ");
            }
            else
            {
                Console.WriteLine(" Aluno Reprovado ");
            }

        }
    }
}
