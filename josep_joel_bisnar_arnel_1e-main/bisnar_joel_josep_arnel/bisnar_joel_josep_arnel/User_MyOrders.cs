using MySql.Data.MySqlClient;
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
    public partial class User_MyOrders : Form
    {
        private int userId;

        private string curr = "All";
        public User_MyOrders(int id)
        {
            userId = id;

            InitializeComponent();
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnMyorders.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnMyprofile.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnAll.FlatAppearance.BorderSize = 0;
            btnPending.FlatAppearance.BorderSize = 0;
            btnCompleted.FlatAppearance.BorderSize = 0;
            btnCancelled.FlatAppearance.BorderSize = 0;
            btnsearch.FlatAppearance.BorderSize = 0;
            LoadUserData();
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

        private void User_MyOrders_Load(object sender, EventArgs e)
        {
            LoadOrders("All");
        }


        // Central method to load and filter data from PostgreSQL
        private void LoadOrders(string status, string searchKeyword = "")
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string query = @"SELECT order_id, item, quantity, total, status 
                                 FROM user_orders 
                                 WHERE user_id = @user_id";
                if (status != "All")
                {
                    query += " AND status = @status";
                }

                // Add Search Filter
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    query += " AND (item ILIKE @search OR order_id::text ILIKE @search)";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    if (status != "All")
                        cmd.Parameters.AddWithValue("@status", status);

                    if (!string.IsNullOrEmpty(searchKeyword))
                        cmd.Parameters.AddWithValue("@search", "%" + searchKeyword + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            curr = "All";
            LoadOrders(curr, textBox1.Text);
            btnAll.ForeColor = Color.FromArgb(212, 175, 55);
            btnCompleted.ForeColor = Color.Green;
            btnPending.ForeColor = Color.Green;
            btnCancelled.ForeColor = Color.Green;
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            curr = "Pending";
            LoadOrders(curr, textBox1.Text);
            btnAll.ForeColor = Color.Green;
            btnCompleted.ForeColor = Color.Green;
            btnPending.ForeColor = Color.FromArgb(212, 175, 55);
            btnCancelled.ForeColor = Color.Green;
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            curr = "Completed";
            LoadOrders(curr, textBox1.Text);
            btnAll.ForeColor = Color.Green;
            btnCompleted.ForeColor = Color.FromArgb(212, 175, 55);
            btnPending.ForeColor = Color.Green;
            btnCancelled.ForeColor = Color.Green;
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            curr = "Cancelled";
            LoadOrders(curr, textBox1.Text);
            btnAll.ForeColor = Color.Green;
            btnCompleted.ForeColor = Color.Green;
            btnPending.ForeColor = Color.Green;
            btnCancelled.ForeColor = Color.FromArgb(212, 175, 55);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoadOrders(curr, btnsearch.Text);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadOrders(curr, btnsearch.Text);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnMyprofile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
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

        private void btnExit_Click_1(object sender, EventArgs e)
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

        private void btnMyprofile_Click_1(object sender, EventArgs e)
        {
            User_Profile form = new User_Profile(userId);
            form.Show();
            this.Hide();
        }

        private void btnProducts_Click_1(object sender, EventArgs e)
        {
            User_Product form = new User_Product(userId);
            form.Show();
            this.Hide();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            User_Dashboard form = new User_Dashboard(userId);
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
