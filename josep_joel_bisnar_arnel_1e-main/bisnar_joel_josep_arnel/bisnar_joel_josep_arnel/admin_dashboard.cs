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
using System.Windows.Forms.DataVisualization.Charting;

namespace bisnar_joel_josep_arnel
{
    public partial class admin_dashboard : Form
    {



        public admin_dashboard()
        {
            InitializeComponent();
            SetupChartManually();
            LoadStats();
            LoadChartData();
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

        Chart popularityChart;

        private void SetupChartManually()
        {
            popularityChart = new Chart();
            popularityChart.Size = new Size(500, 300);
            popularityChart.Location = new Point(50, 350);
            ChartArea area = new ChartArea("MainArea");
            popularityChart.ChartAreas.Add(area);
            Series series = new Series("ProductSales");
            series.ChartType = SeriesChartType.Pie;
            popularityChart.Series.Add(series);
            panel1.Controls.Add(popularityChart);
            popularityChart.BringToFront();
            popularityChart.BackColor = Color.Transparent;
            area.BackColor = Color.Transparent;
        }
        private void LoadChartData()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT item, SUM(quantity) AS total FROM user_orders GROUP BY item";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                popularityChart.Series["ProductSales"].Points.Clear();
                while (reader.Read())
                {
                    popularityChart.Series["ProductSales"].Points.AddXY(
                        reader["item"].ToString(),
                        reader["total"]
                    );
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { db.Close(); }
        }

        private void LoadStats()
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string qSales = "SELECT SUM(total) FROM user_orders WHERE status != 'Cancelled'";
                MySqlCommand cmdSales = new MySqlCommand(qSales, db.Connection);
                var salesResult = cmdSales.ExecuteScalar();
                lblTotalSales.Text = salesResult != DBNull.Value ? "₱" + salesResult.ToString() : "₱0";

                string qStock = "SELECT SUM(quantity) FROM products";
                MySqlCommand cmdStock = new MySqlCommand(qStock, db.Connection);
                lblStock.Text = cmdStock.ExecuteScalar().ToString();

                string qTrans = "SELECT COUNT(*) FROM user_orders;";
                MySqlCommand cmdTrans = new MySqlCommand(qTrans, db.Connection);
                lblTransactions.Text = cmdTrans.ExecuteScalar().ToString();

                UpdateLowStockBadge(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dash Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
        private void UpdateLowStockBadge(DBConnect db)
        {

        }






        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMyorders_Click(object sender, EventArgs e)
        {
            admin_dashboard cord = new admin_dashboard();
            cord.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            admin_orderOrd cord = new admin_orderOrd();
            cord.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            admin_inventory cord = new admin_inventory();
            cord.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
