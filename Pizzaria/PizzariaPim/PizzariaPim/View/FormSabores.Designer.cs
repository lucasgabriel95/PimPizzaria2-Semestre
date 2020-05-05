namespace PizzariaPim.View
{
    partial class FormSabores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.brnIncluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.dgGride = new System.Windows.Forms.DataGridView();
            this.codigoSaborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeSaborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientesaborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorBrotoSaborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorInteiraSaborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadesaborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadSaborBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDpizzariaDataSet = new PizzariaPim.BDpizzariaDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbValorInteira = new System.Windows.Forms.TextBox();
            this.txbValorBroto = new System.Windows.Forms.TextBox();
            this.txbIngredientes = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.cad_SaborTableAdapter = new PizzariaPim.BDpizzariaDataSetTableAdapters.Cad_SaborTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadSaborBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDpizzariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.brnIncluir);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbNome);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.dgGride);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbQuantidade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbValorInteira);
            this.panel1.Controls.Add(this.txbValorBroto);
            this.panel1.Controls.Add(this.txbIngredientes);
            this.panel1.Controls.Add(this.txbCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 534);
            this.panel1.TabIndex = 11;
            // 
            // brnIncluir
            // 
            this.brnIncluir.Location = new System.Drawing.Point(140, 56);
            this.brnIncluir.Name = "brnIncluir";
            this.brnIncluir.Size = new System.Drawing.Size(75, 23);
            this.brnIncluir.TabIndex = 31;
            this.brnIncluir.Text = "Incluir";
            this.brnIncluir.UseVisualStyleBackColor = true;
            this.brnIncluir.Click += new System.EventHandler(this.btn_Incluir_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(22, 98);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(193, 20);
            this.txbNome.TabIndex = 33;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Location = new System.Drawing.Point(407, 470);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 32;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Location = new System.Drawing.Point(326, 470);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 31;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(245, 470);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 30;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // dgGride
            // 
            this.dgGride.AutoGenerateColumns = false;
            this.dgGride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGride.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoSaborDataGridViewTextBoxColumn,
            this.nomeSaborDataGridViewTextBoxColumn,
            this.ingredientesaborDataGridViewTextBoxColumn,
            this.valorBrotoSaborDataGridViewTextBoxColumn,
            this.valorInteiraSaborDataGridViewTextBoxColumn,
            this.quantidadesaborDataGridViewTextBoxColumn});
            this.dgGride.DataSource = this.cadSaborBindingSource;
            this.dgGride.Location = new System.Drawing.Point(12, 287);
            this.dgGride.Name = "dgGride";
            this.dgGride.Size = new System.Drawing.Size(718, 150);
            this.dgGride.TabIndex = 21;
            this.dgGride.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGride_CellDoubleClick);
            // 
            // codigoSaborDataGridViewTextBoxColumn
            // 
            this.codigoSaborDataGridViewTextBoxColumn.DataPropertyName = "codigo_Sabor";
            this.codigoSaborDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.codigoSaborDataGridViewTextBoxColumn.Name = "codigoSaborDataGridViewTextBoxColumn";
            this.codigoSaborDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeSaborDataGridViewTextBoxColumn
            // 
            this.nomeSaborDataGridViewTextBoxColumn.DataPropertyName = "nome_Sabor";
            this.nomeSaborDataGridViewTextBoxColumn.HeaderText = "SABOR";
            this.nomeSaborDataGridViewTextBoxColumn.Name = "nomeSaborDataGridViewTextBoxColumn";
            this.nomeSaborDataGridViewTextBoxColumn.Width = 130;
            // 
            // ingredientesaborDataGridViewTextBoxColumn
            // 
            this.ingredientesaborDataGridViewTextBoxColumn.DataPropertyName = "ingrediente_sabor";
            this.ingredientesaborDataGridViewTextBoxColumn.HeaderText = "INGREDIENTES";
            this.ingredientesaborDataGridViewTextBoxColumn.Name = "ingredientesaborDataGridViewTextBoxColumn";
            // 
            // valorBrotoSaborDataGridViewTextBoxColumn
            // 
            this.valorBrotoSaborDataGridViewTextBoxColumn.DataPropertyName = "valor_Broto_Sabor";
            this.valorBrotoSaborDataGridViewTextBoxColumn.HeaderText = "VALOR BROTO";
            this.valorBrotoSaborDataGridViewTextBoxColumn.Name = "valorBrotoSaborDataGridViewTextBoxColumn";
            this.valorBrotoSaborDataGridViewTextBoxColumn.Width = 110;
            // 
            // valorInteiraSaborDataGridViewTextBoxColumn
            // 
            this.valorInteiraSaborDataGridViewTextBoxColumn.DataPropertyName = "valor_Inteira_Sabor";
            this.valorInteiraSaborDataGridViewTextBoxColumn.HeaderText = "VALOR INTEIRA";
            this.valorInteiraSaborDataGridViewTextBoxColumn.Name = "valorInteiraSaborDataGridViewTextBoxColumn";
            this.valorInteiraSaborDataGridViewTextBoxColumn.Width = 112;
            // 
            // quantidadesaborDataGridViewTextBoxColumn
            // 
            this.quantidadesaborDataGridViewTextBoxColumn.DataPropertyName = "quantidade_sabor";
            this.quantidadesaborDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE";
            this.quantidadesaborDataGridViewTextBoxColumn.Name = "quantidadesaborDataGridViewTextBoxColumn";
            // 
            // cadSaborBindingSource
            // 
            this.cadSaborBindingSource.DataMember = "Cad_Sabor";
            this.cadSaborBindingSource.DataSource = this.bDpizzariaDataSet;
            // 
            // bDpizzariaDataSet
            // 
            this.bDpizzariaDataSet.DataSetName = "BDpizzariaDataSet";
            this.bDpizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quantidade";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(22, 224);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(70, 20);
            this.txbQuantidade.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Valor Inteira";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Valor broto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ingredientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo";
            // 
            // txbValorInteira
            // 
            this.txbValorInteira.Location = new System.Drawing.Point(145, 181);
            this.txbValorInteira.Name = "txbValorInteira";
            this.txbValorInteira.Size = new System.Drawing.Size(70, 20);
            this.txbValorInteira.TabIndex = 14;
            // 
            // txbValorBroto
            // 
            this.txbValorBroto.Location = new System.Drawing.Point(22, 181);
            this.txbValorBroto.Name = "txbValorBroto";
            this.txbValorBroto.Size = new System.Drawing.Size(70, 20);
            this.txbValorBroto.TabIndex = 13;
            // 
            // txbIngredientes
            // 
            this.txbIngredientes.Location = new System.Drawing.Point(22, 137);
            this.txbIngredientes.Name = "txbIngredientes";
            this.txbIngredientes.Size = new System.Drawing.Size(342, 20);
            this.txbIngredientes.TabIndex = 12;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(25, 59);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(45, 20);
            this.txbCodigo.TabIndex = 11;
            // 
            // cad_SaborTableAdapter
            // 
            this.cad_SaborTableAdapter.ClearBeforeFill = true;
            // 
            // FormSabores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 534);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSabores";
            this.Text = "FormSabores";
            this.Load += new System.EventHandler(this.FormSabores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadSaborBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDpizzariaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgGride;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbValorInteira;
        private System.Windows.Forms.TextBox txbValorBroto;
        private System.Windows.Forms.TextBox txbIngredientes;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNome;
        private BDpizzariaDataSet bDpizzariaDataSet;
        private System.Windows.Forms.BindingSource cadSaborBindingSource;
        private BDpizzariaDataSetTableAdapters.Cad_SaborTableAdapter cad_SaborTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSaborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSaborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientesaborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorBrotoSaborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorInteiraSaborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadesaborDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button brnIncluir;
    }
}