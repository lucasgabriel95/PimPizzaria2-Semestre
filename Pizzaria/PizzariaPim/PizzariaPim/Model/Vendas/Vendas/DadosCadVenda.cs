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
                this.CodigoCliente = 0;
                this.DataTime = "";
                this.Status = "";
            

            }

            public DadosCadVenda(int codigo, double valor, double desconto, double valorPago, int codigoPessoa,String Status,String DataTime)
            {
                this.Codigo = codigo;
                this.Valor = valor;
                this.Desconto = desconto;
                this.ValorPago = valorPago;
                this.CodigoCliente = codigoPessoa;
                this.DataTime = DataTime;
                this.Status = Status;

        }
            int codigo_Bebidas;
            public int Codigo { get { return this.codigo_Bebidas; } set { this.codigo_Bebidas = value; } }           
            double valor_Bebidas;
            public double Valor { get { return this.valor_Bebidas; } set { this.valor_Bebidas = value; } }
            double valor_Desconto;
            public double Desconto { get { return this.valor_Desconto; } set { this.valor_Desconto = value; } }
            double Valor_Pago;
            public double ValorPago { get { return this.Valor_Pago; } set { this.Valor_Pago = value; } }
            int Codigo_Cliente;
            public int CodigoCliente { get { return this.Codigo_Cliente; } set { this.Codigo_Cliente = value; } }
            String Status_Venda;
            public String Status { get { return this.Status_Venda; } set { this.Status_Venda = value; } }
        String Data_Time;
            public String DataTime { get { return this.Data_Time; } set { this.Data_Time = value; } }

        }
    
}

