using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ENIR
{
    public partial class Historicodecompra : Form
    {
        public MySqlConnection conexao;
        public Historicodecompra()
        {
            InitializeComponent();
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            conexao = new MySqlConnection(strConexao);
        }

       

        private void Historicodecompra_Load(object sender, EventArgs e)
        {

        }

        private void Tb_consulta_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Tb_consulta.Text))
            {
              
                Dgv_historico.DataSource = null;
                return;
            }
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();


            string pesquisa = @" SELECT t.Nome AS Cliente,v.Marca,v.Modelo,v.Cor,v.Preco, tr.Data AS DataCompra,tr.Fmr_Pagmnt AS FormaPagamento
            FROM  tb_transacoes tr JOIN tb_clientes t ON tr.Id_cliente = t.Id_Cliente JOIN tb_veiculos v ON tr.Id_veiculo = v.Id_veiculo WHERE t.Nome LIKE @Nome";

                MySqlCommand command = new MySqlCommand(pesquisa, conexao);
                command.Parameters.AddWithValue("@Nome", "%" + Tb_consulta.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Dgv_historico.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_historico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
  }

