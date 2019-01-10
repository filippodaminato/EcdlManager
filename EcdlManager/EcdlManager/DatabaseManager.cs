using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EcdlManager
{
    public static class DatabaseManager
    {
        static MySqlConnection database;
        public static void connection(string credentials)
        {
            database = new MySqlConnection(credentials);
        }

        public static void disconnect()
        {
            database.Close();
        }

        public static void post(string query)
        {
            database.Open();
            MySqlCommand cmd = new MySqlCommand(query, database);
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Close();
      
        }

        public static DataSet get(string query)
        {
            database.Open();
            MySqlCommand cmd = new MySqlCommand(query, database);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adp.Fill(data);
            database.Close();
            return data;
        }
    }
}
