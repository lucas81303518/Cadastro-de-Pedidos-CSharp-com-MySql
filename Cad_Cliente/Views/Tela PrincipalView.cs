using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cad_Cliente.screens
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
        }

        private void finançasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financas financas = new Financas();
            financas.Show();
        }

    }
}
