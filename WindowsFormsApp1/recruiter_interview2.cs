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
    public partial class recruiter_interview2 : Form
    {
        int interviewID;
        string eventTitle;
        DateTime timeslot;
        string status;
        string appName;
        public recruiter_interview2(int review, string reviewJob, DateTime time, string status, string appName)
        {
            InitializeComponent();
            this.interviewID = review;
            this.eventTitle = reviewJob;
            this.timeslot = time;
            this.status = status;
            this.appName = appName;

            textBox1.Text = review.ToString();
            textBox5.Text = appName;
            comboBox2.Text = reviewJob;
            dateTimePicker1.Text = time.ToString();
            comboBox1.Text = status;


            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();
            string queryComboBox = "SELECT title from JOB_FAIR_EVENTS";
            SqlCommand cmdComboBox = new SqlCommand(queryComboBox, conn);
            SqlDataReader reader = cmdComboBox.ExecuteReader();

            while (reader.Read())
            {
                string skillName = reader["title"].ToString();
                comboBox2.Items.Add(skillName);
            }

            reader.Close();
            conn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();
            string status = comboBox1.Text;
            string eventName = comboBox2.Text.ToString();
            DateTime time = dateTimePicker1.Value;

            string query = "SELECT eventID FROM JOB_FAIR_EVENTS WHERE title = @eventTitle";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@eventTitle", eventName);
            int eventID = (int)cmd.ExecuteScalar();
            cmd.Dispose();


            string query2 = "UPDATE INTERVIEWS SET eventID = @eventID WHERE interview_id = @application_id";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@eventID", eventID);
            cmd2.Parameters.AddWithValue("@application_id", interviewID);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();

            string query3 = "UPDATE INTERVIEWS SET status = @status WHERE interview_id = @application_id";
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            cmd3.Parameters.AddWithValue("@status", status);
            cmd3.Parameters.AddWithValue("@application_id", interviewID);
            cmd3.ExecuteNonQuery();
            cmd3.Dispose();

            string query4 = "UPDATE INTERVIEWS SET timeslot = @timeslot WHERE interview_id = @application_id";
            SqlCommand cmd4 = new SqlCommand(query4, conn);
            cmd4.Parameters.AddWithValue("@timeslot", time);
            cmd4.Parameters.AddWithValue("@application_id", interviewID);
            cmd4.ExecuteNonQuery();
            cmd4.Dispose();

            MessageBox.Show("Application Status Updated Successfully");
            conn.Close();

            recruiter_interviews recruiter_Interviews = new recruiter_interviews();
            recruiter_Interviews.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recruiter_interviews recruiter_Interviews = new recruiter_interviews();
            recruiter_Interviews.Show();
            this.Hide();
        }

        private void recruiter_interview2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'job_FairDataSet.JOB_FAIR_EVENTS' table. You can move, or remove it, as needed.
            this.jOB_FAIR_EVENTSTableAdapter.Fill(this.job_FairDataSet.JOB_FAIR_EVENTS);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
