namespace Projeto_ENIR
{
    partial class Cadastro_funcionario
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
            this.Tb_nome = new System.Windows.Forms.TextBox();
            this.Tb_login = new System.Windows.Forms.TextBox();
            this.Cb_Cargo = new System.Windows.Forms.ComboBox();
            this.Nud_permissao = new System.Windows.Forms.NumericUpDown();
            this.Tb_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_salario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_permissao)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 48);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 570);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 33);
            this.panel2.TabIndex = 2;
            // 
            // Tb_nome
            // 
            this.Tb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_nome.Location = new System.Drawing.Point(15, 113);
            this.Tb_nome.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_nome.Name = "Tb_nome";
            this.Tb_nome.Size = new System.Drawing.Size(289, 30);
            this.Tb_nome.TabIndex = 3;
            // 
            // Tb_login
            // 
            this.Tb_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_login.Location = new System.Drawing.Point(15, 184);
            this.Tb_login.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_login.Name = "Tb_login";
            this.Tb_login.Size = new System.Drawing.Size(289, 30);
            this.Tb_login.TabIndex = 4;
            // 
            // Cb_Cargo
            // 
            this.Cb_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Cargo.FormattingEnabled = true;
            this.Cb_Cargo.Items.AddRange(new object[] {
            "A",
            "G",
            "F"});
            this.Cb_Cargo.Location = new System.Drawing.Point(19, 411);
            this.Cb_Cargo.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_Cargo.Name = "Cb_Cargo";
            this.Cb_Cargo.Size = new System.Drawing.Size(79, 28);
            this.Cb_Cargo.TabIndex = 6;
            this.Cb_Cargo.SelectedIndexChanged += new System.EventHandler(this.Cb_Cargo_SelectedIndexChanged);
            // 
            // Nud_permissao
            // 
            this.Nud_permissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nud_permissao.Location = new System.Drawing.Point(236, 412);
            this.Nud_permissao.Margin = new System.Windows.Forms.Padding(4);
            this.Nud_permissao.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Nud_permissao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_permissao.Name = "Nud_permissao";
            this.Nud_permissao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nud_permissao.Size = new System.Drawing.Size(69, 27);
            this.Nud_permissao.TabIndex = 7;
            this.Nud_permissao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Tb_senha
            // 
            this.Tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_senha.Location = new System.Drawing.Point(17, 258);
            this.Tb_senha.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_senha.Name = "Tb_senha";
            this.Tb_senha.Size = new System.Drawing.Size(289, 30);
            this.Tb_senha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(11, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "User ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(15, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha";
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_salvar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Btn_salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_salvar.Location = new System.Drawing.Point(13, 469);
            this.Btn_salvar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(100, 47);
            this.Btn_salvar.TabIndex = 12;
            this.Btn_salvar.Text = "Salvar";
            this.Btn_salvar.UseVisualStyleBackColor = false;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Cancelar.Location = new System.Drawing.Point(209, 469);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(100, 47);
            this.Btn_Cancelar.TabIndex = 13;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(15, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(232, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Permissão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(14, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Salario";
            // 
            // tb_salario
            // 
            this.tb_salario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salario.Location = new System.Drawing.Point(15, 339);
            this.tb_salario.Margin = new System.Windows.Forms.Padding(4);
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.Size = new System.Drawing.Size(289, 30);
            this.tb_salario.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(61, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cadastro De Funcionario";
            // 
            // Cadastro_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 603);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_salario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_senha);
            this.Controls.Add(this.Nud_permissao);
            this.Controls.Add(this.Cb_Cargo);
            this.Controls.Add(this.Tb_login);
            this.Controls.Add(this.Tb_nome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.Cadastro_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_permissao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Tb_nome;
        private System.Windows.Forms.TextBox Tb_login;
        private System.Windows.Forms.ComboBox Cb_Cargo;
        private System.Windows.Forms.NumericUpDown Nud_permissao;
        private System.Windows.Forms.TextBox Tb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_salario;
        private System.Windows.Forms.Label label7;
    }
}