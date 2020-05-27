namespace PizzariaPim
{
    partial class FormCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxCodigo = new System.Windows.Forms.TextBox();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.boxNomeCompleto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxTelefone = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.dgGride = new System.Windows.Forms.DataGridView();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpjClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDpizzariaDataSet = new PizzariaPim.BDpizzariaDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boxLogadouro = new System.Windows.Forms.TextBox();
            this.boxCEP = new System.Windows.Forms.TextBox();
            this.boxNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.boxBairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxComplemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDpizzariaDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.dgGride);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 534);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.boxCPF);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.boxCodigo);
            this.panel2.Controls.Add(this.btn_Incluir);
            this.panel2.Controls.Add(this.boxNomeCompleto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.boxTelefone);
            this.panel2.Location = new System.Drawing.Point(7, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 180);
            this.panel2.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(42, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "CPF";
            // 
            // boxCPF
            // 
            this.boxCPF.Location = new System.Drawing.Point(12, 58);
            this.boxCPF.Name = "boxCPF";
            this.boxCPF.Size = new System.Drawing.Size(167, 20);
            this.boxCPF.TabIndex = 0;
            this.boxCPF.TextChanged += new System.EventHandler(this.boxCPF_TextChanged);
            this.boxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxCPF_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "NOME COMPLETO";
            // 
            // boxCodigo
            // 
            this.boxCodigo.Enabled = false;
            this.boxCodigo.Location = new System.Drawing.Point(12, 13);
            this.boxCodigo.Name = "boxCodigo";
            this.boxCodigo.Size = new System.Drawing.Size(26, 20);
            this.boxCodigo.TabIndex = 42;
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.BackColor = System.Drawing.Color.Black;
            this.btn_Incluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Incluir.FlatAppearance.BorderSize = 0;
            this.btn_Incluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Incluir.ForeColor = System.Drawing.Color.White;
            this.btn_Incluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Incluir.Location = new System.Drawing.Point(191, 56);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 41;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = false;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click_1);
            // 
            // boxNomeCompleto
            // 
            this.boxNomeCompleto.Location = new System.Drawing.Point(12, 102);
            this.boxNomeCompleto.Name = "boxNomeCompleto";
            this.boxNomeCompleto.Size = new System.Drawing.Size(294, 20);
            this.boxNomeCompleto.TabIndex = 1;
            this.boxNomeCompleto.TextChanged += new System.EventHandler(this.boxNomeCompleto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "TELEFONE";
            // 
            // boxTelefone
            // 
            this.boxTelefone.Location = new System.Drawing.Point(12, 141);
            this.boxTelefone.Name = "boxTelefone";
            this.boxTelefone.Size = new System.Drawing.Size(167, 20);
            this.boxTelefone.TabIndex = 2;
            this.boxTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTelefone_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 28);
            this.panel3.TabIndex = 55;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(715, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 22);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 72;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "CLIENTES ";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.Black;
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.btn_Excluir.Location = new System.Drawing.Point(411, 499);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 53;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(330, 499);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 52;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.Black;
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.FlatAppearance.BorderSize = 0;
            this.btn_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.btn_Salvar.Location = new System.Drawing.Point(249, 499);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 51;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // dgGride
            // 
            this.dgGride.AllowUserToAddRows = false;
            this.dgGride.AllowUserToDeleteRows = false;
            this.dgGride.AutoGenerateColumns = false;
            this.dgGride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGride.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoClienteDataGridViewTextBoxColumn,
            this.cpfcnpjClienteDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.telefoneClienteDataGridViewTextBoxColumn,
            this.cepClienteDataGridViewTextBoxColumn,
            this.logradouroClienteDataGridViewTextBoxColumn,
            this.numeroClienteDataGridViewTextBoxColumn,
            this.bairroClienteDataGridViewTextBoxColumn,
            this.complementeClienteDataGridViewTextBoxColumn});
            this.dgGride.DataSource = this.cadClienteBindingSource;
            this.dgGride.Location = new System.Drawing.Point(7, 336);
            this.dgGride.Name = "dgGride";
            this.dgGride.ReadOnly = true;
            this.dgGride.Size = new System.Drawing.Size(727, 150);
            this.dgGride.TabIndex = 50;
            this.dgGride.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGride_CellDoubleClick);
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigo_Cliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoClienteDataGridViewTextBoxColumn.Width = 55;
            // 
            // cpfcnpjClienteDataGridViewTextBoxColumn
            // 
            this.cpfcnpjClienteDataGridViewTextBoxColumn.DataPropertyName = "cpf_cnpj_Cliente";
            this.cpfcnpjClienteDataGridViewTextBoxColumn.HeaderText = "CPF/CNPJ";
            this.cpfcnpjClienteDataGridViewTextBoxColumn.Name = "cpfcnpjClienteDataGridViewTextBoxColumn";
            this.cpfcnpjClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfcnpjClienteDataGridViewTextBoxColumn.Width = 115;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneClienteDataGridViewTextBoxColumn
            // 
            this.telefoneClienteDataGridViewTextBoxColumn.DataPropertyName = "telefone_Cliente";
            this.telefoneClienteDataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.telefoneClienteDataGridViewTextBoxColumn.Name = "telefoneClienteDataGridViewTextBoxColumn";
            this.telefoneClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepClienteDataGridViewTextBoxColumn
            // 
            this.cepClienteDataGridViewTextBoxColumn.DataPropertyName = "cep_Cliente";
            this.cepClienteDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cepClienteDataGridViewTextBoxColumn.Name = "cepClienteDataGridViewTextBoxColumn";
            this.cepClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logradouroClienteDataGridViewTextBoxColumn
            // 
            this.logradouroClienteDataGridViewTextBoxColumn.DataPropertyName = "logradouro_Cliente";
            this.logradouroClienteDataGridViewTextBoxColumn.HeaderText = "LOGRADOURO";
            this.logradouroClienteDataGridViewTextBoxColumn.Name = "logradouroClienteDataGridViewTextBoxColumn";
            this.logradouroClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroClienteDataGridViewTextBoxColumn
            // 
            this.numeroClienteDataGridViewTextBoxColumn.DataPropertyName = "numero_Cliente";
            this.numeroClienteDataGridViewTextBoxColumn.HeaderText = "NUMERO";
            this.numeroClienteDataGridViewTextBoxColumn.Name = "numeroClienteDataGridViewTextBoxColumn";
            this.numeroClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroClienteDataGridViewTextBoxColumn
            // 
            this.bairroClienteDataGridViewTextBoxColumn.DataPropertyName = "bairro_Cliente";
            this.bairroClienteDataGridViewTextBoxColumn.HeaderText = "BAIRRO";
            this.bairroClienteDataGridViewTextBoxColumn.Name = "bairroClienteDataGridViewTextBoxColumn";
            this.bairroClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementeClienteDataGridViewTextBoxColumn
            // 
            this.complementeClienteDataGridViewTextBoxColumn.DataPropertyName = "complemente_Cliente";
            this.complementeClienteDataGridViewTextBoxColumn.HeaderText = "COMPLEXO";
            this.complementeClienteDataGridViewTextBoxColumn.Name = "complementeClienteDataGridViewTextBoxColumn";
            this.complementeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadClienteBindingSource
            // 
            this.cadClienteBindingSource.DataMember = "Cad_Cliente";
            this.cadClienteBindingSource.DataSource = this.bDpizzariaDataSet;
            // 
            // bDpizzariaDataSet
            // 
            this.bDpizzariaDataSet.DataSetName = "BDpizzariaDataSet";
            this.bDpizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.boxLogadouro);
            this.panel4.Controls.Add(this.boxCEP);
            this.panel4.Controls.Add(this.boxNumero);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.boxBairro);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.boxComplemento);
            this.panel4.Location = new System.Drawing.Point(7, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(727, 100);
            this.panel4.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(182, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "LOGRADOURO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "CEP";
            // 
            // boxLogadouro
            // 
            this.boxLogadouro.Location = new System.Drawing.Point(182, 21);
            this.boxLogadouro.Name = "boxLogadouro";
            this.boxLogadouro.Size = new System.Drawing.Size(167, 20);
            this.boxLogadouro.TabIndex = 6;
            // 
            // boxCEP
            // 
            this.boxCEP.Location = new System.Drawing.Point(12, 20);
            this.boxCEP.Name = "boxCEP";
            this.boxCEP.Size = new System.Drawing.Size(167, 20);
            this.boxCEP.TabIndex = 5;
            this.boxCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxCEP_KeyPress);
            // 
            // boxNumero
            // 
            this.boxNumero.Location = new System.Drawing.Point(368, 20);
            this.boxNumero.Name = "boxNumero";
            this.boxNumero.Size = new System.Drawing.Size(73, 20);
            this.boxNumero.TabIndex = 7;
            this.boxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxNumero_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(368, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nº";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(182, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "COMPLEMENTO";
            // 
            // boxBairro
            // 
            this.boxBairro.Location = new System.Drawing.Point(12, 64);
            this.boxBairro.Name = "boxBairro";
            this.boxBairro.Size = new System.Drawing.Size(168, 20);
            this.boxBairro.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(12, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "BAIRRO";
            // 
            // boxComplemento
            // 
            this.boxComplemento.Location = new System.Drawing.Point(182, 64);
            this.boxComplemento.Name = "boxComplemento";
            this.boxComplemento.Size = new System.Drawing.Size(167, 20);
            this.boxComplemento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(5, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "ENDEREÇO";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 534);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDpizzariaDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxLogadouro;
        private System.Windows.Forms.TextBox boxCEP;
        private System.Windows.Forms.TextBox boxNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox boxBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxComplemento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxCodigo;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.TextBox boxNomeCompleto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.DataGridView dgGride;
        private BDpizzariaDataSet bDpizzariaDataSet;
        private System.Windows.Forms.BindingSource cadClienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpjClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox boxCPF;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}