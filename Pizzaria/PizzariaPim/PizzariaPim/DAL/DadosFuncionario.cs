using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.DAL
{
    class DadosFuncionario
    {
        public DadosFuncionario()
        {
            this.codigo = 0;
            this.cpf = "";
            this.nome = "";
            this.telefone = "";
            this.cargo = "";
            this.unidade = "";
            this.cep = "";
            this.logradouro = "";
            this.numero="";
            this.bairro = "";
            this.complemento = "";
            this.login = "";
            this.senha = "";

        }       

        public DadosFuncionario (int codigo,string cpf, string nome, string telefone,
            string cargo, string unidade, string cep, string logradouro,
            string numero, string bairro, string complemento, string login, string senha)
        {
            this.codigo = codigo;
            this.cpf = cpf;
            this.nome = nome;
            this.telefone = telefone;
            this.cargo = cargo;
            this.unidade = unidade;
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.login = login;
            this.senha = senha;

        }
        int codigo_Funcionario;
        public int codigo
        {
            get
            {
                return this.codigo_Funcionario;
            }
            set
            {
                this.codigo_Funcionario = value;
            }
        }
        string cpf_Funcionario;
        public string cpf
        {
            get
            {
                return this.cpf_Funcionario;
            }
            set
            {
                this.cpf_Funcionario = value;
            }
        }
        string nome_Funcionario;
        public string nome
        {
            get
            {
                return this.nome_Funcionario;
            }
            set
            {
                this.nome_Funcionario = value;
            }
        }
        string telefone_Funcionario;
        public string telefone
        {
            get
            {
                return this.telefone_Funcionario;
            }
            set
            {
                this.telefone_Funcionario = value;
            }
        }
        public string cargo_Funcionario;
        public string cargo
        {
            get
            {
                return this.cargo_Funcionario;
            }
            set
            {
                this.cargo_Funcionario = value;
            }
        }
        public string unidade_Funcionario;
        public string unidade
        {
            get
            {
                return this.unidade_Funcionario;
            }
            set
            {
                this.unidade_Funcionario = value;
            }
        }
        public string cep_Funcionario;
        public string cep
        {
            get
            {
                return this.cep_Funcionario;
            }
            set
            {
                this.cep_Funcionario = value;
            }
        }
        public string logradouro_Funcionario;
        public string logradouro
        {
            get
            {
                return this.logradouro_Funcionario;
            }
            set
            {
                this.logradouro_Funcionario = value;
            }
        }
        public string numero_Funcionario;
        public string numero
        {
            get
            {
                return this.numero_Funcionario;
            }
            set
            {
                this.numero_Funcionario = value;
            }
        }
        public string bairro_Funcionario;
        public string bairro
        {
            get
            {
                return this.bairro_Funcionario;
            }
            set
            {
                this.bairro_Funcionario = value;
            }
        }
        public string complemente_Funcionario;
        public string complemento
        {
            get
            {
                return this.complemente_Funcionario;
            }
            set
            {
                this.complemente_Funcionario = value;
            }
        }
        public string login_Funcionario;
        public string login
        {
            get
            {
                return this.login_Funcionario;
            }
            set
            {
                this.login_Funcionario = value;
            }
        }
        public string senha_Funcionario;
        public string senha
        {
            get
            {
                return this.senha_Funcionario;
            }
            set
            {
                this.senha_Funcionario = value;
            }
        }


    }
}
