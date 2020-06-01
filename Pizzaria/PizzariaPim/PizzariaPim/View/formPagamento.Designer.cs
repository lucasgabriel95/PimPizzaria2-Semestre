namespace PizzariaPim.View
{
    partial class formPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPagamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbDesconto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbRecebido = new System.Windows.Forms.TextBox();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnDinheiro = new System.Windows.Forms.Button();
            this.btnCartao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFormadePagamento = new System.Windows.Forms.Label();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txbDesconto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(11, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 179);
            this.panel1.TabIndex = 0;
            // 
            // txbDesconto
            // 
            this.txbDesconto.BackColor = System.Drawing.Color.Black;
            this.txbDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txbDesconto.Location = new System.Drawing.Point(15, 64);
            this.txbDesconto.Multiline = true;
            this.txbDesconto.Name = "txbDesconto";
            this.txbDesconto.Size = new System.Drawing.Size(100, 31);
            this.txbDesconto.TabIndex = 55;
            this.txbDesconto.Text = "0,00";
            this.txbDesconto.TextChanged += new System.EventHandler(this.txbDesconto_TextChanged);
            this.txbDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDesconto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desconto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sub Total";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.lblSubtotal);
            this.panel5.Location = new System.Drawing.Point(14, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 31);
            this.panel5.TabIndex = 51;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Black;
            this.lblSubtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSubtotal.Location = new System.Drawing.Point(0, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(62, 29);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "0,00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtotal.TextChanged += new System.EventHandler(this.lblSubtotal_TextChanged);
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.lblTotal);
            this.panel6.Location = new System.Drawing.Point(14, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 31);
            this.panel6.TabIndex = 52;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Black;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 29);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txbRecebido);
            this.panel2.Controls.Add(this.btn100);
            this.panel2.Controls.Add(this.btn50);
            this.panel2.Controls.Add(this.btn20);
            this.panel2.Controls.Add(this.btn10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(150, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 110);
            this.panel2.TabIndex = 1;
            // 
            // txbRecebido
            // 
            this.txbRecebido.BackColor = System.Drawing.Color.Black;
            this.txbRecebido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRecebido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txbRecebido.Location = new System.Drawing.Point(8, 18);
            this.txbRecebido.Multiline = true;
            this.txbRecebido.Name = "txbRecebido";
            this.txbRecebido.Size = new System.Drawing.Size(100, 31);
            this.txbRecebido.TabIndex = 54;
            this.txbRecebido.Text = "0,00";
            this.txbRecebido.TextChanged += new System.EventHandler(this.txbRecebido_TextChanged);
            this.txbRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRecebido_KeyPress);
            // 
            // btn100
            // 
            this.btn100.ForeColor = System.Drawing.Color.Green;
            this.btn100.Location = new System.Drawing.Point(191, 62);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(65, 31);
            this.btn100.TabIndex = 8;
            this.btn100.Text = "R$ 100,00";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn50
            // 
            this.btn50.ForeColor = System.Drawing.Color.Green;
            this.btn50.Location = new System.Drawing.Point(126, 62);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(59, 31);
            this.btn50.TabIndex = 7;
            this.btn50.Text = "R$ 50,00";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn20
            // 
            this.btn20.ForeColor = System.Drawing.Color.Green;
            this.btn20.Location = new System.Drawing.Point(192, 17);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(64, 31);
            this.btn20.TabIndex = 6;
            this.btn20.Text = "R$ 20,00";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn10
            // 
            this.btn10.ForeColor = System.Drawing.Color.Green;
            this.btn10.Location = new System.Drawing.Point(126, 17);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(59, 31);
            this.btn10.TabIndex = 5;
            this.btn10.Text = "R$ 10,00";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Troco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Recebido";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.lblTroco);
            this.panel7.Location = new System.Drawing.Point(8, 62);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 31);
            this.panel7.TabIndex = 53;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.BackColor = System.Drawing.Color.Black;
            this.lblTroco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.Yellow;
            this.lblTroco.Location = new System.Drawing.Point(0, 0);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(62, 29);
            this.lblTroco.TabIndex = 9;
            this.lblTroco.Text = "0,00";
            this.lblTroco.TextChanged += new System.EventHandler(this.lblTroco_TextChanged);
            // 
            // btnDinheiro
            // 
            this.btnDinheiro.Image = ((System.Drawing.Image)(resources.GetObject("btnDinheiro.Image")));
            this.btnDinheiro.Location = new System.Drawing.Point(150, 195);
            this.btnDinheiro.Name = "btnDinheiro";
            this.btnDinheiro.Size = new System.Drawing.Size(75, 67);
            this.btnDinheiro.TabIndex = 2;
            this.btnDinheiro.UseVisualStyleBackColor = true;
            this.btnDinheiro.Click += new System.EventHandler(this.btnDinheiro_Click);
            // 
            // btnCartao
            // 
            this.btnCartao.Image = ((System.Drawing.Image)(resources.GetObject("btnCartao.Image")));
            this.btnCartao.Location = new System.Drawing.Point(231, 195);
            this.btnCartao.Name = "btnCartao";
            this.btnCartao.Size = new System.Drawing.Size(75, 67);
            this.btnCartao.TabIndex = 3;
            this.btnCartao.UseVisualStyleBackColor = true;
            this.btnCartao.Click += new System.EventHandler(this.btnCartao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Foma de Pamenento:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblFormadePagamento);
            this.panel3.Controls.Add(this.btnFinalizarVenda);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnCartao);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnDinheiro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 318);
            this.panel3.TabIndex = 5;
            // 
            // lblFormadePagamento
            // 
            this.lblFormadePagamento.AutoSize = true;
            this.lblFormadePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormadePagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFormadePagamento.Location = new System.Drawing.Point(111, 284);
            this.lblFormadePagamento.Name = "lblFormadePagamento";
            this.lblFormadePagamento.Size = new System.Drawing.Size(0, 13);
            this.lblFormadePagamento.TabIndex = 50;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(312, 195);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(100, 67);
            this.btnFinalizarVenda.TabIndex = 49;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = false;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btnFechar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 28);
            this.panel4.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 74;
            this.label11.Text = "PAGAMENTO";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(400, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 22);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 73;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // formPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 318);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPagamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDinheiro;
        private System.Windows.Forms.Button btnCartao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Label lblFormadePagamento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbRecebido;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.TextBox txbDesconto;
    }
}