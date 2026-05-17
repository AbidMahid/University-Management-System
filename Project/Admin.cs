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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
           form1.Show();
        }

        private void btnStu_Click(object sender, EventArgs e)
        {
            ViewStu Vs = new ViewStu();
            Vs.Show();
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            ViewTeacher Vs = new ViewTeacher();
            Vs.Show();
        }

        private void btnTpe_Click(object sender, EventArgs e)
        {
            TPE tpe = new TPE();
            tpe.Show();
        }

        private void btnVC_Click(object sender, EventArgs e)
        {
            ViewCourse vc = new ViewCourse();   
            vc.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void adminControlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStu Vs = new ViewStu();
            Vs.Show();
        
    }

        private void viewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTeacher Vs = new ViewTeacher();
            Vs.Show();
        }

        private void viewTPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TPE tpe = new TPE();
            tpe.Show();
        }

        private void viewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCourse vc = new ViewCourse();
            vc.Show();
        }
    }
}
