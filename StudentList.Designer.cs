namespace Bisnar_AnthonyJohn_FinalExam
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string user = usertxt.Text.Trim();
            string pass = passtxt.Text.Trim();

            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Registered!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db.Close();
            }

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            new Login_Page().Show();
            this.Hide();
        }
    }
}
