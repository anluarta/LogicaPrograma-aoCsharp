using System;

namespace FormulaBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            //FÓRMULA DE BHASKARA
            //obs: NaN >> São números imagináveis que não são representado de forma computacionais 5,5,2
            // 2,4,-6
            // 3,0,-27  >> CONJUNTO DE NUMEROS REAIS QUE CONSEGUE REPRESENTAR COMPUTACIONALMENTE

            Console.WriteLine("Formula Bhaskara");
            int a = 2;
            int b = 5;
            int c = 3;

            double delta = (b * b) - (4 * a * c);//24
            double raiz = Math.Sqrt(delta);
            double x1 = (-b + raiz) / (2 * a);
            double x2 = (-b - raiz) / (2 * a);

            Console.WriteLine(" Valor de X1 É :" + x1);
            Console.WriteLine(" Valor de X2 É :" + x2);

            Console.ReadKey();

        }
    }
}
