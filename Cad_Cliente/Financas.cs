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

namespace Cad_Cliente
{
    public partial class Financas : Form
    {
        MySqlConnection Conexao;
        MySqlCommand Comando;
        MySqlDataAdapter Da;
        string strSQL;
        public Financas()
        {
            InitializeComponent();
        }
        private void Connection()//Método de conexão com banco
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
        }

        private void Financas_Load(object sender, EventArgs e)
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Financas";

                DataTable Dt = new DataTable();

                Da = new MySqlDataAdapter(strSQL, Conexao);

                Da.Fill(Dt);

                DgvFinancas.DataSource = Dt;
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
    }
    }

