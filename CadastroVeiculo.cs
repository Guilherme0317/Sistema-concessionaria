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
    public partial class CadastroVeiculo : Form
    {
        public MySqlConnection conexao;
        public CadastroVeiculo()
        {
            InitializeComponent();
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            conexao = new MySqlConnection(strConexao);

        }

        private void CadastroVeiculo_Load(object sender, EventArgs e)
        {
          
        }

        private void Btn_Cadastra_Click(object sender, EventArgs e)
        {
            string marca = Tb_Marca.Text;
            string modelo = Tb_Modelo.Text;
            string ano = Tb_ano.Text;
            string cor = Cb_cor.Text;
            string preco = Tb_preco.Text;
            string status = Tb_status.Text;

            if (string.IsNullOrEmpty(marca))
            {
                MessageBox.Show("O campo MARCA é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(modelo))
            {
                MessageBox.Show("O campo MODELO é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(ano))
            {
                MessageBox.Show("O campo ANO é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(preco))
            {
                MessageBox.Show("O campo PREÇO é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("O campo STATUS é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(cor))
            {
                MessageBox.Show("O campo COR é obrigatório");
                return;
            }

            var comando = new MySqlCommand(
                "INSERT INTO tb_veiculos (Marca, Modelo, Ano, Cor, Preco, Status) VALUES (@Marca, @Modelo, @Ano, @Cor, @Preco, @Status)",
                conexao
            );

            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Modelo", modelo);
            comando.Parameters.AddWithValue("@Ano", ano);
            comando.Parameters.AddWithValue("@Cor", cor);
            comando.Parameters.AddWithValue("@Preco", preco);
            comando.Parameters.AddWithValue("@Status", status);

            try
            {
                if (conexao.State != ConnectionState.Open)
                {
                    conexao.Open();
                }

                comando.ExecuteNonQuery();
                MessageBox.Show("Veículo inserido com sucesso!");
                Tb_Modelo.Clear();
                Tb_preco.Clear();
                Tb_status.Clear();
                Tb_ano.Clear();
                Tb_Marca.Clear();
                Cb_cor.SelectedIndex = -1;
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }
        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
