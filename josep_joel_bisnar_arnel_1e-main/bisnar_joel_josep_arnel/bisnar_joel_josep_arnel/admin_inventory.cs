using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;

namespace bisnar_joel_josep_arnel
{
    public partial class admin_inventory : Form
    {
        public admin_inventory()
        {
            InitializeComponent();
            LoadProducts();

        }


        private void LoadProducts()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT product_id, product_name, product_price, quantity FROM products";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;

                        if (dataGridView1.Columns.Contains("product_id"))
                            dataGridView1.Columns["product_id"].HeaderText = "Product ID";
                        if (dataGridView1.Columns.Contains("product_name"))
                            dataGridView1.Columns["product_name"].HeaderText = "Product Name";
                        if (dataGridView1.Columns.Contains("product_price"))
                            dataGridView1.Columns["product_price"].HeaderText = "Product Price";
                        if (dataGridView1.Columns.Contains("quantity"))
                            dataGridView1.Columns["quantity"].HeaderText = "Quantity";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
        private void FetchProductDetails(int productId)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT product_name, product_price, quantity, product_image FROM products WHERE product_id = @pid";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@pid", productId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUpdateName.Text = reader["product_name"].ToString();
                            txtUpdatePrice.Text = reader["product_price"].ToString();
                            txtUpdateQty.Text = reader["quantity"].ToString();
                            textBox2.Text = reader["product_image"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Product not found.");
                        }
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


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            overview.Location = new Point(212, 59);
            AddItem.Location = new Point(1100, 60);
            UpdateItem.Location = new Point(1100, 60);
            btnOverview.ForeColor = Color.FromArgb(212, 175, 55);
            btnAddItem.ForeColor = Color.Green;
            btnUpdateItem.ForeColor = Color.Green;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            overview.Location = new Point(1100, 60);
            AddItem.Location = new Point(212, 59);
            UpdateItem.Location = new Point(1100, 60);
            btnOverview.ForeColor = Color.Green;
            btnAddItem.ForeColor = Color.FromArgb(212, 175, 55);
            btnUpdateItem.ForeColor = Color.Green;
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            overview.Location = new Point(1100, 60);
            AddItem.Location = new Point(1100, 60);
            UpdateItem.Location = new Point(212, 59);
            btnOverview.ForeColor = Color.Green;
            btnAddItem.ForeColor = Color.Green;
            btnUpdateItem.ForeColor = Color.FromArgb(212, 175, 55);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void overview_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ClearAddFields()
        {
            txtpn.Clear();
            txtprice.Clear();
            txtqty.Clear();
        }

        private void btnU_Click(object sender, EventArgs e)
        {

            string pname = txtpn.Text.Trim();
            string pimage = textBox1.Text.Trim();

            if (!decimal.TryParse(txtprice.Text, out decimal price) || !int.TryParse(txtqty.Text, out int qty))
            {
                MessageBox.Show("Please enter valid numbers for Price and Quantity.");
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "INSERT INTO products (product_name, product_price, quantity, product_image) VALUES (@name, @price, @qty, @img)";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", pname);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@img", pimage);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully!");
                    ClearAddFields();
                    LoadProducts();
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



        private void button2_Click(object sender, EventArgs e)
        {
            txtUpdateName.Enabled = true;
            txtUpdatePrice.Enabled = true;
            txtUpdateQty.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pid = (int)numericUpDown1.Value;
            string pimage = textBox2.Text;

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "UPDATE products SET product_name=@name, product_price=@price, quantity=@qty, product_image=@img WHERE product_id=@pid";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", txtUpdateName.Text);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtUpdatePrice.Text));
                    cmd.Parameters.AddWithValue("@qty", int.Parse(txtUpdateQty.Text));
                    cmd.Parameters.AddWithValue("@img", pimage);
                    cmd.Parameters.AddWithValue("@pid", pid);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product updated successfully!");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int selectedId = (int)numericUpDown1.Value;

            if (selectedId > 0)
            {
                FetchProductDetails(selectedId);
            }
            else
            {
                txtUpdateName.Clear();
                txtUpdatePrice.Clear();
                txtUpdateQty.Clear();
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            overview.Location = new Point(1100, 60);
            AddItem.Location = new Point(212, 59);
            UpdateItem.Location = new Point(1100, 60);
            btnOverview.ForeColor = Color.Green;
            btnAddItem.ForeColor = Color.FromArgb(212, 175, 55);
            btnUpdateItem.ForeColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            overview.Location = new Point(212, 59);
            AddItem.Location = new Point(1100, 60);
            UpdateItem.Location = new Point(1100, 60);
            btnOverview.ForeColor = Color.FromArgb(212, 175, 55);
            btnAddItem.ForeColor = Color.Green;
            btnUpdateItem.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            overview.Location = new Point(1100, 60);
            AddItem.Location = new Point(1100, 60);
            UpdateItem.Location = new Point(212, 59);
            btnOverview.ForeColor = Color.Green;
            btnAddItem.ForeColor = Color.Green;
            btnUpdateItem.ForeColor = Color.FromArgb(212, 175, 55);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            overview.Location = new Point(212, 59);
            AddItem.Location = new Point(1100, 60);
            UpdateItem.Location = new Point(1100, 60);
            btnOverview.ForeColor = Color.FromArgb(212, 175, 55);
            btnAddItem.ForeColor = Color.Green;
            btnUpdateItem.ForeColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            overview.Location = new Point(1100, 60);
            AddItem.Location = new Point(1100, 60);
            UpdateItem.Location = new Point(212, 59);
            btnOverview.ForeColor = Color.Green;
            btnAddItem.ForeColor = Color.Green;
            btnUpdateItem.ForeColor = Color.FromArgb(212, 175, 55);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            overview.Location = new Point(1100, 60);
            AddItem.Location = new Point(212, 59);
            UpdateItem.Location = new Point(1100, 60);
            btnOverview.ForeColor = Color.Green;
            btnAddItem.ForeColor = Color.FromArgb(212, 175, 55);
            btnUpdateItem.ForeColor = Color.Green;
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            admin_orderOrd form = new admin_orderOrd();
            form.Show();
            this.Hide();
        }



        private void btnMyorders_Click(object sender, EventArgs e)
        {
            admin_dashboard form = new admin_dashboard();
            form.Show();
            this.Hide();
        }

        private void admin_inventory_Load(object sender, EventArgs e)
        {

        }
    }

}
