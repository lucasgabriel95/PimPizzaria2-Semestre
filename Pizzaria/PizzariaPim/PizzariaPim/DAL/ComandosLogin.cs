using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.DAL
{
    class ComandosLogin
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin (String login  ,String senha)
        {
            cmd.CommandText = "select * from Cad_Funcionario where login_Funcionario = @login and senha_Funcionario = @senha";
            cmd.Parameters.AddWithValue("@login",login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true; 
                }
                con.desconectar();
                dr.Close();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro no Banco de Dados";
            }
            return tem;
        }
    }
}
