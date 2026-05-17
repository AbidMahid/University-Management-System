using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class GiveTPE : Form
    {
        public GiveTPE()
        {
            InitializeComponent();
        }

        private void GiveTPE_Load(object sender, EventArgs e)
        {
            this.LoadData();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\6th Semester Final\C#\New Project\Power.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=false";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string TeacherQuery = "SELECT Id, Name FROM Teacher";
                    SqlCommand cmd = new SqlCommand(TeacherQuery, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbTN.DisplayMember = "Name";
                    cmbTN.ValueMember = "ID";
                    cmbTN.DataSource = dt;
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Feedback";
            DataTable result = DataConnect.GetData(query);

            if (result == null)
            {
                MessageBox.Show("Something went wrong. Please try again!");
                return;
            }

            dgvGTPE.AutoGenerateColumns = false;
            dgvGTPE.DataSource = result;
            dgvGTPE.Refresh();
            dgvGTPE.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        
        private void dgvGTPE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvGTPE.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadSingleData(id);
            }
        }
        private void LoadSingleData(string id)
        {
            string query = "select* from Feedback where id = " + id + "";
            DataTable result = DataConnect.GetData(query);

            if (result == null)
            {
                MessageBox.Show("Somthing Went Wrong.Please Try Again!");
                return;
            }

            cmbTN.Text = result.Rows[0]["TeacherID"].ToString();
            rtxtTPE.Text = result.Rows[0]["Feedback"].ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\6th Semester Final\C#\New Project\Power.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=false";

            if (cmbTN.SelectedValue == null)
            {
                MessageBox.Show("Please select a TEACHER.");
                return;
            }

            int TeacherId;
            if (!int.TryParse(cmbTN.SelectedValue.ToString(), out TeacherId))
            {
                MessageBox.Show("Invalid TEACHER selection.");
                return;
            }

            // Retrieve feedback from the rich text box
            string Feedback = rtxtTPE.Text.Trim();

            // Validate the feedback text
            if (string.IsNullOrEmpty(Feedback))
            {
                MessageBox.Show("Feedback cannot be empty!");
                return;
            }

            // SQL query to insert TeacherId and Feedback
            string query = "INSERT INTO Feedback (TeacherId, Feedback) VALUES (@TeacherId, @Feedback)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Use SqlCommand to execute the query
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Bind parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@TeacherId", TeacherId);
                        cmd.Parameters.AddWithValue("@Feedback", Feedback);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Feedback submitted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student();
            student.Show();
        }
    }
    
}
