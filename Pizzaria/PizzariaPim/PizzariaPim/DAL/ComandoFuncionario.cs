using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.DAL
{
    class ComandoFuncionario
    {
        public bool tem = false;
        public string mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public string cadastrarFuncionario(string cpf, string nome,string telefone, string cargo, string unidadade,string cep,string logradouro,string numero,string bairro,string complemento,string login,string senha)
        {
            tem = false;  
            cmd.CommandText = "insert into Cad_Funcionario (cpf_Funcionario,nome_Funcionario,telefone_Funcionario,cargo_Funcionario,unidade_Funcionario," +
                "cep_Funcionario,logradouro_Funcionario,numero_Funcionario,bairro_Funcionario,complemente_Funcionario,login_Funcionario,senha_Funcionario)values"+
                "(@cpf,@nome,@telefone,@cargo,@unidade,@cep,@logradouro,@numero,@bairro,@complemento,@login,@senha);select @@IDENTITY";
            cmd.Parameters.AddWithValue("@cpf",cpf);
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@telefone",telefone);
            cmd.Parameters.AddWithValue("@cargo",cargo);
            cmd.Parameters.AddWithValue("@unidade",unidadade);
            cmd.Parameters.AddWithValue("@cep",cep);
            cmd.Parameters.AddWithValue("@logradouro",logradouro);
            cmd.Parameters.AddWithValue("@numero",numero);
            cmd.Parameters.AddWithValue("@bairro",bairro);
            cmd.Parameters.AddWithValue("@complemento",complemento);
            cmd.Parameters.AddWithValue("@login",login);
            cmd.Parameters.AddWithValue("@senha",senha); 
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
        public DadosFuncionario carregarFuncionario(int valor)
        {
            DadosFuncionario dados = new DadosFuncionario();
            cmd.Connection = con.Conectar();
            cmd.CommandText = "select * from Cad_Funcionario where codigo_Funcionario =" + valor.ToString();          
            SqlDataReader registro = cmd.ExecuteReader();            
            if (registro.HasRows)
            {
                registro.Read();
                dados.codigo = Convert.ToInt32(registro["codigo_Funcionario"]);
                dados.cpf= Convert.ToString(registro["cpf_Funcionario"]);
                dados.nome= Convert.ToString(registro["nome_Funcionario"]);
                dados.telefone= Convert.ToString(registro["telefone_Funcionario"]);
                dados.cargo= Convert.ToString(registro["cargo_Funcionario"]);
                dados.unidade= Convert.ToString(registro["unidade_Funcionario"]);
                dados.cep= Convert.ToString(registro["cep_Funcionario"]);
                dados.logradouro= Convert.ToString(registro["logradouro_Funcionario"]);
                dados.numero= Convert.ToString(registro["numero_Funcionario"]);
                dados.bairro= Convert.ToString(registro["bairro_Funcionario"]);
                dados.complemento= Convert.ToString(registro["complemente_Funcionario"]);
                dados.login= Convert.ToString(registro["login_Funcionario"]);
                dados.senha= Convert.ToString(registro["senha_Funcionario"]);
            }
            con.desconectar();
            return dados;
        }
        public DataTable localizarFuncionario (String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cad_Funcionario where cpf_Funcionario like '%" +
               valor + "%'", con.Conectar());
            da.Fill(tabela);
            con.desconectar();
            return tabela;
        }


    }
}
