using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Student_Reviews : Form
    {
        public Student_Reviews()
        {
            InitializeComponent();
            initComboBoxes();
            
        }

        private void initComboBoxes()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();
            string queryComboBox = "SELECT jp.Title AS Job_Title FROM INTERVIEWS i JOIN RECRUITER r ON i.recruiter_ID = r.recruiter_ID JOIN APPLICATION a ON a.applicant_ID = i.student_ID AND a.recruiter_ID = i.recruiter_ID JOIN JOB_POSTING jp ON jp.job_ID = a.job_ID WHERE i.student_ID =  @StudentId and i.status = 'Completed'";
            SqlCommand cmdComboBox = new SqlCommand(queryComboBox, conn);

            cmdComboBox.Parameters.AddWithValue("@StudentId", student_dashboard.getUserId());
            SqlDataReader reader = cmdComboBox.ExecuteReader();

            while (reader.Read())
            {
                string skillName = reader["Job_Title"].ToString();
                comboBox1.Items.Add(skillName);
            }

            reader.Close();
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string title = comboBox1.Text;
            int rating = int.Parse(comboBox2.Text);
            string comment = richTextBox1.Text;

            string query = @"SELECT TOP 1 i.interview_ID
                            FROM INTERVIEWS i
                           JOIN RECRUITER r ON i.recruiter_ID = r.recruiter_ID
                           JOIN APPLICATION a ON a.applicant_ID = i.student_ID AND a.recruiter_ID = i.recruiter_ID
                           JOIN JOB_POSTING jp ON jp.job_ID = a.job_ID
                           WHERE i.student_ID = @StudentId AND jp.Title = @title;";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@StudentID", student_dashboard.getUserId());

            int interviewID = (int)cmd.ExecuteScalar();

            string query2 = @"SELECT MAX(review_ID) FROM REVIEW";
            SqlCommand cmd2 = new SqlCommand(query2, conn);

            int reviewID = (int)cmd2.ExecuteScalar() + 1;

            string query3 = @"INSERT INTO REVIEW(review_ID, rating, student_ID, interview_ID) 
                  VALUES (@review_ID, @rating, @student_ID, @interview_ID)";

            SqlCommand cmd3 = new SqlCommand(query3, conn);
            cmd3.Parameters.AddWithValue("@review_ID", reviewID);
            cmd3.Parameters.AddWithValue("@rating", rating);
            cmd3.Parameters.AddWithValue("@student_ID", student_dashboard.getUserId());
            cmd3.Parameters.AddWithValue("@interview_ID", interviewID);
            cmd3.ExecuteNonQuery();

            string query4 = @"INSERT INTO REVIEW_comments(review_ID, comments) 
                  VALUES (@review_ID, @comments)";

            SqlCommand cmd4 = new SqlCommand(query4, conn);
            cmd4.Parameters.AddWithValue("@review_ID", reviewID);
            cmd4.Parameters.AddWithValue("@comments", comment);
            cmd4.ExecuteNonQuery();

            cmd.Dispose();
            cmd2.Dispose();
            cmd3.Dispose();
            cmd4.Dispose();

            Student_Reviews_Load(sender, e);
            conn.Close();

        }

        private void button13_Click(object sender, EventArgs e)
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
            student_Interviews.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Student_Reviews student_Reviews = new Student_Reviews();
            student_Reviews.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Student_Booth_checkins student_Booth_Checkins = new Student_Booth_checkins();
            student_Booth_Checkins.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Student_Reviews_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string query = @"SELECT 
                            C.Name AS Company_Name,
                            U.Name AS Interviewer_Name,
                            R.rating AS Review_Rating,
                            RC.comments AS Review_Comment
                            FROM 
                            REVIEW R
                            JOIN INTERVIEWS I ON R.interview_ID = I.interview_ID
                            JOIN RECRUITER RE ON I.recruiter_ID = RE.recruiter_ID
                            JOIN COMPANY C ON RE.company_ID = C.company_ID
                            JOIN USERS U ON RE.recruiter_ID = U.user_ID
                            JOIN REVIEW_comments RC ON R.review_ID = RC.review_ID
                            WHERE R.student_ID =@studentId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@studentId", student_dashboard.getUserId());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            cmd.Dispose();


            

            conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
