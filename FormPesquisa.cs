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
    public partial class FormPesquisa : Form
    {
        public FormPesquisa()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Obter a string de conexão do arquivo de configuração
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

            // Criar uma consulta SQL para pesquisar os pedidos
            string query = "SELECT PedidoID, Cliente FROM Pedidos WHERE Cliente LIKE @Cliente";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Definir o parâmetro de pesquisa
                    command.Parameters.AddWithValue("@Cliente", "%" + txtPesquisaCliente.Text + "%");

                    // Abrir a conexão e executar a consulta
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Preencher a grade (DataGridView) com os resultados da pesquisa
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridViewPedidos.DataSource = dataTable;

                    // Fechar a conexão
                    reader.Close();
                }
            }

        }

        public void dataGridViewPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewPedidos.Rows.Count)
            {
                // Obter os dados do pedido selecionado na dataGridViewPedidos
                int pedidoId = (int)dataGridViewPedidos.Rows[e.RowIndex].Cells["PedidoID"].Value;
                string cliente = dataGridViewPedidos.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();

                // Exibir os dados do pedido na Form1
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                form1.ExibirPedido(pedidoId, cliente);
                form1.CarregarDadosPedido(pedidoId);

                // Fechar o FormPesquisa
                this.Close();


            }


        }



        private void FormPesquisa_Load(object sender, EventArgs e)
        {

        }
    }
}
