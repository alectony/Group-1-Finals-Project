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
    public partial class gradeSTUDENT : Form
    {
        public gradeSTUDENT()
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

        private void button4_Click(object sender, EventArgs e)
        {
            studentlistSTUDENT form = new studentlistSTUDENT();
            form.Show();
            this.Hide();
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
