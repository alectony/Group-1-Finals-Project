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
using System.IO;

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

            SetupCartColumns();
            LoadProductsFromDatabase();

            btnDashboard.FlatAppearance.BorderSize = 0;
            btnMyorders.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnMyprofile.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
        }

        private void SetupCartColumns()
        {
            listNotifications.View = View.Details;
            listNotifications.FullRowSelect = true;
            listNotifications.GridLines = true;
            listNotifications.Columns.Clear();
            listNotifications.Columns.Add("Item", 150);
            listNotifications.Columns.Add("Qty", 50);
            listNotifications.Columns.Add("Price", 100);
        }

        private void LoadProductsFromDatabase()
        {
            flproducts.Controls.Clear();
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT * FROM products";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int pid = Convert.ToInt32(reader["product_id"]);
                            string pName = reader["product_name"].ToString();
                            int pPrice = Convert.ToInt32(reader["product_price"]);
                            string pImg = reader["product_image"].ToString();
                            CreateProductCard(pid, pName, pPrice, pImg);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally { db.Close(); }
        }

        private void CreateProductCard(int id, string name, int price, string imageName)
        {
            Panel pnl = new Panel();
            pnl.Size = new Size(160, 210);
            pnl.BackColor = Color.FromArgb(30, 30, 50);
            pnl.Margin = new Padding(10);

            PictureBox pb = new PictureBox();
            pb.Size = new Size(140, 100);
            pb.Location = new Point(10, 10);
            pb.SizeMode = PictureBoxSizeMode.Zoom;

         
            string path = Path.Combine(Application.StartupPath, "product_images", imageName);

            if (File.Exists(path))
            {
                pb.Image = Image.FromFile(path);
            }
            else
            {
                pb.BackColor = Color.Gray;
            }

            Label lblName = new Label { Text = name, ForeColor = Color.White, Location = new Point(10, 115), AutoSize = true };
            Label lblPrice = new Label { Text = "₱" + price, ForeColor = Color.Gold, Location = new Point(10, 135), AutoSize = true };

            Button btnAdd = new Button();
            btnAdd.Text = "Add";
            btnAdd.Size = new Size(140, 30);
            btnAdd.Location = new Point(10, 165);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.Click += (sender, e) => { AddToCart(id, name, price); };

            pnl.Controls.Add(pb);
            pnl.Controls.Add(lblName);
            pnl.Controls.Add(lblPrice);
            pnl.Controls.Add(btnAdd);
            flproducts.Controls.Add(pnl);
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
                    lbltotal.Text = totalAmount.ToString("N2");
                    return;
                }
            }

            ListViewItem item = new ListViewItem(itemName);
            item.Tag = productId;
            item.SubItems.Add("1");
            item.SubItems.Add("₱" + price.ToString());
            listNotifications.Items.Add(item);

            totalAmount += price;
            lbltotal.Text = totalAmount.ToString("N2");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new form1().Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) => ClearCart();

        private void ClearCart()
        {
            listNotifications.Items.Clear();
            totalAmount = 0;
            lbltotal.Text = "0.00";
        }

        private void flproducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (listNotifications.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty!");
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                // Using a transaction ensures all items are saved, or none are (prevents partial orders)
                MySqlTransaction trans = db.Connection.BeginTransaction();
                try
                {
                    int sharedId = new Random().Next(100000, 999999);

                    foreach (ListViewItem item in listNotifications.Items)
                    {
                        string query = "INSERT INTO user_orders (user_id, product_id, item, quantity, total, status, sharedID) " +
                                       "VALUES (@uid, @pid, @item, @qty, @total, 'Pending', @sid)";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.Connection, trans))
                        {
                            cmd.Parameters.AddWithValue("@uid", userId);
                            cmd.Parameters.AddWithValue("@pid", (int)item.Tag);
                            cmd.Parameters.AddWithValue("@item", item.Text);
                            cmd.Parameters.AddWithValue("@qty", int.Parse(item.SubItems[1].Text));
                            // Parse price safely
                            decimal price = decimal.Parse(item.SubItems[2].Text.Replace("₱", ""));
                            cmd.Parameters.AddWithValue("@total", price * int.Parse(item.SubItems[1].Text));
                            cmd.Parameters.AddWithValue("@sid", sharedId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    trans.Commit();
                    MessageBox.Show("Order Placed Successfully!");
                    ClearCart();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Order failed: " + ex.Message);
                }
            }
            catch (Exception ex) { MessageBox.Show("Database error: " + ex.Message); }
            finally { db.Close(); }
        }
    }
    
}