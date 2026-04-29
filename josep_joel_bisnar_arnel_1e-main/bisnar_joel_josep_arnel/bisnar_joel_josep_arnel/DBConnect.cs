using Npgsql;
using System;
using System.Windows.Forms;

namespace bisnar_joel_josep_arnel
{
    internal class DBConnect
    {
        private NpgsqlConnection connection = new NpgsqlConnection(
            "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=312526;"
        );

        public NpgsqlConnection Connection => connection;

        public void Open()
        {
            try { if (connection.State != System.Data.ConnectionState.Open) connection.Open(); }
            catch (Exception ex) { MessageBox.Show("Connection Error: " + ex.Message); }
        }

        public void Close()
        {
            try { if (connection.State != System.Data.ConnectionState.Closed) connection.Close(); }
            catch (Exception ex) { MessageBox.Show("Connection Error: " + ex.Message); }
        }
    }
}