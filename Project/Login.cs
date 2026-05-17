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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex == 0)
            {
                if (txtName.Text == "admin" || txtPass.Text == "admin")
                {
                    MessageBox.Show("Congratulations Logged In");
                    this.Visible = false;
                    Admin obj1 = new Admin();
                    obj1.ShowDialog();
                    txtName.Text = "";
                    txtPass.Text = "";
                    cmbUser.Text = "Select";
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password.");
                }
                Admin user = new Admin();
                user.Visible = true;
                this.Visible = false;
            }

            else if (cmbUser.SelectedIndex == 1)
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FST05RKU;Initial Catalog=Hospital;Integrated Security=True;Encrypt=False");
                con.Open();
                string str = "SELECT Name FROM Student WHERE Name = '" + txtName.Text + "' and Password = '" + txtPass.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Visible = false;
                    Teacher obj2 = new Teacher();
                    obj2.ShowDialog();
                    txtName.Text = "";
                    txtPass.Text = "";
                    cmbUser.Text = "Select";
                }
                else
                {
                    MessageBox.Show("Invalid username and Password.");
                }
                Teacher user = new Teacher();
                user.Visible = true;
                this.Visible = false;
            }

            else if (cmbUser.SelectedIndex == 2)
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FST05RKU;Initial Catalog=Hospital;Integrated Security=True;Encrypt=False");
                con.Open();
                string str = "SELECT Name FROM Teacher WHERE Name = '" + txtName.Text + "' and Password = '" + txtPass.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Visible = false;
                    Student obj2 = new Student();
                    txtName.Text = "";
                    txtPass.Text = "";
                    cmbUser.Text = "Select";
                }
                else
                {
                    MessageBox.Show("Invalid username and Password.");
                }
                Student user = new Student();
                user.Visible = true;
                this.Visible = false;
            }

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Registration nu = new Registration();
            nu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            R.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex == 0)
            {
                if (txtName.Text == "admin" || txtPass.Text == "admin")
                {
                    MessageBox.Show("You are logged in successfully..");
                    this.Visible = false;
                    Admin obj1 = new Admin();
                    obj1.ShowDialog();
                    txtName.Text = "";
                    txtPass.Text = "";
                    cmbUser.Text = "--Select--";
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password.");
                }
                Admin user = new Admin();
                user.Visible = true;
                this.Visible = false;
            }

            else if (cmbUser.SelectedIndex == 2)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\6th Semester Final\C#\New Project\Power.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
                con.Open();
                string str = "SELECT Name FROM Student WHERE Name = '" + txtName.Text + "' and Password = '" + txtPass.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Visible = false;
                    Teacher obj2 = new Teacher ();
                    obj2.ShowDialog();
                    txtName.Text = "";
                    txtPass.Text = "";
                    cmbUser.Text = "--Select--";
                }
                else
                {
                    MessageBox.Show("Invalid username and Password.");
                }
                Teacher user = new Teacher();
                user.Visible = true;
                this.Visible = false;
            }

            else if (cmbUser.SelectedIndex == 1)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\6th Semester Final\C#\New Project\Power.mdf"";Integrated Security=true;Connect Timeout=30;Encrypt=False");
                con.Open();
                string str = "SELECT Name FROM Teacher WHERE Name = '" + txtName.Text + "' and Password = '" + txtPass.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Visible = false;
                    Student obj2 = new Student();
                    txtName.Text = "";
                    txtPass.Text = "";
                    cmbUser.Text = "--Select--";
                }
                else
                {
                    MessageBox.Show("Invalid username and Password.");
                }
                Student user = new Student();
                user.Visible = true;
                this.Visible = false;
            }
            

        }

        private void btnRegistration_Click_1(object sender, EventArgs e)
        {
            Registration R = new Registration();
            R.Show();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Admin Ad = new Admin();
                Ad.Show();
            
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student St = new Student();
            St.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher Te = new Teacher();
            Te.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

