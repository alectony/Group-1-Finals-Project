using Npgsql;
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
    public partial class grade : Form
    {
        public grade()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            string search = txtsearch.Text.Trim();
            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = @"SELECT student_id, English, Math, NSTP, USELF, (English + Math + NSTP + USELF) / 4 AS average FROM studentlist WHERE student_id LIKE @search";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        System.Data.DataTable table = new System.Data.DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;

                        if (dataGridView1.Columns.Contains("student_id"))
                            dataGridView1.Columns["student_id"].HeaderText = "Student ID";
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string student_id = txtID.Text.Trim();
            string English = txteng.Text.Trim();
            string Math = txtmath.Text.Trim();
            string NSTP = txtnst.Text.Trim();
            string USELF = txtuse.Text.Trim();


            if (string.IsNullOrEmpty(English) || string.IsNullOrEmpty
            (Math) ||
            string.IsNullOrEmpty(NSTP) || string.IsNullOrEmpty(USELF))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"INSERT INTO studentlist (English, Math, NSTP, USELF) VALUES (@English,@Math,@NSTP,@USELF);";

                using (var cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@student_id", txtID.Text);
                    cmd.Parameters.AddWithValue("@English", txteng.Text);
                    cmd.Parameters.AddWithValue("@Math", txtmath.Text);
                    cmd.Parameters.AddWithValue("@NSTP", txtnst.Text);
                    cmd.Parameters.AddWithValue("@USELF", txtuse.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Record Updated Successfully!");
                txtID.Clear();
                txteng.Clear();
                txtmath.Clear();
                txtnst.Clear();
                txtuse.Clear();
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


        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["student_id"].Value.ToString();
                txteng.Text = row.Cells["English"].Value.ToString();
                txtmath.Text = row.Cells["Math"].Value.ToString();
                txtnst.Text = row.Cells["NSTP"].Value.ToString();
                txtuse.Text = row.Cells["USELF"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["student_id"].Value.ToString();
                txteng.Text = row.Cells["English"].Value.ToString();
                txtmath.Text = row.Cells["Math"].Value.ToString();
                txtnst.Text = row.Cells["NSTP"].Value.ToString();
                txtuse.Text = row.Cells["USELF"].Value.ToString();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string eng = txteng.Text.Trim();
            string math = txtmath.Text.Trim();
            string nstp = txtnst.Text.Trim();
            string use = txtuse.Text.Trim();
            string stud_id = txtID.Text.Trim();
            int ID;

            if (string.IsNullOrEmpty(eng) || string.IsNullOrEmpty
            (math) ||
            string.IsNullOrEmpty(nstp) || string.IsNullOrEmpty(use))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }


            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"UPDATE studentlist SET student_id=@student_id, English=@English, Math=@Math, NSTP=@NSTP, USELF=@USELF average=@average WHERE student_id=@student_id";

                using (var cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@student_id", txtID.Text);
                    cmd.Parameters.AddWithValue("@English", txteng.Text);
                    cmd.Parameters.AddWithValue("@Math", txtmath.Text);
                    cmd.Parameters.AddWithValue("@NSTP", txtnst.Text);
                    cmd.Parameters.AddWithValue("@USELF", txtuse.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Record Updated Successfully!");
                txtID.Clear();
                txteng.Clear();
                txtmath.Clear();
                txtnst.Clear();
                txtuse.Clear();
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
            string id = txtID.Text.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student and their grades?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            DBConnect db = new DBConnect();
            try
            {
                db.Open();


                string query = @"DELETE FROM studentlist WHERE student_id = @student_id;";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@student_id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student and grades deleted successfully!");

                txtID.Clear();
                txteng.Clear();
                txtmath.Clear();
                txtnst.Clear();
                txtuse.Clear();

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

        private void button4_Click(object sender, EventArgs e)
        {
            studentlist form = new studentlist();
            form.Show();
            this.Hide();
        }
    }
}
