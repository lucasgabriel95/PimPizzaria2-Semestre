using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Model.Sabores
{
    class DadosSabores
    {
        public DadosSabores ()
        {
            this.codigo = 0;
            this.nome = "";
            this.Ingrediente = "";
            this.valorBroto = 0;
            this.valorInteiro = 0;
            this.quantidade = 0;
        }
        public DadosSabores(int codigo, String nome,String Ingrediente, double valorBroto, double valorInteiro, int quantidade)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.valorBroto = valorBroto;
            this.valorInteiro = valorInteiro;
            this.quantidade = quantidade;
            this.Ingrediente = Ingrediente;
        }
        public int codigo_Sabor;
        public int codigo { get {return this.codigo_Sabor ; } set { this.codigo_Sabor = value; } }
        public String nome_sabor;
        public String nome { get {return this.nome_sabor; } set {this.nome_sabor = value; } }
        public String Ingrediente_sabor;
        public String Ingrediente { get { return this.Ingrediente_sabor; } set { this.Ingrediente_sabor = value; } }
        public double valorBroto_Sabor;
        public double valorBroto { get {return valorBroto_Sabor; } set {this.valorBroto_Sabor = value; } }
        public double valorInteira_Sabor;
        public double valorInteiro { get {return this.valorInteira_Sabor; } set {this.valorInteira_Sabor = value; } }
        public int quantidade_Sabor;
        public int quantidade { get {return this.quantidade_Sabor; } set { quantidade_Sabor = value; ; } }
    }
}
