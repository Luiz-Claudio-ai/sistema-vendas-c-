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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //conexão com o banco de dados sql server

        SqlConnection cn = new SqlConnection(@"Data source = DESKTOP01; integrated security = SSPI; Initial Catalog = PedidoVendaDB");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dr;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher os campos usuáro e senha", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            }

            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from Usuario where Nome = ('" + txtUsuario.Text + "') and Senha = ( '" + txtSenha.Text + "')";
                    cm.Connection = cn;
                    dr = cm.ExecuteReader();

                    if (dr.HasRows)
                    {
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Clear();
                        txtSenha.Clear();
                        txtUsuario.Focus();
                    }
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
