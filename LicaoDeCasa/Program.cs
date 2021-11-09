using System;

namespace LicaoDeCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int valor = aleatorio.Next(1, 20);

            Console.WriteLine("Digite um numero de 1 a 20");
            int numero = int.Parse(Console.ReadLine());                                            

            if (numero == valor)
            {
                Console.WriteLine("Parabéns vc acertou ");
            }
            else
            {
                Console.WriteLine("Não foi dessa vez");
            }
            Console.WriteLine("Você Digitou o Número:" + numero);
            Console.WriteLine("O Resultado Foi:" + valor);

            Console.WriteLine(" Tecle S para jogar novamente ou Qualquer tecla para sair ");
            string texto = Console.ReadLine();

            if (texto == "s")
            {
                Console.WriteLine("Vamos Lá tente Dinovo");

                Random aleatorio2 = new Random();
                int valor2 = aleatorio2.Next(1, 20);

                Console.WriteLine("Digite um numero de 1 a 20");             
                int numero1 = int.Parse(Console.ReadLine());               

                if (numero1== valor2)
                {
                    Console.WriteLine("Parabéns vc acertou ");
                }
                else
                {
                    Console.WriteLine("Que Pena, Você não acertou novamente.fim de jogo");
                }
                Console.WriteLine("Você Digitou o Número:" + numero1);
                Console.WriteLine("O Resultado Foi:" + valor2);
                Console.WriteLine("Fim de jogo clica 2x em qualquer tecla para sair<> Até a Próxima");
            }
            else
            {
                Console.WriteLine("Fim de Jogo < Até mais >");
            }

            Console.ReadKey();
        }
        
    }
}
