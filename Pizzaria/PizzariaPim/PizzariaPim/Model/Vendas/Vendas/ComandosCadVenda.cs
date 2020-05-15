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
        public String DataMaxima;
        public String CodigoVendaFinalizada;
        

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
            cmd.CommandText = "INSERT INTO Cad_Venda VALUES(null,null,null,@codigo,null,null, null,null)";
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
            cmd.CommandText = "update Cad_Venda set valor=@valor,Desconto=@desconto,Valor_pago=@pago,Codigo_Cliente=@cliente,Status_Venda=@status,Obs_Venda=@obs,ElogioRlecamacao_Venda=@ElogioRlecamacao,data_Venda=@time where Codigo_Venda = @codigo ";
            cmd.Parameters.AddWithValue("@codigo", dados.Codigo);
            cmd.Parameters.AddWithValue("@valor", dados.Valor);
            cmd.Parameters.AddWithValue("@desconto", dados.Desconto);
            cmd.Parameters.AddWithValue("@pago", dados.ValorPago);
            cmd.Parameters.AddWithValue("@cliente", dados.CodigoCliente);
            cmd.Parameters.AddWithValue("@status", dados.Status);
            cmd.Parameters.AddWithValue("@obs", dados.obs);
            cmd.Parameters.AddWithValue("@ElogioRlecamacao", dados.ElogioReclamacao);
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
        public DataTable LocalizarCategoriaInneJoin(String Categoria)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Cad_Venda.Codigo_Venda, Cad_Venda.valor, Cad_Venda.Desconto, Cad_Venda.Valor_pago, Cad_Venda.Codigo_Cliente,Cad_Cliente.nome_Cliente, Cad_Venda.Status_Venda, Cad_Venda.data_Venda " +
                "FROM Cad_Venda INNER JOIN Cad_Cliente ON Cad_Venda.Codigo_Cliente = Cad_Cliente.codigo_Cliente where Cad_Venda.Status_Venda like '%" + Categoria + "%';", con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }

        public DataTable LocalizarNomeInneJoin(String Cliente,String Categoria)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Cad_Venda.Codigo_Venda, Cad_Venda.valor, Cad_Venda.Desconto, Cad_Venda.Valor_pago, Cad_Venda.Codigo_Cliente,Cad_Cliente.nome_Cliente, Cad_Venda.Status_Venda, Cad_Venda.data_Venda " +
                "FROM Cad_Venda INNER JOIN Cad_Cliente ON Cad_Venda.Codigo_Cliente = Cad_Cliente.codigo_Cliente where Cad_Cliente.nome_Cliente like '%" + Cliente + "%' and  Cad_Venda.Status_Venda like '%" + Categoria + "%'", con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }
        public DadosCadVenda Carregar(int valor)
        {
            DadosCadVenda dados = new DadosCadVenda();
            cmd.Connection = con.Conectar();
            cmd.CommandText = "select * from Cad_Venda where Codigo_Venda =" + valor.ToString();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                dados.Codigo = Convert.ToInt32(registro["Codigo_Venda"]);
                dados.Valor = Convert.ToDouble(registro["valor"]);
                dados.Desconto = Convert.ToDouble(registro["Desconto"]);
                dados.ValorPago = Convert.ToDouble(registro["Valor_pago"]);
                dados.CodigoCliente = Convert.ToInt32(registro["Codigo_Cliente"]);
                dados.Status = Convert.ToString(registro["Status_Venda"]);
                dados.obs = Convert.ToString(registro["Obs_Venda"]);
                dados.ElogioReclamacao = Convert.ToString(registro["ElogioRlecamacao_Venda"]);
                dados.DataTime = Convert.ToString(registro["data_Venda"]);
                
            }
            con.desconectar();
            return dados;
        }
        public void UpdateCategoria (int CodigoVenda, String Status)
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "update Cad_Venda set Status_Venda = @status where Codigo_Venda = @codigo";
            cmd.Parameters.AddWithValue("@codigo", CodigoVenda);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        
    } 
}
