using Cad_Cliente.Models;
using Cad_Cliente.screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cad_Cliente
{
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Tela_Principal tela_Principal = new Tela_Principal();

            Admin Mariana = new Admin("Mari", "23072807");
            Usuario Lucas = new Usuario("Lucas", "23072807");

            if (ValidarUsuario(Mariana))
            {
                tela_Principal.Show();

                txtLogin.Text = "";
                txtSenha.Text = "";
            }
        }
        public bool ValidarUsuario(Usuario usuario)
        {
            if (usuario.Login == txtLogin.Text && usuario.Senha == txtSenha.Text)
            {
                return true;
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Campo de login não preenchido!!");
                return false;

            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Campo de senha não preenchido!!");
                return false;


            }
            else if (txtLogin.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Campos não preenchidos!!");
                return false;

            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos!!");
                return false;

            }

        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox_Senha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

    }
}
