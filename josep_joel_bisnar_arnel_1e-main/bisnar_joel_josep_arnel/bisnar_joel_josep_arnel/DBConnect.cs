using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bisnar_joel_josep_arnel
{
    internal class DBConnect
    {
        private MySqlConnection connection = new MySqlConnection(
           "server=localhost;user=root;database=Management_System;port=3306;password=;"
       );

        public MySqlConnection Connection => connection;

        public void Open()
        {
            try { if (connection.State != System.Data.ConnectionState.Open) connection.Open(); }
            catch (System.Exception ex) { MessageBox.Show("Connection Error: " + ex.Message); }
        }

        public void Close()
        {
            try { if (connection.State != System.Data.ConnectionState.Closed) connection.Close(); }
            catch (System.Exception ex) { MessageBox.Show("Connection Error: " + ex.Message); }
        }

    }
}
