namespace PizzariaPim
{
    partial class FormSelConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelConfig));
            this.txt_configuser = new System.Windows.Forms.Label();
            this.txt_configImp = new System.Windows.Forms.Label();
            this.btn_imp = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.panelll = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_configuser
            // 
            this.txt_configuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_configuser.AutoSize = true;
            this.txt_configuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_configuser.Location = new System.Drawing.Point(282, 244);
            this.txt_configuser.Name = "txt_configuser";
            this.txt_configuser.Size = new System.Drawing.Size(63, 13);
            this.txt_configuser.TabIndex = 8;
            this.txt_configuser.Text = "USUÁRIO";
            this.txt_configuser.Click += new System.EventHandler(this.txt_configuser_Click);
            // 
            // txt_configImp
            // 
            this.txt_configImp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_configImp.AutoSize = true;
            this.txt_configImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_configImp.Location = new System.Drawing.Point(399, 244);
            this.txt_configImp.Name = "txt_configImp";
            this.txt_configImp.Size = new System.Drawing.Size(88, 13);
            this.txt_configImp.TabIndex = 9;
            this.txt_configImp.Text = "IMPRESSORA";
            this.txt_configImp.Click += new System.EventHandler(this.txt_configImp_Click);
            // 
            // btn_imp
            // 
            this.btn_imp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_imp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imp.BackgroundImage")));
            this.btn_imp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imp.Location = new System.Drawing.Point(399, 260);
            this.btn_imp.Name = "btn_imp";
            this.btn_imp.Size = new System.Drawing.Size(90, 84);
            this.btn_imp.TabIndex = 2;
            this.btn_imp.UseVisualStyleBackColor = true;
            this.btn_imp.Click += new System.EventHandler(this.btn_imp_Click);
            // 
            // btn_user
            // 
            this.btn_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_user.BackgroundImage")));
            this.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_user.Location = new System.Drawing.Point(268, 260);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(90, 84);
            this.btn_user.TabIndex = 1;
            this.btn_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // panelll
            // 
            this.panelll.BackColor = System.Drawing.Color.White;
            this.panelll.Controls.Add(this.btn_user);
            this.panelll.Controls.Add(this.label2);
            this.panelll.Controls.Add(this.btn_imp);
            this.panelll.Controls.Add(this.txt_configImp);
            this.panelll.Controls.Add(this.pictureBox2);
            this.panelll.Controls.Add(this.txt_configuser);
            this.panelll.Controls.Add(this.label1);
            this.panelll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelll.Location = new System.Drawing.Point(0, 0);
            this.panelll.Name = "panelll";
            this.panelll.Size = new System.Drawing.Size(763, 571);
            this.panelll.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Versão 2020v2.1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(93, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "CENTRAL DE CONFIGURAÇÕES";
            // 
            // FormSelConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 571);
            this.Controls.Add(this.panelll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelConfig";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelll.ResumeLayout(false);
            this.panelll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txt_configuser;
        private System.Windows.Forms.Label txt_configImp;
        private System.Windows.Forms.Button btn_imp;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Panel panelll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}