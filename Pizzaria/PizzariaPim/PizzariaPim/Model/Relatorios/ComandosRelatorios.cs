using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Model.Relatorios
{
    class ComandosRelatorios
    {
         SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public String Quantidade;
        public int QuantidadeVenda;
        public String valor;
        public DataTable Localizar(String Data1,String Data2,String Categoria, String Categoria2)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Cad_Venda.Codigo_Venda, Cad_Venda.valor, Cad_Venda.Desconto, Cad_Venda.Valor_pago, Cad_Venda.Codigo_Cliente, Cad_Cliente.nome_Cliente, Cad_Venda.Status_Venda, Cad_Venda.data_Venda, Cad_Venda.ElogioRlecamacao_Venda, Cad_Venda.Obs_Venda "+
                "FROM  Cad_Cliente INNER JOIN Cad_Venda ON Cad_Cliente.codigo_Cliente = Cad_Venda.Codigo_Cliente where Cad_Venda.data_Venda between  '"+ Data1 + "' and '"+ Data2 + "' and Cad_Venda.Status_Venda like '%"+ Categoria + "%' and Cad_Venda.ElogioRlecamacao_Venda like '%"+ Categoria2 + "%'", con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }

        public DataTable LocalizarIntens(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Cad_Intens_Venda.codigo_Produto, Cad_Produtos.Nome_Produto, Cad_Intens_Venda.Quantidade, Cad_Intens_Venda.Valor_Unitario, Cad_Intens_Venda.Codigo_Venda FROM Cad_Intens_Venda INNER JOIN Cad_Produtos ON Cad_Intens_Venda.codigo_Produto = Cad_Produtos.Codigo_Produto where Cad_Intens_Venda.Codigo_Venda =" + valor+"", con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }

        public void QuantidadeValor(String Data1, String Data2, String Categoria)
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "SELECT SUM ( Cad_Intens_Venda.Quantidade) AS QUANTIDADE ,SUM (Cad_Intens_Venda.Quantidade * Cad_Intens_Venda.Valor_Unitario) AS TOTAL FROM Cad_Intens_Venda INNER JOIN Cad_Venda ON Cad_Intens_Venda.Codigo_Venda = Cad_Venda.Codigo_Venda where Cad_Venda.data_Venda between  '"+Data1+"' and '"+Data2+"' and Cad_Venda.Status_Venda like '%"+Categoria+"%'";
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                Quantidade = Convert.ToString(registro["QUANTIDADE"]);
                valor = Convert.ToString(registro["TOTAL"]);
            }
            con.desconectar();
        }

        public void QuantidadeVendas(String Data1, String Data2, String Categoria)
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "SELECT COUNT ( *) linhas FROM Cad_Venda where Cad_Venda.data_Venda between  '" + Data1 + "' and '" + Data2 + "' and Cad_Venda.Status_Venda like '%" + Categoria + "%'";
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                QuantidadeVenda = Convert.ToInt32(registro["linhas"]);
            }
            con.desconectar();
        }
       
    }
}
