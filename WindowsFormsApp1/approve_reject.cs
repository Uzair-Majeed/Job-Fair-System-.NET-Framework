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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class approve_reject : Form
    {
        public approve_reject()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int user_Id = Convert.ToInt32(row.Cells["UserID"].Value);
                string userName = row.Cells["UserName"].Value.ToString();

                DialogResult result = MessageBox.Show("Do you want to approve this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True"))
                {
                    conn.Open();

                    if (result == DialogResult.Yes)
                    {
                        string updateStudent = "UPDATE STUDENT SET isApproved = 1 WHERE student_ID = @userId";
                        string updateRecruiter = "UPDATE RECRUITER SET isApproved = 1 WHERE recruiter_ID = @userId";

                        SqlCommand cmd1 = new SqlCommand(updateStudent, conn);
                        cmd1.Parameters.AddWithValue("@userId", user_Id);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();

                        SqlCommand cmd2 = new SqlCommand(updateRecruiter, conn);
                        cmd2.Parameters.AddWithValue("@userId", user_Id);
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();

                        MessageBox.Show("User: " + userName + " Approved!");
                    }
                    else
                    {
                        string deleteStudent = "DELETE FROM STUDENT WHERE student_ID = @userId";
                        string deleteRecruiter = "DELETE FROM RECRUITER WHERE recruiter_ID = @userId";
                        string deleteEmail = "DELETE FROM USER_EMAIL WHERE user_id = @userId";
                        string deleteUser = "DELETE FROM USERS WHERE user_ID = @userId";

                        SqlCommand cmd1 = new SqlCommand(deleteStudent, conn);
                        cmd1.Parameters.AddWithValue("@userId", user_Id);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();

                        SqlCommand cmd2 = new SqlCommand(deleteRecruiter, conn);
                        cmd2.Parameters.AddWithValue("@userId", user_Id);
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();

                        SqlCommand cmd3 = new SqlCommand(deleteEmail, conn);
                        cmd3.Parameters.AddWithValue("@userId", user_Id);
                        cmd3.ExecuteNonQuery();
                        cmd3.Dispose();

                        SqlCommand cmd4 = new SqlCommand(deleteUser, conn);
                        cmd4.Parameters.AddWithValue("@userId", user_Id);
                        cmd4.ExecuteNonQuery();
                        cmd4.Dispose();

                        MessageBox.Show("User: " + userName + " Rejected and removed!");
                    }

                    approve_reject_Load(sender, e);
                    conn.Close();
                }
            }

        }

        private void approve_reject_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MHBH552\\SQLEXPRESS;Initial Catalog=Job_Fair;Integrated Security=True");
            conn.Open();


            string query = @"SELECT 
                            u.user_ID AS UserID,
                            u.Name AS UserName,
                             u.Password,
                             ue.email AS Email,
                            u.Role,
                            'Pending Approval' AS Approval_Status
                            FROM USERS u
                            JOIN STUDENT s ON u.user_ID = s.student_ID
                            JOIN USER_email ue ON u.user_ID = ue.user_ID
                            WHERE s.isApproved = 0

                            UNION
                            
                            SELECT 
                                u.user_ID AS UserID,
                                u.Name AS UserName,
                                u.Password,
                                ue.email AS Email,
                                u.Role,
                                'Pending Approval' AS Approval_Status
                            FROM USERS u
                            JOIN RECRUITER r ON u.user_ID = r.recruiter_ID
                            JOIN USER_email ue ON u.user_ID = ue.user_ID
                            WHERE r.isApproved = 0;";

            SqlCommand cmd = new SqlCommand(query, conn);


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            cmd.Dispose();
            conn.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            TPO_dashboard tpo_Dashboard = new TPO_dashboard();
            this.Hide();
            tpo_Dashboard.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
