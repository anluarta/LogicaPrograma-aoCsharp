using System;

namespace SplitDeFormaCorreta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Split de Forma Correta");

            string dadosPosicao = "30.12345,12.5233;32.12345,13.5233;35.12345.14.5233;37.12345.18.5233";

            string[] split1 = dadosPosicao.Split(';');
            string resposta1 = split1[0];

            Console.WriteLine(" A Primeira resposta é : " + resposta1);// [0]30.12345 , [1]12.5233


            string[] split2 = resposta1.Split(',');
            string resposta2 = split2[0];
            string resposta3 = split2[1];

            Console.WriteLine(" A Segunda Resposta  é : " + resposta2);
            Console.WriteLine(" A Terceira Resposta é : " + resposta3);


        }
    }
}
