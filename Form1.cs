using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ENIR
{
    public partial class Form_Principal : Form
    {
        public MySqlDataReader reader;

        private Form_Login Form_Login;
        internal string user_name;
        internal string senha;

        public string nomeUsuario {  get; set; }
        public string Nivel {  get; set; }

        Boolean logado = false;
        int Perm;
        public Form_Principal()
        {
            InitializeComponent();
            Form_Login form_login = new Form_Login(this);
            form_login.ShowDialog();
            if(reader != null) { 
            ComumFormLoadOperations();
            }
        }
        private void ComumFormLoadOperations()
        {
            Pb_Led.Image = Properties.Resources.verde;
            if (reader is null)
            {
                MessageBox.Show("Não encontrado");
                Close();
            }
            else
            {
                if (reader.HasRows)
                {
                    reader.Read();
                   lb_Nome_Usuario.Text = reader["Nome_Usuario"].ToString();
                   lb_Acesso.Text = reader["Permissao"].ToString();
                   Perm = int.Parse(reader["Permissao"].ToString());
                   logado = true;

                }
            }

            string imapath = @"C:\Users\natal\OneDrive\Documentos\C#projetos\Projeto_ENIR\Projeto_ENIR\Img\logo.png";
            if (File.Exists(imapath))
            {
                try
                {
                    Image img = Image.FromFile(imapath);
                    Pb_Logotipo.Image = img;
                    Pb_Logotipo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um error de imagem:" + ex.Message);
                }
        }
            else
            {
                MessageBox.Show("A imagem não foi encontrada");
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void Ms_Transacoes_Click(object sender, EventArgs e)
        {
         
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form_Login == null || Form_Login.IsDisposed)
            {
                this.Hide();
                Form_Login = new Form_Login(this);
                Form_Login.ShowDialog();
                this.Show();
                ComumFormLoadOperations();

            }
            else
            {
                Form_Login.Visible = true;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logado = false;
            Pb_Led.Image = Properties.Resources.vermelho;
            lb_Acesso.Text = "0";
            lb_Nome_Usuario.Text = "---";
        }

            private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (logado)
                {
                    if (Perm >= 3)
                    {
                    cadastro cadastro = new cadastro();
                    cadastro.Enabled = true;
                    cadastro.ShowDialog();
                }
                    else
                    {
                        MessageBox.Show("Acesso não autorizado");
                    }
                }
                else
                {
                    MessageBox.Show("É necessário ter um usuário logado");
                }
            }

        private void fecharSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastrarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logado)
            {
                if (Perm >= 3)
                {
                    CadastroVeiculo cadastroVeiculo = new CadastroVeiculo();
                    cadastroVeiculo.Enabled = true;
                    cadastroVeiculo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não autorizado");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }


        private void editarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logado)
            {
                if (Perm >= 3)
                {
                   edita_excluirVeiculo edita_ExcluirVeiculo = new edita_excluirVeiculo();
                   edita_ExcluirVeiculo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não autorizado");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

       
        private void registrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logado)
            {
                if (Perm >= 3)
                {
                   RelatorioVenda relatorio = new RelatorioVenda();
                   relatorio.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não autorizado");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void relatórioDeTransaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logado)
            {
                if (Perm >= 3)
                {
                    Pesquisa_transacoes pesquisa_trasacoes = new Pesquisa_transacoes();
                    pesquisa_trasacoes.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso não autorizado");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logado)
            {
                if (Perm >= 2)
                {
                   Cadastro_funcionario cadastro_Funcionario = new Cadastro_funcionario();
                    cadastro_Funcionario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não autorizado");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void gerenciarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logado)
            {
                if (Perm >= 2)
                {
                  Gestao_Funcionarios gestao_Funcionarios = new Gestao_Funcionarios();
                  gestao_Funcionarios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não autorizado");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void editarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (logado)
            {
                if (Perm >= 3)
                {
                    editar_excluir editar_Excluir = new editar_excluir();
                    editar_Excluir.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não autorizado");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void excluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void históricoDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logado)
            {
                if (Perm >= 2)
                {
                 Historicodecompra historicodecompra = new Historicodecompra();
                 historicodecompra.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não autorizado");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }


        private void Ms_Clientes_Click(object sender, EventArgs e)
        {

        }

        private void Ms_Usuarios_Click(object sender, EventArgs e)
        {

        }

        private void compraDeVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logado)
            {
                if (Perm >= 3)
                {
                  Compra_veiculo compra_Veiculo = new Compra_veiculo();
                  compra_Veiculo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não autorizado");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
  }

