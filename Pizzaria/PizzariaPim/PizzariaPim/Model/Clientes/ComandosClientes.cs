using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.DAL
{
    class ComandosClientes
    {
        public bool tem = false;
        public string mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public string cadastrar(string cpf_cnpj, string nome, string telefone, string cep, string logradouro, string numero, string bairro, string complemento)
        {
            tem = false;
            cmd.CommandText = "insert into Cad_Cliente (cpf_cnpj_Cliente,nome_Cliente,telefone_Cliente,cep_Cliente,logradouro_Cliente,numero_Cliente,bairro_Cliente,complemente_Cliente)values" +
                "(@cpf_cnpj,@nome,@telefone,@cep,@logradouro,@numero,@bairro,@complemento);select @@IDENTITY";
            cmd.Parameters.AddWithValue("@cpf_cnpj", cpf_cnpj);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);            
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@logradouro", logradouro);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@complemento", complemento);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cadastrado com sucesso";
                tem = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados";
            }
            return mensagem;
        }
        public void Alterar(DadosClientes dadosClientes)
        {
            cmd.Connection = con.Conectar();
            cmd.CommandText = "update Cad_Cliente set cpf_cnpj_Cliente=@cpf_cnpj,nome_Cliente=@nome,telefone_Cliente=@telefone," +
                "cep_Cliente=@cep,logradouro_Cliente=@logradouro,numero_Cliente=@numero,bairro_Cliente=@bairro,complemente_Cliente=@complemento where codigo_Cliente=@codigo";
            cmd.Parameters.AddWithValue("@codigo", dadosClientes.codigo);
            cmd.Parameters.AddWithValue("@cpf_cnpj", dadosClientes.cpf_cnpj);
            cmd.Parameters.AddWithValue("@nome", dadosClientes.nome);
            cmd.Parameters.AddWithValue("@telefone", dadosClientes.telefone);           
            cmd.Parameters.AddWithValue("@cep", dadosClientes.cep);
            cmd.Parameters.AddWithValue("@logradouro", dadosClientes.logradouro);
            cmd.Parameters.AddWithValue("@numero", dadosClientes.numero);
            cmd.Parameters.AddWithValue("@bairro", dadosClientes.bairro);
            cmd.Parameters.AddWithValue("@complemento", dadosClientes.complemento);
            cmd.ExecuteNonQuery();
            con.desconectar();
            this.mensagem = "Editado com Sucesso!";
        }
        public void Excluir(int codigo)
        {
            cmd.CommandText = "delete from Cad_Cliente where codigo_Cliente=@codigo ";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public DadosClientes carregar(int valor)
        {
            DadosClientes dados = new DadosClientes();
            cmd.Connection = con.Conectar();
            cmd.CommandText = "select * from Cad_Cliente where codigo_Cliente =" + valor.ToString();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                dados.codigo = Convert.ToInt32(registro["codigo_Cliente"]);
                dados.cpf_cnpj = Convert.ToString(registro["cpf_cnpj_Cliente"]);
                dados.nome = Convert.ToString(registro["nome_Cliente"]);
                dados.telefone = Convert.ToString(registro["telefone_Cliente"]);               
                dados.cep = Convert.ToString(registro["cep_Cliente"]);
                dados.logradouro = Convert.ToString(registro["logradouro_Cliente"]);
                dados.numero = Convert.ToString(registro["numero_Cliente"]);
                dados.bairro = Convert.ToString(registro["bairro_Cliente"]);
                dados.complemento = Convert.ToString(registro["complemente_Cliente"]);                
            }
            con.desconectar();
            return dados;
        }
        public DataTable localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cad_Cliente where nome_Cliente like '%" +
               valor + "%'", con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }
    }
}
