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
    public partial class studentlistSTUDENT : Form
    {
        public studentlistSTUDENT()
        {
            InitializeComponent();
            LoadStudents();
        }







        private void StudentList_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            string search = txtsearch.Text.Trim();
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"SELECT id, firstname, lastname, course, student_id, section FROM studentlist WHERE id LIKE @search OR firstname LIKE @search OR lastname LIKE @search OR course LIKE @search OR student_id LIKE @search OR section LIKE @search";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns["id"].HeaderText = "ID";
                dataGridView1.Columns["firstname"].HeaderText = "First name";
                dataGridView1.Columns["lastname"].HeaderText = "Last Name";
                dataGridView1.Columns["course"].HeaderText = "Course";
                dataGridView1.Columns["student_id"].HeaderText = "Student ID";
                dataGridView1.Columns["Section"].HeaderText = "Section";
                adapter.Dispose();
                cmd.Dispose();
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


        private void button4_Click(object sender, EventArgs e)
        {
            gradeSTUDENT form = new gradeSTUDENT();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["id"].Value.ToString();
                txtFname.Text = row.Cells["firstname"].Value.ToString();
                txtLname.Text = row.Cells["lastname"].Value.ToString();
                txtcourse.Text = row.Cells["course"].Value.ToString();
                txtSec.Text = row.Cells["section"].Value.ToString();
                txtStud_id.Text = row.Cells["Student_id"].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["id"].Value.ToString();
                txtFname.Text = row.Cells["firstname"].Value.ToString();
                txtLname.Text = row.Cells["lastname"].Value.ToString();
                txtcourse.Text = row.Cells["course"].Value.ToString();
                txtSec.Text = row.Cells["section"].Value.ToString();
                txtStud_id.Text = row.Cells["Student_id"].Value.ToString();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
