using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim
{
   public class Conexao
   {
        SqlConnection con = new SqlConnection();
        public Conexao ()
        {
            con.ConnectionString = @"Data Source=DESKTOP-788MSMO;Initial Catalog=BDpizzaria;Integrated Security=True";
        }
        public SqlConnection Conectar ()
        {
           if(con.State == System.Data.ConnectionState.Closed)
           {
                con.Open();            
           }
          return con;
        }

        public void desconectar ()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
   }
}
