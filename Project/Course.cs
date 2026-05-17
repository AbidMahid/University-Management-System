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
    public partial class Course : Form
    {

     

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\6th Semester Final\C#\New Project\Power.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();


                    string insertQuery = "INSERT INTO Course (Time, Duration, Department) VALUES (@Time, @Duration, @Department)";



                    SqlCommand cmd = new SqlCommand(insertQuery, con);


                   // cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    cmd.Parameters.AddWithValue("@Time",txtTime.Text);
                    cmd.Parameters.AddWithValue("@Duration", txtDur.Text);
                    cmd.Parameters.AddWithValue("@Department", txtDept);
      


                    cmd.ExecuteNonQuery();


                    string fetchMaxIdQuery = "SELECT MAX(Id) FROM Course;";
                    SqlCommand cmd1 = new SqlCommand(fetchMaxIdQuery, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Inserted Appointment Information Successfully.");


                        //txtId.Text = "";
                        txtTime.Text="";
                        txtDur.Text="";
                        txtDept.Text = "";
                        
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtId.Text = "";
            txtTime.Text = "";
            txtDur.Text = "";
            txtDept.Text = "";
        }

        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student();
            student.Show();
        }
    }
}
