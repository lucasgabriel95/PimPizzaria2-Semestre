﻿using PizzariaPim.DAL;
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

    public partial class ConfigUser : Form
    {
        public int codigo;
        public int teste;
        public string alteraBotoes;
        public string salvarEditar;
        public ConfigUser()
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
            boxLogin.Clear();
            boxSenha.Clear();
            boxConfirmarSenha.Clear();
        }
        public void AlteraBotoes (int op)
        {            

            if (op == 1)
            {
                boxCPF.Enabled = true;
               
                boxTelefone.Enabled = true;
                cbCargo.Enabled = true;
                cbUnidade.Enabled = true;
                boxCEP.Enabled = true;
                boxLogadouro.Enabled = true;
                boxNumero.Enabled = true;
                boxBairro.Enabled = true;
                boxComplemento.Enabled = true;
                boxLogin.Enabled = true;
                boxSenha.Enabled = true;
                boxConfirmarSenha.Enabled = true;
            }
            if (op == 2)
            {
                boxCPF.Enabled = false;
              
                boxTelefone.Enabled = false;
                cbCargo.Enabled = false;
                cbUnidade.Enabled = false;
                boxCEP.Enabled = false;
                boxLogadouro.Enabled = false;
                boxNumero.Enabled = false;
                boxBairro.Enabled = false;
                boxComplemento.Enabled = false;
                boxLogin.Enabled = false;
                boxSenha.Enabled = false;
                boxConfirmarSenha.Enabled = false;
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void Localizar ()
        {
            ComandoFuncionario cf = new ComandoFuncionario();
            dgGride.DataSource = cf.localizarFuncionario(boxNomeCompleto.Text);
        }
        private void boxCPF_TextChanged(object sender, EventArgs e)
        {
            Localizar();
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
            
            ComandoFuncionario cf = new ComandoFuncionario();
            DadosFuncionario dadosFuncionario = cf.carregarFuncionario(codigo);
            boxCodigo.Text = dadosFuncionario.codigo.ToString();
            boxCPF.Text = dadosFuncionario.cpf;
            boxNomeCompleto.Text = dadosFuncionario.nome;
            boxTelefone.Text = dadosFuncionario.telefone;
            cbCargo.Text = dadosFuncionario.cargo;
            cbUnidade.Text = dadosFuncionario.unidade;
            boxCEP.Text = dadosFuncionario.cep;
            boxLogadouro.Text = dadosFuncionario.logradouro;
            boxNumero.Text = dadosFuncionario.numero;
            boxBairro.Text = dadosFuncionario.bairro;
            boxComplemento.Text = dadosFuncionario.complemento;
            boxLogin.Text = dadosFuncionario.login;
            boxSenha.Text = dadosFuncionario.senha;            
            AlteraBotoes(1);
            alteraBotoes = "view";
            salvarEditar = "Alterar";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult mensagem;

            if (alteraBotoes == "incluir")
            {                
                mensagem = MessageBox.Show("Deseja Cancelar o cadastro ?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question);                

                if (mensagem.ToString() == "Yes")
                {
                    AlteraBotoes(2);
                    alteraBotoes = "";
                    LimparCampos();
                }               
            }
            else if (alteraBotoes == "view")            
            {
                AlteraBotoes(2);
                LimparCampos();
                alteraBotoes = "";
            }
            else
            {
                ConfigUser cu = new ConfigUser();
                this.Close();
            }            
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            if (boxCPF.Text != "" && boxNomeCompleto.Text !="" && boxTelefone.Text != ""&& cbCargo.Text!=""&& cbUnidade.Text!= ""&& boxCEP.Text!="" && boxLogadouro.Text!=""&& boxNumero.Text!=""&& boxBairro.Text!="" && boxComplemento.Text!=""&& boxLogin.Text!=""&& boxSenha.Text!="")
            {
                if(boxSenha.Text == boxConfirmarSenha.Text)
                {
                    DialogResult mensagemConfirmacao;

                    if (salvarEditar == "novo")
                    {
                        mensagemConfirmacao = MessageBox.Show("Deseja Cadastrar Funcionario ?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    }
                    else
                    {
                        mensagemConfirmacao = MessageBox.Show("Deseja Alterar Funcionario ?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    }
                    if (mensagemConfirmacao.ToString() == "Yes")
                    {

                        if (this.salvarEditar == "novo")
                        {
                            ControleFuncionario controle = new ControleFuncionario();
                            string mensagem = controle.cadastrarFuncionario(boxCPF.Text, boxNomeCompleto.Text, boxTelefone.Text,
                                cbCargo.Text, cbUnidade.Text, boxCEP.Text, boxLogadouro.Text, boxNumero.Text, boxBairro.Text,
                                boxComplemento.Text, boxLogin.Text, boxSenha.Text);
                            if (controle.tem)
                            {
                                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(controle.mensagem);// messagem de erro. 
                            }
                            AlteraBotoes(2);
                            LimparCampos();
                            alteraBotoes = "";
                        }
                        else
                        {
                            DadosFuncionario dadosFuncionario = new DadosFuncionario();
                            dadosFuncionario.cpf = boxCPF.Text;
                            dadosFuncionario.nome = boxNomeCompleto.Text;
                            dadosFuncionario.telefone = boxTelefone.Text;
                            dadosFuncionario.cargo = cbCargo.Text;
                            dadosFuncionario.unidade = cbUnidade.Text;
                            dadosFuncionario.cep = boxCEP.Text;
                            dadosFuncionario.logradouro = boxLogadouro.Text;
                            dadosFuncionario.numero = boxNumero.Text;
                            dadosFuncionario.bairro = boxBairro.Text;
                            dadosFuncionario.complemento = boxComplemento.Text;
                            dadosFuncionario.login = boxLogin.Text;
                            dadosFuncionario.senha = boxSenha.Text;

                            dadosFuncionario.codigo = Convert.ToInt32(boxCodigo.Text);

                            ComandoFuncionario comandoFuncionario = new ComandoFuncionario();
                            comandoFuncionario.Alterar(dadosFuncionario);
                            LimparCampos();
                            AlteraBotoes(2);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Senha não são iguais", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }               
            }
            else
            {
                MessageBox.Show("Oscampos não podem ficar em branco!!", "Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ConfigUser_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            AlteraBotoes(1);
            alteraBotoes = "incluir";
            salvarEditar = "novo";
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult mensagemConfirmacao;

            mensagemConfirmacao = MessageBox.Show("Deseja Excluir Funcionario ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensagemConfirmacao.ToString() == "Yes")
            {
                ControleFuncionario controle = new ControleFuncionario();
                controle.Excluir(codigo);
                MessageBox.Show("Cadastro Excluido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlteraBotoes(2);
                LimparCampos();
                Localizar();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void boxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void boxCPF_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void boxNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            Localizar();
        }
    }
}
