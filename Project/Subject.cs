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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student();
            student.Show();
        }

        private void Subject_Load(object sender, EventArgs e)
        {

        }
    }
}
