using PizzariaPim.Control;
using PizzariaPim.Model.Vendas.Vendas;
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
    public partial class formPagamento : Form
    {
        public formPagamento()
        {
            InitializeComponent();
            txbRecebido.Enabled = false;
            AlterarBotoesValor(0);

        }
        int Codigo;
        double Valor;
        double Desconto;
        double ValorPago;
        double Recebido;
        double Troco;
        String formaPagamento; 
        int CodigoCliente;
        public int VendaRealizada = 1;

        String obs;
        public void AlterarBotoesValor(int numero)
        {
            if (numero == 1)
            {
                btn10.Enabled = true;
                btn20.Enabled = true;
                btn50.Enabled = true;
                btn100.Enabled = true;
            }
            else
            {
                btn10.Enabled = false;
                btn20.Enabled = false;
                btn50.Enabled = false;
                btn100.Enabled = false;
            }
        }
        public static void Moeda(ref TextBox txt)
        {
            String n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")

                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = String.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {

            }
        }

        public void PassarDadosVenda (int Codigo,double Total,int codigoCliente,String obs)
        {
            
            this.Codigo = Codigo;
            this.Valor = Total;                     
            this.CodigoCliente = codigoCliente;            
            this.obs = obs;
            CarregarDadosVenda();
        }
        public void CarregarDadosVenda ()
        {
           lblSubtotal.Text = Valor.ToString();
           lblTotal.Text = Valor.ToString();           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            lblFormadePagamento.Text = "Forma de pagamento Dinheiro !!";
            txbRecebido.Enabled = true;
            AlterarBotoesValor(1);
            formaPagamento = "Dinheiro";

        }

        private void btnCartao_Click(object sender, EventArgs e)
        {
            lblFormadePagamento.Text = "Forma de pagamento Cartão !!";
            txbRecebido.Text = "00,00";
            txbRecebido.Enabled = false;
            AlterarBotoesValor(0);
            formaPagamento = "Cartão";
        }     

       

        private void lblSubtotal_TextChanged(object sender, EventArgs e)
        {
            lblSubtotal.Text = String.Format("{0:#,##0.00}", double.Parse(lblSubtotal.Text));
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = String.Format("{0:#,##0.00}", double.Parse(lblTotal.Text));
        }

        private void lblTroco_TextChanged(object sender, EventArgs e)
        {
            lblTroco.Text = String.Format("{0:#,##0.00}", double.Parse(lblTroco.Text));
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void txbDesconto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txbDesconto);
            if (txbDesconto.Text != "")
            {
                Desconto = Convert.ToDouble(txbDesconto.Text);
                ValorPago = Valor - Desconto;
                if(ValorPago < 0)
                {
                    lblTotal.Text = "00,00";
                }
                else 
                {                    
                    lblTotal.Text = ValorPago.ToString();
                }
                
            }           
        }

        private void txbDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)1)
            {
                e.Handled = true;
            }
        }

        private void txbRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)1)
            {
                e.Handled = true;
            }
        }

        private void txbRecebido_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txbRecebido);         
            Recebido = Convert.ToDouble(txbRecebido.Text);
            ValorPago = Convert.ToDouble(lblTotal.Text);                
            Troco = Recebido - ValorPago;
            if (txbRecebido.Text == "0,00")
            {
                lblTroco.Text = "00,00";
            }
            else
            {
                lblTroco.Text = Troco.ToString();
            }
            
            
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txbRecebido.Text = "10,00";
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            txbRecebido.Text = "20,00";
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            txbRecebido.Text = "50,00";
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            txbRecebido.Text = "100,00";
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (formaPagamento != "")
            {
                if (formaPagamento == "Dinheiro")
                {
                    if (txbRecebido.Text != "0,00")
                    {
                        if (Convert.ToDouble(lblTroco.Text) > 0)
                        {
                            ComandosCadVenda comandos = new ComandosCadVenda();
                            comandos.UpDateInicializacao();
                            DadosCadVenda dados = new DadosCadVenda();
                            dados.Codigo = Codigo;
                            dados.Valor = Valor;
                            dados.Desconto = Desconto;
                            dados.ValorPago = ValorPago;
                            dados.Recebido = Recebido;
                            dados.Troco = Convert.ToDouble(lblTroco.Text);
                            dados.FormaPagamento = formaPagamento;
                            dados.CodigoCliente = CodigoCliente;
                            dados.Status = "Cozinha";
                            dados.obs = obs;
                            dados.DataTime = Convert.ToString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:dd"));
                            ControleVendas controle = new ControleVendas();
                            controle.Alterar(dados);
                            FormPedido form = new FormPedido();
                            MessageBox.Show("Venda Realizada com Sucesso !!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VendaRealizada = 2;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Valor recebido e menor do que o total da venda!!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Valor recebido não pode Ficar em Branco!!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
                else if (formaPagamento == "Cartão")
                {
                    ComandosCadVenda comandos = new ComandosCadVenda();
                    comandos.UpDateInicializacao();
                    DadosCadVenda dados = new DadosCadVenda();
                    dados.Codigo = Codigo;
                    dados.Valor = Valor;
                    dados.Desconto = Desconto;
                    dados.ValorPago = ValorPago;
                    dados.Recebido = Recebido;
                    dados.Troco = Convert.ToDouble(lblTroco.Text);
                    dados.FormaPagamento = formaPagamento;
                    dados.CodigoCliente = CodigoCliente;
                    dados.Status = "Cozinha";
                    dados.obs = obs;
                    dados.DataTime = Convert.ToString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:dd"));
                    ControleVendas controle = new ControleVendas();
                    controle.Alterar(dados);
                    FormPedido form = new FormPedido();
                    MessageBox.Show("Venda Realizada com Sucesso !!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VendaRealizada = 2;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecione a forma de pagamento !!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
