using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMarcel4.Entities

{
    class BusinessAccount
    {

        public double LimiteEmprestimo { get; set; }
        public double Saldo { get; private set; }

        public BusinessAccount(int numero, string titular, double saldo, double limiteemprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteemprestimo;
        }

        public void Emprestimo(double valoremprestimo)
        {
            if (Saldo <= LimiteEmprestimo)
            {
                Saldo += valoremprestimo;
            }

        }


    }
}
