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
    public partial class Student_academic_info : Form
    {
        public Student_academic_info()
        {
            InitializeComponent();
        }

        private void Student_academic_info_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string query = @"SELECT a.degree_program, a.current_Semester, a.GPA FROM ACADEMIC_RECORD a WHERE a.student_id = @studentId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@studentId", student_dashboard.getUserId());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            cmd.Dispose();
            conn.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            student_dashboard student_Dashboard = new student_dashboard(SessionData.UserId, SessionData.UserName, SessionData.email, SessionData.password);
            this.Hide();
            student_Dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profile_management profile_Management = new profile_management(SessionData.UserId, SessionData.UserName, SessionData.email, SessionData.password);
            this.Hide();
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
            this.Hide();
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string organization = textBox1.Text;
            int currSemester = int.Parse(textBox2.Text);
            float GPA = float.Parse(textBox3.Text);

            if(GPA < 0.0f || GPA > 4.0f)
            {
                MessageBox.Show("GPA should be between 0.0 and 4.0");
                return;
            }

            string query1 = "UPDATE ACADEMIC_RECORD SET degree_program = @degreeProgram, current_Semester = @currentSemester, GPA = @GPA WHERE student_id = @studentId";
            SqlCommand cmd = new SqlCommand(query1, conn);
            cmd.Parameters.AddWithValue("@studentId", student_dashboard.getUserId());
            cmd.Parameters.AddWithValue("@degreeProgram", organization);
            cmd.Parameters.AddWithValue("@currentSemester", currSemester);
            cmd.Parameters.AddWithValue("@GPA", GPA);


            cmd.ExecuteNonQuery();
            cmd.Dispose();

            MessageBox.Show("UPDATED Successfully");

            Student_academic_info_Load(sender, e);

            conn.Close();
        }
    }
}
