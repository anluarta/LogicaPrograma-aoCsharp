using System;

namespace Aula4Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matriz é um vetor que possui Linhas e Colunas

            Console.WriteLine("Exercicios Matrizes ");

            int [,] colunateste = new int [3,6];

            /* 10 34 45 56 98 100
               35 23 57 89 97 200
               02 43 46 98 90 301
            */

            colunateste[0,0] = 10;
            colunateste[0,1] = 34;
            colunateste[0,2] = 45;
            colunateste[0,3] = 56;
            colunateste[0,4] = 98;
            colunateste[0,5] = 100;

            colunateste[1,0] = 35;
            colunateste[1,1] = 23;
            colunateste[1,2] = 57;
            colunateste[1,3] = 89;
            colunateste[1,4] = 97;
            colunateste[1,5] = 200;

            colunateste[2,0] = 02;
            colunateste[2,1] = 43;
            colunateste[2,2] = 46;
            colunateste[2,3] = 98;
            colunateste[2,4] = 90;
            colunateste[2,5] = 301;


            Console.WriteLine(colunateste[0,0]);
            Console.ReadKey();
        }
    }
}
