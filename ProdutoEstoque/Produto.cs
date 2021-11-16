using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoEstoque
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double Estoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidades)
        {
            Quantidade = Quantidade + quantidades;
        }

        public void RemoverProdutos(int quantidades)
        {
            Quantidade = Quantidade -= quantidades;
        }

        public override string ToString()
        {
            return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                        + ", " + Quantidade
                        + " Unidades, Total: $ "
                        + Estoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
