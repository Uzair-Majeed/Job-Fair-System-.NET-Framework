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
    public partial class Coordinator_dashboard : Form
    {
        private int userId;
        private string userName;
        private string email;
        private string password;

        public Coordinator_dashboard()
        {

            InitializeComponent();
        }
        public Coordinator_dashboard(int user_id, string name, string em, string pass)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coordinator_profile profile = new Coordinator_profile(userId, userName, email, password);
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
    }
}
