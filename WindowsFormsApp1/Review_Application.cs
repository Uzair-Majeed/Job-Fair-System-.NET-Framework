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

//added data grid view as there can be many applications to be reviewed.
namespace WindowsFormsApp1
{
    public partial class Review_Application : Form
    {
        public int reviewId;
        public string reviewJob;
        public DateTime time;
        public string status;
        public string appName;
        public Review_Application()
        {
            InitializeComponent();
            reviewId = -1;
            reviewJob = "";
            time = DateTime.Now;
            status = "";
            appName = "";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                reviewId = (int)row.Cells["ID"].Value;
                reviewJob = row.Cells["Job_Title"].Value.ToString();
                appName = row.Cells["Applicant_Name"].Value.ToString();
                status = row.Cells["Status"].Value.ToString();
                time = (DateTime)row.Cells["Applied_Date"].Value;
                MessageBox.Show("Click on review button to review!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recruiter_dashboard recruiter_Dashboard = new recruiter_dashboard();
            this.Hide();
            recruiter_Dashboard.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            recruiter_profile recruiter_Profile = new recruiter_profile();
            this.Hide();
            recruiter_Profile.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Post_Job post_Job = new Post_Job();
            this.Hide();
            post_Job.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Review_Application review_Application = new Review_Application();
            this.Hide();
            review_Application.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            recruiter_interviews recruiter_Interviews = new recruiter_interviews();
            this.Hide();
            recruiter_Interviews.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Review_Application_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();


            string query = @"SELECT 
                            A.application_ID AS ID,     
                            JP.Title AS Job_Title,
                            U.Name AS Applicant_Name,
                            A.applied_date AS Applied_Date,
                            A.status AS Status
                            FROM APPLICATION A
                            JOIN JOB_POSTING JP ON A.job_ID = JP.job_ID
                            JOIN USERS U ON A.applicant_ID = U.user_ID
                            JOIN RECRUITER R ON R.recruiter_ID = A.recruiter_ID
                            WHERE R.recruiter_ID = @recruiterId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@recruiterId",SessionData.UserId);


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

        private void button1_Click(object sender, EventArgs e)
        {
            if (reviewId == -1)
            {
                MessageBox.Show("Select an Application to Review!!"); return;
            }

            ReviewApplication2 review = new ReviewApplication2(reviewId,reviewJob,time,status,appName);
            this.Hide();
            review.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            manage_companies manage_Companies = new manage_companies();
            this.Hide();
            manage_Companies.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hiring hiring = new Hiring();
            this.Hide();
            hiring.Show();
        }
    }
}
