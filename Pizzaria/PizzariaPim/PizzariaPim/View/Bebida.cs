using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PizzariaPim
{
    public partial class FormBebida : Form
    {
        public FormBebida()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBebida_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            MenuPrincipal RetornaMenu = new MenuPrincipal();
            RetornaMenu.Show();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBTipo.Size = new System.Drawing.Size(100, 100);
        }

        private void txbRefrigerante_MouseEnter(object sender, EventArgs e)
        {
            if (txbRefrigerante.Text == "Refrigerante")
            {
                txbRefrigerante.Text = "";
                txbRefrigerante.ForeColor = Color.DimGray;
            }
        }

        private void txbRefrigerante_MouseLeave(object sender, EventArgs e)
        {
            if (txbRefrigerante.Text == "")
            {
                txbRefrigerante.Text = "Refrigerante";
                txbRefrigerante.ForeColor = Color.DimGray;
            }
        }

        private void txbQtde_MouseEnter(object sender, EventArgs e)
        {
            if (txbQtde.Text == "Qtde")
            {
                txbQtde.Text = "";
                txbQtde.ForeColor = Color.DimGray;

            }
        }

        private void txbQtde_MouseLeave(object sender, EventArgs e)
        {
            if(txbQtde.Text == "")
            {
                txbQtde.Text = "Qtde";
                txbQtde.ForeColor = Color.DimGray;
            }
        }

        private void txbValor_MouseEnter(object sender, EventArgs e)
        {
            if(txbValor.Text == "Valor")
            {
                txbValor.Text = "";
                txbValor.ForeColor = Color.DimGray;
            }
        }

        private void txbValor_MouseLeave(object sender, EventArgs e)
        {
            if(txbValor.Text == "")
            {
                txbValor.Text = "Valor";
                txbValor.ForeColor = Color.DimGray;
            }
        }
    }
}
