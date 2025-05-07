namespace Projeto_ENIR
{
    partial class editar_excluir
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
            this.Dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuarios)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 34);
            this.panel1.TabIndex = 1;
            // 
            // Dgv_Usuarios
            // 
            this.Dgv_Usuarios.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Usuarios.Location = new System.Drawing.Point(7, 77);
            this.Dgv_Usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Usuarios.Name = "Dgv_Usuarios";
            this.Dgv_Usuarios.RowHeadersWidth = 51;
            this.Dgv_Usuarios.RowTemplate.Height = 24;
            this.Dgv_Usuarios.Size = new System.Drawing.Size(724, 381);
            this.Dgv_Usuarios.TabIndex = 2;
            this.Dgv_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Usuarios_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 48);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(7, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(724, 30);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabela De Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "_______________________________________";
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_excluir.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Btn_excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_excluir.Location = new System.Drawing.Point(784, 230);
            this.Btn_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(111, 49);
            this.Btn_excluir.TabIndex = 0;
            this.Btn_excluir.Text = "🗑️ Excluir";
            this.Btn_excluir.UseVisualStyleBackColor = false;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_editar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Btn_editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.Location = new System.Drawing.Point(784, 120);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(111, 49);
            this.Btn_editar.TabIndex = 1;
            this.Btn_editar.Text = "✏️ Editar";
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(784, 352);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // editar_excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(969, 529);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Dgv_Usuarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "editar_excluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar \\ Excluir";
            this.Load += new System.EventHandler(this.editar_excluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuarios)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_Usuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button button3;
    }
}