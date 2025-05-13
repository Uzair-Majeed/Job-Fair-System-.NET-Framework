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
    public partial class TPO_booth_checkin : Form
    {
        public TPO_booth_checkin()
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
        private void loadTPOBOOTH() {
            using (SqlConnection con = new SqlConnection(SessionData.ijtabastring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    @"select bc.booth_ID[booth #],JFE.title[Event Name],u.Name[Coordinator Name],bt.booth_Traffic[Traffic] from BOOTH_CHECKIN bc join JOB_FAIR_EVENTS JFE on bc.eventID=JFE.eventID join BOOTH_TRACKING BT on bt.booth_ID=bc.booth_ID join users u on bt.coordinator_ID=u.user_ID
order by bt.booth_Traffic desc", con); // Adjust fields/table names

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void TPO_booth_checkin_Load(object sender, EventArgs e)
        {

            loadTPOBOOTH();
            // TODO: This line of code loads data into the 'job_FairDataSet1.BOOTH_CHECKIN' table. You can move, or remove it, as needed.
            //this.bOOTH_CHECKINTableAdapter.Fill(this.job_FairDataSet1.BOOTH_CHECKIN);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            REPORT_Interface rEPORT_Interface = new REPORT_Interface();
            this.Hide();
            rEPORT_Interface.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User_Manage user_Manage = new User_Manage();
            this.Hide();
            user_Manage.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            approve_reject approve_Reject = new approve_reject();
            this.Hide();
            approve_Reject.Show();
        }
    }
}
