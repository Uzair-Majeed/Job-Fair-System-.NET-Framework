using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    
    public partial class student_dashboard : Form
    {
        public static int userId;
        public static string userName;
        public static string email;
        public static string password;

        public student_dashboard()
        {

            InitializeComponent();
        }
        public static int getUserId()
        {
            return userId;
        }
        public static string getUserName()
        {
            return userName;
        }
        public static string getEmail()
        {
            return email;
        }
        public static string getPassword() {
            return password;
        } 
        public student_dashboard(int user_id,string name,string em,string pass)
        {   

            InitializeComponent();
            userId = user_id;
            userName = name;
            email = em;
            password = pass;

            SessionData.UserId = userId;
            SessionData.email = email;
            SessionData.password = password;
            SessionData.UserName = userName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            profile_management profile_Management = new profile_management(userId, userName, email, password);
            this.Hide();
            profile_Management.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_certifications student_Certifications = new Student_certifications();
            student_Certifications.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student_skill student_Skill = new student_skill();
            this.Hide();
            student_Skill.Show();
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
            student_Job_Search.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Student_application student_Application = new Student_application();
            student_Application.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
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
    }
}
