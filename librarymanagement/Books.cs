using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace librarymanagement
{
    public partial class Books : Form
    {
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\try.mdf;Integrated Security=True;Connect Timeout=30";
        public Books()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Books (Id,Title, Author) VALUES (@Id,@Title, @Author)", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = int.Parse(textBox6.Text) });
                        cmd.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar) { Value = textBox5.Text });
                        cmd.Parameters.Add(new SqlParameter("@Author", SqlDbType.NVarChar) { Value = textBox4.Text });

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book Added Successfully");
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
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Books", con))
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Books set Title=@Title, Author=@Author WHERE Id=@Id", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = int.Parse(textBox6.Text) });
                        cmd.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar) { Value = textBox5.Text });
                        cmd.Parameters.Add(new SqlParameter("@Author", SqlDbType.NVarChar) { Value = textBox4.Text });

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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE Books WHERE Id=@ID", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = int.Parse(textBox6.Text) });

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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Books", con))
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
