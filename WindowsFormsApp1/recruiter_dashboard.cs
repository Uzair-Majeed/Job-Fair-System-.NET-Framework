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
    public partial class recruiter_dashboard : Form
    {
        public recruiter_dashboard()
        {
            InitializeComponent();
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

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
