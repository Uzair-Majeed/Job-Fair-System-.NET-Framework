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
    public partial class TPO_dashboard : Form
    {
        private int userId;
        private string userName;
        private string email;
        private string password;

        public TPO_dashboard()
        {

            InitializeComponent();
        }
        public TPO_dashboard(int user_id, string name, string em, string pass)
        {

            InitializeComponent();
            this.userId = user_id;
            this.userName = name;
            this.email = em;
            this.password = pass;


            SessionData.UserId = userId;
            SessionData.email = email;
            SessionData.password = password;
            SessionData.UserName = userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tpo_Profile profile = new Tpo_Profile(userId,userName,email,password);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            REPORT_Interface rEPORT_Interface = new REPORT_Interface();
            rEPORT_Interface.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GPA_distribution gPA_Distribution = new GPA_distribution();
            gPA_Distribution.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            top_skills top_Skills = new top_skills();
            top_Skills.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            approve_reject approve_Reject = new approve_reject();
            approve_Reject.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            User_Manage user_Manage = new User_Manage();
            user_Manage.Show();
            this.Hide();
        }
    }
}
