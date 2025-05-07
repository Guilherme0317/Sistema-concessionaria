using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_ENIR
{
    public partial class RelatorioVenda : Form
    {
        public MySqlConnection conexao;

        public RelatorioVenda()
        {
            InitializeComponent();
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            conexao = new MySqlConnection(strConexao);
        }

        private void RelatorioVenda_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();


                string relatorio = @"
                              SELECT
                                  u.Nome_Usuario AS 'Vendedor', 
                                  c.Nome AS 'Cliente',              
                                  v.Marca AS 'Marca do Carro',      
                                  v.Modelo AS 'Modelo do Carro',    
                                  t.Valor AS 'Preço',                
                                  t.Fmr_Pagmnt AS 'Forma de Pagamento',
                                  t.Data AS 'Data da Venda'
                              FROM 
                                  tb_transacoes t
                              INNER JOIN tb_clientes c ON t.Id_cliente = c.Id_Cliente
                              INNER JOIN tb_veiculos v ON t.Id_veiculo = v.Id_veiculo
                              INNER JOIN tb_usuarios u ON t.id_funcionario = u.Id_Usuario
                              ORDER BY 
                                  t.Data DESC";

                MySqlCommand command = new MySqlCommand(relatorio, conexao);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    dgv_relatorio.DataSource = dataTable; 
                }
                else
                {
                    MessageBox.Show("Nenhuma transação encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
            finally
            {
                
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                dgv_relatorio.DataSource = null;
                return;
            }

            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();
                string pesquisa = @"
            SELECT 
                u.Nome_Usuario AS 'Vendedor', 
                c.Nome AS 'Cliente',              
                v.Marca AS 'Marca do Carro',      
                v.Modelo AS 'Modelo do Carro',    
                t.Valor AS 'Preço',                
                t.Fmr_Pagmnt AS 'Forma de Pagamento',
                t.Data AS 'Data da Venda',
                c.Historico_compra      AS 'Histórico de Compras'
            FROM 
                tb_transacoes t
            INNER JOIN tb_clientes c ON t.Id_cliente = c.Id_Cliente
            INNER JOIN tb_veiculos v ON t.Id_veiculo = v.Id_veiculo
            INNER JOIN tb_usuarios u ON t.id_funcionario = u.Id_Usuario
            WHERE 
                c.Nome LIKE @Nome OR u.Nome_Usuario LIKE @Nome
            ORDER BY 
                t.Data DESC";

                MySqlCommand command = new MySqlCommand(pesquisa, conexao);
                command.Parameters.AddWithValue("@Nome", "%" + textBox1.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dgv_relatorio.DataSource = dataTable;
                }
                else
                {
                    dgv_relatorio.DataSource = null;
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
    }
}
