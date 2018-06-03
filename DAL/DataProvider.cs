using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class DataProvider
    {
        private static string connStr = "server=localhost;user=root;database=quanlykaraoke;port=3306;password=1;Convert Zero Datetime=True";
        private static MySqlConnection conn;

        public static void InitalizeConnection()
        {
            if (conn != null)
                conn.Close();


            conn = new MySqlConnection(connStr);
        }

        public static void ExecuseNonQuery(string strQuery)
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(strQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataTable ExecuseQuery(string strQuery)
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(strQuery, conn);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            return dt;
            
        }

        public static MySqlConnection getConnection()
        {
            return conn;
        }
    }
}
