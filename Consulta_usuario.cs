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
    public partial class Cadastro_funcionario : Form
    {
        public MySqlConnection conexao;
        public Cadastro_funcionario()
        {
            InitializeComponent();
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            conexao = new MySqlConnection(strConexao);
        }

        private void Cadastro_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string nome = Tb_nome.Text;
            string senha = Tb_senha.Text;
            string cargo = Cb_Cargo.Text;
            string login = Tb_login.Text;
            string permissao = Nud_permissao.Text;
            string salario = tb_salario.Text;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo NOME DO USUÁRIO é obrigatório");
                return;
            }

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("O campo USUÁRIO é obrigatório");
                return;
            }

            if (string.IsNullOrEmpty(Convert.ToString(permissao)))
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                return;
            }
            if (string.IsNullOrEmpty(cargo))
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                return;
            }
            
           

            var comando = new MySqlCommand("INSERT INTO tb_usuarios (nome_usuario," +
                "Cargo, Login ,Senha ,permissao) VALUES (@nome_usuario, @Cargo," +
                "@Login, @Senha, @Permissao)", conexao);

            comando.Parameters.AddWithValue("@nome_usuario", nome);
            comando.Parameters.AddWithValue("@Cargo", cargo);
            comando.Parameters.AddWithValue("@Login", login);
            comando.Parameters.AddWithValue("@Senha", senha);
            comando.Parameters.AddWithValue("@Permissao", permissao);
            comando.Parameters.AddWithValue("@Salario", salario);
            
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Usuario inserido com sucesso");

                Tb_nome.Clear();
                Tb_senha.Clear();
                Tb_login.Clear();
                Cb_Cargo.Items.Clear();
                tb_salario.Clear();
                Nud_permissao.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cb_Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
