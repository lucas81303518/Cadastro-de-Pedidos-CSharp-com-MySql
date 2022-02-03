using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cad_Cliente.Models
{
    public class Usuario
    {
        private string Login { get; set; }
        private string Senha { get; set; }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
        public bool ValidarUsuario(TextBox login, TextBox senha)
        {
            if (Login == login.Text && Senha == senha.Text)
            {
                LimparTela();
                return true;
            }
            else if (login.Text == "")
            {
                MessageBox.Show("Campo de login não preenchido!!");
                return false;

            }
            else if (senha.Text == "")
            {
                MessageBox.Show("Campo de senha não preenchido!!");
                return false;


            }
            else if (login.Text == "" && senha.Text == "")
            {
                MessageBox.Show("Campos não preenchidos!!");
                return false;

            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos!!");
                return false;

            }
            void LimparTela()
            {
                login.Text = "";
                senha.Text = "";
            }
        }
    }
}