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
    class ComandosProdutos
    {
        public bool tem;
        public String menssagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public String Cadastrar ( String nome,String descricao,double valor, int quantidade, int Categoria)
        {
            tem = false;
           cmd.CommandText = "insert into Cad_Produtos (Nome_Produto,Descricao_Produto,Valor_Produto,quantidade_sabor,codigo_Categoria)" +
                "values (@nome,@ds,@valor,@quantidade,@categoria); select @@IDENTITY";
          
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@ds", descricao);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@categoria", Categoria);
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
        public void Alterar (DadosProdutos dadosProdutos)
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "update Cad_Produtos set Nome_Produto=@nome,Descricao_Produto=@ds,Valor_Produto=@valor,quantidade_sabor=@quantidade where Codigo_Produto=@codigo";
            cmd.Parameters.AddWithValue("@codigo", dadosProdutos.Codigo);
            cmd.Parameters.AddWithValue("@ds", dadosProdutos.Descricao);
            cmd.Parameters.AddWithValue("@nome", dadosProdutos.Nome);
            cmd.Parameters.AddWithValue("@valor", dadosProdutos.Valor);
            cmd.Parameters.AddWithValue("@quantidade", dadosProdutos.Quantidade);
            cmd.ExecuteNonQuery();
            con.desconectar();
            this.menssagem = "Editado com Sucesso !!";
        }
        public void Excluir (int codigo)
        {
            cmd.CommandText = "delete from Cad_Produtos where  Codigo_Produto=@codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public DadosProdutos Carregar (int valor )
        {
            DadosProdutos dados = new DadosProdutos();
            cmd.Connection = con.Conectar();
            cmd.CommandText = "select * from Cad_Produtos where Codigo_Produto =" + valor.ToString();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                dados.Codigo = Convert.ToInt32(registro["Codigo_Produto"]);
                dados.Nome= Convert.ToString(registro["Nome_Produto"]);
                dados.Descricao = Convert.ToString(registro["Descricao_Produto"]);
                dados.Valor = Convert.ToDouble(registro["Valor_Produto"]);
                dados.Quantidade = Convert.ToInt32(registro["quantidade_sabor"]);
                dados.Categoria = Convert.ToInt32(registro["codigo_Categoria"]);
            }
            con.desconectar();
            return dados;
        }
        public DataTable LocalizarDescricao (String valor)
        { 
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cad_Produtos where Nome_Produto like '%" + valor + "%'",con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }
        public DataTable LocalizarCategoria(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cad_Produtos where codigo_Categoria like '%" + valor + "%'", con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }
    }
}
