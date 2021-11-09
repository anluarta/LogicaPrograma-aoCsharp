using System;

namespace LicaoDeCasaWhile
{
    class Program
    {
        static void Main(string[] args)
        {         
           
            Random aleatorio = new Random();
            int dado = aleatorio.Next(1,10);

            var numero = 0;
            while (dado != numero)
            {
               Console.Clear();          
               Console.WriteLine("Digite um numero de 1 a 10");
               numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Parabéns vc acertou");
            Console.WriteLine("Você Digitou o Número:" + numero);
            Console.WriteLine("O Resultado do Random Foi:" + dado);

            Console.ReadKey();
        }
        
    }
}

