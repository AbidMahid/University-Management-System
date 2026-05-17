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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {

        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subject Su = new Subject();
            Su.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void giveTPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiveTPE course = new GiveTPE();
            course.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
