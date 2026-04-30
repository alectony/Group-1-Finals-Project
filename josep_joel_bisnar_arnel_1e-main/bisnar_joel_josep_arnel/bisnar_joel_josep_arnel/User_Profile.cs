using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Npgsql.Internal.Postgres;
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
    public partial class User_Profile : Form
    {
        private int userId;
        public User_Profile(int id)
        {
            userId = id;
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string queryInfo = "SELECT first_name, last_name, address FROM user_info WHERE user_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(queryInfo, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fn = reader["first_name"].ToString();
                            string ln = reader["last_name"].ToString();
                            textBox1.Text = fn;
                            textBox2.Text = ln;
                            textBox4.Text = reader["address"].ToString();
                            lbl_firstn.Text = fn;
                            lbl_lastn.Text = ln;
                            lblInatial.Text = GetInitials(fn, ln);
                        }
                    }
                }

                string queryClient = "SELECT user_name, password FROM clients WHERE user_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(queryClient, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox3.Text = reader["user_name"].ToString();
                            textBox6.Text = reader["password"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { db.Close(); }
        }
        private void LoadProfile()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query1 = "SELECT first_name, last_name, address FROM user_info WHERE user_id = @user_id";

                using (MySqlCommand cmd = new MySqlCommand(query1, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["first_name"].ToString();
                            textBox2.Text = reader["last_name"].ToString();
                            textBox3.Text = reader["address"].ToString();
                        }
                    }
                }
                string query2 = "SELECT user_name, password FROM clients WHERE user_id = @user_id";

                using (MySqlCommand cmd1 = new MySqlCommand(query2, db.Connection))
                {
                    cmd1.Parameters.AddWithValue("@user_id", userId);
                    using (MySqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox4.Text = reader["user_name"].ToString();
                            textBox6.Text = reader["password"].ToString();
                            lblInatial.Text = reader["user_name"].ToString();
                        }
                    }
                }
                lblInatial.Text = GetInitials(lbl_firstn.Text, lbl_lastn.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
            finally { db.Close(); }
        }
        private string GetInitials(string fn, string ln)
        {
            if (string.IsNullOrEmpty(fn) || string.IsNullOrEmpty(ln))
            {
                return "UU";
            }

            return $"{fn.ToUpper()[0]}{ln.ToUpper()[0]}";
        }

        private void lblOrder_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                int totalRowsAffected = 0;
                string query1 = @"UPDATE user_info SET first_name = @first_name, last_name = @last_name, address = @address WHERE user_id = @user_id";
                using (MySqlCommand cmd = new MySqlCommand(query1, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@first_name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@address", textBox4.Text);
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    totalRowsAffected += cmd.ExecuteNonQuery();
                }
                string query2 = @"UPDATE clients SET user_name = @user_name, password = @password WHERE user_id = @user_id";
                using (MySqlCommand cmd2 = new MySqlCommand(query2, db.Connection))
                {
                    cmd2.Parameters.AddWithValue("@user_name", textBox3.Text);
                    cmd2.Parameters.AddWithValue("@password", textBox6.Text);
                    cmd2.Parameters.AddWithValue("@user_id", userId);
                    totalRowsAffected += cmd2.ExecuteNonQuery();
                }
                if (totalRowsAffected > 0)
                {
                    MessageBox.Show("Profile and Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProfile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            User_Product form = new User_Product(userId);
            form.Show();
            this.Hide();
        }

        private void btnMyorders_Click(object sender, EventArgs e)
        {
            User_MyOrders form = new User_MyOrders(userId);
            form.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            User_Dashboard form = new User_Dashboard(userId);
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                form1 form = new form1();
                form.Show();
                this.Hide();
            }
            if (result == DialogResult.No)
            {
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (result == DialogResult.No)
            {
            }
        }
    }
}

