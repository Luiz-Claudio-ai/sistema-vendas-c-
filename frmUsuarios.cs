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

namespace Vendas
{
    public partial class frmUsuarios : UserControl
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        //conexão com o banco de dados sql server

        SqlConnection cn = new SqlConnection(@"Data source = DESKTOP01; integrated security = SSPI; Initial Catalog = PedidoVendaDB");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dr;

        private void DesabilitaCampos()
        {
            btnNovo.Enabled = true;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            btnGravar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            txtUsuario.Focus();
            btnNovo.Enabled = false;
        }

        private void LimparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void manipularDados()
        {
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = false;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            DesabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            LimparCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo senha deve conter no minimo 8 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else
            {
                try
                {
                    string usuario = txtUsuario.Text;
                    string senha = txtSenha.Text;

                    string StrSql = "insert into Usuario(nome, senha) values (@usuario,@senha)";

                    cm.CommandText = StrSql;
                    cm.Connection = cn;
                    //SqlCommand cm = new SqlCommand(sql, cn);

                    cm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Os dados foram gravados com sucesso!!", "Inserção de dados concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                    LimparCampos();

                }
                catch(Exception erro)
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if(txtPesquisa.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "SELECT * FROM USUARIO WHERE NOME LIKE '"+txtPesquisa.Text+"%'";
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
                    da.Fill(dt); //preenchendo a datatable
                    dgvUsuarios.DataSource = dt; //preenchendo o datagridview
                    cn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }

            }
            else
            {
                dgvUsuarios.DataSource = null;
            }
        }

        private void CarregaUsuario()
        {
            lblCod.Text = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
            txtUsuario.Text = dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString();
            txtSenha.Text = dgvUsuarios.SelectedRows[0].Cells[2].Value.ToString();
            manipularDados();
        }

        private void dgvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregaUsuario();
        }
    }
}
