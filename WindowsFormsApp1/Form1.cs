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

//added masked text box to hide password
namespace WindowsFormsApp1
{

    public static class SessionData
    {
        public static int UserId;
        public static string UserName;
        public static string email;
        public static string password;
        public static string companyName;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True"); //Connection String
            conn.Open();
            MessageBox.Show("Connection Open");
            string em = textBox1.Text;
            string pass = maskedTextBox1.Text;

            string query = "SELECT COUNT(*) FROM user_email e JOIN Users u on u.user_id = e.user_id WHERE e.email = @email AND u.password = @password";

            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@email", em);
            cm.Parameters.AddWithValue("@password", pass);

            int result = (int)cm.ExecuteScalar(); // Get the count result

            if (result > 0)
            {
                MessageBox.Show("Login Successful!");

                

                string query2 = "SELECT u.Role FROM users u JOIN user_email e on u.user_id = e.user_id WHERE e.email = @email AND u.password = @password";

                SqlCommand cm2 = new SqlCommand(query2, conn);
                cm2.Parameters.AddWithValue("@email", em);
                cm2.Parameters.AddWithValue("@password", pass);

                string role = (string)cm2.ExecuteScalar();

                string query3 = "SELECT u.user_id FROM users u JOIN user_email e on u.user_id = e.user_id WHERE e.email = @email AND u.password = @password";

                SqlCommand cm3 = new SqlCommand(query3, conn);
                cm3.Parameters.AddWithValue("@email", em);
                cm3.Parameters.AddWithValue("@password", pass);

                int user_id = (int)cm3.ExecuteScalar();

                string query4 = "SELECT u.name FROM users u JOIN user_email e on u.user_id = e.user_id WHERE e.email = @email AND u.password = @password";

                SqlCommand cm4 = new SqlCommand(query4, conn);
                cm4.Parameters.AddWithValue("@email", em);
                cm4.Parameters.AddWithValue("@password", pass);

                string name = (string)cm4.ExecuteScalar();

                if (role == "Student")
                {
                    student_dashboard student_Dashboard = new student_dashboard(user_id,name,em,pass);
                    this.Hide();
                    student_Dashboard.Show();

                }
                else if (role == "Recruiter")
                {
                    string query5 = "SELECT c.Name FROM COMPANY c JOIN RECRUITER r ON r.company_ID = c.company_ID WHERE r.recruiter_ID = @user_id";

                    SqlCommand cm5 = new SqlCommand(query5, conn);
                    cm5.Parameters.AddWithValue("@user_id", user_id);

                    string company = (string)cm5.ExecuteScalar();

                    recruiter_dashboard recruiter_Dashboard = new recruiter_dashboard(user_id, name, em, pass, company);
                    this.Hide();
                    recruiter_Dashboard.Show();
                }
                else if (role == "TPO")
                {
                    TPO_dashboard tPO_Dashboard = new TPO_dashboard(user_id, name, em, pass);
                    this.Hide();

                    tPO_Dashboard.Show();

                }
                else
                {
                    Coordinator_dashboard coordinator_Dashboard = new Coordinator_dashboard(user_id, name, em, pass);
                    this.Hide();

                    coordinator_Dashboard.Show();
                }

                cm2.Dispose();

            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }

            cm.Dispose();
            conn.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("BYE BYE!!!");
            Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show(); 
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
