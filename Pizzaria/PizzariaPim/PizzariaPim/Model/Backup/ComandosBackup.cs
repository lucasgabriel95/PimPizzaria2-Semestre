using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaPim.Model.Backup
{
    class ComandosBackup
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public void Backup (String Local)
        {
            cmd.CommandText = "BACKUP DATABASE TO DISK + '"+Local+"\\BDpizzaria -"+DateTime.Now.Ticks.ToString()+".bak'";
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
