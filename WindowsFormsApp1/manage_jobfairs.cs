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
    public partial class manage_jobfairs : Form
    {
        public manage_jobfairs()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TPO_dashboard tpo_Dashboard = new TPO_dashboard();
            this.Hide();
            tpo_Dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tpo_Profile profile = new Tpo_Profile();
            this.Hide();
            profile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manage_jobfairs manage_Jobfairs = new manage_jobfairs();
            this.Hide();
            manage_Jobfairs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            assign_booths assign_Booths = new assign_booths();
            this.Hide();
            assign_Booths.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TPO_booth_checkin tPO_Booth_Checkin = new TPO_booth_checkin();
            this.Hide();
            tPO_Booth_Checkin.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Read input values
            string eventName = textBox2.Text;
            DateTime date = dateTimePicker1.Value;
            string venue = textBox1.Text;
            string staff = textBox3.Text;
            int userid = SessionData.UserId;

            // Connection string
            string connectionString = SessionData.ijtabastring;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Step 1: Get max EventID
                    int newEventID = 1; // default if table is empty
                    string getMaxIdQuery = "SELECT ISNULL(MAX(EventID), 0) + 1 FROM Job_Fair_Events";
                    using (SqlCommand getMaxCmd = new SqlCommand(getMaxIdQuery, conn))
                    {
                        newEventID = (int)getMaxCmd.ExecuteScalar();
                    }

                    // Step 2: Insert new record
                    string query = "INSERT INTO Job_Fair_Events (EventID, title, Date, venue_location, Staff, scheduler_id) " +
                                   "VALUES (@EventID, @EventTitle, @Date, @Venue, @Staff, @userid)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EventID", newEventID);
                        cmd.Parameters.AddWithValue("@EventTitle", eventName);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Venue", venue);
                        cmd.Parameters.AddWithValue("@Staff", staff);
                        cmd.Parameters.AddWithValue("@userid", userid);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event scheduled successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to schedule event.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            manage_jobfairs_Load(sender, e);
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void manage_jobfairs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'job_FairDataSet1.JOB_FAIR_EVENTS' table. You can move, or remove it, as needed.
            //this.jOB_FAIR_EVENTSTableAdapter1.Fill(this.job_FairDataSet.JOB_FAIR_EVENTS);
  
            this.jOB_FAIR_EVENTSTableAdapter.Fill(this.job_FairDataSet.JOB_FAIR_EVENTS);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            approve_reject approve_Reject = new approve_reject();
            this.Hide();
            approve_Reject.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User_Manage user_Manage = new User_Manage();
            this.Hide();

            user_Manage.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            REPORT_Interface rEPORT_Interface = new REPORT_Interface();
            this.Hide();
            rEPORT_Interface.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
