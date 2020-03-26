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
    public partial class ConfigUser : Form
    {
        public int codigo;
        public int teste;
        public ConfigUser()
        {
            InitializeComponent();
            AlteraBotoes(2); 
        }   
        
        public void AlteraBotoes (int op)
        {            

            if (op == 1)
            {
                boxCPF.Enabled = true;
                boxNomeCompleto.Enabled = true;
                boxTelefone.Enabled = true;
                boxCargo.Enabled = true;
                boxUnidade.Enabled = true;
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
                boxNomeCompleto.Enabled = false;
                boxTelefone.Enabled = false;
                boxCargo.Enabled = false;
                boxUnidade.Enabled = false;
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
        private void boxCPF_TextChanged(object sender, EventArgs e)
        {           
            ComandoFuncionario cf = new ComandoFuncionario();
            dgGride.DataSource = cf.localizarFuncionario(boxCPF.Text);
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
            Conexao cx = new Conexao();
            ComandoFuncionario cf = new ComandoFuncionario();
            DadosFuncionario dadosFuncionario = cf.carregarFuncionario(codigo);
            boxCPF.Text = dadosFuncionario.cpf.ToString();
            boxNomeCompleto.Text = dadosFuncionario.nome;
            boxTelefone.Text = dadosFuncionario.telefone;
            boxCargo.Text = dadosFuncionario.cargo;
            boxUnidade.Text = dadosFuncionario.unidade;
            boxCEP.Text = dadosFuncionario.cep;
            boxLogadouro.Text = dadosFuncionario.logradouro;
            boxNumero.Text = dadosFuncionario.numero;
            boxBairro.Text = dadosFuncionario.bairro;
            boxComplemento.Text = dadosFuncionario.complemento;
            boxLogin.Text = dadosFuncionario.login;
            boxSenha.Text = dadosFuncionario.senha;            
            AlteraBotoes(1);          
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            ConfigUser cu = new ConfigUser();
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            ControleFuncionario controle = new ControleFuncionario();
            string mensagem = controle.cadastrarFuncionario(boxCPF.Text, boxNomeCompleto.Text, boxTelefone.Text,
                boxCargo.Text, boxUnidade.Text, boxCEP.Text, boxLogadouro.Text, boxNumero.Text, boxBairro.Text,
                boxComplemento.Text, boxLogin.Text, boxSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);// messagem de erro. 
            }
        }

        private void ConfigUser_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDpizzariaDataSet.Cad_Funcionario'. Você pode movê-la ou removê-la conforme necessário.
          //  this.cad_FuncionarioTableAdapter.Fill(this.bDpizzariaDataSet.Cad_Funcionario);

        }
    }
}
