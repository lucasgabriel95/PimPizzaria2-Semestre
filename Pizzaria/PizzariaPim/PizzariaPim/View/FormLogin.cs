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
using System.Runtime.InteropServices;

namespace PizzariaPim
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ControleFuncionario controle = new ControleFuncionario();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show("Logado com sucesso!!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ComandoFuncionario comando = new ComandoFuncionario();
                DadosFuncionario dados = comando.carregarFuncionario2(txbLogin.Text);

                MenuPrincipal Menu = new MenuPrincipal();
                Menu.CarregarDadosFuncionario(dados.nome,dados.cargo);
                Menu.Show();
                Login ln = new Login();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Login não econtrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void txbLogin_Enter(object sender, EventArgs e)
        {
            if(txbLogin.Text == "LOGIN") {
                txbLogin.Text = "";
                txbLogin.ForeColor = Color.Black;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbLogin_Leave(object sender, EventArgs e)
        {
            if(txbLogin.Text == "")
            {
                txbLogin.Text = "LOGIN";
                txbLogin.ForeColor = Color.Black;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txbSenha_MouseEnter(object sender, EventArgs e)
        {
            if (txbSenha.Text == "SENHA")
            {
                txbSenha.Text = "";
                txbSenha.ForeColor = Color.Black;
                txbSenha.UseSystemPasswordChar = true;
            }
        }

        private void txbSenha_Leave(object sender, EventArgs e)
        {
            if (txbSenha.Text == "")
            {
                txbSenha.Text = "SENHA";
                txbSenha.ForeColor = Color.Black;
                txbSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizaAgenda_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
