using System;
using System.Diagnostics;
using System.Globalization;
using Caelum.Stella.CSharp.Vault;

namespace TrabalhandoComDinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Trabalhando com Dinheiro ");
            Money money = 10.00;
            Console.WriteLine(money);

            //Trabalhando com real 
            double valor1 = 10.00;
            double valor2 = 20.00;
            Money total = valor1 + valor2;
            Console.WriteLine(total);

            //Trabalhando com Real
            decimal minuendo = 20m;
            decimal subtraendo = 15m;
            Money diferenca = minuendo - subtraendo;
            Console.WriteLine(diferenca);

            //Trabanhando Com Euro
            Money euro = new Money(Currency.EUR, 1000);
            Console.WriteLine(euro);
            Debug.WriteLine(euro);

            //Trabalhando com Dolar
            Money dolar = new Money(Currency.USD, 1000);
            Console.WriteLine(dolar);
            Debug.WriteLine(dolar);

            //Trabalhando com Dolar Cultura americana
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(dolar);
            Debug.WriteLine(dolar);

            Console.ReadKey();
        }
    }
}
