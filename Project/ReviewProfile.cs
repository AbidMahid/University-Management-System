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
    public partial class ReviewProfile : Form
    {
        public ReviewProfile()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
           this.UpdateData();
        }
        private void UpdateData()
        {
            string Id = txtId.Text;
            string Name = txtName.Text;
            string Password = txtPass.Text;
            string Qualification = txtQ.Text;


            if (string.IsNullOrEmpty(Id))
            {
                MessageBox.Show("ID cannot be empty!");
                return;
            } 


            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }


            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }


            if (string.IsNullOrEmpty(Qualification))
            {
                MessageBox.Show("Qualification cannot be empty!");
                return;
            }


            string query = $"UPDATE Teacher SET Name = '" + Name + "', Password = '" + Password + "', Qualification = '" + Qualification + "' WHERE Id = " + Id + "";


            var result = DataConnect.ExecuteQuery(query);


            if (!result)
            {
                MessageBox.Show("Something went wrong in Update. Please try again!");
                return;
            }


            MessageBox.Show("Update successful!");


            this.LoadData();


            for (int i = 0; i < dgvT.Rows.Count; i++)
            {
                string selectedId = dgvT.Rows[i].Cells[0].Value?.ToString();


                if (selectedId == Id)
                {
                    dgvT.ClearSelection();
                    dgvT.Rows[i].Selected = true;
                    dgvT.FirstDisplayedScrollingRowIndex = i;
                    return;
                }
            }
        }

        private void ReviewProfile_Load(object sender, EventArgs e)
        {
            this.LoadData();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
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
            txtQ.Text = "";
            dgvT.ClearSelection();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
            txtQ.Text = result.Rows[0]["Qualification"].ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher teacher = new Teacher();    
            teacher.Show();
        }
    }
}
