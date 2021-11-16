using System;

namespace TipoBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte num1 = 127;
            byte num2 = 255;
            int num3 = 2147483647;//aceita até 2147483647 
            long num4 = 21474836478L;
            float num5 = 4.5f;
            double num6 = 4.59887878877;
            decimal num7 = decimal.MaxValue;
            double num8 = double.MinValue;
            int num9 = int.MaxValue;
            int num10 = int.MinValue;
            bool ladrao = false;
            bool ladrao2 = true;
            char genero = 'M';
            string nome = "Marcel";
            object nome1 = "Silva";
            object nome2 = 4.5f;

            Console.WriteLine(num9);
        }
    }
}
