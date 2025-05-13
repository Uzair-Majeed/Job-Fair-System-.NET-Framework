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
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class User_Manage : Form
    {
        public User_Manage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void User_Manage_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();
            string query = @"
                SELECT u.user_id AS [User ID], u.name AS [Name], u.role AS [Role], ue.email AS [Email]
                FROM users u
                JOIN user_email ue ON u.user_id = ue.user_id
                WHERE u.role <> 'TPO'";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void ModifyUser(int userId)
        {

            modify modifyUserForm = new modify(userId);
            modifyUserForm.Show();
            this.Hide();

        }

        private void DeactivateUser(int userId)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");

            conn.Open();
            string query = "DELETE FROM users WHERE user_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User deleted successfully.");
                

            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int userId = Convert.ToInt32(row.Cells["User ID"].Value);
                string userName = row.Cells["Name"].Value.ToString();

                DialogResult action = MessageBox.Show($"Modify(Yes) or deactivate(No) user '{userName}'?", "Choose Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                if (action == DialogResult.Yes) 
                {
                    
                    ModifyUser(userId);
                    
                }
                else if (action == DialogResult.No) 
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        DeactivateUser(userId);
                    }
                }

                User_Manage_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TPO_dashboard tpo_Dashboard = new TPO_dashboard();
            this.Hide();
            tpo_Dashboard.Show();
        }
    }
}
