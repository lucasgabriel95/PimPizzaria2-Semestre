using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Model.Sabores
{
    class ComandosSabores
    { 
        public String menssagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public String cadastrar (String nome,String ingredientes,double valorBroto, double ValorInteira,int quantidade)
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "insert into Cad_Sabor (nome_Sabor,ingrediente_sabor,valor_Broto_Sabor,valor_Inteira_Sabor,quantidade_sabor)" +
                "values (@nome,@ingrediente,@valorBroto,@valorInteira,@quantidade); select @@IDENTITY";
            
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@ingrediente", ingredientes);
            cmd.Parameters.AddWithValue("@valorBroto", valorBroto);
            cmd.Parameters.AddWithValue("@valorInteira", ValorInteira);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.menssagem = "Cadastrado Com sucesso"; 
            }
            catch (SqlException)
            {
                this.menssagem = "Erro com banco de dados";
            }   
            return menssagem;
        }
        public void Alterar (DadosSabores dados)
        {
            cmd.CommandText = "Update Cad_Sabor set nome_Sabor=@nome,ingrediente_sabor=@ingrediente,valor_Broto_Sabor=@valorBroto,valor_Inteira_Sabor=@valorInteira,quantidade_sabor=@quantidade where codigo_Sabor=@codigo ";
            cmd.Connection = con.Conectar();
            cmd.Parameters.AddWithValue("@codigo", dados.codigo);
            cmd.Parameters.AddWithValue("@nome", dados.nome);
            cmd.Parameters.AddWithValue("@ingrediente",dados.Ingrediente);
            cmd.Parameters.AddWithValue("@valorBroto", dados.valorBroto);
            cmd.Parameters.AddWithValue("@valorInteira", dados.valorInteira_Sabor);
            cmd.Parameters.AddWithValue("@quantidade", dados.quantidade);
            cmd.ExecuteNonQuery();
            con.desconectar();            
        }
        public void Excluir (int codigo)
        {
            cmd.CommandText = "delete from Cad_Sabor where codigo_Sabor=@codigo ";
            cmd.Parameters.AddWithValue("codigo", codigo);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public DadosSabores carregar (int valor )
        {
            DadosSabores dados = new DadosSabores();
            cmd.Connection = con.Conectar();
            cmd.CommandText = "select * from Cad_Sabor where codigo_Sabor ="+ valor.ToString();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                dados.codigo = Convert.ToInt32(registro["codigo_Sabor"]);
                dados.nome = Convert.ToString(registro["nome_Sabor"]);
                dados.Ingrediente = Convert.ToString(registro["ingrediente_sabor"]);
                dados.quantidade = Convert.ToInt32(registro["quantidade_sabor"]);
                dados.valorBroto = Convert.ToInt32(registro["valor_Broto_Sabor"]);
                dados.valorInteiro = Convert.ToInt32(registro["valor_Inteira_Sabor"]);
            }
            con.desconectar();
            return dados;
        }
        public DataTable localizar (String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select codigo_Sabor AS 'CODIGO', nome_Sabor AS 'SABOR', ingrediente_sabor AS 'INGREDIENTES',valor_Broto_Sabor AS 'VALOR BROOTO',valor_Inteira_Sabor AS 'VALOR GRANDE', quantidade_sabor AS 'QUANTIDADE' from Cad_Sabor  where nome_Sabor like '%" +
                valor + "%'", con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }
    }
}
