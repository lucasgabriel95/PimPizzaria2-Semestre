﻿namespace PizzariaPim
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.credits = new System.Windows.Forms.Label();
            this.LogoLogin = new System.Windows.Forms.PictureBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label3 = new System.Windows.Forms.Label();
            this.EsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnMinimizaAgenda = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLogin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizaAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.credits.Location = new System.Drawing.Point(491, 335);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(156, 13);
            this.credits.TabIndex = 16;
            this.credits.Text = "Desenvolved by PizzaHot 2020";
            // 
            // LogoLogin
            // 
            this.LogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("LogoLogin.Image")));
            this.LogoLogin.Location = new System.Drawing.Point(27, 59);
            this.LogoLogin.Name = "LogoLogin";
            this.LogoLogin.Size = new System.Drawing.Size(152, 120);
            this.LogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoLogin.TabIndex = 18;
            this.LogoLogin.TabStop = false;
            // 
            // txbLogin
            // 
            this.txbLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txbLogin.Location = new System.Drawing.Point(281, 141);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(276, 23);
            this.txbLogin.TabIndex = 1;
            this.txbLogin.Text = "LOGIN";
            this.txbLogin.Enter += new System.EventHandler(this.txbLogin_Enter);
            this.txbLogin.Leave += new System.EventHandler(this.txbLogin_Leave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntrar.Location = new System.Drawing.Point(280, 258);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(276, 36);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LogoLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 360);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(76, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Todos Direitos Reservados.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "AQUI VOCÊ COME BEM!";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(651, 360);
            this.shapeContainer1.TabIndex = 21;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 280;
            this.lineShape2.X2 = 556;
            this.lineShape2.Y1 = 210;
            this.lineShape2.Y2 = 210;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 279;
            this.lineShape1.X2 = 555;
            this.lineShape1.Y1 = 169;
            this.lineShape1.Y2 = 169;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(350, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 39);
            this.label3.TabIndex = 22;
            this.label3.Text = "LOGIN";
            // 
            // EsqueceuSenha
            // 
            this.EsqueceuSenha.AutoSize = true;
            this.EsqueceuSenha.LinkColor = System.Drawing.Color.DimGray;
            this.EsqueceuSenha.Location = new System.Drawing.Point(371, 317);
            this.EsqueceuSenha.Name = "EsqueceuSenha";
            this.EsqueceuSenha.Size = new System.Drawing.Size(102, 13);
            this.EsqueceuSenha.TabIndex = 3;
            this.EsqueceuSenha.TabStop = true;
            this.EsqueceuSenha.Text = "Esqueceu a senha?";
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSenha.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txbSenha.Location = new System.Drawing.Point(281, 183);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(276, 23);
            this.txbSenha.TabIndex = 2;
            this.txbSenha.Text = "SENHA";
            this.txbSenha.Enter += new System.EventHandler(this.txbSenha_MouseEnter);
            this.txbSenha.Leave += new System.EventHandler(this.txbSenha_Leave);
            // 
            // btnMinimizaAgenda
            // 
            this.btnMinimizaAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizaAgenda.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizaAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizaAgenda.Image")));
            this.btnMinimizaAgenda.Location = new System.Drawing.Point(405, 4);
            this.btnMinimizaAgenda.Name = "btnMinimizaAgenda";
            this.btnMinimizaAgenda.Size = new System.Drawing.Size(22, 22);
            this.btnMinimizaAgenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizaAgenda.TabIndex = 27;
            this.btnMinimizaAgenda.TabStop = false;
            this.btnMinimizaAgenda.Click += new System.EventHandler(this.btnMinimizaAgenda_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(429, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 22);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 26;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btnMinimizaAgenda);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 28);
            this.panel2.TabIndex = 25;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(651, 360);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.EsqueceuSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.LogoLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizaAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label credits;
        private System.Windows.Forms.PictureBox LogoLogin;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel EsqueceuSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.PictureBox btnMinimizaAgenda;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel panel2;
    }
}