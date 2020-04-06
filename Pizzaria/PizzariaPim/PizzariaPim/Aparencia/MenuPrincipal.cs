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
    public partial class MenuPrincipal : Form
    {
        private Form _objForm;
        public MenuPrincipal()
        {
            InitializeComponent();
            Login ln = new Login();
            ln.Hide();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_config_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new Sel_Config
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlMenu.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
