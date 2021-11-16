using System;

namespace SplitDeFormaErrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Split Forma Errada");
            // [0] 30.12345,12.5233
            // [1] 32.12345,13.5233
            // [2] 35.12345,14.5233
            // [3] 37.12345,18.5233
            //------------------------------// 
            //imprima: 30.12345,12.5233  
            //Imprima: 30.12345   
            //Imprima: 12.5233

            string dadosPosicao = "30.12345,12.5233;32.12345,13.5233;35.1234514.5233;37.12345,18.5233";


            string[] posicao1 = dadosPosicao.Split(';'); // =  30.12345,12.5233; 
            string _1posicao = posicao1[0];
            Console.WriteLine("(1)Posicao = " + _1posicao);

            string[] posicao2 = _1posicao.Split(','); // = 30.12345
            string _2posicao = posicao2[0];
            Console.WriteLine("(2)Posicao = " + _2posicao);

            string[] posicao3 = _1posicao.Split(','); // = 12.5233;
            string _3posicao = posicao3[1];
            Console.WriteLine("(3)Posicao = " + _3posicao);

            Console.ReadKey();



        }
    }
}
