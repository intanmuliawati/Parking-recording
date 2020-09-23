using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms; // dapat mengakses form windows
using System.Data;
using System.Threading.Tasks;

namespace LatihanMysql
{
    class MysqlDB
    {
        public  MySqlConnection connection;
        public  MySqlDataAdapter adapter;
        public  DataTable table;
        public  Boolean is_connect;

        public void koneksidb() {
            
            try
            {
                connection = new MySqlConnection("server=localhost;user id=root ;database=parkiran");
                connection.Open();
                is_connect = true;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
        public void closeConnection() {
            if (is_connect == true)
            {
                Console.WriteLine("\n Closing connection");
                connection.Close();

            }
        }
    }
}
