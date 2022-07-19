using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter.Helpers
{
    public static class DatabaseLayer
    {
        private static MySqlConnection Db;
        public static MySqlConnection getDefaultConnection()
        {
            if (Db==null)
            {
                MySqlConnection con = new MySqlConnection("datasource= localhost; database=signal_encrypt;port=3306; username = root; password=Cavista@N"); //open connection
                con.Open();
                Db = con;
            }

            return Db;
        }


        public static MySqlDataReader QueryDB(string query)
        {
            var dbCon = getDefaultConnection();
            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
          
        }
    }
}
