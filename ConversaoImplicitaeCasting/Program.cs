using System;

namespace ConversaoImplicitaeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão Implicita E Casting");

            //conversão implícita entre tipos que pode ser realizada automaticamente é conhecida como Implícita :
            byte valor1 = 10;
            byte valor2 = 23;
            long total = valor1 + valor2;
            Console.WriteLine(total);

            //Conversão explícita entre tipos que pode ser feita manualmente, em vez de automaticamente :
            long valor = 300;
            int a = (int)valor;
            Console.WriteLine(a);

            //conversão implicita de tipos
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            //conversão explicita de tipos
            double d = 5.1;
            float e = (float)d;//casting) to falando pode jogar conteúdo de 8 bytes no dentro da variavel 4 bytes
            Console.WriteLine(e);

            //casting para inteiro com perda de informação
            double f = 6.1;
            int g = (int)f;
            Console.WriteLine(g);

            /*tanto valor de a ou b são inteiros.. ele reconhece como valor inteiro.. divisão sao inteiros
            SequencePosition quise mudar tenho que colcoar um casting*/
            int na = 5;
            int nb = 2;
            double resultado = na / nb;
            Console.WriteLine(resultado);

        }
    }
}
