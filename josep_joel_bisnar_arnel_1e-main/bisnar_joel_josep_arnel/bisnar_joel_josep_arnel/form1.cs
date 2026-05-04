using System.ComponentModel;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.LinkLabel;

namespace bisnar_joel_josep_arnel
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;
            pb2.Hide();
            lnkCreate.Cursor = Cursors.Hand;
            lnkCreate.LinkColor = Color.White;


            panel1.BackColor = Color.FromArgb(100, 13, 10, 38);
            panel2.BackColor = Color.FromArgb(100, 13, 10, 38);
            lblacc.BackColor = Color.Transparent;
            lblget.BackColor = Color.Transparent;
            lblpass.BackColor = Color.Transparent;
            lblname.BackColor = Color.Transparent;
            pb1.BackColor = Color.Transparent;
            pb2.BackColor = Color.Transparent;
            pb3.BackColor = Color.Transparent;
            chkpass.BackColor = Color.Transparent;
            lnkCreate.BackColor = Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text.Trim();
            string password = txtpass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT user_id, role FROM clients WHERE user_name=@user_name AND password=@password";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@user_name", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    int userId = Convert.ToInt32(result["user_id"]);
                    int role = Convert.ToInt32(result["role"]);

                    if (role == 1)
                    {
                        MessageBox.Show("Welcome admin.");

                        admin_inventory form = new admin_inventory();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Welcome User.");

                        User_Dashboard form = new User_Dashboard(userId);
                        form.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                result.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegAcc page = new RegAcc();
            page.Show();
            this.Hide();
        }
        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpass.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
                pb2.Show();
                pb3.Hide();
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                pb3.Show();
                pb2.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
