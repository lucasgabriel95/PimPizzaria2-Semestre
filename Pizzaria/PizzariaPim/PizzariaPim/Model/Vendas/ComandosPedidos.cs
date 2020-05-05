using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Model.Vendas
{
    class ComandosPedidos
    {
        DadosVendas dados = new DadosVendas();
       

        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        
        
        public DadosVendas GerarCodigoPedido()
        {
            DadosVendas dados = new DadosVendas();
            cmd.Connection = con.Conectar();
            cmd.CommandText = "select MAX(Cad_Vendas.codigo_Venda) as codigo_Venda FROM Cad_Vendas ";
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                vendaCodigo = Convert.ToInt32(registro["codigo_Venda"]);               
            }
            
            con.desconectar();
            return dados;
        }

        public DataTable LocalizarBebida(String valor)
        {

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cad_Bebidas where descricao_Bebidas like '%" + valor + "%'", con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }

      




        public int vendaCodigo;
        public int CodigoProduto;

    }
}
