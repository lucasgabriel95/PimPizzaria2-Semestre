﻿using System;
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
            con.ConnectionString = @"Data Source=bdpizzaria.cclb1vxbhmpa.sa-east-1.rds.amazonaws.com;Initial Catalog=BDpizzaria;Persist Security Info=True;User ID=admin;Password=19954567";
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
