using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update the connection string according to your setup
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\6th Semester Final\C#\New Project\Power.mdf"";Integrated Security=False;Connect Timeout=30;Encrypt=False";

            // Get values from text boxes
            string Name = txtName.Text;
            string Mobile= txtMob.Text; // Changed to string type to accommodate long numbers
            string Address = txtAdd.Text;
            string Password = txtPass.Text; // Consider hashing the password before storing

            // Check if any field is empty
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Mobile) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // SQL query to insert data
            string query = "INSERT INTO Student (Name, PhoneNumber, Password, Address) VALUES (@Name, @PhoneNumber,@Password,@address)";

            // Using SqlConnection and SqlCommand to interact with the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add values to the parameters
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@PhoneNumber", Mobile);
                        cmd.Parameters.AddWithValue("@Password", Address);
                        cmd.Parameters.AddWithValue("@Address", Password); // Hash the password before adding to the database

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        // Show success message
                        MessageBox.Show("Data inserted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Assuming you just want to close the registration form
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
               this.Refresh();
             
        }
    }
}
