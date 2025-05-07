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
    public partial class editar_excluir : Form
    {
        public MySqlConnection conexao;
        public editar_excluir()
        {
            this.Hide();
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editar_excluir_Load(object sender, EventArgs e)
        {
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            using (conexao = new MySqlConnection(strConexao))
            {
                conexao.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_clientes", conexao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Dgv_Usuarios.ForeColor = Color.Black;
                Dgv_Usuarios.DataSource = dataTable;
                Dgv_Usuarios.Columns["Id_cliente"].Visible = false;
                Dgv_Usuarios.Columns["Nome"].Width = 90;
                Dgv_Usuarios.Columns["Telefone"].Width = 90;
                Dgv_Usuarios.Columns["Nome"].HeaderText = "Nome Completo";
                Dgv_Usuarios.Columns["Telefone"].HeaderText = "Telefone";
                Dgv_Usuarios.Columns["Email"].HeaderText = "Email";
                Dgv_Usuarios.Columns["Rua"].HeaderText = "Rua";
                Dgv_Usuarios.Columns["Complemento"].HeaderText = "Complemento";
                Dgv_Usuarios.Columns["CEP"].HeaderText = "CEP";
                Dgv_Usuarios.Columns["Cidade"].HeaderText = "Cidade";
                Dgv_Usuarios.Columns["Estado"].HeaderText = "Estado";
                Dgv_Usuarios.Columns["Historico_compra"].HeaderText = "Historico_compra";
               
              
              
            }
        }

       

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (Dgv_Usuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow row = Dgv_Usuarios.SelectedRows[0];
                DataRowView dataRowView = (DataRowView)row.DataBoundItem;
                int idUsuario = (int)dataRowView["Id_cliente"];

                using (conexao = new MySqlConnection("server=localhost; uid=root; pwd=''; database=bd_concessionaria"))
                {
                    conexao.Open();
                    string query =
                        "UPDATE tb_clientes SET Nome = @Nome," +
                        "Telefone = @Telefone," +
                        "Email = @Email," +
                        "Rua  = @Rua," +
                        "Complemento = @Complemento," +
                        "CEP = @CEP ," +
                        "Cidade = @Cidade," +
                        "Estado  = @Estado," +
                        "Historico_compra = @Historico_compra WHERE Id_cliente = @Id_cliente";

                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@Nome", dataRowView["Nome"]);
                    command.Parameters.AddWithValue("@Telefone", dataRowView["Telefone"]);
                    command.Parameters.AddWithValue("@Email", dataRowView["Email"]);
                    command.Parameters.AddWithValue("@Rua", dataRowView["Rua"]);
                    command.Parameters.AddWithValue("@Complemento", dataRowView["Complemento"]);
                    command.Parameters.AddWithValue("@CEP", dataRowView["CEP"]);
                    command.Parameters.AddWithValue("@Cidade", dataRowView["Cidade"]);
                    command.Parameters.AddWithValue("@Estado", dataRowView["Estado"]);
                    command.Parameters.AddWithValue("@Historico_compra", dataRowView["Historico_compra"]);
                    command.Parameters.AddWithValue("@Id_cliente", dataRowView["Id_cliente"]);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Registro atualizado com sucesso");
                editar_excluir_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            if (Dgv_Usuarios.SelectedRows.Count > 0)
            {
                
                DataGridViewRow row = Dgv_Usuarios.SelectedRows[0];
                DataRowView dataRowView = (DataRowView)row.DataBoundItem;
                int idcliente = (int)dataRowView["Id_cliente"];
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    using (conexao = new MySqlConnection("server=localhost; uid=root; pwd=''; database=bd_concessionaria"))
                    {
                        conexao.Open(); 
                        string query = "DELETE FROM tb_clientes WHERE Id_cliente = @Id_cliente";
                        MySqlCommand command = new MySqlCommand(query, conexao);
                        command.Parameters.AddWithValue("Id_cliente", idcliente);
                        command.ExecuteNonQuery();
                    }


                    MessageBox.Show("Registro excluído com sucesso.");
                    editar_excluir_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada para exclusão.");
            }
        }

        private void Dgv_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
