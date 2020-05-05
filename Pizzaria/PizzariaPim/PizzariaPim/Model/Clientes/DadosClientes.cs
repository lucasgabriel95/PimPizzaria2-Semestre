using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.DAL
{
    class DadosClientes
    {
        public DadosClientes()
        {
            this.codigo = 0;
            this.cpf_cnpj_cliente = "";
            this.nome = "";
            this.telefone = "";           
            this.cep = "";
            this.logradouro = "";
            this.numero = "";
            this.bairro = "";
            this.complemento = "";
          

        }

        public DadosClientes(int codigo, string cpf_cnpj, string nome, string telefone,string cep, string logradouro, string numero, string bairro, string complemento)
        {
            this.codigo = codigo;
            this.cpf_cnpj_cliente = cpf_cnpj;
            this.nome = nome;
            this.telefone = telefone;           
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;          

        }
        int codigo_cliente;
        public int codigo
        {
            get
            {
                return this.codigo_cliente;
            }
            set
            {
                this.codigo_cliente = value;
            }
        }
        string cpf_cnpj_cliente;
        public string cpf_cnpj
        {
            get
            {
                return this.cpf_cnpj_cliente;
            }
            set
            {
                this.cpf_cnpj_cliente = value;
            }
        }
        string nome_cliente;
        public string nome
        {
            get
            {
                return this.nome_cliente;
            }
            set
            {
                this.nome_cliente = value;
            }
        }
        string telefone_cliente;
        public string telefone
        {
            get
            {
                return this.telefone_cliente;
            }
            set
            {
                this.telefone_cliente = value;
            }
        }       
        public string cep_cliente;
        public string cep
        {
            get
            {
                return this.cep_cliente;
            }
            set
            {
                this.cep_cliente = value;
            }
        }
        public string logradouro_cliente;
        public string logradouro
        {
            get
            {
                return this.logradouro_cliente;
            }
            set
            {
                this.logradouro_cliente = value;
            }
        }
        public string numero_cliente;
        public string numero
        {
            get
            {
                return this.numero_cliente;
            }
            set
            {
                this.numero_cliente = value;
            }
        }
        public string bairro_cliente;
        public string bairro
        {
            get
            {
                return this.bairro_cliente;
            }
            set
            {
                this.bairro_cliente = value;
            }
        }
        public string complemente_cliente;
        public string complemento
        {
            get
            {
                return this.complemente_cliente;
            }
            set
            {
                this.complemente_cliente = value;
            }
        }
       

    }
}
