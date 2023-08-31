using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    internal class PedidosProdutos
    {
        public int PedidoID { get; set; }

        public int ProdutoID { get; set; }

        public string Nome { get; set; }

        public string Preco { get; set; }

        public string Quantidade { get; set; }

        public string Total { get; set; }
    }
}
