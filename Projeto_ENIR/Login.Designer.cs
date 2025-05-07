namespace Projeto_ENIR
{
    partial class Form_Login
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
            this.Tb_Usuario = new System.Windows.Forms.TextBox();
            this.Tb_Senha = new System.Windows.Forms.TextBox();
            this.Lb_Usuario = new System.Windows.Forms.Label();
            this.Lb_Senha = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_Logar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 560);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 48);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 48);
            this.panel2.TabIndex = 1;
            // 
            // Tb_Usuario
            // 
            this.Tb_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Usuario.Location = new System.Drawing.Point(28, 263);
            this.Tb_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Usuario.Name = "Tb_Usuario";
            this.Tb_Usuario.Size = new System.Drawing.Size(286, 30);
            this.Tb_Usuario.TabIndex = 2;
            this.Tb_Usuario.Text = "gojo";
            this.Tb_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tb_Usuario.TextChanged += new System.EventHandler(this.Tb_Usuario_TextChanged);
            this.Tb_Usuario.Enter += new System.EventHandler(this.Tb_Usuario_Enter);
            // 
            // Tb_Senha
            // 
            this.Tb_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Senha.Location = new System.Drawing.Point(28, 361);
            this.Tb_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Senha.Name = "Tb_Senha";
            this.Tb_Senha.PasswordChar = '*';
            this.Tb_Senha.Size = new System.Drawing.Size(286, 30);
            this.Tb_Senha.TabIndex = 3;
            this.Tb_Senha.Text = "1234";
            this.Tb_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lb_Usuario
            // 
            this.Lb_Usuario.AutoSize = true;
            this.Lb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Usuario.Location = new System.Drawing.Point(23, 230);
            this.Lb_Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Usuario.Name = "Lb_Usuario";
            this.Lb_Usuario.Size = new System.Drawing.Size(79, 25);
            this.Lb_Usuario.TabIndex = 5;
            this.Lb_Usuario.Text = "Usuário";
            this.Lb_Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lb_Senha
            // 
            this.Lb_Senha.AutoSize = true;
            this.Lb_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Senha.Location = new System.Drawing.Point(23, 328);
            this.Lb_Senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Senha.Name = "Lb_Senha";
            this.Lb_Senha.Size = new System.Drawing.Size(70, 25);
            this.Lb_Senha.TabIndex = 6;
            this.Lb_Senha.Text = "Senha";
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Fechar.Location = new System.Drawing.Point(216, 446);
            this.Btn_Fechar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(98, 50);
            this.Btn_Fechar.TabIndex = 7;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_Logar
            // 
            this.Btn_Logar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Logar.Location = new System.Drawing.Point(28, 446);
            this.Btn_Logar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Logar.Name = "Btn_Logar";
            this.Btn_Logar.Size = new System.Drawing.Size(98, 50);
            this.Btn_Logar.TabIndex = 8;
            this.Btn_Logar.Text = "Entrar";
            this.Btn_Logar.UseVisualStyleBackColor = false;
            this.Btn_Logar.Click += new System.EventHandler(this.Btn_Logar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_ENIR.Properties.Resources.Usuario_imagem;
            this.pictureBox1.Location = new System.Drawing.Point(109, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(348, 608);
            this.Controls.Add(this.Btn_Logar);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Lb_Senha);
            this.Controls.Add(this.Lb_Usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Tb_Senha);
            this.Controls.Add(this.Tb_Usuario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Tb_Usuario;
        private System.Windows.Forms.TextBox Tb_Senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_Usuario;
        private System.Windows.Forms.Label Lb_Senha;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_Logar;
    }
}