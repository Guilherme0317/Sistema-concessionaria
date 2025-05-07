using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_ENIR
{
    public partial class Form_Login : Form
    {
        Form_Principal form_Principal;
        public Form_Login(Form_Principal form_Principal)
        {
            InitializeComponent();
            this.form_Principal = form_Principal; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            string login = Tb_Usuario.Text;
            string senha = Tb_Senha.Text;

   
            if (login == "" || senha == "")
            {
                MessageBox.Show("Usuário e ou senha inválidos");
                Tb_Usuario.Focus();
                return;
            }

            bool usuarioCadastrado = false;

            try
            {
                var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();

                var comando = new MySqlCommand("SELECT * FROM tb_usuarios WHERE Nome_usuario = @usuario AND Senha = @senha", conexao);
                comando.Parameters.AddWithValue("@usuario", login);
                comando.Parameters.AddWithValue("@senha", senha);

                var reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    usuarioCadastrado = true;
                    form_Principal.reader = reader;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

            if (usuarioCadastrado)
            {
                form_Principal.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretas.");
                Tb_Usuario.Clear();
                Tb_Senha.Clear();
                Tb_Usuario.Focus();
            }
        }

        private void Tb_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
       
        }

        private void Tb_Usuario_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
