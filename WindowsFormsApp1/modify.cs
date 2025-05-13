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
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace WindowsFormsApp1
{
    public partial class modify : Form
    {
        public int userID;
        public modify(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void modify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'job_FairDataSet.COMPANY' table. You can move, or remove it, as needed.
            this.cOMPANYTableAdapter.Fill(this.job_FairDataSet.COMPANY);




        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");

            conn.Open();

            string name = textBox7.Text.ToString();
            string email = textBox8.Text.ToString();
            string pass = textBox1.Text.ToString();
            string company = comboBox2.Text.ToString();


            string query = "UPDATE users SET name = @name WHERE user_id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", userID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            string query2 = "UPDATE user_email SET email = @email WHERE user_id = @id";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@email", email);
            cmd2.Parameters.AddWithValue("@id", userID);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();

            string query3 = "UPDATE users SET password = @name WHERE user_id = @id";
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            cmd3.Parameters.AddWithValue("@name", pass);
            cmd3.Parameters.AddWithValue("@id", userID);
            cmd3.ExecuteNonQuery();
            cmd3.Dispose();

            string query4 = "UPDATE recruiter SET company_id = (SELECT company_ID FROM COMPANY WHERE name = @company) WHERE recruiter_id = @id";
            SqlCommand cmd4 = new SqlCommand(query4, conn);
            cmd4.Parameters.AddWithValue("@company", company);
            cmd4.Parameters.AddWithValue("@id", userID);


            conn.Close();
            MessageBox.Show("User details have been updated successfully!");

            User_Manage user_Manage = new User_Manage();
            user_Manage.Show();
            this.Hide();
        }
    }
}
