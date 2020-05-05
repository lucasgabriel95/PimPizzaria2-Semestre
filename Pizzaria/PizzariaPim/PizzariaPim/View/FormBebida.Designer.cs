namespace PizzariaPim.View
{
    partial class FormBebida
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
            this.bDpizzariaDataSet = new PizzariaPim.BDpizzariaDataSet();
            this.cadBebidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_BebidasTableAdapter = new PizzariaPim.BDpizzariaDataSetTableAdapters.Cad_BebidasTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brnIncluir = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTipo = new System.Windows.Forms.ComboBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.dgGride = new System.Windows.Forms.DataGridView();
            this.codigoBebidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoBebidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipobebidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeBebidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorBebidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDpizzariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadBebidasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGride)).BeginInit();
            this.SuspendLayout();
            // 
            // bDpizzariaDataSet
            // 
            this.bDpizzariaDataSet.DataSetName = "BDpizzariaDataSet";
            this.bDpizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadBebidasBindingSource
            // 
            this.cadBebidasBindingSource.DataMember = "Cad_Bebidas";
            this.cadBebidasBindingSource.DataSource = this.bDpizzariaDataSet;
            // 
            // cad_BebidasTableAdapter
            // 
            this.cad_BebidasTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.brnIncluir);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTipo);
            this.panel1.Controls.Add(this.txbValor);
            this.panel1.Controls.Add(this.txbQuantidade);
            this.panel1.Controls.Add(this.txbDescricao);
            this.panel1.Controls.Add(this.txbCodigo);
            this.panel1.Controls.Add(this.dgGride);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 573);
            this.panel1.TabIndex = 16;
            // 
            // brnIncluir
            // 
            this.brnIncluir.Location = new System.Drawing.Point(284, 78);
            this.brnIncluir.Name = "brnIncluir";
            this.brnIncluir.Size = new System.Drawing.Size(75, 23);
            this.brnIncluir.TabIndex = 30;
            this.brnIncluir.Text = "Incluir";
            this.brnIncluir.UseVisualStyleBackColor = true;
            this.brnIncluir.Click += new System.EventHandler(this.brnIncluir_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Location = new System.Drawing.Point(421, 488);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 29;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Location = new System.Drawing.Point(340, 488);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 28;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(259, 488);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 27;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descrição ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo";
            // 
            // txbTipo
            // 
            this.txbTipo.FormattingEnabled = true;
            this.txbTipo.Items.AddRange(new object[] {
            "150ML",
            "250ML",
            "350ML",
            "500ML",
            "1L",
            "1,5L",
            "2L",
            "3L"});
            this.txbTipo.Location = new System.Drawing.Point(531, 134);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(121, 21);
            this.txbTipo.TabIndex = 21;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(259, 194);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 20);
            this.txbValor.TabIndex = 20;
            this.txbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbValor_KeyPress);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(106, 194);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidade.TabIndex = 19;
            this.txbQuantidade.TextChanged += new System.EventHandler(this.txbQuantidade_TextChanged);
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(106, 135);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(253, 20);
            this.txbDescricao.TabIndex = 18;
            this.txbDescricao.TextChanged += new System.EventHandler(this.txbDescricao_TextChanged);
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(106, 81);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(100, 20);
            this.txbCodigo.TabIndex = 17;
            // 
            // dgGride
            // 
            this.dgGride.AllowUserToAddRows = false;
            this.dgGride.AllowUserToDeleteRows = false;
            this.dgGride.AutoGenerateColumns = false;
            this.dgGride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGride.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoBebidasDataGridViewTextBoxColumn,
            this.descricaoBebidasDataGridViewTextBoxColumn,
            this.tipobebidaDataGridViewTextBoxColumn,
            this.quantidadeBebidasDataGridViewTextBoxColumn,
            this.valorBebidasDataGridViewTextBoxColumn});
            this.dgGride.DataSource = this.cadBebidasBindingSource;
            this.dgGride.Location = new System.Drawing.Point(106, 302);
            this.dgGride.Name = "dgGride";
            this.dgGride.ReadOnly = true;
            this.dgGride.Size = new System.Drawing.Size(546, 150);
            this.dgGride.TabIndex = 16;
            this.dgGride.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGride_CellDoubleClick);
            // 
            // codigoBebidasDataGridViewTextBoxColumn
            // 
            this.codigoBebidasDataGridViewTextBoxColumn.DataPropertyName = "codigo_Bebidas";
            this.codigoBebidasDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.codigoBebidasDataGridViewTextBoxColumn.Name = "codigoBebidasDataGridViewTextBoxColumn";
            this.codigoBebidasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoBebidasDataGridViewTextBoxColumn
            // 
            this.descricaoBebidasDataGridViewTextBoxColumn.DataPropertyName = "descricao_Bebidas";
            this.descricaoBebidasDataGridViewTextBoxColumn.HeaderText = "DESCRIÇÃO";
            this.descricaoBebidasDataGridViewTextBoxColumn.Name = "descricaoBebidasDataGridViewTextBoxColumn";
            this.descricaoBebidasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipobebidaDataGridViewTextBoxColumn
            // 
            this.tipobebidaDataGridViewTextBoxColumn.DataPropertyName = "tipo_bebida";
            this.tipobebidaDataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tipobebidaDataGridViewTextBoxColumn.Name = "tipobebidaDataGridViewTextBoxColumn";
            this.tipobebidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeBebidasDataGridViewTextBoxColumn
            // 
            this.quantidadeBebidasDataGridViewTextBoxColumn.DataPropertyName = "quantidade_Bebidas";
            this.quantidadeBebidasDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE";
            this.quantidadeBebidasDataGridViewTextBoxColumn.Name = "quantidadeBebidasDataGridViewTextBoxColumn";
            this.quantidadeBebidasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorBebidasDataGridViewTextBoxColumn
            // 
            this.valorBebidasDataGridViewTextBoxColumn.DataPropertyName = "valor_Bebidas";
            this.valorBebidasDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.valorBebidasDataGridViewTextBoxColumn.Name = "valorBebidasDataGridViewTextBoxColumn";
            this.valorBebidasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBebida";
            this.Text = "FormBebida";
            this.Load += new System.EventHandler(this.FormBebida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDpizzariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadBebidasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGride)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BDpizzariaDataSet bDpizzariaDataSet;
        private System.Windows.Forms.BindingSource cadBebidasBindingSource;
        private BDpizzariaDataSetTableAdapters.Cad_BebidasTableAdapter cad_BebidasTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txbTipo;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.DataGridView dgGride;
        private System.Windows.Forms.Button brnIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBebidasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoBebidasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipobebidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeBebidasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorBebidasDataGridViewTextBoxColumn;
    }
}