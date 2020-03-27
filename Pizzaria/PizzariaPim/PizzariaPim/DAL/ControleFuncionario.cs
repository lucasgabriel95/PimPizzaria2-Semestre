using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.DAL
{
    public class ControleFuncionario
    {
        public bool tem;
        public String mensagem = "";
        
        public bool acessar(String login, String senha)
        {
            ComandosLogin comandos = new ComandosLogin();
            tem = comandos.verificarLogin(login, senha);
            if (!comandos.mensagem.Equals(""))
            {
                this.mensagem = comandos.mensagem;
            }
            return tem;
        }
        public string cadastrarFuncionario(string cpf, string nome, string telefone,
            string cargo, string unidadade, string cep, string logradouro,
            string numero, string bairro, string complemento, string login, string senha)
        {
            ComandoFuncionario comandos = new ComandoFuncionario();
            this.mensagem = comandos.cadastrarFuncionario(cpf, nome, telefone, cargo, unidadade, cep, logradouro,
                numero, bairro, complemento, login, senha);
            if (comandos.tem)
            {
                this.tem = true;
            }


            return mensagem;
        }

        public void Excluir(int codigo)
        {
            ComandoFuncionario cf = new ComandoFuncionario();
            cf.Excluir(codigo);

        }
       /* public void Alterar(int alterar)
        {            
            DadosFuncionario df = new DadosFuncionario();
            df.codigo = alterar;
            ComandoFuncionario cf = new ComandoFuncionario();
            
            cf.Alterar(df);
        }
        */


    }
}
