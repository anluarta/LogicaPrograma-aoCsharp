using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }//Não pode alterado(set)encapsulamento
        public string Titular { get; set; }
        public double Saldo { get; private set; }//(set)só altera pelo meio deposito ou saque

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        // this >>reaproveitar construtor de cima 2 argumentos
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);//chamando método Deposito>> uma disrcurssão de encapsulamento
        }
        

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }

        public override string ToString()
        {
            return " Conta: " + Numero + " Titular: " + Titular + ", Saldo R$: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
