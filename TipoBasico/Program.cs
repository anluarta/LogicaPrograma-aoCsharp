using System;

namespace TipoBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n1 = 127;
            byte n2 = 255;
            int n3 = 2147483647;//aceita até 2147483647 
            long n4 = 21474836478L;
            float n5 = 4.5f;
            double n6 = 4.59887878877;
            decimal n7 = decimal.MaxValue;
            double n8 = double.MinValue;
            int n9 = int.MaxValue;
            int n10 = int.MinValue;
            bool ladrao = false;
            bool ladrao2 = true;
            char genero = 'M';
            string nome = "Marcel";
            object nome1 = "Silva";
            object nome2 = 4.5f;

            Console.WriteLine(n9);
        }
    }
}
