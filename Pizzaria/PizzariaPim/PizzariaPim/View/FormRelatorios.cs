using PizzariaPim.Model.Relatorios;
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
    public partial class FormRelatorios : Form
    {
        public FormRelatorios()
        {
            InitializeComponent();
            codigo = 1;
            LocalizarItens();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        String Data1 ="", Data2="",Status,Satifacao;
        int codigo = 0;
        public void LocalizarItens()
        {
            ComandosRelatorios comandos = new ComandosRelatorios();
            dgGrideItens.DataSource = comandos.LocalizarIntens(Convert.ToString(codigo));
        }
        public void Localizar ()
        {
            ComandosRelatorios comandos = new ComandosRelatorios();
            dgGride.DataSource = comandos.Localizar(Data1,Data2, Status, Satifacao);
            comandos.QuantidadeValor(Data1, Data2, Status);
            comandos.QuantidadeVendas(Data1, Data2, Status);
            lblQuantidade.Text = comandos.Quantidade.ToString();
            lblValor.Text =comandos.valor.ToString();
            lblQuantidadeVendas.Text = comandos.QuantidadeVenda.ToString();

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.Text == "Todos")
            {
                Status = "";
            }
            else
            {
                Status = cbStatus.Text;
            }
            
        }

        private void dgGride_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    codigo = Convert.ToInt32(dgGride.Rows[e.RowIndex].Cells[0].Value);
                }
            }
            LocalizarItens();
        }

        private void lblValor_TextChanged(object sender, EventArgs e)
        {
            if (lblValor.Text == "")
            {
                lblValor.Text = "0,00";
                lblQuantidade.Text = "0";
            }
            else
            {
                lblValor.Text = String.Format("{0:#,##0.00}", double.Parse(lblValor.Text));
            }
            
        }

        private void cbSatisfacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSatisfacao.Text == "Todos")
            {
                Satifacao = "";
            }
            else
            {
                Satifacao = cbSatisfacao.Text;
            }            
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            Data1 = Calendario.SelectionStart.ToString("yyyy/MM/dd HH:mm:dd");
            Data2 = Calendario.SelectionEnd.ToString("yyyy/MM/dd HH:mm:dd");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Data1 != "")
            {                
                Localizar();
                lblMenssagem.Text = "";
            }
            else
            {
                lblMenssagem.Text = "Selecione uma Data !!";
            }
        }

        private void FormRelatorios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Venda_INNER_JOIN'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_Venda_INNER_JOINTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Venda_INNER_JOIN);
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Intens_Venda_INNER_JOIN'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_Intens_Venda_INNER_JOINTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Intens_Venda_INNER_JOIN);

        }
    }
}
