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

//this form can be used for all user to update their profiles.
//will push this.
namespace WindowsFormsApp1
{
    
    public partial class profile_management : Form
    {
        public static int userId;
        public static string userName;
        public static string email;
        public static string password;

        public profile_management()
        {

            InitializeComponent();
        }
        public profile_management(int user_id, string name, string em, string pass)
        {

            InitializeComponent();
            userId = user_id;
            userName = name;
            email = em;
            password = pass;

            textBox5.Text = userName;        // Name
            textBox4.Text = email;           // Email
            maskedTextBox1.Text = password;
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
        public static string getPassword()
        {
            return password;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            student_dashboard student_Dashboard = new student_dashboard(userId,userName,email,password);
           student_Dashboard.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            profile_management profile_Management = new profile_management(userId, userName, email, password);
            this.Hide();
            profile_Management.Show();
        }

        private void button11_Click(object sender, EventArgs e)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True"); //Connection String
            conn.Open();
            string newEm = textBox8.Text;
            string newName = textBox7.Text;
            string newPass = textBox3.Text;
            string reconfirm = textBox2.Text;

            if(newPass != reconfirm)
            {
                MessageBox.Show("Password does not match");
                return;
            }

            email = newEm;
            userName = newName;
            password = newPass;

            SessionData.password = password;
            SessionData.email = email;
            SessionData.UserName = userName;


            string query = "UPDATE Users SET Name = @name, Password = @password WHERE user_id = @userId";
            string query2 = "UPDATE user_email SET email = @email WHERE user_id = @userId";

            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@name", userName);
            cm.Parameters.AddWithValue("@password", password);
            cm.Parameters.AddWithValue("@userId", userId);

            cm.ExecuteNonQuery();
            cm.Dispose();

            SqlCommand cm2 = new SqlCommand(query2, conn);
            cm2.Parameters.AddWithValue("@email", email);
            cm2.Parameters.AddWithValue("@userId", userId);

            cm2.ExecuteNonQuery();
            cm2.Dispose();
            conn.Close();

            MessageBox.Show("Profile Updated successfully,\nReload to see changes");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
