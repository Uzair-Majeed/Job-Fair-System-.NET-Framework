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
    public partial class manage_companies : Form
    {
        public manage_companies()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void manage_companies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'job_FairDataSet.COMPANY' table. You can move, or remove it, as needed.
            this.cOMPANYTableAdapter.Fill(this.job_FairDataSet.COMPANY);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");

            conn.Open();
            string name= textBox1.Text;
            string sector = textBox2.Text;
            string street = textBox3.Text;
            string phoneNo = textBox4.Text;

            string Q = "SELECT MAX(company_ID) FROM COMPANY";
            SqlCommand cm = new SqlCommand(Q, conn);
            int company_id = (int)cm.ExecuteScalar()+1;



            string query = "INSERT INTO COMPANY (company_ID,Name, Sector, Street,booth_ID) VALUES (@company_ID,@name, @sector, @street,(SELECT MAX(BOOTH_ID) FROM BOOTH))";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@company_ID", company_id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sector", sector);
            cmd.Parameters.AddWithValue("@street", street);

            cmd.ExecuteNonQuery();
            cmd.Dispose();

            string query2 = "INSERT INTO COMPANY_Contact_No (contact_no,company_ID) VALUES (@phoneNo, @company_ID)";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@company_id", company_id);
            cmd2.Parameters.AddWithValue("@phoneNo", phoneNo);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            MessageBox.Show("Company Added Successfully!");

            manage_companies_Load(sender, e);
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            recruiter_profile recruiter_Profile = new recruiter_profile();
            this.Hide();
            recruiter_Profile.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manage_companies manage_Companies = new manage_companies();
            this.Hide();
            manage_Companies.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Post_Job post_Job = new Post_Job();
            this.Hide();
            post_Job.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Review_Application review_Application = new Review_Application();
            this.Hide();
            review_Application.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            recruiter_interviews recruiter_Interviews = new recruiter_interviews();
            this.Hide();
            recruiter_Interviews.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hiring hiring
                = new Hiring();
            this.Hide();
            hiring.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TPO_dashboard tpo_Dashboard = new TPO_dashboard();
            tpo_Dashboard.Show();
            this.Hide();
        }
    }
}
