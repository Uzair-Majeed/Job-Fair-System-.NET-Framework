using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//added this to add the functionality of posting a job,belongs to recruiter dashboard
//will commit

namespace WindowsFormsApp1
{
    public partial class Post_Job : Form
    {
        public Post_Job()
        {
            InitializeComponent();

            comboBox1.Items.Add("Full-Time");
            comboBox1.Items.Add("Internship");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
