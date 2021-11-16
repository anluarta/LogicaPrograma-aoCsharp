using System;

namespace RestricaoVariavel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Restrições de Variaveis
             Não pode começar com dígito: use uma letra ou _
             Não usar acentos ou til
             Não pode ter espaço em branco

            Sugestão: use nomes que tenham um significado
             Errado:
             int 5minutos;
             int salário;
             int salario do funcionario;


            Correto:
            int _5minutos;
            int salario;
            int salarioDoFuncionario;

            REGRA DE CONVENÇÕES:

            Obs: Usar variáveis que tenha sentido... ex: Double salario  ou sal = 1.000;  >> nunca usar Double x = 1.000; (x não tem sentido)
            ex: String Nome = "Marcel " >> nunca usar string teste = " Marcel"; (teste não tem sentido)
            Obs: Importante

            Camel Case: marcelSilva(parâmetros de métodos, variáveis dentro Métodos)

            Pascal Case: MarcelSilva(namespaces, classes, properties e métodos)

            Padrão: _marcelSilva(atributos "internos" da classe) */
            public string Titular { get; set; }
            private double _saldo;

            public void Deposito(double quantia)
            {
            _saldo += quantia;
            }

            public double GetSaldo()
            {
            return _saldo;
            }


    }

    }       
}

