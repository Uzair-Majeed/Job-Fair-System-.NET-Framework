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
    public partial class REPORT_Interface : Form
    {
        public REPORT_Interface()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TPO_dashboard tPO_Dashboard = new TPO_dashboard();
            tPO_Dashboard.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dep_count dep_Reg_Count = new dep_count();
            dep_Reg_Count.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GPA_distribution gPA_Distribution = new GPA_distribution();
            gPA_Distribution.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            top_skills top_Skills = new top_skills();
            top_Skills.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total_interviews_per_company total_Interviews_Per_Company = new total_interviews_per_company();
            total_Interviews_Per_Company.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            acceptRatio accept_Ratio = new acceptRatio();
            accept_Ratio.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            student_ratings student_Ratings = new student_ratings();
            student_Ratings.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            overall_placements overall_Placements = new overall_placements();
            overall_Placements.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            placement_per_dep placement_Per_Dep = new placement_per_dep();
            placement_Per_Dep.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            avg_sal avg_Sal = new avg_sal();
            avg_Sal.Show();
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {

            booth_traff booth_Traff = new booth_traff();
            booth_Traff.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            peak_hours peak_Hours = new peak_hours();
            peak_Hours.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            resource_usage resource_Usage = new resource_usage();
            resource_Usage.Show();
            this.Hide();
        }
    }
}
