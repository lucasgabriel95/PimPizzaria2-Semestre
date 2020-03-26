//using PizzariaPim.Aparencia;
using PizzariaPim.DAL;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ControleFuncionario controle = new ControleFuncionario();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuPrincipal Menu = new MenuPrincipal();
                Menu.Show();
                Login ln = new Login();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Login não econtrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
