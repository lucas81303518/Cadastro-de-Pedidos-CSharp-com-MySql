using Cad_Cliente.Models;
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
            Usuario Mariana = new Usuario("Mariana", "23072807");

           if( Mariana.ValidarUsuario(txtLogin, txtSenha))
            {
                Pedido pedido = new Pedido();
                pedido.ShowDialog();
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
