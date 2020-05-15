using PizzariaPim.Control;
using PizzariaPim.DAL;
using PizzariaPim.Model.Pedidos;
using PizzariaPim.Model.Vendas.Vendas;
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
    public partial class FormSatisfacao : Form
    {
        public FormSatisfacao()
        {
            InitializeComponent();            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txbCodigoCliente.Text != "")
            {        
                    ComandosElogioReclamacoes comandos = new ComandosElogioReclamacoes();
                    comandos.ConsultaUmtimaCompraCliente(Convert.ToInt32(txbCodigoCliente.Text));

                    ComandosClientes clientes = new ComandosClientes();
                    DadosClientes dados = clientes.carregar(Convert.ToInt32(txbCodigoCliente.Text));

                    lblNomeCliente.Text = dados.nome;
                    lblCodigoVenda.Text = comandos.CodigoVenda;
                    lblValorVenda.Text = comandos.valor;
                    
                
            }
            else
            {
                lblErro.Text = "O Campo codigo do cliente não pode ficar vazio!!";
            }
        }

        private void lblValorVenda_TextChanged(object sender, EventArgs e)
        {
            if (lblValorVenda.Text == "")
            {
                lblNomeCliente.Text = "Nome do Cliente";
                lblCodigoVenda.Text = "Codigo da Venda";
                lblValorVenda.Text = "0,00";
            }
            else
            {
                lblValorVenda.Text = String.Format("{0:#,##0.00}", double.Parse(lblValorVenda.Text));

            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbCodigoCliente.Text != "")
            {
                if (cbCategoria.Text != "")
                {
                    MessageBox.Show("Cadastro de Elogio ou Reclamção realizado com sucesso!! ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ComandosElogioReclamacoes comandos = new ComandosElogioReclamacoes();
                    comandos.Alterar( lblCodigoVenda.Text,cbCategoria.Text + " - " + txbElogioReclamacao.Text);   
                    txbCodigoCliente.Text = "";
                    txbElogioReclamacao.Text = "";
                    lblCodigoVenda.Text = "Codigo da Venda";
                    lblErro.Text = "";
                    lblNomeCliente.Text = "Nome do Cliente";
                    lblValorVenda.Text = "0,00";
                }
                else
                {
                    lblErro.Text = "O Campo satisção não pode ficar vazio!!";
                }
            }                
            else
            {
                lblErro.Text = "O Campo codigo do cliente não pode ficar vazio!!";
            }
           
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txbCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }    
}
