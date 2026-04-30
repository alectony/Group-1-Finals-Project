using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using MySql.Data.MySqlClient;

namespace bisnar_joel_josep_arnel
{
    public partial class RegAcc : Form
    {
        public static class GlobalData
        {
            public static int choice = 0;
        }
        public RegAcc()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;
            txtconfirm.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegAcc_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 13, 10, 38);
            panel2.BackColor = Color.FromArgb(100, 13, 10, 38);
            panel3.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            checkBox1.BackColor = Color.Transparent;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnU_Click(object sender, EventArgs e)
        {
            GlobalData.choice = 0;
            panel3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first_name = txtFirst.Text.ToString().Trim();
            string last_name = txtLast.Text.ToString().Trim();
            string address = txtAddress.Text.ToString().Trim();
            string user_name = txtUser.Text.ToString().Trim();
            string password = txtpass.Text.ToString().Trim();
            string confirmpass = txtconfirm.Text.ToString().Trim();
            int choice = GlobalData.choice;

            passkey var = new passkey(first_name, last_name, address, user_name, password, confirmpass);
  
            if (string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty (last_name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(user_name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmpass))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            DBConnect db = new DBConnect();
            if (choice == 0)
            {
                try
                {
                    db.Open();
                    string query = "INSERT INTO user_info (first_name, last_name, address) VALUES (@first_name, @last_name, @address)";
                    string query1 = "INSERT INTO clients(user_name, password, role)VALUES(@user_name,@password,@role)";
                    MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                    MySqlCommand cmd3 = new MySqlCommand(query1, db.Connection);
                    cmd.Parameters.AddWithValue("@first_name", first_name);
                    cmd.Parameters.AddWithValue("@last_name", last_name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd3.Parameters.AddWithValue("@user_name", user_name);
                    cmd3.Parameters.AddWithValue("@password", password);
                    cmd3.Parameters.AddWithValue("@role", choice);
                    cmd.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Student added successfully!");
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
            else if (choice == 1)
            {
                passkey page = new passkey(first_name, last_name, address, user_name, password, confirmpass);
                page.Show();
                this.Close();
            }
           
            
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form1 page = new form1();
            page.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalData.choice = 1;
            panel3.Enabled = true;
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
                txtconfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                txtconfirm.UseSystemPasswordChar = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
