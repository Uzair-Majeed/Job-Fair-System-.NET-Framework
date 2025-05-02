using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class assign_booths : Form
    {
        public assign_booths()
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
    }
}
