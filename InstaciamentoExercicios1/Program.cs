using System;

namespace InstaciamentoExercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            var _1pessoa = new Pessoa();
            _1pessoa.Nome = "Marcel";
            _1pessoa.Idade = 25;            

            var _2pessoa = new Pessoa();
            _2pessoa.Nome = "Carlos";
            _2pessoa.Idade = 38;
            

            if (_1pessoa.Idade > _2pessoa.Idade)
            {
                Console.WriteLine("Marcel é Mais velho");
            }
            else
            {
                Console.WriteLine("Carlos é mais velho");
            }
        }
    }
}
