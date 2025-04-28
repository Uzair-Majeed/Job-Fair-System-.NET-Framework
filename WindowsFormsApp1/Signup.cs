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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("TPO");
            comboBox1.Items.Add("Recruiter");
            comboBox1.Items.Add("Coordinator");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("BYE BYE!!!");
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True"); //Connection String
            conn.Open();
            MessageBox.Show("Connection Open");
            SqlCommand cm;

            string name = textBox1.Text;
            string email = textBox2.Text;
            string pass = textBox3.Text;
            string role = comboBox1.Text;

            string query1 = "select MAX(user_ID) From Users";
            cm = new SqlCommand(query1, conn);

            int user_id = (int)cm.ExecuteScalar();

            cm.Dispose();
            user_id.ToString();

            string query2 = "insert into USERS(user_id,password,role,name) values ('" + user_id + "','" + pass + "','" + role + "','" + name + "')";

            cm = new SqlCommand(query2, conn);
            cm.Dispose();

            string query3 = "insert into USER_Email(email,user_id) values('" + email + "','" + user_id + "')";

            cm = new SqlCommand(query3, conn);

            MessageBox.Show("SIGNUP SUCCESSFULL !!");
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
