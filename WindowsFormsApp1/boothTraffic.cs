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
    public partial class boothTraffic : Form
    {
        public boothTraffic()
        {
            InitializeComponent();
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
                    @"select bt.booth_ID[Booth #],u.Name[Coordinator name],bt.booth_Traffic[Booth traffic]   from BOOTH_TRACKING bt join users u on bt.coordinator_ID=u.user_ID", con); // Adjust fields/table names

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

        }
        private void boothTraffic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'job_FairDataSet1.BOOTH_TRACKING' table. You can move, or remove it, as needed.
            // this.bOOTH_TRACKINGTableAdapter.Fill(this.job_FairDataSet1.BOOTH_TRACKING);
            loadtablequery();
        }
    }
}
