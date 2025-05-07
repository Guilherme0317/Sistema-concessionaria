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
    public partial class Pesquisa_transacoes : Form
    {
        public MySqlConnection conexao;
        
        public Pesquisa_transacoes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Pesquisa_transacoes_Load(object sender, EventArgs e)
        {
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            using (conexao = new MySqlConnection(strConexao))
            {
                conexao.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_Veiculos", conexao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Dgv_Pesquisa.ForeColor = Color.Black;
                Dgv_Pesquisa.DataSource = dataTable;
                Dgv_Pesquisa.Columns["Id_Veiculo"].Visible = false; 
                Dgv_Pesquisa.Columns["Id_Cliente"].Visible = false;
                Dgv_Pesquisa.Columns["Marca"].Width = 80;
                Dgv_Pesquisa.Columns["Modelo"].Width = 80;
                Dgv_Pesquisa.Columns["Ano"].HeaderText = "Ano";
                Dgv_Pesquisa.Columns["Cor"].HeaderText = "Cor";
                Dgv_Pesquisa.Columns["Preco"].HeaderText = "Preço";
                Dgv_Pesquisa.Columns["Status"].HeaderText = "Status";
                conexao.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                Dgv_Pesquisa.DataSource = null;
                return;
            }

            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();
                string pesquisa = @"
            SELECT 
                c.Nome,
                v.Marca, 
                v.Modelo,              
                v.Ano,      
                v.Cor,    
                v.Preco,                
                t.Fmr_Pagmnt AS 'Forma de Pagamento',
                t.Data AS 'Data da Venda',
                c.Historico_compra      AS 'Histórico de Compras'
            FROM 
                tb_transacoes t
            INNER JOIN tb_clientes c ON t.Id_cliente = c.Id_Cliente
            INNER JOIN tb_veiculos v ON t.Id_veiculo = v.Id_veiculo
            INNER JOIN tb_usuarios u ON t.id_funcionario = u.Id_Usuario
            WHERE 
            v.Id_Veiculo = @Id_Veiculo
            ORDER BY 
                t.Data DESC";

                MySqlCommand command = new MySqlCommand(pesquisa, conexao);
                command.Parameters.AddWithValue("@Id_Veiculo", "%" + textBox1.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    Dgv_Pesquisa.DataSource = dataTable;
                }
                else
                {
                    Dgv_Pesquisa.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
