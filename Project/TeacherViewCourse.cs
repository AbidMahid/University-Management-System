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

namespace Project
{
    public partial class TeacherViewCourse : Form
    {
        public TeacherViewCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\6th Semester Final\C#\New Project\Power.mdf"";Integrated Security=False;Connect Timeout=30;Encrypt=False");
                conn.Open();
                string query = "select * from Student";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvTVC.DataSource = dt;
                dgvTVC.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show("SWW");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher teacher = new Teacher();
            teacher.Show();
        }
    }
}
