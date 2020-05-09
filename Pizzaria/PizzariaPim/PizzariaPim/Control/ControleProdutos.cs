using PizzariaPim.Model.Bebidas;
using PizzariaPim.Model.Vendas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Control
{
    class ControleProdutos
    {
        public bool tem;
        public String menssage;
        public String Cadastrar(String nome, String descricao, double valor, int quantidade, int Categoria)
        {
            ComandosProdutos comandos = new ComandosProdutos();
            comandos.Cadastrar(nome,descricao,valor,quantidade,Categoria);
            return menssage;
        }
        public void AlterarBebidas (DadosProdutos dadosProdutos) 
        {
            ComandosProdutos comandos = new ComandosProdutos();
            comandos.Alterar (dadosProdutos);
        }
        public void Excluir(int codigo)
        {
            ComandosProdutos comandos = new ComandosProdutos();
            comandos.Excluir(codigo);
        }
       
    }
} 
