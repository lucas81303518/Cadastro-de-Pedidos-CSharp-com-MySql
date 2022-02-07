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
    public partial class CadastroClienteView : Form
    {

        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataReader Dr;

        string strSQL;

        public bool Edit = false; //Variavel de controle 
        public int _getId;//Variavel para guardar o Id do cliente  
        public string _getNome;

        public CadastroClienteView()
        {
            InitializeComponent();

        }

        private void Connection()//Método de conexão com banco
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
        }
        //Método de limpar campos
        private void cleanScreen()
        {
            txtNome.Text = "";
            txtTel.Text = "";
            txtCep.Text = "";
            txtEnd.Text = "";
            txtInstagram.Text = "";
            txtNum.Text = "";
        }
        //Método para adicionar novo cliente no banco  de dados
        public void newClient()
        {
            try
            {
                Connection();

                strSQL = "INSERT INTO Cliente (NOME, TELEFONE,ESTADO, CIDADE, ENDEREÇO, NUMERO, CEP, INSTAGRAM)" +
                                " VALUES ( @NOME, @TELEFONE,@ESTADO, @CIDADE, @ENDEREÇO, @NUMERO, @CEP, @INSTAGRAM)";
                
                Comando = new MySqlCommand(strSQL, Conexao);
                Comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                Comando.Parameters.AddWithValue("@TELEFONE", txtTel.Text);
                Comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
                Comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                Comando.Parameters.AddWithValue("@ENDEREÇO", txtEnd.Text);
                Comando.Parameters.AddWithValue("@NUMERO", txtNum.Text);
                Comando.Parameters.AddWithValue("@CEP", txtCep.Text);
                Comando.Parameters.AddWithValue("@INSTAGRAM", txtInstagram.Text);
                Conexao.Open();
                Comando.ExecuteNonQuery();
                Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                MessageBox.Show($"Cliente {txtNome.Text} cadastrado com sucesso", "Parabéns!!");
                cleanScreen();
                Conexao.Close();
                Conexao = null;
                Comando = null;
                
            }
        }
        //Método para atualizar o cliente selecionado.
        public void updateClient()
        {
            DialogResult dialogResult = new DialogResult();
            try
            {
                Connection();

                if (txtNome.Text != "")
                {
                    dialogResult = MessageBox.Show($"Deseja alterar o cliente {_getNome} ?", "ATENÇAO!!",
                                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)

                        strSQL = "UPDATE Cliente SET NOME = @NOME, TELEFONE = @TELEFONE,ESTADO = @ESTADO," +
                                " CIDADE = @CIDADE, ENDEREÇO = @ENDEREÇO, NUMERO = @NUMERO, CEP = @CEP," +
                                " INSTAGRAM = @INSTAGRAM WHERE ID = @ID";

                    Comando = new MySqlCommand(strSQL, Conexao);
                    Comando.Parameters.AddWithValue("@ID", _getId);
                    Comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                    Comando.Parameters.AddWithValue("@TELEFONE", txtTel.Text);
                    Comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
                    Comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                    Comando.Parameters.AddWithValue("@ENDEREÇO", txtEnd.Text);
                    Comando.Parameters.AddWithValue("@NUMERO", txtNum.Text);
                    Comando.Parameters.AddWithValue("@CEP", txtCep.Text);
                    Comando.Parameters.AddWithValue("@INSTAGRAM", txtInstagram.Text);
                    Conexao.Open();
                    Comando.ExecuteNonQuery();

                    cleanScreen();
                }
                else
                {
                    MessageBox.Show("Campos não preenchidos para edição!!");
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
        public void getSelecionado()
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
                    txtEstado.Text = Convert.ToString(Dr["Estado"]);
                    txtCidade.Text = Convert.ToString(Dr["Cidade"]);
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
        
        //Botao de salvar
        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            if (!Edit)
            {
                // Aqui estara Incluindo um Novo cliente
                newClient();
            }
            else
            {
                //Aqui estara Editando um cliente existente
                updateClient();
            }
        }
        public void consultaCep()
        {

            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                try
                {
                    using (var ws = new WSCorreios.AtendeClienteClient())
                    {

                        var endereco = ws.consultaCEP(txtCep.Text.Trim());
                        txtEnd.Text = endereco.end;
                        txtEstado.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Informe um Cep válido!!'");
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Pegando Id e Nome do cliente que foi selecionado na classe Cliente
        public void getIdNomeClient(int id, string nome)
        {
            _getId = id;
            _getNome = nome;
        }
        //Pegando valor da variavel Edit na classe Cliente
        public void getEdit(bool edit)
        {
            Edit = edit;
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            consultaCep();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
