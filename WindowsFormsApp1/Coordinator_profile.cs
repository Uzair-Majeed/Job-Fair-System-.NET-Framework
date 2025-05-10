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
    public partial class Coordinator_profile : Form
    {

        private int userId;
        private string userName;
        private string email;
        private string password;
        public Coordinator_profile()
        {
            InitializeComponent();
        }

        public Coordinator_profile(int user_id, string name, string em, string pass)
        {

            InitializeComponent();
            this.userId = user_id;
            this.userName = name;
            this.email = em;
            this.password = pass;


            textBox5.Text = userName;        // Name
            textBox4.Text = email;           // Email
            maskedTextBox1.Text = password;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Coordinator_dashboard coordinator_Dashboard = new Coordinator_dashboard(userId,userName,email,password);
            this.Hide();
            coordinator_Dashboard.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            boothTraffic boothTraffic = new boothTraffic();
            this.Hide();
            boothTraffic.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coord_booth coord_Booth = new coord_booth();
            this.Hide();
            coord_Booth.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coordinator_profile profile = new Coordinator_profile(userId, userName, email, password);
            this.Hide();
            profile.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coordinator_verify_std coordinator_Verify_Std = new coordinator_verify_std();
            this.Hide();
            coordinator_Verify_Std.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True"); //Connection String
            conn.Open();
            string newEm = textBox8.Text;
            string newName = textBox7.Text;
            string newPass = textBox3.Text;
            string reconfirm = textBox2.Text;

            if (newPass != reconfirm)
            {
                MessageBox.Show("Password does not match");
                return;
            }

            email = newEm;
            userName = newName;
            password = newPass;


            SessionData.password = password;
            SessionData.email = email;
            SessionData.UserName = userName;

            string query = "UPDATE Users SET Name = @name, Password = @password WHERE user_id = @userId";
            string query2 = "UPDATE user_email SET email = @email WHERE user_id = @userId";

            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@name", userName);
            cm.Parameters.AddWithValue("@password", password);
            cm.Parameters.AddWithValue("@userId", userId);

            cm.ExecuteNonQuery();
            cm.Dispose();

            SqlCommand cm2 = new SqlCommand(query2, conn);
            cm2.Parameters.AddWithValue("@email", email);
            cm2.Parameters.AddWithValue("@userId", userId);

            cm2.ExecuteNonQuery();
            cm2.Dispose();
            conn.Close();

            MessageBox.Show("Profile Updated successfully,\nReload to see changes");
        }
    }
}
