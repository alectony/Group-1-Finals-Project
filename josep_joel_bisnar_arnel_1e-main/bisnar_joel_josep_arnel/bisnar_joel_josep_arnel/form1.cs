using Npgsql;
using System.ComponentModel;

namespace bisnar_joel_josep_arnel
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;
            pb2.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text.Trim();
            string password = txtpass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }
            
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT role FROM clients WHERE user_name=@user_name AND password=@password";

                NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@user_name", username);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();
                    if (role == "admin")
                    {
                        MessageBox.Show("Welcome admin.");

                    }
                    else if (role == "student")
                    {
                        MessageBox.Show("Welcome User.");

                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpass.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
                pb2.Show();
                pb3.Hide();
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                pb3.Show();
                pb2.Hide();
            }
        }
    }
}
