using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cad_Cliente
{
    public partial class Financas : Form
    {
        MySqlConnection Conexao;
        MySqlDataAdapter Da;
        string strSQL;
        public Financas()
        {
            InitializeComponent();
        }
        private void Connection()//Método de conexão com banco
        {
            Conexao = new MySqlConnection("Server=localhost;Database=cad_clientes;Uid=root;Pwd=root;");
            Conexao.Open();
        }
        private void ExibirDetalhado()
        {
            try
            {
                Connection();

                strSQL = "SELECT * FROM Pedido Where Data_Pedido BETWEEN @De AND @Ate";

                DataTable Dt = new DataTable();

                Da = new MySqlDataAdapter(strSQL, Conexao);

                Da.SelectCommand.Parameters.AddWithValue("@De", dtFiltroDe.Value.ToString(("yyyy/MM/dd"))
                                                                                .Substring(0, 10));
                Da.SelectCommand.Parameters.AddWithValue("@Ate", dtFiltroAte.Value.ToString("yyyy/MM/dd")
                                                                                .Substring(0, 10));
                Da.Fill(Dt);

                DgvFinanca.DataSource = Dt;
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Conexao.Close();
                Conexao = null;

            }
        }
        private void Exibir()
        {
            try
            {
                Connection();

                strSQL = "SELECT Sum(Valor_Total) as Vendas_Total, (Sum(Lucro))as Lucro_Total, " +
                    "(Sum(Custo))as Gasto_Total FROM Pedido Where Data_Pedido BETWEEN @De AND @Ate";

                DataTable Dt = new DataTable();

                Da = new MySqlDataAdapter(strSQL, Conexao);

                Da.SelectCommand.Parameters.AddWithValue("@De", dtFiltroDe.Value.ToString(("yyyy/MM/dd"))
                                                                                .Substring(0, 10));
                Da.SelectCommand.Parameters.AddWithValue("@Ate", dtFiltroAte.Value.ToString("yyyy/MM/dd")
                                                                                .Substring(0, 10));
                Da.Fill(Dt);

                DgvFinanca.DataSource = Dt;
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Conexao.Close();
                Conexao = null;

            }
        }
      
        private void DgvFinanca_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < DgvFinanca.Columns.Count; i++)
            {
                if (DgvFinanca.Columns[i].ValueType == typeof(float) || DgvFinanca.Columns.Count == 3)
                {
                    DgvFinanca.Columns[i].DefaultCellStyle.Format = "C2";
                }
            }
        }

        private void dtFiltroAte_ValueChanged(object sender, EventArgs e)
        {
            filtrarFinancas();
        }

        private void dtFiltroDe_ValueChanged(object sender, EventArgs e)
        {
            filtrarFinancas();
        }
        private void filtrarFinancas()
        {
            if (cbFiltroFinancas.Text == "Valor Total")
            {
                Exibir();
            }
            else if (cbFiltroFinancas.Text == "Valor Detalhado")
            {
                ExibirDetalhado();
            }
            else
            {
                MessageBox.Show("Selecione a maneira de exibir!!");
                cbFiltroFinancas.Focus();
            }
        }
        private void cbFiltroFinancas_SelectedValueChanged(object sender, EventArgs e)
        {
            filtrarFinancas();
        }

        private void Financas_Load(object sender, EventArgs e)
        {
            Exibir();
        }
    }
}

