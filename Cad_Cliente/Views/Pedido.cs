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
            Exibir();
        }
        //Método de Limpar dados da Tela
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
        //Método de Conexão com Banco de dados
        private void Connection()
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
        }
        //Método de Adicionar novo Pedido
        private void btnNovo_Click(object sender, EventArgs e)
        {

            try
            {
                Connection();

                strSQL = "INSERT INTO Pedido (Produto, Cliente_Cadastrado, Valor_Total, Valor_Pago, Custo," +
                    " Status_Pedido, Forma_Pagamento, Data_Pedido, Data_Entrega)" +
                    " VALUES (@Produto, @Cliente_Cadastrado, @Valor_Total, @Valor_Pago, @Custo, @Status_Pedido," +
                    " @Forma_Pagamento, @Data_Pedido, @Data_Entrega)";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@Produto", txtProduto.Text);
                Comando.Parameters.AddWithValue("@Cliente_Cadastrado", cbCliente_Pedido.Text);
                Comando.Parameters.AddWithValue("@Status_Pedido", cbStatus.Text);
                Comando.Parameters.AddWithValue("@Valor_Total", Convert.ToDouble(txtValTotal.Text));
                Comando.Parameters.AddWithValue("@Valor_Pago", Convert.ToDouble(txtValPago.Text));
                Comando.Parameters.AddWithValue("@Custo", Convert.ToDouble(txtCusto.Text));
                Comando.Parameters.AddWithValue("@Forma_Pagamento", cbFormaPag.Text);
                Comando.Parameters.AddWithValue("@Data_Pedido", DateTime.Parse(dtPedido.Text));
                Comando.Parameters.AddWithValue("@Data_Entrega", DateTime.Parse(dtEntrega.Text));

                Conexao.Open();
                Comando.ExecuteNonQuery();
                LimparTela();
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
                Exibir();
            }
        }
        //Método de Editar Pedidos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtPedido.Text != "")
            {
                try
                {
                    Connection();

                    strSQL = "UPDATE Pedido SET Produto = @Produto, Cliente_Cadastrado = @Cliente_Cadastrado," +
                        " Valor_Total = @Valor_Total, Valor_Pago = @Valor_Pago, Custo = @Custo," +
                        " Status_Pedido = @Status_Pedido, Forma_Pagamento = @Forma_Pagamento, Data_Pedido = @Data_Pedido," +
                        " Data_Entrega = @Data_Entrega WHERE ID = @ID";

                    Comando = new MySqlCommand(strSQL, Conexao);
                    Comando.Parameters.AddWithValue("@ID", txtPedido.Text);
                    Comando.Parameters.AddWithValue("@Produto", txtProduto.Text);
                    Comando.Parameters.AddWithValue("@Cliente_Cadastrado", cbCliente_Pedido.Text);
                    Comando.Parameters.AddWithValue("@Status_Pedido", cbStatus.Text);
                    Comando.Parameters.AddWithValue("@Valor_Total", Convert.ToDouble(txtValTotal.Text));
                    Comando.Parameters.AddWithValue("@Valor_Pago", Convert.ToDouble(txtValPago.Text));
                    Comando.Parameters.AddWithValue("@Custo", Convert.ToDouble(txtCusto.Text));
                    Comando.Parameters.AddWithValue("@Forma_Pagamento", cbFormaPag.Text);
                    Comando.Parameters.AddWithValue("@Data_Pedido", DateTime.Parse(dtPedido.Text));
                    Comando.Parameters.AddWithValue("@Data_Entrega", DateTime.Parse(dtEntrega.Text));
                    Conexao.Open();
                    Comando.ExecuteNonQuery();

                    LimparTela();
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
            else
            {
                MessageBox.Show("Digite o ID do Pedido que deseja Editar!!");
            }
        }
        //Método de Excluir um determinado pedido pelo seu ID
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = new DialogResult();
            try
            {
                Connection();
                if (txtPedido.Text != "")
                {
                    dialogResult = MessageBox.Show("Deseja Realmente Excluir esse Pedido?", "ATENÇAO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        strSQL = "DELETE FROM Pedido WHERE ID = @ID";

                        Comando = new MySqlCommand(strSQL, Conexao);
                        Comando.Parameters.AddWithValue("@ID", txtPedido.Text);
                        Comando.Parameters.AddWithValue("@Produto", txtProduto.Text);

                        Conexao.Open();
                        Comando.ExecuteNonQuery();
                    }
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
        //Método que retorna para tela um determinado pedido pelo ID
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Pedido WHERE ID = @ID";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@ID", txtPedido.Text);

                Conexao.Open();
                Dr = Comando.ExecuteReader();

                while (Dr.Read())
                {
                    txtPedido.Text = Convert.ToString(Dr["ID"]);
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
        //Método de Exibir Pedidos
        private void Exibir()
        {

            try
            {
                Connection();

                strSQL = "SELECT * FROM Pedido Order by ID Desc";

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

                    Comando.CommandText = "Select * From Pedido" +
                        " Where Pedido.Cliente_Cadastrado like('%" + txtBusca_Pedido.Text + "%')";
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
            Atualizar_Cliente();
            cbFiltrar.SelectedIndex = 0;
            Exibir();
            toolTip();

        }
        //Método para quando passar o mouse em cima dos botões ele mostrar o que ele faz
        private void toolTip()
        {
            tp_Novo.SetToolTip(btnNovo, "Este botão irá adicionar um novo pedido.");
            tp_Editar.SetToolTip(btnEditar, "Este botão irá editar um pedido com base no Numero de Pedido.");
            tp_Consultar.SetToolTip(btnConsultar, "Este botão irá trazer para tela um pedido já cadastrado com base no Numero de Pedido.");
            tp_Excluir.SetToolTip(btnExcluir, "Este botão irá excluir um pedido com base no Numero de Pedido.");
        }
        //Método para pegar os Clientes que foram cadastrados e passar para o Combobox da Tabela Pedido
        private void Atualizar_Cliente()
        {
            Connection();
            Conexao.Close();
            Conexao.Open();
            Comando = new MySqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "Select Nome From Cliente order by ID desc";
            Dr = Comando.ExecuteReader();
            DataTable Dt = new DataTable();
            Dt.Load(Dr);
            cbCliente_Pedido.DisplayMember = "Nome";
            cbCliente_Pedido.DataSource = Dt;
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
        //Método para abrir a Tela de Cliente
        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            this.Hide();
            cliente.ShowDialog();
        }
        //Método para abrir a Tela de Finanças
        private void finançasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Financas financas = new Financas();
            financas.ShowDialog();
        }
       
       
    }
}
