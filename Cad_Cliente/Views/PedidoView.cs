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
using Cad_Cliente.Views;
using MySql.Data.MySqlClient;

namespace Cad_Cliente
{
    public partial class Pedido : Form
    {
        public int _getId;
        public bool Edit = false;//Variável de controle

        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataAdapter Da;
        string strSQL;
        public Pedido()
        {
            InitializeComponent();
            Exibir();
        }
        //Método de Limpar dados da Tela

        //Método de Conexão com Banco de dados
        private void Connection()
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
        }

        //Método de Exibir Pedidos
        private void Exibir()
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Pedido";

                DataTable Dt = new DataTable();

                Da = new MySqlDataAdapter(strSQL, Conexao);

                Da.Fill(Dt);

                DgvPedido.DataSource = Dt;
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Conexao.Close();
                Conexao = null;
                Comando = null;
            }

        }

        //Método para filtrar pedidos através dos clientes 
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca_Pedido.Text != "")
            {
                try
                {
                    Connection();

                    Conexao.Open();

                    Comando = new MySqlCommand();

                    Comando.CommandText = "Select * from Pedido " +
                                          "Where Pedido.Cliente_Cadastrado like ('%" + txtBusca_Pedido.Text + "%')";
                    Comando.Connection = Conexao;
                    Da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    Da.SelectCommand = Comando;
                    Da.Fill(dt);
                    DgvPedido.DataSource = dt;
                    Conexao.Close();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Conexao.Close();
                    Conexao = null;
                    Comando = null;
                }
            }
            else
            {
                Exibir();
            }
        }
        //Método de quando abre a página Pedido
        private void Pedido_Load(object sender, EventArgs e)
        {
            cbFiltrar.SelectedIndex = 0;
            Exibir();
        }

        //Método para Organizar as Células da DataGridView 
        private void DgvPedido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Organizando Células que tem o tipo float para R$
            for (int i = 0; i < DgvPedido.Columns.Count; i++)
            {
                if (DgvPedido.Columns[i].ValueType == typeof(float))
                {
                    DgvPedido.Columns[i].DefaultCellStyle.Format = "C2";
                }
            }
            //-----------------------------------------------------------\\
            //Organizando as Cores das Células Baseado nos Status dos Pedidos 
            if (e.Value != null && e.Value.Equals("Finalizado"))
            {
                DgvPedido.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 255);
            }
            if (e.Value != null && e.Value.Equals("Entregue"))
            {
                DgvPedido.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            if (e.Value != null && e.Value.Equals("Montar Arte"))
            {
                DgvPedido.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 255);
            }
            if (e.Value != null && e.Value.Equals("Impressão"))
            {
                DgvPedido.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 255);
            }
            if (e.Value != null && e.Value.Equals("Aguardando Pagamento"))
            {
                DgvPedido.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            if (e.Value != null && e.Value.Equals("Produção"))
            {
                DgvPedido.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255);
            }

        }

        //Método para Filtrar dados de Pedidos baseado em um Combobox
        private void cbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltrar.Text == "Todas")
            {
                Exibir();
            }
            if (cbFiltrar.Text == "Montar Arte")
            {
                strSQL = "SELECT * FROM Pedido Where Status_Pedido = 'Montar Arte' ";
            }
            if (cbFiltrar.Text == "Impressão")
            {
                strSQL = "SELECT * FROM Pedido Where Status_Pedido = 'Impressão' ";
            }
            if (cbFiltrar.Text == "Produção")
            {
                strSQL = "SELECT * FROM Pedido Where Status_Pedido = 'Produção' ";
            }
            if (cbFiltrar.Text == "Finalizado")
            {
                strSQL = "SELECT * FROM Pedido Where Status_Pedido = 'Finalizado' ";
            }
            if (cbFiltrar.Text == "Entregue")
            {
                strSQL = "SELECT * FROM Pedido Where Status_Pedido = 'Entregue' ";
            }
            if (cbFiltrar.Text == "Aguardando Pagamento")
            {
                strSQL = "SELECT * FROM Pedido Where Status_Pedido = 'Aguardando Pagamento' ";
            }
            try
            {
                Connection();

                DataTable Dt = new DataTable();

                Da = new MySqlDataAdapter(strSQL, Conexao);

                Da.Fill(Dt);

                DgvPedido.DataSource = Dt;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Conexao.Close();
                Conexao = null;
                Comando = null;
            }
        }
        private void deleteOrder()
        {
            DialogResult dialogResult = new DialogResult();
            try
            {
                Connection();

                dialogResult = MessageBox.Show("Deseja Realmente Excluir esse Pedido?", "ATENÇAO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    strSQL = "DELETE FROM Pedido WHERE Id = @Id";

                    Comando = new MySqlCommand(strSQL, Conexao);
                    Comando.Parameters.AddWithValue("@Id", _getId);

                    Conexao.Open();
                    Comando.ExecuteNonQuery();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Conexao.Close();
                Conexao = null;
                Comando = null;
                Exibir();
            }
        }
        private void finançasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Financas financas = new Financas();
            financas.ShowDialog();
        }

        private void novoCliente_Click(object sender, EventArgs e)
        {
            CadastroPedidoView cadastroPedido = new CadastroPedidoView();
            cadastroPedido.Show();
        }
        private void editarCliente_Click(object sender, EventArgs e)
        {
            Edit = true;

            CadastroPedidoView cadastroPedido = new CadastroPedidoView();
            cadastroPedido.getIdPedido(_getId);
            cadastroPedido.getEdit(Edit);

            if (_getId != 0)
            {
                cadastroPedido.Show();
                cadastroPedido.getSelecionado();
            }
            else
            {
                MessageBox.Show("Selecione o pedido para editar.", "Atenção!!");
            }
        }
        private void excluirPedido_Click(object sender, EventArgs e)
        {
            deleteOrder();
            Exibir();
        }
        private void atualizarPedido_Click(object sender, EventArgs e)
        {
            Exibir();
        }

        private void DgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _getId = Convert.ToInt32(DgvPedido.CurrentRow.Cells[0].Value);
            DgvPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


    }
}

