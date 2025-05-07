using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class cadastro : Form
    {
        public MySqlConnection conexao;
        public cadastro()
        {
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            conexao = new MySqlConnection(strConexao);
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string email = tb_email.Text;
            string telefone = Mtb_telefone.Text;
            string rua = tb_rua.Text;
            string compl = tb_complemento.Text;
            string CEP = Mtb_cep.Text;
            string cidade = tb_cidade.Text; 
            string estado = tb_estado.Text; 

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo NOME DO USUÁRIO é obrigatório");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("O campo USUÁRIO é obrigatório");
                return;
            }

            if (string.IsNullOrEmpty(Convert.ToString(telefone)))
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(CEP))
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(rua))
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(compl))
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(cidade))
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(estado))
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                return;
            }

            var comando = new MySqlCommand("INSERT INTO tb_clientes (nome," +
                "Email, Telefone, Rua, Complemento, CEP, Cidade, Estado) VALUES (@nome, @Email," +
                "@Telefone, @Rua, @Complemento, @CEP, @Cidade, @Estado)", conexao);

            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@rua", rua);
            comando.Parameters.AddWithValue("@complemento", compl);
            comando.Parameters.AddWithValue("@Cidade", cidade);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@CEP", CEP);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Usuario inserido com sucesso");

                tb_nome.Clear();
                tb_email.Clear();
                tb_rua.Clear();
                tb_complemento.Clear();
                tb_cidade.Clear();
                Mtb_cep.Clear();
                tb_estado.Clear();
                Mtb_telefone.Clear();
                tb_nome.Focus();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
