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
    public partial class Record : Form
    {
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\try.mdf;Integrated Security=True;Connect Timeout=30";
        public Record()
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [Borrowers Record] (Id, Name, Book, Date_Borrowed, Date_Return) VALUES (@Id, @Name, @Book, @Date_Borrowed, @Date_Return)", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = int.Parse(textBox12.Text) });
                        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = textBox11.Text });
                        cmd.Parameters.Add(new SqlParameter("@Book", SqlDbType.NVarChar) { Value = textBox10.Text });
                        cmd.Parameters.Add(new SqlParameter("@Date_Borrowed", SqlDbType.NVarChar) { Value = textBox13.Text });
                        cmd.Parameters.Add(new SqlParameter("@Date_Return", SqlDbType.NVarChar) { Value = textBox14.Text });

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Borrower Added Successfully");
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
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Borrowers Record]", con))
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE [Borrowers Record] set Name=@Name, Book=@Book, Date_Borrowed=@Date_Borrowed, Date_Return=@Date_Return WHERE Id=@Id", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = int.Parse(textBox12.Text) });
                        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = textBox11.Text });
                        cmd.Parameters.Add(new SqlParameter("@Book", SqlDbType.NVarChar) { Value = textBox10.Text });
                        cmd.Parameters.Add(new SqlParameter("@Date_Borrowed", SqlDbType.NVarChar) { Value = textBox13.Text });
                        cmd.Parameters.Add(new SqlParameter("@Date_Return", SqlDbType.NVarChar) { Value = textBox14.Text });

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [Borrowers Record] WHERE Id=@ID", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = int.Parse(textBox12.Text) });

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
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Borrowers Record]", con))
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
