using PizzariaPim.Control;
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
    public partial class FormBebida : Form
    {
        public FormBebida()
        {
            InitializeComponent();
            AlterarBotoes(2);
        }
        int codigo;
        public string salvarEditar;
        
        public void limpar()
        {
            txbCodigo.Clear();
            txbDescricao.Clear();
            txbQuantidade.Clear();
            txbTipo.Text = "";
            txbValor.Clear();
        }

        public void Localizar()
        {
            ComandosBebidas cf = new ComandosBebidas();
            dgGride.DataSource = cf.LocalizarBebida(txbDescricao.Text);
        }

        public void AlterarBotoes (int op)
        {
            if( 1 == op)
            {
                txbCodigo.Enabled = true;               
                txbTipo.Enabled = true;
                txbQuantidade.Enabled = true;
                txbValor.Enabled = true;
            }
            if (2== op)
            {
                txbCodigo.Enabled = false;                
                txbTipo.Enabled = false;
                txbQuantidade.Enabled = false;
                txbValor.Enabled = false;
            }
        }
        private void FormBebida_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Bebidas'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_BebidasTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Bebidas);

        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (salvarEditar == "Incluir")
            {


                if (txbDescricao.Text != "" && txbTipo.Text != "" && txbQuantidade.Text != "" && txbValor.Text != "")
                {
                    DialogResult mensagem;
                    mensagem = MessageBox.Show("Deseja cadastrar bebida ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensagem.ToString() == "Yes")
                    {
                        ControleBebidas controle = new ControleBebidas();
                        controle.CadastrarBebida(txbDescricao.Text, txbTipo.Text, Convert.ToInt32(txbQuantidade.Text), Convert.ToDouble(txbValor.Text));
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
                    DadosBebidas dados = new DadosBebidas();
                    dados.codigo = Convert.ToInt32(txbCodigo.Text);
                    dados.descricao = txbDescricao.Text;
                    dados.tipo = txbTipo.Text;
                    dados.quantidade = Convert.ToInt32(txbQuantidade.Text);
                    dados.valor = Convert.ToDouble(txbValor.Text);
                    ControleBebidas controle = new ControleBebidas();
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
                    ControleBebidas controle = new ControleBebidas();
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
            ComandosBebidas comando = new ComandosBebidas();
            DadosBebidas dados = comando.CarregarBebida(codigo);
            txbCodigo.Text = dados.codigo.ToString();
            txbDescricao.Text = dados.descricao;
            txbTipo.Text = dados.tipo;
            txbQuantidade.Text = dados.quantidade.ToString();
            txbValor.Text = dados.valor.ToString();
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
            Localizar();
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
    }
}
