using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Model.Vendas.Vendas
{
        class DadosCadVenda
        {
            public DadosCadVenda()
            {
                this.Codigo = 0;
                this.Valor = 0;
                this.Desconto = 0;
                this.ValorPago = 0;
                this.Recebido = 0;
                this.Troco = 0;
                this.FormaPagamento = "";
                this.CodigoCliente = 0;
                this.Status = "";
                this.obs = "";
                this.ElogioReclamacao = "";
                this.DataTime = "";
                
            

            }

            public DadosCadVenda(int codigo, double valor, double desconto, double valorPago,double Recebido,double Troco,String FormaPagamento, int codigoPessoa,String Status,String obs ,String ElogioReclamacao, String DataTime)
            {
                this.Codigo = codigo;
                this.Valor = valor;
                this.Desconto = desconto;
                this.ValorPago = valorPago;
                this.Recebido = Recebido;
                this.Troco = Troco;
                this.FormaPagamento = FormaPagamento;
                this.CodigoCliente = codigoPessoa;
                this.Status = Status;
                this.obs = obs;
                this.ElogioReclamacao = ElogioReclamacao;
                this.DataTime = DataTime;
                

        }
            int codigo_Bebidas;
            public int Codigo { get { return this.codigo_Bebidas; } set { this.codigo_Bebidas = value; } }           
            double valor_Bebidas;
            public double Valor { get { return this.valor_Bebidas; } set { this.valor_Bebidas = value; } }
            double valor_Desconto;
            public double Desconto { get { return this.valor_Desconto; } set { this.valor_Desconto = value; } }
            double Valor_Pago;
            public double ValorPago { get { return this.Valor_Pago; } set { this.Valor_Pago = value; } }
            double Valor_Recebido;
            public double Recebido { get { return this.Valor_Recebido; } set { this.Valor_Recebido = value; } }
            double Troco_Valor;
            public double Troco { get { return this.Troco_Valor; } set { this.Troco_Valor = value; } }
            int Codigo_Cliente;
            String Forma_Pagamento;
            public String FormaPagamento { get { return this.Forma_Pagamento; } set { this.Forma_Pagamento = value; } }
            public int CodigoCliente { get { return this.Codigo_Cliente; } set { this.Codigo_Cliente = value; } }
            String Status_Venda;
            public String Status { get { return this.Status_Venda; } set { this.Status_Venda = value; } }
            String obs_Venda;
            public String obs { get { return this.obs_Venda; } set { this.obs_Venda = value; } }
            String ElogioReclamacao_VEnda;
            public String ElogioReclamacao { get { return this.ElogioReclamacao_VEnda; } set { this.ElogioReclamacao_VEnda = value; } }
        String Data_Time;
            public String DataTime { get { return this.Data_Time; } set { this.Data_Time = value; } }

        }
    
}

