using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace bisnar_joel_josep_arnel
{
    internal class DBConnect
    {
        private MySqlConnection connection = new MySqlConnection(
            "server=sql12.freesqldatabase.com;user=sql12824893;database=sql12824893;port=3306;password=ZXvIJRcr88;"
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