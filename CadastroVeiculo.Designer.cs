namespace Projeto_ENIR
{
    partial class CadastroVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Tb_ano = new System.Windows.Forms.MaskedTextBox();
            this.Tb_preco = new System.Windows.Forms.MaskedTextBox();
            this.Tb_status = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_Cadastra = new System.Windows.Forms.Button();
            this.Cb_cor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Modelo = new System.Windows.Forms.TextBox();
            this.Tb_Marca = new System.Windows.Forms.TextBox();
            this.Dgv_carros = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_carros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 427);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 39);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 39);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.Tb_ano);
            this.panel3.Controls.Add(this.Tb_preco);
            this.panel3.Controls.Add(this.Tb_status);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.Btn_Fechar);
            this.panel3.Controls.Add(this.Btn_Cadastra);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.Cb_cor);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Tb_Modelo);
            this.panel3.Controls.Add(this.Tb_Marca);
            this.panel3.Location = new System.Drawing.Point(12, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 314);
            this.panel3.TabIndex = 7;
            // 
            // Tb_ano
            // 
            this.Tb_ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_ano.Location = new System.Drawing.Point(36, 198);
            this.Tb_ano.Mask = "0000";
            this.Tb_ano.Name = "Tb_ano";
            this.Tb_ano.Size = new System.Drawing.Size(162, 27);
            this.Tb_ano.TabIndex = 31;
            this.Tb_ano.ValidatingType = typeof(System.DateTime);
            // 
            // Tb_preco
            // 
            this.Tb_preco.Location = new System.Drawing.Point(255, 198);
            this.Tb_preco.Mask = "000,000,000.00";
            this.Tb_preco.Name = "Tb_preco";
            this.Tb_preco.Size = new System.Drawing.Size(168, 22);
            this.Tb_preco.TabIndex = 30;
            // 
            // Tb_status
            // 
            this.Tb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_status.Location = new System.Drawing.Point(249, 59);
            this.Tb_status.Name = "Tb_status";
            this.Tb_status.Size = new System.Drawing.Size(168, 27);
            this.Tb_status.TabIndex = 29;
            this.Tb_status.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(245, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Status";
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Fechar.Location = new System.Drawing.Point(28, 261);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(77, 37);
            this.Btn_Fechar.TabIndex = 27;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            // 
            // Btn_Cadastra
            // 
            this.Btn_Cadastra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Cadastra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cadastra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Cadastra.Location = new System.Drawing.Point(249, 261);
            this.Btn_Cadastra.Name = "Btn_Cadastra";
            this.Btn_Cadastra.Size = new System.Drawing.Size(81, 37);
            this.Btn_Cadastra.TabIndex = 26;
            this.Btn_Cadastra.Text = "Cadastrar";
            this.Btn_Cadastra.UseVisualStyleBackColor = false;
            this.Btn_Cadastra.Click += new System.EventHandler(this.Btn_Cadastra_Click);
            // 
            // Cb_cor
            // 
            this.Cb_cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_cor.FormattingEnabled = true;
            this.Cb_cor.Items.AddRange(new object[] {
            "Preto",
            "Verde",
            "Azul",
            "Grafite",
            "Vermelho",
            "Amarelo"});
            this.Cb_cor.Location = new System.Drawing.Point(249, 120);
            this.Cb_cor.Name = "Cb_cor";
            this.Cb_cor.Size = new System.Drawing.Size(168, 28);
            this.Cb_cor.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(251, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(257, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(36, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Marca";
            // 
            // Tb_Modelo
            // 
            this.Tb_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Modelo.Location = new System.Drawing.Point(30, 122);
            this.Tb_Modelo.Name = "Tb_Modelo";
            this.Tb_Modelo.Size = new System.Drawing.Size(162, 27);
            this.Tb_Modelo.TabIndex = 16;
            // 
            // Tb_Marca
            // 
            this.Tb_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Marca.Location = new System.Drawing.Point(30, 59);
            this.Tb_Marca.Name = "Tb_Marca";
            this.Tb_Marca.Size = new System.Drawing.Size(162, 27);
            this.Tb_Marca.TabIndex = 15;
            // 
            // Dgv_carros
            // 
            this.Dgv_carros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_carros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_carros.GridColor = System.Drawing.Color.DarkGray;
            this.Dgv_carros.Location = new System.Drawing.Point(553, 73);
            this.Dgv_carros.Name = "Dgv_carros";
            this.Dgv_carros.RowHeadersWidth = 51;
            this.Dgv_carros.RowTemplate.Height = 24;
            this.Dgv_carros.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Dgv_carros.Size = new System.Drawing.Size(269, 314);
            this.Dgv_carros.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(34, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Casatro De Veiculo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_ENIR.Properties.Resources.cadastro;
            this.pictureBox1.Location = new System.Drawing.Point(423, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 466);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dgv_carros);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroVeiculo";
            this.Load += new System.EventHandler(this.CadastroVeiculo_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_carros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Modelo;
        private System.Windows.Forms.TextBox Tb_Marca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Cb_cor;
        private System.Windows.Forms.DataGridView Dgv_carros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_Cadastra;
        private System.Windows.Forms.TextBox Tb_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox Tb_ano;
        private System.Windows.Forms.MaskedTextBox Tb_preco;
    }
}