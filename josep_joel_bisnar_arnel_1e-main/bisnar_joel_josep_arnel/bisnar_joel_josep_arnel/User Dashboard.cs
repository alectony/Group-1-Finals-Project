using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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

    public partial class User_Dashboard : Form
    {

        private int userId;


        public User_Dashboard(int id)
        {
            InitializeComponent();
            userId = id;
            listNotifications.Items.Clear();
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnMyorders.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnMyprofile.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            LoadUserData();
        }

        private void LoadStudents()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"SELECT order_id, item, quantity, total, status 
                         FROM user_orders 
                         WHERE user_id = @user_id";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = table;

                        dataGridView2.Columns["order_id"].HeaderText = "ORDER ID";
                        dataGridView2.Columns["item"].HeaderText = "ITEM";
                        dataGridView2.Columns["quantity"].HeaderText = "QUANTITY";
                        dataGridView2.Columns["total"].HeaderText = "TOTAL";
                        dataGridView2.Columns["status"].HeaderText = "STATUS";
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
            try
            {
                db.Open();
                string query1 = "select count(*) FROM user_orders WHERE user_id = @user_id";
                using (MySqlCommand cmd1 = new MySqlCommand(query1, db.Connection))
                {
                    cmd1.Parameters.AddWithValue("@user_id", userId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1))
                    {
                        int orderCount = Convert.ToInt32(cmd1.ExecuteScalar());
                        lblOrder.Text = orderCount.ToString();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }

            try
            {
                db.Open();
                string query2 = "select count(*) FROM user_orders WHERE status = 'Pending'";
                using (MySqlCommand cmd2 = new MySqlCommand(query2, db.Connection))
                {
                    cmd2.Parameters.AddWithValue("@user_id", userId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2))
                    {
                        int orderCount = Convert.ToInt32(cmd2.ExecuteScalar());
                        lblPending.Text = orderCount.ToString();
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
        private void LoadUserData()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT user_orders, user_penoders, user_totspent FROM transactions WHERE user_id=@user_id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@user_id", userId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblOrder.Text = reader["user_orders"].ToString();
                    lblPending.Text = reader["user_penoders"].ToString();
                    lblTotalspent.Text = reader["user_totspent"].ToString();
                }
                else
                {
                    lblOrder.Text = "0";
                    lblPending.Text = "0";
                    lblTotalspent.Text = "0";
                }

                reader.Close();
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



        private object dgvOrders;


        private void lblpanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_MyOrders form = new User_MyOrders(userId);
            form.Show();
            this.Hide();
        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            LoadStudents();

            listNotifications.Items.Add("Order #1041 is being prepared.");
            listNotifications.Items.Add("New promo: 10% off on beverages today.");
            listNotifications.Items.Add("Your profile is incomplete. Please update.");
        }












        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listNotifications_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOrder_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            User_Product form = new User_Product(userId);
            form.Show();
            this.Hide();
        }

        private void btnMyprofile_Click(object sender, EventArgs e)
        {
            User_Profile form = new User_Profile(userId);
            form.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
