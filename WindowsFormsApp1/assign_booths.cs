﻿using System;
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
    public partial class assign_booths : Form
    {
        string connectionString = SessionData.ijtabastring;
        public assign_booths()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TPO_dashboard tpo_Dashboard = new TPO_dashboard();
            this.Hide();
            tpo_Dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tpo_Profile profile = new Tpo_Profile();
            this.Hide();
            profile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manage_jobfairs manage_Jobfairs = new manage_jobfairs();
            this.Hide();
            manage_Jobfairs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            assign_booths assign_Booths = new assign_booths();
            this.Hide();
            assign_Booths.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TPO_booth_checkin tPO_Booth_Checkin = new TPO_booth_checkin();
            this.Hide();
            tPO_Booth_Checkin.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void LoadEventNames()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Title FROM JOB_FAIR_EVENTS", con); // Example
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Title"].ToString());
                }
            }
        }

        private void LoadCoordinators()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select name from users where role='Coordinator'", con); // Example
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox3.Items.Add(reader["Name"].ToString());
                }
            }
        }

        private void LoadCompanies()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name as [CompanyName] FROM COMPANY", con); // Example
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["CompanyName"].ToString());
                }
            }
        }
        private void LoadBoothAssignments()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT e.title AS [Event Title], 
                     u.Name AS [Coordinator], 
                     com.Name AS [Company], 
                     b.booth_id AS [Booth #]
              FROM BOOTH_ASSIGNMENT b
			  INNER JOIN BOOTH bo on bo.booth_ID=b.booth_ID
              INNER JOIN JOB_FAIR_EVENTS e ON bo.EventId = e.eventid
              INNER JOIN COMPANY com ON b.booth_id = com.company_Id
              INNER JOIN BOOTH_TRACKING BR on b.booth_id=BR.booth_id
              INNER JOIN USERS u ON BR.COORDINATOR_ID=u.User_id ", con); // Adjust fields/table names

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void assign_booths_Load(object sender, EventArgs e)
        {
            LoadEventNames();
            LoadCoordinators();
            LoadCompanies();
            LoadBoothAssignments(); // Load DataGridView
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //event name combo box 
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //coordinator combo box
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //company combo box
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectedEvent = comboBox1.SelectedItem?.ToString();
            string selectedCoordinator = comboBox3.SelectedItem?.ToString();
            string selectedCompany = comboBox2.SelectedItem?.ToString();
            int tpoid = SessionData.UserId;

            if (string.IsNullOrEmpty(selectedEvent) || string.IsNullOrEmpty(selectedCoordinator) || string.IsNullOrEmpty(selectedCompany))
            {
                MessageBox.Show("Please select all fields before assigning a booth.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO BOOTH_ASSIGNMENTS (TPO_ID,EventName, CoordinatorName, CompanyName) VALUES (@tpo_id,@event, @coordinator, @company)", con); // Complete this
                //cmd.Parameters.AddWithValue("@tpo_id", tpoid);
                //cmd.Parameters.AddWithValue("@event", selectedEvent);
                //cmd.Parameters.AddWithValue("@coordinator", selectedCoordinator);
                //cmd.Parameters.AddWithValue("@company", selectedCompany);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Booth assigned successfully!");

                LoadBoothAssignments(); // Refresh DataGridView
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            approve_reject approve_Reject = new approve_reject();
            this.Hide();
            approve_Reject.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User_Manage user_Manage = new User_Manage();
            this.Hide();
            user_Manage.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            REPORT_Interface rEPORT_Interface = new REPORT_Interface();
            this.Hide();
            rEPORT_Interface.Show();
        }
    }
}
