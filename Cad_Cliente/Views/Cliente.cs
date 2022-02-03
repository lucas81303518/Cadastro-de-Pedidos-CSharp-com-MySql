using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cad_Cliente.Views;
using Correios.Net;
using MySql.Data.MySqlClient;
namespace Cad_Cliente
{
    public partial class Cliente : Form
    {
       
        private int _getId;
        private string _getNome;

        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataAdapter Da;
        
        string strSQL;

        public Cliente()
        {
            InitializeComponent();
        }

        private void Connection()//Método de conexão com banco
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
        }

        private void toolTip()
        {
            

        }

        public void Exibir()
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Cliente";

                DataTable Dt = new DataTable();

                Da = new MySqlDataAdapter(strSQL, Conexao);

                Da.Fill(Dt);

                DgvCliente.DataSource = Dt;
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

        private void Cliente_Load(object sender, EventArgs e)
        {
            toolTip();
            Exibir();
        }


        private void DgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)//Quando clicar ele
                                                                                     //pega o ID e Nome do Cliente
        {
            _getId = Convert.ToInt32(DgvCliente.CurrentRow.Cells[0].Value);
            _getNome = DgvCliente.CurrentRow.Cells[1].Value.ToString();

        }
        //Menu de Novo cliente
        private void novoCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();

            Exibir();
        }

        private void editarCliente_Click(object sender, EventArgs e)
        {
         
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.EditarCliente(_getId, _getNome);
            cadastroCliente.Show();

            Exibir();
        }
        private void excluirCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.ExcluirCliente(_getId, _getNome);
            Exibir();
        }
        
        //Método para cada vez que alterar os dados do Textbox
        //ele procurar o nome do cliente desejado
        private void txtBusca_Cliente_TextChanged(object sender, EventArgs e)
        {
         
            if (txtBusca_Cliente.Text != "")
            {
                try
                {
                    Connection();

                    Conexao.Open();

                    Comando = new MySqlCommand();

                    Comando.CommandText = "Select * from Cliente " +
                        "Where Cliente.Nome like ('%" + txtBusca_Cliente.Text + "%')";

                    Comando.Connection = Conexao;

                    Da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();

                    Da.SelectCommand = Comando;
                    Da.Fill(dt);
                    DgvCliente.DataSource = dt;
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

        private void atualizarCliente_Click(object sender, EventArgs e)
        {
            Exibir();
        }

        
    }
}

