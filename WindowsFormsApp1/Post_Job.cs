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

//added this to add the functionality of posting a job,belongs to recruiter dashboard
//will commit

namespace WindowsFormsApp1
{
    public partial class Post_Job : Form
    {
        public Post_Job()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();
            string queryComboBox = "SELECT distinct skill_name as skill_name FROM SKILL";
            SqlCommand cmdComboBox = new SqlCommand(queryComboBox, conn);
            SqlDataReader reader = cmdComboBox.ExecuteReader();

            while (reader.Read())
            {
                string skillName = reader["skill_name"].ToString();
                comboBox2.Items.Add(skillName);
            }

            reader.Close();
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            recruiter_dashboard recruiter_Dashboard = new recruiter_dashboard();
            this.Hide();
            recruiter_Dashboard.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            recruiter_profile recruiter_Profile = new recruiter_profile();
            this.Hide();
            recruiter_Profile.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Post_Job post_Job = new Post_Job();
            this.Hide();
            post_Job.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Review_Application review_Application = new Review_Application();
            this.Hide();
            review_Application.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            recruiter_interviews recruiter_Interviews = new recruiter_interviews();
            this.Hide();
            recruiter_Interviews.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string job_title = textBox1.Text;
            string job_description = richTextBox1.Text;
            string job_type = comboBox1.SelectedItem.ToString();
            string minSal = textBox2.Text;
            string maxSal = textBox3.Text;

            string salary = "Rs." + minSal + " - Rs." + maxSal;
            string location = textBox4.Text;
            DateTime deadline = dateTimePicker1.Value;
            string skills = comboBox2.SelectedItem.ToString();

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string q = "Select max(job_ID) FROM job_posting";
            SqlCommand cm = new SqlCommand(q, conn);
            int job_id = (int)cm.ExecuteScalar();

            job_id++;
            cm.Dispose();

            string q2 = "Select company_id from RECRUITER where recruiter_id = @recruiter_id";

            SqlCommand cm2 = new SqlCommand(q2, conn);
            cm2.Parameters.AddWithValue("@recruiter_id", SessionData.UserId);
            int company_id = (int)cm2.ExecuteScalar();
            cm2.Dispose();


            string query = @"INSERT INTO JOB_POSTING(job_ID, description, salary_Range, location_Preferences, Title, deadline, job_type, company_ID, recruiter_ID)
                         VALUES (@job_id, @job_description, @salary, @location, @job_title, @deadline, @job_type,@company_id,@recruiter_id)";

            SqlCommand cm3 = new SqlCommand(query, conn);
            cm3.Parameters.AddWithValue("@job_id", job_id);
            cm3.Parameters.AddWithValue("@job_description", job_description);
            cm3.Parameters.AddWithValue("@salary", salary);
            cm3.Parameters.AddWithValue("@location", location);
            cm3.Parameters.AddWithValue("@job_title", job_title);
            cm3.Parameters.AddWithValue("@deadline", deadline);
            cm3.Parameters.AddWithValue("@job_type", job_type);
            cm3.Parameters.AddWithValue("@company_id", company_id);
            cm3.Parameters.AddWithValue("@recruiter_id", SessionData.UserId);
            cm3.ExecuteNonQuery();
            cm3.Dispose();

            string query2 = "INSERT INTO JOB_SKILLS(job_ID, skill_id) VALUES (@job_id, (SELECT TOP 1 skill_id FROM SKILL WHERE skill_name = @skill_name))";
            SqlCommand cm4 = new SqlCommand(query2, conn);
            cm4.Parameters.AddWithValue("@job_id", job_id);
            cm4.Parameters.AddWithValue("@skill_name", skills);
            cm4.ExecuteNonQuery();
            cm4.Dispose();

            conn.Close();
            MessageBox.Show("Job posted successfully.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            manage_companies manage_Companies = new manage_companies();
            this.Hide();
            manage_Companies.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hiring hiring = new Hiring();
            this.Hide();
            hiring.Show();
        }
    }
}
