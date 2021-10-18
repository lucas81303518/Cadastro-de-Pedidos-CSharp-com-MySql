using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Cad_Cliente
{
    public partial class Cliente : Form
    {
        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataAdapter Da;
        MySqlDataReader Dr;
        string strSQL;
        public Cliente( )
        {
            InitializeComponent();
        }
       
        //Metodo de Limpar Tela
        private void LimparTela()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtTel.Text = "";
            txtEnd.Text = "";
            txtNum.Text = "";
            txtCep.Text = "";
            txtInstagram.Text = "";
        }
        private void Connection()//Método de conexão com banco
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
        }

        //Metodo para criar novo cliente
        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();

                strSQL = "INSERT INTO Cliente (NOME, TELEFONE, ENDEREÇO, NUMERO, CEP, INSTAGRAM) VALUES ( @NOME, @TELEFONE, @ENDEREÇO, @NUMERO, @CEP, @INSTAGRAM)";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                Comando.Parameters.AddWithValue("@TELEFONE", txtTel.Text);
                Comando.Parameters.AddWithValue("@ENDEREÇO", txtEnd.Text);
                Comando.Parameters.AddWithValue("@NUMERO", txtNum.Text);
                Comando.Parameters.AddWithValue("@CEP", txtCep.Text);
                Comando.Parameters.AddWithValue("@INSTAGRAM", txtInstagram.Text);
                Conexao.Open();
                Comando.ExecuteNonQuery();
              
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                LimparTela();
                Conexao.Close();
                Conexao = null;
                Comando = null;
            }
        }
        //Metodo para editar cliente
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();

                strSQL = "UPDATE Cliente SET NOME = @NOME, TELEFONE = @TELEFONE, ENDEREÇO = @ENDEREÇO, NUMERO = @NUMERO, CEP = @CEP, INSTAGRAM = @INSTAGRAM WHERE ID = @ID";
                    
                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@ID", txtID.Text);
                Comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                Comando.Parameters.AddWithValue("@TELEFONE", txtTel.Text);
                Comando.Parameters.AddWithValue("@ENDEREÇO", txtEnd.Text);
                Comando.Parameters.AddWithValue("@NUMERO", txtNum.Text);
                Comando.Parameters.AddWithValue("@CEP", txtCep.Text);
                Comando.Parameters.AddWithValue("@INSTAGRAM", txtInstagram.Text);
                Conexao.Open();
                Comando.ExecuteNonQuery();
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
        //Metodo para excluir cliente
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = new DialogResult();
            try
            {
                Connection();
                dialogResult = MessageBox.Show("Deseja Realmente Excluir esse Cliente?", "ATENÇAO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)

                {
                    strSQL = "DELETE FROM Cliente WHERE ID = @ID";

                    Comando = new MySqlCommand(strSQL, Conexao);
                    Comando.Parameters.AddWithValue("@ID", txtID.Text);
                    Comando.Parameters.AddWithValue("@Nome", txtNome.Text);

                    Conexao.Open();
                    Comando.ExecuteNonQuery();
                }
                else
                {

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
            }
        }
        //Metodo de consultar cliente
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Cliente WHERE ID = @ID";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@ID", txtID.Text);

                Conexao.Open();
                Dr = Comando.ExecuteReader();

                while (Dr.Read())
                {
                    txtNome.Text = Convert.ToString(Dr["Nome"]);
                    txtTel.Text = Convert.ToString(Dr["Telefone"]);
                    txtEnd.Text = Convert.ToString(Dr["Endereço"]);
                    txtNum.Text = Convert.ToString(Dr["Numero"]);
                    txtCep.Text = Convert.ToString(Dr["Cep"]);
                    txtInstagram.Text = Convert.ToString(Dr["Instagram"]);
                   
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
            }
        }
        //Metodo de exibir dados do cliente
        private void btnExibir_Click(object sender, EventArgs e)
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

            if (txtBusca.Text != "")
            {
                try
                {
                    Connection();

                    Conexao.Open();
                    Comando = new MySqlCommand();
                    Comando.CommandText = "Select Cliente.ID, Cliente.Nome, " +
                        "Cliente.Telefone, Cliente.Endereço, Cliente.Numero, " +
                        "Cliente.Cep, Cliente.Instagram From Cliente Where Cliente.Nome like ('%"+txtBusca.Text +"%')";
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
            else { 

                 }
        }
        //Evento quando clica em Pedido
        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.ShowDialog();
        }
        //Evento quando clica em Finanças
        private void finançasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financas financas = new Financas();
            financas.ShowDialog();
        }
    }
}

