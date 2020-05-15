using PizzariaPim.Model.Vendas.Vendas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Model.Pedidos
{
    class ComandosElogioReclamacoes
    {

        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public String CodigoVenda;
        public String valor;
        public String DataMaxima;
        DadosCadVenda dados = new DadosCadVenda();
        

        public void ConsultaUmtimaCompraCliente(int codigo)
        {
            
            cmd.Connection = con.Conectar();
            cmd.CommandText = "select MAX(Cad_Venda.data_Venda) datamaxima from Cad_Venda WHERE Cad_Venda.Codigo_Cliente = '" + codigo.ToString() + "'";
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                DataMaxima = Convert.ToString(registro["datamaxima"]);
               
            }
            con.desconectar();

            ///////////////////////////////////////////////////////////////////////////
            cmd.Connection = con.Conectar();
            cmd.CommandText = "select MAX(Cad_Venda.Codigo_Venda)CodigoVenda from Cad_Venda WHERE Cad_Venda.Codigo_Cliente = '"+codigo.ToString() + "'";
            registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
               
                CodigoVenda = Convert.ToString(registro["CodigoVenda"]);
                
            }
            con.desconectar();


            cmd.Connection = con.Conectar();
            cmd.CommandText = "select Cad_Venda.Valor_pago Valor from Cad_Venda WHERE Cad_Venda.Codigo_Venda =  '"+CodigoVenda+"'";
            registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();

                valor = Convert.ToString(registro["Valor"]);

            }
            con.desconectar();

        }
        public void Alterar(String codigo, String dados)
        {

            cmd.Connection = con.Conectar();
            cmd.CommandText = "update Cad_Venda set ElogioRlecamacao_Venda=@ElogioRlecamacao where Codigo_Venda = @codigo ";

            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@ElogioRlecamacao", dados);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
    }
    
}
