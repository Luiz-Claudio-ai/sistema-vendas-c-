using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        //conexão com o banco de dados sql server

        SqlConnection cn = new SqlConnection(@"Data source = DESKTOP01; integrated security = SSPI; Initial Catalog = PedidoVendaDB");

        SqlCommand cm = new SqlCommand();

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            btnNovoCliente.Enabled = true;
            txtCliente.Enabled = true;
            txtNomeCliente.Enabled = false;
            txtUFCliente.Enabled = false;
            txtCepCliente.Enabled = false;
            btnGravarCliente.Enabled = false;
            btnPesquisarCliente.Enabled = true;
            btnExcluirCliente.Enabled = false;
            btnCancelarCliente.Enabled = false;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            btnNovoCliente.Enabled = false;
            txtCliente.Enabled = false;
            txtNomeCliente.Enabled = true;
            txtUFCliente.Enabled = true;
            txtCepCliente.Enabled = true;
            btnGravarCliente.Enabled = true;
            btnPesquisarCliente.Enabled = false;
            btnExcluirCliente.Enabled = false;
            btnCancelarCliente.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNomeCliente.Clear();
            txtCepCliente.Clear();
            txtUFCliente.Clear();
            txtCliente.Focus();
        }

        private void btnGravarCliente_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeCliente.Focus();
            }
            else if (txtCepCliente.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo CEP.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCepCliente.Focus();
            }
            else if (txtUFCliente.Text.Length < 2)
            {
                MessageBox.Show("Obrigatório informar o campo UF de forma válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUFCliente.Focus();
            }
            else
            {
                try
                {
                    string nomeCliente = txtNomeCliente.Text;
                    string cepCliente = txtCepCliente.Text;
                    string ufCliente = txtUFCliente.Text;

                    string StrSql = "insert into Clientes(Nome, Estado, CEP) values (@nome,@estado, @cep)";

                    cm.CommandText = StrSql;
                    cm.Connection = cn;
                    //SqlCommand cm = new SqlCommand(sql, cn);

                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nomeCliente;
                    cm.Parameters.Add("@estado", SqlDbType.Char).Value = ufCliente;
                    cm.Parameters.Add("@cep", SqlDbType.Char).Value = cepCliente;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Os dados foram gravados com sucesso!!", "Inserção de dados concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeCliente.Focus();
                    LimparCampos();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
