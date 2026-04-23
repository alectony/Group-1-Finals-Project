using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bisnar_joel_josep_arnel
{
    public partial class studReg : Form
    {
        public studReg()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            string role = "";
            string username = txtuser.Text.Trim();
            string password = passwordbox.Text.Trim();
            string cpass = txtcpass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            if (password != cpass)
            {
                MessageBox.Show("Password mismatch!");
                return;
            }
            if (radioButton1.Checked)
            {
                role = "admin";
                DBConnect db = new DBConnect();
                try
                {
                    db.Open();
                    string query = "INSERT INTO clients (user_name, password, role) VALUES (@user_name, @password, @role)";
                    MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query,
                    db.Connection);
                    cmd.Parameters.AddWithValue("@user_name", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("admin added successfully!");

                    txtuser.Clear();
                    passwordbox.Clear();

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
            if (radioButton2.Checked)
            {
                role = "student";
                DBConnect db = new DBConnect();
                try
                {
                    db.Open();
                    string query = "INSERT INTO clients (user_name, password, role) VALUES (@user_name, @password, @role)";
                    MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query,
                    db.Connection);
                    cmd.Parameters.AddWithValue("@user_name", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student added successfully!");

                    txtuser.Clear();
                    passwordbox.Clear();

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


        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form1 form = new form1();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passwordbox.Clear();
            txtcpass.Clear();
            txtuser.Clear();
        }
    }
}
