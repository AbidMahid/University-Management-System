using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class DataConnect

    {
        static string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\6th Semester Final\C#\New Project\Power.mdf"";Integrated Security=False;Connect Timeout=30;Encrypt=False";
        public static DataTable GetData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public static bool ExecuteQuery(string query)
        {
            try
            {


                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

                return false;
            }
        }
    }
}

        
