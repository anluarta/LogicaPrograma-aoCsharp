using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDia1
{
    public class Relogio
    {
        public void Data()
        {
            var diaedata = DateTime.Now;
            Console.WriteLine(diaedata);
        }
        public void Modelo()
        {
            var modelo = "Oriente";
            Console.WriteLine(modelo);
        }      

         public void Segundos()
        {
            for (int segundos = 0; segundos <60; segundos++)
            {
                Console.WriteLine(segundos);                
            }
        }     
        

        public void Alarme()
        {
           
            var num = 0;

            while (num<=10)
            {
                Console.WriteLine(num);
                num++;                
            }
            Console.WriteLine("Fim do Alarme");
        }
    }
}
