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
    public partial class Hiring : Form
    {
        public Hiring()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hiring_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string query = @"SELECT
                            I.interview_ID AS Interview_ID,
                            U.name AS Applicant_Name,
                            E.title AS Event_Name,
                            jp.title AS Job_Title,
                            I.timeslot AS Time_Slot,
                            I.status AS Status
                            ,CASE 
                            WHEN I.isHired = 1 THEN 'Hired'
                            ELSE 'Not Hired'
                            END AS Hiring_Status
                            FROM INTERVIEWS I
                            JOIN USERS U ON I.student_ID = U.user_ID
                            JOIN JOB_FAIR_EVENTS E ON I.eventID = E.eventID
                            JOIN APPLICATION A ON A.applicant_ID = I.student_ID AND A.recruiter_ID = I.recruiter_ID
                            JOIN JOB_POSTING JP ON A.job_ID = JP.job_ID     
                            WHERE I.recruiter_ID = @recruiterID AND A.status = 'Accepted' AND I.status = 'Completed'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@recruiterID", SessionData.UserId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            cmd.Dispose();

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int interviewId = Convert.ToInt32(row.Cells["Interview_ID"].Value);
                string applicantName = row.Cells["Applicant_Name"].Value.ToString();

                DialogResult result = MessageBox.Show("Hire the applicant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
                    conn.Open();

                    string updateQuery = "UPDATE INTERVIEWS SET isHired = 1 WHERE interview_ID = @interviewID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@interviewID", interviewId);
                    updateCmd.ExecuteNonQuery();

                    Hiring_Load(sender,e);
                    updateCmd.Dispose();
                    conn.Close();
                    MessageBox.Show($"Applicant '{applicantName}' has been hired successfully.");
                }
                else
                {
                    MessageBox.Show($"Applicant '{applicantName}' Rejected!.");
                }


            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TPO_dashboard tpo_Dashboard = new TPO_dashboard();
            this.Hide();
            tpo_Dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recruiter_profile recruiter_Profile = new recruiter_profile();
            this.Hide();
            recruiter_Profile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Post_Job post_Job = new Post_Job();
            this.Hide();

            post_Job.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Review_Application review_Application = new Review_Application();
            this.Hide();
            review_Application.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            recruiter_interviews recruiter_Interviews = new recruiter_interviews();
            this.Hide();
            recruiter_Interviews.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Hiring hiring = new Hiring();
            hiring.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manage_companies manage_Companies = new manage_companies();
            this.Hide();
            manage_Companies.Show();
        }
    }
}
