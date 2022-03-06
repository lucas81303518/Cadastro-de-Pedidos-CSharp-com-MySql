using System;
using System.Data;
using System.Windows.Forms;
using Cad_Cliente.Views;
using MySql.Data.MySqlClient;
namespace Cad_Cliente
{
    public partial class Cliente : Form
    {
        public int _getId = 0;
        public string _getNome { get; set; }

        public string _getNumero = "";

        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataAdapter Da;

        public bool Edit = false;//Variável de controle

        string strSQL;

        public Cliente()
        {
            InitializeComponent();
        }

        private void Connection()//Método de conexão com banco
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
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
            Exibir();
        }

        //Quando clicar  na célula ele pega o ID e Nome do Cliente
        private void DgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _getId = Convert.ToInt32(DgvCliente.CurrentRow.Cells[0].Value);
            _getNome = DgvCliente.CurrentRow.Cells[1].Value.ToString();
            _getNumero = DgvCliente.CurrentRow.Cells[2].Value.ToString();//Recebendo telefone do cliente
            _getNumero = String.Join("", System.Text.RegularExpressions.Regex.Split
                                    (_getNumero, @"[^\d]"));//Pegando somente os numeros do telefone
            DgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //Menu de Novo cliente
        private void NovoCliente_Click(object sender, EventArgs e)
        {
            CadastroClienteView cadastroCliente = new CadastroClienteView(this);
            cadastroCliente.Show();
        }
        public void EditarCliente_Click(object sender, EventArgs e)
        {
            Edit = true;

            CadastroClienteView cadastroCliente = new CadastroClienteView(this);
            cadastroCliente.getIdNomeClient(_getId, _getNome);
            cadastroCliente.getEdit(Edit);
            if (_getId != 0)
            {
                cadastroCliente.Show();
                cadastroCliente.getSelecionado();
            }
            else
            {
                MessageBox.Show("Selecione o cliente para editar.", "Atenção!!");
            }
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

        private void menuItemWhatsapp_Click(object sender, EventArgs e)
        {
            if (_getId != 0 && _getNumero == "")
            {
                MessageBox.Show("O cliente selecionado nao possui número \nde telefone cadastrado",
                                        "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (_getId == 0 && _getNumero == "")
            {
                MessageBox.Show("Selecione o cliente para acessar o Whatsapp", "Atenção!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                System.Diagnostics.Process.Start("chrome.exe",
               $"https://api.whatsapp.com/send?1=pt_BR&phone=55{_getNumero}");
            }

        }

    }
}