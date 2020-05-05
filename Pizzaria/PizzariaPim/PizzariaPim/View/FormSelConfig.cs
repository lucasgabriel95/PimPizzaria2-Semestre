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
    public partial class FormSelConfig : Form
    {
        public FormSelConfig()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            ConfigUser cu = new ConfigUser();
            cu.ShowDialog();
            
        }

        private void btn_imp_Click(object sender, EventArgs e)
        {

        }

        private void txt_configImp_Click(object sender, EventArgs e)
        {

        }

        private void txt_configuser_Click(object sender, EventArgs e)
        {

        }
    }
}
