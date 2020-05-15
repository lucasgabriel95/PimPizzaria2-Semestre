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
    public partial class FormSelPedido : Form
    {
        public FormSelPedido()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {

            FormPedido form = new FormPedido();
            form.Show();
        }

        private void btnGerenciamento_Click(object sender, EventArgs e)
        {
            FormControlePedidos form = new FormControlePedidos();
            form.ShowDialog();
        }
    }
}
