using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class Gestao_Funcionarios : Form
    {
        public MySqlConnection conexao;
        public Gestao_Funcionarios()
        {
            this.Hide();
            InitializeComponent();
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
            conexao = new MySqlConnection(strConexao);
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(Cd_id.Text);
            if (idUsuario <= 0)
            {
                MessageBox.Show("O campo 'ID do Funcionario' é obrigatório.");
                return;
            }
            conexao.Open();
            var comando = new MySqlCommand("SELECT * FROM tb_usuarios WHERE id_usuario = @idUsuario", conexao);
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            var reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tb_nome.Text = reader["Nome_usuario"].ToString();
                tb_login.Text = reader["Login"].ToString();
                tb_senha.Text = reader["senha"].ToString();
                tb_salario.Text = reader["salario"].ToString();
                Cd_cargo.Text = reader["Cargo"].ToString();
                Nud_perm.Value = Convert.ToInt32(reader["Permissao"]);
            }
            else
            {
                MessageBox.Show("Funcionario não Existe.");
            }
            reader.Close();
            conexao.Close();

        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Gestao_Funcionarios_Load(object sender, EventArgs e)
        {
            conexao.Open();

            var comando = new MySqlCommand("SELECT id_usuario FROM tb_usuarios", conexao);
            var reader = comando.ExecuteReader();
            Cd_id.Items.Clear();
            while (reader.Read())
            {
                Cd_id.Items.Add(reader["id_usuario"].ToString());
            }
            reader.Close();
            conexao.Close();
        }

        private void Cd_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }

