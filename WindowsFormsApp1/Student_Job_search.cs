using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Student_Job_search : Form
    {
        public string filter;
        int applyTo;
        public Student_Job_search()
        {
            InitializeComponent();
            comboBox1.Text = "NONE";
            comboBox2.Text = "NONE";
            comboBox3.Text = "NONE";
            comboBox4.Text = "NONE";

            initializeComboBoxes();
            this.filter = "";
            this.applyTo = -1;
        }
        private void initializeComboBoxes()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();
            string combo2 = "SELECT DISTINCT Salary_Range as Salary_Range,CAST(SUBSTRING(Salary_Range, 4, CHARINDEX(',', Salary_Range) - 4) AS INT) AS Salary FROM JOB_POSTING ORDER BY Salary;";
            SqlCommand cmd2 = new SqlCommand(combo2, conn);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                string skillName = reader2["Salary_Range"].ToString();
                comboBox2.Items.Add(skillName);
            }

            reader2.Close();

            cmd2.Dispose();

            string combo3 = "SELECT distinct location_Preferences as location_Preferences FROM JOB_POSTING";
            SqlCommand cmd3 = new SqlCommand(combo3, conn);
            SqlDataReader reader3 = cmd3.ExecuteReader();

            while (reader3.Read())
            {
                string skillName = reader3["location_Preferences"].ToString();
                comboBox3.Items.Add(skillName);
            }

            reader3.Close();

            cmd3.Dispose();

            string combo4 = "SELECT distinct s.skill_name as skill_name FROM SKILL s JOIN JOB_SKILLS js on js.skill_ID = s.skill_ID JOIN JOB_POSTING j on j.job_ID = js.job_ID";
            SqlCommand cmd4 = new SqlCommand(combo4, conn);
            SqlDataReader reader4 = cmd4.ExecuteReader();

            while (reader4.Read())
            {
                string skillName = reader4["skill_name"].ToString();
                comboBox4.Items.Add(skillName);
            }

            reader4.Close();

            cmd4.Dispose();
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            student_dashboard student_Dashboard = new student_dashboard(SessionData.UserId, SessionData.UserName, SessionData.email, SessionData.password); this.Hide();
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
            student_Application.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Student_Job_search_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string query = @"SELECT 
                            JP.job_id AS ID,
                            JP.Title AS Job_Title,
                            JP.job_type AS Job_Type,
                            JP.description AS Job_Description,
                            JP.salary_Range AS Salary_Range,
                            JP.location_Preferences AS Location_Preferences,
                            JP.deadline AS Deadline,
                            C.Name AS Company_Name,
                            U.Name AS Recruiter_Name,
                            S.skill_Name AS Required_Skill
                            FROM JOB_POSTING JP
                            JOIN COMPANY C ON JP.company_ID = C.company_ID
                            JOIN RECRUITER R ON JP.recruiter_ID = R.recruiter_ID
                            JOIN USERS U ON R.recruiter_ID = U.user_ID
                            LEFT JOIN JOB_SKILLS JS ON JP.job_ID = JS.job_ID
                            LEFT JOIN SKILL S ON JS.skill_ID = S.skill_ID ";
            query += filter;
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            cmd.Dispose();

            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string job_type = comboBox1.Text;
            string sal = comboBox2.Text;
            string location = comboBox3.Text;
            string skillName = comboBox4.Text;
            string subquery = " WHERE ";

            
            if (job_type != "NONE")
            {
                 subquery += " JP.job_type = '" + job_type + "'";

            }

            if (sal != "NONE")
            {
                if (job_type != "NONE") subquery += " AND";

               
               subquery += " JP.salary_Range = '" + sal + "'";


            }

            if (location != "NONE")
            {

                if (job_type != "NONE" || sal != "NONE") subquery += " AND";
                subquery += " JP.location_Preferences = '" + location + "'";

            }

            if (skillName != "NONE")
            {

                if (job_type != "NONE" || sal != "NONE" || location != "NONE") subquery += " AND";
                subquery += " S.skill_name = '" + skillName + "'";

            }

            if(job_type == "NONE" && sal == "NONE" && location == "NONE" && skillName == "NONE")
            {
                subquery = "";
            }

            filter = subquery;



            Student_Job_search_Load(sender, e);
            conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                applyTo = (int) row.Cells["ID"].Value;
                MessageBox.Show("Click on apply button to apply!");

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if(applyTo == -1)
            {
                MessageBox.Show("Select a JOB Title to apply!!"); return;
            }

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string q = "select max(application_id) from application";
            SqlCommand cm = new SqlCommand(q, conn);
            int app_id = (int)cm.ExecuteScalar() + 1;

            string q2 = "select recruiter_id from JOB_POSTING where job_id = @applyTo";
            SqlCommand cm2 = new SqlCommand(q2, conn);
            cm2.Parameters.AddWithValue("@applyTo", applyTo);
            int r_id = (int)cm2.ExecuteScalar();

            string q3 = @"INSERT INTO APPLICATION(application_id,status,applied_Date,applicant_ID,job_ID,recruiter_ID)
                        VALUES(@app_id,'Pending',GETDATE(),@student_ID,@applyTo,@r_ID)";
            SqlCommand cm3 = new SqlCommand(q3, conn);
            cm3.Parameters.AddWithValue("@app_id", app_id);
            cm3.Parameters.AddWithValue("@student_id", student_dashboard.getUserId());
            cm3.Parameters.AddWithValue("@r_ID", r_id);
            cm3.Parameters.AddWithValue("@applyTo", applyTo);
            cm3.ExecuteNonQuery();

            cm.Dispose();
            cm2.Dispose();
            cm3.Dispose();

            conn.Close();

            MessageBox.Show("Application submitted successfully!");
            applyTo = -1;
        }
    }
}
