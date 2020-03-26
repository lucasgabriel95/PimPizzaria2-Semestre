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
    public partial class MenuPrincipal : Form
    {
        private Form _objForm;
        public MenuPrincipal()
        {
            InitializeComponent();
            Login ln = new Login();
            ln.Hide();
        }

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
    }
}
