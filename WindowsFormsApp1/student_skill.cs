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
    public partial class student_skill : Form
    {
        public student_skill()
        {
            InitializeComponent();
            initializeComboBoxes();
        }

        private void initializeComboBoxes()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();
            string queryComboBox = "SELECT distinct skill_name as skill_name FROM SKILL";
            SqlCommand cmdComboBox = new SqlCommand(queryComboBox, conn);
            SqlDataReader reader = cmdComboBox.ExecuteReader();

            while (reader.Read())
            {
                string skillName = reader["skill_name"].ToString();
                comboBox1.Items.Add(skillName);
            }

            reader.Close();
            conn.Close();
        }

        private void student_skill_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string query = "SELECT s.skill_name, s.skill_level FROM STUDENT_SKILLS ss JOIN SKILL s ON ss.skill_id = s.skill_id WHERE ss.student_id = @studentId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@studentId", student_dashboard.getUserId());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string skillname = comboBox1.Text;

            string query1 = "SELECT skill_id FROM SKILL WHERE skill_name = @skillname";
            SqlCommand cm = new SqlCommand(query1, conn);
            cm.Parameters.AddWithValue("@skillname", skillname);
            
            int skillId = (int)cm.ExecuteScalar();
            cm.Dispose();

            string query2 = "INSERT INTO STUDENT_SKILLS (student_id, skill_id) VALUES (@studentId, @skillId)";
            SqlCommand cm2 = new SqlCommand(query2, conn);
            cm2.Parameters.AddWithValue("@studentId", student_dashboard.getUserId());
            cm2.Parameters.AddWithValue("@skillId",skillId);
            cm2.ExecuteNonQuery();
            cm2.Dispose();

            MessageBox.Show("Skill Added Successfully");
            student_skill_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            profile_management profile_Management = new profile_management(SessionData.UserId, SessionData.UserName, SessionData.email, SessionData.password);
            this.Hide();
            profile_Management.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            student_dashboard student_Dashboard = new student_dashboard(SessionData.UserId, SessionData.UserName, SessionData.email, SessionData.password);
            this.Hide();
            student_Dashboard.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string skillname = textBox1.Text;

            string query1 = "SELECT max(skill_id) FROM SKILL";
            SqlCommand cm = new SqlCommand(query1, conn);

            int skillId = (int)cm.ExecuteScalar() + 1;
            cm.Dispose();

            string query2 = "INSERT INTO SKILL (skill_id, skill_name,skill_level) VALUES (@skillId, @skillname,'Intermediate')";
            SqlCommand cm2 = new SqlCommand(query2, conn);
            cm2.Parameters.AddWithValue("@skillId", skillId);
            cm2.Parameters.AddWithValue("@skillname", skillname);
            cm2.ExecuteNonQuery();
            cm2.Dispose();

            string query3 = "INSERT INTO STUDENT_SKILLS (student_id, skill_id) VALUES (@studentId, @skillId)";
            SqlCommand cm3 = new SqlCommand(query3, conn);
            cm3.Parameters.AddWithValue("@studentId", student_dashboard.getUserId());
            cm3.Parameters.AddWithValue("@skillId", skillId);
            cm3.ExecuteNonQuery();
            cm3.Dispose();

            MessageBox.Show("Skill Added Successfully");

            student_skill_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sKILLTableAdapter.Fill(this.job_FairDataSet.SKILL);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
