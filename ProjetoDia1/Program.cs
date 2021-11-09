using System;

namespace ProjetoDia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Relógio");

            var relogio = new Relogio();

            relogio.Data();
            relogio.Segundos();
            relogio.Modelo();
            relogio.Alarme();

        }
    }
}
