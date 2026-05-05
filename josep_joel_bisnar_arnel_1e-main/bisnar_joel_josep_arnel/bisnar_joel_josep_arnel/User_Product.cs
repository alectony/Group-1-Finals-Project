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
    using MySql.Data.MySqlClient;

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
                listNotifications.View = View.Details;
                listNotifications.FullRowSelect = true;
                listNotifications.GridLines = true;
                listNotifications.Columns.Clear();
                listNotifications.Columns.Add("Item", 150);
                listNotifications.Columns.Add("Qty", 50);
                listNotifications.Columns.Add("Price", 100);
                btnDashboard.FlatAppearance.BorderSize = 0;
                btnMyorders.FlatAppearance.BorderSize = 0;
                btnProducts.FlatAppearance.BorderSize = 0;
                btnMyprofile.FlatAppearance.BorderSize = 0;
                btnLogout.FlatAppearance.BorderSize = 0;
                btnExit.FlatAppearance.BorderSize = 0;


            }
            public void AddToCart(int productId, string itemName, int price)
            {
                foreach (ListViewItem existingItem in listNotifications.Items)
                {
                    if ((int)existingItem.Tag == productId)
                    {

                        int currentQty = int.Parse(existingItem.SubItems[1].Text);
                        currentQty++;
                        existingItem.SubItems[1].Text = currentQty.ToString();


                        totalAmount += price;
                        lbltotal.Text = totalAmount.ToString();
                        return;
                    }
                }


                ListViewItem item = new ListViewItem(itemName);
                item.Tag = productId;

                item.SubItems.Add("1");
                item.SubItems.Add("₱" + price.ToString());

                listNotifications.Items.Add(item);

                totalAmount += price;
                lbltotal.Text = totalAmount.ToString();
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
            Random rand = new Random();
            int sharedId = rand.Next(100000, 999999);
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                MySqlTransaction trans = db.Connection.BeginTransaction();
                try
                {
                    foreach (ListViewItem item in listNotifications.Items)
                    {
                        int pid = (int)item.Tag;
                        string itemName = item.Text;
                        int price = int.Parse(item.SubItems[2].Text.Replace("₱", "").Replace(",", ""));
                        int cartQty = int.Parse(item.SubItems[1].Text);
                        int totalPrice = price * cartQty;

                        if (cartQty > 0)
                        {
                            string orderQuery = "INSERT INTO user_orders (user_id, product_id, item, quantity, total, status, sharedID) VALUES (@uid, @pid, @item, @qty, @total, 'Pending', @shareId)";
                            using (MySqlCommand cmd = new MySqlCommand(orderQuery, db.Connection, trans))
                            {
                                cmd.Parameters.AddWithValue("@uid", userId);
                                cmd.Parameters.AddWithValue("@pid", pid);
                                cmd.Parameters.AddWithValue("@item", itemName);
                                cmd.Parameters.AddWithValue("@total", totalPrice);
                                cmd.Parameters.AddWithValue("@qty", cartQty);
                                cmd.Parameters.AddWithValue("@shareId", sharedId);
                                cmd.ExecuteNonQuery();
                            }
                            string transactionQuery = @"UPDATE transactions 
                                              SET user_orders = user_orders + @qty, 
                                                  user_penoders = user_penoders + @qty, 
                                                  user_totspent = user_totspent + @tot 
                                              WHERE user_id = @user_id";
                            using (MySqlCommand cmdTransaction = new MySqlCommand(transactionQuery, db.Connection, trans))
                            {
                                cmdTransaction.Parameters.AddWithValue("@user_id", userId);
                                cmdTransaction.Parameters.AddWithValue("@qty", cartQty);
                                cmdTransaction.Parameters.AddWithValue("@tot", totalPrice);
                                cmdTransaction.ExecuteNonQuery();
                            }
                        }
                    }
                    trans.Commit();
                    MessageBox.Show("Order Placed successfully! Status: Pending");
                    ClearCart();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Transaction failed: " + ex.Message);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { db.Close(); }
        }



        private void ClearCart()
            {
                listNotifications.Items.Clear();
                totalAmount = 0;
                lbltotal.Text = "0.00";
            }

            private void button2_Click(object sender, EventArgs e)
            {
                ClearCart();
            }

            private void btnriceadd_Click(object sender, EventArgs e)
            {
                AddToCart(1, "Rice 1kg", 50);
            }

            private void btnwateradd_Click(object sender, EventArgs e)
            {
                AddToCart(2, "Water 500ml", 15);
            }

            private void btnoiladd_Click(object sender, EventArgs e)
            {
                AddToCart(3, "Cooking Oil 1L", 35);
            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {
            }

            private void button8_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox3_Click(object sender, EventArgs e)
            {

            }

            private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
            {

            }

            private void pictureBox4_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {

            }

            private void listNotifications_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void listNotifications_SelectedIndexChanged_1(object sender, EventArgs e)
            {

            }
        }

    }

