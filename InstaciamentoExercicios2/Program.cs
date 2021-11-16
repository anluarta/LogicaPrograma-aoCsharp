using System;
using System.Globalization;

namespace InstaciamentoExercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados de dois funcionários");

            var funcionario1 = new Funcionario();
            funcionario1.Nome = "Marcel";
            funcionario1.Salario = 6300.00;

            var funcionario2 = new Funcionario();
            funcionario2.Nome = "Carlos";
            funcionario2.Salario = 5100.00;

            var valormediasal = (funcionario1.Salario + funcionario2.Salario) / 2.0;
            Console.WriteLine("A média salarial é :" + valormediasal.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
