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
using PizzariaPim.View;
using PizzariaPim.Model.Vendas.Vendas;

namespace PizzariaPim
{

    public partial class MenuPrincipal : Form
    {
        private Form _objForm;
        public MenuPrincipal()
        {
            InitializeComponent();
            Login ln = new Login();
            ln.Hide();
            AbrirFormulario(new FormHome());
            
        }       
        public void CarregarDadosFuncionario (String Nome, String Cargo)
        {
            lblNomeFuncionario.Text = "Bem-Vindo-" + Nome;

            if (Cargo == "Balconista")
            {
                btn_relatorio.Visible = false;
                btn_config.Visible = false;
                SelMenuRelatorio.Visible = false;
                SelMenuConfig.Visible = false;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        

        private void btn_config_Click(object sender, EventArgs e)
        {
            
            _objForm?.Close();

            _objForm = new FormSelConfig
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            PainelLogo.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormulario(object Formhijo)
        {
            if (this.PainelLogo.Controls.Count > 0)
                this.PainelLogo.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PainelLogo.Controls.Add(fh);
            this.PainelLogo.Tag = fh;
            fh.Show();
        }
        private void btn_config_Click_1(object sender, EventArgs e)
        {
            
            AbrirFormulario(new FormSelConfig());
        }
        
        private void btn_Bebidas_Click(object sender, EventArgs e)
        {

            FormProdutos form = new FormProdutos();
            form.ShowDialog();

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void btnPedido_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormSelPedido());
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.WindowState = FormWindowState.Normal;
            btnRestaura.Visible = false;
            btnMaximizar.Visible = true;
        }
       
        private void PainelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente();
            form.ShowDialog();
        }

        private void btn_Sabores_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios();
            form.ShowDialog();
        }

        private void btn_opc_Click(object sender, EventArgs e)
        {
            FormSatisfacao form = new FormSatisfacao();
            form.ShowDialog();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaura.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaura_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaura.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizaAgenda_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormHome());
        }
    }
}
