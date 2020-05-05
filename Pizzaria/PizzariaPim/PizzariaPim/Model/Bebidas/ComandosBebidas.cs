using PizzariaPim.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Model.Bebidas
{
    class ComandosBebidas
    {
        public bool tem;
        public String menssagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public String CadastrarBebidas ( String descricao,String tipo,int quantidade,double valor)
        {
            tem = false;
           cmd.CommandText = "insert into Cad_Bebidas (descricao_Bebidas,tipo_bebida,quantidade_Bebidas,valor_Bebidas)" +
                "values (@descricao,@tipo,@quantidade,@valor); select @@IDENTITY";
           // cmd.Parameters.AddWithValue("@codigo",codigo);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@valor", valor);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.menssagem = "Cadastro com sucesso !!";
                tem = true;
            }
            catch (SqlException)
            {
                this.menssagem ="Erro com banco de dados";
            }
            return menssagem;
        }
        public void AlterarBebidas (DadosBebidas dadosBebidas)
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "update Cad_Bebidas set descricao_Bebidas=@descricao,tipo_Bebida=@tipo,quantidade_Bebidas=@quantidade,valor_Bebidas=@valor where codigo_Bebidas=@codigo";
            cmd.Parameters.AddWithValue("@codigo",dadosBebidas.codigo);
            cmd.Parameters.AddWithValue("@descricao",dadosBebidas.descricao);
            cmd.Parameters.AddWithValue("@tipo",dadosBebidas.tipo);
            cmd.Parameters.AddWithValue("@quantidade",dadosBebidas.quantidade);
            cmd.Parameters.AddWithValue("@valor",dadosBebidas.valor);
            cmd.ExecuteNonQuery();
            con.desconectar();
            this.menssagem = "Editado com Sucesso !!";
        }
        public void Excluir (int codigo)
        {
            cmd.CommandText = "delete from Cad_Bebidas where codigo_Bebidas=@codigo";
            cmd.Parameters.AddWithValue("codigo", codigo);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public DadosBebidas CarregarBebida (int valor )
        {
            DadosBebidas dados = new DadosBebidas();
            cmd.Connection = con.Conectar();
            cmd.CommandText = "select * from Cad_Bebidas where codigo_Bebidas =" + valor.ToString();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                dados.codigo = Convert.ToInt32(registro["codigo_Bebidas"]);
                dados.descricao= Convert.ToString(registro["descricao_Bebidas"]);
                dados.tipo = Convert.ToString(registro["tipo_Bebida"]);
                dados.quantidade = Convert.ToInt32(registro["quantidade_Bebidas"]);
                dados.valor = Convert.ToDouble(registro["valor_Bebidas"]);
            }
            con.desconectar();
            return dados;
        }
        public DataTable LocalizarBebida (String valor)
        {
            
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cad_Bebidas where descricao_Bebidas like '%" + valor + "%'",con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }
    }
}
