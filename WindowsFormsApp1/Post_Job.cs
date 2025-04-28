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
    }
}
