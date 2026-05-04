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
    public partial class User_Product : Form
    {
        private int userId;
        private decimal totalAmount = 0;


        public User_Product(int id)
        {
            userId = id;
            InitializeComponent();
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnMyorders.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnMyprofile.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;

        }
        private void AddToCart(string itemName, decimal price)
        {
            listNotifications.Items.Add(itemName);
            listPrices.Items.Add("₱" + price.ToString("N2"));

            totalAmount += price;
            lbltotal.Text = totalAmount.ToString("N2");
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnMyprofile_Click(object sender, EventArgs e)
        {
            User_Profile form = new User_Profile(userId);
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listNotifications.Items.Count == 0) return;

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                foreach (var item in listNotifications.Items)
                {
                    string query = "INSERT INTO user_orders (user_id, item, status) VALUES (@uid, @item, 'Pending')";
                    using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                    {
                        cmd.Parameters.AddWithValue("@uid", userId);
                        cmd.Parameters.AddWithValue("@item", item.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order Placed! Check 'My Orders' for status.");
                ClearCart();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { db.Close(); }
        }

        private void ClearCart()
        {
            listNotifications.Items.Clear();
            listPrices.Items.Clear();
            totalAmount = 0;
            lbltotal.Text = "0.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void btnriceadd_Click(object sender, EventArgs e)
        {
            AddToCart("Rice 1kg", 50.00m);
        }

        private void btnwateradd_Click(object sender, EventArgs e)
        {
            AddToCart("Water 500ml", 12.00m);
        }

        private void btnoiladd_Click(object sender, EventArgs e)
        {
            AddToCart("Cooking Oil 1L", 95.00m);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }

}

