using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Numerics;

namespace bisnar_joel_josep_arnel
{
    public partial class passkey : Form
    {
        private string firstname, lastname, address, username, password, confirmpass;
        private int attemptsLeft = 3;
        private int userId;
        public static class globalData
        {
            public static string passkey = "";

        }

        public passkey(string first_name, string last_name, string address, string user_name, string password, string confirmpass)

           
        {
            InitializeComponent();
            this.firstname = first_name;
            this.lastname = last_name;
            this.address = address;
            this.username = user_name;
            this.password = password;
            this.confirmpass = confirmpass;
            textBox1.UseSystemPasswordChar = true;
            textBox1.ReadOnly = true;
            textBox1.MaxLength = 8;
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string btntext = "1";

            if (textBox1.Text.Length < 8)
            {
                textBox1.Text += btntext;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string btntext = "2";
            if (textBox1.Text.Length < 8)
            {
                textBox1.Text += btntext;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string btntext = "3";
            if (textBox1.Text.Length < 8)
            {
                textBox1.Text += btntext;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string btntext = "4";
            if (textBox1.Text.Length < 8)
            {
                textBox1.Text += btntext;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string btntext = "5";
            if (textBox1.Text.Length < 8)
            {
                textBox1.Text += btntext;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string btntext = "6";
            if (textBox1.Text.Length < 8)
            {
                textBox1.Text += btntext;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string btntext = "7";
            if (textBox1.Text.Length < 8)
            {
                textBox1.Text += btntext;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string btntext = "8";
            if (textBox1.Text.Length < 8)
            {
                textBox1.Text += btntext;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string btntext = "9";
            if (textBox1.Text.Length < 8)
            {
                textBox1.Text += btntext;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string btntext = "0";
            if (textBox1.Text.Length < 8)
            {
                textBox1.Text += btntext;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entered: " + textBox1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RegAcc page = new RegAcc(userId);
            page.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text.Trim();
            int role = 1;
            DBConnect db = new DBConnect();

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter the passkey.");
                return;
            }

            try
            {
                db.Open();
                string query = "SELECT passkey FROM clients WHERE passkey = @key LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@key", key);
                string dbPasskey = cmd.ExecuteScalar()?.ToString();

                if (key == dbPasskey)
                {
                    string query2 = "INSERT INTO clients (user_name, password, role) VALUES (@user_name, @password, @role)";
                    using (MySqlCommand cmd2 = new MySqlCommand(query2, db.Connection))
                    {
                        cmd2.Parameters.AddWithValue("@user_name", (object)username ?? DBNull.Value);
                        cmd2.Parameters.AddWithValue("@password", (object)password ?? DBNull.Value);
                        cmd2.Parameters.AddWithValue("@role", role);
                        cmd2.ExecuteNonQuery();
                        long newUserId = cmd2.LastInsertedId;

                        string query1 = "INSERT INTO user_info (user_id, first_name, last_name, address) VALUES (@user_id, @first_name, @last_name, @address)";



                        using (MySqlCommand cmd1 = new MySqlCommand(query1, db.Connection))
                        {
                            cmd1.Parameters.AddWithValue("@user_id", newUserId);
                            cmd1.Parameters.AddWithValue("@first_name", firstname);
                            cmd1.Parameters.AddWithValue("@last_name", lastname );
                            cmd1.Parameters.AddWithValue("@address", address);
                            cmd1.ExecuteNonQuery();
                        }

                    }





                    MessageBox.Show("Registered Successfully!");
                    new form1().Show();
                    this.Hide();
                }
                else
                {
                    attemptsLeft--;
                    label5.Text = attemptsLeft.ToString();

                    if (attemptsLeft > 0)
                    {
                        MessageBox.Show($"{attemptsLeft} attempts remaining.");
                        textBox1.Clear(); 
                    }
                    else
                    {
                        MessageBox.Show("Too many failed attempts. Closing application.");
                        Application.Exit();
                    }
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
    }
}
