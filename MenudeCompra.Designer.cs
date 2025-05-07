namespace Projeto_ENIR
{
    partial class MenudeCompra
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
            this.Tb_modelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_valor = new System.Windows.Forms.TextBox();
            this.Cb_cor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_finalizarpag = new System.Windows.Forms.Button();
            this.Cb_fmrpagamento = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_clientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cb_vendendor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Tb_modelo
            // 
            this.Tb_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_modelo.Location = new System.Drawing.Point(46, 172);
            this.Tb_modelo.Multiline = true;
            this.Tb_modelo.Name = "Tb_modelo";
            this.Tb_modelo.Size = new System.Drawing.Size(276, 31);
            this.Tb_modelo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(46, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo Do Veiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(46, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // Tb_valor
            // 
            this.Tb_valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_valor.Location = new System.Drawing.Point(46, 252);
            this.Tb_valor.Multiline = true;
            this.Tb_valor.Name = "Tb_valor";
            this.Tb_valor.Size = new System.Drawing.Size(276, 31);
            this.Tb_valor.TabIndex = 3;
            // 
            // Cb_cor
            // 
            this.Cb_cor.FormattingEnabled = true;
            this.Cb_cor.Items.AddRange(new object[] {
            "Prata",
            "Preto",
            "Amarelo",
            "Vermelho",
            "Azul",
            "Verde",
            "Rosa",
            "Grafite"});
            this.Cb_cor.Location = new System.Drawing.Point(46, 415);
            this.Cb_cor.Name = "Cb_cor";
            this.Cb_cor.Size = new System.Drawing.Size(121, 24);
            this.Cb_cor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(43, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(43, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forma de Pagamento";
            // 
            // Btn_finalizarpag
            // 
            this.Btn_finalizarpag.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_finalizarpag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_finalizarpag.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_finalizarpag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_finalizarpag.Location = new System.Drawing.Point(46, 532);
            this.Btn_finalizarpag.Name = "Btn_finalizarpag";
            this.Btn_finalizarpag.Size = new System.Drawing.Size(88, 53);
            this.Btn_finalizarpag.TabIndex = 8;
            this.Btn_finalizarpag.Text = "Finalizar ";
            this.Btn_finalizarpag.UseVisualStyleBackColor = false;
            this.Btn_finalizarpag.Click += new System.EventHandler(this.Btn_finalizarpag_Click);
            // 
            // Cb_fmrpagamento
            // 
            this.Cb_fmrpagamento.FormattingEnabled = true;
            this.Cb_fmrpagamento.Items.AddRange(new object[] {
            "Cartão",
            "Dinhero"});
            this.Cb_fmrpagamento.Location = new System.Drawing.Point(46, 484);
            this.Cb_fmrpagamento.Name = "Cb_fmrpagamento";
            this.Cb_fmrpagamento.Size = new System.Drawing.Size(121, 24);
            this.Cb_fmrpagamento.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 38);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 34);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(46, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome do Comprador";
            // 
            // Cb_clientes
            // 
            this.Cb_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_clientes.FormattingEnabled = true;
            this.Cb_clientes.Location = new System.Drawing.Point(46, 108);
            this.Cb_clientes.Name = "Cb_clientes";
            this.Cb_clientes.Size = new System.Drawing.Size(276, 33);
            this.Cb_clientes.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(42, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vendendor";
            // 
            // Cb_vendendor
            // 
            this.Cb_vendendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_vendendor.FormattingEnabled = true;
            this.Cb_vendendor.Location = new System.Drawing.Point(47, 327);
            this.Cb_vendendor.Name = "Cb_vendendor";
            this.Cb_vendendor.Size = new System.Drawing.Size(275, 33);
            this.Cb_vendendor.TabIndex = 15;
            // 
            // MenudeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 636);
            this.Controls.Add(this.Cb_vendendor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cb_clientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cb_fmrpagamento);
            this.Controls.Add(this.Btn_finalizarpag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cb_cor);
            this.Controls.Add(this.Tb_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_modelo);
            this.Name = "MenudeCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenudeCompra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenudeCompra_FormClosing);
            this.Load += new System.EventHandler(this.MenudeCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_modelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_valor;
        private System.Windows.Forms.ComboBox Cb_cor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_finalizarpag;
        private System.Windows.Forms.ComboBox Cb_fmrpagamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cb_clientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cb_vendendor;
    }
}