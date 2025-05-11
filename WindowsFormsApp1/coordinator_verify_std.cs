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
    public partial class coordinator_verify_std : Form
    {
        public coordinator_verify_std()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Coordinator_dashboard coordinator_Dashboard = new Coordinator_dashboard();
            this.Hide();
            coordinator_Dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coordinator_profile profile = new Coordinator_profile();
            this.Hide();
            profile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coord_booth coord_Booth = new coord_booth();
            this.Hide();
            coord_Booth.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coordinator_verify_std coordinator_Verify_Std = new coordinator_verify_std();
            this.Hide();
            coordinator_Verify_Std.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            boothTraffic boothTraffic = new boothTraffic();
            this.Hide();
            boothTraffic.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void loadtablequery() {
            using (SqlConnection con = new SqlConnection(SessionData.ijtabastring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    @"select  bc.booth_ID[Booth #],bc.checkIn_Time [check-in Time],bc.student_id [Student_id],u.Name[student Name] from  BOOTH_CHECKIN bc join users u on student_ID=u.user_ID order by bc.checkIn_Time desc", con); // Adjust fields/table names

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void coordinator_verify_std_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'job_FairDataSet1.BOOTH_CHECKIN' table. You can move, or remove it, as needed.
            // this.bOOTH_CHECKINTableAdapter.Fill(this.job_FairDataSet1.BOOTH_CHECKIN);
            loadtablequery();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string boothnum = textBox2.Text;
            string studentid = textBox1.Text;
            DateTime checkin = dateTimePicker1.Value;

            using (SqlConnection con = new SqlConnection(SessionData.ijtabastring))
            {
                con.Open();

                // 1. Check if student exists in STUDENT table
                SqlCommand checkStudentCmd = new SqlCommand("SELECT COUNT(*) FROM STUDENT WHERE Student_ID = @sid", con);
                checkStudentCmd.Parameters.AddWithValue("@sid", studentid);
                int studentExists = (int)checkStudentCmd.ExecuteScalar();

                if (studentExists == 0)
                {
                    MessageBox.Show("Student does not exist.");
                    return;
                }
                // 1. Check if student exists in STUDENT table
                SqlCommand checkboothCmd = new SqlCommand("SELECT COUNT(*) FROM booth WHERE booth_ID = @bid", con);
                checkboothCmd.Parameters.AddWithValue("@bid", boothnum);
                int boothdoesntexists = (int)checkboothCmd.ExecuteScalar();

                if (boothdoesntexists== 0)
                {
                    MessageBox.Show("booth does not exist.");
                    return;
                }

                // 2. Check if student already checked in
                SqlCommand checkDuplicateCmd = new SqlCommand("SELECT COUNT(*) FROM booth_checkin WHERE Student_ID = @sid", con);
                checkDuplicateCmd.Parameters.AddWithValue("@sid", studentid);
                int alreadyCheckedIn = (int)checkDuplicateCmd.ExecuteScalar();

                if (alreadyCheckedIn > 0)
                {
                    MessageBox.Show("Student has already checked in.");
                    return;
                }

                // 3. Insert into CHECKIN table
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO booth_CHECKIN (Student_ID, Booth_id, CheckIn_Time) VALUES (@sid, @booth, @checkin)", con);
                insertCmd.Parameters.AddWithValue("@sid", studentid);
                insertCmd.Parameters.AddWithValue("@booth", boothnum);
                insertCmd.Parameters.AddWithValue("@checkin", checkin);

                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Check-in successful!");
                }
                else
                {
                    MessageBox.Show("Check-in failed.");
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
