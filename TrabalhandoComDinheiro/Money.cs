using System;

namespace TrabalhandoComDinheiro
{
    internal class Money
    {
        private Caelum.Stella.CSharp.Vault.Currency uSD;
        private int v;

        public Money(Caelum.Stella.CSharp.Vault.Currency uSD, int v)
        {
            this.uSD = uSD;
            this.v = v;
        }

        public static implicit operator Money(double v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Money(decimal v)
        {
            throw new NotImplementedException();
        }
    }
}