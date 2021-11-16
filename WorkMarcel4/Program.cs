using System;
using WorkMarcel4.Entities;

namespace WorkMarcel4
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(1030, "Marcel", 100.0, 500.0);
            Console.WriteLine(account.Saldo);
            //account.Saldo = 200.0; 
        }
    }
}
