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
    public partial class Student_Interviews : Form
    {
        public Student_Interviews()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            student_dashboard student_Dashboard = new student_dashboard(SessionData.UserId, SessionData.UserName, SessionData.email, SessionData.password); this.Hide();
            student_Dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profile_management profile_Management = new profile_management(SessionData.UserId, SessionData.UserName, SessionData.email, SessionData.password); this.Hide();
            profile_Management.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student_skill student_Skill = new student_skill();
            this.Hide();
            student_Skill.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_certifications student_Certifications = new Student_certifications();
            student_Certifications.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student_academic_info academic = new Student_academic_info();
            this.Hide();
            academic.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Student_Job_search student_Job_Search = new Student_Job_search();
            this.Hide();
            student_Job_Search.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Student_application student_Application = new Student_application();
            this.Hide();
            student_Application.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Student_Interviews student_Interviews = new Student_Interviews();
            this.Hide();
            student_Interviews.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Student_Reviews student_Reviews = new Student_Reviews();
            this.Hide();
            student_Reviews.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Student_Booth_checkins student_Booth_Checkins = new Student_Booth_checkins();
            this.Hide();
            student_Booth_Checkins.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Student_Interviews_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string query = @"SELECT 
                             jp.Title AS Job_Title,
                             c.Name AS Company_Name,
                             u.Name AS Interviewer,
                             e.Title AS Event,
                             i.timeSlot AS TimeSlot,
                             i.Status AS Status
                             FROM INTERVIEWS i
                             JOIN RECRUITER r ON i.recruiter_ID = r.recruiter_ID
                             JOIN USERS u ON u.user_ID = r.recruiter_ID
                             JOIN APPLICATION a ON a.applicant_ID = i.student_ID AND a.recruiter_ID = i.recruiter_ID
                             JOIN JOB_POSTING jp ON jp.job_ID = a.job_ID
                             JOIN COMPANY c ON c.company_ID = r.company_ID
                             JOIN JOB_FAIR_EVENTS e ON e.eventID = i.eventID
                             WHERE i.student_ID =  @studentId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@studentId", student_dashboard.getUserId());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            cmd.Dispose();
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
