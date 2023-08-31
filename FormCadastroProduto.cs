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
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnGravarProduto_Click(object sender, EventArgs e)
        {
            // Criar um objeto Produto com os valores dos campos
            Produto produto = new Produto();
            //produto.ProdutoID = int.Parse(txtProdutoID.Text);
            produto.Nome = txtNome.Text;
            produto.Preco = decimal.Parse(txtPreco.Text);

            // Obter a string de conexão do arquivo de configuração
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

            // Criar uma consulta SQL para inserir os dados do produto
            string query = "INSERT INTO Produtos (Nome, Preco) VALUES (@Nome, @Preco)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adicionar os parâmetros aos valores do produto
                    //command.Parameters.AddWithValue("@ProdutoID", produto.ProdutoID);
                    command.Parameters.AddWithValue("@Nome", produto.Nome);
                    command.Parameters.AddWithValue("@Preco", produto.Preco);

                    // Abrir a conexão e executar a consulta
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Consulta SQL para obter o último PedidoID e Cliente gravado
                string consulta = "SELECT TOP 1 ProdutoID, Nome, Preco FROM Produtos ORDER BY ProdutoID DESC";
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int produtoId = reader.GetInt32(0);
                            string nome = reader.GetString(1);
                            decimal preco = reader.GetDecimal(2);

                            // Exibir mensagem com os dados do último pedido gravado
                            //MessageBox.Show($"Último pedido gravado:\nNúmero do Pedido: {pedidoId}\nCliente: {cliente}");

                            // Atualizar os campos txtPedido e txtCliente com os dados recém-gravados
                            txtProdutoID.Text = produtoId.ToString();
                            txtNome.Text = nome;
                        }

                    }
                }
            }

        }

    }
}
