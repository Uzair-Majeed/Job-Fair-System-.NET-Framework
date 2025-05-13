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

namespace WindowsFormsApp1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("TPO");
            comboBox1.Items.Add("Recruiter");
            comboBox1.Items.Add("Coordinator");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("BYE BYE!!!");
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();
            MessageBox.Show("Connection Open");

            string name = textBox1.Text;
            string email = textBox2.Text;
            string pass = textBox3.Text;
            string role = comboBox1.Text;
            string company = comboBox2.Text;

            string query1 = "SELECT MAX(user_ID) FROM USERS";
            SqlCommand cm = new SqlCommand(query1, conn);
            object user_id = (int)cm.ExecuteScalar() + 1;
            cm.Dispose();

            string query2 = "INSERT INTO USERS(user_id, password, role, name) VALUES (@userId, @password, @role, @name)";
            SqlCommand cm2 = new SqlCommand(query2, conn);
            cm2.Parameters.AddWithValue("@userId", user_id);
            cm2.Parameters.AddWithValue("@password", pass);
            cm2.Parameters.AddWithValue("@role", role);
            cm2.Parameters.AddWithValue("@name", name);
            cm2.ExecuteNonQuery();
            cm2.Dispose();

            if (role == "Student")
            {
                string query3 = "INSERT INTO Student(student_id, isApproved) VALUES (@user_id, 0)";
                SqlCommand cm3 = new SqlCommand(query3, conn);
                cm3.Parameters.AddWithValue("@user_id", user_id);
                cm3.ExecuteNonQuery();
                cm3.Dispose();

                MessageBox.Show("Your Registration req has been sent to admin!");
            }
            else if (role == "Recruiter")
            {
                string query6 = "SELECT company_ID FROM COMPANY WHERE name = @company";
                SqlCommand cm6 = new SqlCommand(query6, conn);
                cm6.Parameters.AddWithValue("@company", company);
                int company_id = (int)cm6.ExecuteScalar();
                cm6.Dispose();

                string query3 = "INSERT INTO Recruiter(recruiter_id, company_ID,isApproved) VALUES (@user_id, @company_id,0)";
                SqlCommand cm3 = new SqlCommand(query3, conn);
                cm3.Parameters.AddWithValue("@user_id", user_id);
                cm3.Parameters.AddWithValue("@company_id", company_id);
                cm3.ExecuteNonQuery();
                cm3.Dispose();

                MessageBox.Show("Your Registration req has been sent to admin!");

            }
            else if (role == "TPO")
            {
                string query3 = "INSERT INTO TPO(TPO_id) VALUES (@user_id)";
                SqlCommand cm3 = new SqlCommand(query3, conn);
                cm3.Parameters.AddWithValue("@user_id", user_id);
                cm3.ExecuteNonQuery();
                cm3.Dispose();

                MessageBox.Show("SIGNUP SUCCESSFUL!");
            }
            else
            {
                string query3 = "INSERT INTO Coordinator(Coordinator_id) VALUES (@user_id)";
                SqlCommand cm3 = new SqlCommand(query3, conn);
                cm3.Parameters.AddWithValue("@user_id", user_id);
                cm3.ExecuteNonQuery();
                cm3.Dispose();

                MessageBox.Show("SIGNUP SUCCESSFUL!");
            }

            string query4 = "INSERT INTO USER_Email(email, user_id) VALUES (@email, @user_id)";
            SqlCommand cm4 = new SqlCommand(query4, conn);
            cm4.Parameters.AddWithValue("@email", email);
            cm4.Parameters.AddWithValue("@user_id", user_id);
            cm4.ExecuteNonQuery();
            cm4.Dispose();

            conn.Close();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'job_FairDataSet.COMPANY' table. You can move, or remove it, as needed.
            this.cOMPANYTableAdapter.Fill(this.job_FairDataSet.COMPANY);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
