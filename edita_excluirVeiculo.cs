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
    public partial class edita_excluirVeiculo : Form
    {
        public MySqlConnection conexao;
        public edita_excluirVeiculo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {

                dataGridView1.DataSource = null;
                return;
            }
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();


                string pesquisa = "SELECT * FROM tb_veiculos";
         
                MySqlCommand command = new MySqlCommand(pesquisa, conexao);
                command.Parameters.AddWithValue("@Nome", "%" + textBox1.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
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

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                DataRowView dataRowView = (DataRowView)row.DataBoundItem;
                int idUsuario = (int)dataRowView["Id_cliente"];

                using (conexao = new MySqlConnection("server=localhost; uid=root; pwd=''; database=bd_concessionaria"))
                {
                    conexao.Open();
                    string query =
                        "UPDATE tb_veiculos SET Marca = @Marca," +
                        "Modelo = @Modelo," +
                        "Ano = @Ano," +
                        "Cor  = @Cor," +
                        "Preco= @Preco," +
                        "Status= @Status WHERE Id_veiculo = @Id_veiculo";

                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@Marca", dataRowView["Marca"]);
                    command.Parameters.AddWithValue("@Modelo", dataRowView["Modelo"]);
                    command.Parameters.AddWithValue("@Ano", dataRowView["Ano"]);
                    command.Parameters.AddWithValue("@Cor", dataRowView["Cor"]);
                    command.Parameters.AddWithValue("@Preco", dataRowView["Preco"]);
                    command.Parameters.AddWithValue("@Status", dataRowView["Status"]);


                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Registro atualizado com sucesso");
                edita_excluirVeiculo_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dataGridView1.SelectedRows[0];
                DataRowView dataRowView = (DataRowView)row.DataBoundItem;
                int idcliente = (int)dataRowView["Id_veiculo"];
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    using (conexao = new MySqlConnection("server=localhost; uid=root; pwd=''; database=bd_concessionaria"))
                    {
                        conexao.Open();
                        string query = "DELETE FROM tb_veiculos WHERE Id_veiculo = @Id_veiculo";
                        MySqlCommand command = new MySqlCommand(query, conexao);
                        command.Parameters.AddWithValue("Id_cliente", idcliente);
                        command.ExecuteNonQuery();
                    }


                    MessageBox.Show("Registro excluído com sucesso.");
                    edita_excluirVeiculo_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada para exclusão.");
            }
        }

            private void Tbn_sair_Click(object sender, EventArgs e)
        {

        }

        private void edita_excluirVeiculo_Load(object sender, EventArgs e)
        {
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            using (conexao = new MySqlConnection(strConexao))
            {
                conexao.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_veiculos", conexao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.ForeColor = Color.Black;
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["Id_veiculo"].Visible = false;
                dataGridView1.Columns["Marca"].HeaderText = "Marca";
                dataGridView1.Columns["Modelo"].HeaderText = "Modelo";
                dataGridView1.Columns["Ano"].HeaderText = "Ano";
                dataGridView1.Columns["Preco"].HeaderText = "Preço (R$)";
                dataGridView1.Columns["Preco"].DefaultCellStyle.Format = "C2";
                dataGridView1.Columns["Status"].HeaderText = "status";


            }
        }
    }
   }

