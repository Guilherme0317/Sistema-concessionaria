namespace Projeto_ENIR
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pb_Led = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Acesso = new System.Windows.Forms.Label();
            this.lb_Nome_Usuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Ms_Acesso = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Veiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeManutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Transacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarManutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarTransaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeTransaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pb_Logotipo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Led)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Logotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.Pb_Led);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_Acesso);
            this.panel1.Controls.Add(this.lb_Nome_Usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 60);
            this.panel1.TabIndex = 0;
            // 
            // Pb_Led
            // 
            this.Pb_Led.Image = global::Projeto_ENIR.Properties.Resources.vermelho;
            this.Pb_Led.Location = new System.Drawing.Point(1003, 10);
            this.Pb_Led.Name = "Pb_Led";
            this.Pb_Led.Size = new System.Drawing.Size(41, 42);
            this.Pb_Led.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Led.TabIndex = 4;
            this.Pb_Led.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Acesso:";
            // 
            // lb_Acesso
            // 
            this.lb_Acesso.AutoSize = true;
            this.lb_Acesso.Location = new System.Drawing.Point(862, 24);
            this.lb_Acesso.Name = "lb_Acesso";
            this.lb_Acesso.Size = new System.Drawing.Size(0, 16);
            this.lb_Acesso.TabIndex = 6;
            // 
            // lb_Nome_Usuario
            // 
            this.lb_Nome_Usuario.AutoSize = true;
            this.lb_Nome_Usuario.Location = new System.Drawing.Point(617, 24);
            this.lb_Nome_Usuario.Name = "lb_Nome_Usuario";
            this.lb_Nome_Usuario.Size = new System.Drawing.Size(0, 16);
            this.lb_Nome_Usuario.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ms_Acesso,
            this.Ms_Clientes,
            this.Ms_Veiculos,
            this.Ms_Transacoes,
            this.Ms_Usuarios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Ms_Acesso
            // 
            this.Ms_Acesso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.fecharSistemaToolStripMenuItem});
            this.Ms_Acesso.Image = global::Projeto_ENIR.Properties.Resources.controle_de_acesso;
            this.Ms_Acesso.Name = "Ms_Acesso";
            this.Ms_Acesso.Size = new System.Drawing.Size(89, 24);
            this.Ms_Acesso.Text = "Acesso";
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.entrarToolStripMenuItem.Text = "Entrar";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // fecharSistemaToolStripMenuItem
            // 
            this.fecharSistemaToolStripMenuItem.Name = "fecharSistemaToolStripMenuItem";
            this.fecharSistemaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.fecharSistemaToolStripMenuItem.Text = "Fechar Sistema";
            this.fecharSistemaToolStripMenuItem.Click += new System.EventHandler(this.fecharSistemaToolStripMenuItem_Click);
            // 
            // Ms_Clientes
            // 
            this.Ms_Clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem1,
            this.históricoDeComprasToolStripMenuItem});
            this.Ms_Clientes.Image = global::Projeto_ENIR.Properties.Resources.negocios;
            this.Ms_Clientes.Name = "Ms_Clientes";
            this.Ms_Clientes.Size = new System.Drawing.Size(95, 24);
            this.Ms_Clientes.Text = "Clientes";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.editarClienteToolStripMenuItem.Text = "Pesquisar Cliente";
            this.editarClienteToolStripMenuItem.Click += new System.EventHandler(this.editarClienteToolStripMenuItem_Click);
            // 
            // editarClienteToolStripMenuItem1
            // 
            this.editarClienteToolStripMenuItem1.Name = "editarClienteToolStripMenuItem1";
            this.editarClienteToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.editarClienteToolStripMenuItem1.Text = "Editar\\Excluir  Cliente";
            this.editarClienteToolStripMenuItem1.Click += new System.EventHandler(this.editarClienteToolStripMenuItem1_Click);
            // 
            // históricoDeComprasToolStripMenuItem
            // 
            this.históricoDeComprasToolStripMenuItem.Name = "históricoDeComprasToolStripMenuItem";
            this.históricoDeComprasToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.históricoDeComprasToolStripMenuItem.Text = "Histórico de Compras";
            this.históricoDeComprasToolStripMenuItem.Click += new System.EventHandler(this.históricoDeComprasToolStripMenuItem_Click);
            // 
            // Ms_Veiculos
            // 
            this.Ms_Veiculos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarVeículoToolStripMenuItem,
            this.pesquisarVeículoToolStripMenuItem,
            this.editarVeículoToolStripMenuItem,
            this.excluirVeículoToolStripMenuItem,
            this.históricoDeManutençãoToolStripMenuItem});
            this.Ms_Veiculos.Image = global::Projeto_ENIR.Properties.Resources.frota;
            this.Ms_Veiculos.Name = "Ms_Veiculos";
            this.Ms_Veiculos.Size = new System.Drawing.Size(97, 24);
            this.Ms_Veiculos.Text = "Veículos";
            this.Ms_Veiculos.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click);
            // 
            // cadastrarVeículoToolStripMenuItem
            // 
            this.cadastrarVeículoToolStripMenuItem.Name = "cadastrarVeículoToolStripMenuItem";
            this.cadastrarVeículoToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.cadastrarVeículoToolStripMenuItem.Text = "Cadastrar Veículo";
            this.cadastrarVeículoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarVeículoToolStripMenuItem_Click);
            // 
            // pesquisarVeículoToolStripMenuItem
            // 
            this.pesquisarVeículoToolStripMenuItem.Name = "pesquisarVeículoToolStripMenuItem";
            this.pesquisarVeículoToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.pesquisarVeículoToolStripMenuItem.Text = "Pesquisar Veículo";
            this.pesquisarVeículoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarVeículoToolStripMenuItem_Click);
            // 
            // editarVeículoToolStripMenuItem
            // 
            this.editarVeículoToolStripMenuItem.Name = "editarVeículoToolStripMenuItem";
            this.editarVeículoToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.editarVeículoToolStripMenuItem.Text = "Editar Veículo";
            this.editarVeículoToolStripMenuItem.Click += new System.EventHandler(this.editarVeículoToolStripMenuItem_Click);
            // 
            // excluirVeículoToolStripMenuItem
            // 
            this.excluirVeículoToolStripMenuItem.Name = "excluirVeículoToolStripMenuItem";
            this.excluirVeículoToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.excluirVeículoToolStripMenuItem.Text = "Excluir Veículo";
            this.excluirVeículoToolStripMenuItem.Click += new System.EventHandler(this.excluirVeículoToolStripMenuItem_Click);
            // 
            // históricoDeManutençãoToolStripMenuItem
            // 
            this.históricoDeManutençãoToolStripMenuItem.Name = "históricoDeManutençãoToolStripMenuItem";
            this.históricoDeManutençãoToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.históricoDeManutençãoToolStripMenuItem.Text = "Histórico de Manutenção";
            this.históricoDeManutençãoToolStripMenuItem.Click += new System.EventHandler(this.históricoDeManutençãoToolStripMenuItem_Click);
            // 
            // Ms_Transacoes
            // 
            this.Ms_Transacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVendaToolStripMenuItem,
            this.registrarManutençãoToolStripMenuItem,
            this.pesquisarTransaçõesToolStripMenuItem,
            this.relatórioDeTransaçõesToolStripMenuItem});
            this.Ms_Transacoes.Image = global::Projeto_ENIR.Properties.Resources.cartao_de_credito;
            this.Ms_Transacoes.Name = "Ms_Transacoes";
            this.Ms_Transacoes.Size = new System.Drawing.Size(115, 24);
            this.Ms_Transacoes.Text = "Transações";
            this.Ms_Transacoes.Click += new System.EventHandler(this.Ms_Transacoes_Click);
            // 
            // registrarVendaToolStripMenuItem
            // 
            this.registrarVendaToolStripMenuItem.Name = "registrarVendaToolStripMenuItem";
            this.registrarVendaToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.registrarVendaToolStripMenuItem.Text = "Registrar Venda";
            this.registrarVendaToolStripMenuItem.Click += new System.EventHandler(this.registrarVendaToolStripMenuItem_Click);
            // 
            // registrarManutençãoToolStripMenuItem
            // 
            this.registrarManutençãoToolStripMenuItem.Name = "registrarManutençãoToolStripMenuItem";
            this.registrarManutençãoToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.registrarManutençãoToolStripMenuItem.Text = "Registrar Manutenção";
            this.registrarManutençãoToolStripMenuItem.Click += new System.EventHandler(this.registrarManutençãoToolStripMenuItem_Click);
            // 
            // pesquisarTransaçõesToolStripMenuItem
            // 
            this.pesquisarTransaçõesToolStripMenuItem.Name = "pesquisarTransaçõesToolStripMenuItem";
            this.pesquisarTransaçõesToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.pesquisarTransaçõesToolStripMenuItem.Text = "Pesquisar Transações";
            this.pesquisarTransaçõesToolStripMenuItem.Click += new System.EventHandler(this.pesquisarTransaçõesToolStripMenuItem_Click);
            // 
            // relatórioDeTransaçõesToolStripMenuItem
            // 
            this.relatórioDeTransaçõesToolStripMenuItem.Name = "relatórioDeTransaçõesToolStripMenuItem";
            this.relatórioDeTransaçõesToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.relatórioDeTransaçõesToolStripMenuItem.Text = "Relatório de Transações";
            this.relatórioDeTransaçõesToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeTransaçõesToolStripMenuItem_Click);
            // 
            // Ms_Usuarios
            // 
            this.Ms_Usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.gerenciarUsuárioToolStripMenuItem});
            this.Ms_Usuarios.Image = global::Projeto_ENIR.Properties.Resources.adicionar_usuario;
            this.Ms_Usuarios.Name = "Ms_Usuarios";
            this.Ms_Usuarios.Size = new System.Drawing.Size(99, 24);
            this.Ms_Usuarios.Text = "Usuários";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // gerenciarUsuárioToolStripMenuItem
            // 
            this.gerenciarUsuárioToolStripMenuItem.Name = "gerenciarUsuárioToolStripMenuItem";
            this.gerenciarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.gerenciarUsuárioToolStripMenuItem.Text = "Gerenciar Usuário";
            this.gerenciarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.gerenciarUsuárioToolStripMenuItem_Click);
            // 
            // Pb_Logotipo
            // 
            this.Pb_Logotipo.Location = new System.Drawing.Point(342, 59);
            this.Pb_Logotipo.Name = "Pb_Logotipo";
            this.Pb_Logotipo.Size = new System.Drawing.Size(702, 404);
            this.Pb_Logotipo.TabIndex = 4;
            this.Pb_Logotipo.TabStop = false;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Pb_Logotipo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestAuto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Led)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Logotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Ms_Acesso;
        private System.Windows.Forms.ToolStripMenuItem Ms_Clientes;
        private System.Windows.Forms.ToolStripMenuItem Ms_Veiculos;
        private System.Windows.Forms.ToolStripMenuItem Ms_Transacoes;
        private System.Windows.Forms.ToolStripMenuItem Ms_Usuarios;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeManutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarManutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarTransaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeTransaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeComprasToolStripMenuItem;
        private System.Windows.Forms.PictureBox Pb_Logotipo;
        private System.Windows.Forms.PictureBox Pb_Led;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Acesso;
        private System.Windows.Forms.Label lb_Nome_Usuario;
    }
}

