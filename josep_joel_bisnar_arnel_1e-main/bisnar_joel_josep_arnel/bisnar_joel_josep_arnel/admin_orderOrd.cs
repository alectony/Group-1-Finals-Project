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
            finally { db.Close(); }
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
            if (selectedOrderId != -1)
            {
                DBConnect db = new DBConnect();
                try
                {
                    db.Open();
                    string query = "UPDATE user_orders SET status = @status WHERE order_id = @order_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                    {
                        cmd.Parameters.AddWithValue("@status", "completed");
                        cmd.Parameters.AddWithValue("@order_id", selectedOrderId);
                        cmd.ExecuteNonQuery();
                    }
                    LoadPendingOrders();
                    LoadCompletedOrders();
                    MessageBox.Show("Order marked as completed!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating order status: " + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an order to mark as completed.");
            }



        }
    }
}
