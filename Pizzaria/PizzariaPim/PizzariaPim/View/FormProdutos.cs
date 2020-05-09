﻿using PizzariaPim.Control;
using PizzariaPim.Model.Bebidas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaPim.View
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
            AlterarBotoes(2);
        }
        int codigo;
        public string salvarEditar;

        public void limpar()
        {
            txbCodigo.Clear();
            txbNome.Clear();
            txbDescricao.Clear();
            txbQuantidade.Clear();
            txbValor.Clear();
            cbCategoria.Text = "";
        }

        public void Localizar()
        {
            ComandosProdutos cf = new ComandosProdutos();
            dgGride.DataSource = cf.LocalizarDescricao(txbNome.Text);
            dgGride.DataSource = cf.LocalizarCategoria(txbNome.Text);
        }

        public void AlterarBotoes(int op)
        {
            if (1 == op)
            {
                txbCodigo.Enabled = true;
                txbDescricao.Enabled = true;
                txbQuantidade.Enabled = true;
                txbValor.Enabled = true;
                cbCategoria.Enabled = true;
            }
            if (2 == op)
            {
                txbCodigo.Enabled = false;
                txbDescricao.Enabled = false;
                txbQuantidade.Enabled = false;
                txbValor.Enabled = false;
                cbCategoria.Enabled = false;
            }
        }
        private void FormProdutos_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_CategoriasTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Categorias);
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_ProdutosTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Produtos);

        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (salvarEditar == "Incluir")
            {


                if (txbNome.Text != "" && txbDescricao.Text != "" && txbValor.Text != "" && txbQuantidade.Text != "" && cbCategoria.Text != "")
                {
                    DialogResult mensagem;
                    mensagem = MessageBox.Show("Deseja cadastrar bebida ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensagem.ToString() == "Yes")
                    {
                        int Categoria;
                        if (cbCategoria.Text == "Pizza")
                        {
                            Categoria = 2;
                        }
                        else
                        {
                            Categoria = 1;
                        }
                        ControleProdutos controle = new ControleProdutos();
                        controle.Cadastrar(txbNome.Text, txbDescricao.Text, Convert.ToDouble(txbValor.Text), Convert.ToInt32(txbQuantidade.Text),Categoria);
                        MessageBox.Show("Bebida cadastrada com sucesso !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                        AlterarBotoes(2);
                        Localizar();
                    }
                }
                else
                {
                    MessageBox.Show("Os camnpos não pode ficar em branco !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult mensagem;
                mensagem = MessageBox.Show("Deseja Alterar bebida ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensagem.ToString() == "Yes")
                {
                    DadosProdutos dados = new DadosProdutos();
                    dados.Codigo = Convert.ToInt32(txbCodigo.Text);
                    dados.Nome = txbNome.Text;
                    dados.Descricao = txbDescricao.Text;
                    dados.Quantidade = Convert.ToInt32(txbQuantidade.Text);
                    dados.Valor = Convert.ToDouble(txbValor.Text);
                    if (dados.Categoria == 2)
                    {
                        cbCategoria.Text = "Pizza";
                    }
                    else
                    {
                        cbCategoria.Text = "Bebida";
                    }
                    ControleProdutos controle = new ControleProdutos();
                    controle.AlterarBebidas(dados);
                    MessageBox.Show("Bebida Alterada com sucesso !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    AlterarBotoes(2);

                }
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult menssagem;
            if (txbCodigo.Text != "")
            {
                menssagem = MessageBox.Show("Deseja Excluir bebida ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (menssagem.ToString() == "Yes")
                {
                    ControleProdutos controle = new ControleProdutos();
                    controle.Excluir(Convert.ToInt32(txbCodigo.Text));
                    MessageBox.Show("Bebida excluida com sucesso !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    AlterarBotoes(2);
                    Localizar();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma bebida na tabela para excluir !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (salvarEditar == "Alterar" || salvarEditar == "Incluir")
            {
                limpar();
                salvarEditar = "";
                AlterarBotoes(2);
            }
            else
            {
                this.Close();
            }
        }

        private void dgGride_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    codigo = Convert.ToInt32(dgGride.Rows[e.RowIndex].Cells[0].Value);
                }
            }
            ComandosProdutos comando = new ComandosProdutos();
            DadosProdutos dados = comando.Carregar(codigo);
            txbCodigo.Text = dados.Codigo.ToString();
            txbNome.Text = dados.Nome;
            txbDescricao.Text = dados.Descricao;
            txbQuantidade.Text = dados.Quantidade.ToString();
            txbValor.Text = dados.Valor.ToString();
            salvarEditar = "Alterar";
            AlterarBotoes(1);
        }

        private void brnIncluir_Click(object sender, EventArgs e)
        {
            AlterarBotoes(1);
            salvarEditar = "Incluir";
        }

        private void txbDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txbQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            Localizar();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




       
    