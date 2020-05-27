namespace PizzariaPim.View
{
    partial class FormRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbSatisfacao = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgGride = new System.Windows.Forms.DataGridView();
            this.cadVendaINNERJOINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDpizzariaDataSet = new PizzariaPim.BDpizzariaDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.dgGrideItens = new System.Windows.Forms.DataGridView();
            this.codigoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadIntensVendaINNERJOINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQuantidadeVendas = new System.Windows.Forms.Label();
            this.lblMenssagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cad_Intens_Venda_INNER_JOINTableAdapter = new PizzariaPim.BDpizzariaDataSetTableAdapters.Cad_Intens_Venda_INNER_JOINTableAdapter();
            this.cad_Venda_INNER_JOINTableAdapter = new PizzariaPim.BDpizzariaDataSetTableAdapters.Cad_Venda_INNER_JOINTableAdapter();
            this.codigoVendaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorpagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elogioRlecamacaoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgGride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadVendaINNERJOINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDpizzariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrideItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadIntensVendaINNERJOINBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSatisfacao
            // 
            this.cbSatisfacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSatisfacao.FormattingEnabled = true;
            this.cbSatisfacao.Items.AddRange(new object[] {
            "Elogios",
            "Reclamações ",
            "Todos"});
            this.cbSatisfacao.Location = new System.Drawing.Point(14, 339);
            this.cbSatisfacao.Name = "cbSatisfacao";
            this.cbSatisfacao.Size = new System.Drawing.Size(121, 23);
            this.cbSatisfacao.TabIndex = 4;
            this.cbSatisfacao.SelectedIndexChanged += new System.EventHandler(this.cbSatisfacao_SelectedIndexChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Concluido",
            "Cancelado",
            "Todos"});
            this.cbStatus.Location = new System.Drawing.Point(14, 284);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 23);
            this.cbStatus.TabIndex = 3;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(166, 284);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Loja 1",
            "Loja 2",
            "Loja 3",
            "Todas"});
            this.comboBox1.Location = new System.Drawing.Point(14, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status da Venda";
            // 
            // dgGride
            // 
            this.dgGride.AllowUserToAddRows = false;
            this.dgGride.AllowUserToDeleteRows = false;
            this.dgGride.AutoGenerateColumns = false;
            this.dgGride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGride.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoVendaDataGridViewTextBoxColumn1,
            this.valorDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.valorpagoDataGridViewTextBoxColumn,
            this.codigoClienteDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.statusVendaDataGridViewTextBoxColumn,
            this.dataVendaDataGridViewTextBoxColumn,
            this.obsVendaDataGridViewTextBoxColumn,
            this.elogioRlecamacaoVendaDataGridViewTextBoxColumn});
            this.dgGride.DataSource = this.cadVendaINNERJOINBindingSource;
            this.dgGride.Location = new System.Drawing.Point(306, 42);
            this.dgGride.Name = "dgGride";
            this.dgGride.ReadOnly = true;
            this.dgGride.Size = new System.Drawing.Size(961, 372);
            this.dgGride.TabIndex = 1;
            this.dgGride.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGride_CellClick);
            this.dgGride.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGride_CellContentClick);
            // 
            // cadVendaINNERJOINBindingSource
            // 
            this.cadVendaINNERJOINBindingSource.DataMember = "Cad_Venda_INNER JOIN";
            this.cadVendaINNERJOINBindingSource.DataSource = this.bDpizzariaDataSet;
            // 
            // bDpizzariaDataSet
            // 
            this.bDpizzariaDataSet.DataSetName = "BDpizzariaDataSet";
            this.bDpizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Satisfação Cliente";
            // 
            // Calendario
            // 
            this.Calendario.BackColor = System.Drawing.SystemColors.Highlight;
            this.Calendario.Location = new System.Drawing.Point(33, 48);
            this.Calendario.MaxSelectionCount = 366;
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            this.Calendario.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calendario.TitleForeColor = System.Drawing.Color.AliceBlue;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loja";
            // 
            // dgGrideItens
            // 
            this.dgGrideItens.AllowUserToAddRows = false;
            this.dgGrideItens.AllowUserToDeleteRows = false;
            this.dgGrideItens.AutoGenerateColumns = false;
            this.dgGrideItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrideItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.codigoVendaDataGridViewTextBoxColumn});
            this.dgGrideItens.DataSource = this.cadIntensVendaINNERJOINBindingSource;
            this.dgGrideItens.Location = new System.Drawing.Point(11, 421);
            this.dgGrideItens.Name = "dgGrideItens";
            this.dgGrideItens.ReadOnly = true;
            this.dgGrideItens.Size = new System.Drawing.Size(285, 269);
            this.dgGrideItens.TabIndex = 9;
            // 
            // codigoProdutoDataGridViewTextBoxColumn
            // 
            this.codigoProdutoDataGridViewTextBoxColumn.DataPropertyName = "codigo_Produto";
            this.codigoProdutoDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.codigoProdutoDataGridViewTextBoxColumn.Name = "codigoProdutoDataGridViewTextBoxColumn";
            this.codigoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoProdutoDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "PRODUTO";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "QTDE";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 40;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "Valor_Unitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "VALOR ";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUnitarioDataGridViewTextBoxColumn.Width = 50;
            // 
            // codigoVendaDataGridViewTextBoxColumn
            // 
            this.codigoVendaDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Venda";
            this.codigoVendaDataGridViewTextBoxColumn.HeaderText = "CODIGO VENDA";
            this.codigoVendaDataGridViewTextBoxColumn.Name = "codigoVendaDataGridViewTextBoxColumn";
            this.codigoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoVendaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cadIntensVendaINNERJOINBindingSource
            // 
            this.cadIntensVendaINNERJOINBindingSource.DataMember = "Cad_Intens_Venda INNER JOIN";
            this.cadIntensVendaINNERJOINBindingSource.DataSource = this.bDpizzariaDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOTAL PRODUTOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(732, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "VALOR";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(552, 475);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(18, 20);
            this.lblQuantidade.TabIndex = 12;
            this.lblQuantidade.Text = "0";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(732, 475);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 20);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "0,00";
            this.lblValor.TextChanged += new System.EventHandler(this.lblValor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "QUANTIDADE VENDAS";
            // 
            // lblQuantidadeVendas
            // 
            this.lblQuantidadeVendas.AutoSize = true;
            this.lblQuantidadeVendas.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeVendas.Location = new System.Drawing.Point(343, 475);
            this.lblQuantidadeVendas.Name = "lblQuantidadeVendas";
            this.lblQuantidadeVendas.Size = new System.Drawing.Size(18, 20);
            this.lblQuantidadeVendas.TabIndex = 15;
            this.lblQuantidadeVendas.Text = "0";
            // 
            // lblMenssagem
            // 
            this.lblMenssagem.AutoSize = true;
            this.lblMenssagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenssagem.ForeColor = System.Drawing.Color.Red;
            this.lblMenssagem.Location = new System.Drawing.Point(79, 388);
            this.lblMenssagem.Name = "lblMenssagem";
            this.lblMenssagem.Size = new System.Drawing.Size(0, 16);
            this.lblMenssagem.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblMenssagem);
            this.panel1.Controls.Add(this.lblQuantidadeVendas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.lblQuantidade);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgGrideItens);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Calendario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgGride);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.cbSatisfacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1278, 28);
            this.panel3.TabIndex = 75;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1252, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 22);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 73;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "RELATÓRIOS";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label7_MouseDown);
            // 
            // cad_Intens_Venda_INNER_JOINTableAdapter
            // 
            this.cad_Intens_Venda_INNER_JOINTableAdapter.ClearBeforeFill = true;
            // 
            // cad_Venda_INNER_JOINTableAdapter
            // 
            this.cad_Venda_INNER_JOINTableAdapter.ClearBeforeFill = true;
            // 
            // codigoVendaDataGridViewTextBoxColumn1
            // 
            this.codigoVendaDataGridViewTextBoxColumn1.DataPropertyName = "Codigo_Venda";
            dataGridViewCellStyle1.NullValue = null;
            this.codigoVendaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.codigoVendaDataGridViewTextBoxColumn1.HeaderText = "CODIGO";
            this.codigoVendaDataGridViewTextBoxColumn1.Name = "codigoVendaDataGridViewTextBoxColumn1";
            this.codigoVendaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codigoVendaDataGridViewTextBoxColumn1.Width = 74;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorDataGridViewTextBoxColumn.HeaderText = "VALOR TOTAL";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.Width = 60;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.descontoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.descontoDataGridViewTextBoxColumn.HeaderText = "DESCONTO";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descontoDataGridViewTextBoxColumn.Width = 75;
            // 
            // valorpagoDataGridViewTextBoxColumn
            // 
            this.valorpagoDataGridViewTextBoxColumn.DataPropertyName = "Valor_pago";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.valorpagoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorpagoDataGridViewTextBoxColumn.HeaderText = "VALOR PAGO";
            this.valorpagoDataGridViewTextBoxColumn.Name = "valorpagoDataGridViewTextBoxColumn";
            this.valorpagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorpagoDataGridViewTextBoxColumn.Width = 60;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Cliente";
            dataGridViewCellStyle5.NullValue = null;
            this.codigoClienteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "CODIGO CLIENTE";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoClienteDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "NOME DO CLIENTE";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeClienteDataGridViewTextBoxColumn.Width = 130;
            // 
            // statusVendaDataGridViewTextBoxColumn
            // 
            this.statusVendaDataGridViewTextBoxColumn.DataPropertyName = "Status_Venda";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statusVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.statusVendaDataGridViewTextBoxColumn.HeaderText = "STATUS DA VENDA";
            this.statusVendaDataGridViewTextBoxColumn.Name = "statusVendaDataGridViewTextBoxColumn";
            this.statusVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusVendaDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            this.dataVendaDataGridViewTextBoxColumn.DataPropertyName = "data_Venda";
            dataGridViewCellStyle7.Format = "g";
            dataGridViewCellStyle7.NullValue = null;
            this.dataVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataVendaDataGridViewTextBoxColumn.HeaderText = "DATA DA VENDA";
            this.dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            this.dataVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsVendaDataGridViewTextBoxColumn
            // 
            this.obsVendaDataGridViewTextBoxColumn.DataPropertyName = "Obs_Venda";
            this.obsVendaDataGridViewTextBoxColumn.HeaderText = "OBS DO PEDIDO";
            this.obsVendaDataGridViewTextBoxColumn.Name = "obsVendaDataGridViewTextBoxColumn";
            this.obsVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elogioRlecamacaoVendaDataGridViewTextBoxColumn
            // 
            this.elogioRlecamacaoVendaDataGridViewTextBoxColumn.DataPropertyName = "ElogioRlecamacao_Venda";
            this.elogioRlecamacaoVendaDataGridViewTextBoxColumn.HeaderText = "ELOGIOS/RECLAMAÇÕES";
            this.elogioRlecamacaoVendaDataGridViewTextBoxColumn.Name = "elogioRlecamacaoVendaDataGridViewTextBoxColumn";
            this.elogioRlecamacaoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.elogioRlecamacaoVendaDataGridViewTextBoxColumn.Width = 180;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRelatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadVendaINNERJOINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDpizzariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrideItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadIntensVendaINNERJOINBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
     
        private System.Windows.Forms.ComboBox cbSatisfacao;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgGride;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgGrideItens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQuantidadeVendas;
        private System.Windows.Forms.Label lblMenssagem;
        private System.Windows.Forms.Panel panel1;
        private BDpizzariaDataSet bDpizzariaDataSet;
        private System.Windows.Forms.BindingSource cadIntensVendaINNERJOINBindingSource;
        private BDpizzariaDataSetTableAdapters.Cad_Intens_Venda_INNER_JOINTableAdapter cad_Intens_Venda_INNER_JOINTableAdapter;
        private System.Windows.Forms.BindingSource cadVendaINNERJOINBindingSource;
        private BDpizzariaDataSetTableAdapters.Cad_Venda_INNER_JOINTableAdapter cad_Venda_INNER_JOINTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVendaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorpagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elogioRlecamacaoVendaDataGridViewTextBoxColumn;
    }
}