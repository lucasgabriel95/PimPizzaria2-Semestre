using PizzariaPim.Control;
using PizzariaPim.Model.Sabores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaPim.View
{
    public partial class FormSabores : Form
    {
        public int codigo;
        public int teste;
        public string alteraBotoes;
        public string salvarEditar;
        public FormSabores()
        {
            InitializeComponent();
            AlteraBotoes(2);
            Localizar();
        }
        public void LimparCampos()
        {
            txbCodigo.Clear();
            txbNome.Clear();
            txbIngredientes.Clear();
            txbValorBroto.Clear();
            txbValorInteira.Clear();
            txbQuantidade.Clear();
        }
        public void AlteraBotoes(int op)
        {

            if (op == 1)
            {
                txbNome.Enabled = true;
                txbIngredientes.Enabled = true;
                txbValorBroto.Enabled = true;
                txbValorInteira.Enabled = true;
                txbQuantidade.Enabled = true;
            }
            if (op == 2)
            {
                txbNome.Enabled = false;
                txbIngredientes.Enabled = false;
                txbValorBroto.Enabled = false;
                txbValorInteira.Enabled = false;
                txbQuantidade.Enabled = false;
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void Localizar()
        {
            ComandosSabores cf = new ComandosSabores();
            dgGride.DataSource = cf.localizar(txbNome.Text);
        }
        private void boxCPF_TextChanged(object sender, EventArgs e)
        {
            Localizar();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text != "" && txbIngredientes.Text != "" && txbValorBroto.Text != "" && txbValorInteira.Text != "" && txbQuantidade.Text != "")
            {
                if (salvarEditar == "novo")
                {
                    DialogResult mensagemConfirmacao;
                    mensagemConfirmacao = MessageBox.Show("Deseja Sabor Cliente ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mensagemConfirmacao.ToString() == "Yes")
                    {
                        if (this.salvarEditar == "novo")
                        {
                            ControleSabores controle = new ControleSabores();
                            controle.Cadastrar(txbNome.Text, txbIngredientes.Text, Convert.ToDouble(txbValorBroto.Text), Convert.ToDouble(txbValorInteira.Text), Convert.ToInt32(txbQuantidade.Text));
                            MessageBox.Show("Sabor cadastrado com Sucesso !!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AlteraBotoes(2);
                            LimparCampos();
                            alteraBotoes = "";
                        }
                    }
                }
                else
                {

                    DialogResult mensagemConfirmacao;
                    mensagemConfirmacao = MessageBox.Show("Deseja Alterar Sabor ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mensagemConfirmacao.ToString() == "Yes")
                    {
                        DadosSabores dadosSabores = new DadosSabores();
                        dadosSabores.nome = txbNome.Text;
                        dadosSabores.Ingrediente = txbIngredientes.Text;
                        dadosSabores.valorBroto = Convert.ToDouble(txbValorBroto.Text);
                        dadosSabores.valorInteiro = Convert.ToDouble(txbValorInteira.Text);
                        dadosSabores.quantidade = Convert.ToInt32(txbQuantidade.Text);
                        dadosSabores.codigo = Convert.ToInt32(txbCodigo.Text);
                        ControleSabores controleSabores = new ControleSabores();
                        controleSabores.Alterar(dadosSabores);
                        LimparCampos();
                        AlteraBotoes(2);
                    }
                }
            }
            else
            {
                MessageBox.Show("Oscampos não podem ficar em branco!!", "Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormSabores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Sabor'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_SaborTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Sabor);
        }
        private void btn_Incluir_Click_1(object sender, EventArgs e)
        {
            AlteraBotoes(1);
            LimparCampos();
            salvarEditar = "Incluir";
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (salvarEditar == "Incluir")
            {
                LimparCampos();
                salvarEditar = "";
                AlteraBotoes(2);
            }
            else
            {
                this.Close();
            }
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (txbCodigo.Text != "")
            {
                DialogResult mensagemConfirmacao;
                mensagemConfirmacao = MessageBox.Show("Deseja Excluir Cliente ?", "Aviso", MessageBoxButtons.YesNo);
                if (mensagemConfirmacao.ToString() == "Yes")
                {
                    ControleSabores controle = new ControleSabores();
                    controle.Excluir(codigo);
                    MessageBox.Show("Cadastro Excluido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlteraBotoes(2);
                    LimparCampos();
                    Localizar();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma bebida na tabela para excluir !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ComandosSabores comando = new ComandosSabores();
            DadosSabores dados = comando.carregar(codigo);
            txbCodigo.Text = dados.codigo.ToString();
            txbNome.Text = dados.nome;
            txbIngredientes.Text = dados.Ingrediente;
            txbValorBroto.Text = dados.valorBroto.ToString();
            txbValorInteira.Text = dados.valorInteiro.ToString();
            txbQuantidade.Text = dados.quantidade.ToString();
            salvarEditar = "Alterar";
            AlteraBotoes(1);
        }
    }
}
