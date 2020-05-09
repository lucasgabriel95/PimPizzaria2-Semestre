using PizzariaPim.DAL;
using PizzariaPim.Model.Bebidas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Control
{
    class ControleClientes
    {
        public String menssage;
       
        public String Cadastrar(string cpf_cnpj, string nome, string telefone, string cep, string logradouro, string numero, string bairro, string complemento)
        {
            ComandosClientes comandos = new ComandosClientes();
            comandos.cadastrar(cpf_cnpj,nome,telefone,cep,logradouro,numero,bairro,complemento);
            return menssage;
        }
        public void Alterar(DadosClientes dadosClientes)
        {
            ComandosClientes comandos = new ComandosClientes();
            comandos.Alterar(dadosClientes);
        }
        public void Excluir(int codigo)
        {
            ComandosClientes comandos = new ComandosClientes();
            comandos.Excluir(codigo);
        }
        public void Localizar(String valor)
        {
            ComandosClientes comandos = new ComandosClientes();
            comandos.localizar(valor);

        }
    }
}
