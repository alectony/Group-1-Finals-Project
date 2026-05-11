using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace bisnar_joel_josep_arnel
{
    public partial class admin_orderOrd : Form
    {


        int selectedOrderId = -1;



        public admin_orderOrd()
        {
            InitializeComponent();
            LoadPendingOrders();
            LoadCompletedOrders();
        }
        private void LoadPendingOrders()
        {

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"SELECT uo.order_id, c.user_name AS Customer_Name, uo.item, uo.quantity, (p.product_price * uo.quantity) AS total, uo.status, uo.user_id, uo.product_id FROM user_orders uo LEFT JOIN products p ON uo.product_id = p.product_id LEFT JOIN clients c ON uo.user_id = c.user_id WHERE uo.status = @status";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@status", "pending");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvPend.DataSource = table;
                        if (dgvPend.Columns.Contains("Customer_Name")) dgvPend.Columns["Customer_Name"].HeaderText = "Ordered By";
                        if (dgvPend.Columns.Contains("order_id")) dgvPend.Columns["order_id"].Visible = false;
                        if (dgvPend.Columns.Contains("user_id")) dgvPend.Columns["user_id"].Visible = false;
                        if (dgvPend.Columns.Contains("product_id")) dgvPend.Columns["product_id"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending orders: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void LoadCompletedOrders()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"SELECT uo.order_id, c.user_name AS Customer_Name, uo.item, uo.quantity, (p.product_price * uo.quantity) AS total, uo.status, uo.user_id, uo.product_id FROM user_orders uo LEFT JOIN products p ON uo.product_id = p.product_id LEFT JOIN clients c ON uo.user_id = c.user_id WHERE uo.status = @status";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@status", "completed");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvComp.DataSource = table;

                        dgvComp.DataSource = table;
                        if (dgvComp.Columns.Contains("Customer_Name")) dgvComp.Columns["Customer_Name"].HeaderText = "Ordered By";
                        if (dgvComp.Columns.Contains("order_id")) dgvComp.Columns["order_id"].Visible = false;
                        if (dgvComp.Columns.Contains("user_id")) dgvComp.Columns["user_id"].Visible = false;
                        if (dgvComp.Columns.Contains("product_id")) dgvComp.Columns["product_id"].Visible = false;
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


        private void org_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            org.Location = new Point(207, 53);
            message.Location = new Point(1000, 60);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            org.Location = new Point(1000, 60);
            message.Location = new Point(207, 53);
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

        private void dgvPend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPend_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPend.Rows[e.RowIndex];
                if (row.Cells["Customer_Name"].Value != null)
                {
                    textBox1.Text = row.Cells["Customer_Name"].Value.ToString();
                    TextBox2.Text = row.Cells["Customer_Name"].Value.ToString();
                }
                if (row.Cells["order_id"].Value != null)
                {
                    selectedOrderId = Convert.ToInt32(row.Cells["order_id"].Value);
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == -1)
            {
                MessageBox.Show("Please select an order to mark as completed.");
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                MySqlTransaction trans = db.Connection.BeginTransaction();

                try
                {
                    int productId = 0;
                    int quantity = 0;
                    int userId = 0;
                    decimal total = 0;
                    string userEmail = "";
                    string itemName = "";

                    string detailQuery = "SELECT product_id, quantity, user_id, total FROM user_orders WHERE order_id = @oid";
                    string beachQuery = @"SELECT ui.email, uo.item FROM user_orders uo INNER JOIN clients c ON uo.user_id = c.user_id INNER JOIN user_info ui ON c.user_id = ui.user_id WHERE uo.order_id = @oid";
                    using (MySqlCommand cmdDetail = new MySqlCommand(detailQuery, db.Connection, trans))
                    {
                        cmdDetail.Parameters.AddWithValue("@oid", selectedOrderId);
                        using (MySqlDataReader reader = cmdDetail.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productId = reader.GetInt32("product_id");
                                quantity = reader.GetInt32("quantity");
                                userId = reader.GetInt32("user_id");
                                total = reader.GetDecimal("total");
                            }
                        }
                    }
                    using (MySqlCommand cmd = new MySqlCommand(beachQuery, db.Connection))
                    {
                        cmd.Parameters.AddWithValue("@oid", selectedOrderId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userEmail = reader["email"].ToString();
                                itemName = reader["item"].ToString();
                            }
                        }
                    }
                    MailMessage mail = new MailMessage();
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("anthonyjohnbisnar@gmail.com", "Grab n Go Admin");
                    mail.To.Add(userEmail);
                    mail.Subject = "Order Completed: " + itemName;
                    mail.Body = $"Hi! Your order for {itemName} was Completed.\n\n";
                    smtp.Port = 587;
                    smtp.Credentials = new NetworkCredential("anthonyjohnbisnar@gmail.com", "dhkkktkqznulwbvv");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    string updateStatus = "UPDATE user_orders SET status = 'Completed' WHERE order_id = @oid";
                    using (MySqlCommand cmdStatus = new MySqlCommand(updateStatus, db.Connection, trans))
                    {
                        cmdStatus.Parameters.AddWithValue("@oid", selectedOrderId);
                        cmdStatus.ExecuteNonQuery();
                    }
                    MessageBox.Show("Email sent and order Completed successfully and stock updated!");
                    LoadPendingOrders();

                    string updateStock = "UPDATE products SET quantity = quantity - @qty WHERE product_id = @pid";
                    using (MySqlCommand cmdStock = new MySqlCommand(updateStock, db.Connection, trans))
                    {
                        cmdStock.Parameters.AddWithValue("@qty", quantity);
                        cmdStock.Parameters.AddWithValue("@pid", productId);
                        cmdStock.ExecuteNonQuery();
                    }

                    string updateTrans = @"UPDATE transactions SET user_penoders = user_penoders - 1 WHERE user_id = @uid";
                    using (MySqlCommand cmdTrans = new MySqlCommand(updateTrans, db.Connection, trans))
                    {
                        cmdTrans.Parameters.AddWithValue("@uid", userId);
                        cmdTrans.ExecuteNonQuery();
                    }

                    trans.Commit();
                    LoadPendingOrders();
                    LoadCompletedOrders();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Transaction Failed: " + ex.Message);
                }
            }
            catch (Exception ex) { MessageBox.Show("Database Error: " + ex.Message); }
            finally { db.Close(); }
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == -1) { MessageBox.Show("Select an order first!"); return; }
            if (string.IsNullOrWhiteSpace(richTextBox1.Text)) { MessageBox.Show("Enter a reason!"); return; }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string userEmail = "";
                string itemName = "";
                string query = @"SELECT ui.email, uo.item FROM user_orders uo INNER JOIN clients c ON uo.user_id = c.user_id INNER JOIN user_info ui ON c.user_id = ui.user_id WHERE uo.order_id = @oid";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@oid", selectedOrderId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userEmail = reader["email"].ToString();
                            itemName = reader["item"].ToString();
                        }
                    }
                }
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("anthonyjohnbisnar@gmail.com", "Grab n Go Admin");
                mail.To.Add(userEmail);
                mail.Subject = "Order Declined: " + itemName;
                mail.Body = $"Hi! Your order for {itemName} was declined.\n\nReason: {richTextBox1.Text}";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("anthonyjohnbisnar@gmail.com", "dhkkktkqznulwbvv");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                string updateQuery = "UPDATE user_orders SET status = 'Cancelled' WHERE order_id = @oid";
                using (MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, db.Connection))
                {
                    cmdUpdate.Parameters.AddWithValue("@oid", selectedOrderId);
                    cmdUpdate.ExecuteNonQuery();
                }
                MessageBox.Show("Email sent and order cancelled successfully!");
                richTextBox1.Clear();
                org.Location = new Point(207, 53);
                message.Location = new Point(1000, 60);
                LoadPendingOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
            finally 
            { 
                db.Close(); 
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            admin_orderOrd form = new admin_orderOrd();
            form.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            admin_inventory form = new admin_inventory();
            form.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnMyorders_Click(object sender, EventArgs e)
        {
            admin_dashboard page = new admin_dashboard();
            page.Show();
            this.Hide();
        }
    }
}
