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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  this.Hide();

            ViewCourse vc = new ViewCourse();
            //ViewCourse.ShowDialog();
            this.Show();  */

            Course course = new Course();
            course.Show();

        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ReviewProfile rf = new ReviewProfile();
            rf.Show();
            
             //updateDoctorProfileForm.ShowDialog();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void viewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherViewCourse tvc = new TeacherViewCourse();
            tvc.Show();

        }

        private void reviewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewProfile rf = new ReviewProfile();
            rf.Show();
        }
    }
}
