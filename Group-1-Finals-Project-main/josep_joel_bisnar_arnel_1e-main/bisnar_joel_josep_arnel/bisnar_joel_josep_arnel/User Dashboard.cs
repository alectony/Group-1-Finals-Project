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
    public partial class User_Dashboard : Form
    {
        private object dgvOrders;

        public User_Dashboard()
        {
            InitializeComponent();
        }

        private void lblpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            btnUser.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("#1042", "Rice 5kg", "2", "₱480", "Done");
            dataGridView1.Rows.Add("#1041", "Cooking Oil", "1", "₱95", "Pending");
            dataGridView1.Rows.Add("#1040", "Water 500ml", "6", "₱72", "Done");

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
    }
}
