using Microsoft.VisualBasic.Logging;
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
    public partial class passkey : Form
    {
        private string firstname, lastname, address, username, password, confirmpass;

        public passkey(string firstname, string lastname, string address,
                 string username, string password, string confirmpass)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.username = username;
            this.password = password;
            this.confirmpass = confirmpass;
        }
        public static class globalData
        {
            public static string passkey = "";
        }

        public passkey()
        {
            InitializeComponent();
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
            RegAcc page = new RegAcc();
            page.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text.Trim();
            int role = 1;
            DBConnect db = new DBConnect();
            if (key == "")
            {
                MessageBox.Show("Please enter username and password.");
                return; 
            }
            try
            {
                db.Open(); 
                string query = "SELECT passkey FROM clients WHERE passkey = @key";
                Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@key", key);
                string passkey = cmd.ExecuteScalar()?.ToString();
                cmd.Dispose(); 

                if (key == passkey)
                {
                    MessageBox.Show("Registered Successful!");
                    form1 dashboard = new form1();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
