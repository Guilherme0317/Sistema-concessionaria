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
            this.Tb_Usuario = new System.Windows.Forms.TextBox();
            this.Tb_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_Logar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Usuario
            // 
            this.Tb_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Usuario.Location = new System.Drawing.Point(29, 198);
            this.Tb_Usuario.Name = "Tb_Usuario";
            this.Tb_Usuario.Size = new System.Drawing.Size(199, 26);
            this.Tb_Usuario.TabIndex = 2;
            this.Tb_Usuario.Text = "gojo";
            this.Tb_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tb_Usuario.TextChanged += new System.EventHandler(this.Tb_Usuario_TextChanged);
            this.Tb_Usuario.Enter += new System.EventHandler(this.Tb_Usuario_Enter);
            this.Tb_Usuario.Leave += new System.EventHandler(this.Tb_Usuario_Leave);
            // 
            // Tb_Senha
            // 
            this.Tb_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Senha.Location = new System.Drawing.Point(29, 278);
            this.Tb_Senha.Name = "Tb_Senha";
            this.Tb_Senha.PasswordChar = '*';
            this.Tb_Senha.Size = new System.Drawing.Size(199, 26);
            this.Tb_Senha.TabIndex = 3;
            this.Tb_Senha.Text = "1234";
            this.Tb_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tb_Senha.Enter += new System.EventHandler(this.Tb_Senha_Enter);
            this.Tb_Senha.Leave += new System.EventHandler(this.Tb_Senha_Leave);
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Fechar.Location = new System.Drawing.Point(161, 375);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(74, 41);
            this.Btn_Fechar.TabIndex = 7;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_Logar
            // 
            this.Btn_Logar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Logar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Logar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Logar.Location = new System.Drawing.Point(22, 375);
            this.Btn_Logar.Name = "Btn_Logar";
            this.Btn_Logar.Size = new System.Drawing.Size(74, 41);
            this.Btn_Logar.TabIndex = 8;
            this.Btn_Logar.Text = "Entrar";
            this.Btn_Logar.UseVisualStyleBackColor = false;
            this.Btn_Logar.Click += new System.EventHandler(this.Btn_Logar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Projeto_ENIR.Properties.Resources.User;
            this.pictureBox4.Location = new System.Drawing.Point(29, 168);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Projeto_ENIR.Properties.Resources.cadeado;
            this.pictureBox3.Location = new System.Drawing.Point(29, 248);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_ENIR.Properties.Resources.do_utilizador;
            this.pictureBox1.Location = new System.Drawing.Point(77, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 31);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 31);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(261, 494);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Btn_Logar);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Tb_Senha);
            this.Controls.Add(this.Tb_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tb_Usuario;
        private System.Windows.Forms.TextBox Tb_Senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_Logar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}