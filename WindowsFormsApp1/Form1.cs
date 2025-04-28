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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True"); //Connection String
            conn.Open();
            MessageBox.Show("Connection Open");
            string em = textBox1.Text;
            string pass = textBox2.Text;

            string query = "SELECT COUNT(*) FROM user_email e JOIN Users u on u.user_id = e.user_id WHERE e.email = @email AND u.password = @password";

            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@email", em);
            cm.Parameters.AddWithValue("@password", pass);

            int result = (int)cm.ExecuteScalar(); // Get the count result

            if (result > 0)
            {
                MessageBox.Show("Login Successful!");


            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }

            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("BYE BYE!!!");
            Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show(); 
            this.Hide();
        }
    }
}
