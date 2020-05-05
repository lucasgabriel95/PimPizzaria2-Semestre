using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Model.Bebidas
{
    class DadosBebidas
    {
       public  DadosBebidas ()
       {
            this.codigo = 0;
            this.descricao = "";
            this.tipo = "";
            this.quantidade = 0;
            this.valor = 0;
       }
        public DadosBebidas (int codigo,String descricao,String tipo,int quantidade,float valor)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.tipo = tipo;
            this.quantidade = quantidade;
            this.valor = valor;
        }
        int codigo_Bebidas;
        public int codigo { get {return this.codigo_Bebidas; } set {this.codigo_Bebidas = value; } }
        String descricao_Bebidas;
        public String descricao { get {return this.descricao_Bebidas; } set {this.descricao_Bebidas = value; } }
        String tipo_Bebidas;
        public String tipo { get {return this.tipo_Bebidas; } set {this.tipo_Bebidas = value; } }
        int quanitade_Bebidas;
        public int quantidade { get { return this.quanitade_Bebidas; } set {this.quanitade_Bebidas = value; } }
        Double valor_Bebidas;
        public Double valor { get {return this.valor_Bebidas; } set {this.valor_Bebidas = value; } }





    }
}
