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
    public partial class recruiter_profile : Form
    {

        private int userId;
        private string userName;
        private string email;
        private string password;
        private string companyName;

        public recruiter_profile(int user_id, string name, string em, string pass, string companyName)
        {

            InitializeComponent();
            this.userId = user_id;
            this.userName = name;
            this.email = em;
            this.password = pass;
            this.companyName = companyName;

            textBox5.Text = userName;        // Name
            textBox4.Text = email;           // Email
            maskedTextBox1.Text = password;
            textBox1.Text = companyName;

        }
        public recruiter_profile()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            recruiter_dashboard recruiter_Dashboard = new recruiter_dashboard(userId, userName, email, password, companyName);
            this.Hide();
            recruiter_Dashboard.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            recruiter_profile recruiter_Profile = new recruiter_profile(userId, userName, email, password, companyName);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();

            string newEm = textBox8.Text;
            string newName = textBox7.Text;
            string newPass = textBox3.Text;
            string reconfirm = textBox2.Text;
            string company = comboBox1.Text;

            if (newPass != reconfirm)
            {
                MessageBox.Show("Password does not match");
                return;
            }

            email = newEm;
            userName = newName;
            password = newPass;
            companyName = company;


            SessionData.password = password;
            SessionData.email = email;
            SessionData.UserName = userName;
            SessionData.companyName = companyName;

            string query = "UPDATE Users SET Name = @name, Password = @password WHERE user_id = @userId";
            string query2 = "UPDATE user_email SET email = @email WHERE user_id = @userId";
            string query3 = "UPDATE RECRUITER SET company_ID = (SELECT TOP 1 company_ID FROM COMPANY WHERE Name = @companyName) where recruiter_ID = @userId";
        
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

            SqlCommand cm3 = new SqlCommand(query3, conn);
            cm3.Parameters.AddWithValue("@companyName", companyName);
            cm3.Parameters.AddWithValue("@userId", userId);
            cm3.ExecuteNonQuery();
            cm3.Dispose();

            conn.Close();
            MessageBox.Show("Profile updated successfully.\nReload to see changes.");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void recruiter_profile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'job_FairDataSet.COMPANY' table. You can move, or remove it, as needed.
            this.cOMPANYTableAdapter.Fill(this.job_FairDataSet.COMPANY);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cOMPANYTableAdapter.FillBy(this.job_FairDataSet.COMPANY);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            companyName = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manage_companies manage_Companies = new manage_companies();
            this.Hide();
            manage_Companies.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hiring hiring = new Hiring();
            this.Hide();
            hiring.Show();
        }
    }
}
