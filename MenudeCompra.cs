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
        public partial class MenudeCompra : Form
        {
            public MySqlConnection conexao;
            public int IdVeiculo { get; set; }
            public int IdCliente { get; set; }
       
            public MenudeCompra(int idVeiculo, int idCliente)
            {
                InitializeComponent();
                IdVeiculo = idVeiculo;
                IdCliente = idCliente;
                var strConexao = "server=localhost; uid=root; pwd=''; database=bd_concessionaria";
                conexao = new MySqlConnection(strConexao);
            }

            private void MenudeCompra_Load(object sender, EventArgs e)
            {
                try
                {
                    conexao.Open();

                    MySqlCommand commandClientes = new MySqlCommand("SELECT Id_Cliente, Nome FROM tb_clientes", conexao);
                    MySqlDataReader readerClientes = commandClientes.ExecuteReader();

                    while (readerClientes.Read())
                    {
                        Cb_clientes.Items.Add(new { Text = readerClientes["Nome"].ToString(), Value = readerClientes["Id_Cliente"] });
                    }

                    Cb_clientes.DisplayMember = "Text";
                    Cb_clientes.ValueMember = "Value";
                    readerClientes.Close();


                    if (IdCliente > 0)
                    {
                 
                        foreach (var item in Cb_clientes.Items)
                        {
                            var cliente = item as dynamic;
                            if (cliente.Value == IdCliente)
                            {
                                Cb_clientes.SelectedItem = item;
                                break;
                            }
                        }
                    }

                    MySqlCommand command = new MySqlCommand("SELECT * FROM tb_veiculos WHERE Id_veiculo = @IdVeiculo", conexao);
                    command.Parameters.AddWithValue("@IdVeiculo", IdVeiculo);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Tb_modelo.Text = reader["Modelo"].ToString();
                        Tb_valor.Text = Convert.ToDecimal(reader["Preco"]).ToString("C2");
                        Cb_cor.SelectedItem = reader["Cor"].ToString();
                    }
                    reader.Close();

                MySqlCommand commandVendedores = new MySqlCommand("SELECT Id_Usuario, Nome_Usuario FROM tb_usuarios", conexao);
                MySqlDataReader readerVendedores = commandVendedores.ExecuteReader();

                while (readerVendedores.Read())
                {
                    Cb_vendendor.Items.Add(new { Text = readerVendedores["Nome_Usuario"].ToString(), Value = readerVendedores["Id_Usuario"] });
                }

                Cb_vendendor.DisplayMember = "Text"; 
                Cb_vendendor.ValueMember = "Value";   
                readerVendedores.Close();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }

            private void Btn_finalizarpag_Click(object sender, EventArgs e)
            {
                try
                {

                    if (Cb_clientes.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, selecione um cliente.");
                        return;
                    }

               
                    var clienteSelecionado = Cb_clientes.SelectedItem;
                    int idCliente = Convert.ToInt32((clienteSelecionado as dynamic).Value); 


               
                    MySqlCommand commandVerificaCliente = new MySqlCommand("SELECT COUNT(*) FROM tb_clientes WHERE Id_Cliente = @IdCliente", conexao);
                    commandVerificaCliente.Parameters.AddWithValue("@IdCliente", idCliente);
                    int clienteCount = Convert.ToInt32(commandVerificaCliente.ExecuteScalar());

                    if (clienteCount == 0)
                    {
                        MessageBox.Show("Cliente selecionado não existe.");
                        return;
                    }

                    var vendedorSelecionado = Cb_vendendor.SelectedItem;
                    int idVendedor = Convert.ToInt32((vendedorSelecionado as dynamic).Value);
                    string modelo = Tb_modelo.Text;
                    decimal valor = Convert.ToDecimal(Tb_valor.Text.Replace("R$", "").Trim());
                    string cor = Cb_cor.Text;
                    string formaDePagamento = Cb_fmrpagamento.SelectedItem.ToString();

                    string Up = "UPDATE tb_veiculos SET Id_cliente = @IdCliente WHERE Id_veiculo = @IdVeiculo";
                    MySqlCommand command = new MySqlCommand(Up, conexao);
                    command.Parameters.AddWithValue("@IdCliente", idCliente);
                    command.Parameters.AddWithValue("@IdVeiculo", IdVeiculo);

                string Historico = "INSERT INTO tb_transacoes (Id_cliente, Id_veiculo, Fmr_Pagmnt, Data, Valor, id_funcionario) " +
                       "VALUES (@IdCliente, @IdVeiculo, @Fmr_Pagmnt, @Data, @Valor, @IdFuncionario)";
                MySqlCommand commandHistorico = new MySqlCommand(Historico, conexao);
                commandHistorico.Parameters.AddWithValue("@IdCliente", idCliente);
                commandHistorico.Parameters.AddWithValue("@IdVeiculo", IdVeiculo);
                commandHistorico.Parameters.AddWithValue("@Valor", valor);
                commandHistorico.Parameters.AddWithValue("@Fmr_Pagmnt", formaDePagamento);
                commandHistorico.Parameters.AddWithValue("@Data", DateTime.Now);
                commandHistorico.Parameters.AddWithValue("@IdFuncionario", idVendedor);

                string atualizarHistoricoCompra = "UPDATE tb_clientes SET Historico_compra = Historico_compra + 1 WHERE Id_Cliente = @IdCliente";
                MySqlCommand commandAtualizaHistorico = new MySqlCommand(atualizarHistoricoCompra, conexao);
                commandAtualizaHistorico.Parameters.AddWithValue("@IdCliente", idCliente);


                command.ExecuteNonQuery();
                commandHistorico.ExecuteNonQuery();
                commandAtualizaHistorico.ExecuteNonQuery();

                MessageBox.Show("Compra realizada com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a compra: " + ex.Message);
                }
            }

            private void MenudeCompra_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

            private void Cb_vendendor_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
    }
    
