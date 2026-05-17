using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Student";
            DataTable result = DataConnect.GetData(query);

            if (result == null)
            {
                MessageBox.Show("Something went wrong. Please try again!");
                return;
            }

            dgvP.AutoGenerateColumns = false; // Assuming dgvT is your DataGridView's name
            dgvP.DataSource = result;
            dgvP.Refresh();
            dgvP.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtPass.Text = "";
            txtAddress.Text = "";
            dgvP.ClearSelection();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.UpdateData();
        }

        private void UpdateData()
        {
            // Retrieve the values from the form fields
            string id = txtId.Text;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string password = txtPass.Text;
            string address = txtAddress.Text;

            // Validate the inputs
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID cannot be empty!");
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone cannot be empty!");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }

            // Sanitize inputs to avoid potential SQL injection issues
            id = id.Replace("'", "''");
            name = name.Replace("'", "''");
            phone = phone.Replace("'", "''");
            password = password.Replace("'", "''");
            address = address.Replace("'", "''");

            // Corrected SQL query construction
            string query = $"UPDATE Student SET Name = '{name}', Phone = '{phone}', Password = '{password}', Address = '{address}' WHERE Id = '{id}'";

            // Execute the query
            var result = DataConnect.ExecuteQuery(query);

            if (!result)
            {
                MessageBox.Show("Something went wrong in Update. Please try again!");
                return;
            }

            // If the update is successful, show a message
            MessageBox.Show("Update successful!");

            // Reload data and highlight the updated row in the DataGridView
            this.LoadData();

            for (int i = 0; i < dgvP.Rows.Count; i++)
            {
                string selectedId = dgvP.Rows[i].Cells[0].Value?.ToString();

                if (selectedId == id)
                {
                    dgvP.ClearSelection();
                    dgvP.Rows[i].Selected = true;
                    dgvP.FirstDisplayedScrollingRowIndex = i;
                    return;
                }
            }
        }



        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvP.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadSingleData(id);
            }

        }
        private void LoadSingleData(string id)
        {
            string query = "select* from Student where id = " + id + "";
            DataTable result = DataConnect.GetData(query);

            if (result == null)
            {
                MessageBox.Show("Somthing Went Wrong.Please Try Again!");
                return;
            }

            txtId.Text = result.Rows[0]["Id"].ToString();
            txtName.Text = result.Rows[0]["Name"].ToString();
            txtPhone.Text = result.Rows[0]["PhoneNumber"].ToString();
            txtPass.Text = result.Rows[0]["Password"].ToString();
            txtAddress.Text = result.Rows[0]["Address"].ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student s1 = new Student();
            s1.Show();
        }
    }
}
