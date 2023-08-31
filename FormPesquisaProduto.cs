using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class FormPesquisaProduto : Form
    {
        public FormPesquisaProduto()
        {
            InitializeComponent();
        }


        private void FormPesquisaProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            // Obter a string de conexão do arquivo de configuração
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

            // Criar uma consulta SQL para pesquisar os pedidos
            string query = "SELECT ProdutoID, Nome, Preco FROM Produtos WHERE Nome LIKE @Nome";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Definir o parâmetro de pesquisa
                    command.Parameters.AddWithValue("@Nome", "%" + txtPesquisaProduto.Text + "%");

                    // Abrir a conexão e executar a consulta
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Preencher a grade (DataGridView) com os resultados da pesquisa
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridViewProdutos.DataSource = dataTable;

                    // Fechar a conexão
                    reader.Close();
                }
            }
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewProdutos.Rows.Count)
            {
                // Obtém os dados do pedido selecionado na DataGridView
                int produtoId = (int)dataGridViewProdutos.Rows[e.RowIndex].Cells["ProdutoID"].Value;
                string nome = dataGridViewProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                decimal preco = (decimal)dataGridViewProdutos.Rows[e.RowIndex].Cells["Preco"].Value;

                // Envia os dados do pedido selecionado de volta para a Form1
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                form1.AtualizarCamposProdutos(produtoId, nome, preco);

                // Fecha o FormPesquisa
                this.Close();
            }
        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
