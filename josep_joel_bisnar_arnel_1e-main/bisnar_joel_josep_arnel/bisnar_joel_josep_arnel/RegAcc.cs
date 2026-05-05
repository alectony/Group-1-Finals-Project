using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using static System.Collections.Specialized.BitVector32;

namespace bisnar_joel_josep_arnel
{
    public partial class RegAcc : Form
    {
        public static class GlobalData

        
        {
            public static int choice = 0;
        }
        private int userId;

        public RegAcc(int id)
        {
            userId = id;
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
            string email = txtEmail.Text.ToString().Trim();
            string confirmpass = txtconfirm.Text.ToString().Trim();
            int choice = GlobalData.choice;

            passkey var = new passkey(first_name, last_name, address, user_name, password, email);

            if (string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(user_name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(confirmpass))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            DBConnect db = new DBConnect();
            if(password != confirmpass)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            else if (choice == 0)
            {
                try
                {
                    int orders = 0;
                    int pen = 0;
                    int tot = 0;

                    db.Open();
                        
                    string queryClients = "INSERT INTO clients(user_name, password, role) VALUES(@user_name, @password, @role)";
                    MySqlCommand cmdClients = new MySqlCommand(queryClients, db.Connection);
                    cmdClients.Parameters.AddWithValue("@user_name", user_name);
                    cmdClients.Parameters.AddWithValue("@password", password);
                    cmdClients.Parameters.AddWithValue("@role", choice);
                    cmdClients.ExecuteNonQuery();

                    long newUserId = cmdClients.LastInsertedId;

                    string queryInfo = "INSERT INTO user_info (user_id, first_name, last_name, address, email) VALUES (@uid, @first_name, @last_name, @address, @email)";
                    MySqlCommand cmdInfo = new MySqlCommand(queryInfo, db.Connection);
                    cmdInfo.Parameters.AddWithValue("@uid", newUserId);
                    cmdInfo.Parameters.AddWithValue("@first_name", first_name);
                    cmdInfo.Parameters.AddWithValue("@last_name", last_name);
                    cmdInfo.Parameters.AddWithValue("@address", address);
                    cmdInfo.Parameters.AddWithValue("@email", email);
                    cmdInfo.ExecuteNonQuery();

                    string queryOrders = "INSERT INTO transactions (user_id, user_orders, user_penoders, user_totspent) VALUES (@user_id, @user_orders, @user_pend, @user_tots)";
                    MySqlCommand cmdOrders = new MySqlCommand(queryOrders, db.Connection);
                    cmdOrders.Parameters.AddWithValue("@user_id", newUserId);
                    cmdOrders.Parameters.AddWithValue("@user_orders", orders);
                    cmdOrders.Parameters.AddWithValue("@user_pend", pen);
                    cmdOrders.Parameters.AddWithValue("@user_tots", tot);
                    cmdOrders.ExecuteNonQuery();
                    txtAddress.Clear();
                    txtconfirm.Clear();
                    txtFirst.Clear();
                    txtLast.Clear();
                    txtUser.Clear();
                    txtpass.Clear();    
                    MessageBox.Show("Registration successful!");
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

        private void txtconfirm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
