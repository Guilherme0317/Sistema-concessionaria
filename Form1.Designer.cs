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
            this.lb_Acesso = new System.Windows.Forms.Label();
            this.lb_Nome_Usuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Ms_Acesso = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Veiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraDeVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Transacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeTransaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pb_Led = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pb_Logotipo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Led)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Logotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 0;
            // 
            // lb_Acesso
            // 
            this.lb_Acesso.AutoSize = true;
            this.lb_Acesso.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.lb_Acesso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Acesso.Location = new System.Drawing.Point(62, 145);
            this.lb_Acesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Acesso.Name = "lb_Acesso";
            this.lb_Acesso.Size = new System.Drawing.Size(0, 15);
            this.lb_Acesso.TabIndex = 6;
            // 
            // lb_Nome_Usuario
            // 
            this.lb_Nome_Usuario.AutoSize = true;
            this.lb_Nome_Usuario.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.lb_Nome_Usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Nome_Usuario.Location = new System.Drawing.Point(62, 59);
            this.lb_Nome_Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nome_Usuario.Name = "lb_Nome_Usuario";
            this.lb_Nome_Usuario.Size = new System.Drawing.Size(0, 15);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Ms_Acesso
            // 
            this.Ms_Acesso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.fecharSistemaToolStripMenuItem});
            this.Ms_Acesso.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Ms_Acesso.Image = global::Projeto_ENIR.Properties.Resources.controle_de_acesso;
            this.Ms_Acesso.Name = "Ms_Acesso";
            this.Ms_Acesso.Size = new System.Drawing.Size(85, 24);
            this.Ms_Acesso.Text = "Acesso";
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.entrarToolStripMenuItem.Text = "Entrar";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // fecharSistemaToolStripMenuItem
            // 
            this.fecharSistemaToolStripMenuItem.Name = "fecharSistemaToolStripMenuItem";
            this.fecharSistemaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fecharSistemaToolStripMenuItem.Text = "Fechar Sistema";
            this.fecharSistemaToolStripMenuItem.Click += new System.EventHandler(this.fecharSistemaToolStripMenuItem_Click);
            // 
            // Ms_Clientes
            // 
            this.Ms_Clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem1,
            this.históricoDeComprasToolStripMenuItem});
            this.Ms_Clientes.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Ms_Clientes.Image = global::Projeto_ENIR.Properties.Resources.negocios;
            this.Ms_Clientes.Name = "Ms_Clientes";
            this.Ms_Clientes.Size = new System.Drawing.Size(90, 24);
            this.Ms_Clientes.Text = "Clientes";
            this.Ms_Clientes.Click += new System.EventHandler(this.Ms_Clientes_Click);
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // editarClienteToolStripMenuItem1
            // 
            this.editarClienteToolStripMenuItem1.Name = "editarClienteToolStripMenuItem1";
            this.editarClienteToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.editarClienteToolStripMenuItem1.Text = "Editar\\Excluir  Cliente";
            this.editarClienteToolStripMenuItem1.Click += new System.EventHandler(this.editarClienteToolStripMenuItem1_Click);
            // 
            // históricoDeComprasToolStripMenuItem
            // 
            this.históricoDeComprasToolStripMenuItem.Name = "históricoDeComprasToolStripMenuItem";
            this.históricoDeComprasToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.históricoDeComprasToolStripMenuItem.Text = "Histórico de Compras";
            this.históricoDeComprasToolStripMenuItem.Click += new System.EventHandler(this.históricoDeComprasToolStripMenuItem_Click);
            // 
            // Ms_Veiculos
            // 
            this.Ms_Veiculos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarVeículoToolStripMenuItem,
            this.editarVeículoToolStripMenuItem,
            this.compraDeVeiculoToolStripMenuItem});
            this.Ms_Veiculos.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Ms_Veiculos.Image = global::Projeto_ENIR.Properties.Resources.frota;
            this.Ms_Veiculos.Name = "Ms_Veiculos";
            this.Ms_Veiculos.Size = new System.Drawing.Size(95, 24);
            this.Ms_Veiculos.Text = "Veículos";
            this.Ms_Veiculos.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click);
            // 
            // cadastrarVeículoToolStripMenuItem
            // 
            this.cadastrarVeículoToolStripMenuItem.Name = "cadastrarVeículoToolStripMenuItem";
            this.cadastrarVeículoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cadastrarVeículoToolStripMenuItem.Text = "Cadastrar Veículo";
            this.cadastrarVeículoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarVeículoToolStripMenuItem_Click);
            // 
            // editarVeículoToolStripMenuItem
            // 
            this.editarVeículoToolStripMenuItem.Name = "editarVeículoToolStripMenuItem";
            this.editarVeículoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.editarVeículoToolStripMenuItem.Text = "Editar\\Excluir Veículo";
            this.editarVeículoToolStripMenuItem.Click += new System.EventHandler(this.editarVeículoToolStripMenuItem_Click);
            // 
            // compraDeVeiculoToolStripMenuItem
            // 
            this.compraDeVeiculoToolStripMenuItem.Name = "compraDeVeiculoToolStripMenuItem";
            this.compraDeVeiculoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.compraDeVeiculoToolStripMenuItem.Text = "Compra de Veiculo";
            this.compraDeVeiculoToolStripMenuItem.Click += new System.EventHandler(this.compraDeVeiculoToolStripMenuItem_Click);
            // 
            // Ms_Transacoes
            // 
            this.Ms_Transacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVendaToolStripMenuItem,
            this.relatórioDeTransaçõesToolStripMenuItem});
            this.Ms_Transacoes.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Ms_Transacoes.Image = global::Projeto_ENIR.Properties.Resources.cartao_de_credito;
            this.Ms_Transacoes.Name = "Ms_Transacoes";
            this.Ms_Transacoes.Size = new System.Drawing.Size(110, 24);
            this.Ms_Transacoes.Text = "Transações";
            this.Ms_Transacoes.Click += new System.EventHandler(this.Ms_Transacoes_Click);
            // 
            // registrarVendaToolStripMenuItem
            // 
            this.registrarVendaToolStripMenuItem.Name = "registrarVendaToolStripMenuItem";
            this.registrarVendaToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.registrarVendaToolStripMenuItem.Text = "Registrar Venda";
            this.registrarVendaToolStripMenuItem.Click += new System.EventHandler(this.registrarVendaToolStripMenuItem_Click);
            // 
            // relatórioDeTransaçõesToolStripMenuItem
            // 
            this.relatórioDeTransaçõesToolStripMenuItem.Name = "relatórioDeTransaçõesToolStripMenuItem";
            this.relatórioDeTransaçõesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.relatórioDeTransaçõesToolStripMenuItem.Text = "Relatório de Transações";
            this.relatórioDeTransaçõesToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeTransaçõesToolStripMenuItem_Click);
            // 
            // Ms_Usuarios
            // 
            this.Ms_Usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.gerenciarUsuárioToolStripMenuItem});
            this.Ms_Usuarios.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Ms_Usuarios.Image = global::Projeto_ENIR.Properties.Resources.adicionar_usuario;
            this.Ms_Usuarios.Name = "Ms_Usuarios";
            this.Ms_Usuarios.Size = new System.Drawing.Size(121, 24);
            this.Ms_Usuarios.Text = "Funcionarios";
            this.Ms_Usuarios.Click += new System.EventHandler(this.Ms_Usuarios_Click);
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Funcionario";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // gerenciarUsuárioToolStripMenuItem
            // 
            this.gerenciarUsuárioToolStripMenuItem.Name = "gerenciarUsuárioToolStripMenuItem";
            this.gerenciarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.gerenciarUsuárioToolStripMenuItem.Text = "Gestão de Funcionario";
            this.gerenciarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.gerenciarUsuárioToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Pb_Led);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lb_Acesso);
            this.panel2.Controls.Add(this.lb_Nome_Usuario);
            this.panel2.Location = new System.Drawing.Point(32, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 261);
            this.panel2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(71, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(168, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 259);
            this.panel3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 11);
            this.label4.TabIndex = 12;
            this.label4.Text = "ACESSO DE USUARIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(8, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "______________________________";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(8, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "______________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "______________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(8, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "______________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nivel Permissão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projeto_ENIR.Properties.Resources.acesso;
            this.pictureBox2.Location = new System.Drawing.Point(30, 145);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Pb_Led
            // 
            this.Pb_Led.Image = global::Projeto_ENIR.Properties.Resources.vermelho;
            this.Pb_Led.Location = new System.Drawing.Point(70, 212);
            this.Pb_Led.Margin = new System.Windows.Forms.Padding(2);
            this.Pb_Led.Name = "Pb_Led";
            this.Pb_Led.Size = new System.Drawing.Size(40, 33);
            this.Pb_Led.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Led.TabIndex = 4;
            this.Pb_Led.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_ENIR.Properties.Resources.do_utilizador;
            this.pictureBox1.Location = new System.Drawing.Point(30, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pb_Logotipo
            // 
            this.Pb_Logotipo.Location = new System.Drawing.Point(256, 55);
            this.Pb_Logotipo.Margin = new System.Windows.Forms.Padding(2);
            this.Pb_Logotipo.Name = "Pb_Logotipo";
            this.Pb_Logotipo.Size = new System.Drawing.Size(526, 328);
            this.Pb_Logotipo.TabIndex = 4;
            this.Pb_Logotipo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(32, 96);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 259);
            this.panel4.TabIndex = 19;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pb_Logotipo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestAuto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Led)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeTransaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeComprasToolStripMenuItem;
        private System.Windows.Forms.PictureBox Pb_Logotipo;
        private System.Windows.Forms.PictureBox Pb_Led;
        private System.Windows.Forms.Label lb_Acesso;
        private System.Windows.Forms.Label lb_Nome_Usuario;
        private System.Windows.Forms.ToolStripMenuItem compraDeVeiculoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
    }
}

