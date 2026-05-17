using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class ViewTeacher : Form
    {
        public ViewTeacher()
        {
            InitializeComponent();
        }

        private void ViewTeacher_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Teacher";
            DataTable result = DataConnect.GetData(query);

            if (result == null)
            {
                MessageBox.Show("Something went wrong. Please try again!");
                return;
            }

            dgvT.AutoGenerateColumns = false; // Assuming dgvT is your DataGridView's name
            dgvT.DataSource = result;
            dgvT.Refresh();
            dgvT.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
            txtSal.Text = "";
            txtQ.Text = "";
            dgvT.ClearSelection();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }
        private void SaveData()
        {
            string id = txtId.Text;
            string Name = txtName.Text;
            string Password = txtPass.Text;
            string Salary = txtSal.Text;
            string Qualification = txtQ.Text;
            

            if (txtId.Text == "")
            {
                var query = "insert into Teacher (Name,Password,Salary,Qualification) output inserted.Id values('"+Name+"',"+Password+","+Salary+",'"+Qualification+"' )";
                var result = DataConnect.GetData(query);
                if (result == null)
                {
                    MessageBox.Show("Somthing Went Wrong.Pleasr try again!");
                    return;
                }

                txtId.Text = result.Rows[0]["Id"].ToString();
            }
            else
            {
                var query = "UPDATE Teacher SET Name = '"+Name+"', Password = "+Password+", Salary = "+Salary+", Qualification = '"+Qualification+"' WHERE Id = "+id+"";
                var result = DataConnect.ExecuteQuery(query);

                if (result == false)
                {
                    MessageBox.Show("Somthing Went Wrong.Pleasr try again!");
                    return;
                }
                MessageBox.Show("Success");
            }

            this.LoadData();

            for (int i = 0; i < dgvT.Rows.Count; i++)
            {
                string selectedID = dgvT.Rows[i].Cells[0].Value.ToString();
                if (selectedID == txtId.Text)
                {
                    dgvT.Rows[i].Selected = true;
                    return;
                }
            }
        }

        private void dgvT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvT.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadSingleData(id);
            }
        }
        private void LoadSingleData(string id)
        {
            string query = "select* from Teacher where id = " + id + "";
            DataTable result = DataConnect.GetData(query);

            if (result == null)
            {
                MessageBox.Show("Somthing Went Wrong.Please Try Again!");
                return;
            }

            txtId.Text = result.Rows[0]["Id"].ToString();
            txtName.Text = result.Rows[0]["Name"].ToString();
            txtPass.Text = result.Rows[0]["Password"].ToString();
            txtSal.Text = result.Rows[0]["Salary"].ToString();
            txtQ.Text = result.Rows[0]["Qualification"].ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DeleteData();
        }
        private void DeleteData()
        {
            string id = txtId.Text;

            if (id == "")
            {
                MessageBox.Show("Please select a row first");
                return;
            }

            var userResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

            if (userResult == DialogResult.No)
            {
                return;
            }


            var query = "delete from Teacher where id = " + id + "";
            var result = DataConnect.ExecuteQuery(query);

            if (result == false)
            {
                MessageBox.Show("Somthing Went Wrong.Pleasr try again!");
                return;
            }
            MessageBox.Show("Deleted");
            this.LoadData();
            this.NewData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void dgvT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
