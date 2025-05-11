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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static WindowsFormsApp1.Job_FairDataSet;

//added data grid for interviews.
namespace WindowsFormsApp1
{
    public partial class recruiter_interviews : Form
    {


        int interviewID;
        string eventTitle;
        DateTime timeslot;
        string status;
        string appName;
        string filter;
        public recruiter_interviews()
        {
            InitializeComponent();



            comboBox2.Text = "NONE";
            filter = "";
            interviewID = -1;
            eventTitle = "";
            timeslot = DateTime.Now;
            status = "";
            appName = "";

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                interviewID = (int)row.Cells["Interview_ID"].Value;
                appName = row.Cells["Applicant_Name"].Value.ToString();
                eventTitle = row.Cells["Event_Name"].Value.ToString();
                status = row.Cells["Status"].Value.ToString();
                timeslot = (DateTime)row.Cells["Time_Slot"].Value;
                MessageBox.Show("Click on Schedule button!");

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void recruiter_interviews_Load(object sender, EventArgs e)
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
                            FROM INTERVIEWS I
                            JOIN USERS U ON I.student_ID = U.user_ID
                            JOIN JOB_FAIR_EVENTS E ON I.eventID = E.eventID
                            JOIN APPLICATION A ON A.applicant_ID = I.student_ID AND A.recruiter_ID = I.recruiter_ID
                            JOIN JOB_POSTING JP ON A.job_ID = JP.job_ID     
                            WHERE I.recruiter_ID = @recruiterID AND A.status = 'Accepted' ";
            query += filter;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@recruiterID", SessionData.UserId);

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

            string status = comboBox2.Text;
            string subquery = " ";


            if (status != "NONE")
            {


                subquery += " AND I.status = '" + status + "'";


            }

            if (status == "NONE")
            {
                subquery = "";
            }

            filter = subquery;


            recruiter_interviews_Load(sender, e);
            conn.Close();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (interviewID == -1)
            {
                MessageBox.Show("Select an Interview First!!"); return;
            }

            recruiter_interview2 review = new recruiter_interview2(interviewID, eventTitle, timeslot, status, appName);
            this.Hide();
            review.Show();

        }
    }
}
