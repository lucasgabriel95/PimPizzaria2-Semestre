using PizzariaPim.DAL;
using PizzariaPim.Model.Bebidas;
using PizzariaPim.Model.Sabores;
using PizzariaPim.Model.Vendas;
using PizzariaPim.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaPim
{
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
            Carregar();
            localizar();
        }
        int codigo;
        ComandosPedidos pedidos = new ComandosPedidos();
        public void Limpar()
        {
            lblCodigo.Text = "";
            txbDescricaoProduto.Text = "";
            lblQuantidade.Text = "0";
            lblValorUnitario.Text = "0,00";
            lblValorTotal.Text = "0,00";
        }

        public void Carregar()
        {
            DadosVendas dados = new DadosVendas();
            ComandosPedidos comandos = new ComandosPedidos();
            comandos.GerarCodigoPedido();
            txbCodigoVenda.Text = Convert.ToString(comandos.vendaCodigo + 1);

        }

        public void localizar()
        {
            if (cbCategoria.Text == "Clientes")
            {
                ComandosClientes cf = new ComandosClientes();
                dgGride.DataSource = cf.localizar(txbDescricao.Text);
            }
            else if (cbCategoria.Text == "Sabores")
            {
                ComandosSabores cf = new ComandosSabores();
                dgGride.DataSource = cf.localizar(txbDescricao.Text);
            }
            else
            {
                ComandosBebidas cf = new ComandosBebidas();
                dgGride.DataSource = cf.LocalizarBebida(txbDescricao.Text);
            }
        }


        private void FormPedido_Load(object sender, EventArgs e)
        {

        }
        private void dgGride_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbCategoria.Text == "Clientes")
            {
                if (e.ColumnIndex >= 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        codigo = Convert.ToInt32(dgGride.Rows[e.RowIndex].Cells[0].Value);
                    }
                }
                ComandosClientes cf = new ComandosClientes();
                DadosClientes dadosClientes = cf.carregar(codigo);
                txbCodigoCliente.Text = dadosClientes.codigo.ToString() + " - " + dadosClientes.nome;
            }
            else if (cbCategoria.Text == "Sabores")
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
                txbDescricaoProduto.Text = dados.nome.ToString();
                lblValorUnitario.Text = dados.valorInteiro.ToString();
                lblCodigo.Text = dados.codigo.ToString();
                lblValorTotal.Text = lblValorUnitario.Text;
            }
            else
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
                txbDescricaoProduto.Text = dados.descricao.ToString();
                lblValorUnitario.Text = dados.valor.ToString();
                lblCodigo.Text = dados.codigo.ToString();
                lblValorTotal.Text = lblValorUnitario.Text;
                if (lblQuantidade.Text != "")
                {
                    double resultado = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValorUnitario.Text);
                    lblValorTotal.Text = Convert.ToString(resultado);
                }
            }
        }
        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            localizar();
        }

        private void txbQuantidade_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {

            if (lblCodigo.Text != "0" && lblQuantidade.Text != "0" && txbDescricaoProduto.Text != "")
            {
                dgGrideItens.Rows.Add(lblQuantidade.Text, lblCodigo.Text, txbDescricaoProduto.Text, "R$ " + lblValorUnitario.Text, lblValorTotal.Text);
                Limpar();
                foreach (DataGridViewRow linha in dgGrideItens.Rows)
                {
                    valor = Convert.ToDouble(linha.Cells[4].Value);

                }

                Subtotal += valor;
                lblSubTotal.Text = Subtotal.ToString();
                valor = 0;
            }
            else
            {
                MessageBox.Show("Selecione um produto na tabela !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            contadorMais = 0;
            ContadorMenos = 500;  

        }

        public double valor = 0;
        public double Subtotal;
        public double contadorMais = 0;
        public double ContadorMenos = 500;
        private void btnValorMais_Click(object sender, EventArgs e)
        {
            if (contadorMais != ContadorMenos)
            {
                contadorMais++;
                ContadorMenos++;
                lblQuantidade.Text = Convert.ToString(contadorMais);
                if (lblCodigo.Text != "0")
                {
                    double resultado = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValorUnitario.Text);
                    lblValorTotal.Text = Convert.ToString(resultado);
                }
            }
            if (contadorMais < 1)
            {
                contadorMais = 1;
                lblQuantidade.Text = Convert.ToString(contadorMais);
                if (lblCodigo.Text != "0")
                {
                    double resultado = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValorUnitario.Text);
                    lblValorTotal.Text = Convert.ToString(resultado);
                }
            }
        }
        private void btnValorMenos_Click(object sender, EventArgs e)
        {
            if (contadorMais != ContadorMenos)
            {

                contadorMais--;
                ContadorMenos--;
                lblQuantidade.Text = Convert.ToString(contadorMais);
                if (lblCodigo.Text != "0")
                {
                    double resultado = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValorUnitario.Text);
                    lblValorTotal.Text = Convert.ToString(resultado);
                }
            }
            if (contadorMais < 1)
            {
                contadorMais = 1;
                lblQuantidade.Text = Convert.ToString(contadorMais);
                if (lblCodigo.Text != "0")
                {
                    double resultado = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValorUnitario.Text);
                    lblValorTotal.Text = Convert.ToString(resultado);
                }
            }
        }
        private void lblValorUnitario_TextChanged(object sender, EventArgs e)
        {
            lblValorUnitario.Text = String.Format("{0:#,##0.00}", double.Parse(lblValorUnitario.Text));
        }
        private void lblValorTotal_TextChanged(object sender, EventArgs e)
        {
            lblValorTotal.Text = String.Format("{0:#,##0.00}", double.Parse(lblValorTotal.Text));
        }
        private void lblQuantidade_TextChanged(object sender, EventArgs e)
        {
            lblQuantidade.Text = String.Format("{0:#,##0.00}", double.Parse(lblQuantidade.Text));
        }

        private void lblSubTotal_TextChanged(object sender, EventArgs e)
        {
          lblSubTotal.Text = String.Format("{0:#,##0.00}", double.Parse(lblSubTotal.Text));
        }
        double linha;
        private void dgGrideItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    linha = Convert.ToDouble(dgGrideItens.Rows[e.RowIndex].Cells[4].Value);
                }
            }

            
            Subtotal = Subtotal- linha;
            lblSubTotal.Text = Subtotal.ToString();
            dgGrideItens.Rows.Remove(dgGrideItens.CurrentRow);
        }
    }
}
