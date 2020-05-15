using PizzariaPim.DAL;
using PizzariaPim.Model.Vendas.Vendas;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PizzariaPim.View
{
    public partial class FormControlePedidos : Form
    {
        public FormControlePedidos()
        {
            InitializeComponent();           
            Localizar();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        String Categoria = "Ativo", Cliente;
        int codigoVenda;
        int codigoCliente;
        public void Localizar()
        {
           
            ComandosCadVenda comandos = new ComandosCadVenda();                  
            dgGride.DataSource = comandos.LocalizarNomeInneJoin(Cliente,Categoria);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult mensagemConfirmacao;
            mensagemConfirmacao = MessageBox.Show("Alterar Status do Cliente "+lblNomeCliente.Text+" ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensagemConfirmacao.ToString() == "Yes")
            {
                ComandosCadVenda comandos = new ComandosCadVenda();
                comandos.UpdateCategoria(codigoVenda, cbAlterarStatus.Text);
                Localizar();
                lblCodigoCliente.Text = "0";
                lblNomeCliente.Text = "Nome do Cliente";
            }            

            
        }

       
        private void txbNomeCliente_TextChanged(object sender, EventArgs e)
        {
            Cliente = txbNomeCliente.Text;
            Localizar();
        }

        private void cbPesquisaCategoria_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (cbPesquisaCategoria.Text == "Todas")
            {
                Categoria = "";
                Localizar();
            }
            else
            {
                Categoria = cbPesquisaCategoria.Text;
                Localizar();
            }
         
        }

        private void dgGride_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    codigoVenda = Convert.ToInt32(dgGride.Rows[e.RowIndex].Cells[0].Value);
                    codigoCliente = Convert.ToInt32(dgGride.Rows[e.RowIndex].Cells[4].Value);
                }
            }
            ComandosCadVenda comandos = new ComandosCadVenda();
            ComandosClientes clientes = new ComandosClientes();
            DadosCadVenda dados = comandos.Carregar(codigoVenda);
            DadosClientes clientes1 = clientes.carregar(codigoCliente);

            
            lblCodigoCliente.Text = dados.CodigoCliente.ToString();
            lblNomeCliente.Text = "- " + clientes1.nome;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgGride_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizaAgenda_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        
        }

        private void FormControlePedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Venda_INNER_JOIN'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_Venda_INNER_JOINTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Venda_INNER_JOIN);
        }


    }
}
