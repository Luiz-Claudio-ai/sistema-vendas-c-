using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void peiddosDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 pedido = new Form1();
            pedido.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente Clientes = new FormCadastroCliente();
            Clientes.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroProduto Produtos = new FormCadastroProduto();
            Produtos.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario Usuarios = new FormCadastroUsuario();
            Usuarios.Show();
        }
    }
}
