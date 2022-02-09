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
using Newtonsoft.Json;
using System.IO;

namespace Cad_Cliente.Views
{
    public partial class CadastroPedidoView : Form
    {
        public int _getId;
        public bool Edit;
        public int id;

        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataReader Dr;

        string strSQL;
        public CadastroPedidoView()
        {
            InitializeComponent();
        }
        private void Connection()
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
        }
        private void LimparTela()
        {
            cbCliente_Pedido.Text = "";
            cbStatus.Text = "";
            txtProduto.Text = "";
            txtValTotal.Text = "";
            txtValPago.Text = "";
            txtCusto.Text = "";
            cbFormaPag.Text = "";
            dtPedido.Text = "";
        }
        public void pegaIdForeignKey()
        {
            Connection();

            Conexao.Open();

            strSQL = "SELECT Id FROM CLIENTE WHERE Nome = @Cliente_Cadastrado";

            Comando = new MySqlCommand(strSQL, Conexao);

            Comando.Parameters.AddWithValue("@Cliente_Cadastrado", cbCliente_Pedido.Text);
            Dr = Comando.ExecuteReader();

            while (Dr.Read())
            {
                id = Convert.ToInt32(Dr["Id"]);
            }

            Conexao.Close();
            Comando = null;
            strSQL = "";
        }
       
        public void newPedido()
        {
            try
            {
                pegaIdForeignKey();

                strSQL = "INSERT INTO Pedido (Produto, Cliente_Cadastrado, Valor_Total, Valor_Pago, Custo," +
                    " Status_Pedido, Forma_Pagamento, Data_Pedido, Data_Entrega, FK_Id_Cliente)" +
                    " VALUES (@Produto, @Cliente_Cadastrado, @Valor_Total, @Valor_Pago, @Custo, @Status_Pedido," +
                    " @Forma_Pagamento, @Data_Pedido, @Data_Entrega, @ClienteId)";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@Produto", txtProduto.Text);
                Comando.Parameters.AddWithValue("@Cliente_Cadastrado", cbCliente_Pedido.Text);
                Comando.Parameters.AddWithValue("@Status_Pedido", cbStatus.Text);
                Comando.Parameters.AddWithValue("@Valor_Total", Convert.ToDouble(txtValTotal.Text));
                Comando.Parameters.AddWithValue("@Valor_Pago", Convert.ToDouble(txtValPago.Text));
                Comando.Parameters.AddWithValue("@Custo", Convert.ToDouble(txtCusto.Text));
                Comando.Parameters.AddWithValue("@Forma_Pagamento", cbFormaPag.Text);
                Comando.Parameters.AddWithValue("@Data_Pedido", dtPedido.Value.Date);
                Comando.Parameters.AddWithValue("@Data_Entrega", dtEntrega.Value.Date);
                Comando.Parameters.AddWithValue("@ClienteId", id);
                Conexao.Open();
                Comando.ExecuteNonQuery();
                LimparTela();
                Hide();
            }
            catch (Exception Ex)
            {
                if (txtValTotal.Text == "")
                {
                    MessageBox.Show("Preencha o campo de Valor Total", "ATENÇAO!!", MessageBoxButtons.OK);
                    txtValTotal.Focus();
                }
                else if (txtValPago.Text == "")
                {
                    MessageBox.Show("Preencha o campo de Valor Pago", "ATENÇAO!!", MessageBoxButtons.OK);
                    txtValPago.Focus();
                }
                else if (txtCusto.Text == "")
                {
                    MessageBox.Show("Preencha o campo de Custo", "ATENÇAO!!", MessageBoxButtons.OK);
                    txtCusto.Focus();
                }
            }
            finally
            {
                Conexao.Close();
                Conexao = null;
                Comando = null;
            }
        }
        public void updatePedido()
        {
            try
            {
                pegaIdForeignKey();

                strSQL = "UPDATE Pedido SET Produto = @Produto, Cliente_Cadastrado = @Cliente_Cadastrado," +
                    " Valor_Total = @Valor_Total, Valor_Pago = @Valor_Pago, Custo = @Custo," +
                    " Status_Pedido = @Status_Pedido, Forma_Pagamento = @Forma_Pagamento, Data_Pedido = @Data_Pedido," +
                    " Data_Entrega = @Data_Entrega, FK_Id_Cliente = @ClienteId WHERE Id = @Id";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@Id", _getId);
                Comando.Parameters.AddWithValue("@Produto", txtProduto.Text);
                Comando.Parameters.AddWithValue("@Cliente_Cadastrado", cbCliente_Pedido.Text);
                Comando.Parameters.AddWithValue("@Status_Pedido", cbStatus.Text);
                Comando.Parameters.AddWithValue("@Valor_Total", Convert.ToDouble(txtValTotal.Text));
                Comando.Parameters.AddWithValue("@Valor_Pago", Convert.ToDouble(txtValPago.Text));
                Comando.Parameters.AddWithValue("@Custo", Convert.ToDouble(txtCusto.Text));
                Comando.Parameters.AddWithValue("@Forma_Pagamento", cbFormaPag.Text);
                Comando.Parameters.AddWithValue("@Data_Pedido", DateTime.Parse(dtPedido.Text));
                Comando.Parameters.AddWithValue("@Data_Entrega", DateTime.Parse(dtEntrega.Text));
                Comando.Parameters.AddWithValue("@ClienteId", id);

                Conexao.Open();
                Comando.ExecuteNonQuery();

                LimparTela();
                Hide();
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
        public void getSelecionado()
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Pedido WHERE Id = @Id";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@ID", _getId);

                Conexao.Open();
                Dr = Comando.ExecuteReader();

                while (Dr.Read())
                {
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
        //Método para pegar os Clientes que foram cadastrados e passar para o Combobox da Tabela Pedido
        private void Atualizar_Cliente()
        {
                Connection();
                Conexao.Open();
                Comando = new MySqlCommand();
                Comando.Connection = Conexao;
                Comando.CommandText = "Select Nome From Cliente order by Id desc";
                Dr = Comando.ExecuteReader();
                DataTable Dt = new DataTable();
                Dt.Load(Dr);
                cbCliente_Pedido.DisplayMember = "Nome";
                cbCliente_Pedido.DataSource = Dt;
                Conexao.Close();
                Comando = null;
            
        }

        private void CadastroPedido_Load(object sender, EventArgs e)
        {
            Atualizar_Cliente();
        }
        public void getEdit(bool edit)
        {
            Edit = edit;
        }
        public void getIdPedido(int id)
        {
            _getId = id;
        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            if (!Edit)
            {
                // Aqui estara Incluindo um Novo cliente
                newPedido();
            }
            else
            {
                //Aqui estara Editando um cliente existente
                updatePedido();
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

