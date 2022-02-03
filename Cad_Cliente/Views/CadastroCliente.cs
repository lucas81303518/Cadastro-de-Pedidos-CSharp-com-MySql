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

namespace Cad_Cliente.Views
{
    public partial class CadastroCliente : Form
    {

        public int cont = 0;//Gambiarra

        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataReader Dr;

        string strSQL;

        public bool Edit = false; //Variavel de controle 
        public int _getId;//É vazio até chamar o Editar
        public string _getNome;//É vazio até chamar o Editar

        public CadastroCliente()
        {
            InitializeComponent();
           
        }

        private void Connection()//Método de conexão com banco
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
        }
        private void LimparTela()
        {
            txtNome.Text = "";
            txtTel.Text = "";
            txtCep.Text = "";
            txtEnd.Text = "";
            //txtEstado.Text = "";
            txtInstagram.Text = "";
            txtNum.Text = "";
            //txtCidade.Text = "";

        }

        public void NewCliente()
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
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                MessageBox.Show($"Cliente {txtNome.Text} cadastrado com sucesso", "Parabéns!!");
                LimparTela();
                Conexao.Close();
                Conexao = null;
                Comando = null;
                Hide();
            }
        }
        public void EditarCliente(int id, string nome)
        {

            cont++;//Gambiarra que nao sei o que fazer

            Edit = true;

            _getId = id;
            _getNome = nome;



            DialogResult dialogResult = new DialogResult();

            try
            {
                Connection();

                if (txtNome.Text != "")
                {
                    dialogResult = MessageBox.Show($"Deseja alterar o cliente {_getNome} ?", "ATENÇAO!!",
                                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)

                        strSQL = "UPDATE Cliente SET NOME = @NOME, TELEFONE = @TELEFONE, ENDEREÇO = @ENDEREÇO, NUMERO = @NUMERO, CEP = @CEP, INSTAGRAM = @INSTAGRAM WHERE ID = @ID";

                    Comando = new MySqlCommand(strSQL, Conexao);
                    Comando.Parameters.AddWithValue("@ID", _getId);
                    Comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                    Comando.Parameters.AddWithValue("@TELEFONE", txtTel.Text);
                    Comando.Parameters.AddWithValue("@ENDEREÇO", txtEnd.Text);
                    Comando.Parameters.AddWithValue("@NUMERO", txtNum.Text);
                    Comando.Parameters.AddWithValue("@CEP", txtCep.Text);
                    Comando.Parameters.AddWithValue("@INSTAGRAM", txtInstagram.Text);
                    Conexao.Open();
                    Comando.ExecuteNonQuery();

                    LimparTela();
                }
                else
                {
                    if (cont > 1)
                    {
                        MessageBox.Show("Campos não preenchidos para edição!!");

                    }
                    else
                    {
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
                Hide();
            }


        }
        //Ao selecionar um cliente da tabela ele pega o Id do cliente
        //e retorna as informações para os textbox
        public void pegaSelecionado()
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Cliente WHERE ID = @ID";

                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@ID", _getId);

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
        public void ExcluirCliente(int id, string nome)
        {
            _getId = id;
            _getNome = nome;
            DialogResult dialogResult = new DialogResult();
            try
            {
                Connection();

                dialogResult = MessageBox.Show($"Deseja Realmente Excluir o Cliente {_getNome} ?", "ATENÇAO!!",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)

                {
                    strSQL = "DELETE FROM Cliente WHERE ID = @ID";

                    Comando = new MySqlCommand(strSQL, Conexao);
                    Comando.Parameters.AddWithValue("@ID", _getId);
                    Comando.Parameters.AddWithValue("@Nome", txtNome.Text);

                    Conexao.Open();
                    Comando.ExecuteNonQuery();

                    LimparTela();
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

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            if (!Edit)
            {
                // Aqui estara Incluindo um Novo cliente
                NewCliente();

            }
            else
            {
                //Aqui estara Editando um cliente existente
                EditarCliente(_getId, _getNome);

            }

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            pegaSelecionado();
        }
    }
}
