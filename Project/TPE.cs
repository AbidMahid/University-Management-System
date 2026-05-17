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
    public partial class TPE : Form
    {
        public TPE()
        {
            InitializeComponent();
        }

        private void btnVTPE_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\6th Semester Final\C#\New Project\Power.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=false");
                string query = "select * from Feedback";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvVTPE.DataSource = dt;
                dgvVTPE.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show("SWW");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void TPE_Load(object sender, EventArgs e)
        {

        }
    }
}
