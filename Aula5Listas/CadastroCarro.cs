using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5Listas
{
    public class CadastroCarro
    {
        public List<Carro> Carros { get; set; }

        public void Processo()
        {
            Carros = new List<Carro>();

            var resposta = string.Empty;

            while (resposta!="F")
            {
                
                Console.WriteLine("(I)Incluir,(L)Listar,(F)Fechar");
                resposta = Console.ReadKey().Key.ToString();

                switch (resposta)
                {
                    case "I":
                        Inclusao();
                        break;

                    case "L":
                        Listar();
                        break;

                    default:
                        break;
                }
            }
        }

        private void Listar()
        {
           Console.WriteLine("Listar");

            for (int i = 0; i <Carros.Count; i++)
            {
                Console.WriteLine(Carros[i].Marca);
            }
        }

        private int Inclusao()
        {            
                Console.WriteLine("Qual a Marca");
                string marca = Console.ReadLine();
                var marcaproibida = "JAGUAR";

                while (marcaproibida == marca)
                {
                    Console.Clear();
                    Console.WriteLine("Não é possível cadastrar esse tipo de marca");
                    Console.WriteLine("Digite outra Marca");
                    marca = Console.ReadLine();
                }

                Console.WriteLine("Qual o modelo");
                string modelo = Console.ReadLine();

                Console.WriteLine("Qual a cor ");
                string cor = Console.ReadLine();

                Console.WriteLine("Qual Quantidade de Portas");
                int portas = int.Parse(Console.ReadLine());
                //var quantiportasnaoaceita1 = 3;
                //var portasnaoaceita2=

                var carro = new Carro();

                carro.Marca = marca;
                carro.Modelo = modelo;
                carro.Cor = cor;
                carro.Portas = portas;

                Carros.Add(carro);
            
        }
    }
}
