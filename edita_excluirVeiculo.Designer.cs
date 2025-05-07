namespace Projeto_ENIR
{
    partial class edita_excluirVeiculo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Tbn_sair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(32, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 384);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(692, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 48);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "_______________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabela De Veiculos";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(349, 427);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_editar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Btn_editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.Location = new System.Drawing.Point(32, 426);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(82, 50);
            this.Btn_editar.TabIndex = 3;
            this.Btn_editar.Text = "✏️ Editar";
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_excluir.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Btn_excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_excluir.Location = new System.Drawing.Point(136, 426);
            this.Btn_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(84, 50);
            this.Btn_excluir.TabIndex = 4;
            this.Btn_excluir.Text = "🗑️ Excluir";
            this.Btn_excluir.UseVisualStyleBackColor = false;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Tbn_sair
            // 
            this.Tbn_sair.BackColor = System.Drawing.SystemColors.Highlight;
            this.Tbn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tbn_sair.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Tbn_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tbn_sair.Location = new System.Drawing.Point(245, 427);
            this.Tbn_sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tbn_sair.Name = "Tbn_sair";
            this.Tbn_sair.Size = new System.Drawing.Size(84, 50);
            this.Tbn_sair.TabIndex = 5;
            this.Tbn_sair.Text = "Sair";
            this.Tbn_sair.UseVisualStyleBackColor = false;
            this.Tbn_sair.Click += new System.EventHandler(this.Tbn_sair_Click);
            // 
            // edita_excluirVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 487);
            this.Controls.Add(this.Tbn_sair);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edita_excluirVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edita_excluirVeiculo";
            this.Load += new System.EventHandler(this.edita_excluirVeiculo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Button Tbn_sair;
    }
}