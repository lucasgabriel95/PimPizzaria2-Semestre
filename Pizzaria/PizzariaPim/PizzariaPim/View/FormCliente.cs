using PizzariaPim.Control;
using PizzariaPim.DAL;
using PizzariaPim.Model.Bebidas;
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

namespace PizzariaPim
{

    public partial class FormCliente : Form
    {
        public int codigo;
        public int teste;
        public string alteraBotoes;
        public string salvarEditar;
        public FormCliente()
        {
            InitializeComponent();
            AlteraBotoes(2);
            Localizar();
        }
        public void LimparCampos()
        {
            boxCPF.Clear();
            boxNomeCompleto.Clear();
            boxTelefone.Clear();
            
            boxCEP.Clear();
            boxLogadouro.Clear();
            boxNumero.Clear();
            boxBairro.Clear();
            boxComplemento.Clear();
            boxCodigo.Clear();
            
        }
        public void AlteraBotoes(int op)
        {

            if (op == 1)
            {
                boxCPF.Enabled = true;
                
                boxTelefone.Enabled = true;                
                boxCEP.Enabled = true;
                boxLogadouro.Enabled = true;
                boxNumero.Enabled = true;
                boxBairro.Enabled = true;
                boxComplemento.Enabled = true;               
            }
            if (op == 2)
            {
                boxCPF.Enabled = false;
                
                boxTelefone.Enabled = false;
                boxCEP.Enabled = false;
                boxLogadouro.Enabled = false;
                boxNumero.Enabled = false;
                boxBairro.Enabled = false;
                boxComplemento.Enabled = false;
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void Localizar()
        {
            ComandosClientes cf = new ComandosClientes();
            dgGride.DataSource = cf.localizar(boxNomeCompleto.Text);
        }
        private void boxCPF_TextChanged(object sender, EventArgs e)
        {
            Localizar();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (salvarEditar == "Alterar" || salvarEditar == "Incluir")
            {
                LimparCampos();
                salvarEditar = "";
                AlteraBotoes(2);
            }
            else
            {
                this.Close();
            }
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (boxNomeCompleto.Text != "" && boxTelefone.Text != "" && boxCEP.Text != "" && boxLogadouro.Text != "" && boxNumero.Text != "" && boxBairro.Text != "" && boxComplemento.Text != "" )
            {
                if (salvarEditar == "novo")
                {
                    DialogResult mensagemConfirmacao;
                    mensagemConfirmacao = MessageBox.Show("Deseja Cadastrar Cliente ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mensagemConfirmacao.ToString() == "Yes")
                    {
                        if (this.salvarEditar == "novo")
                        {
                            ControleClientes controle = new ControleClientes();
                            string mensagem = controle.Cadastrar(boxCPF.Text, boxNomeCompleto.Text, boxTelefone.Text,
                            boxCEP.Text, boxLogadouro.Text, boxNumero.Text, boxBairro.Text, boxComplemento.Text);
                            MessageBox.Show("Cliente cadastrado com Sucesso !!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AlteraBotoes(2);
                            LimparCampos();
                            alteraBotoes = "";
                        }
                    }
                }
                else
                {
                    
                    DialogResult mensagemConfirmacao;
                    mensagemConfirmacao = MessageBox.Show("Deseja Alterar Cliente ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mensagemConfirmacao.ToString() == "Yes")
                    {
                        DadosClientes dadosClientes = new DadosClientes();
                        dadosClientes.cpf_cnpj = boxCPF.Text;
                        dadosClientes.nome = boxNomeCompleto.Text;
                        dadosClientes.telefone = boxTelefone.Text;
                        dadosClientes.cep = boxCEP.Text;
                        dadosClientes.logradouro = boxLogadouro.Text;
                        dadosClientes.numero = boxNumero.Text;
                        dadosClientes.bairro = boxBairro.Text;
                        dadosClientes.complemento = boxComplemento.Text;
                        dadosClientes.codigo = Convert.ToInt32(boxCodigo.Text);
                        ComandosClientes comandosClientes = new ComandosClientes();
                        comandosClientes.Alterar(dadosClientes);
                        LimparCampos();
                        AlteraBotoes(2);
                    }
                }   
            }            
        }       
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (boxCodigo.Text != "")
            {
                DialogResult mensagemConfirmacao;
                mensagemConfirmacao = MessageBox.Show("Deseja Excluir Cliente ?", "AVISO", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (mensagemConfirmacao.ToString() == "Yes")
                {
                    ControleClientes controle = new ControleClientes();
                    controle.Excluir(codigo);
                    MessageBox.Show("Cadastro Excluido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlteraBotoes(2);
                    LimparCampos();
                    Localizar();
                }
            }
            
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgGride_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    codigo = Convert.ToInt32(dgGride.Rows[e.RowIndex].Cells[0].Value);
                }
            }
            ComandosClientes cf = new ComandosClientes();
            DadosClientes dadosClientes = cf.carregar(codigo);
            boxCodigo.Text = dadosClientes.codigo.ToString();
            boxCPF.Text = dadosClientes.cpf_cnpj;
            boxNomeCompleto.Text = dadosClientes.nome;
            boxTelefone.Text = dadosClientes.telefone;           
            boxCEP.Text = dadosClientes.cep;
            boxLogadouro.Text = dadosClientes.logradouro;
            boxNumero.Text = dadosClientes.numero;
            boxBairro.Text = dadosClientes.bairro;
            boxComplemento.Text = dadosClientes.complemento;           
            AlteraBotoes(1);
            alteraBotoes = "view";
            salvarEditar = "Alterar";
        }
        private void btn_Incluir_Click_1(object sender, EventArgs e)
        {
            AlteraBotoes(1);
            LimparCampos();
            
            salvarEditar = "novo";
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
           

        }
        private void boxCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }
        private void boxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void boxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46 && e.KeyChar != (char)47 && e.KeyChar != (char)8 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }

        }
        private void boxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)40 && e.KeyChar != (char)41 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }

        private void boxNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            Localizar();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown_1(object sender, MouseEventArgs e)
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
    }
}
