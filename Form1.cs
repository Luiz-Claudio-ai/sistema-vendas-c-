using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Vendas
{
    public partial class Form1 : Form
    {
        private void Form1_Shown(object sender, EventArgs e)
        {
            txtPedido.Focus();
        }

        private Pedido pedido;

        public Form1()
        {
            InitializeComponent();
            pedido = new Pedido();
            this.Shown += Form1_Shown;

            dgvProdutosPedido.Columns.Add("Total", "Total");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtPedido.Text = "0";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crie uma consulta SQL para inserir os dados do pedido
                string query = "INSERT INTO Pedidos (Cliente) VALUES (@Cliente)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Substitua os parâmetros pelos valores reais do pedido
                    //command.Parameters.AddWithValue("@Quantidade", int.Parse(txtQuantidade.Text));
                    command.Parameters.AddWithValue("@Cliente", txtCliente.Text);
                    //command.Parameters.AddWithValue("@Produto", txtCliente.Text);

                    command.ExecuteNonQuery();

                    /* Criar um objeto Pedido e atribuir os valores
                    Pedido pedido = new Pedido();
                    pedido.PedidoID = Convert.ToInt32(txtPedido.Text);
                    pedido.Cliente = txtCliente.Text;

                    // Exibir mensagem de sucesso com os dados do pedido
                    MessageBox.Show($"Pedido gravado com sucesso!\nNúmero do Pedido: {pedido.PedidoID}\nCliente: {pedido.Cliente}");*/


                }

                // Consulta SQL para obter o último PedidoID e Cliente gravado
                string consulta = "SELECT TOP 1 PedidoID, Cliente FROM Pedidos ORDER BY PedidoID DESC";
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int pedidoId = reader.GetInt32(0);
                            string cliente = reader.GetString(1);

                            // Exibir mensagem com os dados do último pedido gravado
                            //MessageBox.Show($"Último pedido gravado:\nNúmero do Pedido: {pedidoId}\nCliente: {cliente}");

                            // Atualizar os campos txtPedido e txtCliente com os dados recém-gravados
                            txtPedido.Text = pedidoId.ToString();
                            txtCliente.Text = cliente;
                        }

                    }
                }
            }
            

        }

        public void AtualizarCamposPedido(int pedidoId, string cliente)
        {
            txtPedido.Text = pedidoId.ToString();
            txtCliente.Text = cliente;
        }

        public void AtualizarCamposProdutos(int produtoId, string nome, decimal preco)
        {
            txtIncluiProduto.Text = produtoId.ToString();
            txtIncluiNomeProd.Text = nome;
            txtIncluiPreco.Text = preco.ToString();
        }


        private void btnPesquisarPedido_Click(object sender, EventArgs e)
        {
            FormPesquisa formPesquisa = new FormPesquisa();
            formPesquisa.ShowDialog();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.ShowDialog();
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            FormPesquisaProduto formPesquisaProduto = new FormPesquisaProduto();
            formPesquisaProduto.ShowDialog();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new FormCadastroCliente();
            formCadastroCliente.ShowDialog();
        }


        private void btnGravarProduto_Click(object sender, EventArgs e)
        {

            // Obter os dados dos campos
            int produtoId = int.Parse(txtIncluiProduto.Text);
            string nome = txtIncluiNomeProd.Text;
            decimal preco = decimal.Parse(txtIncluiPreco.Text);
            int quantidade = int.Parse(txtQuantidadeProduto.Text);
            int pedidoId = int.Parse(txtPedido.Text);
            decimal total = preco * quantidade;
            // Exibir o total no TextBox ou Label antes de adicionar à DataGridView
            //txtTotalProduto.Text = total.ToString();

            // Adicionar os dados na DataGridView
            dgvProdutosPedido.Rows.Add(produtoId, nome, preco, quantidade, total);

            // Gravar a associação do produto ao número do pedido na tabela associativa PedidosProdutos
            GravarAssociacaoProdutoPedido(pedidoId, produtoId, nome, preco, quantidade);

            // Limpar os campos após a inclusão do produto
            LimparCamposProduto();

        }

        private void GravarAssociacaoProdutoPedido(int pedidoId, int produtoId, string nome, decimal preco, int quantidade)
        {
            // Obter a string de conexão do arquivo de configuração
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

            // Criar uma consulta SQL para inserir a associação do produto ao número do pedido
            string query = "INSERT INTO PedidosProdutos (PedidoID, ProdutoID, Nome, Preco, Quantidade) VALUES (@PedidoID, @ProdutoID, @Nome, @Preco, @Quantidade)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adicionar os parâmetros
                    command.Parameters.AddWithValue("@PedidoID", pedidoId);
                    command.Parameters.AddWithValue("@ProdutoID", produtoId);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Preco", preco);
                    command.Parameters.AddWithValue("@Quantidade", quantidade);
                    //command.Parameters.AddWithValue("@Total", total);

                    // Abrir a conexão e executar a consulta
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }


        private void LimparCamposProduto()
        {
            txtIncluiProduto.Text = string.Empty;
            txtIncluiNomeProd.Text = string.Empty;
            txtIncluiPreco.Text = string.Empty;
            txtQuantidadeProduto.Text = string.Empty;
            txtTotalProduto.Text = string.Empty;
        }

        public void ExibirPedido(int pedidoId, string cliente)
        {
            txtPedido.Text = pedidoId.ToString();
            txtCliente.Text = cliente;
           
        }


        private List<Produto> ObterProdutosPorPedido(int pedidoId)
        {
            List<Produto> produtos = new List<Produto>();

            // Obter a string de conexão do arquivo de configuração
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

            // Criar uma consulta SQL para obter os registros relacionados ao pedido na tabela PedidosProdutos
            string query = "SELECT pp.PedidoID, p.ProdutoID, p.Nome, pp.Preco, pp.Quantidade " +
                           "FROM PedidosProdutos pp " +
                           "INNER JOIN Produtos p ON pp.ProdutoID = p.ProdutoID " +
                           "WHERE pp.PedidoID = @PedidoID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adicionar o parâmetro PedidoID à consulta SQL
                    command.Parameters.AddWithValue("@PedidoID", pedidoId);

                    // Abrir a conexão e executar a consulta
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Ler os dados retornados pela consulta e criar objetos Produto
                        while (reader.Read())
                        {
                            int produtoId = (int)reader["ProdutoID"];
                            string nome = (string)reader["Nome"];
                            decimal preco = (decimal)reader["Preco"];
                            int quantidade = (int)reader["Quantidade"];
                            //decimal total = (decimal)reader["Total"];

                            Produto produto = new Produto();
                            produto.ProdutoID = produtoId;
                            produto.Nome = nome;
                            produto.Preco = preco;
                            produto.Quantidade = quantidade;
                            //produto.Total = total;

                            produtos.Add(produto);
                        }
                    }
                }
            }

            return produtos;
        }




        private void btnCarregaProdutos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPedido.Text))
            {
                // Obter o número do pedido informado
                int pedidoId = int.Parse(txtPedido.Text);

                // Obter os produtos relacionados ao pedido na tabela PedidosProdutos
                List<Produto> produtos = ObterProdutosPorPedido(pedidoId);

                // Preencher a DataGridView dgvProdutosPedido
                dgvProdutosPedido.Rows.Clear();
                foreach (Produto produto in produtos)
                {
                    dgvProdutosPedido.Rows.Add(produto.ProdutoID, produto.Nome, produto.Preco, produto.Quantidade);
                }
            }
            else
            {
                MessageBox.Show("Informe um número de pedido válido.");
            }
            /* Obter a string de conexão do arquivo de configuração
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

            // Criar uma consulta SQL para pesquisar os pedidos
            string query = "SELECT PedidoID, ProdutoID, Nome, Preco, Quantidade FROM PedidosProdutos WHERE PedidoID LIKE @pedido";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Definir o parâmetro de pesquisa
                    command.Parameters.AddWithValue("@pedido", txtPedido.Text);

                    // Abrir a conexão e executar a consulta
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Preencher a grade (DataGridView) com os resultados da pesquisa
                    DataTable dataTable2 = new DataTable();
                    dataTable2.Load(reader);
                    dgvProdutosPedido.DataSource = dataTable2;

                    // Fechar a conexão
                    reader.Close();
                }
            }*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtPedido.Text = string.Empty;
            txtCliente.Text = string.Empty;
            dgvProdutosPedido.Rows.Clear();
        }

        private void txtPedido_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPedido.Text))
            {
                int pedidoId;
                if (int.TryParse(txtPedido.Text, out pedidoId))
                {
                    CarregarDadosPedido(pedidoId);
                }
                else
                {
                    LimparCamposPedido();
                }
            }
            else
            {
                LimparCamposPedido();
            }

        }

        public void CarregarDadosPedido(int pedidoId)
        {
            // Aqui você pode implementar a lógica para buscar os dados do pedido no banco de dados
            // e preencher os campos txtPedido, txtCliente e dgvProdutosPedido com os dados correspondentes ao pedido
            // Lembre-se de adaptar o código de acordo com a sua estrutura de banco de dados

            // Exemplo de código para preencher os campos com dados fictícios:
            string cliente = ObterClienteDoPedido(pedidoId);
            List<Produto> produtos = ObterProdutosPorPedido(pedidoId);

            txtPedido.Text = pedidoId.ToString();
            txtCliente.Text = cliente;

            dgvProdutosPedido.Rows.Clear();
            foreach (Produto produto in produtos)
            {
                dgvProdutosPedido.Rows.Add(produto.ProdutoID, produto.Nome, produto.Preco, produto.Quantidade);
            }
        }

        private void LimparCamposPedido()
        {
            txtPedido.Text = string.Empty;
            txtCliente.Text = string.Empty;
            dgvProdutosPedido.Rows.Clear();
        }

        private string ObterClienteDoPedido(int pedidoId)
        {
            // Aqui você deve implementar a lógica para buscar o cliente do pedido no banco de dados
            // Utilize a conexão com o banco de dados e a consulta apropriada para obter o cliente associado ao pedido
            // Lembre-se de adaptar o código para a sua estrutura de banco de dados

            // Exemplo de código fictício para obter o cliente do pedido
            string cliente = string.Empty;

            // Utilize a conexão com o banco de dados e a consulta apropriada para obter o cliente associado ao pedido
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Cliente FROM Pedidos WHERE PedidoID = @PedidoID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PedidoID", pedidoId);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    cliente = result.ToString();
                }
            }

            return cliente;
        }


        private void txtQuantidadeProduto_Leave(object sender, EventArgs e)
        {
            decimal preco = decimal.Parse(txtIncluiPreco.Text);
            int quantidade = int.Parse(txtQuantidadeProduto.Text);
            decimal total = preco * quantidade;

            // Exibir o total no TextBox ou Label antes de adicionar à DataGridView
            txtTotalProduto.Text = total.ToString(); // ou lblTotalProduto.Text = total.ToString();

        }

        private void btnBuscarPedido_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
