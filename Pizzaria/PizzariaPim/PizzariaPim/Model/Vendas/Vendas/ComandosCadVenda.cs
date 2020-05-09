using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaPim.Model.Vendas.Vendas
{
    class ComandosCadVenda
    {  
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public int CodigoVenda ;
        public int codigoItem;
        

        public void  Inicializacao()
        {           
            cmd.Connection = con.Conectar();
            cmd.CommandText = "SELECT inicializar FROM inicializacao";           
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                CodigoVenda = Convert.ToInt32(registro["inicializar"]);
            }
            con.desconectar();
        }
        public void verificarCodigoVenda ()
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "SELECT  MAX(Cad_Venda.Codigo_Venda) AS MAIOR FROM Cad_Venda";
            SqlDataReader registro = cmd.ExecuteReader();
            

            if (registro.HasRows)
            {
                registro.Read();
                CodigoVenda = Convert.ToInt32(registro["MAIOR"]);
            }
            con.desconectar();
        }
        public void UpDateInicializacao ()
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "update inicializacao set inicializar = 2";
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                CodigoVenda = Convert.ToInt32(registro["inicializar"]);
            }

            con.desconectar();

        }
        public void IncluirClienteNull(int codigo)
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "INSERT INTO Cad_Venda VALUES(null,null,null,@codigo,null,null)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            SqlDataReader registro = cmd.ExecuteReader();
            registro.Read();
            con.desconectar();


        }
        public void ConsultarCodigoItem()
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "SELECT  MAX(Cad_Intens_Venda.Codigo_Item) AS MAIOR FROM Cad_Intens_Venda";
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                codigoItem = Convert.ToInt32(registro["MAIOR"]);
            }
            con.desconectar();
        }
        public void CadatrarItens(int CodigoProduto, int CodigoVenda, int Quantidade, double Valor)
        {

            cmd.CommandText = "INSERT INTO Cad_Intens_Venda (codigo_Produto,Codigo_Venda,Quantidade,Valor_Unitario) VALUES " +
                "(@CodigoProduto,@CodigoVenda,@Quantidade,@Valor);  select @@IDENTITY";
            cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);
            cmd.Parameters.AddWithValue("@CodigoVenda", CodigoVenda);
            cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@Valor", Valor);
            
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();

           
        }
      

        public void ExcluirIntens(int codigo)
        {
            cmd.CommandText = "delete from Cad_Intens_Venda where  Codigo_Item=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        
        public void Alterar(DadosCadVenda dados)
        {

            cmd.Connection = con.Conectar();
            cmd.CommandText = "update Cad_Venda set valor=@valor,Desconto=@desconto,Valor_pago=@pago,Codigo_Cliente=@cliente,Status_Venda=@status,data_Venda=@time where Codigo_Venda = @codigo ";
            cmd.Parameters.AddWithValue("@codigo", dados.Codigo);
            cmd.Parameters.AddWithValue("@valor", dados.Valor);
            cmd.Parameters.AddWithValue("@desconto", dados.Desconto);
            cmd.Parameters.AddWithValue("@pago", dados.ValorPago);
            cmd.Parameters.AddWithValue("@cliente", dados.CodigoCliente);
            cmd.Parameters.AddWithValue("@status", dados.Status);
            cmd.Parameters.AddWithValue("@time", dados.DataTime);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public void ExcluirVenda(int codigo)
        {
            cmd.CommandText = "delete from Cad_Venda where  Codigo_Venda=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();
        }

    } 
}
