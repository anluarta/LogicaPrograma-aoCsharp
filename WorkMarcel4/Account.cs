using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMarcel4.Entities
{
    class Account
    {
        public int Numero { get; private set; }//private posso acessar mas não alterar
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }//Protected Só pode ser alterado dentro da propria classe ou sub classe.

        public Account(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double valorsaque)//WithDraw 
        {
            Saldo -= valorsaque;
        }
        public void Deposito(double valordeposito)//Deposit
        {
            Saldo += valordeposito;
        }

    }
}
