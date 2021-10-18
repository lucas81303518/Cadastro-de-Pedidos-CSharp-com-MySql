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
    public partial class Pedido : Form
    {
        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataAdapter Da;
        MySqlDataReader Dr;
        string strSQL;
        public Pedido()
        {
            InitializeComponent();
        }
        private void LimparTela()
        {
            txtPedido.Text = "";
            cbCliente_Pedido.Text = "";
            cbStatus.Text = "";
            txtProduto.Text = "";
            txtValTotal.Text = "";
            txtValPago.Text = "";
            txtCusto.Text = "";
            cbFormaPag.Text = "";
            dtPedido.Text = "";
        }
        private void Connection()
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();

                strSQL = "INSERT INTO Pedido (Produto, Cliente_Cadastrado, Valor_Total, Valor_Pago, Custo, Status_Pedido, Forma_Pagamento, Data_Pedido, Data_Entrega) VALUES (@Produto, @Cliente_Cadastrado, @Valor_Total, @Valor_Pago, @Custo, @Status_Pedido, @Forma_Pagamento, @Data_Pedido, @Data_Entrega)";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@Produto", txtProduto.Text);
                Comando.Parameters.AddWithValue("@Cliente_Cadastrado", cbCliente_Pedido.Text);
                Comando.Parameters.AddWithValue("@Status_Pedido", cbStatus.Text);
                Comando.Parameters.AddWithValue("@Valor_Total", txtValTotal.Text);
                Comando.Parameters.AddWithValue("@Valor_Pago", txtValPago.Text);
                Comando.Parameters.AddWithValue("@Custo", txtCusto.Text);
                Comando.Parameters.AddWithValue("@Forma_Pagamento", cbFormaPag.Text);
                Comando.Parameters.AddWithValue("@Data_Pedido", dtPedido.Text);
                Comando.Parameters.AddWithValue("@Data_Entrega", dtEntrega.Text);
                Conexao.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception Ex)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();

                strSQL = "UPDATE Pedido SET Produto = @Produto, Cliente_Cadastrado = @Cliente_Cadastrado, Valor_Total = @Valor_Total, Valor_Pago = @Valor_Pago, Custo = @Custo, Status_Pedido = @Status_Pedido, Forma_Pagamento = @Forma_Pagamento, Data_Pedido = @Data_Pedido, Data_Entrega = @Data_Entrega WHERE Num_Pedido = @Num_Pedido";
                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@Num_Pedido", txtPedido.Text);
                Comando.Parameters.AddWithValue("@Produto", txtProduto.Text);
                Comando.Parameters.AddWithValue("@Cliente_Cadastrado", cbCliente_Pedido.Text);
                Comando.Parameters.AddWithValue("@Status_Pedido", cbStatus.Text);
                Comando.Parameters.AddWithValue("@Valor_Total", txtValTotal.Text);
                Comando.Parameters.AddWithValue("@Valor_Pago", txtValPago.Text);
                Comando.Parameters.AddWithValue("@Custo", txtCusto.Text);
                Comando.Parameters.AddWithValue("@Forma_Pagamento", cbFormaPag.Text);
                Comando.Parameters.AddWithValue("@Data_Pedido", dtPedido.Text);
                Comando.Parameters.AddWithValue("@Data_Entrega", dtEntrega.Text);
                Conexao.Open();
                Comando.ExecuteNonQuery();
                LimparTela();
                MessageBox.Show("Pedido Editado com Sucesso!!");
              
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


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
                DialogResult dialogResult = new DialogResult();
                try
                {
                    Connection();
                    dialogResult = MessageBox.Show("Deseja Realmente Excluir esse Pedido?", "ATENÇAO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        strSQL = "DELETE FROM Pedido WHERE Num_Pedido = @Num_Pedido";

                        Comando = new MySqlCommand(strSQL, Conexao);
                        Comando.Parameters.AddWithValue("@Num_Pedido", txtPedido.Text);
                        Comando.Parameters.AddWithValue("@Produto", txtProduto.Text);

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
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Pedido WHERE Num_Pedido = @Num_Pedido";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@Num_Pedido", txtPedido.Text);

                Conexao.Open();
                Dr = Comando.ExecuteReader();

                while (Dr.Read())
                {
                    txtPedido.Text = Convert.ToString(Dr["Num_Pedido"]);
                    txtProduto.Text = Convert.ToString(Dr["Produto"]);
                    cbCliente_Pedido.Text = Convert.ToString(Dr["Cliente_Cadastrado"]);
                    cbStatus.Text = Convert.ToString(Dr["Status_Pedido"]);
                    txtValTotal.Text = Convert.ToString(Dr["Valor_Total"]);
                    txtValPago.Text = Convert.ToString(Dr["Valor_Pago"]);
                    txtCusto.Text = Convert.ToString(Dr["Custo"]);
                    cbFormaPag.Text = Convert.ToString(Dr["Forma_Pagamento"]);
                    dtPedido.Text = Convert.ToString(Dr["Data_Pedido"]);
                    dtEntrega.Text = Convert.ToString(Dr["Data_Entrega"]);
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

        private void btnExibir_Click(object sender, EventArgs e)
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
                    Comando.CommandText = "Select Pedido.Num_Pedido, Pedido.Produto, " +
                        "Pedido.Valor_Total, Pedido.Valor_Pago, Pedido.Forma_Pagamento, " +
                        "Pedido.Data_Pedido, Pedido.Data_Entrega From Pedido Where Pedido.Produto like ('%" + txtBusca.Text + "%')";
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

            }
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            Atualizar_Cliente();
        }
        private void Atualizar_Cliente()
        {
            Connection();
            Conexao.Close();
            Conexao.Open();
            Comando = new MySqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "Select Nome From Cliente";
            Dr = Comando.ExecuteReader();
            DataTable Dt = new DataTable();
            Dt.Load(Dr);
            cbCliente_Pedido.DisplayMember = "Nome";
            cbCliente_Pedido.DataSource = Dt;
        }

    }
}
