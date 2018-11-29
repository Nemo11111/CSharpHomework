using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace homework10
{
    class Connection
    {
        public MySqlConnection getConn()
        {
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=''; database=ordertest;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();
                Console.WriteLine("已经建立连接");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return conn;
        }
    }
}
