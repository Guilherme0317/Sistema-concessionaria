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

namespace Projeto_ENIR
{
    public partial class Compra_veiculo : Form
    {
        public MySqlConnection conexao;
       
        public Compra_veiculo()
        {
            InitializeComponent();
        }

        private void Compra_veiculo_Load(object sender, EventArgs e)
        {
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            using (conexao = new MySqlConnection(strConexao))
            {
                conexao.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_veiculos WHERE Id_cliente IS NULL", conexao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Dgv_veiculos.ForeColor = Color.Black;
                Dgv_veiculos.DataSource = dataTable;
                Dgv_veiculos.Columns["Id_veiculo"].Visible = false;
                Dgv_veiculos.Columns["Id_cliente"].Visible = false;

                Dgv_veiculos.Columns["Marca"].HeaderText = "Marca";
                Dgv_veiculos.Columns["Modelo"].HeaderText = "Modelo";
                Dgv_veiculos.Columns["Ano"].HeaderText = "Ano De Lançamento";
                Dgv_veiculos.Columns["Cor"].HeaderText = "Cor";
                Dgv_veiculos.Columns["Preco"].HeaderText = "Preço (R$)";
                Dgv_veiculos.Columns["Preco"].DefaultCellStyle.Format = "C2";
                Dgv_veiculos.Columns["Status"].HeaderText = "Status";
               


            }
        }

        private void Btn_compra_Click(object sender, EventArgs e)
        {
            if (Dgv_veiculos.SelectedRows.Count > 0)
            {
                
                var valorIdVeiculo = Dgv_veiculos.SelectedRows[0].Cells["Id_veiculo"].Value;
                if (valorIdVeiculo == null || valorIdVeiculo == DBNull.Value)
                {
                    MessageBox.Show("Nenhum Veículo Selecionado!!");
                    return;
                }

                
                int idVeiculoSelecionado = Convert.ToInt32(valorIdVeiculo);

               
                int idClienteSelecionado = 1;
                MenudeCompra menudeCompra = new MenudeCompra(idVeiculoSelecionado, idClienteSelecionado);
                menudeCompra.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um veículo para comprar.");
            }

        }

        private void Tb_comprar_TextChanged(object sender, EventArgs e)
        {
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_veiculos WHERE Marca LIKE @Marca AND Id_cliente IS NULL", conexao);
                command.Parameters.AddWithValue("@Marca", "%" + Tb_comprar.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Dgv_veiculos.DataSource = dataTable;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dgv_veiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

