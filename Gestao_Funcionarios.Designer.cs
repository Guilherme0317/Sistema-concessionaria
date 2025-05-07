namespace Projeto_ENIR
{
    partial class Gestao_Funcionarios
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cd_id = new System.Windows.Forms.ComboBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.Cd_cargo = new System.Windows.Forms.ComboBox();
            this.Nud_perm = new System.Windows.Forms.NumericUpDown();
            this.tb_salario = new System.Windows.Forms.TextBox();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_perm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 39);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 28);
            this.panel1.TabIndex = 2;
            // 
            // Cd_id
            // 
            this.Cd_id.FormattingEnabled = true;
            this.Cd_id.Location = new System.Drawing.Point(24, 102);
            this.Cd_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cd_id.Name = "Cd_id";
            this.Cd_id.Size = new System.Drawing.Size(43, 21);
            this.Cd_id.TabIndex = 3;
            this.Cd_id.SelectedIndexChanged += new System.EventHandler(this.Cd_id_SelectedIndexChanged);
            // 
            // tb_nome
            // 
            this.tb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(24, 152);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_nome.Multiline = true;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(251, 24);
            this.tb_nome.TabIndex = 4;
            // 
            // tb_login
            // 
            this.tb_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login.Location = new System.Drawing.Point(24, 220);
            this.tb_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_login.Multiline = true;
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(160, 22);
            this.tb_login.TabIndex = 5;
            // 
            // tb_senha
            // 
            this.tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(196, 220);
            this.tb_senha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_senha.Multiline = true;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(79, 22);
            this.tb_senha.TabIndex = 6;
            // 
            // Cd_cargo
            // 
            this.Cd_cargo.FormattingEnabled = true;
            this.Cd_cargo.Items.AddRange(new object[] {
            "A",
            "F",
            "G"});
            this.Cd_cargo.Location = new System.Drawing.Point(24, 274);
            this.Cd_cargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cd_cargo.Name = "Cd_cargo";
            this.Cd_cargo.Size = new System.Drawing.Size(53, 21);
            this.Cd_cargo.TabIndex = 7;
            // 
            // Nud_perm
            // 
            this.Nud_perm.Location = new System.Drawing.Point(24, 332);
            this.Nud_perm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Nud_perm.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Nud_perm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_perm.Name = "Nud_perm";
            this.Nud_perm.Size = new System.Drawing.Size(52, 20);
            this.Nud_perm.TabIndex = 8;
            this.Nud_perm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_salario
            // 
            this.tb_salario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salario.Location = new System.Drawing.Point(196, 313);
            this.tb_salario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_salario.Multiline = true;
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.Size = new System.Drawing.Size(79, 22);
            this.tb_salario.TabIndex = 9;
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Consultar.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Consultar.Location = new System.Drawing.Point(24, 389);
            this.Btn_Consultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(68, 47);
            this.Btn_Consultar.TabIndex = 10;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_fechar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_fechar.Location = new System.Drawing.Point(211, 389);
            this.Btn_fechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(68, 47);
            this.Btn_fechar.TabIndex = 11;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = false;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(24, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(22, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(194, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(194, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Salario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(24, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cargo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(21, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Permissão";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(34, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gestão De Funcionarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_ENIR.Properties.Resources.adicionar_usuario;
            this.pictureBox1.Location = new System.Drawing.Point(211, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Gestao_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.tb_salario);
            this.Controls.Add(this.Nud_perm);
            this.Controls.Add(this.Cd_cargo);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.Cd_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestao_Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestao_Funcionarios";
            this.Load += new System.EventHandler(this.Gestao_Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_perm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Cd_id;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.ComboBox Cd_cargo;
        private System.Windows.Forms.NumericUpDown Nud_perm;
        private System.Windows.Forms.TextBox tb_salario;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}