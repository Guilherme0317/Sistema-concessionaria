namespace Projeto_ENIR
{
    partial class Compra_veiculo
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
            this.Dgv_veiculos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Tb_comprar = new System.Windows.Forms.TextBox();
            this.Btn_compra = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_veiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 24);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 50);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Dgv_veiculos
            // 
            this.Dgv_veiculos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_veiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_veiculos.Location = new System.Drawing.Point(31, 170);
            this.Dgv_veiculos.Name = "Dgv_veiculos";
            this.Dgv_veiculos.RowHeadersWidth = 51;
            this.Dgv_veiculos.RowTemplate.Height = 24;
            this.Dgv_veiculos.Size = new System.Drawing.Size(738, 290);
            this.Dgv_veiculos.TabIndex = 5;
            this.Dgv_veiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_veiculos_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(31, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 16);
            this.panel3.TabIndex = 6;
            // 
            // Tb_comprar
            // 
            this.Tb_comprar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_comprar.Location = new System.Drawing.Point(148, 102);
            this.Tb_comprar.Multiline = true;
            this.Tb_comprar.Name = "Tb_comprar";
            this.Tb_comprar.Size = new System.Drawing.Size(438, 33);
            this.Tb_comprar.TabIndex = 7;
            this.Tb_comprar.TextChanged += new System.EventHandler(this.Tb_comprar_TextChanged);
            // 
            // Btn_compra
            // 
            this.Btn_compra.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_compra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_compra.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.Btn_compra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_compra.Location = new System.Drawing.Point(617, 102);
            this.Btn_compra.Name = "Btn_compra";
            this.Btn_compra.Size = new System.Drawing.Size(152, 41);
            this.Btn_compra.TabIndex = 8;
            this.Btn_compra.Text = "Efetuar Compra";
            this.Btn_compra.UseVisualStyleBackColor = false;
            this.Btn_compra.Click += new System.EventHandler(this.Btn_compra_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(31, 452);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(738, 17);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Compra De Veiculo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_ENIR.Properties.Resources.frota;
            this.pictureBox1.Location = new System.Drawing.Point(43, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Compra_veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_compra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Tb_comprar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Dgv_veiculos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Compra_veiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de veiculo";
            this.Load += new System.EventHandler(this.Compra_veiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_veiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_veiculos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Tb_comprar;
        private System.Windows.Forms.Button Btn_compra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}