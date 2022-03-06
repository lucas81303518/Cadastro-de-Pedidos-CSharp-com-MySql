using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cad_Cliente.Views
{
    public partial class CadastroUsuario : Form
    {
        MySqlConnection Conexao;
        MySqlCommand Comando;
        string strSQL;
        public CadastroUsuario()
        {
            InitializeComponent();
        }
        private void Connection()
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
            Conexao.Open();
        }
        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
        }
        private bool jaExiste()
        {
            Connection();

            strSQL = "SELECT Count(idUsuario) FROM Usuario WHERE usuario LIKE @usuario";

            Comando = new MySqlCommand(strSQL, Conexao);

            Comando.Parameters.AddWithValue("@usuario", txtLogin.Text);

            int count = Convert.ToInt32(Comando.ExecuteScalar());
            if (count >= 1)  // Usuário já existe
            {
                lblErroUsuario.Text = "Usuário não disponível!!";
                lblErroUsuario.ForeColor = Color.Red;
                txtLogin.Focus();
                return true;
            }
            else
            {
                lblErroUsuario.Text = "";
                return false;
            }
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (!jaExiste())
            {
                if (txtLogin.Text.Length < 8)
                {
                    lblErroUsuario.Text = "Usuário deve ter no mínimo 8 caracteres!!";
                    lblErroUsuario.ForeColor = Color.Red;
                    
                    txtLogin.Focus();
                }
                else
                {
                    lblErroUsuario.Text = "";
                }
            }
            
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text != txtSenha.Text)
            {
                lblErroConfirmSenha.Text = "Confirmação de senha nao condiz com a senha digitada!!";
                lblErroConfirmSenha.ForeColor = Color.Red;
                lblErroConfirmSenha.Focus();
            }
            else
            {
                lblErroConfirmSenha.Text = "";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length < 5)
            {
                lblErroSenha.Text = "Senha deve ter no mínimo 5 caracteres!!";
                lblErroSenha.ForeColor = Color.Red;
                txtSenha.Focus();
            }
            else
            {
                lblErroSenha.Text = "";
            }
        }
    }
}
