using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace librarymanagement
{
    public partial class Members : Form
    {
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\try.mdf;Integrated Security=True;Connect Timeout=30";

        public Members()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Members (Name, Email) VALUES (@Name, @Email)", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = int.Parse(textBox1.Text) });
                        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = textBox3.Text });
                        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar) { Value = textBox2.Text });

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Member Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Members", con))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            da.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Members set Name=@Name, Email=@Email WHERE Id=@Id", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = int.Parse(textBox1.Text) });
                        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = textBox3.Text });
                        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar) { Value = textBox2.Text });

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE Members WHERE Id=@ID", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = int.Parse(textBox1.Text) });

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Successfully Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Members", con))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            da.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

