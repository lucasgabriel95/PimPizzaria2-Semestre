using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Model.Bebidas
{
    class DadosProdutos
    {
       public DadosProdutos()
       {
            this.Codigo = 0;
            this.Nome = "";
            this.Descricao = "";
            this.Valor = 0;
            this.Quantidade = 0;
            this.Categoria = 0;
        }
        public DadosProdutos(int codigo,String nome,String descricao,int Categoria, int quantidade,double valor)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Valor = valor;
            this.Quantidade = quantidade;
            this.Categoria = Categoria;          
            
        }
        int codigo_Bebidas;
        public int Codigo { get {return this.codigo_Bebidas; } set {this.codigo_Bebidas = value; } }
        String nome_Produto;
        public String Nome { get {return this.nome_Produto; } set {this.nome_Produto = value; } }
        String descricao_Bebidas;
        public String Descricao { get { return this.descricao_Bebidas; } set { this.descricao_Bebidas = value; } }
        int Categoria_Produtos;
        public int Categoria { get {return this.Categoria_Produtos; } set {this.Categoria_Produtos = value; } }
        int quanitade_Bebidas;
        public int Quantidade { get { return this.quanitade_Bebidas; } set {this.quanitade_Bebidas = value; } }
        Double valor_Bebidas;
        public Double Valor { get {return this.valor_Bebidas; } set {this.valor_Bebidas = value; } }





    }
}
