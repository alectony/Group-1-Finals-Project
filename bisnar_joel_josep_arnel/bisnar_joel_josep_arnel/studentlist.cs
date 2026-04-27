using Npgsql;
using bisnar_joel_josep_arnel;
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
    public partial class studentlist : Form
    {
        public studentlist()
        {
            InitializeComponent();
            LoadStudents();
            cmbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cmbCourse.SelectedIndex = -1;

        }
        private void StudentList_Load(object sender, EventArgs e)
        {
            LoadStudents();
            cmbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cmbCourse.SelectedIndex = -1;
        }
        private void LoadStudents()
        {
            string search = txtsearch.Text.Trim();
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"SELECT id, firstname, lastname, course, student_id, section 
                 FROM studentlist 
                 WHERE CAST(id AS TEXT) LIKE @search 
                 OR firstname LIKE @search 
                 OR lastname LIKE @search 
                 OR course LIKE @search 
                 OR student_id LIKE @search 
                 OR section LIKE @search";

                NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["id"].Value.ToString();
                txtFname.Text = row.Cells["firstname"].Value.ToString();
                txtLname.Text = row.Cells["lastname"].Value.ToString();
                cmbCourse.Text = row.Cells["course"].Value.ToString();
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
                cmbCourse.Text = row.Cells["course"].Value.ToString();
                txtSec.Text = row.Cells["section"].Value.ToString();
                txtStud_id.Text = row.Cells["Student_id"].Value.ToString();

            }
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void txtsearch_Click_1(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.ToString();
            string firstname = txtFname.Text.Trim();
            string lastName = txtLname.Text.Trim();
            string course = cmbCourse.SelectedItem.ToString();
            string stud_id = txtStud_id.Text.Trim();
            string section = txtSec.Text.Trim();


            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty
            (lastName) ||
            string.IsNullOrEmpty(course) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"INSERT INTO studentlist (firstname, lastname, course, student_id, section) VALUES (@firstname,@lastname,@course,@student_id,@section);";

                using (var cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@firstname", txtFname.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLname.Text);
                    cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                    cmd.Parameters.AddWithValue("@section", txtSec.Text);
                    cmd.Parameters.AddWithValue("@student_id", txtStud_id.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Record Updated Successfully!");
                txtID.Clear();
                txtFname.Clear();
                txtLname.Clear();
                cmbCourse.SelectedIndex = -1;
                txtSec.Clear();
                LoadStudents();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string firstName = txtFname.Text.Trim();
            string lastName = txtLname.Text.Trim();
            string course = cmbCourse.SelectedItem.ToString();
            string section = txtSec.Text.Trim();
            string stud_id = txtStud_id.Text.Trim();
            int ID;

            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please Click Record to Update");
                return;
            }
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty
            (lastName) ||
            string.IsNullOrEmpty(course) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }


            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"UPDATE studentlist SET firstname=@firstname, lastname=@lastname, course=@course, section=@section, student_id=@student_id WHERE id=@id";
                using (var cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@firstname", txtFname.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLname.Text);
                    cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                    cmd.Parameters.AddWithValue("@section", txtSec.Text);
                    cmd.Parameters.AddWithValue("@student_id", txtStud_id.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Record Updated Successfully!");
                txtID.Clear();
                txtFname.Clear();
                txtLname.Clear();
                cmbCourse.SelectedIndex = -1;
                txtSec.Clear();
                LoadStudents();
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
            int ID;
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please select a student first.");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student ? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "DELETE FROM studentlist WHERE id=@id";
                NpgsqlCommand cmd =
                new NpgsqlCommand(query,
                db.Connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();


                cmd.Dispose();
                MessageBox.Show("Student deleted successfully!");
                txtID.Clear();
                txtFname.Clear();
                txtLname.Clear();
                cmbCourse.SelectedIndex = -1;
                txtStud_id.Clear();
                txtSec.Clear();
                LoadStudents();
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

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            grade form = new grade();
            form.Show();
            this.Hide();
        }
    }
}
