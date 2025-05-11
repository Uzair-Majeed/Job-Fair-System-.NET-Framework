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
    public partial class ReviewApplication2 : Form
    {
        int review;
        string reviewJob;
        DateTime time;
        string status;
        string appName;
        public ReviewApplication2(int review,string reviewJob,DateTime time,string status,string appName)
        {
            InitializeComponent();
            this.review = review;
            this.reviewJob = reviewJob;
            this.time = time;
            this.status = status;
            this.appName = appName;

            textBox1.Text = review.ToString();
            textBox5.Text = appName;
            textBox6.Text = reviewJob;
            dateTimePicker1.Text = time.ToString();
            comboBox1.Text = status;


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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
            DateTime time = dateTimePicker1.Value;

            string query = "UPDATE APPLICATION SET status = @status WHERE application_id = @application_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@application_id", review);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            string intID = "Select max(interview_ID) FROM INTERVIEWS";
            SqlCommand cmd1 = new SqlCommand(intID, conn);
            int interviewID = (int)cmd1.ExecuteScalar() + 1;
            cmd1.Dispose();

            string stdID = "Select applicant_ID FROM Application WHERE application_ID = @application_id";
            SqlCommand cmd3 = new SqlCommand(stdID, conn);
            cmd3.Parameters.AddWithValue("@application_id", review);
            int studentID = (int)cmd3.ExecuteScalar();
            cmd3.Dispose();

            string query2 = @"INSERT INTO INTERVIEWS (interview_ID, timeSlot, status, recruiter_ID, student_ID, eventID)
                              VALUES(@interviewID,@timeSlot,'Scheduled',@recruiter_ID,@student_ID,(SELECT MAX(eventID) FROM JOB_FAIR_EVENTS))";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@interviewID", interviewID);
            cmd2.Parameters.AddWithValue("@timeSlot", time);
            cmd2.Parameters.AddWithValue("@recruiter_ID", SessionData.UserId);
            cmd2.Parameters.AddWithValue("@student_ID", studentID);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();

            MessageBox.Show("Application Status Updated Successfully");
            conn.Close();

            Review_Application review_Application = new Review_Application();
            review_Application.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Review_Application review_Application = new Review_Application();
            review_Application.Show();
            this.Hide();
        }
    }
}
