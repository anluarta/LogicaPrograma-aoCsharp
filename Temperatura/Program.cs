using System;
using System.Globalization;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fórmulas para Calcular Temperatura estrangeira");
            // TC = TEMPERATURA EM CELSIUS
            // TF= TENPERATURA EM FAHRENHEIT
            // TC/5 = (TF -32)/9

            int tc;
            int tf = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           

            tc = ((tf - 32) / 9) * 5;

            Console.WriteLine(" A temperatura de miami é : " + tc.ToString("F1", CultureInfo.InvariantCulture) + " CELSIUS ");

            Console.ReadLine();


        }
    }
}
